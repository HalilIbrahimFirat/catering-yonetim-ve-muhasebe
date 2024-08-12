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
    public partial class TarifForm1 : Form
    {
        public TarifForm1()
        {
            InitializeComponent();
        }

        private void btnGeriDon1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SosluMakarnaForm sosluMakarnaForm=new SosluMakarnaForm();
            sosluMakarnaForm.ShowDialog();
        }

    }
}
