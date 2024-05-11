using System.Xml.Linq;
using WinFormsApp1;

namespace PROJECT_ADIS
{
    public partial class DanhSachHoaDon : Form
    {
        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            var db = new database();
            DgvDanhSachHoaDon.DataSource = db.PrintAllDanhSachHoaDon();
            DgvDanhSachHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hoá đơn";
            DgvDanhSachHoaDon.Columns["MaDangTuyen"].HeaderText = "Mã đăng tuyển";
            DgvDanhSachHoaDon.Columns["GiaTriHoaDon"].HeaderText = "Giá trị hoá đơn";
            DgvDanhSachHoaDon.Columns["HinhThucThanhToan"].HeaderText = "Hình thức thanh toán";
            DgvDanhSachHoaDon.Columns["CachThucThanhToan"].HeaderText = "Cách thức thanh toán";
            DgvDanhSachHoaDon.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
            DgvDanhSachHoaDon.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void DgvDanhSachHoaDon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detail = DgvDanhSachHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();

                new CapNhatHoaDon(detail).ShowDialog();
                LoadDanhSachHoaDon();
            }
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {
            var db = new database();
            DgvDanhSachHoaDon.DataSource = db.TimHoaDon(SearchBox.Text);
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            new ThemHoaDon().ShowDialog();
            LoadDanhSachHoaDon();
        }
    }
}
