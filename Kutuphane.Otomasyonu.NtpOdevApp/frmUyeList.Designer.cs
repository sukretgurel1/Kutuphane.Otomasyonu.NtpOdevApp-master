namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class frmUyeList
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
            this.gridUye = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ClmUyeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmUyeSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUye
            // 
            this.gridUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmUyeAd,
            this.ClmUyeSoyad,
            this.ClmTel,
            this.ClmMail});
            this.gridUye.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridUye.Location = new System.Drawing.Point(0, 0);
            this.gridUye.Name = "gridUye";
            this.gridUye.Size = new System.Drawing.Size(443, 252);
            this.gridUye.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(143, 258);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 58);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ClmUyeAd
            // 
            this.ClmUyeAd.HeaderText = "Uye Adı";
            this.ClmUyeAd.Name = "ClmUyeAd";
            // 
            // ClmUyeSoyad
            // 
            this.ClmUyeSoyad.HeaderText = "Uye Soyad";
            this.ClmUyeSoyad.Name = "ClmUyeSoyad";
            // 
            // ClmTel
            // 
            this.ClmTel.HeaderText = "Telefon";
            this.ClmTel.Name = "ClmTel";
            // 
            // ClmMail
            // 
            this.ClmMail.HeaderText = "Üye Mail";
            this.ClmMail.Name = "ClmMail";
            // 
            // frmUyeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 321);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gridUye);
            this.Name = "frmUyeList";
            this.Text = "frmUyeList";
            this.Load += new System.EventHandler(this.frmUyeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUye;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmUyeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmUyeSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMail;
    }
}