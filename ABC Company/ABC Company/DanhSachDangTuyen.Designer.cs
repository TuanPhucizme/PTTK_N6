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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Search = new Button();
            searchBox = new TextBox();
            Add = new Button();
            DVData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DVData).BeginInit();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Location = new Point(492, 42);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 1;
            Search.Text = "Tim kiem";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(173, 42);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(313, 27);
            searchBox.TabIndex = 2;
            // 
            // Add
            // 
            Add.Location = new Point(615, 42);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 3;
            Add.Text = "Them";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // DVData
            // 
            DVData.AllowUserToAddRows = false;
            DVData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DVData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DVData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DVData.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DVData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DVData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DVData.DefaultCellStyle = dataGridViewCellStyle3;
            DVData.Location = new Point(173, 96);
            DVData.Name = "DVData";
            DVData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DVData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DVData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            DVData.RowTemplate.Height = 29;
            DVData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DVData.Size = new Size(536, 296);
            DVData.TabIndex = 0;
            DVData.CellDoubleClick += DVData_CellDoubleClick;
            // 
            // DangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 394);
            Controls.Add(Add);
            Controls.Add(searchBox);
            Controls.Add(Search);
            Controls.Add(DVData);
            Name = "DangTuyen";
            Text = "DS Dang Tuyen";
            Load += TuyenDung_Load;
            ((System.ComponentModel.ISupportInitialize)DVData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Search;
        private TextBox searchBox;
        private Button Add;
        private DataGridView DVData;
    }
}
