
namespace catring
{
    partial class GelirGider
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
            this.rbtnGelir = new System.Windows.Forms.RadioButton();
            this.rbtnGider = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cbGelirGiderTipi = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataRdbtnGider = new System.Windows.Forms.RadioButton();
            this.dataRdbtnGelir = new System.Windows.Forms.RadioButton();
            this.dataRdbtnHepsi = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Filtrele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Tipi";
            // 
            // rbtnGelir
            // 
            this.rbtnGelir.AutoSize = true;
            this.rbtnGelir.Location = new System.Drawing.Point(92, 70);
            this.rbtnGelir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnGelir.Name = "rbtnGelir";
            this.rbtnGelir.Size = new System.Drawing.Size(46, 17);
            this.rbtnGelir.TabIndex = 1;
            this.rbtnGelir.TabStop = true;
            this.rbtnGelir.Text = "Gelir";
            this.rbtnGelir.UseVisualStyleBackColor = true;
            // 
            // rbtnGider
            // 
            this.rbtnGider.AutoSize = true;
            this.rbtnGider.Location = new System.Drawing.Point(178, 70);
            this.rbtnGider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnGider.Name = "rbtnGider";
            this.rbtnGider.Size = new System.Drawing.Size(50, 17);
            this.rbtnGider.TabIndex = 2;
            this.rbtnGider.TabStop = true;
            this.rbtnGider.Text = "Gider";
            this.rbtnGider.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(92, 110);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(151, 20);
            this.dtpTarih.TabIndex = 4;
            // 
            // cbGelirGiderTipi
            // 
            this.cbGelirGiderTipi.FormattingEnabled = true;
            this.cbGelirGiderTipi.Items.AddRange(new object[] {
            "muhasebe"});
            this.cbGelirGiderTipi.Location = new System.Drawing.Point(92, 148);
            this.cbGelirGiderTipi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGelirGiderTipi.Name = "cbGelirGiderTipi";
            this.cbGelirGiderTipi.Size = new System.Drawing.Size(151, 21);
            this.cbGelirGiderTipi.TabIndex = 6;
            this.cbGelirGiderTipi.SelectedIndexChanged += new System.EventHandler(this.cbGelirGiderTipi_SelectedIndexChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(92, 184);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(84, 20);
            this.txtTutar.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(92, 222);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(151, 78);
            this.txtAciklama.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gelir/Gider tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Açıklama";
            // 
            // dataRdbtnGider
            // 
            this.dataRdbtnGider.AutoSize = true;
            this.dataRdbtnGider.Location = new System.Drawing.Point(428, 70);
            this.dataRdbtnGider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRdbtnGider.Name = "dataRdbtnGider";
            this.dataRdbtnGider.Size = new System.Drawing.Size(50, 17);
            this.dataRdbtnGider.TabIndex = 13;
            this.dataRdbtnGider.TabStop = true;
            this.dataRdbtnGider.Text = "Gider";
            this.dataRdbtnGider.UseVisualStyleBackColor = true;
            // 
            // dataRdbtnGelir
            // 
            this.dataRdbtnGelir.AutoSize = true;
            this.dataRdbtnGelir.Location = new System.Drawing.Point(352, 70);
            this.dataRdbtnGelir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRdbtnGelir.Name = "dataRdbtnGelir";
            this.dataRdbtnGelir.Size = new System.Drawing.Size(46, 17);
            this.dataRdbtnGelir.TabIndex = 12;
            this.dataRdbtnGelir.TabStop = true;
            this.dataRdbtnGelir.Text = "Gelir";
            this.dataRdbtnGelir.UseVisualStyleBackColor = true;
            this.dataRdbtnGelir.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // dataRdbtnHepsi
            // 
            this.dataRdbtnHepsi.AutoSize = true;
            this.dataRdbtnHepsi.Location = new System.Drawing.Point(511, 70);
            this.dataRdbtnHepsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataRdbtnHepsi.Name = "dataRdbtnHepsi";
            this.dataRdbtnHepsi.Size = new System.Drawing.Size(52, 17);
            this.dataRdbtnHepsi.TabIndex = 14;
            this.dataRdbtnHepsi.TabStop = true;
            this.dataRdbtnHepsi.Text = "Hepsi";
            this.dataRdbtnHepsi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 290);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(164, 314);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(62, 23);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(80, 314);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 23);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(247, 149);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(56, 19);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(92, 349);
            this.dtpBaslangicTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(151, 20);
            this.dtpBaslangicTarihi.TabIndex = 20;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(92, 371);
            this.dtpBitisTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(151, 20);
            this.dtpBitisTarihi.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bitiş";
            // 
            // Filtrele
            // 
            this.Filtrele.Location = new System.Drawing.Point(259, 353);
            this.Filtrele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Filtrele.Name = "Filtrele";
            this.Filtrele.Size = new System.Drawing.Size(77, 29);
            this.Filtrele.TabIndex = 24;
            this.Filtrele.Text = "FİLTRELE";
            this.Filtrele.UseVisualStyleBackColor = true;
            this.Filtrele.Click += new System.EventHandler(this.Filtrele_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Bk", 14.25F);
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "GELİR GİDER";
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 488);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Filtrele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataRdbtnHepsi);
            this.Controls.Add(this.dataRdbtnGider);
            this.Controls.Add(this.dataRdbtnGelir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cbGelirGiderTipi);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnGider);
            this.Controls.Add(this.rbtnGelir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnGelir;
        private System.Windows.Forms.RadioButton rbtnGider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cbGelirGiderTipi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton dataRdbtnGider;
        private System.Windows.Forms.RadioButton dataRdbtnGelir;
        private System.Windows.Forms.RadioButton dataRdbtnHepsi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Filtrele;
        private System.Windows.Forms.Label label8;
    }
}