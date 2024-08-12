using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek.Ayarlar
{
    public partial class uygulamaayar : Form
    {
        public uygulamaayar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Edildi");
            this.Close();
        }

        private void uygulamaayar_Load(object sender, EventArgs e)
        {

        }
    }
}
