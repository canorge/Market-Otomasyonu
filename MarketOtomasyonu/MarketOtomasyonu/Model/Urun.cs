using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Model
{
    public class Urun
    {
        public string ad { get; set; }
        public string barkod { get; set; }
        public string sonTuketimTarihi{ get; set; }
        public string adet { get; set; }
        public float fiyat {  get; set; }
        public string tur { get; set; }

    }
}
