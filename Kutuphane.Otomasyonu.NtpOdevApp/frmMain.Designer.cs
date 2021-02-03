namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuUye = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKitap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyeKitap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmanetAlVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyeKitapListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyeGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKitapEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKitapGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazarEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazarGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUye,
            this.menuKitap,
            this.menuUyeKitap});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(922, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuUye
            // 
            this.menuUye.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUyeEkle,
            this.menuUyeGoster});
            this.menuUye.Name = "menuUye";
            this.menuUye.Size = new System.Drawing.Size(86, 20);
            this.menuUye.Text = "Üye İşlemleri";
            // 
            // menuKitap
            // 
            this.menuKitap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKitapEkle,
            this.menuKitapGoster,
            this.menuYazarEkle,
            this.menuYazarGoster});
            this.menuKitap.Name = "menuKitap";
            this.menuKitap.Size = new System.Drawing.Size(93, 20);
            this.menuKitap.Text = "Kitap İşlemleri";
            // 
            // menuUyeKitap
            // 
            this.menuUyeKitap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmanetAlVer,
            this.menuUyeKitapListele});
            this.menuUyeKitap.Name = "menuUyeKitap";
            this.menuUyeKitap.Size = new System.Drawing.Size(106, 20);
            this.menuUyeKitap.Text = "Emanet İşlemleri";
            // 
            // menuEmanetAlVer
            // 
            this.menuEmanetAlVer.Name = "menuEmanetAlVer";
            this.menuEmanetAlVer.Size = new System.Drawing.Size(192, 22);
            this.menuEmanetAlVer.Text = "Kitap Alım/Teslim";
            // 
            // menuUyeKitapListele
            // 
            this.menuUyeKitapListele.Name = "menuUyeKitapListele";
            this.menuUyeKitapListele.Size = new System.Drawing.Size(192, 22);
            this.menuUyeKitapListele.Text = "Verilen Kitapları Göster";
            // 
            // menuUyeEkle
            // 
            this.menuUyeEkle.Name = "menuUyeEkle";
            this.menuUyeEkle.Size = new System.Drawing.Size(186, 22);
            this.menuUyeEkle.Text = "Üye Ekle/Sil/Güncelle";
            this.menuUyeEkle.Click += new System.EventHandler(this.menuUyeEkle_Click);
            // 
            // menuUyeGoster
            // 
            this.menuUyeGoster.Name = "menuUyeGoster";
            this.menuUyeGoster.Size = new System.Drawing.Size(186, 22);
            this.menuUyeGoster.Text = "Üyeleri Göster";
            this.menuUyeGoster.Click += new System.EventHandler(this.menuUyeGoster_Click);
            // 
            // menuKitapEkle
            // 
            this.menuKitapEkle.Name = "menuKitapEkle";
            this.menuKitapEkle.Size = new System.Drawing.Size(193, 22);
            this.menuKitapEkle.Text = "Kitap Ekle/Sil/Güncelle";
            // 
            // menuKitapGoster
            // 
            this.menuKitapGoster.Name = "menuKitapGoster";
            this.menuKitapGoster.Size = new System.Drawing.Size(193, 22);
            this.menuKitapGoster.Text = "Kitapları Göster";
            // 
            // menuYazarEkle
            // 
            this.menuYazarEkle.Name = "menuYazarEkle";
            this.menuYazarEkle.Size = new System.Drawing.Size(193, 22);
            this.menuYazarEkle.Text = "Yazar Ekle/Sil/Güncelle";
            // 
            // menuYazarGoster
            // 
            this.menuYazarGoster.Name = "menuYazarGoster";
            this.menuYazarGoster.Size = new System.Drawing.Size(193, 22);
            this.menuYazarGoster.Text = "Yazarları Göster";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Ana Form";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuUye;
        private System.Windows.Forms.ToolStripMenuItem menuKitap;
        private System.Windows.Forms.ToolStripMenuItem menuUyeKitap;
        private System.Windows.Forms.ToolStripMenuItem menuUyeEkle;
        private System.Windows.Forms.ToolStripMenuItem menuUyeGoster;
        private System.Windows.Forms.ToolStripMenuItem menuKitapEkle;
        private System.Windows.Forms.ToolStripMenuItem menuKitapGoster;
        private System.Windows.Forms.ToolStripMenuItem menuYazarEkle;
        private System.Windows.Forms.ToolStripMenuItem menuYazarGoster;
        private System.Windows.Forms.ToolStripMenuItem menuEmanetAlVer;
        private System.Windows.Forms.ToolStripMenuItem menuUyeKitapListele;
    }
}

