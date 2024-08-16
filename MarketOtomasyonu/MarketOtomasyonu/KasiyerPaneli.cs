using AForge.Video.DirectShow;
using MarketOtomasyonu.controller;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    
    public partial class KasiyerPaneli : Form
    {
        Controller cont=new Controller();
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        DataTable dataTable = new DataTable();
        private string lastBarcode = "";
        private DateTime lastScanTime;
        float toplam=0;
        public KasiyerPaneli()
        {
            InitializeComponent();
        }

        private void KasiyerPaneli_Load(object sender, EventArgs e)
        {
             fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            vcd = new VideoCaptureDevice(fic[0].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void btn_kameraac_Click(object sender, EventArgs e)
        {
             
           
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {   
            pictureBox1.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_gun.Text = DateTime.Now.Day.ToString() + ".";
            lbl_ay.Text = DateTime.Now.Month.ToString() + ".";
            lbl_yil.Text = DateTime.Now.Year.ToString();

            lbl_saat.Text = DateTime.Now.Hour.ToString()+":";
            lbl_dakika.Text = DateTime.Now.Minute.ToString()+":";
            lbl_saniye.Text = DateTime.Now.Second.ToString();   

            if(pictureBox1.Image != null)
            {
                BarcodeReader br=new BarcodeReader();
                Result result = br.Decode((Bitmap)pictureBox1.Image);
                if(result != null) 
                {
                    string currentBarcode = result.ToString();
                    if (currentBarcode != lastBarcode || (DateTime.Now - lastScanTime).TotalSeconds > 2)
                    {
                        txt_barkod.Text = currentBarcode;
                        lastBarcode = currentBarcode;
                        lastScanTime = DateTime.Now;

                        if (!string.IsNullOrEmpty(txt_barkod.Text))
                        {
                            Urun urun = cont.urunGetir(txt_barkod.Text);
                            if(urun != null)
                            {
                                if (dataTable.Columns.Count == 0)
                                {
                                    dataTable.Columns.Add("Ad", typeof(string));
                                    dataTable.Columns.Add("Fiyat", typeof(decimal));
                                }
                                DataRow newRow = dataTable.NewRow();
                                newRow["Ad"] = urun.ad;
                                newRow["Fiyat"] = urun.fiyat;
                                dataTable.Rows.Add(newRow);
                                dataGridView1.DataSource = dataTable;
                                toplam += urun.fiyat;
                                lbl_toplam.Text = toplam.ToString();
                                SoundPlayer sound=new SoundPlayer();
                                sound.SoundLocation = "barkod.wav";
                                sound.Play(); 
                            }

                          
                        }
                    }
                  
                   
                }
                
            }
        }


        private void numberClick(object sender,EventArgs e)
        {
            Button btn= (Button)sender;
            txt_barkod.Text = txt_barkod.Text + btn.Text;
        }

        private void enterClick(object sender,EventArgs e)
        {
            if (txt_barkod.Text != null)
            {
                Urun urun = cont.urunGetir(txt_barkod.Text);
                if (urun != null)
                {
                    if (dataTable.Columns.Count == 0)
                    {
                        dataTable.Columns.Add("Ad", typeof(string));
                        dataTable.Columns.Add("Fiyat", typeof(decimal));
                    }
                    DataRow newRow = dataTable.NewRow();
                    newRow["Ad"] = urun.ad;
                    newRow["Fiyat"] = urun.fiyat;
                    dataTable.Rows.Add(newRow);
                    dataGridView1.DataSource = dataTable;
                    toplam += urun.fiyat;
                    lbl_toplam.Text = toplam.ToString();
                    SoundPlayer sound = new SoundPlayer();
                    sound.SoundLocation = "barkod.wav";
                    sound.Play();
                }
            }
        }

        private void ClearClick(object sender,EventArgs e)
        {
            txt_barkod.Text = " ";
        }

        public void PanelClear()
        {
            lbl_toplam.Text = "";
            txt_barkod.Text = "";
            dataGridView1.DataSource = null;
        }
        private void lbl_saniye_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nakit_Click(object sender, EventArgs e)
        {
            NakitÖdeme no = new NakitÖdeme(toplam,this);
            no.ShowDialog();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_kredi_Click(object sender, EventArgs e)
        {

        }

        private void btn_puan_Click(object sender, EventArgs e)
        {
            PuanKullan pk = new PuanKullan(toplam,this);
            pk.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UrunSil(object sender,EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                toplam -= float.Parse(row.Cells[1].Value.ToString());
                lbl_toplam.Text = toplam.ToString();
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
