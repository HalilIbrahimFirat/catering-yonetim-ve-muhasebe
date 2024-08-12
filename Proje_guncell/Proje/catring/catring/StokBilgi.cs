using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace catring
{
    public partial class StokBilgi : Form
    {
        private List<Malzeme> malzemeler = new List<Malzeme>();
        public float MinimumStok { get { return (float)numericUpDownMinimumStok.Value; } }
        public float MalzemeAdedi { get { return (float)numericUpDownAdet.Value; } }

        public StokBilgi()
        {
            InitializeComponent();
        }

        private void StokBilgi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            // numericUpDownAdet ayarları
            numericUpDownAdet.DecimalPlaces = 2;
            numericUpDownAdet.Increment = 0.01M;
            numericUpDownAdet.Maximum = 1000000;
            numericUpDownAdet.Minimum = 0;

            // numericUpDownMinimumStok ayarları
            numericUpDownMinimumStok.DecimalPlaces = 2;
            numericUpDownMinimumStok.Increment = 0.01M;
            numericUpDownMinimumStok.Maximum = 1000000;
            numericUpDownMinimumStok.Minimum = 0;
        }

        private void VerileriGetir()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM Malzemeler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Malzemeler");
                dataGridView1.DataSource = ds.Tables["Malzemeler"];
            }
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malzemeAdi = txtMalzemeAdi.Text.ToLower();
            float malzemeAdedi = (float)numericUpDownAdet.Value;
            float minimumStok = (float)numericUpDownMinimumStok.Value;
            float birimFiyat = float.Parse(txtBirimFiyat.Text);

            if (string.IsNullOrEmpty(malzemeAdi))
            {
                MessageBox.Show("Malzeme adı boş olamaz. Lütfen geçerli bir malzeme adı girin.");
                return;
            }

            if (malzemeAdedi == 0)
            {
                MessageBox.Show("Adet sayısı 0 olamaz. Lütfen geçerli bir adet sayısı girin.");
                return;
            }

            bool malzemeVarMi = false;
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                string query = "SELECT MalzemeAdi FROM Malzemeler";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string existingMalzemeAdi = reader["MalzemeAdi"].ToString();
                            if (existingMalzemeAdi == malzemeAdi)
                            {
                                malzemeVarMi = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (malzemeVarMi)
            {
                MessageBox.Show("Bu malzeme zaten var.");
            }
            else
            {
                Malzeme yeniMalzeme = new Malzeme(malzemeAdi, malzemeAdedi, minimumStok, birimFiyat);
                malzemeler.Add(yeniMalzeme);

                VeritabaniIslemleri veritabaniIslemleri = new VeritabaniIslemleri("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True");
                veritabaniIslemleri.MalzemeEkle(malzemeAdi, malzemeAdedi, minimumStok, birimFiyat);

                // Gider tablosuna ekleme işlemi
                decimal toplamTutar = (decimal)(malzemeAdedi * birimFiyat);
                GelirGiderClass gelirGider = new GelirGiderClass
                {
                    IslemTipi = "Gider",
                    Tarih = DateTime.Now,
                    GelirGiderTipi = malzemeAdi,
                    Tutar = toplamTutar,
                    Aciklama = $"{malzemeAdedi} adet {malzemeAdi}"
                };

                veritabaniIslemleri.KaydetGelirGider(gelirGider, 0);

                MessageBox.Show("Malzeme kaydedildi ve GelirGider tablosuna gider olarak eklendi!");
                VerileriGetir();

                txtMalzemeAdi.Text = "";
                numericUpDownAdet.Value = 0;
                numericUpDownMinimumStok.Value = 0;
                txtBirimFiyat.Text = "";
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Malzeme adını ve yeni minimum stok değerini al
                string malzemeAdi = txtMalzemeAdi.Text.Trim();
                if (string.IsNullOrEmpty(malzemeAdi))
                {
                    throw new Exception("Malzeme adı boş olamaz.");
                }

                float yeniminimumStok = (float)numericUpDownMinimumStok.Value;

                if (yeniminimumStok < 0)
                {
                    throw new Exception("Minimum stok negatif bir değer olamaz.");
                }

                // Veritabanında güncelle
                using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                {
                    string query = "UPDATE Malzemeler SET MinimumStok = @MinimumStok WHERE MalzemeAdi = @MalzemeAdi";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MinimumStok", yeniminimumStok);
                        command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Minimum stok başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VerileriGetir(); // DataGridView'i güncelle
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen malzeme adı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBirimFiyatGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Malzeme adını ve yeni birim fiyatı al
                string malzemeAdi = txtMalzemeAdi.Text.Trim();
                if (string.IsNullOrEmpty(malzemeAdi))
                {
                    throw new Exception("Malzeme adı boş olamaz.");
                }

                if (!float.TryParse(txtBirimFiyat.Text.Trim(), out float yeniBirimFiyat) || yeniBirimFiyat < 0)
                {
                    throw new Exception("Lütfen geçerli ve negatif olmayan bir birim fiyat girin.");
                }

                // Veritabanında güncelle
                using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                {
                    string query = "UPDATE Malzemeler SET BirimFiyat = @BirimFiyat WHERE MalzemeAdi = @MalzemeAdi";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BirimFiyat", yeniBirimFiyat);
                        command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Birim fiyat başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VerileriGetir(); // DataGridView'i güncelle
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen malzeme adı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
