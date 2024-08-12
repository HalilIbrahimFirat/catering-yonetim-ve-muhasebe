
namespace yemek.Arayüz
{
    partial class Anasayfa
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
            this.yaklasanteslimat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gelirgider = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yaklasanteslimat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirgider)).BeginInit();
            this.SuspendLayout();
            // 
            // yaklasanteslimat
            // 
            this.yaklasanteslimat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yaklasanteslimat.Location = new System.Drawing.Point(12, 102);
            this.yaklasanteslimat.Name = "yaklasanteslimat";
            this.yaklasanteslimat.RowHeadersWidth = 51;
            this.yaklasanteslimat.Size = new System.Drawing.Size(531, 400);
            this.yaklasanteslimat.TabIndex = 0;
            this.yaklasanteslimat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yaklasanteslimat_CellClick);
            this.yaklasanteslimat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yaklasanteslimat_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yaklaşan Teslimatlar";
            // 
            // stok
            // 
            this.stok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stok.Location = new System.Drawing.Point(668, 104);
            this.stok.Name = "stok";
            this.stok.RowHeadersWidth = 51;
            this.stok.Size = new System.Drawing.Size(364, 400);
            this.stok.TabIndex = 2;
            this.stok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stok_CellClick);
            this.stok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stok_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(774, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stoğu Azalanlar";
            // 
            // gelirgider
            // 
            this.gelirgider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gelirgider.Location = new System.Drawing.Point(1024, 433);
            this.gelirgider.Name = "gelirgider";
            this.gelirgider.RowHeadersWidth = 51;
            this.gelirgider.Size = new System.Drawing.Size(8, 8);
            this.gelirgider.TabIndex = 5;
            this.gelirgider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gelirgider_CellClick);
            this.gelirgider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gelirgider_CellContentClick);
            this.gelirgider.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gelirgider_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ANASAYFA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.gelirgider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yaklasanteslimat);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yaklasanteslimat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirgider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView yaklasanteslimat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gelirgider;
        private System.Windows.Forms.Label label2;
    }
}