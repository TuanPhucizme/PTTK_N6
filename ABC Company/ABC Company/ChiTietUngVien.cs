using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    public partial class ChiTietUngVien : Form
    {
        private string muv;

        public ChiTietUngVien(string muv)
        {
            this.muv = muv;
            InitializeComponent();
        }

        private void ChiTietUngVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(muv))
            {
                this.Text = "Thêm mới ứng viên";
            }
            else
            {
                this.Text = "Thông tin chi tiết ứng viên";
                txtMaUngVien.Text = muv;
            }
        }

        // Cập nhật phương thức FillData
        public void FillData(string hoTen, string diaChi, string email, string loaiChungTu, string tinhTrangNop)
        {
            txtHoTen.Text = hoTen;
            txtDiaChi.Text = diaChi;
            txtEmail.Text = email;
            txtLoaiChungTu.Text = loaiChungTu;
            txtTinhTrangNop.Text = tinhTrangNop;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Ẩn form ChiTietUngVien
            this.Hide();

            // Kiểm tra xem form UngVien đã được tạo chưa
            UngVien ungVienForm = Application.OpenForms.OfType<UngVien>().FirstOrDefault();
            if (ungVienForm == null)
            {
                // Nếu chưa được tạo, tạo một instance mới và hiển thị
                ungVienForm = new UngVien();
                ungVienForm.Show();
            }
            else
            {
                // Nếu đã được tạo, chỉ hiển thị nó
                ungVienForm.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trường txtTinhTrangNop có giá trị không
            if (string.IsNullOrEmpty(txtTinhTrangNop.Text))
            {
                // Nếu trống, chuyển hướng sang trang mới ViTriUngTuyen
                new ViTriUngTuyen().ShowDialog();
               
                //this.Hide(); // Ẩn form ChiTietUngVien
            }
            else
            {
                // Nếu đã có giá trị, hiển thị hộp thoại thông báo
                MessageBox.Show("Đã đầy đủ thông tin. Không thể cập nhật.");
            }
        }
    }
}
