using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class DangKyUngVien : Form
    {
        public DangKyUngVien()
        {
            InitializeComponent();
        }


        private void DangKyUngVien_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textBox trên form
            string hoTen = txtTen.Text;
            string diaChi = txtDc.Text;
            string email = txtE.Text;
            DateTime ngaySinh;
            if (!DateTime.TryParseExact(txtDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng yyyy-MM-dd.");
                return;
            }
            string cccd = txtCccd.Text;
            string maUngVien = txtMuv.Text;

            // Thêm bản ghi mới vào cơ sở dữ liệu
            var db = new database();
            bool success = db.AddNewCandidate(hoTen, diaChi, email, ngaySinh, cccd, maUngVien);

            if (success)
            {
                MessageBox.Show("Thêm ứng viên thành công!");

                // Cập nhật lại dataGridView trên form UngVien
                /*((UngVien)this.Owner).RefreshDataGrid();*/

                // Đóng form DangKyUngVien sau khi thêm thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm ứng viên thất bại!");
            }
        }



    }
}
