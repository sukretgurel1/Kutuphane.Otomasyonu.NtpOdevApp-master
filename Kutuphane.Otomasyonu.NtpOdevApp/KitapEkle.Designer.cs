namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class KitapEkle
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
            this.btnKitapVazgec = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapBul = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.cmbYayinEvi = new System.Windows.Forms.ComboBox();
            this.txtKitapAd = new CustomControls.MyTextBox();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKitapVazgec
            // 
            this.btnKitapVazgec.Location = new System.Drawing.Point(155, 186);
            this.btnKitapVazgec.Name = "btnKitapVazgec";
            this.btnKitapVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnKitapVazgec.TabIndex = 20;
            this.btnKitapVazgec.Text = "Vazgec";
            this.btnKitapVazgec.UseVisualStyleBackColor = true;
            this.btnKitapVazgec.Visible = false;
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(71, 186);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(75, 23);
            this.btnKitapSil.TabIndex = 19;
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Visible = false;
            // 
            // btnKitapBul
            // 
            this.btnKitapBul.Location = new System.Drawing.Point(155, 147);
            this.btnKitapBul.Name = "btnKitapBul";
            this.btnKitapBul.Size = new System.Drawing.Size(75, 23);
            this.btnKitapBul.TabIndex = 18;
            this.btnKitapBul.Text = "Bul";
            this.btnKitapBul.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(71, 147);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 17;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Basım Yılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap Adı";
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.cmbYazar);
            this.pnlText.Controls.Add(this.cmbYayinEvi);
            this.pnlText.Controls.Add(this.txtKitapAd);
            this.pnlText.Location = new System.Drawing.Point(71, 12);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(159, 89);
            this.pnlText.TabIndex = 13;
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(3, 59);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(151, 21);
            this.cmbYazar.TabIndex = 3;
            // 
            // cmbYayinEvi
            // 
            this.cmbYayinEvi.FormattingEnabled = true;
            this.cmbYayinEvi.Location = new System.Drawing.Point(4, 31);
            this.cmbYayinEvi.Name = "cmbYayinEvi";
            this.cmbYayinEvi.Size = new System.Drawing.Size(150, 21);
            this.cmbYayinEvi.TabIndex = 2;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtKitapAd.Location = new System.Drawing.Point(3, 4);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(151, 20);
            this.txtKitapAd.TabIndex = 0;
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 258);
            this.Controls.Add(this.btnKitapVazgec);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapBul);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlText);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnKitapVazgec;
        public System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapBul;
        public System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.ComboBox cmbYayinEvi;
        public CustomControls.MyTextBox txtKitapAd;
    }
}