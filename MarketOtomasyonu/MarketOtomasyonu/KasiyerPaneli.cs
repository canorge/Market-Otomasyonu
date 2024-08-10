using AForge.Video.DirectShow;
using MarketOtomasyonu.controller;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    txt_barkod.Text = result.ToString();
                    if (!string.IsNullOrEmpty(txt_barkod.Text))
                    {
                        Urun urun = cont.urunGetir(txt_barkod.Text);
                        

                        if (dataTable.Columns.Count == 0)
                        {
                            dataTable.Columns.Add("Ad", typeof(string));
                            dataTable.Columns.Add("Fiyat", typeof(decimal));
                        }
                            DataRow newRow = dataTable.NewRow();
                            newRow["Ad"] = urun.ad;
                            newRow["Fiyat"] = urun.fiyat;
                            dataTable.Rows.Add(newRow);
                
                        dataGridView1.DataSource=dataTable;
                    }
                }
                
            }
        }

        private void lbl_saniye_Click(object sender, EventArgs e)
        {

        }
    }
}
