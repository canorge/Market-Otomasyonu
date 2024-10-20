using MarketOtomasyonu.Model;
using MarketOtomasyonu.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode.Internal;

namespace MarketOtomasyonu.repository
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Repository()
        {
            con = new SqlConnection("data source=CANORGE\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
        }

        public user girisYap(string kullaniciadi,string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select yetki from kisi where kullaniciadi=@v1 and sifre=@v2", con);
            cmd.Parameters.AddWithValue("@v1", kullaniciadi);
            cmd.Parameters.AddWithValue("@v2", sifre);
            dr=cmd.ExecuteReader();
            

            if(dr.Read())
            {
                user user = new user();
                user.yetki = dr["yetki"].ToString();
                user.girisDurumu = LoginStatue.basarili;
                con.Close();
                return user;
            }
            else
            {
                user user=new user();
                user.girisDurumu= LoginStatue.basarisiz;
                con.Close();
                return user;
            }
           
        }

        public string yetkiGetir(string kullaniciadi,string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select yetki from kisi where kullaniciadi=@v1 and sifre=@v2", con);
            cmd.Parameters.AddWithValue("@v1", kullaniciadi);
            cmd.Parameters.AddWithValue("@v2", sifre);
            string yetki=cmd.ExecuteScalar().ToString();
            con.Close();
            return yetki;
        }

        public LoginStatue emailKullaniciAdiDogruMu(string email,string kullaniciadi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from kisi where email=@v1 and kullaniciadi=@v2",con);
            cmd.Parameters.AddWithValue("@v1", email);
            cmd.Parameters.AddWithValue("@v2", kullaniciadi);

            int result=(int)cmd.ExecuteScalar();
            con.Close();
            if (result ==1)
            {
                return LoginStatue.basarili;
            }
            else
            {
                return LoginStatue.basarisiz;
            }
        }

       public LoginStatue sifreDegistir(string sifre,string email,string kullaniciadi)
        {
            con.Open();
            cmd = new SqlCommand("update kisi set sifre=@v1 where email=@v2 and kullaniciadi=@v3", con);
            cmd.Parameters.AddWithValue("@v1", sifre);
            cmd.Parameters.AddWithValue ("@v2", email);
            cmd.Parameters.AddWithValue("@v3", kullaniciadi);

            int result=cmd.ExecuteNonQuery();
            con.Close();

            if(result ==1)
            {
                return LoginStatue.basarili;
            }
            else
            {
                return LoginStatue.basarisiz;
            }
        }

        public Urun urunGetir(string barkod)
        {
            con.Open();
            cmd = new SqlCommand("select fiyat,ad,barkod,tur from Urun  where barkod=@v1 ", con);
            cmd.Parameters.AddWithValue("@v1", barkod);
            dr=cmd.ExecuteReader();

            if(dr.Read()) 
            {
                Urun urun = new Urun();
                urun.fiyat = float.Parse(dr["fiyat"].ToString());
                urun.ad = dr["ad"].ToString();
                urun.barkod = dr["barkod"].ToString();
                urun.tur = dr["tur"].ToString();
                con.Close();
                return urun;
            }
            else
            {
                con.Close ();
                return null; 
            }

        }

        public List<Urun> aburCuburGetir()
        {
            List<Urun> urunListesi = new List<Urun>();
            con.Open();
            cmd = new SqlCommand("select Urun.ad,Urun.barkod,Urun.sonTüketimTarihi,Urun.adet,Urun.fiyat from Urun where tur='aburcubur'", con);
            dr=cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Urun urun = new Urun();
                    urun.ad = dr["ad"].ToString();
                    urun.barkod = dr["barkod"].ToString();
                    urun.sonTuketimTarihi = dr["sonTüketimTarihi"].ToString();
                    urun.adet = dr["adet"].ToString();
                    urun.fiyat = float.Parse(dr["fiyat"].ToString());
                    urunListesi.Add(urun);
                    
                }
                con.Close();
                return urunListesi;
            }
            else
            {
                con.Close();
                return null;
            }     
          
        }

        public List<Urun> sebzeGetir()
        {
            List<Urun> urunListesi = new List<Urun>();
            con.Open();
            cmd = new SqlCommand("select Urun.ad,Urun.barkod,Urun.sonTüketimTarihi,Urun.adet,Urun.fiyat from Urun where tur='sebze'", con);
            dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Urun urun = new Urun();
                    urun.ad = dr["ad"].ToString();
                    urun.barkod = dr["barkod"].ToString();
                    urun.sonTuketimTarihi = dr["sonTüketimTarihi"].ToString();
                    urun.adet = dr["adet"].ToString();
                    urun.fiyat = float.Parse(dr["fiyat"].ToString());
                    urunListesi.Add(urun);
                    
                }
                con.Close();
                return urunListesi;
            }
            else
            {
                con.Close();
                return null;
            }

        }

        public LoginStatue aburCuburEkle(string barkod,string sonTuketimTarihi,string ad,int adet,float fiyat)
        {
            con.Open();

            object urunVarMi = UrunVarMi(barkod);

            if(urunVarMi == null)
            {
                cmd = new SqlCommand("insert into Urun(barkod,sonTüketimTarihi,ad,tur,adet,fiyat) values(@v1,@v2,@v3,'aburcubur',@v4,@v5)", con);
                cmd.Parameters.AddWithValue("@v1", barkod);
                cmd.Parameters.AddWithValue("@v2", sonTuketimTarihi);
                cmd.Parameters.AddWithValue("@v3", ad);
                cmd.Parameters.AddWithValue("@v4", adet);
                cmd.Parameters.AddWithValue("@v5", fiyat);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    con.Close();
                    return LoginStatue.basarili;
                }
                else
                {
                    con.Close();
                    return LoginStatue.basarisiz;
                }
            }
            else
            {
                con.Close();
                return LoginStatue.ayniParametre;
            }

            
        }

        


        // barkodu verilen ürünün idsini alma
        private int idGetir(string barkod)
        {
            
            cmd = new SqlCommand("select id from Urun where barkod=@v1 ", con);
            cmd.Parameters.AddWithValue("@v1", barkod);
            int id=int.Parse(cmd.ExecuteScalar().ToString());
            return id;
        }

        public LoginStatue aburCuburGuncelle(string barkod,string ad=null,string stt=null,string fiyat=null,string adet=null)
        {
            
            con.Open();
            

            if(!string.IsNullOrEmpty(ad) || !string.IsNullOrEmpty(stt))
            {
                StringBuilder sqlQuery = new StringBuilder("update Urun set");
                bool firstSet = true;
                if (!string.IsNullOrEmpty(ad))
                {
                    firstSet=false;
                    sqlQuery.Append(" ad=@ad");
                }
                if (!string.IsNullOrEmpty(stt))
                {
                    if(!firstSet)
                    {
                        sqlQuery.Append(" , ");
                    }
                    sqlQuery.Append(" sonTüketimTarihi=@stt");
                }
                string finalQuery = sqlQuery.ToString().TrimEnd(',', ' ') + " WHERE barkod = @barkod";
                cmd= new SqlCommand(finalQuery, con);
                cmd.Parameters.AddWithValue("@barkod", barkod);
                if (!string.IsNullOrEmpty(ad))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                }
                if (!string.IsNullOrEmpty(stt))
                {
                    cmd.Parameters.AddWithValue("@stt",stt);
                }
                cmd.ExecuteNonQuery();
            }
            
            if(!string.IsNullOrEmpty(adet) || !string.IsNullOrEmpty(fiyat))
            {
                bool firstSet = true;
                int id = idGetir(barkod);
                StringBuilder sqlQuery = new StringBuilder("update Urun set");
                if (!string.IsNullOrEmpty(fiyat))
                {
                    firstSet = false;
                    sqlQuery.Append(" fiyat=@fiyat");
                }
                if (!string.IsNullOrEmpty(adet))
                {
                    if (!firstSet)
                    {
                        sqlQuery.Append(" , ");
                    }
                    sqlQuery.Append(" adet=@adet");
                }
                string finalQuery = sqlQuery.ToString().TrimEnd(',', ' ') + " where id=@id";
                cmd= new SqlCommand(finalQuery, con);
                cmd.Parameters.AddWithValue("@id", id);
                if (!string.IsNullOrEmpty(fiyat))
                {
                    cmd.Parameters.AddWithValue("@fiyat", float.Parse(fiyat));
                }
                if (!string.IsNullOrEmpty(adet))
                {
                    cmd.Parameters.AddWithValue("@adet",int.Parse(adet));
                }
                cmd.ExecuteNonQuery();
             }
            
            con.Close();

            return LoginStatue.basarili;
        }

        public LoginStatue SebzeEkle(string barkod, string sonTuketimTarihi, string ad, int adet, float fiyat)
        {
            con.Open();

            object urunVarMi = UrunVarMi(barkod);

            if (urunVarMi == null)
            {
                cmd = new SqlCommand("insert into Urun(barkod,sonTuketimTarihi,ad,tur,adet,fiyat) values(@v1,@v2,@v3,'aburcubur',@v4,@v5)", con);
                cmd.Parameters.AddWithValue("@v1", barkod);
                cmd.Parameters.AddWithValue("@v2", sonTuketimTarihi);
                cmd.Parameters.AddWithValue("@v3", ad);
                cmd.Parameters.AddWithValue("@v4", adet);
                cmd.Parameters.AddWithValue("@v5", fiyat);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    con.Close();
                    return LoginStatue.basarili;
                }
                else
                {
                    con.Close();
                    return LoginStatue.basarisiz;
                }
            }
            else
            {
                con.Close();
                return LoginStatue.ayniParametre;
            }
        }

        public LoginStatue sebzeGuncelle(string barkod, string ad = null, string stt = null, string fiyat = null, string adet = null)
        {

            con.Open();


            if (!string.IsNullOrEmpty(ad) || !string.IsNullOrEmpty(stt))
            {
                StringBuilder sqlQuery = new StringBuilder("update Urun set");
                bool firstSet = true;
                if (!string.IsNullOrEmpty(ad))
                {
                    firstSet = false;
                    sqlQuery.Append(" ad=@ad");
                }
                if (!string.IsNullOrEmpty(stt))
                {
                    if (!firstSet)
                    {
                        sqlQuery.Append(" , ");
                    }
                    sqlQuery.Append(" sonTüketimTarihi=@stt");
                }
                string finalQuery = sqlQuery.ToString().TrimEnd(',', ' ') + " WHERE barkod = @barkod";
                cmd = new SqlCommand(finalQuery, con);
                cmd.Parameters.AddWithValue("@barkod", barkod);
                if (!string.IsNullOrEmpty(ad))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                }
                if (!string.IsNullOrEmpty(stt))
                {
                    cmd.Parameters.AddWithValue("@stt", stt);
                }
                cmd.ExecuteNonQuery();
            }

            if (!string.IsNullOrEmpty(adet) || !string.IsNullOrEmpty(fiyat))
            {
                bool firstSet = true;
                int id = idGetir(barkod);
                StringBuilder sqlQuery = new StringBuilder("update Urun set");
                if (!string.IsNullOrEmpty(fiyat))
                {
                    firstSet = false;
                    sqlQuery.Append(" fiyat=@fiyat");
                }
                if (!string.IsNullOrEmpty(adet))
                {
                    if (!firstSet)
                    {
                        sqlQuery.Append(" , ");
                    }
                    sqlQuery.Append(" adet=@adet");
                }
                string finalQuery = sqlQuery.ToString().TrimEnd(',', ' ') + " where id=@id";
                cmd = new SqlCommand(finalQuery, con);
                cmd.Parameters.AddWithValue("@id", id);
                if (!string.IsNullOrEmpty(fiyat))
                {
                    cmd.Parameters.AddWithValue("@fiyat", float.Parse(fiyat));
                }
                if (!string.IsNullOrEmpty(adet))
                {
                    cmd.Parameters.AddWithValue("@adet", int.Parse(adet));
                }
                cmd.ExecuteNonQuery();
            }

            con.Close();

            return LoginStatue.basarili;
        }

        public LoginStatue urunSil(string barkod)
        {
            con.Open();

            cmd = new SqlCommand("select adet from Urun where barkod=@v1", con);
            cmd.Parameters.AddWithValue("@v1", barkod);
            object adet = cmd.ExecuteScalar();
            if (adet != null)
            {
                cmd = new SqlCommand("update Urun set adet=adet-1 where barkod=@v2", con);
                cmd.Parameters.AddWithValue("@v2", barkod);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    return LoginStatue.basarili;
                }
                else
                {
                    return LoginStatue.basarisiz;
                }

            }
            else
            {
                con.Close();
                return LoginStatue.urunYok;
            }

        }

        public List<user> adminGetir()
        {
            List<user> kisiListesi= new List<user>();
            con.Open();
            cmd = new SqlCommand(" select ad,soyad,kullaniciadi,sifre,email from kisi where yetki='Admin'",con);
            dr=cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    user user = new user();
                    user.ad = dr["ad"].ToString();
                    user.soyad = dr["soyad"].ToString();
                    user.kullaniciadi = dr["kullaniciadi"].ToString();
                    user.sifre = dr["sifre"].ToString();
                    user.email = dr["email"].ToString();
                    kisiListesi.Add(user);
                }
                con.Close();
                return kisiListesi;
            }
            else
            {
                con.Close();
                return null;
            }
        }


        public LoginStatue adminEkle(string ad,string soyad,string email,string kullaniciAdi,string sifre,string yetki)
        {
            con.Open();
            bool kontrol = kullaniciAdiVarMi(kullaniciAdi);
            bool kontrol2 = EmailVarMi(email);
            
            if(kontrol && kontrol2)
            {
                cmd = new SqlCommand("insert into kisi(ad,soyad,kullaniciadi,sifre,email,yetki) values(@v1,@v2,@v3,@v4,@v5,@v6) ", con);
                cmd.Parameters.AddWithValue("@v1", ad);
                cmd.Parameters.AddWithValue("@v2", soyad);
                cmd.Parameters.AddWithValue("@v3", kullaniciAdi);
                cmd.Parameters.AddWithValue("@v4", sifre);
                cmd.Parameters.AddWithValue("@v5", email);
                cmd.Parameters.AddWithValue("@v6", yetki);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    con.Close();
                    return LoginStatue.basarili;
                }
                else
                {
                    con.Close();
                    return LoginStatue.basarisiz;
                }
            }
            else
            {
                con.Close();
                if(kontrol)
                {
                    return LoginStatue.ayniEmail;
                }
                else if(kontrol2)
                {
                    return LoginStatue.ayniKullaniciAdi;
                }
                else
                {
                    return LoginStatue.ayniParametre;
                }
            }
           
        }

        public LoginStatue kisiGuncelle(string kullaniciAdi,string ad=null,string soyad=null,string sifre=null)
        {
            
            con.Open();
            
            if(!string.IsNullOrEmpty(ad) || !string.IsNullOrEmpty(soyad) || !string.IsNullOrEmpty(sifre) )
            {
                StringBuilder stringBuilder = new StringBuilder(" update kisi set");
                bool firstSet = true;
                if (!string.IsNullOrEmpty(ad))
                {
                    stringBuilder.Append(" ad=@ad");
                    firstSet = false;
                }
                if(!string.IsNullOrEmpty(soyad))
                {
                    if(!firstSet)
                    {
                        stringBuilder.Append(", soyad =@soyad");
                    }
                    else
                    {
                        stringBuilder.Append(" soyad =@soyad");
                        firstSet = false;
                    }
                }
                if(!string.IsNullOrEmpty(sifre))
                {
                    if(!firstSet)
                    {
                        stringBuilder.Append(" , sifre=@sifre");
                    }
                    else
                    {
                        stringBuilder.Append(" sifre=@sifre");
                    }
                }

                string query = stringBuilder.ToString().TrimEnd(',', ' ') + " where kullaniciadi=@kullaniciadi";
                cmd=new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@kullaniciadi",kullaniciAdi);

                if (!string.IsNullOrEmpty(ad))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                }
                if (!string.IsNullOrEmpty(soyad))
                {
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                }
                if (!string.IsNullOrEmpty(sifre))
                {
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                }
                int result=cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    con.Close();
                    return LoginStatue.basarili;
                }
                else
                {
                    con.Close();
                    return LoginStatue.basarisiz;
                }
            }
            con.Close();  
            return LoginStatue.bosAlan;
            
        }

        public LoginStatue kisiSil(string kullaniciAdi)
        {
            con.Open();
            cmd = new SqlCommand("delete from kisi where kullaniciadi=@v1", con);
            cmd.Parameters.AddWithValue("@v1", kullaniciAdi);
            int result=cmd.ExecuteNonQuery();
            con.Close() ;
            if (result == 1)
            {
                return LoginStatue.basarili;
            }
            else
            {
                return LoginStatue.basarisiz;
            }
        }

        public List<user> kasiyerGetir()
        {
            List<user> kisiListesi = new List<user>();
            con.Open();
            cmd = new SqlCommand(" select ad,soyad,kullaniciadi,sifre,email from kisi where yetki='Kasiyer'", con);
            dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    user user = new user();
                    user.ad = dr["ad"].ToString();
                    user.soyad = dr["soyad"].ToString();
                    user.kullaniciadi = dr["kullaniciadi"].ToString();
                    user.sifre = dr["sifre"].ToString();
                    user.email = dr["email"].ToString();
                    kisiListesi.Add(user);
                }
                con.Close();
                return kisiListesi;
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public LoginStatue kasiyerEkle(string ad, string soyad, string email, string kullaniciAdi, string sifre, string yetki)
        {
            con.Open();
            bool kontrol = kullaniciAdiVarMi(kullaniciAdi);
            bool kontrol2 = EmailVarMi(email);
            if(kontrol && kontrol2)
            {
                cmd = new SqlCommand("insert into kisi(ad,soyad,kullaniciadi,sifre,email,yetki) values(@v1,@v2,@v3,@v4,@v5,@v6) ", con);
                cmd.Parameters.AddWithValue("@v1", ad);
                cmd.Parameters.AddWithValue("@v2", soyad);
                cmd.Parameters.AddWithValue("@v3", kullaniciAdi);
                cmd.Parameters.AddWithValue("@v4", sifre);
                cmd.Parameters.AddWithValue("@v5", email);
                cmd.Parameters.AddWithValue("@v6", yetki);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    con.Close();
                    return LoginStatue.basarili;
                }
                else
                {
                    con.Close();
                    return LoginStatue.basarisiz;
                }
            }
            else
            {
                con.Close();
                if(kontrol)
                {
                    return LoginStatue.ayniEmail;
                }
                else if(kontrol2)
                {
                    return LoginStatue.ayniKullaniciAdi;
                }
                else
                {
                    return LoginStatue.ayniParametre;
                }
                
            }
            
        }

        private bool kullaniciAdiVarMi(string kullaniciAdi)
        {
            cmd = new SqlCommand("select 1 from kisi where kullaniciadi=@v1", con);
            cmd.Parameters.AddWithValue("@v1", kullaniciAdi);

            object result = cmd.ExecuteScalar();

            // Eğer sorgu sonucunda hiçbir şey dönmezse, result null olacaktır
            if (result != null && int.Parse(result.ToString()) == 1)
            {
                return false;  // Kullanıcı adı var
            }
            else
            {
                return true;   // Kullanıcı adı yok
            }
        }

        private bool EmailVarMi(string email)
        {
            cmd = new SqlCommand("select 1 from kisi where email=@v1", con);
            cmd.Parameters.AddWithValue("@v1", email);

            object result = cmd.ExecuteScalar();

            // Eğer sorgu sonucunda hiçbir şey dönmezse, result null olacaktır
            if (result != null && int.Parse(result.ToString()) == 1)
            {
                return false;  // Kullanıcı adı var
            }
            else
            {
                return true;   // Kullanıcı adı yok
            }
        }

       

        public void urunOdemesiYap(List<Urun> UrunListesi)
        {
            foreach (var urun in UrunListesi)
            {
                urunSil(urun.barkod);
            }
        }

        private object UrunVarMi(string barkod)
        {
            cmd = new SqlCommand("select 1 from Urun where barkod=@v1", con);
            cmd.Parameters.AddWithValue("@v1",barkod);
            object result = cmd.ExecuteScalar();
            return result;
        }

    }
}
