using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class DanhSachDN : Form
    {

        public DanhSachDN()
        {
            InitializeComponent();
        }

        private void UngVien_Load(object sender, EventArgs e)
        {
            var db = new database();
            DSDN.DataSource = db.DoanhNghiep();
            DSDN.Columns["MaCongTy"].Visible = false;
            DSDN.Columns["TenCongTy"].HeaderText = "Tên Công Ty";
            DSDN.Columns["MaSoThue"].HeaderText = "Mã Số Thuế";
            DSDN.Columns["NguoiDaiDien"].HeaderText = "Người Đại Diện";
            DSDN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            DSDN.Columns["Email"].HeaderText = "Email";
        }

        private void DSDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detail = DSDN.Rows[e.RowIndex].Cells["MaCongTy"].Value.ToString();
                new ChiTietDN(detail).ShowDialog();
                UngVien_Load(this, EventArgs.Empty);
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            new DangKyDN().ShowDialog();
            UngVien_Load(this, EventArgs.Empty);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            var db = new database();
            DSDN.DataSource = db.TimDN(txtTukhoa.Text);
            DSDN.Columns["MaCongTy"].Visible=false;
            DSDN.Columns["TenCongTy"].HeaderText = "Tên Công Ty";
            DSDN.Columns["MaSoThue"].HeaderText = "Mã Số Thuế";
            DSDN.Columns["NguoiDaiDien"].HeaderText = "Người Đại Diện";
            DSDN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            DSDN.Columns["Email"].HeaderText = "Email";
        }
    }
}
