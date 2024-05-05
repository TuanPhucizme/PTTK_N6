using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class DangTuyen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DVData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DVData).BeginInit();
            SuspendLayout();
            // 
            // DVData
            // 
            DVData.BackgroundColor = SystemColors.ControlDarkDark;
            DVData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVData.Dock = DockStyle.Bottom;
            DVData.Location = new Point(0, 233);
            DVData.Name = "DVData";
            DVData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            DVData.RowTemplate.Height = 29;
            DVData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DVData.Size = new Size(1182, 320);
            DVData.TabIndex = 0;
            DVData.CellDoubleClick += DVData_CellDoubleClick;
            // 
            // DangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(DVData);
            Name = "DangTuyen";
            Text = "DS Dang Tuyen";
            Load += TuyenDung_Load;
            ((System.ComponentModel.ISupportInitialize)DVData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DVData;
    }
}
