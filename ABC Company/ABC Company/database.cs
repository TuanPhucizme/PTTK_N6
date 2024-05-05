using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class database
    {
        // modified 'Data Source' to match your local database instance
        private string connstr = @"Data Source=localhost\HOANG_VV;Initial Catalog=ABC;User ID=sa; Password=123456";
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;

        public database()
        {
            try
            {
                conn = new SqlConnection (connstr);
                conn.Open ();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to connect" + ex.Message);
            }
        }

        public DataTable selectDangTuyen()
        {
            try
            {
                sql = "select dst.MaDangTuyen, dst.ViTri, dst.ThoiGianDangTuyen, ct.TenCongTy AS CongTyDangTuyen from DanhSachDangTuyen dst inner join CongTy ct ON dst.CongTyDangTuyen = ct.MaCongTy";
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to load data " + ex.Message);
                return null;
            }
            //finally
            //{
            //    conn.Close();
            //}
        }

        public DataTable chiTietDangTuyen()
        {
            try
            {
                sql = "select MaDangTuyen from DanhSachDangTuyen";
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to load data " + ex.Message);
                return null;
            }
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}
