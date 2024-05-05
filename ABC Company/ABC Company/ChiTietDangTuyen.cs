using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChiTietDangTuyen : Form
    {
        public ChiTietDangTuyen(string detail)
        {
            this.detail = detail;
            InitializeComponent();
        }

        private string detail;

        private void ChiTietDangTuyen_Load(object sender, EventArgs e)
        {
            MessageBox.Show(detail);
        }
    }
}
