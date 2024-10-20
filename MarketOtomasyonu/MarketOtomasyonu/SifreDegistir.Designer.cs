namespace MarketOtomasyonu
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_hotmail = new System.Windows.Forms.Label();
            this.txt_hotmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dogrulamakodu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dogrula = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yenisifre2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(19, 41);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(212, 20);
            this.lbl_kullaniciadi.TabIndex = 0;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adınızı Giriniz:";
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(258, 39);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(180, 22);
            this.txt_kullaniciadi.TabIndex = 0;
            // 
            // lbl_hotmail
            // 
            this.lbl_hotmail.AutoSize = true;
            this.lbl_hotmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hotmail.Location = new System.Drawing.Point(-1, 89);
            this.lbl_hotmail.Name = "lbl_hotmail";
            this.lbl_hotmail.Size = new System.Drawing.Size(232, 20);
            this.lbl_hotmail.TabIndex = 0;
            this.lbl_hotmail.Text = "Hotmail Adresinizi Giriniz:";
            // 
            // txt_hotmail
            // 
            this.txt_hotmail.Location = new System.Drawing.Point(258, 87);
            this.txt_hotmail.Name = "txt_hotmail";
            this.txt_hotmail.Size = new System.Drawing.Size(180, 22);
            this.txt_hotmail.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kod Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğrulama Kodunu Giriniz:";
            // 
            // txt_dogrulamakodu
            // 
            this.txt_dogrulamakodu.Location = new System.Drawing.Point(248, 208);
            this.txt_dogrulamakodu.Name = "txt_dogrulamakodu";
            this.txt_dogrulamakodu.Size = new System.Drawing.Size(180, 22);
            this.txt_dogrulamakodu.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_kullaniciadi);
            this.groupBox1.Controls.Add(this.btn_dogrula);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_hotmail);
            this.groupBox1.Controls.Add(this.txt_dogrulamakodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_hotmail);
            this.groupBox1.Controls.Add(this.txt_kullaniciadi);
            this.groupBox1.Location = new System.Drawing.Point(47, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_dogrula
            // 
            this.btn_dogrula.Location = new System.Drawing.Point(248, 237);
            this.btn_dogrula.Name = "btn_dogrula";
            this.btn_dogrula.Size = new System.Drawing.Size(180, 35);
            this.btn_dogrula.TabIndex = 4;
            this.btn_dogrula.Text = "Doğrula";
            this.btn_dogrula.UseVisualStyleBackColor = true;
            this.btn_dogrula.Click += new System.EventHandler(this.btn_dogrula_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_yenisifre2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_yenisifre);
            this.groupBox2.Location = new System.Drawing.Point(568, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 263);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Şifre Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // txt_yenisifre2
            // 
            this.txt_yenisifre2.Location = new System.Drawing.Point(211, 90);
            this.txt_yenisifre2.Name = "txt_yenisifre2";
            this.txt_yenisifre2.Size = new System.Drawing.Size(180, 22);
            this.txt_yenisifre2.TabIndex = 1;
            this.txt_yenisifre2.TextChanged += new System.EventHandler(this.txt_yenisifre2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(83, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Şifre:";
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(211, 39);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(180, 22);
            this.txt_yenisifre.TabIndex = 0;
            this.txt_yenisifre.TextChanged += new System.EventHandler(this.txt_yenisifre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SifreDegistir";
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label lbl_hotmail;
        private System.Windows.Forms.TextBox txt_hotmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dogrulamakodu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yenisifre2;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_dogrula;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}