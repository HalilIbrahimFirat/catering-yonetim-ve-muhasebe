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
    public partial class StokEkleCikar : Form
    {
        private float minimumStok;
        private float malzemeAdedi;

        public float MinimumStok { get { return minimumStok; } }
        public float MalzemeAdedi { get { return malzemeAdedi; } }

        public StokEkleCikar()
        {
            InitializeComponent();
        }

        public StokEkleCikar(float minimumStok, float malzemeAdedi)
        {
            InitializeComponent();
            this.minimumStok = minimumStok;
            this.malzemeAdedi = malzemeAdedi;
        }

        private void StokEkleCikar_Load(object sender, EventArgs e)
        {
            VerileriGetir();

            // numericUpDownAdet ayarları
            numericUpDownStokCikar.DecimalPlaces = 2;
            numericUpDownStokCikar.Increment = 0.01M;
            numericUpDownStokCikar.Maximum = 1000000; 
            numericUpDownStokCikar.Minimum = 0;

            // numericUpDownMinimumStok ayarları
            numericUpDownStokEkle.DecimalPlaces = 2;
            numericUpDownStokEkle.Increment = 0.01M;
            numericUpDownStokEkle.Maximum = 1000000; 
            numericUpDownStokEkle.Minimum = 0;
        }

        private void VerileriGetir()
        {
            // Veritabanından verileri çek ve DataGridView'e yükle
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
            // DataGridView sütunlarını otomatik boyutlandır
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malzemeAdi = cmbMalzemeAdi.Text;
            float stokEkleAdet = (float)numericUpDownStokEkle.Value;

            if (string.IsNullOrEmpty(malzemeAdi))
            {
                MessageBox.Show("Lütfen Malzeme Adı Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (stokEkleAdet == 0)
            {
                MessageBox.Show("Lütfen sıfırdan farklı bir değer giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                VeritabaniIslemleri veritabaniIslemleri = new VeritabaniIslemleri("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True");

                // Veritabanında malzeme adı olup olmadığını kontrol et
                using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                {
                    string queryCheck = "SELECT COUNT(*) FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                    using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        connection.Open();
                        int count = (int)commandCheck.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Belirtilen malzeme adı bulunamadı. Ekleme yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Malzeme adı mevcutsa stok ekleme işlemini yap
                veritabaniIslemleri.StokEkle(malzemeAdi, stokEkleAdet);
            }

            VerileriGetir();
        }


        private void btnStokCikar_Click(object sender, EventArgs e)
        {
            string malzemeAdi = cmbMalzemeAdi.Text;
            float stokCikarAdet = (float)numericUpDownStokCikar.Value;

            if (string.IsNullOrEmpty(malzemeAdi))
            {
                MessageBox.Show("Lütfen Malzeme Adı Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (stokCikarAdet == 0)
            {
                MessageBox.Show("Lütfen sıfırdan farklı bir değer giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                VeritabaniIslemleri veritabaniIslemleri = new VeritabaniIslemleri("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True");
                float mevcutStok = veritabaniIslemleri.MevcutStok(malzemeAdi);

                // Çıkarılacak stok miktarı, mevcut stok miktarından fazla ise işlemi iptal et
                if (stokCikarAdet > mevcutStok)
                {
                    MessageBox.Show("Çıkarılacak stok miktarı, mevcut stok miktarından fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veritabaniIslemleri.StokCikar(malzemeAdi, stokCikarAdet);
                MessageBox.Show("Malzeme stok çıkarma işlemi tamamlandı!");
            }

            VerileriGetir();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
