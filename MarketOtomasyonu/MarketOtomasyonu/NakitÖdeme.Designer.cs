namespace MarketOtomasyonu
{
    partial class NakitÖdeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.txt_odeme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutar Giriniz:";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(297, 76);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(118, 22);
            this.txt_tutar.TabIndex = 1;
            // 
            // txt_odeme
            // 
            this.txt_odeme.Location = new System.Drawing.Point(297, 130);
            this.txt_odeme.Name = "txt_odeme";
            this.txt_odeme.Size = new System.Drawing.Size(118, 44);
            this.txt_odeme.TabIndex = 2;
            this.txt_odeme.Text = "Ödeme";
            this.txt_odeme.UseVisualStyleBackColor = true;
            this.txt_odeme.Click += new System.EventHandler(this.txt_odeme_Click);
            // 
            // NakitÖdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 209);
            this.Controls.Add(this.txt_odeme);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.label1);
            this.Name = "NakitÖdeme";
            this.Text = "NakitÖdeme";
            this.Load += new System.EventHandler(this.NakitÖdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Button txt_odeme;
    }
}