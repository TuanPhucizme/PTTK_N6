using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class DangKyDN : Form
    {
        public DangKyDN()
        {
            InitializeComponent();
        }

        private void DangKyDN_Load(object sender, EventArgs e)
        {
            var db = new database();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textBox trên form
            string MaCty = txtMaCty.Text;
            string TenCty = txtTenCty.Text;
            string MaThue = txtMaThue.Text;
            string NguoiDD = txtNguoiDD.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;

            // Thêm bản ghi mới vào cơ sở dữ liệu
            var db = new database();
            bool success = db.ThemDN(MaCty, TenCty, MaThue, NguoiDD, DiaChi, Email);

            if (success)
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
