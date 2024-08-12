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
    public partial class TarifForm : Form
    {
        public TarifForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            PilavForm pilavForm = new PilavForm();
            pilavForm.ShowDialog();
        }
    }
}
