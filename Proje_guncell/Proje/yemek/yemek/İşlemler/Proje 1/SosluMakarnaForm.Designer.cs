namespace Proje_1
{
    partial class SosluMakarnaForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SosluMakarnaForm));
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.lblKaydetDurum = new System.Windows.Forms.Label();
            this.btnGeriCik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Cornsilk;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(116, 79);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 31);
            label1.TabIndex = 1;
            label1.Text = "Malzeme Adı";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Cornsilk;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(116, 133);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 31);
            label2.TabIndex = 2;
            label2.Text = "Miktar ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Cornsilk;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(116, 194);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 31);
            label3.TabIndex = 3;
            label3.Text = "Birim ";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Cornsilk;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(544, 67);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(267, 55);
            label4.TabIndex = 13;
            label4.Text = "Malzeme Listesi";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(296, 84);
            this.txtMalzemeAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(121, 22);
            this.txtMalzemeAdi.TabIndex = 10;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(296, 142);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 22);
            this.txtMiktar.TabIndex = 11;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Litre",
            "Mililitre"});
            this.cmbBirim.Location = new System.Drawing.Point(296, 201);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 24);
            this.cmbBirim.TabIndex = 12;
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(539, 142);
            this.lstMalzemeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(272, 148);
            this.lstMalzemeler.TabIndex = 14;
            // 
            // lblKaydetDurum
            // 
            this.lblKaydetDurum.BackColor = System.Drawing.Color.White;
            this.lblKaydetDurum.ForeColor = System.Drawing.Color.Lime;
            this.lblKaydetDurum.Location = new System.Drawing.Point(765, 334);
            this.lblKaydetDurum.Name = "lblKaydetDurum";
            this.lblKaydetDurum.Size = new System.Drawing.Size(254, 32);
            this.lblKaydetDurum.TabIndex = 17;
            this.lblKaydetDurum.UseWaitCursor = true;
            this.lblKaydetDurum.Visible = false;
            // 
            // btnGeriCik
            // 
            this.btnGeriCik.BackColor = System.Drawing.Color.DarkGray;
            this.btnGeriCik.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriCik.Location = new System.Drawing.Point(12, 35);
            this.btnGeriCik.Name = "btnGeriCik";
            this.btnGeriCik.Size = new System.Drawing.Size(105, 32);
            this.btnGeriCik.TabIndex = 20;
            this.btnGeriCik.Text = "Geri Git";
            this.btnGeriCik.UseVisualStyleBackColor = false;
            this.btnGeriCik.Click += new System.EventHandler(this.btnGeriCik_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(612, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tarife Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEkle2
            // 
            this.btnEkle2.Location = new System.Drawing.Point(296, 287);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(121, 32);
            this.btnEkle2.TabIndex = 22;
            this.btnEkle2.Text = "Ekle";
            this.btnEkle2.UseVisualStyleBackColor = true;
            this.btnEkle2.Click += new System.EventHandler(this.btnEkle2_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(296, 334);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(121, 32);
            this.btnCikart.TabIndex = 23;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.BackColor = System.Drawing.Color.Silver;
            this.bttnKaydet.Location = new System.Drawing.Point(612, 334);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(121, 32);
            this.bttnKaydet.TabIndex = 24;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = false;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // SosluMakarnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 680);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnEkle2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGeriCik);
            this.Controls.Add(this.lblKaydetDurum);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "SosluMakarnaForm";
            this.Text = "SosluMakarnaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Label lblKaydetDurum;
        private System.Windows.Forms.Button btnGeriCik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button bttnKaydet;
    }
}