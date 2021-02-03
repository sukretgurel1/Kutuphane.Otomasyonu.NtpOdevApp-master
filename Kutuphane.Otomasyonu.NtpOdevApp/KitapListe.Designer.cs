namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class KitapListe
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
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.gridKitap = new System.Windows.Forms.DataGridView();
            this.ClmUyeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmUyeSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(133, 258);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(168, 58);
            this.btnKitapKaydet.TabIndex = 3;
            this.btnKitapKaydet.Text = "Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            // 
            // gridKitap
            // 
            this.gridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmUyeAd,
            this.ClmUyeSoyad,
            this.ClmTel,
            this.ClmMail});
            this.gridKitap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridKitap.Location = new System.Drawing.Point(0, 0);
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.Size = new System.Drawing.Size(443, 252);
            this.gridKitap.TabIndex = 2;
            // 
            // ClmUyeAd
            // 
            this.ClmUyeAd.HeaderText = "Kitap Adı";
            this.ClmUyeAd.Name = "ClmUyeAd";
            // 
            // ClmUyeSoyad
            // 
            this.ClmUyeSoyad.HeaderText = "Basım Yılı";
            this.ClmUyeSoyad.Name = "ClmUyeSoyad";
            // 
            // ClmTel
            // 
            this.ClmTel.HeaderText = "Yazar";
            this.ClmTel.Name = "ClmTel";
            // 
            // ClmMail
            // 
            this.ClmMail.HeaderText = "Yayın Evi";
            this.ClmMail.Name = "ClmMail";
            // 
            // KitapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 349);
            this.Controls.Add(this.btnKitapKaydet);
            this.Controls.Add(this.gridKitap);
            this.Name = "KitapListe";
            this.Text = "KitapListe";
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.DataGridView gridKitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmUyeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmUyeSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMail;
    }
}