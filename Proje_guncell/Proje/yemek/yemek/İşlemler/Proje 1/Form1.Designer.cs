namespace Proje_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPilav = new System.Windows.Forms.Button();
            this.btnMakarna = new System.Windows.Forms.Button();
            this.btnKofte = new System.Windows.Forms.Button();
            this.btnTantuni = new System.Windows.Forms.Button();
            this.btnKebap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPilav
            // 
            this.btnPilav.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPilav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPilav.Location = new System.Drawing.Point(436, 130);
            this.btnPilav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPilav.Name = "btnPilav";
            this.btnPilav.Size = new System.Drawing.Size(207, 50);
            this.btnPilav.TabIndex = 0;
            this.btnPilav.Text = "Pilav";
            this.btnPilav.UseVisualStyleBackColor = false;
            this.btnPilav.Click += new System.EventHandler(this.btnPilav_Click);
            // 
            // btnMakarna
            // 
            this.btnMakarna.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMakarna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMakarna.Location = new System.Drawing.Point(436, 199);
            this.btnMakarna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakarna.Name = "btnMakarna";
            this.btnMakarna.Size = new System.Drawing.Size(207, 50);
            this.btnMakarna.TabIndex = 1;
            this.btnMakarna.Text = "Soslu Makarna";
            this.btnMakarna.UseVisualStyleBackColor = false;
            this.btnMakarna.Click += new System.EventHandler(this.btnMakarna_Click);
            // 
            // btnKofte
            // 
            this.btnKofte.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKofte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKofte.Location = new System.Drawing.Point(436, 267);
            this.btnKofte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKofte.Name = "btnKofte";
            this.btnKofte.Size = new System.Drawing.Size(207, 50);
            this.btnKofte.TabIndex = 2;
            this.btnKofte.Text = "Rosto Köfte";
            this.btnKofte.UseVisualStyleBackColor = false;
            this.btnKofte.Click += new System.EventHandler(this.btnKofte_Click);
            // 
            // btnTantuni
            // 
            this.btnTantuni.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTantuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTantuni.Location = new System.Drawing.Point(436, 331);
            this.btnTantuni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTantuni.Name = "btnTantuni";
            this.btnTantuni.Size = new System.Drawing.Size(207, 50);
            this.btnTantuni.TabIndex = 3;
            this.btnTantuni.Text = "Tavuk Tantuni";
            this.btnTantuni.UseVisualStyleBackColor = false;
            this.btnTantuni.Click += new System.EventHandler(this.btnTantuni_Click);
            // 
            // btnKebap
            // 
            this.btnKebap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKebap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKebap.Location = new System.Drawing.Point(436, 396);
            this.btnKebap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKebap.Name = "btnKebap";
            this.btnKebap.Size = new System.Drawing.Size(207, 50);
            this.btnKebap.TabIndex = 4;
            this.btnKebap.Text = "Orman Kebabı";
            this.btnKebap.UseVisualStyleBackColor = false;
            this.btnKebap.Click += new System.EventHandler(this.btnKebap_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(413, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 71);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENÜ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKebap);
            this.Controls.Add(this.btnTantuni);
            this.Controls.Add(this.btnKofte);
            this.Controls.Add(this.btnMakarna);
            this.Controls.Add(this.btnPilav);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPilav;
        private System.Windows.Forms.Button btnMakarna;
        private System.Windows.Forms.Button btnKofte;
        private System.Windows.Forms.Button btnTantuni;
        private System.Windows.Forms.Button btnKebap;
        private System.Windows.Forms.Label label1;
    }
}

