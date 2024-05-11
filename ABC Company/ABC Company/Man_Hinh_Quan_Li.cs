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
using PROJECT_ADIS;

namespace ABC_Company
{
    public partial class Man_Hinh_Quan_Li : Form
    {
        public Man_Hinh_Quan_Li()
        {
            InitializeComponent();
        }

        private void candidate_Click(object sender, EventArgs e)
        {
            new UngVien().ShowDialog();
        }

        private void company_Click(object sender, EventArgs e)
        {
            new DanhSachDN().ShowDialog();
        }

        private void jobPost_Click(object sender, EventArgs e)
        {
            new DangTuyen().ShowDialog();
        }

        private void bill_Click(object sender, EventArgs e)
        {
            new DanhSachHoaDon().ShowDialog();
        }

        private void payment_Click(object sender, EventArgs e)
        {

        }
    }
}
