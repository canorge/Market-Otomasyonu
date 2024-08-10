using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.User
{
    public class user
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string yetki { get; set; }

        public LoginStatue girisDurumu { get; set; }

    }
}
