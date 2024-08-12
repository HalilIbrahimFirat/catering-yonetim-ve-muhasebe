
namespace yemek.Arayüz
{
    partial class Arayüz
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arayüz));
            this.saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.kullanıcılbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayarlarmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.anapanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ayarlarbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kasabtn = new System.Windows.Forms.Button();
            this.urtmbtn = new System.Windows.Forms.Button();
            this.yntmbtn = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.ayarlar = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.gün = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
            this.saat.Font = new System.Drawing.Font("Roboto Bk", 17F);
            this.saat.Location = new System.Drawing.Point(31, 546);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(104, 28);
            this.saat.TabIndex = 9;
            this.saat.Text = "00:00:00";
            this.saat.Click += new System.EventHandler(this.saat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hoşgeldiniz!";
            // 
            // kullanıcılbl
            // 
            this.kullanıcılbl.AutoSize = true;
            this.kullanıcılbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
            this.kullanıcılbl.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
            this.kullanıcılbl.ForeColor = System.Drawing.Color.White;
            this.kullanıcılbl.Location = new System.Drawing.Point(9, 24);
            this.kullanıcılbl.Name = "kullanıcılbl";
            this.kullanıcılbl.Size = new System.Drawing.Size(95, 22);
            this.kullanıcılbl.TabIndex = 11;
            this.kullanıcılbl.Text = "kullanıcı";
            this.kullanıcılbl.Click += new System.EventHandler(this.kullanıcılbl_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageKey = "(yok)";
            this.button5.Location = new System.Drawing.Point(0, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 50);
            this.button5.TabIndex = 14;
            this.button5.Text = "DEPO MENÜ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngwing.com (2).png");
            this.ımageList1.Images.SetKeyName(1, "pngwing.com (4).png");
            this.ımageList1.Images.SetKeyName(2, "pngwing.com (3).png");
            this.ımageList1.Images.SetKeyName(3, "home.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ayarlarmenu
            // 
            this.ayarlarmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ayarlarmenu.Name = "ayarlarmenu";
            this.ayarlarmenu.Size = new System.Drawing.Size(61, 4);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 0;
            this.button6.Location = new System.Drawing.Point(0, 451);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 50);
            this.button6.TabIndex = 17;
            this.button6.Text = "TESLİMAT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.anapanel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Location = new System.Drawing.Point(176, 58);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1102, 650);
            this.mainPanel.TabIndex = 19;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // anapanel
            // 
            this.anapanel.Location = new System.Drawing.Point(0, 799);
            this.anapanel.Name = "anapanel";
            this.anapanel.Size = new System.Drawing.Size(1779, 221);
            this.anapanel.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 621);
            this.panel1.TabIndex = 21;
            // 
            // ayarlarbtn
            // 
            this.ayarlarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
            this.ayarlarbtn.BackgroundImage = global::yemek.Properties.Resources.pngwing_com__5_;
            this.ayarlarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayarlarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayarlarbtn.Location = new System.Drawing.Point(12, 1018);
            this.ayarlarbtn.Name = "ayarlarbtn";
            this.ayarlarbtn.Size = new System.Drawing.Size(55, 50);
            this.ayarlarbtn.TabIndex = 8;
            this.ayarlarbtn.UseVisualStyleBackColor = false;
            this.ayarlarbtn.MouseLeave += new System.EventHandler(this.ayarlarbtn_MouseLeave);
            this.ayarlarbtn.MouseHover += new System.EventHandler(this.ayarlarbtn_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImage = global::yemek.Properties.Resources.no;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1864, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // kasabtn
            // 
            this.kasabtn.BackColor = System.Drawing.Color.Silver;
            this.kasabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kasabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kasabtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasabtn.Location = new System.Drawing.Point(0, 362);
            this.kasabtn.Name = "kasabtn";
            this.kasabtn.Size = new System.Drawing.Size(174, 50);
            this.kasabtn.TabIndex = 20;
            this.kasabtn.Text = "KASA";
            this.kasabtn.UseVisualStyleBackColor = false;
            this.kasabtn.Click += new System.EventHandler(this.kasabtn_Click);
            // 
            // urtmbtn
            // 
            this.urtmbtn.BackColor = System.Drawing.Color.Silver;
            this.urtmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.urtmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urtmbtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urtmbtn.Location = new System.Drawing.Point(0, 269);
            this.urtmbtn.Name = "urtmbtn";
            this.urtmbtn.Size = new System.Drawing.Size(174, 50);
            this.urtmbtn.TabIndex = 21;
            this.urtmbtn.Text = "ÜRETİM";
            this.urtmbtn.UseVisualStyleBackColor = false;
            this.urtmbtn.Click += new System.EventHandler(this.urtmbtn_Click);
            // 
            // yntmbtn
            // 
            this.yntmbtn.BackColor = System.Drawing.Color.Silver;
            this.yntmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yntmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yntmbtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yntmbtn.Location = new System.Drawing.Point(0, 104);
            this.yntmbtn.Name = "yntmbtn";
            this.yntmbtn.Size = new System.Drawing.Size(174, 50);
            this.yntmbtn.TabIndex = 23;
            this.yntmbtn.Text = "YÖNETİM";
            this.yntmbtn.UseVisualStyleBackColor = false;
            this.yntmbtn.Click += new System.EventHandler(this.yntmbtn_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.kapat.BackgroundImage = global::yemek.Properties.Resources.no;
            this.kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kapat.Location = new System.Drawing.Point(1239, 7);
            this.kapat.Margin = new System.Windows.Forms.Padding(2);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(30, 32);
            this.kapat.TabIndex = 24;
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // ayarlar
            // 
            this.ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ayarlar.BackgroundImage = global::yemek.Properties.Resources.pngwing_com__1_;
            this.ayarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayarlar.Location = new System.Drawing.Point(1170, 6);
            this.ayarlar.Margin = new System.Windows.Forms.Padding(2);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(30, 32);
            this.ayarlar.TabIndex = 26;
            this.ayarlar.UseVisualStyleBackColor = false;
            this.ayarlar.Click += new System.EventHandler(this.ayarlar_Click);
            this.ayarlar.MouseLeave += new System.EventHandler(this.ayarlar_MouseLeave);
            this.ayarlar.MouseHover += new System.EventHandler(this.ayarlar_MouseHover);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.logout.BackgroundImage = global::yemek.Properties.Resources.kisspng_login_abmeldung_computer_icons_session_clip_art_register_button_5acb70ab19a2f0_4082348515232820911051;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Location = new System.Drawing.Point(1204, 6);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 32);
            this.logout.TabIndex = 27;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // gün
            // 
            this.gün.AutoSize = true;
            this.gün.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
            this.gün.Font = new System.Drawing.Font("Roboto Bk", 15F);
            this.gün.Location = new System.Drawing.Point(13, 522);
            this.gün.Name = "gün";
            this.gün.Size = new System.Drawing.Size(146, 24);
            this.gün.TabIndex = 31;
            this.gün.Text = "24 Mayıs 2024";
            this.gün.Click += new System.EventHandler(this.gün_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anasayfa.ImageKey = "home.png";
            this.anasayfa.ImageList = this.ımageList1;
            this.anasayfa.Location = new System.Drawing.Point(180, 9);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(2);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(158, 32);
            this.anasayfa.TabIndex = 33;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // Arayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::yemek.Properties.Resources.arayüz2;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.gün);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.ayarlar);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.yntmbtn);
            this.Controls.Add(this.urtmbtn);
            this.Controls.Add(this.kasabtn);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.kullanıcılbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.ayarlarbtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Arayüz";
            this.Text = "Arayüz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Arayüz_FormClosing);
            this.Load += new System.EventHandler(this.Arayüz_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arayüz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Arayüz_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Arayüz_MouseUp);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ayarlarbtn;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kullanıcılbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip ayarlarmenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel anapanel;
        private System.Windows.Forms.Button kasabtn;
        private System.Windows.Forms.Button urtmbtn;
        private System.Windows.Forms.Button yntmbtn;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button ayarlar;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label gün;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Panel panel1;
    }
}