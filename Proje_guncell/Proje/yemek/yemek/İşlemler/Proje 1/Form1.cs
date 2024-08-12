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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void btnPilav_Click(object sender, EventArgs e)
        {
            PilavForm pilavForm = new PilavForm();
            pilavForm.Show();
            this.Hide();
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            SosluMakarnaForm sosluMakarnaForm = new SosluMakarnaForm();
            sosluMakarnaForm.Show();
            this.Hide();
        }

        private void btnKofte_Click(object sender, EventArgs e)
        {
            RostoKofte rostoKofte = new RostoKofte();
            rostoKofte.Show();
            this.Hide();
        }

        private void btnTantuni_Click(object sender, EventArgs e)
        {
            TavukTantuniForm tavukTantuniForm = new TavukTantuniForm();
            tavukTantuniForm.Show();    
            this.Hide();
        }

        private void btnKebap_Click(object sender, EventArgs e)
        {
            OrmanKebabıForm ormanKebabıForm=new OrmanKebabıForm();
            ormanKebabıForm.Show();
            this.Hide();
        }

    }
}
