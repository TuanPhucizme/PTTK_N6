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

namespace PROJECT_ADIS
{
    public partial class CapNhatHoaDon : Form
    {
        private readonly string detail;
        public CapNhatHoaDon(string detail)
        {
            this.detail = detail;
            InitializeComponent();
        }

        private void CapNhatHoaDon_Load(object sender, EventArgs e)
        {
            var ChiTietHD = new Database().ShowChiTietHoaDon(detail);
            txtMaHoaDon.Text = ChiTietHD["MaHoaDon"].ToString();
            txtMaDangTuyen.Text = ChiTietHD["MaDangTuyen"].ToString();
            DateTime dateTimeValue = Convert.ToDateTime(ChiTietHD["NgayThanhToan"]);
            Date_Update.Value = dateTimeValue;
            txtGiatri.Text = ChiTietHD["GiaTriHoaDon"].ToString();
            cBoxHinhThuc.Text = ChiTietHD["HinhThucThanhToan"].ToString();
            cBoxCachThuc.Text = ChiTietHD["CachThucThanhToan"].ToString();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var ChiTiet = new Database().ShowChiTietHoaDon(detail);

                if (ChiTiet == null)
                {
                    MessageBox.Show("Details not found.");
                    return;
                }

                DateTime dateTimeValue = Convert.ToDateTime(ChiTiet["NgayThanhToan"]);
                new Database().CapNhatHoaDon(ChiTiet["MaHoaDon"].ToString(), ChiTiet["MaDangTuyen"].ToString(), int.Parse(txtGiatri.Text), cBoxHinhThuc.Text, cBoxCachThuc.Text, Date_Update.Value);
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
