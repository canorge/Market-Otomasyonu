namespace MarketOtomasyonu
{
    partial class KasiyerPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_gun = new System.Windows.Forms.Label();
            this.lbl_ay = new System.Windows.Forms.Label();
            this.lbl_yil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-7, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(267, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(365, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(459, 317);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(238, 22);
            this.txt_barkod.TabIndex = 4;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(713, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(10, 16);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = ".";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(739, 9);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(10, 16);
            this.lbl_dakika.TabIndex = 5;
            this.lbl_dakika.Text = ".";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(764, 9);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(10, 16);
            this.lbl_saniye.TabIndex = 5;
            this.lbl_saniye.Text = ".";
            this.lbl_saniye.Click += new System.EventHandler(this.lbl_saniye_Click);
            // 
            // lbl_gun
            // 
            this.lbl_gun.AutoSize = true;
            this.lbl_gun.Location = new System.Drawing.Point(606, 9);
            this.lbl_gun.Name = "lbl_gun";
            this.lbl_gun.Size = new System.Drawing.Size(10, 16);
            this.lbl_gun.TabIndex = 5;
            this.lbl_gun.Text = ".";
            // 
            // lbl_ay
            // 
            this.lbl_ay.AutoSize = true;
            this.lbl_ay.Location = new System.Drawing.Point(632, 9);
            this.lbl_ay.Name = "lbl_ay";
            this.lbl_ay.Size = new System.Drawing.Size(10, 16);
            this.lbl_ay.TabIndex = 5;
            this.lbl_ay.Text = ".";
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.Location = new System.Drawing.Point(657, 9);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(10, 16);
            this.lbl_yil.TabIndex = 5;
            this.lbl_yil.Text = ".";
            this.lbl_yil.Click += new System.EventHandler(this.lbl_saniye_Click);
            // 
            // KasiyerPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 567);
            this.Controls.Add(this.lbl_yil);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_ay);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_gun);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KasiyerPaneli";
            this.Text = "KasiyerPaneli";
            this.Load += new System.EventHandler(this.KasiyerPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_gun;
        private System.Windows.Forms.Label lbl_ay;
        private System.Windows.Forms.Label lbl_yil;
    }
}