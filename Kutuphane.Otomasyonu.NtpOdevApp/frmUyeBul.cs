using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Otomasyonu.NtpOdevApp
{
    public partial class frmUyeBul : Form
    {
        public frmUyeBul()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Uye u = null;
            UyeBL ubl = new UyeBL();
            u=ubl.UyeBul(txtTel.Text.Trim());
            if (u!=null)
            {
                frmUyeEkle frm = (frmUyeEkle)Application.OpenForms["frmUyeEkle"];
                frm.txtUyeAd.Text = u.UyeAd;
                frm.txtUyeSoyad.Text = u.UyeSoyad;
                frm.txtUyeTel.Text = u.UyeTel;
                frm.txtUyeMail.Text = u.UyeMail;
                frm.uyeID = u.UyeID;
                frm.btnEkle.Text = "Güncelle";
                frm.btnSil.Visible = true;
                frm.btnVazgec.Visible = true;
            }
            else
            {
                MessageBox.Show("Üye Bulunamadı.");
            }
        }
    }
}
