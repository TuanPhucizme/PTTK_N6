using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_ADIS
{
    public class Database
    {
        private readonly string connectString = @"Data Source=LAPTOP-CTO70D8S\SQLEXPRESS;Initial Catalog=PROJECTADIS;Integrated Security=True;Encrypt=False";
        private readonly SqlConnection conn;
        SqlCommand cmd;
        DataTable dt = new();

        public Database() 
        {
            try
            {
                conn = new SqlConnection(connectString);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to connect" + ex.Message);
            }
        }
        public DataTable PrintAllDanhSachHoaDon()
        {
            try
            {
                cmd = new SqlCommand("select * from HOADON", conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to load data " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow ShowChiTietHoaDon(string MaHD)
        {
            try
            {
                using SqlCommand cmd = new("SELECT * FROM HOADON WHERE MaHoaDon = @MAHD;", conn);
                cmd.Parameters.AddWithValue("@MaHD", MaHD);
                DataTable dt = new();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to load data " + ex.Message);
                return null;
            }
        }

        public void CapNhatHoaDon(string MaHD, string MaDT, int TongTienMoi, string HinhThucMoi, string CachThucMoi, DateTime NgayThanhToanMoi)
        {
            try
            {
                using SqlCommand cmd = new("UpdateHoaDon", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHoaDon", MaHD);
                cmd.Parameters.AddWithValue("@MaDangTuyen", MaDT);
                cmd.Parameters.AddWithValue("@GiaTriHoaDon", TongTienMoi);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", HinhThucMoi);
                cmd.Parameters.AddWithValue("@CachThucThanhToan", CachThucMoi);
                cmd.Parameters.AddWithValue("@NgayThanhToan", NgayThanhToanMoi);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo hoá đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to update data " + ex.Message);
            }
        }

        public void ThemHoaDon(string MaHD, string MaDT, int TongTienMoi, string HinhThucMoi, string CachThucMoi, DateTime NgayThanhToanMoi)
        {
            try
            {
                using SqlCommand cmd = new("AddHoaDon", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", MaHD);
                cmd.Parameters.AddWithValue("@MaDangTuyen", MaDT);
                cmd.Parameters.AddWithValue("@GiaTriHoaDon", TongTienMoi);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", HinhThucMoi);
                cmd.Parameters.AddWithValue("@CachThucThanhToan", CachThucMoi);
                cmd.Parameters.AddWithValue("@NgayThanhToan", NgayThanhToanMoi);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo hoá đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo hoá đơn " + ex.Message);
            }
        }

        public DataTable TimHoaDon(string search)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM HOADON WHERE MaHoaDon LIKE '%' + @search + '%' OR MaDangTuyen LIKE '%' + @search + '%' OR HinhThucThanhToan LIKE '%' + @search + '%' OR CachThucThanhToan LIKE '%' + @search + '%' ", conn);
                cmd.Parameters.AddWithValue("@search", search);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to load data " + ex.Message);
                return null;
            }
        }
    }
}
