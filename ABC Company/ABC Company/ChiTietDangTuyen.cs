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
        public ChiTietDangTuyen(string detail)
        {
            this.detail = detail;
            InitializeComponent();
        }

        private string detail;

        private void ChiTietDangTuyen_Load(object sender, EventArgs e)
        {
            var ChiTiet = new database().chiTietDangTuyen(detail);
            position.Text = ChiTiet["ViTri"].ToString();
            number.Text = ChiTiet["SoLuong"].ToString();
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
            DateTime dateTimeValue = Convert.ToDateTime(ChiTiet["ThoiGianDangTuyen"]);
            new database().updateDangTuyen(ChiTiet["MaDangTuyen"].ToString(), ChiTiet["MaChiTietDangTuyen"].ToString(), dateTimeValue, position.Text, int.Parse(number.Text), description.Text);
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            new DangKyUngTuyen(detail).ShowDialog();
            this.Close();
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
