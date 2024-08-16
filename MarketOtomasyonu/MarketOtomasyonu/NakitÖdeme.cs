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
    public partial class NakitÖdeme : Form
    {
        public NakitÖdeme(float toplam, KasiyerPaneli ks)
        {
            InitializeComponent();
            this.toplam = toplam;
            this.ks = ks;
        }
        float toplam;
        KasiyerPaneli ks;
        private void NakitÖdeme_Load(object sender, EventArgs e)
        {

        }

        private void tutarYeterliMi(float tutar)
        {
            if(tutar < toplam)
            {
                MessageBox.Show("Verilen para yeterli değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tutar == toplam)
            {
                MessageBox.Show("Ödeme tamamlandı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);        
                ks.PanelClear();
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Ödeme tamamlandı\n Para üstü:" + (tutar - toplam) + " TL", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ks.PanelClear();
                this.Close();
            }
        }

        private void txt_odeme_Click(object sender, EventArgs e)
        {
            tutarYeterliMi(float.Parse(txt_tutar.Text));
        }
    }
}
