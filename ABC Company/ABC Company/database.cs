using ABC_Company;
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
        // modified 'Data Source' to match your local database instance User ID=sa; Password=123456 if need
        private string connstr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=PROJECTADIS;Integrated Security=True";
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

        public DataTable ListDangTuyen()
        {
            try
            {
                sql = @"SELECT cdt.MaChiTietDangTuyen, cdt.ViTri, cdt.SoLuong, dst.ThoiGianDangTuyen, c.TenCongTy FROM ChiTietDangTuyen cdt 
                       INNER JOIN DanhSachDangTuyen dst ON cdt.MaDangTuyen = dst.MaDangTuyen 
                       INNER JOIN CongTy c ON dst.CongTyDangTuyen = c.MaCongTy";
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
        }

        public DataTable searchListDangTuyen(string search)
        {
            try
            {
                sql = @"SELECT cdt.MaChiTietDangTuyen, cdt.ViTri, cdt.SoLuong, dst.ThoiGianDangTuyen, c.TenCongTy FROM ChiTietDangTuyen cdt 
                       INNER JOIN DanhSachDangTuyen dst ON cdt.MaDangTuyen = dst.MaDangTuyen 
                       INNER JOIN CongTy c ON dst.CongTyDangTuyen = c.MaCongTy
                       WHERE ViTri LIKE '%' + @search + '%' OR TenCongTy LIKE '%' + @search + '%'";

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

        public DataTable UngVien()
        {
            try
            {
                sql = @"SELECT UV.MaUngVien AS 'Mã ứng viên', 
                       UV.HoTen AS 'Họ tên', 
                       UV.DiaChi AS 'Địa chỉ', 
                       UV.Email AS 'Email', 
                       DSTC.LoaiChungTu AS 'Bằng cấp', 
                       CASE WHEN DSTC.TinhTrangNop = 1 THEN 'da nop' ELSE NULL END AS 'tình trạng nộp'
                FROM UngVien UV
                LEFT JOIN DanhSachChungTu DSTC ON UV.MaUngVien = DSTC.MaUngVien";
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
        }







        public DataRow chiTietDangTuyen(string MaDT)
        {
            try
            {
                sql = @"SELECT cdt.MaChiTietDangTuyen, cdt.MaDangTuyen ,dst.ThoiGianDangTuyen, dst.HinhThucDangTuyen, cdt.ViTri, cdt.SoLuong, cdt.MoTa, c.TenCongTy 
                        FROM ChiTietDangTuyen cdt
                        INNER JOIN DanhSachDangTuyen dst ON cdt.MaDangTuyen = dst.MaDangTuyen
                        INNER JOIN CongTy c ON dst.CongTyDangTuyen = c.MaCongTy
                        WHERE cdt.MaChiTietDangTuyen = @MaDT";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDT", MaDT);
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

        public void updateDangTuyen(string MaDT, string MaCTDT, DateTime newThoiGianDangTuyen, string newViTri, int newSoLuong, string newMoTa)
        {
            try
            {
                string sql1 = @"UPDATE DanhSachDangTuyen
                                SET ThoiGianDangTuyen = @newThoiGianDangTuyen
                                WHERE MaDangTuyen = @MaDT";

                string sql2 = @"UPDATE ChiTietDangTuyen
                                SET ViTri = @newViTri,
                                    SoLuong = @newSoLuong,
                                    MoTa = @newMoTa
                                WHERE MaChiTietDangTuyen = @MaCTDT";

                using (SqlCommand cmd = new SqlCommand(sql1, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDT", MaDT);
                    cmd.Parameters.AddWithValue("@newThoiGianDangTuyen", newThoiGianDangTuyen);
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand(sql2, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCTDT", MaCTDT);
                    cmd.Parameters.AddWithValue("@newViTri", newViTri);
                    cmd.Parameters.AddWithValue("@newSoLuong", newSoLuong);
                    cmd.Parameters.AddWithValue("@newMoTa", newMoTa);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to update data " + ex.Message);
            }
        }

        public void registerDangTuyen(string MaCTDT, string MaHS, string MaUV)
        {
            try
            {
                string sql1 = @"INSERT DanhSachDangKyUngTuyen (MaDangTuyen, MaUngVien) VALUES (@MaDT, @MaUV)";
                string sql2 = @"SELECT MaDangTuyen";
                string sql3 = @"INSERT DanhSachDangKyUngTuyen (MaDangTuyen, MaUngVien) VALUES (@MaDT, @MaUV)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaUV", MaUV);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to update data " + ex.Message);
            }
        }

        public List<string> companySuggestion()
        {
            List<string> suggestions = new List<string>();
            try
            {
                sql = @"SELECT MaCongTy FROM CongTy";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    // Convert data to List<string>
                    foreach (DataRow row in dt.Rows)
                    {
                        suggestions.Add(row["MaCongTy"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to get data " + ex.Message);
            }
            return suggestions;
        }

        public List<string> paperSuggestion()
        {
            List<string> suggestions = new List<string>();
            try
            {
                sql = @"SELECT MaChungTu FROM DanhSachChungTu";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    // Convert data to List<string>
                    foreach (DataRow row in dt.Rows)
                    {
                        suggestions.Add(row["MaChungTu"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to get data " + ex.Message);
            }
            return suggestions;
        }

        public List<string> applierSuggestion()
        {
            List<string> suggestions = new List<string>();
            try
            {
                sql = @"SELECT MaUngVien FROM UngVien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    // Convert data to List<string>
                    foreach (DataRow row in dt.Rows)
                    {
                        suggestions.Add(row["MaUngVien"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to get data " + ex.Message);
            }
            return suggestions;
        }

        public bool applyCheck(string UV, string CT)
        {
            try
            {
                sql = @"SELECT MaUngVien, TinhTrangNop FROM DanhSachChungTu where MaChungTu = @hoso";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@hoso", CT);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string retrievedUV = reader["MaUngVien"].ToString();
                            bool retrievedStatus = (bool)reader["TinhTrangNop"]; 
                            return retrievedUV.Equals(UV) && retrievedStatus;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to get data " + ex.Message);
            }

            return false; // Return false if no matching record or exception occurs
        }

        public void createDangTuyen(DateTime newThoiGianDangTuyen, string newViTri, int newSoLuong, string newMoTa, string companyId)
        {
            try
            {
                string maChiTietDangTuyen = null;
                string maDangTuyen = null;
                string sql1 = @"INSERT ChiTietDangTuyen (MaChiTietDangTuyen, MaDangTuyen, ViTri, SoLuong, MoTa) VALUES (@MaCTDT, @MaDT, @Vitri, @Soluong, @Mota)";
                string sql2 = @"SELECT TOP 1 MaChiTietDangTuyen FROM ChiTietDangTuyen ORDER BY MaChiTietDangTuyen DESC";
                string sql3 = @"SELECT MaDangTuyen FROM DanhSachDangTuyen WHERE CongTyDangTuyen = @companyId";

                using (SqlCommand cmd = new SqlCommand(sql2, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maChiTietDangTuyen = reader["MaChiTietDangTuyen"].ToString();
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(sql3, conn))
                {
                    cmd.Parameters.AddWithValue("@companyId", companyId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maDangTuyen = reader["MaDangTuyen"].ToString();
                        }
                    }
                }

                string prefix = maChiTietDangTuyen.Substring(0, 4);
                string numberPart = maChiTietDangTuyen.Substring(4);
                int number = int.Parse(numberPart) + 1;
                numberPart = number.ToString().PadLeft(numberPart.Length, '0');

                maChiTietDangTuyen = prefix + numberPart;

                using (SqlCommand cmd = new SqlCommand(sql1, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCTDT", maChiTietDangTuyen);
                    cmd.Parameters.AddWithValue("@Vitri", newViTri);
                    cmd.Parameters.AddWithValue("@SoLuong", newSoLuong);
                    cmd.Parameters.AddWithValue("@MoTa", newMoTa);
                    cmd.Parameters.AddWithValue("@MaDT", maDangTuyen);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to update data " + ex.Message);
            }
        }

        public void deleteDangTuyen(string MaCTDT)
        {
            try
            {
                sql = @"DELETE FROM ChiTietDangTuyen WHERE MaChiTietDangTuyen = @MaCTDT";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCTDT", MaCTDT);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to update data " + ex.Message);
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

        public bool AddNewCandidate(string hoTen, string diaChi, string email, DateTime ngaySinh, string cccd, string maUngVien)
        {
            try
            {
                // Thực hiện truy vấn SQL để thêm bản ghi mới vào cơ sở dữ liệu
                string sql = "INSERT INTO UngVien (HoTen, DiaChi, Email, NgaySinh, CCCD, MaUngVien) VALUES (@HoTen, @DiaChi, @Email, @NgaySinh, @CCCD, @MaUngVien)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@CCCD", cccd);
                cmd.Parameters.AddWithValue("@MaUngVien", maUngVien);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Trả về true nếu thêm thành công và ngược lại
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm ứng viên: " + ex.Message);
                return false;
            }
        }




    }
}
