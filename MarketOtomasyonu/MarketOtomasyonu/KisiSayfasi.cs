using MarketOtomasyonu.controller;
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
    public partial class KisiSayfasi : Form
    {
        Controller cont;
        public KisiSayfasi()
        {
            InitializeComponent();
        }

        private void KisiSayfasi_Load(object sender, EventArgs e)
        {
            cont = new Controller();
            comboBox1.SelectedIndex = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                adminGetir();
            }

            comboBox1.SelectedIndexChanged += comboBoxChange;
        }

        private void comboBoxChange(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                adminGetir();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                kasiyerGetir();
            }
        }

        private void adminGetir()
        {
            dataGridView1.DataSource = cont.adminGetir();
            dataGridView1.Columns["girisDurumu"].Visible = false;
            dataGridView1.Columns["yetki"].Visible = false;
        }

        private void kasiyerGetir()
        {
            dataGridView1.DataSource=cont.kasiyerGetir();
            dataGridView1.Columns["girisDurumu"].Visible = false;
            dataGridView1.Columns["yetki"].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                LoginStatue result = cont.adminEkle(txt_ad.Text, txt_soyad.Text, txt_email.Text, txt_kullaniciAdi.Text, txt_sifre.Text, comboBox1.Text);
                if (result == LoginStatue.basarili)
                {
                    MessageBox.Show("Admin eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Lütfen boş yer bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.ayniParametre)
                {
                    MessageBox.Show("Kullanıcı adı ve email daha önce alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.ayniEmail)
                {
                    MessageBox.Show("Email daha önce alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.ayniKullaniciAdi)
                {
                    MessageBox.Show("Kullanıcı adı daha önce alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Admin ekleme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                adminGetir();
            }
            else
            {
                LoginStatue result = cont.kasiyerEkle(txt_ad.Text, txt_soyad.Text, txt_email.Text, txt_kullaniciAdi.Text, txt_sifre.Text, comboBox1.Text);
                if (result == LoginStatue.basarili)
                {
                    MessageBox.Show("Kasiyer  eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Lütfen boş yer bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(result == LoginStatue.ayniParametre)
                {
                    MessageBox.Show("Kullanıcı adı ve email daha önce alınmış.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(result == LoginStatue.ayniEmail)
                {
                    MessageBox.Show("Email daha önce alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.ayniKullaniciAdi)
                {
                    MessageBox.Show("Kullanıcı adı daha önce alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kasiyer ekleme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                kasiyerGetir();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
                LoginStatue result = cont.kisiGuncelle(txt_kullaniciAdi.Text, txt_ad.Text, txt_soyad.Text, txt_sifre.Text);
                if(result == LoginStatue.basarili)
                {
                    MessageBox.Show("Güncelleme başarılı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(result==LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Güncelleme için kullanıcı adı gerekli","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if(result ==LoginStatue.bosAlan)
                {
                    MessageBox.Show("Güncellemek istediğiniz bilgileri giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if(comboBox1.Text == "Admin")
                {
                    adminGetir();
                }
                else
                {
                    kasiyerGetir();    
                }
            
          

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            LoginStatue result = cont.kisiSil(txt_kullaniciAdi.Text);

            if( result == LoginStatue.basarili)
            {
                MessageBox.Show("Silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(result == LoginStatue.eksikParametre)
            {
                MessageBox.Show("Silme işlemi için kullanıcı adı gerekli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            if(comboBox1.Text== "Admin")
            {
                adminGetir();
            }
            else
            {
                kasiyerGetir();
            }
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminPaneli ad=new AdminPaneli();
            ad.Show();
            this.Hide();
        }
    }
}
