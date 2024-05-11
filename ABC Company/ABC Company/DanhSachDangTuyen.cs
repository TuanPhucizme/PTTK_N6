using ABC_Company;

namespace WinFormsApp1
{
    public partial class DangTuyen : Form
    {
        public DangTuyen()
        {
            InitializeComponent();
        }

        private void TuyenDung_Load(object sender, EventArgs e)
        {
            var db = new database();
            DVData.DataSource = db.ListDangTuyen();
            DVData.Columns["MaChiTietDangTuyen"].Visible = false;
            DVData.Columns["SoLuongConLai"].HeaderText = "Số lượng tuyển dụng";
            DVData.Columns["HinhThucDangTuyen"].HeaderText = "Hình thức đăng tuyển";
            DVData.Columns["ViTri"].HeaderText = "Vị trí ứng tuyển";
            DVData.Columns["ThoiGianDangTuyen"].HeaderText = "Thời gian đăng tuyển";
            DVData.Columns["TenCongTy"].HeaderText = "Công ty đăng tuyển";
        }

        private void DVData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detailId = DVData.Rows[e.RowIndex].Cells["MaChiTietDangTuyen"].Value.ToString();
                var detailNumber = DVData.Rows[e.RowIndex].Cells["SoLuongConLai"].Value.ToString();
                new ChiTietDangTuyen(detailId, int.Parse(detailNumber)).ShowDialog();
                TuyenDung_Load(this, EventArgs.Empty);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var db = new database();
            DVData.DataSource = db.searchListDangTuyen(searchBox.Text);
            DVData.Columns["MaChiTietDangTuyen"].Visible = false;
            DVData.Columns["SoLuongConLai"].HeaderText = "Số lượng tuyển dụng";
            DVData.Columns["HinhThucDangTuyen"].HeaderText = "Hình thức đăng tuyển";
            DVData.Columns["ViTri"].HeaderText = "Vị trí ứng tuyển";
            DVData.Columns["ThoiGianDangTuyen"].HeaderText = "Thời gian đăng tuyển";
            DVData.Columns["TenCongTy"].HeaderText = "Công ty đăng tuyển";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new NewDangTuyen().ShowDialog();
            TuyenDung_Load(this, EventArgs.Empty);
        }
    }
}
