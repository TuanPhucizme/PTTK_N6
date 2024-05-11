namespace PROJECT_ADIS
{
    partial class DanhSachHoaDon
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
            DgvDanhSachHoaDon = new DataGridView();
            Button_Find = new Button();
            Button_Add = new Button();
            label1 = new Label();
            SearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvDanhSachHoaDon).BeginInit();
            SuspendLayout();
            // 
            // DgvDanhSachHoaDon
            // 
            DgvDanhSachHoaDon.AllowUserToAddRows = false;
            DgvDanhSachHoaDon.AllowUserToDeleteRows = false;
            DgvDanhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDanhSachHoaDon.BackgroundColor = SystemColors.Control;
            DgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDanhSachHoaDon.Dock = DockStyle.Bottom;
            DgvDanhSachHoaDon.Location = new Point(0, 153);
            DgvDanhSachHoaDon.MultiSelect = false;
            DgvDanhSachHoaDon.Name = "DgvDanhSachHoaDon";
            DgvDanhSachHoaDon.ReadOnly = true;
            DgvDanhSachHoaDon.RowHeadersWidth = 51;
            DgvDanhSachHoaDon.Size = new Size(882, 400);
            DgvDanhSachHoaDon.TabIndex = 0;
            DgvDanhSachHoaDon.CellContentDoubleClick += DgvDanhSachHoaDon_CellContentDoubleClick;
            // 
            // Button_Find
            // 
            Button_Find.Location = new Point(663, 96);
            Button_Find.Name = "Button_Find";
            Button_Find.Size = new Size(100, 35);
            Button_Find.TabIndex = 10;
            Button_Find.Text = "Tìm";
            Button_Find.UseVisualStyleBackColor = true;
            Button_Find.Click += Button_Find_Click;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(782, 96);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(100, 35);
            Button_Add.TabIndex = 11;
            Button_Add.Text = "Thêm";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 19);
            label1.Name = "label1";
            label1.Size = new Size(391, 46);
            label1.TabIndex = 12;
            label1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(246, 100);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(391, 27);
            SearchBox.TabIndex = 13;
            // 
            // DanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(882, 553);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Controls.Add(Button_Add);
            Controls.Add(Button_Find);
            Controls.Add(DgvDanhSachHoaDon);
            Name = "DanhSachHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABC Company";
            Load += DanhSachHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)DgvDanhSachHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvDanhSachHoaDon;
        private Button Button_Find;
        private Button Button_Add;
        private Label label1;
        private TextBox SearchBox;
    }
}
