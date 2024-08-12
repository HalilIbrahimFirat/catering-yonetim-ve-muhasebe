
namespace catring
{
    partial class StokBilgi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinimumStok = new System.Windows.Forms.NumericUpDown();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBirimFiyatGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malzeme Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum Stok Belirle";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(147, 136);
            this.numericUpDownAdet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAdet.TabIndex = 3;
            // 
            // numericUpDownMinimumStok
            // 
            this.numericUpDownMinimumStok.Location = new System.Drawing.Point(147, 167);
            this.numericUpDownMinimumStok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMinimumStok.Name = "numericUpDownMinimumStok";
            this.numericUpDownMinimumStok.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMinimumStok.TabIndex = 4;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(147, 102);
            this.txtMalzemeAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(91, 20);
            this.txtMalzemeAdi.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(147, 243);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(72, 26);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MALZEME GİRİŞ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(278, 346);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(238, 158);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(70, 38);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "MİN STOK GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(147, 210);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(91, 20);
            this.txtBirimFiyat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birim Fiyat";
            // 
            // btnBirimFiyatGuncelle
            // 
            this.btnBirimFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimFiyatGuncelle.Location = new System.Drawing.Point(242, 201);
            this.btnBirimFiyatGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBirimFiyatGuncelle.Name = "btnBirimFiyatGuncelle";
            this.btnBirimFiyatGuncelle.Size = new System.Drawing.Size(70, 36);
            this.btnBirimFiyatGuncelle.TabIndex = 14;
            this.btnBirimFiyatGuncelle.Text = "Birim Fiyat Güncelle";
            this.btnBirimFiyatGuncelle.UseVisualStyleBackColor = true;
            this.btnBirimFiyatGuncelle.Click += new System.EventHandler(this.btnBirimFiyatGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Bk", 14.25F);
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "STOK BİLGİ";
            // 
            // StokBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBirimFiyatGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.numericUpDownMinimumStok);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StokBilgi";
            this.Text = "StokBilgi";
            this.Load += new System.EventHandler(this.StokBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimumStok;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBirimFiyatGuncelle;
        private System.Windows.Forms.Label label6;
    }
}