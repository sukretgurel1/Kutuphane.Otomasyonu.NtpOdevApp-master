namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    partial class frmUyeBul
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
            this.txtTel = new CustomControls.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTel
            // 
            this.txtTel.CalismaModu = CustomControls.WorkMode.Sayi;
            this.txtTel.Location = new System.Drawing.Point(137, 37);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(117, 20);
            this.txtTel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefon Numarası";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(147, 63);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // frmUyeBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 107);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Name = "frmUyeBul";
            this.Text = "frmUyeBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.MyTextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBul;
    }
}