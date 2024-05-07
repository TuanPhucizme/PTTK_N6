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
            DVData.DataSource = db.selectDangTuyen();
            DVData.Columns["MaDangTuyen"].HeaderText = "Mã đăng tuyển";
            DVData.Columns["ViTri"].HeaderText = "Vị trí ứng tuyển";
            DVData.Columns["ThoiGianDangTuyen"].HeaderText = "Thời gian đăng tuyển";
            DVData.Columns["CongTyDangTuyen"].HeaderText = "Công ty đăng tuyển";
            DVData.AutoResizeRowHeadersWidth(
            0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void DVData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detail = DVData.Rows[e.RowIndex].Cells["MaDangTuyen"].Value.ToString();
                new ChiTietDangTuyen(detail).ShowDialog();
            }
        }
    }
}
