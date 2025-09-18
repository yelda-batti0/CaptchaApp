using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices2
{
    internal class Musteri
    {
        public int id;
        public string isim;
        private string soyisim;
        private string sehir;

        public string Soyisim { get => soyisim; set => soyisim = value.ToLower(); }
        public string Sehir { get => sehir; set => sehir = value.ToUpper(); }
    }
}
