using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Proje_1
{
    public partial class menü : Form
    {
        string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";

        public menü()
        {
            InitializeComponent();
            dgvYemekler.CellClick += new DataGridViewCellEventHandler(dgvYemekler_CellClick);
        }

        private void menü_Load(object sender, EventArgs e)
        {
            LoadMenuData();
            AddTarifButtonColumn();
            AddMalzemeListesiButtonColumn();
            AddSilButtonColumn(); 
        }

        private void AddSilButtonColumn()
        {
            DataGridViewButtonColumn silButtonColumn = new DataGridViewButtonColumn();
            silButtonColumn.Name = "Sil";
            silButtonColumn.Text = "Sil";
            silButtonColumn.UseColumnTextForButtonValue = true;
            dgvYemekler.Columns.Add(silButtonColumn);
        }

        private void LoadMenuData()
        {
            try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = @"
                SELECT 
                    m.MenuID, 
                    m.YemekAdi,
                    m.PorsiyonUcreti
                FROM 
                    Menu m";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvYemekler.DataSource = dt;

            // Hide the MenuID column
            dgvYemekler.Columns["MenuID"].Visible = false;

            // Set column headers
            dgvYemekler.Columns["YemekAdi"].HeaderText = "Yemek Adı";

            // Check if "PorsiyonUcreti" column exists and remove it if found
            if (dt.Columns.Contains("PorsiyonUcreti"))
            {
                dgvYemekler.Columns["PorsiyonUcreti"].Visible = false;
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Veritabanı hatası: " + ex.Message);
    }
        }

      


        private void AddTarifButtonColumn()
        {
            DataGridViewButtonColumn tarifButtonColumn = new DataGridViewButtonColumn();
            tarifButtonColumn.Name = "Tarif";
            tarifButtonColumn.Text = "Tarife Bak";
            tarifButtonColumn.UseColumnTextForButtonValue = true;
            dgvYemekler.Columns.Add(tarifButtonColumn);
        }

        private void AddMalzemeListesiButtonColumn()
        {
            DataGridViewButtonColumn malzemeListesiButtonColumn = new DataGridViewButtonColumn();
            malzemeListesiButtonColumn.Name = "MalzemeListesi";
            malzemeListesiButtonColumn.Text = "Malzeme Listesi";
            malzemeListesiButtonColumn.UseColumnTextForButtonValue = true;
            dgvYemekler.Columns.Add(malzemeListesiButtonColumn);
        }

        private void dgvYemekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvYemekler.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex < dgvYemekler.Rows.Count - 1)
                {
                    DialogResult result = MessageBox.Show("Bu yemeği silmek istediğinizden emin misiniz?", "Yemek Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int selectedMenuID;
                        if (int.TryParse(dgvYemekler.Rows[e.RowIndex].Cells["MenuID"].Value?.ToString(), out selectedMenuID))
                        {
                            DeleteMenu(selectedMenuID);
                        }
                        else
                        {
                            MessageBox.Show("MenuID alınamadı.");
                        }
                    }
                }
                else
                {
                    int selectedMenuID;
                    if (int.TryParse(dgvYemekler.Rows[e.RowIndex].Cells["MenuID"].Value?.ToString(), out selectedMenuID))
                    {
                        ShowTarifAndMalzemeListesi(selectedMenuID);
                    }
                    else
                    {
                        MessageBox.Show("MenuID alınamadı.");
                    }
                }
            }
        }



        private void DeleteMenu(int menuID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Önce MenuMalzemeler tablosundan ilgili kayıtları sil
                    string deleteMenuMalzemelerQuery = "DELETE FROM MenuMalzemeler WHERE MenuID = @MenuID";
                    SqlCommand deleteMenuMalzemelerCmd = new SqlCommand(deleteMenuMalzemelerQuery, connection);
                    deleteMenuMalzemelerCmd.Parameters.AddWithValue("@MenuID", menuID);
                    deleteMenuMalzemelerCmd.ExecuteNonQuery();

                    // Sonra Menu tablosundan yemeği sil
                    string deleteMenuQuery = "DELETE FROM Menu WHERE MenuID = @MenuID";
                    SqlCommand deleteMenuCmd = new SqlCommand(deleteMenuQuery, connection);
                    deleteMenuCmd.Parameters.AddWithValue("@MenuID", menuID);
                    int rowsAffected = deleteMenuCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Yemek başarıyla silindi.");
                        LoadMenuData(); // Veritabanından yeniden yemekleri yükleme
                    }
                    else
                    {
                        MessageBox.Show("Yemek silinirken bir hata oluştu veya belirtilen MenuID bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }


        private void ShowTarifAndMalzemeListesi(int menuID)
        {
            string tarif = GetTarif(menuID);
            string malzemeListesi = GetMalzemeListesi(menuID);

            richTextBox1.Text = tarif;
            richTextBox2.Text = malzemeListesi;
        }

        private string GetTarif(int menuID)
        {
            string tarif = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Tarif FROM Menu WHERE MenuID = @MenuID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MenuID", menuID);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        tarif = result.ToString();
                    }
                    else
                    {
                        tarif = "Tarif bulunamadı veya tanımsız.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                tarif = "Tarif alınırken bir hata oluştu.";
            }

            return tarif;
        }

        private string GetMalzemeListesi(int menuID)
        {
            string malzemeListesi = "Malzeme Adı - Miktar\n";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    malz.MalzemeAdi, 
                    mm.Miktar 
                FROM 
                    MenuMalzemeler mm
                JOIN 
                    Malzemeler malz ON mm.MalzemeID = malz.Id
                WHERE 
                    mm.MenuID = @MenuID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MenuID", menuID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        malzemeListesi += $"{row["MalzemeAdi"]} - {row["Miktar"]}\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                malzemeListesi = "Malzeme listesi alınırken bir hata oluştu.";
            }

            return malzemeListesi;
        }


        private void btnYemekYap_Click(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
                return;
            }

            int selectedMenuID = Convert.ToInt32(dgvYemekler.SelectedRows[0].Cells["MenuID"].Value);
            int porsiyon = (int)numPorsiyon.Value;
            decimal toplamTutar = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Malzeme stok kontrolü
                    string malzemeQuery = "SELECT malz.Id AS MalzemeID, malz.MalzemeAdi, mm.Miktar, malz.Adet, malz.BirimFiyat " +
                      "FROM MenuMalzemeler mm " +
                      "JOIN Malzemeler malz ON mm.MalzemeID = malz.Id " +
                      "WHERE mm.MenuID = @MenuID";

                    SqlCommand malzemeCmd = new SqlCommand(malzemeQuery, connection, transaction);
                    malzemeCmd.Parameters.AddWithValue("@MenuID", selectedMenuID);

                    DataTable malzemeTable = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(malzemeCmd))
                    {
                        da.Fill(malzemeTable);
                    }

                    List<string> eksikMalzemeler = new List<string>();

                    foreach (DataRow row in malzemeTable.Rows)
                    {
                        string malzemeAdi = row["MalzemeAdi"].ToString();
                        decimal miktar = Convert.ToDecimal(row["Miktar"]) * porsiyon;
                        int mevcutAdet = Convert.ToInt32(row["Adet"]);
                        decimal birimFiyat = Convert.ToDecimal(row["BirimFiyat"]);

                        if (mevcutAdet < miktar)
                        {
                            eksikMalzemeler.Add($" Ürün: {malzemeAdi} \n miktarı eksik mevcut: {mevcutAdet} \n gereken: {miktar} \n ");
                        }
                        else
                        {
                            toplamTutar += miktar * birimFiyat;
                        }
                    }

                    if (eksikMalzemeler.Count > 0)
                    {
                        string eksikMalzemelerMsg = "Eksik Malzemeler:\n" + string.Join("\n", eksikMalzemeler);
                        MessageBox.Show(eksikMalzemelerMsg);
                        transaction.Rollback();
                        return;
                    }

                    // Stok güncelleme ve Gelir kaydı
                    foreach (DataRow row in malzemeTable.Rows)
                    {
                        int malzemeID = Convert.ToInt32(row["MalzemeID"]);
                        decimal miktar = Convert.ToDecimal(row["Miktar"]) * porsiyon;
                        int yeniAdet = Convert.ToInt32(row["Adet"]) - Convert.ToInt32(miktar);

                        string stokGuncelleQuery = "UPDATE Malzemeler SET Adet = @YeniAdet WHERE Id = @MalzemeID";
                        SqlCommand stokGuncelleCmd = new SqlCommand(stokGuncelleQuery, connection, transaction);
                        stokGuncelleCmd.Parameters.AddWithValue("@YeniAdet", yeniAdet);
                        stokGuncelleCmd.Parameters.AddWithValue("@MalzemeID", malzemeID);
                        stokGuncelleCmd.ExecuteNonQuery();
                    }

                    string gelirEkleQuery = "INSERT INTO GelirGider (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) " +
                        "VALUES ('Gider', @Tarih, 'Sipariş', @Tutar, @Aciklama)";
                    SqlCommand gelirEkleCmd = new SqlCommand(gelirEkleQuery, connection, transaction);
                    gelirEkleCmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    gelirEkleCmd.Parameters.AddWithValue("@Tutar", toplamTutar);
                    // Yemek adını Aciklama parametresine ekle
                    gelirEkleCmd.Parameters.AddWithValue("@Aciklama", $"{dgvYemekler.SelectedRows[0].Cells["YemekAdi"].Value} yemeğinin {porsiyon} porsiyon hazırlanış");
                    gelirEkleCmd.ExecuteNonQuery();


                    transaction.Commit();

                    MessageBox.Show("Yemek Yapıldı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yemek yapma sırasında hata: " + ex.Message);
                    transaction.Rollback();
                }
            }
        }
        private void dgvYemekler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
