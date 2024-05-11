using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class UngVien : Form
    {
        public UngVien()
        {
            InitializeComponent();
        }

        private void UngVien_Load(object sender, EventArgs e)
        {
            var db = new database();
            dgvDt.DataSource = null;
            dgvDt.DataSource = db.UngVien();

            // Thêm cột vị trí vào DataGridView
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Vị trí";
            column.Name = "Vị trí"; // Đặt tên cho cột
            dgvDt.Columns.Add(column);
        }

        private void dgvDt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                var muv = dgvDt.Rows[e.RowIndex].Cells["Mã ứng viên"].Value.ToString();
                var hoTen = dgvDt.Rows[e.RowIndex].Cells["Họ tên"].Value.ToString();
                var diaChi = dgvDt.Rows[e.RowIndex].Cells["Địa chỉ"].Value.ToString();
                var email = dgvDt.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var loaiChungTu = dgvDt.Rows[e.RowIndex].Cells["Bằng cấp"].Value.ToString();
                var tinhTrangNop = dgvDt.Rows[e.RowIndex].Cells["Tình trạng nộp"].Value.ToString();

                // Truyền giá trị muv khi tạo thể hiện mới của ChiTietUngVien
                ChiTietUngVien formChiTietUngVien = new ChiTietUngVien(muv);
                formChiTietUngVien.FillData(hoTen, diaChi, email, loaiChungTu, tinhTrangNop);
                formChiTietUngVien.ShowDialog();
            }
        }


        private void btnDangky_Click(object sender, EventArgs e)
        {
            // Tạo một phiên bản mới của form DangKyUngVien
            DangKyUngVien dangKyForm = new DangKyUngVien();


            // Hiển thị form DangKyUngVien
            dangKyForm.ShowDialog();

            UngVien_Load(this, EventArgs.Empty);
        }

        // Phương thức cập nhật cột "Vị trí"
        public void UpdatePosition(string position)
        {
            // Lấy dòng hiện tại (dòng được focus) từ DataGridView
            DataGridViewRow currentRow = dgvDt.CurrentRow;

            // Kiểm tra xem dòng hiện tại có tồn tại hay không
            if (currentRow != null)
            {
                // Thiết lập giá trị vị trí cho dòng hiện tại
                currentRow.Cells["Vị trí"].Value = position;
            }
        }

        public void RefreshDataGrid()
        {
            var db = new database();
            dgvDt.DataSource = db.UngVien(); // Cập nhật lại dataGridView với dữ liệu mới từ cơ sở dữ liệu
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            var db = new database();
            dgvDt.DataSource = db.searchUngVien(txtTukhoa.Text);
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Vị trí";
            column.Name = "Vị trí"; // Đặt tên cho cột
            dgvDt.Columns.Add(column);
        }
    }
}
