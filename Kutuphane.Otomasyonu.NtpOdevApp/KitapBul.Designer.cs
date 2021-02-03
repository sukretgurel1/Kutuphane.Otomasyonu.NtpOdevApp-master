namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class KitapBul
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
            this.btnKitapBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAd = new CustomControls.MyTextBox();
            this.SuspendLayout();
            // 
            // btnKitapBul
            // 
            this.btnKitapBul.Location = new System.Drawing.Point(136, 48);
            this.btnKitapBul.Name = "btnKitapBul";
            this.btnKitapBul.Size = new System.Drawing.Size(75, 23);
            this.btnKitapBul.TabIndex = 5;
            this.btnKitapBul.Text = "Bul";
            this.btnKitapBul.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.CalismaModu = CustomControls.WorkMode.Sayi;
            this.txtKitapAd.Location = new System.Drawing.Point(126, 22);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(117, 20);
            this.txtKitapAd.TabIndex = 3;
            // 
            // KitapBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 122);
            this.Controls.Add(this.btnKitapBul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapAd);
            this.Name = "KitapBul";
            this.Text = "KitapBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKitapBul;
        private System.Windows.Forms.Label label1;
        private CustomControls.MyTextBox txtKitapAd;
    }
}