using MarketOtomasyonu.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class SifreDegistir : Form
    {
        Controller cont;
        int code;
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            cont=new Controller();
            groupBox2.Hide();
            txt_yenisifre.PasswordChar = '*';
            txt_yenisifre2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginStatue ayniMi=cont.emailKullaniciAdiDogruMu(txt_hotmail.Text, txt_kullaniciadi.Text);
            if(ayniMi==LoginStatue.basarili)
            {
                dogrulamaKoduGonder();
            }
            else if(ayniMi == LoginStatue.eksikParametre)
            {
                MessageBox.Show("Kullanıcı adınızı ve emailinizi giriniz","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Mail Gönderilemedi","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dogrulamaKoduGonder()
        {
            Random rnd=new Random();
             code = rnd.Next(111111, 999999);

            MailAddress mailAlan = new MailAddress(txt_hotmail.Text);
            MailAddress mailGonderen = new MailAddress("AhmetDal540@hotmail.com", "Ahmet Dal");
            MailMessage message=new MailMessage();
            message.To.Add(mailAlan);
            message.From=mailGonderen;
            message.Subject = "Şifre Değiştirme";
            message.Body = "Şifre değiştirme kodunuz:" + code;

            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com",587);
            smtp.Credentials = new System.Net.NetworkCredential("AhmetDal540@hotmail.com", "AhmDl0147");
            smtp.EnableSsl = true;
            smtp.Send(message);
            MessageBox.Show("Doğrulama Kodu Gönderildi","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_dogrula_Click(object sender, EventArgs e)
        {
            if(code == int.Parse(txt_dogrulamakodu.Text))
            {
                groupBox2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           LoginStatue result= cont.sifreDegistir(txt_yenisifre.Text, txt_yenisifre2.Text, txt_hotmail.Text, txt_kullaniciadi.Text);

            if(result == LoginStatue.basarili)
            {
                MessageBox.Show("Şifre Değiştirme Başarılı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(result == LoginStatue.farkli)
            {
                MessageBox.Show("Şifreler Farklı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(result==LoginStatue.eksikParametre)
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Şifre Değiştirilemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_yenisifre_TextChanged(object sender, EventArgs e)
        {
            txt_yenisifre.UseSystemPasswordChar = true;
        }

        private void txt_yenisifre2_TextChanged(object sender, EventArgs e)
        {
            txt_yenisifre2.UseSystemPasswordChar= true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
