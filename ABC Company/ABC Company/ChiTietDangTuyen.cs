using ABC_Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChiTietDangTuyen : Form
    {
        public ChiTietDangTuyen(string detail, int left)
        {
            this.detail = detail;
            this.left = left;
            InitializeComponent();
        }

        private string detail;
        private int left;

        private void ChiTietDangTuyen_Load(object sender, EventArgs e)
        {
            var ChiTiet = new database().chiTietDangTuyen(detail);
            position.Text = ChiTiet["ViTri"].ToString();
            number.Text = ChiTiet["SoLuong"].ToString();
            type.Text = ChiTiet["HinhThucDangTuyen"].ToString();
            DateTime dateTimeValue = Convert.ToDateTime(ChiTiet["ThoiGianDangTuyen"]);
            UploadDate.Text = dateTimeValue.ToShortDateString();
            description.Text = ChiTiet["MoTa"].ToString();
            company.Text = ChiTiet["TenCongTy"].ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            new database().deleteDangTuyen(detail);
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            var ChiTiet = new database().chiTietDangTuyen(detail);
            new database().updateDangTuyen(ChiTiet["MaDangTuyen"].ToString(), ChiTiet["MaChiTietDangTuyen"].ToString(), UploadDate.Value, position.Text, int.Parse(number.Text), description.Text, type.Text);
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (left == 0)
            {
                MessageBox.Show("Đã hết số lượng đăng kí cho vị trí này");

            }
            else
            {
                new DangKyUngTuyen(detail).ShowDialog();
                this.Close();
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
