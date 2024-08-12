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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
            ComboBoxDoldur(); // Form yüklenirken ComboBox'ı doldur


            // RadioButton'ların CheckedChanged olayını işleyiciye bağlar
            dataRdbtnGelir.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            dataRdbtnGider.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);


        }

        private void GelirGider_Load(object sender, EventArgs e)
        {
            VerileriGetir();

            dataGridView1.Columns["ID"].Visible = false;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!rbtnGelir.Checked && !rbtnGider.Checked)
            {
                MessageBox.Show("Lütfen gelir veya gider seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Formdaki verileri al
            string islemTipi = rbtnGelir.Checked ? "Gelir" : "Gider";
            DateTime tarih = dtpTarih.Value;


            // ComboBox'tan seçilen öğeyi kontrol et
            if (cbGelirGiderTipi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen gelir/gider tipi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gelirGiderTipi = cbGelirGiderTipi.SelectedItem.ToString();

            // Tutar TextBox'ının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtTutar.Text))
            {
                MessageBox.Show("Lütfen tutar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tutarın geçerli bir sayı olup olmadığını kontrol et
            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                MessageBox.Show("Lütfen geçerli bir tutar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string aciklama = txtAciklama.Text;

            // GelirGider nesnesi oluştur
            GelirGiderClass gelirGider = new GelirGiderClass
            {
                IslemTipi = islemTipi,
                Tarih = tarih,
                GelirGiderTipi = gelirGiderTipi,
                Tutar = tutar,
                Aciklama = aciklama
            };

            // Veritabanı bağlantı dizesini tanımlayın
            string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";

            // VeritabaniIslemleri nesnesi oluştur
            VeritabaniIslemleri veritabaniIslemleri = new VeritabaniIslemleri(connectionString);

            try
            {
                // Veriyi kaydet
                veritabaniIslemleri.KaydetGelirGider(gelirGider, 0);
                MessageBox.Show("Kayıt başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına kaydedilirken bir hata oluştu: " + ex.Message);
            }
            VerileriGetir();
        }
        private void VerileriGetir()
        {
            // Veritabanından verileri çek ve DataGridView'e yükle
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM GelirGider";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "GelirGider");
                dataGridView1.DataSource = ds.Tables["GelirGider"];
            }
            // DataGridView sütunlarını otomatik boyutlandır
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        // RadioButton'ların CheckedChanged event handler'ı
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dataRdbtnGelir.Checked)
            {
                // RadioButton1 seçiliyse belirli kategoriyi göster 
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "IslemTipi = 'gelir'";
            }
            else if (dataRdbtnGider.Checked)
            {
                // RadioButton2 seçiliyse belirli kategoriyi göster
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "IslemTipi = 'gider'";
            }
            else
            {
                // Hiçbir RadioButton seçili değilse tüm verileri göster
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (TipEkle tipEkleForm = new TipEkle())
            {
                if (tipEkleForm.ShowDialog() == DialogResult.OK)
                {
                    ComboBoxDoldur(); // Form kapandıktan sonra ComboBox'ı yeniden doldur

                }
            }
        }

        private void ComboBoxDoldur()
        {
            cbGelirGiderTipi.Items.Clear();

            string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TipAdi FROM Tipler";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbGelirGiderTipi.Items.Add(reader["TipAdi"].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbGelirGiderTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
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
                    int selectedGelirGiderID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                    using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                    {
                        connection.Open();
                        string query = "DELETE FROM GelirGider WHERE ID = @Id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", selectedGelirGiderID);
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

        private void Filtrele_Click(object sender, EventArgs e)
        {

            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;

            if (baslangicTarihi > bitisTarihi)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM GelirGider WHERE Tarih BETWEEN @BaslangicTarihi AND @BitisTarihi";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                adapter.SelectCommand.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "GelirGider");
                dataGridView1.DataSource = ds.Tables["GelirGider"];

                // Kâr/Zarar hesaplama
                decimal toplamGelir = 0;
                decimal toplamGider = 0;

                foreach (DataRow row in ds.Tables["GelirGider"].Rows)
                {
                    string islemTipi = row["IslemTipi"].ToString();
                    decimal tutar = Convert.ToDecimal(row["Tutar"]);

                    if (islemTipi == "Gelir")
                    {
                        toplamGelir += tutar;
                    }
                    else if (islemTipi == "Gider")
                    {
                        toplamGider += tutar;
                    }
                }

                if (0 > (toplamGelir + toplamGider))
                {

                    decimal karZarar = toplamGelir - toplamGider;

                    decimal gelirYuzde = (toplamGelir / (toplamGelir + toplamGider)) * 100;
                    decimal giderYuzde = (toplamGider / (toplamGelir + toplamGider)) * 100;
                    decimal karZararYuzde = gelirYuzde - giderYuzde;

                    string mesaj = $"Toplam Gelir: {toplamGelir:C}\nToplam Gider: {toplamGider:C}\nKâr/Zarar: {karZarar:C}\n\n" +
                                  $"Gelir Yüzdesi: {gelirYuzde:F2}%\nGider Yüzdesi: {giderYuzde:F2}%\nKâr/Zarar Yüzdesi: {karZararYuzde:F2}%";

                    MessageBox.Show(mesaj, "Kâr-Zarar Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                
               
            }

            // DataGridView sütunlarını otomatik boyutlandır
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

