
namespace Proje_1
{
    partial class menü
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
            this.dgvYemekler = new System.Windows.Forms.DataGridView();
            this.btnYemekYap = new System.Windows.Forms.Button();
            this.numPorsiyon = new System.Windows.Forms.NumericUpDown();
            this.lblTarif = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorsiyon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYemekler
            // 
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekler.Location = new System.Drawing.Point(103, 82);
            this.dgvYemekler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvYemekler.Name = "dgvYemekler";
            this.dgvYemekler.RowHeadersWidth = 51;
            this.dgvYemekler.Size = new System.Drawing.Size(592, 479);
            this.dgvYemekler.TabIndex = 0;
            this.dgvYemekler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYemekler_CellClick_1);
            // 
            // btnYemekYap
            // 
            this.btnYemekYap.Location = new System.Drawing.Point(919, 172);
            this.btnYemekYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYemekYap.Name = "btnYemekYap";
            this.btnYemekYap.Size = new System.Drawing.Size(139, 43);
            this.btnYemekYap.TabIndex = 1;
            this.btnYemekYap.Text = "Yemeği Yap";
            this.btnYemekYap.UseVisualStyleBackColor = true;
            this.btnYemekYap.Click += new System.EventHandler(this.btnYemekYap_Click);
            // 
            // numPorsiyon
            // 
            this.numPorsiyon.Location = new System.Drawing.Point(919, 140);
            this.numPorsiyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPorsiyon.Name = "numPorsiyon";
            this.numPorsiyon.Size = new System.Drawing.Size(171, 22);
            this.numPorsiyon.TabIndex = 2;
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTarif.Location = new System.Drawing.Point(728, 374);
            this.lblTarif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(166, 31);
            this.lblTarif.TabIndex = 3;
            this.lblTarif.Text = "Yemek Tarifi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(735, 409);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 152);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1077, 409);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(235, 152);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1072, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanılacak Malzemeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(739, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Porsiyon Adeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(315, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "MENÜ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(848, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "SİPARİŞ OLUŞTUR";
            // 
            // menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 640);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.numPorsiyon);
            this.Controls.Add(this.btnYemekYap);
            this.Controls.Add(this.dgvYemekler);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "menü";
            this.Text = "menü";
            this.Load += new System.EventHandler(this.menü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorsiyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYemekler;
        private System.Windows.Forms.Button btnYemekYap;
        private System.Windows.Forms.NumericUpDown numPorsiyon;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}