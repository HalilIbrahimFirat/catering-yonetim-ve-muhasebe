using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catring
{
    class Gelir
    {
        public decimal gelirMiktarı { get; set; }
        public DateTime Tarih { get; set; }

        public Gelir(decimal miktar, DateTime tarih)
        {
            gelirMiktarı = miktar;
            Tarih = tarih;
        }

    }
}
