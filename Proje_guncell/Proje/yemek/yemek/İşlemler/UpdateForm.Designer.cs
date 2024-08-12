
namespace yemek.İşlemler
{
    partial class UpdateForm
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
            this.tsmttutarı = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tsmtbaşlangıç = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tsmtsaat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tsmtbitiş = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.günler = new System.Windows.Forms.CheckedListBox();
            this.tsmtbasla = new System.Windows.Forms.Label();
            this.tsmtsor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tsmtadres = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsmtadı = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tsmttutarı
            // 
            this.tsmttutarı.Location = new System.Drawing.Point(307, 170);
            this.tsmttutarı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tsmttutarı.Multiline = true;
            this.tsmttutarı.Name = "tsmttutarı";
            this.tsmttutarı.Size = new System.Drawing.Size(195, 27);
            this.tsmttutarı.TabIndex = 53;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(307, 133);
            this.telno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telno.Multiline = true;
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(195, 27);
            this.telno.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(162, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Telefon Numarası:";
            // 
            // tsmtbaşlangıç
            // 
            this.tsmtbaşlangıç.Location = new System.Drawing.Point(307, 218);
            this.tsmtbaşlangıç.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmtbaşlangıç.Name = "tsmtbaşlangıç";
            this.tsmtbaşlangıç.Size = new System.Drawing.Size(195, 22);
            this.tsmtbaşlangıç.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 577);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 49;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(234, 430);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 48;
            this.label11.Text = "Adres:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tsmtsaat
            // 
            this.tsmtsaat.FormattingEnabled = true;
            this.tsmtsaat.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.tsmtsaat.Location = new System.Drawing.Point(307, 385);
            this.tsmtsaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmtsaat.Name = "tsmtsaat";
            this.tsmtsaat.Size = new System.Drawing.Size(195, 24);
            this.tsmtsaat.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(211, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Bitiş Tarihi:";
            // 
            // tsmtbitiş
            // 
            this.tsmtbitiş.Location = new System.Drawing.Point(307, 350);
            this.tsmtbitiş.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmtbitiş.Name = "tsmtbitiş";
            this.tsmtbitiş.Size = new System.Drawing.Size(195, 22);
            this.tsmtbitiş.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(167, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Teslimat Günleri:";
            // 
            // günler
            // 
            this.günler.FormattingEnabled = true;
            this.günler.Items.AddRange(new object[] {
            "PAZARTESİ",
            "SALI",
            "ÇARŞAMBA",
            "PERŞEMBE",
            "CUMA ",
            "CUMARTESİ",
            "PAZAR"});
            this.günler.Location = new System.Drawing.Point(307, 254);
            this.günler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.günler.Name = "günler";
            this.günler.Size = new System.Drawing.Size(195, 72);
            this.günler.TabIndex = 39;
            // 
            // tsmtbasla
            // 
            this.tsmtbasla.AutoSize = true;
            this.tsmtbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmtbasla.Location = new System.Drawing.Point(178, 222);
            this.tsmtbasla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tsmtbasla.Name = "tsmtbasla";
            this.tsmtbasla.Size = new System.Drawing.Size(116, 18);
            this.tsmtbasla.TabIndex = 38;
            this.tsmtbasla.Text = "Başlangıç Tarihi:";
            // 
            // tsmtsor
            // 
            this.tsmtsor.Location = new System.Drawing.Point(307, 97);
            this.tsmtsor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tsmtsor.Multiline = true;
            this.tsmtsor.Name = "tsmtsor";
            this.tsmtsor.Size = new System.Drawing.Size(195, 27);
            this.tsmtsor.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(178, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teslimat Tutarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(146, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Teslimat Sorumlusu:";
            // 
            // tsmtadres
            // 
            this.tsmtadres.Location = new System.Drawing.Point(247, 451);
            this.tsmtadres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmtadres.Name = "tsmtadres";
            this.tsmtadres.Size = new System.Drawing.Size(255, 114);
            this.tsmtadres.TabIndex = 34;
            this.tsmtadres.Text = "";
            this.tsmtadres.TextChanged += new System.EventHandler(this.tsmtadres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(183, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Teslimat Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(197, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Teslimat Adı:";
            // 
            // tsmtadı
            // 
            this.tsmtadı.Location = new System.Drawing.Point(307, 62);
            this.tsmtadı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tsmtadı.Multiline = true;
            this.tsmtadı.Name = "tsmtadı";
            this.tsmtadı.Size = new System.Drawing.Size(195, 27);
            this.tsmtadı.TabIndex = 31;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(675, 601);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 24);
            this.comboBox2.TabIndex = 55;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(675, 567);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 24);
            this.comboBox1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "TESLİMAT GÜNCELLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tsmttutarı);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tsmtbaşlangıç);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tsmtsaat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tsmtbitiş);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.günler);
            this.Controls.Add(this.tsmtbasla);
            this.Controls.Add(this.tsmtsor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsmtadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsmtadı);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateForm";
            this.Text = "Teslimat Güncelle";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tsmttutarı;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tsmtbaşlangıç;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tsmtsaat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tsmtbitiş;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox günler;
        private System.Windows.Forms.Label tsmtbasla;
        private System.Windows.Forms.TextBox tsmtsor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tsmtadres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsmtadı;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}