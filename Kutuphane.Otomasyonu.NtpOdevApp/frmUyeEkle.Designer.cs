namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class frmUyeEkle
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
            this.txtUyeAd = new CustomControls.MyTextBox();
            this.txtUyeSoyad = new CustomControls.MyTextBox();
            this.txtUyeTel = new CustomControls.MyTextBox();
            this.txtUyeMail = new CustomControls.MyTextBox();
            this.pnlText = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtUyeAd.Location = new System.Drawing.Point(3, 4);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(151, 20);
            this.txtUyeAd.TabIndex = 0;
            // 
            // txtUyeSoyad
            // 
            this.txtUyeSoyad.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtUyeSoyad.Location = new System.Drawing.Point(3, 30);
            this.txtUyeSoyad.Name = "txtUyeSoyad";
            this.txtUyeSoyad.Size = new System.Drawing.Size(151, 20);
            this.txtUyeSoyad.TabIndex = 1;
            // 
            // txtUyeTel
            // 
            this.txtUyeTel.CalismaModu = CustomControls.WorkMode.Sayi;
            this.txtUyeTel.Location = new System.Drawing.Point(3, 56);
            this.txtUyeTel.Name = "txtUyeTel";
            this.txtUyeTel.Size = new System.Drawing.Size(151, 20);
            this.txtUyeTel.TabIndex = 2;
            // 
            // txtUyeMail
            // 
            this.txtUyeMail.CalismaModu = CustomControls.WorkMode.Normal;
            this.txtUyeMail.Location = new System.Drawing.Point(3, 82);
            this.txtUyeMail.Name = "txtUyeMail";
            this.txtUyeMail.Size = new System.Drawing.Size(151, 20);
            this.txtUyeMail.TabIndex = 3;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.txtUyeTel);
            this.pnlText.Controls.Add(this.txtUyeMail);
            this.pnlText.Controls.Add(this.txtUyeAd);
            this.pnlText.Controls.Add(this.txtUyeSoyad);
            this.pnlText.Location = new System.Drawing.Point(65, 26);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(159, 113);
            this.pnlText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Mail";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(65, 161);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(149, 161);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 9;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(65, 200);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(149, 200);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 11;
            this.btnVazgec.Text = "Vazgec";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // frmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 258);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlText);
            this.Name = "frmUyeEkle";
            this.Text = "Üye İşlemleri";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnVazgec;
        public CustomControls.MyTextBox txtUyeAd;
        public CustomControls.MyTextBox txtUyeSoyad;
        public CustomControls.MyTextBox txtUyeTel;
        public CustomControls.MyTextBox txtUyeMail;
    }
}