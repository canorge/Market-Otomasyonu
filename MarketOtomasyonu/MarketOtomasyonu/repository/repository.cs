using MarketOtomasyonu.Model;
using MarketOtomasyonu.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            cmd = new SqlCommand("select aburcubur.fiyat,urun.ad from urun inner join aburcubur on urun.id=aburcubur.id where urun.barkod=@v1 ", con);
            cmd.Parameters.AddWithValue("@v1", barkod);
            dr=cmd.ExecuteReader();

            if(dr.Read()) 
            {
                Urun urun = new Urun();
                urun.fiyat = float.Parse(dr["fiyat"].ToString());
                urun.ad = dr["ad"].ToString();
                con.Close();
                return urun;
            }
            else
            {
                con.Close ();
                return null; 
            }

        }
    }
}
