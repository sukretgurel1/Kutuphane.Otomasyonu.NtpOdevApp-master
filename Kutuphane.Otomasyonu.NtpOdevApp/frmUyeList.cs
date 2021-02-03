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
    public partial class frmUyeList : Form
    {
        DataTable dt = null;
        public frmUyeList()
        {
            InitializeComponent();
            gridUye.AutoGenerateColumns = false;
        }

        private void frmUyeList_Load(object sender, EventArgs e)
        {
            UyeBL ubl = new UyeBL();
            dt = ubl.UyeTable();
            gridUye.DataSource = dt;
            ubl.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UyeBL ub = new UyeBL();

            foreach (DataRow item in dt.Rows)
            {

                Uye u = new Uye();
                if (item.RowState != DataRowState.Deleted)
                {
                    u.UyeAd = item[1].ToString();
                    u.UyeSoyad = item[2].ToString();
                    u.UyeTel = item[3].ToString();
                    u.UyeMail = item[4].ToString();
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ub.Kaydet(u);
                        break;
                    case DataRowState.Deleted:
                        ub.Sil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        u.UyeID = Convert.ToInt32(item[0]);
                        ub.Guncelle(u);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
