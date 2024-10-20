using MarketOtomasyonu.controller;
using MarketOtomasyonu.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        Controller cont=new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_sifremiunuttum_Click(object sender, EventArgs e)
        {
            SifreDegistir sd=new SifreDegistir();
            sd.Show();
            this.Hide();
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            user result = cont.girisYap(txt_kullaniciadi.Text, txt_sifre.Text);
            if(result.girisDurumu==LoginStatue.basarili)
            {
                if(result.yetki=="Admin")
                {
                    AdminPaneli ad=new AdminPaneli();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    KasiyerPaneli kp=new KasiyerPaneli();
                    kp.Show();
                    this.Hide();
                }
            }
            else if(result.girisDurumu==LoginStatue.eksikParametre)
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kullanıcıadı veya şifre hatalı","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void lbl_sifre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_kullaniciadi_Click(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }
    }
}
