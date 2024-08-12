using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class PilavYemek : Form
    {
        string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";

        public PilavYemek()
        {
            InitializeComponent();
        }

        private void PilavYemek_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MalzemeAdi FROM Malzemeler";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbMalzeme.Items.Add(reader["MalzemeAdi"].ToString());
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yemekAdi = txtYemekAdi.Text;
            string tarif = rtbTarif.Text;
            decimal porsiyonUcreti = 0; // Porsiyon ücretini hesaplamak için başlangıç değeri

            // Porsiyon ücretini burada hesaplayabilirsiniz. Örneğin:
            // Örnek olarak porsiyon ücretini sabit bir değer olarak alıyoruz.
            porsiyonUcreti = 10.00m; // Buradaki değeri gerektiğine göre değiştirebilirsiniz.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Yemek ekleme
                    string insertMenuQuery = "INSERT INTO Menu (YemekAdi, Tarif, PorsiyonUcreti) VALUES (@YemekAdi, @Tarif, @PorsiyonUcreti); SELECT SCOPE_IDENTITY();";
                    SqlCommand menuCmd = new SqlCommand(insertMenuQuery, connection, transaction);
                    menuCmd.Parameters.AddWithValue("@YemekAdi", yemekAdi);
                    menuCmd.Parameters.AddWithValue("@Tarif", tarif);
                    menuCmd.Parameters.AddWithValue("@PorsiyonUcreti", porsiyonUcreti);
                    int menuID = Convert.ToInt32(menuCmd.ExecuteScalar());

                    // Malzemeleri ekleme
                    foreach (var item in lstMalzemeler.Items)
                    {
                        string[] malzemeData = item.ToString().Split('-');
                        string malzemeAdi = malzemeData[0].Trim();
                        decimal miktar = decimal.Parse(malzemeData[1].Trim());

                        string malzemeIDQuery = "SELECT Id FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                        SqlCommand malzemeCmd = new SqlCommand(malzemeIDQuery, connection, transaction);
                        malzemeCmd.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        int malzemeID = Convert.ToInt32(malzemeCmd.ExecuteScalar());

                        string insertMenuMalzemeQuery = "INSERT INTO MenuMalzemeler (MenuID, MalzemeID, Miktar) VALUES (@MenuID, @MalzemeID, @Miktar)";
                        SqlCommand menuMalzemeCmd = new SqlCommand(insertMenuMalzemeQuery, connection, transaction);
                        menuMalzemeCmd.Parameters.AddWithValue("@MenuID", menuID);
                        menuMalzemeCmd.Parameters.AddWithValue("@MalzemeID", malzemeID);
                        menuMalzemeCmd.Parameters.AddWithValue("@Miktar", miktar);
                        menuMalzemeCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Yemek başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (cmbMalzeme.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir malzeme seçin.");
                return;
            }

            if (string.IsNullOrEmpty(txtMiktar.Text) || !decimal.TryParse(txtMiktar.Text, out decimal miktar))
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
                return;
            }

            string selectedMalzeme = cmbMalzeme.SelectedItem.ToString();
            lstMalzemeler.Items.Add($"{selectedMalzeme} - {miktar}");
        }
    }
}
