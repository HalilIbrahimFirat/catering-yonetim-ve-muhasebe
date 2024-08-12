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
            this.btnMakarna = new System.Windows.Forms.Button();
            this.menüpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakarna
            // 
            this.btnMakarna.BackColor = System.Drawing.Color.Bisque;
            this.btnMakarna.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMakarna.Location = new System.Drawing.Point(28, 14);
            this.btnMakarna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakarna.Name = "btnMakarna";
            this.btnMakarna.Size = new System.Drawing.Size(244, 60);
            this.btnMakarna.TabIndex = 1;
            this.btnMakarna.Text = "MENÜ";
            this.btnMakarna.UseVisualStyleBackColor = false;
            this.btnMakarna.Click += new System.EventHandler(this.btnMakarna_Click);
            // 
            // menüpanel
            // 
            this.menüpanel.BackColor = System.Drawing.Color.Transparent;
            this.menüpanel.Location = new System.Drawing.Point(28, 79);
            this.menüpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menüpanel.Name = "menüpanel";
            this.menüpanel.Size = new System.Drawing.Size(1411, 674);
            this.menüpanel.TabIndex = 6;
            this.menüpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menüpanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "YEMEK EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1451, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menüpanel);
            this.Controls.Add(this.btnMakarna);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMakarna;
        private System.Windows.Forms.Panel menüpanel;
        private System.Windows.Forms.Button button1;
    }
}

