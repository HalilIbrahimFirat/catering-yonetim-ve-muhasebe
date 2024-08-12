
namespace yemek.Arayüz
{
    partial class Yönetim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.şifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxGorev = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.şifretkr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yenişifretkr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.yenişifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eskişifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kullanıcıekle = new System.Windows.Forms.Button();
            this.sifregüncelle = new System.Windows.Forms.Button();
            this.kullanıcıadı = new System.Windows.Forms.TextBox();
            this.hatalbl = new System.Windows.Forms.Label();
            this.güncellblhata = new System.Windows.Forms.Label();
            this.güncelka = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(540, 499);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(566, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(569, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı İsmi:";
            // 
            // şifre
            // 
            this.şifre.ForeColor = System.Drawing.Color.Silver;
            this.şifre.Location = new System.Drawing.Point(662, 162);
            this.şifre.Multiline = true;
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(119, 24);
            this.şifre.TabIndex = 5;
            this.şifre.Text = "Şifre";
            this.şifre.TextChanged += new System.EventHandler(this.şifre_TextChanged);
            this.şifre.Enter += new System.EventHandler(this.şifre_Enter);
            this.şifre.Leave += new System.EventHandler(this.şifre_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(569, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(567, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre (Tekrar):";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(788, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxGorev
            // 
            this.comboBoxGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGorev.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGorev.FormattingEnabled = true;
            this.comboBoxGorev.Items.AddRange(new object[] {
            "Yönetici",
            "Aşçı",
            "Muhasebeci"});
            this.comboBoxGorev.Location = new System.Drawing.Point(660, 244);
            this.comboBoxGorev.Name = "comboBoxGorev";
            this.comboBoxGorev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGorev.TabIndex = 9;
            this.comboBoxGorev.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(569, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Görevi :";
            // 
            // şifretkr
            // 
            this.şifretkr.ForeColor = System.Drawing.Color.Silver;
            this.şifretkr.Location = new System.Drawing.Point(662, 202);
            this.şifretkr.Multiline = true;
            this.şifretkr.Name = "şifretkr";
            this.şifretkr.Size = new System.Drawing.Size(119, 24);
            this.şifretkr.TabIndex = 11;
            this.şifretkr.Text = "Şifre";
            this.şifretkr.Enter += new System.EventHandler(this.şifretkr_Enter);
            this.şifretkr.Leave += new System.EventHandler(this.şifretkr_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(194, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kayıtlı Kullanıcılar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(568, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şifre Yenileme";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // yenişifretkr
            // 
            this.yenişifretkr.ForeColor = System.Drawing.Color.Silver;
            this.yenişifretkr.Location = new System.Drawing.Point(897, 490);
            this.yenişifretkr.Multiline = true;
            this.yenişifretkr.Name = "yenişifretkr";
            this.yenişifretkr.Size = new System.Drawing.Size(119, 24);
            this.yenişifretkr.TabIndex = 19;
            this.yenişifretkr.Text = "Yeni Şifre";
            this.yenişifretkr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.yenişifretkr.Enter += new System.EventHandler(this.yenişifretkr_Enter);
            this.yenişifretkr.Leave += new System.EventHandler(this.yenişifretkr_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(810, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Yeni Şifre\r\n(Tekrar):";
            // 
            // yenişifre
            // 
            this.yenişifre.ForeColor = System.Drawing.Color.Silver;
            this.yenişifre.Location = new System.Drawing.Point(662, 483);
            this.yenişifre.Multiline = true;
            this.yenişifre.Name = "yenişifre";
            this.yenişifre.Size = new System.Drawing.Size(119, 24);
            this.yenişifre.TabIndex = 17;
            this.yenişifre.Text = "Yeni Şifre";
            this.yenişifre.Enter += new System.EventHandler(this.yenişifre_Enter);
            this.yenişifre.Leave += new System.EventHandler(this.yenişifre_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(569, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yeni Şifre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(567, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Kullanıcı İsmi:";
            // 
            // eskişifre
            // 
            this.eskişifre.ForeColor = System.Drawing.Color.Silver;
            this.eskişifre.Location = new System.Drawing.Point(897, 430);
            this.eskişifre.Multiline = true;
            this.eskişifre.Name = "eskişifre";
            this.eskişifre.Size = new System.Drawing.Size(119, 24);
            this.eskişifre.TabIndex = 21;
            this.eskişifre.Text = "Eski Şifre";
            this.eskişifre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.eskişifre.Enter += new System.EventHandler(this.eskişifre_Enter);
            this.eskişifre.Leave += new System.EventHandler(this.eskişifre_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(808, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Eski Şifre:";
            // 
            // kullanıcıekle
            // 
            this.kullanıcıekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıekle.Location = new System.Drawing.Point(570, 273);
            this.kullanıcıekle.Margin = new System.Windows.Forms.Padding(2);
            this.kullanıcıekle.Name = "kullanıcıekle";
            this.kullanıcıekle.Size = new System.Drawing.Size(64, 23);
            this.kullanıcıekle.TabIndex = 22;
            this.kullanıcıekle.Text = "Kaydet";
            this.kullanıcıekle.UseVisualStyleBackColor = true;
            this.kullanıcıekle.Click += new System.EventHandler(this.kullanıcıekle_Click);
            // 
            // sifregüncelle
            // 
            this.sifregüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifregüncelle.Location = new System.Drawing.Point(570, 529);
            this.sifregüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.sifregüncelle.Name = "sifregüncelle";
            this.sifregüncelle.Size = new System.Drawing.Size(64, 28);
            this.sifregüncelle.TabIndex = 23;
            this.sifregüncelle.Text = "Güncelle";
            this.sifregüncelle.UseVisualStyleBackColor = true;
            this.sifregüncelle.Click += new System.EventHandler(this.sifregüncelle_Click);
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.ForeColor = System.Drawing.Color.Silver;
            this.kullanıcıadı.Location = new System.Drawing.Point(662, 121);
            this.kullanıcıadı.Multiline = true;
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.Size = new System.Drawing.Size(119, 24);
            this.kullanıcıadı.TabIndex = 24;
            this.kullanıcıadı.Text = "Kullanıcı Adı";
            this.kullanıcıadı.TextChanged += new System.EventHandler(this.kullanıcıadı_TextChanged);
            this.kullanıcıadı.Enter += new System.EventHandler(this.kullanıcıadı_Enter_1);
            this.kullanıcıadı.Leave += new System.EventHandler(this.kullanıcıadı_Leave_1);
            // 
            // hatalbl
            // 
            this.hatalbl.AutoSize = true;
            this.hatalbl.ForeColor = System.Drawing.Color.Red;
            this.hatalbl.Location = new System.Drawing.Point(658, 273);
            this.hatalbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hatalbl.Name = "hatalbl";
            this.hatalbl.Size = new System.Drawing.Size(0, 13);
            this.hatalbl.TabIndex = 25;
            // 
            // güncellblhata
            // 
            this.güncellblhata.AutoSize = true;
            this.güncellblhata.ForeColor = System.Drawing.Color.Red;
            this.güncellblhata.Location = new System.Drawing.Point(661, 529);
            this.güncellblhata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.güncellblhata.Name = "güncellblhata";
            this.güncellblhata.Size = new System.Drawing.Size(0, 13);
            this.güncellblhata.TabIndex = 26;
            // 
            // güncelka
            // 
            this.güncelka.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.güncelka.ForeColor = System.Drawing.Color.Silver;
            this.güncelka.Location = new System.Drawing.Point(660, 435);
            this.güncelka.Multiline = true;
            this.güncelka.Name = "güncelka";
            this.güncelka.Size = new System.Drawing.Size(119, 24);
            this.güncelka.TabIndex = 27;
            this.güncelka.Text = "Kullanıcı Adı";
            this.güncelka.TextChanged += new System.EventHandler(this.güncelka_TextChanged);
            this.güncelka.Enter += new System.EventHandler(this.güncelka_Enter_1);
            this.güncelka.Leave += new System.EventHandler(this.güncelka_Leave_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1021, 429);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 30);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Şifreyi \r\nGöster";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1021, 485);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 30);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Şifreyi\r\nGöster";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(438, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "KULLANICI YÖNETİM";
            // 
            // Yönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 611);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.güncelka);
            this.Controls.Add(this.güncellblhata);
            this.Controls.Add(this.hatalbl);
            this.Controls.Add(this.kullanıcıadı);
            this.Controls.Add(this.sifregüncelle);
            this.Controls.Add(this.kullanıcıekle);
            this.Controls.Add(this.eskişifre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.yenişifretkr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yenişifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.şifretkr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGorev);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Yönetim";
            this.Text = "Yönetim";
            this.Load += new System.EventHandler(this.Yönetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox şifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxGorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox şifretkr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yenişifretkr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yenişifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox eskişifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button kullanıcıekle;
        private System.Windows.Forms.Button sifregüncelle;
        private System.Windows.Forms.TextBox kullanıcıadı;
        private System.Windows.Forms.Label hatalbl;
        private System.Windows.Forms.Label güncellblhata;
        private System.Windows.Forms.TextBox güncelka;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label12;
    }
}