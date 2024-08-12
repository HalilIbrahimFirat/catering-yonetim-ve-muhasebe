using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;


namespace yemek.Login
{
    public partial class Form1 : Form
    {
        public string loggedInUser { get; private set; }

        string connectionString = "Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True";
        Veritabanı dbOperations;
        int loginAttempts = 0;
        const int maxLoginAttempts = 3; // Toplam giriş hakkı

        public Form1()
        {
            InitializeComponent();
            dbOperations = new Veritabanı(connectionString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            } 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }     
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar =Convert.ToChar(none);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Link = "https://grytekno.com";
            Process.Start(Link);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisYap();
  

        }





        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Ana form kapandıktan sonra login formunu tekrar göster
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }
        private void GirisYap()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (dbOperations.LoginKontrol(username, password))
            {
             
                DateTime? sonGirisTarihi = dbOperations.GetSonGirisTarihi(username);

                this.Hide();
                Arayüz.Arayüz mainForm = new Arayüz.Arayüz();
                mainForm.FormClosed += MainForm_FormClosed;
                mainForm.loggedInUser = username;
                mainForm.Show();
            }
            else
            {
                loginAttempts++;
                if (loginAttempts < maxLoginAttempts)
                {
                    int remainingAttempts = maxLoginAttempts - loginAttempts;
                    hatalbl.Text = $"Yanlış girdiniz, {remainingAttempts} giriş hakkınız kaldı.";

                    if (loginAttempts == maxLoginAttempts - 1)
                    {
                        hatalbl.Text = "Son giriş hakkınız kaldı.";
                    }
                }
                else if (loginAttempts == maxLoginAttempts)
                {
                    MessageBox.Show("3 kere yanlış girdiniz. Sistemden atılıyorsunuz.");
                    this.Close();
                }
            }
        }
        }

    
}
