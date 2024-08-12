using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek.Arayüz
{
    public partial class Arayüz : Form
    {
        public string loggedInUser { get; set; }
        private Anasayfa anasayfaForm;

        public Arayüz()
        {
            InitializeComponent();
            CreateMenu();
            LoadAnasayfaForm();

        }

        private void LoadAnasayfaForm()
        {
         
            anasayfaForm = new Anasayfa(); 
            anasayfaForm.TopLevel = false;
            anasayfaForm.FormBorderStyle = FormBorderStyle.None;
            anasayfaForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(anasayfaForm);
            panel1.Tag = anasayfaForm;
            anasayfaForm.Show();
        }

        private void CreateMenu()
        {
            
            ToolStripMenuItem stok = new ToolStripMenuItem("STOK EKLE/ÇIKAR");
            ToolStripMenuItem stokbilgi = new ToolStripMenuItem("MALZEME EKLE");
            ToolStripMenuItem tip = new ToolStripMenuItem("TİP");


            stok.Click += stok_Click;
            stokbilgi.Click += stokbilgi_Click;
            tip.Click += tip_Click;


            contextMenuStrip1.Items.Add(stok);
            contextMenuStrip1.Items.Add(stokbilgi);
            contextMenuStrip1.Items.Add(tip);


            ToolStripMenuItem kdvayarı = new ToolStripMenuItem("KDV AYARI");
            ToolStripMenuItem uygulamaayarı = new ToolStripMenuItem("UYGULAMA AYARI");
            ToolStripMenuItem yönetim = new ToolStripMenuItem("KULLANICI YÖNETİMİ");

            kdvayarı.Click += kdvayarımenu_Click;
            uygulamaayarı.Click += uygayar_Click;
            yönetim.Click += yönetim_Click;

            ayarlarmenu.Items.Add(kdvayarı);
            ayarlarmenu.Items.Add(uygulamaayarı);
            ayarlarmenu.Items.Add(yönetim);



        }


        private void Arayüz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        bool move;
        int mouse_x;
        int mouse_y;


        private void Arayüz_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Arayüz_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Arayüz_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Arayüz_Load(object sender, EventArgs e)
        {
            timer1.Start();
            kullanıcılbl.Text = loggedInUser;



        }

        private void kdvayarımenu_Click(object sender, EventArgs e)
        {
            Ayarlar.kdvayarı arayüzgecis = new Ayarlar.kdvayarı();
            arayüzgecis.ShowDialog();

        }

        private void yönetim_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Yönetim());

        }

        private void uygayar_Click(object sender, EventArgs e)
        {
            Ayarlar.uygulamaayar arayüzgecis = new Ayarlar.uygulamaayar();
            arayüzgecis.ShowDialog();

        }

        private void stok_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new catring.StokEkleCikar());
        }

        private void stokbilgi_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new catring.StokBilgi());
        }

        private void tip_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new catring.TipEkle());
        }

        private void saat_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
            string formattedDate = DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("tr-TR"));
            gün.Text = formattedDate;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button5, new System.Drawing.Point(0, button5.Height));
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            var mousePos = Cursor.Position;
            var menuPos = contextMenuStrip1.PointToClient(mousePos);
            if (!contextMenuStrip1.ClientRectangle.Contains(menuPos))
            {
                contextMenuStrip1.Hide();
            }
        }

        private void personelbtn_Click(object sender, EventArgs e)
        {

        }

        private void ayarlarbtn_MouseHover(object sender, EventArgs e)
        {
            ayarlarmenu.Show(ayarlarbtn, new System.Drawing.Point(0, ayarlarbtn.Height));
        }

        private void ayarlarbtn_MouseLeave(object sender, EventArgs e)
        {
            var mousePos = Cursor.Position;
            var menuPos = ayarlarmenu.PointToClient(mousePos);
            if (!ayarlarmenu.ClientRectangle.Contains(menuPos))
            {
                ayarlarmenu.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Teslimat());
        }
        private void ShowFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearPanel();
        }
        private void ClearPanel()
        {
            // Paneldeki mevcut kontrolleri temizle
            mainPanel.Controls.Clear();
        }

        private void kasabtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new catring.GelirGider()); 
        }

        private void urtmbtn_Click(object sender, EventArgs e)
        {
                        ShowFormInPanel(new Proje_1.Form1());
        }

        private void depobtn_Click(object sender, EventArgs e)
        {
            //ShowFormInPanel(new Teslimat()); hesap formunun ismini ekleyin
        }

        private void yntmbtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new catring.Form1()); 
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {

        }

        private void ayarlar_MouseHover(object sender, EventArgs e)
        {
            ayarlarmenu.Show(ayarlar, new System.Drawing.Point(0, ayarlar.Height));
        }

        private void ayarlar_MouseLeave(object sender, EventArgs e)
        {
            var mousePos = Cursor.Position;
            var menuPos = ayarlarmenu.PointToClient(mousePos);
            if (!ayarlarmenu.ClientRectangle.Contains(menuPos))
            {
                ayarlarmenu.Hide();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gün_Click(object sender, EventArgs e)
        {
            string formattedDate = DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("tr-TR"));
            gün.Text = formattedDate;
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Anasayfa());
        }

        private void kullanıcılbl_Click(object sender, EventArgs e)
        {

        }
    }
}
