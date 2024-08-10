using MarketOtomasyonu.Model;
using MarketOtomasyonu.repository;
using MarketOtomasyonu.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MarketOtomasyonu.controller
{
    public class Controller
    {
        Repository r1;

        public Controller()
        {
            r1 = new Repository();
        }
        public user girisYap(string kullaniciadi,string sifre)
        {
            if (!string.IsNullOrEmpty(sifre) && !string.IsNullOrEmpty(kullaniciadi))
            {
                return r1.girisYap(kullaniciadi, sifre);
            }
            else
            {
                user user = new user();
                user.girisDurumu = LoginStatue.eksikParametre;
                return user;
            }
        }
        public LoginStatue emailKullaniciAdiDogruMu(string email, string kullaniciadi)
        {
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(kullaniciadi))
            {
                return r1.emailKullaniciAdiDogruMu(email, kullaniciadi);
            }
            else
            {
                return LoginStatue.eksikParametre;
            }
        }

        public LoginStatue sifreDegistir(string sifre,string sifre2,string email,string kullaniciadi)
        {
            if(!string.IsNullOrEmpty(sifre) && !string.IsNullOrEmpty(sifre2) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty (kullaniciadi))
            {
                if (sifre == sifre2)
                {
                    return r1.sifreDegistir(sifre, email, kullaniciadi);
                }
                else
                {
                    return LoginStatue.farkli;
                }
            }
            else
            {
                return LoginStatue.eksikParametre;
            }


        }

        public Urun urunGetir(string barkod)
        {
            if(!string.IsNullOrEmpty(barkod))
            {
                return r1.urunGetir(barkod);
            }
            else
            {
                return null;
            }
        }
    }
}
