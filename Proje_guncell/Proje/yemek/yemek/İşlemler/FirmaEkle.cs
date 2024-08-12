using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yemek.İşlemler
{
    public partial class FirmaEkle : Form
    {
        string connectionString = "Server=SERKANGK;Database=Catring;Integrated Security=True;";

        public FirmaEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string firmaAdi = txtFirmaAdi.Text;
                int calisanSayisi = int.Parse(txtCalisanSayisi.Text);
                string vergiNo = txtVergiNo.Text;
                string adres = txtAdres.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Firmalar (FirmaAdi, CalisanSayisi, VergiNo, Adres) VALUES (@FirmaAdi, @CalisanSayisi, @VergiNo, @Adres)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirmaAdi", firmaAdi);
                    cmd.Parameters.AddWithValue("@CalisanSayisi", calisanSayisi);
                    cmd.Parameters.AddWithValue("@VergiNo", vergiNo);
                    cmd.Parameters.AddWithValue("@Adres", adres);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Firma başarıyla eklendi.");
                this.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }

        private void FirmaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
