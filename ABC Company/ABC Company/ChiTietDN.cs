using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class ChiTietDN : Form
    {

        public ChiTietDN(string MaCty)
        {
            this.MaCty = MaCty;
            InitializeComponent();
        }

        private string MaCty;
        private void ChiTietDN_Load_1(object sender, EventArgs e)
        {
            var ChiTiet = new database().chiTietDN(MaCty);
            txtMaCTy.Text = ChiTiet["MaCongTy"].ToString();
            txtTenCty.Text = ChiTiet["TenCongTy"].ToString();
            txtMaThue.Text = ChiTiet["MaSoThue"].ToString();
            txtNgDD.Text = ChiTiet["NguoiDaiDien"].ToString();
            txtDiaChi.Text = ChiTiet["DiaChi"].ToString();
            txtEmail.Text = ChiTiet["Email"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            var ChiTiet = new database().chiTietDN(MaCty);
            new database().updateDN(ChiTiet["MaCongTy"].ToString(), txtTenCty.Text, txtMaThue.Text, txtNgDD.Text, txtDiaChi.Text, txtEmail.Text);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Ẩn form
            this.Close();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            new database().XoaDN(MaCty);
            this.Close();
        }
    }
}
