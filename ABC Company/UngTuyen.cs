using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class UngTuyen : Form
    {
        public UngTuyen()
        {
            InitializeComponent();
        }

        private void UngTuyen_Load(object sender, EventArgs e)
        {
            var db = new database();
            dgvDt.DataSource = db.UngVien();
        }
    }
}
