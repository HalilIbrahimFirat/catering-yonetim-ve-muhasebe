using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catring
{
    class Malzeme
    {
        public string Adi { get; set; }
        public float Adet { get; set; }
        public float MinimumStok { get; set; }
        public float BirimFiyat { get; set; } 

        public Malzeme(string adi, float adet, float minimumStok, float birimFiyat)
        {
            Adi = adi;
            Adet = adet;
            MinimumStok = minimumStok;
            BirimFiyat = birimFiyat; 
        }
    }
}


