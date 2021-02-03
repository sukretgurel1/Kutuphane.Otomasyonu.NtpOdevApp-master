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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuUyeEkle_Click(object sender, EventArgs e)
        {
            frmUyeEkle frm = new frmUyeEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuUyeGoster_Click(object sender, EventArgs e)
        {
            frmUyeList frm = new frmUyeList();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
