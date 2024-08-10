namespace MarketOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.lbl_sifremiunuttum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(281, 60);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(120, 20);
            this.lbl_kullaniciadi.TabIndex = 1;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(408, 60);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(142, 22);
            this.txt_kullaniciadi.TabIndex = 0;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(346, 104);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(55, 20);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(408, 104);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(142, 22);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.Location = new System.Drawing.Point(408, 162);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(111, 33);
            this.btn_girisyap.TabIndex = 2;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // lbl_sifremiunuttum
            // 
            this.lbl_sifremiunuttum.AutoSize = true;
            this.lbl_sifremiunuttum.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_sifremiunuttum.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifremiunuttum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_sifremiunuttum.Location = new System.Drawing.Point(405, 129);
            this.lbl_sifremiunuttum.Name = "lbl_sifremiunuttum";
            this.lbl_sifremiunuttum.Size = new System.Drawing.Size(101, 16);
            this.lbl_sifremiunuttum.TabIndex = 4;
            this.lbl_sifremiunuttum.Text = "Şifremi Unuttum";
            this.lbl_sifremiunuttum.Click += new System.EventHandler(this.lbl_sifremiunuttum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 220);
            this.Controls.Add(this.lbl_sifremiunuttum);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Label lbl_sifremiunuttum;
    }
}

