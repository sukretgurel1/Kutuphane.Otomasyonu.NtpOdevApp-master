using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UyeBL : IDisposable
    {
        Yardimci yrd = new Yardimci();
        public void Dispose()
        {
            ((IDisposable)yrd).Dispose();
        }
        public bool Ekle(Uye u)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", u.UyeAd), new SqlParameter("@Soyad", u.UyeSoyad), new SqlParameter("@Tel", u.UyeTel), new SqlParameter("@Mail", u.UyeMail) };
                return yrd.ExecuteNonQuery("Insert into tblUye values(@Ad,@Soyad,@Tel,@Mail)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Guncelle(Uye u)
        {

            try
            {
                SqlParameter[] p = { new SqlParameter("@ID", u.UyeID), new SqlParameter("@Ad", u.UyeAd), new SqlParameter("@Soyad", u.UyeSoyad), new SqlParameter("@Tel", u.UyeTel), new SqlParameter("@Mail", u.UyeMail) };
                return yrd.ExecuteNonQuery("Update tblUye set UyeAd=@Ad,UyeSoyad=@Soyad,UyeTel=@Tel,UyeMail=@Mail Where UyeID=@ID", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Kaydet(Uye u)
        {
            throw new NotImplementedException();
        }

        public Uye UyeBul(string telefon)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tel", telefon) };
                SqlDataReader dr = yrd.ExecuteReader("Select UyeID,UyeAd,UyeSoyad,UyeTel,UyeMail from tblUye Where UyeTel=@Tel", p);
                Uye u = null;

                if (dr.Read())
                {
                    u = new Uye();
                    u.UyeAd = dr["UyeAd"].ToString();
                    u.UyeSoyad = dr["UyeSoyad"].ToString();
                    u.UyeTel = dr["UyeTel"].ToString();
                    u.UyeMail = dr["UyeMail"].ToString();
                    u.UyeID = Convert.ToInt32(dr["UyeID"]);
                }
                dr.Close();
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Sil(int uyeID)
        {
            SqlParameter[] p = { new SqlParameter("@ID", uyeID) };
            return yrd.ExecuteNonQuery("Delete from tblUye where UyeID=@ID", p) > 0;
        }
        public DataTable UyeTable() => yrd.GetDataTable("Select UyeID,UyeAd,UyeSoyad,UyeTel,UyeMail from tblUye");
    }
}
