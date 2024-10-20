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
    public partial class UrunSayfasi : Form
    {
        Controller cont;

        public UrunSayfasi()
        {
            InitializeComponent();
        }

        private void UrunSayfasi_Load(object sender, EventArgs e)
        {
            cont = new Controller();
            comboBox1.SelectedIndex = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                aburCuburGetir();
            }

            comboBox1.SelectedIndexChanged += comboBoxChange;
        }


        private void aburCuburGetir()
        {
            dataGridView1.DataSource = cont.aburCuburGetir();
            dataGridView1.Columns["tur"].Visible = false;
        }

        private void sebzeGetir()
        {
            dataGridView1.DataSource = cont.sebzeGetir();
            dataGridView1.Columns["tur"].Visible = false;
        }

        private void comboBoxChange(object sender , EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                aburCuburGetir();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                sebzeGetir();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(comboBox1.Text=="Abur Cubur")
            {
                LoginStatue result = cont.aburCuburEkle(txt_barkod.Text, txt_STT.Text, txt_ad.Text, txt_adet.Text, txt_fiyat.Text);
                if (result == LoginStatue.basarili)
                {
                    MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == LoginStatue.basarisiz)
                {
                    MessageBox.Show("Veri Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(result == LoginStatue.ayniParametre)
                {
                    MessageBox.Show("Bu barkoda sahip ürün var","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eksik Yer Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.DataSource = cont.aburCuburGetir();
            }
            else if(comboBox1.Text=="Sebze")
            {
                LoginStatue result = cont.sebzeEkle(txt_barkod.Text, txt_STT.Text, txt_ad.Text, txt_adet.Text, txt_fiyat.Text);
                if (result == LoginStatue.basarili)
                {
                    MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == LoginStatue.basarisiz)
                {
                    MessageBox.Show("Veri Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.ayniParametre)
                {
                    MessageBox.Show("Bu barkoda sahip ürün var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eksik Yer Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.DataSource = cont.sebzeGetir();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Abur Cubur")
            {
                LoginStatue result = cont.aburCuburSil(txt_barkod.Text);
                if (result == LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Silme için barkod gerekli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.basarisiz)
                {
                    MessageBox.Show("Ürün zaten yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(result == LoginStatue.urunYok)
                {
                    MessageBox.Show("Girdiğiniz barkoda ait ürün yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("1 adet ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = cont.aburCuburGetir();
            }
            else if(comboBox1.Text=="Sebze")
            {
                LoginStatue result = cont.sebzeSil(txt_barkod.Text);
                if (result == LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Silme için barkod gerekli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == LoginStatue.basarisiz)
                {
                    MessageBox.Show("Ürün zaten yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("1 adet ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = cont.sebzeGetir();
            }
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Abur Cubur")
            {
                LoginStatue result = cont.aburCuburGuncelle(txt_barkod.Text, txt_ad.Text, txt_STT.Text, txt_fiyat.Text, txt_adet.Text);
                if (result == LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Barkod alanı gerekli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = cont.aburCuburGetir();
            }
            else if(comboBox1.Text== "Sebze")
            {
                LoginStatue result = cont.sebzeGuncelle(txt_barkod.Text, txt_ad.Text, txt_STT.Text, txt_fiyat.Text, txt_adet.Text);
                if (result == LoginStatue.eksikParametre)
                {
                    MessageBox.Show("Barkod alanı gerekli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = cont.sebzeGetir();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminPaneli ad=new AdminPaneli();
            ad.Show();
            this.Hide();
        }
    }
}
