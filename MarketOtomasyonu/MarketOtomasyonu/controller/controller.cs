using MarketOtomasyonu.Model;
using MarketOtomasyonu.repository;
using MarketOtomasyonu.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public List<Urun> aburCuburGetir()
        {
            return r1.aburCuburGetir();
        }
        public List<Urun> sebzeGetir()
        {
            return r1.sebzeGetir();
        }

        public LoginStatue aburCuburEkle(string barkod, string sonTuketimTarihi, string ad, string adet, string fiyat)
        {
            if (string.IsNullOrEmpty(barkod) || string.IsNullOrEmpty(sonTuketimTarihi) || string.IsNullOrEmpty(ad)
                || string.IsNullOrEmpty(adet.ToString()) || string.IsNullOrEmpty(fiyat.ToString()))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.aburCuburEkle(barkod, sonTuketimTarihi, ad, int.Parse(adet), float.Parse(fiyat));
            }
        }

        public LoginStatue aburCuburSil(string barkod)
        {
            if(string.IsNullOrEmpty(barkod))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.urunSil(barkod);
            }
        }

        public LoginStatue aburCuburGuncelle(string barkod, string ad = null, string stt = null, string fiyat = null, string adet = null)
        {
            if(string.IsNullOrEmpty(barkod))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.aburCuburGuncelle(barkod, ad, stt, fiyat, adet);
            }
        }

        public LoginStatue sebzeEkle(string barkod, string sonTuketimTarihi, string ad, string adet, string fiyat)
        {
            if (string.IsNullOrEmpty(barkod) || string.IsNullOrEmpty(sonTuketimTarihi) || string.IsNullOrEmpty(ad)
                || string.IsNullOrEmpty(adet.ToString()) || string.IsNullOrEmpty(fiyat.ToString()))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.SebzeEkle(barkod, sonTuketimTarihi, ad, int.Parse(adet), float.Parse(fiyat));
            }
        }

        public LoginStatue sebzeGuncelle(string barkod, string ad = null, string stt = null, string fiyat = null, string adet = null)
        {
            if (string.IsNullOrEmpty(barkod))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.sebzeGuncelle(barkod, ad, stt, fiyat, adet);
            }
        }

        public LoginStatue sebzeSil(string barkod)
        {
            if (string.IsNullOrEmpty(barkod))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.urunSil(barkod);
            }
        }

        public List<user> adminGetir()
        {
            return r1.adminGetir(); 
        }

        public LoginStatue adminEkle(string ad,string soyad,string email,string kullaniciAdi,string sifre,string yetki)
        {
            if(string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(kullaniciAdi) ||string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(yetki))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.adminEkle(ad,soyad,email,kullaniciAdi,sifre,yetki);
            }
        }

        public LoginStatue kisiGuncelle(string kullaniciAdi, string ad = null, string soyad = null, string sifre = null)
        {
            if(string.IsNullOrEmpty(kullaniciAdi))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.kisiGuncelle(kullaniciAdi,ad,soyad,sifre);
            }
        }

        public LoginStatue kisiSil(string kullaniciadi)
        {
            if(string.IsNullOrEmpty (kullaniciadi))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.kisiSil(kullaniciadi);
            }
        }

        public List<user> kasiyerGetir()
        {
            return r1.kasiyerGetir();
        }

        public LoginStatue kasiyerEkle(string ad, string soyad, string email, string kullaniciAdi, string sifre, string yetki)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(yetki))
            {
                return LoginStatue.eksikParametre;
            }
            else
            {
                return r1.kasiyerEkle(ad, soyad, email, kullaniciAdi, sifre, yetki);
            }
        }

        public void urunOdemesiYap(List<Urun> UrunListesi)
        {
            r1.urunOdemesiYap(UrunListesi);
        }
    }
}
