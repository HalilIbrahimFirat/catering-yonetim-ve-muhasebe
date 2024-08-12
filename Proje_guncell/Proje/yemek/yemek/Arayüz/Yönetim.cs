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

namespace yemek.Arayüz
{
    public partial class Yönetim : Form
    {

        string connectionString = "Server=HALIL;Database=Catring;Integrated Security=True;";
        Veritabanı dbOperations;

        public Yönetim()
        {
            InitializeComponent();
            dbOperations = new Veritabanı(connectionString);
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Username, Password, Role, Songiris FROM login";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "login");
                    dataGridView1.DataSource = ds.Tables["login"];


                    dataGridView1.Columns["Password"].Visible = false;


                    dataGridView1.Columns["Username"].HeaderText = "Kullanıcı Adı";
                    dataGridView1.Columns["Role"].HeaderText = "Görev";
                    dataGridView1.Columns["Songiris"].HeaderText = "Son Giriş Tarihi";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı bağlantı hatası: " + ex.Message);
                }
            }

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                şifre.PasswordChar = '\0'; 
                şifretkr.PasswordChar = '\0';
            }
            else
            {
                şifre.PasswordChar = '*'; 
                şifretkr.PasswordChar = '*';
            }
          
        }

        private void Yönetim_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Sil";
            btnColumn.Text = "Sil";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Name = "Sil"; 
            dataGridView1.Columns.Add(btnColumn);

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void şifre_Enter(object sender, EventArgs e)
        {
            hatalbl.Text = "Şifre 6-20 karakter arasında olmalıdır.";
            if (şifre.Text == "Şifre")
            {
                şifre.Text = "";
                şifre.ForeColor = Color.Black;
                şifre.PasswordChar = '*';
            }
        }
        char? none = null;
        private void şifre_Leave(object sender, EventArgs e)
        {
            hatalbl.Text = " ";
            if (şifre.Text == "")
            {
                şifre.Text = "Şifre";
                şifre.ForeColor = Color.Silver;
                şifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void şifretkr_Enter(object sender, EventArgs e)
        {
            if (şifretkr.Text == "Şifre")
            {
                şifretkr.Text = "";
                şifretkr.ForeColor = Color.Black;
                şifretkr.PasswordChar = '*';
            }
        }

        private void şifretkr_Leave(object sender, EventArgs e)
        {
            if (şifretkr.Text == "")
            {
                şifretkr.Text = "Şifre";
                şifretkr.ForeColor = Color.Silver;
                şifretkr.PasswordChar = Convert.ToChar(none);
            }
            if (şifre.Text != şifretkr.Text)
            {
                hatalbl.Text = "Şifreler birbiriyle uyuşmuyor.";
            }
            else
            {
                hatalbl.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıcıadı_Enter(object sender, EventArgs e)
        {
            if (kullanıcıadı.Text == "Kullanıcı Adı")
            {
                kullanıcıadı.Text = "";
                kullanıcıadı.ForeColor = Color.Black;
            }
        }

        private void kullanıcıadı_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kullanıcıadı.Text))
            {
                kullanıcıadı.Text = "Kullanıcı Adı";
                kullanıcıadı.ForeColor = Color.Silver;
            }
        }

        private void kullanıcıekle_Click(object sender, EventArgs e)
        {
            string username = kullanıcıadı.Text;
            string password = şifre.Text;
            string confirmPassword = şifretkr.Text;
            string role = comboBoxGorev.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username))
            {
                hatalbl.Text = "Kullanıcı adı boş geçilemez.";
                return;
            }

            if (kullanıcıadı.Text != "Kullanıcı Adı")
            {



                if (string.IsNullOrWhiteSpace(password))
                {
                    hatalbl.Text = "Şifre boş geçilemez.";
                    return;
                }

                if (password.Length < 6 || password.Length > 20)
                {
                    hatalbl.Text = "Şifre uzunluğu 6-20 karakter arasında olmalıdır.";
                    return;
                }

                if (password != confirmPassword)
                {
                    hatalbl.Text = "Şifreler eşleşmiyor.";
                    return;
                }

                if (dbOperations.KullanıcıKayıtKontrol(username))
                {
                    hatalbl.Text = "Bu kullanıcı adı zaten kayıtlı.";
                    return;
                }
                if (comboBoxGorev.SelectedItem == null)
                {
                    hatalbl.Text = "Lütfen görev seçiniz.";
                    return;
                }
                bool success = dbOperations.KullanıcıEkle(username, password, role);

                if (success)
                {
                    hatalbl.Text = "Kullanıcı başarıyla kaydedildi.";
                    VerileriGetir();
                    kullanıcıadı.Text = "";
                    şifre.Text = "";
                    şifretkr.Text = "";
                    comboBoxGorev.SelectedIndex = -1;
                }
                else
                {
                    hatalbl.Text = "Kullanıcı eklenirken bir hata oluştu.";
                }
            }
            else
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez");
        }
        private void kullanıcıadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void şifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıcıadı_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kullanıcıadı.Text))
            {
                kullanıcıadı.Text = "Kullanıcı Adı";
                kullanıcıadı.ForeColor = Color.Silver;
            }
        }

        private void kullanıcıadı_Enter_1(object sender, EventArgs e)
        {
            if (kullanıcıadı.Text == "Kullanıcı Adı")
            {
                kullanıcıadı.Text = "";
                kullanıcıadı.ForeColor = Color.Black;
            }
        
    }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifregüncelle_Click(object sender, EventArgs e)
        {
            string username = güncelka.Text;
            string oldPassword = eskişifre.Text;
            string newPassword = yenişifre.Text;
            string confirmPassword = yenişifretkr.Text;


            if (string.IsNullOrWhiteSpace(username))
            {
                güncellblhata.Text = "Kullanıcı adı boş geçilemez.";
                return;
            }


            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                güncellblhata.Text = "Lütfen tüm alanları doldurun.";
                return;
            }


            if (newPassword != confirmPassword)
            {
                güncellblhata.Text = "Yeni şifreler eşleşmiyor.";
                return;
            }


            if (!dbOperations.LoginKontrol(username, oldPassword))
            {
                güncellblhata.Text = "Kullanıcı adı veya eski şifre hatalı.";
                return;
            }

  
            bool success = dbOperations.ŞifreGüncelle(username, newPassword);

            if (success)
            {
                güncellblhata.Text = "Şifre başarıyla güncellendi.";
              
                VerileriGetir();
            }
            else
            {
                güncellblhata.Text = "Şifre güncelleme işlemi başarısız.";
            }
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void güncelka_TextChanged(object sender, EventArgs e)
        {

        }

        private void güncelka_Enter_1(object sender, EventArgs e)
        {
            if (güncelka.Text == "Kullanıcı Adı")
            {
                güncelka.Text = "";
                güncelka.ForeColor = Color.Black;
            }
        }

        private void güncelka_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(güncelka.Text))
            {
                güncelka.Text = "Kullanıcı Adı";
                güncelka.ForeColor = Color.Silver;
            }
        }

        private void eskişifre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eskişifre.Text))
            {
                eskişifre.Text = "Eski Şifre";
                eskişifre.ForeColor = Color.Silver;
                eskişifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void eskişifre_Enter(object sender, EventArgs e)
        {
            if (eskişifre.Text == "Eski Şifre")
            {
                eskişifre.Text = "";
                eskişifre.ForeColor = Color.Black;
                eskişifre.PasswordChar = '*';
            }
        }

        private void yenişifre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(yenişifre.Text))
            {
                yenişifre.Text = "Yeni Şifre";
                yenişifre.ForeColor = Color.Silver;
                yenişifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void yenişifre_Enter(object sender, EventArgs e)
        {
            if (yenişifre.Text == "Yeni Şifre")
            {
                yenişifre.Text = "";
                yenişifre.ForeColor = Color.Black;
                yenişifre.PasswordChar = '*';
            }
        }

        private void yenişifretkr_Enter(object sender, EventArgs e)
        {
            if (yenişifretkr.Text == "Yeni Şifre")
            {
                yenişifretkr.Text = "";
                yenişifretkr.ForeColor = Color.Black;
                yenişifretkr.PasswordChar = '*';
            }
        }

        private void yenişifretkr_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(yenişifretkr.Text))
            {
                yenişifretkr.Text = "Yeni Şifre";
                yenişifretkr.ForeColor = Color.Silver;
                yenişifretkr.PasswordChar = Convert.ToChar(none);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                eskişifre.PasswordChar = '\0';
               
            }
            else
            {
                eskişifre.PasswordChar = '*'; 
               
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                yenişifre.PasswordChar = '\0';
                yenişifretkr.PasswordChar = '\0';
            }
            else
            {
                yenişifre.PasswordChar = '*'; 
                yenişifretkr.PasswordChar = '*';
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.ReadOnly = true;
            }

            if (dataGridView1.Columns["Sil"] != null && e.ColumnIndex == dataGridView1.Columns["Sil"].Index && e.RowIndex >= 0)
            {
   
                string adminPassword = yemek.Prompt.ShowDialog("Admin şifresini girin:", "Şifre Doğrulama");
                if (!string.IsNullOrEmpty(adminPassword))
                {
                    if (dbOperations.IsAdminPasswordCorrect(adminPassword))
                    {
               
                        var row = dataGridView1.Rows[e.RowIndex];
                        if (row.Cells["Username"] != null)
                        {
                            string kullaniciAdi = row.Cells["Username"].Value.ToString();
                            dbOperations.DeleteUser(kullaniciAdi);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış şifre!");
                    }
                }
            }
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



