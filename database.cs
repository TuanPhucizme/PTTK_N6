using ABC_Company;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class database
    {
        // modified 'Data Source' to match your local database instance User ID=sa; Password=123456 if need
        private string ConnectionString = @"Data Source=DESKTOP-JT70F25;Initial Catalog=PROJECTADIS;Integrated Security=True;Password = 123@abc"; 
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;

        public database()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open ();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối: " + ex.Message);
            }
        }


        public int Execute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                // Kiểm tra trạng thái kết nối trước khi mở
                cmd = new SqlCommand(sql, conn);

                // Sử dụng using cho đối tượng SqlCommand
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable DoanhNghiep()
        {
            try
            {
                sql = "SELECT * FROM CongTy"; 
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                return null;
            }
        }

        public DataTable TimDN(string search)
        {
            try
            {
                sql = @"SELECT cty.MaCongTy, cty.TenCongTy, cty.MaSoThue, cty.NguoiDaiDien, cty.DiaChi, cty.Email
                        FROM CongTy cty
                        WHERE TenCongTy LIKE '%' + @search + '%'";

                cmd = new SqlCommand(sql, conn);
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

        public DataRow chiTietDN(string MaCty)
        {
            try
            {
                sql = @"SELECT cty.MaCongTy, cty.TenCongTy, cty.MaSoThue, cty.NguoiDaiDien, cty.DiaChi, cty.Email
                        FROM CongTy cty
                        WHERE cty.MaCongTy = @MaCty";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCty", MaCty);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt.Rows[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to load data " + ex.Message);
                return null;
            }
        }

        public void updateDN(string MaCty, string newTenCongTy, string newMaSoThue, string newNguoiDaiDien, string newDiaChi, string newEmail)
        {
            try
            {
                string sql = @"UPDATE CongTy
                SET TenCongTy = @newTenCongTy, MaSoThue = @newMaSoThue, 
                NguoiDaiDien = @newNguoiDaiDien, DiaChi = @newDiaChi, Email = @newEmail 
                WHERE MaCongTy = @MaCty";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCty", MaCty);
                    cmd.Parameters.AddWithValue("@newTenCongTy", newTenCongTy);
                    cmd.Parameters.AddWithValue("@newMaSoThue", newMaSoThue);
                    cmd.Parameters.AddWithValue("@newNguoiDaiDien", newNguoiDaiDien);
                    cmd.Parameters.AddWithValue("@newDiaChi", newDiaChi);
                    cmd.Parameters.AddWithValue("@newEmail", newEmail);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update data: " + ex.Message);
            }
        }

        public bool ThemDN(string MaCTy, string TenCty, string MaThue, string NgDD, string Diachi, string Email)
        {
            try
            {
                // Thực hiện truy vấn SQL để thêm bản ghi mới vào cơ sở dữ liệu
                string sql = "INSERT INTO CongTy (MaCongTy, TenCongTy, MaSoThue, NguoiDaiDien, DiaChi, Email) VALUES (@MaCty, @TenCty, @MaSoThue, @NgDD, @DiaChi, @Email)";
                using (SqlCommand cmd = new SqlCommand(sql, conn)) 
                {
                    cmd.Parameters.AddWithValue("@MaCty", MaCTy);
                    cmd.Parameters.AddWithValue("@TenCty", TenCty);
                    cmd.Parameters.AddWithValue("@MaSoThue", MaThue);
                    cmd.Parameters.AddWithValue("@NgDD", NgDD);
                    cmd.Parameters.AddWithValue("@DiaChi", Diachi);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm ứng viên: " + ex.Message);
                return false;
            }
        }
        public void XoaDN(string MaCTy)
        {
            try
            {
                sql = @"DELETE FROM CongTy WHERE MaCongTy = @MaCTy";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCTy", MaCTy);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to update data " + ex.Message);
            }
        }

    }
}
