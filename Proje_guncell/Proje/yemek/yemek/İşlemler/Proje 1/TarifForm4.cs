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
    public partial class TarifForm4 : Form
    {
        public TarifForm4()
        {
            InitializeComponent();
        }

        private void gitGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrmanKebabıForm ormanKebabıForm = new OrmanKebabıForm();
            ormanKebabıForm.ShowDialog();
        }
    }
}
