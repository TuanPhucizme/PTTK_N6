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
            DVData.Columns["SoLuong"].HeaderText = "Số lượng tuyển dụng";
            DVData.Columns["ViTri"].HeaderText = "Vị trí ứng tuyển";
            DVData.Columns["ThoiGianDangTuyen"].HeaderText = "Thời gian đăng tuyển";
            DVData.Columns["TenCongTy"].HeaderText = "Công ty đăng tuyển";
        }

        private void DVData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detail = DVData.Rows[e.RowIndex].Cells["MaChiTietDangTuyen"].Value.ToString();
                new ChiTietDangTuyen(detail).ShowDialog();
                TuyenDung_Load(this, EventArgs.Empty);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var db = new database();
            DVData.DataSource = db.searchListDangTuyen(searchBox.Text);
            DVData.Columns["MaChiTietDangTuyen"].Visible = false;
            DVData.Columns["SoLuong"].HeaderText = "Số lượng tuyển dụng";
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
