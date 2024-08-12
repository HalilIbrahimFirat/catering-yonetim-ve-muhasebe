using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catring
{
    class Gider
    {
        public decimal giderMiktarı { get; set; }
        public DateTime Tarih { get; set; }

        public Gider(decimal miktar, DateTime tarih)
        {
            giderMiktarı = miktar;
            Tarih = tarih;
        }
    }
}
