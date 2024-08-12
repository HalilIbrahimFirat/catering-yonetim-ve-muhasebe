using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class TarifForm2 : Form
    {
        public TarifForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RostoKofte rostoKofteForm = new RostoKofte();
            rostoKofteForm.ShowDialog();
        }
    }
}
