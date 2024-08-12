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
    public partial class TarifForm3 : Form
    {
        public TarifForm3()
        {
            InitializeComponent();
        }

        private void bgeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            TavukTantuniForm tavukTantuniForm = new TavukTantuniForm();
            tavukTantuniForm.Show();
        }
    }
}
