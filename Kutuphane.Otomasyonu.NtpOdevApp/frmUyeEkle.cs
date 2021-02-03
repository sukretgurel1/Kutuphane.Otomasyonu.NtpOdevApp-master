using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    public partial class frmUyeEkle : Form
    {
        public frmUyeEkle()
        {
            InitializeComponent();
            Temizle();
        }
        public int uyeID = 0;
        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            btnEkle.Text = "Ekle";
            btnSil.Visible = false;
            btnVazgec.Visible = false;
            uyeID = 0;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                UyeBL ubl = new UyeBL();
                Uye u = new Uye();
                u.UyeID = uyeID;
                u.UyeAd = txtUyeAd.Text.Trim();
                u.UyeSoyad = txtUyeSoyad.Text.Trim();
                u.UyeTel = txtUyeTel.Text.Trim();
                u.UyeMail = txtUyeMail.Text.Trim();
                switch (uyeID)
                {
                    case 0:
                        if (ubl.Ekle(u))
                        {
                            Temizle();
                            ubl.Dispose();
                            MessageBox.Show("Ekleme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Yeniden Deneyiniz!!");
                            ubl.Dispose();
                        }

                        break;
                    default:
                        if (ubl.Guncelle(u))
                        {
                            Temizle();
                            MessageBox.Show("Güncelleme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme Başarısız!");
                        }
                        break;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Veritabanı Hatası! Hata Kodu: "+ex.Number);
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmUyeBul frm = new frmUyeBul();
            frm.MdiParent = Application.OpenForms["frmMain"];
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp=MessageBox.Show("Üye Silinecek. Devam Etmek İstiyormusunuz?","Üye Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cvp==DialogResult.Yes)
            {
                UyeBL ubl = new UyeBL();
                if (ubl.Sil(uyeID))
                {
                    MessageBox.Show("Üye Silindi.");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Üye Silinemedi!");
                }
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
