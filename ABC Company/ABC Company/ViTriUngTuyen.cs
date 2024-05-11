using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    public partial class ViTriUngTuyen : Form
    {

        // Tạo một thuộc tính để lưu trữ giá trị vị trí được chọn
        public string SelectedPosition { get; private set; }


        public ViTriUngTuyen()
        {
            InitializeComponent();
            
        }


        private void ViTriUngTuyen_Load(object sender, EventArgs e)
        {

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem radiobutton nào được chọn và lưu giá trị tương ứng
            if (radioI.Checked)
            {
                SelectedPosition = "Intern";
            }
            else if (radioF.Checked)
            {
                SelectedPosition = "Fresher";
            }
            else if (radioJ.Checked)
            {
                SelectedPosition = "Junior";
            }
            else if (radioS.Checked)
            {
                SelectedPosition = "Senior";
            }

            // Gọi phương thức UpdatePosition của form UngVien để cập nhật cột "Vị trí"
            UngVien ungVienForm = Application.OpenForms.OfType<UngVien>().FirstOrDefault();
            if (ungVienForm != null)
            {
                ungVienForm.UpdatePosition(SelectedPosition);
            }

        }


    }
}
