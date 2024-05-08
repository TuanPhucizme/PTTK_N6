using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROJECT_ADIS
{
    public partial class ThemHoaDon : Form
    {
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHD = txtMaHoaDon.Text; 
                string MaDT = txtMaDangTuyen.Text; 
                int TongTienMoi = int.Parse(txtGiatri.Text) ;
                string HinhThucMoi = cBoxHinhThuc.Text; 
                string CachThucMoi = cBoxCachThuc.Text;
                DateTime NgayThanhToanMoi = Date_Add.Value; 

                if (string.IsNullOrWhiteSpace(MaDT))
                {
                    MessageBox.Show("Mã Đăng Tuyển là bắt buộc!!!");
                    return;
                }

                new Database().ThemHoaDon(MaHD, MaDT, TongTienMoi, HinhThucMoi, CachThucMoi, NgayThanhToanMoi);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi tạo hoá đơn " + ex.Message);
            }
        }
    }
}
