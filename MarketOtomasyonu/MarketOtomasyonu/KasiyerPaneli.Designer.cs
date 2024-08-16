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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bir = new System.Windows.Forms.Button();
            this.btn_dort = new System.Windows.Forms.Button();
            this.btn_yedi = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_cikarma = new System.Windows.Forms.Button();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.btn_dokuz = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_sifir = new System.Windows.Forms.Button();
            this.btn_virgul = new System.Windows.Forms.Button();
            this.btn_uc = new System.Windows.Forms.Button();
            this.btn_alti = new System.Windows.Forms.Button();
            this.btn_iki = new System.Windows.Forms.Button();
            this.btn_bes = new System.Windows.Forms.Button();
            this.btn_sekiz = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_nakit = new System.Windows.Forms.Button();
            this.btn_urunSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 619);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(332, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 155);
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
            this.txt_barkod.Location = new System.Drawing.Point(391, 261);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(238, 22);
            this.txt_barkod.TabIndex = 4;
            this.txt_barkod.TextChanged += new System.EventHandler(this.txt_barkod_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOPLAM:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(194, 39);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(26, 39);
            this.lbl_toplam.TabIndex = 7;
            this.lbl_toplam.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_bir);
            this.groupBox1.Controls.Add(this.btn_dort);
            this.groupBox1.Controls.Add(this.btn_yedi);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.btn_cikarma);
            this.groupBox1.Controls.Add(this.btn_toplama);
            this.groupBox1.Controls.Add(this.btn_dokuz);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_sifir);
            this.groupBox1.Controls.Add(this.btn_virgul);
            this.groupBox1.Controls.Add(this.btn_uc);
            this.groupBox1.Controls.Add(this.btn_alti);
            this.groupBox1.Controls.Add(this.btn_iki);
            this.groupBox1.Controls.Add(this.btn_bes);
            this.groupBox1.Controls.Add(this.btn_sekiz);
            this.groupBox1.Controls.Add(this.btn_carpma);
            this.groupBox1.Controls.Add(this.btn_bolme);
            this.groupBox1.Location = new System.Drawing.Point(326, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 375);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btn_bir
            // 
            this.btn_bir.Location = new System.Drawing.Point(6, 232);
            this.btn_bir.Name = "btn_bir";
            this.btn_bir.Size = new System.Drawing.Size(89, 64);
            this.btn_bir.TabIndex = 0;
            this.btn_bir.Text = "1";
            this.btn_bir.UseVisualStyleBackColor = true;
            this.btn_bir.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_dort
            // 
            this.btn_dort.Location = new System.Drawing.Point(6, 162);
            this.btn_dort.Name = "btn_dort";
            this.btn_dort.Size = new System.Drawing.Size(89, 64);
            this.btn_dort.TabIndex = 0;
            this.btn_dort.Text = "4";
            this.btn_dort.UseVisualStyleBackColor = true;
            this.btn_dort.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_yedi
            // 
            this.btn_yedi.Location = new System.Drawing.Point(6, 92);
            this.btn_yedi.Name = "btn_yedi";
            this.btn_yedi.Size = new System.Drawing.Size(89, 64);
            this.btn_yedi.TabIndex = 0;
            this.btn_yedi.Text = "7";
            this.btn_yedi.UseVisualStyleBackColor = true;
            this.btn_yedi.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(292, 92);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(89, 64);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.Text = "C";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.ClearClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(292, 162);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 204);
            this.button14.TabIndex = 0;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.enterClick);
            // 
            // btn_cikarma
            // 
            this.btn_cikarma.Location = new System.Drawing.Point(292, 22);
            this.btn_cikarma.Name = "btn_cikarma";
            this.btn_cikarma.Size = new System.Drawing.Size(89, 64);
            this.btn_cikarma.TabIndex = 0;
            this.btn_cikarma.Text = "-";
            this.btn_cikarma.UseVisualStyleBackColor = true;
            this.btn_cikarma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_toplama
            // 
            this.btn_toplama.Location = new System.Drawing.Point(197, 21);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(89, 64);
            this.btn_toplama.TabIndex = 0;
            this.btn_toplama.Text = "+";
            this.btn_toplama.UseVisualStyleBackColor = true;
            this.btn_toplama.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_dokuz
            // 
            this.btn_dokuz.Location = new System.Drawing.Point(196, 92);
            this.btn_dokuz.Name = "btn_dokuz";
            this.btn_dokuz.Size = new System.Drawing.Size(89, 64);
            this.btn_dokuz.TabIndex = 0;
            this.btn_dokuz.Text = "9";
            this.btn_dokuz.UseVisualStyleBackColor = true;
            this.btn_dokuz.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(6, 302);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 64);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "<=";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sifir
            // 
            this.btn_sifir.Location = new System.Drawing.Point(102, 302);
            this.btn_sifir.Name = "btn_sifir";
            this.btn_sifir.Size = new System.Drawing.Size(89, 64);
            this.btn_sifir.TabIndex = 0;
            this.btn_sifir.Text = "0";
            this.btn_sifir.UseVisualStyleBackColor = true;
            this.btn_sifir.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_virgul
            // 
            this.btn_virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_virgul.Location = new System.Drawing.Point(196, 302);
            this.btn_virgul.Name = "btn_virgul";
            this.btn_virgul.Size = new System.Drawing.Size(89, 64);
            this.btn_virgul.TabIndex = 0;
            this.btn_virgul.Text = ",";
            this.btn_virgul.UseVisualStyleBackColor = true;
            this.btn_virgul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_uc
            // 
            this.btn_uc.Location = new System.Drawing.Point(196, 232);
            this.btn_uc.Name = "btn_uc";
            this.btn_uc.Size = new System.Drawing.Size(89, 64);
            this.btn_uc.TabIndex = 0;
            this.btn_uc.Text = "3";
            this.btn_uc.UseVisualStyleBackColor = true;
            this.btn_uc.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_alti
            // 
            this.btn_alti.Location = new System.Drawing.Point(197, 162);
            this.btn_alti.Name = "btn_alti";
            this.btn_alti.Size = new System.Drawing.Size(89, 64);
            this.btn_alti.TabIndex = 0;
            this.btn_alti.Text = "6";
            this.btn_alti.UseVisualStyleBackColor = true;
            this.btn_alti.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_iki
            // 
            this.btn_iki.Location = new System.Drawing.Point(101, 232);
            this.btn_iki.Name = "btn_iki";
            this.btn_iki.Size = new System.Drawing.Size(89, 64);
            this.btn_iki.TabIndex = 0;
            this.btn_iki.Text = "2";
            this.btn_iki.UseVisualStyleBackColor = true;
            this.btn_iki.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_bes
            // 
            this.btn_bes.Location = new System.Drawing.Point(102, 162);
            this.btn_bes.Name = "btn_bes";
            this.btn_bes.Size = new System.Drawing.Size(89, 64);
            this.btn_bes.TabIndex = 0;
            this.btn_bes.Text = "5";
            this.btn_bes.UseVisualStyleBackColor = true;
            this.btn_bes.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_sekiz
            // 
            this.btn_sekiz.Location = new System.Drawing.Point(102, 92);
            this.btn_sekiz.Name = "btn_sekiz";
            this.btn_sekiz.Size = new System.Drawing.Size(89, 64);
            this.btn_sekiz.TabIndex = 0;
            this.btn_sekiz.Text = "8";
            this.btn_sekiz.UseVisualStyleBackColor = true;
            this.btn_sekiz.Click += new System.EventHandler(this.numberClick);
            // 
            // btn_carpma
            // 
            this.btn_carpma.Location = new System.Drawing.Point(102, 22);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(89, 64);
            this.btn_carpma.TabIndex = 0;
            this.btn_carpma.Text = "X";
            this.btn_carpma.UseVisualStyleBackColor = true;
            this.btn_carpma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.Location = new System.Drawing.Point(7, 22);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(89, 64);
            this.btn_bolme.TabIndex = 0;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = true;
            this.btn_bolme.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(729, 614);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(147, 63);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_nakit
            // 
            this.btn_nakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nakit.Location = new System.Drawing.Point(729, 402);
            this.btn_nakit.Name = "btn_nakit";
            this.btn_nakit.Size = new System.Drawing.Size(147, 63);
            this.btn_nakit.TabIndex = 9;
            this.btn_nakit.Text = "ÖDEME AL";
            this.btn_nakit.UseVisualStyleBackColor = true;
            this.btn_nakit.Click += new System.EventHandler(this.btn_nakit_Click);
            // 
            // btn_urunSil
            // 
            this.btn_urunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunSil.Location = new System.Drawing.Point(729, 510);
            this.btn_urunSil.Name = "btn_urunSil";
            this.btn_urunSil.Size = new System.Drawing.Size(147, 63);
            this.btn_urunSil.TabIndex = 9;
            this.btn_urunSil.Text = "SİL";
            this.btn_urunSil.UseVisualStyleBackColor = true;
            this.btn_urunSil.Click += new System.EventHandler(this.UrunSil);
            // 
            // KasiyerPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.btn_nakit);
            this.Controls.Add(this.btn_urunSil);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.label1);
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.KasiyerPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_bir;
        private System.Windows.Forms.Button btn_dort;
        private System.Windows.Forms.Button btn_yedi;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.Button btn_dokuz;
        private System.Windows.Forms.Button btn_alti;
        private System.Windows.Forms.Button btn_iki;
        private System.Windows.Forms.Button btn_bes;
        private System.Windows.Forms.Button btn_sekiz;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_cikarma;
        private System.Windows.Forms.Button btn_uc;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_sifir;
        private System.Windows.Forms.Button btn_virgul;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_nakit;
        private System.Windows.Forms.Button btn_urunSil;
    }
}