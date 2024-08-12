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
    public partial class TipEkle : Form

    {
        public string YeniTip { get; private set; }




        public TipEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yeniTip = txtYeniTip.Text.Trim();

            if (!string.IsNullOrWhiteSpace(yeniTip))
            {
                string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Aynı isimde tip olup olmadığını kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM Tipler WHERE TipAdi = @TipAdi";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@TipAdi", yeniTip);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Aynı isimde tip bulunuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Yeni tipi ekle
                            string query = "INSERT INTO Tipler (TipAdi) VALUES (@TipAdi)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@TipAdi", yeniTip);
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Tip başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Formu kapat ve DialogResult.OK döndür
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }

                    connection.Close(); // Bağlantıyı kapat
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tip girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TipEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
