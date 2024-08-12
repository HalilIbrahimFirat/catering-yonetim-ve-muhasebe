using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catring
{
    public partial class Form1 : Form
    {
        private Personel personel;
        private VeritabaniIslemleri veritabaniIslemleri;

        public Form1()
        {
            InitializeComponent();

            personel = new Personel();
            veritabaniIslemleri = new VeritabaniIslemleri("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True");

        }
        string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardan girişleri al
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text))
                    throw new Exception("Ad alanı boş olamaz.");
                personel.ad = txtAd.Text;

                if (string.IsNullOrEmpty(txtSoyad.Text))
                    throw new Exception("Soyad alanı boş olamaz.");
                personel.soyad = txtSoyad.Text;

                if (string.IsNullOrEmpty(txtAdres.Text))
                    throw new Exception("Adres alanı boş olamaz.");
                personel.adres = txtAdres.Text;

                personel.dogumTarihi = dateTimePicker1.Value;

                if (string.IsNullOrEmpty(txtTCNO.Text))
                {
                    throw new Exception("TC Kimlik Numarası alanı boş olamaz.");
                }

                if (txtTCNO.Text.Length != 11 || !double.TryParse(txtTCNO.Text, out double tcNo))
                {
                    throw new Exception("TC Kimlik Numarası 11 haneli bir sayı olmalıdır.");
                }
                personel.tcNo = tcNo;

                if (string.IsNullOrEmpty(txtTelNo.Text))
                {
                    throw new Exception("Telefon numarası alanı boş olamaz.");
                }

                if (txtTelNo.Text.Length != 11 || !double.TryParse(txtTelNo.Text, out double telNo))
                {
                    throw new Exception("Telefon numarası 11 haneli bir sayı olmalıdır.");
                }

                personel.telNo = telNo;

                if (string.IsNullOrEmpty(txtCalismaSaati.Text))
                    throw new Exception("Çalışma Saati alanı boş olamaz.");
                personel.calismaSaati = Convert.ToInt32(txtCalismaSaati.Text);

                if (string.IsNullOrEmpty(txtSaatBasiMaas.Text))
                    throw new Exception("Saat Başı Maaş alanı boş olamaz.");
                personel.SaatBaşıMaaş = Convert.ToDecimal(txtSaatBasiMaas.Text);

               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Calisanlar WHERE TcNo = @TcNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TcNo", tcNo);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new Exception("Bu TC Kimlik Numarası zaten mevcut.");
                    }
                }

                // Hatalar yoksa veritabanına personeli ekle
                veritabaniIslemleri.PersonelEkle(personel);

                

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string islemTipi = "Gider";
                        DateTime kayitTarihi = DateTime.Now;
                        DateTime maasGunu = dateTimePickerMaasTarihi.Value;

                        int calismaGunleri = (maasGunu - kayitTarihi).Days + 1;

                        decimal tutar = calismaGunleri * personel.calismaSaati * personel.SaatBaşıMaaş;
                        string gelirGiderTipi = "Personel Maaş";
                        string tarih = kayitTarihi.ToString("yyyy-MM-dd HH:mm:ss");
                        string aciklama = $"{personel.ad} {personel.soyad} maaş";

                        string query = "INSERT INTO [catring].[dbo].[GelirGider] (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) " +
                                       "VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IslemTipi", islemTipi);
                            command.Parameters.AddWithValue("@Tarih", tarih);
                            command.Parameters.AddWithValue("@GelirGiderTipi", gelirGiderTipi);
                            command.Parameters.AddWithValue("@Tutar", tutar);
                            command.Parameters.AddWithValue("@Aciklama", aciklama);

                            command.ExecuteNonQuery();
                        }
                    }
                

                // TextBox'ları temizle
                txtAd.Clear();
                txtSoyad.Clear();
                txtAdres.Clear();
                txtCalismaSaati.Clear();
                txtTCNO.Clear();
                txtTelNo.Clear();
                txtSaatBasiMaas.Clear();
                dateTimePicker1.Value = DateTime.Now;

                // DataGridView'i güncelle
                VerileriGetir();

                MessageBox.Show("Personel ve maaş başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde verileri getir ve ID sütununu gizle
            VerileriGetir();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void VerileriGetir()
        {
            // Veritabanından verileri çek ve DataGridView'e yükle
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM Calisanlar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Calisanlar");
                dataGridView1.DataSource = ds.Tables["Calisanlar"];
            }
            // DataGridView sütunlarını otomatik boyutlandır
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Sil()
        {
            // Seçili satırı sil
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Uyarı mesajı göster ve kullanıcı yanıtını kontrol et
                DialogResult dialogResult = MessageBox.Show("Veri silinecek. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int selectedPersonelID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                    using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                    {
                        connection.Open();
                        string query = "DELETE FROM Calisanlar WHERE ID = @PersonelID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PersonelID", selectedPersonelID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtCalismaSaati.Clear();
            txtSaatBasiMaas.Clear();
            txtTCNO.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Guncelle()
        {
            try
            {
                // Seçili satırı güncelle
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int selectedPersonelID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                    string yeniAd = txtAd.Text;
                    string yeniSoyad = txtSoyad.Text;
                    string yeniAdres = txtAdres.Text;
                    DateTime yeniDogumTarihi = dateTimePicker1.Value;
                    double yeniTcNo = Convert.ToDouble(txtTCNO.Text);
                    double yeniTelNo = Convert.ToDouble(txtTelNo.Text);
                    int yeniCalismaSaati = Convert.ToInt32(txtCalismaSaati.Text);
                    decimal yeniSaatBasiMaas = Convert.ToDecimal(txtSaatBasiMaas.Text);

                    // Önce eski çalışma saatini ve saat başı maaşı al
                    int eskiCalismaSaati = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["CalismaSaati"].Value);
                    decimal eskiSaatBasiMaas = Convert.ToDecimal(dataGridView1.Rows[selectedRowIndex].Cells["SaatBasiMaas"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Calisanlar SET Ad = @Ad, Soyad = @Soyad, Adres = @Adres, DogumTarihi = @DogumTarihi, TcNo = @TcNo, TelNo = @TelNo, CalismaSaati = @CalismaSaati, SaatBasiMaas = @SaatBasiMaas WHERE ID = @PersonelID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Ad", yeniAd);
                        command.Parameters.AddWithValue("@Soyad", yeniSoyad);
                        command.Parameters.AddWithValue("@Adres", yeniAdres);
                        command.Parameters.AddWithValue("@DogumTarihi", yeniDogumTarihi);
                        command.Parameters.AddWithValue("@TcNo", yeniTcNo);
                        command.Parameters.AddWithValue("@TelNo", yeniTelNo);
                        command.Parameters.AddWithValue("@CalismaSaati", yeniCalismaSaati);
                        command.Parameters.AddWithValue("@SaatBasiMaas", yeniSaatBasiMaas);
                        command.Parameters.AddWithValue("@PersonelID", selectedPersonelID);

                        command.ExecuteNonQuery();

                        // Eğer çalışma saati veya saat başı maaş değiştiyse, GelirGider tablosuna bu değişikliği kaydet
                        if (yeniCalismaSaati != eskiCalismaSaati || yeniSaatBasiMaas != eskiSaatBasiMaas)
                        {
                            // Gelir Gider tablosuna ekleme işlemi
                            string islemTipi = "Gider";
                            DateTime maasGunu = dateTimePickerMaasTarihi.Value;
                            DateTime kayitTarihi = DateTime.Now;
                            string gelirGiderTipi = "Personel Maaş";
                            string aciklama = $"{yeniAd} {yeniSoyad} maaş güncellemesi";

                            // Çalışma günlerini hesapla
                            int calismaGunleri = (maasGunu - kayitTarihi).Days + 1;

                            // Yeni maaş hesaplanması
                            decimal yeniToplamMaas = calismaGunleri * yeniCalismaSaati * yeniSaatBasiMaas * 30; // Günlük maaş * 30

                            // Tarih formatı
                            string tarih = kayitTarihi.ToString("yyyy-MM-dd HH:mm:ss");

                            // SQL komutu
                            query = "INSERT INTO [catring].[dbo].[GelirGider] (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) " +
                                    "VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)";

                            SqlCommand insertCommand = new SqlCommand(query, connection);
                            insertCommand.Parameters.AddWithValue("@IslemTipi", islemTipi);
                            insertCommand.Parameters.AddWithValue("@Tarih", tarih);
                            insertCommand.Parameters.AddWithValue("@GelirGiderTipi", gelirGiderTipi);
                            insertCommand.Parameters.AddWithValue("@Tutar", yeniToplamMaas);
                            insertCommand.Parameters.AddWithValue("@Aciklama", aciklama);

                            insertCommand.ExecuteNonQuery();

                            // Personel tablosundaki ToplamMaas güncellemesi
                            query = "UPDATE Calisanlar SET ToplamMaas = @ToplamMaas WHERE ID = @PersonelID";
                            SqlCommand updateToplamMaasCommand = new SqlCommand(query, connection);
                            updateToplamMaasCommand.Parameters.AddWithValue("@ToplamMaas", yeniToplamMaas);
                            updateToplamMaasCommand.Parameters.AddWithValue("@PersonelID", selectedPersonelID);
                            updateToplamMaasCommand.ExecuteNonQuery();
                        }
                    }

                    // TextBox'ları temizle
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtAdres.Clear();
                    txtCalismaSaati.Clear();
                    txtSaatBasiMaas.Clear();
                    txtTCNO.Clear();
                    txtTelNo.Clear();
                    dateTimePicker1.Value = DateTime.Now;

                    // DataGridView'i güncelle
                    VerileriGetir();

                    MessageBox.Show("Personel başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }




        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'den TextBox'lara veri aktar
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
                txtTCNO.Text = row.Cells["TcNo"].Value.ToString();
                txtTelNo.Text = row.Cells["TelNo"].Value.ToString();
                txtCalismaSaati.Text = row.Cells["CalismaSaati"].Value.ToString();
                txtSaatBasiMaas.Text = row.Cells["SaatBasiMaas"].Value.ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtSaatBasiMaas_TextChanged(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }




    }
}
