namespace PROJECT_ADIS
{
    partial class ThemHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCNHoaDon = new Label();
            txtMaDangTuyen = new TextBox();
            txtMaHoaDon = new TextBox();
            txtGiatri = new TextBox();
            Date_Add = new DateTimePicker();
            cBoxCachThuc = new ComboBox();
            cBoxHinhThuc = new ComboBox();
            lblCachthuc = new Label();
            lblDate = new Label();
            lblMaDangTuyen = new Label();
            lblHinhthuc = new Label();
            lblGiatri = new Label();
            lblMaHoaDon = new Label();
            Button_Add = new Button();
            Button_Cancel = new Button();
            SuspendLayout();
            // 
            // lblCNHoaDon
            // 
            lblCNHoaDon.AutoSize = true;
            lblCNHoaDon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCNHoaDon.Location = new Point(142, 26);
            lblCNHoaDon.Name = "lblCNHoaDon";
            lblCNHoaDon.Size = new Size(288, 46);
            lblCNHoaDon.TabIndex = 8;
            lblCNHoaDon.Text = "THÊM HOÁ ĐƠN";
            lblCNHoaDon.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMaDangTuyen
            // 
            txtMaDangTuyen.Location = new Point(417, 96);
            txtMaDangTuyen.Name = "txtMaDangTuyen";
            txtMaDangTuyen.Size = new Size(125, 27);
            txtMaDangTuyen.TabIndex = 2;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(130, 96);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(125, 27);
            txtMaHoaDon.TabIndex = 1;
            // 
            // txtGiatri
            // 
            txtGiatri.Location = new Point(130, 157);
            txtGiatri.Name = "txtGiatri";
            txtGiatri.Size = new Size(125, 27);
            txtGiatri.TabIndex = 3;
            // 
            // Date_Add
            // 
            Date_Add.Format = DateTimePickerFormat.Short;
            Date_Add.Location = new Point(417, 155);
            Date_Add.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            Date_Add.Name = "Date_Add";
            Date_Add.Size = new Size(125, 27);
            Date_Add.TabIndex = 4;
            Date_Add.Value = new DateTime(2024, 5, 7, 0, 0, 0, 0);
            // 
            // cBoxCachThuc
            // 
            cBoxCachThuc.FormattingEnabled = true;
            cBoxCachThuc.Items.AddRange(new object[] { "Toàn bộ", "Trả góp" });
            cBoxCachThuc.Location = new Point(417, 214);
            cBoxCachThuc.Name = "cBoxCachThuc";
            cBoxCachThuc.Size = new Size(125, 28);
            cBoxCachThuc.TabIndex = 6;
            // 
            // cBoxHinhThuc
            // 
            cBoxHinhThuc.FormattingEnabled = true;
            cBoxHinhThuc.Items.AddRange(new object[] { "Tiền mặt", "Thẻ" });
            cBoxHinhThuc.Location = new Point(130, 214);
            cBoxHinhThuc.Name = "cBoxHinhThuc";
            cBoxHinhThuc.Size = new Size(125, 28);
            cBoxHinhThuc.TabIndex = 5;
            // 
            // lblCachthuc
            // 
            lblCachthuc.AutoSize = true;
            lblCachthuc.Location = new Point(283, 217);
            lblCachthuc.Name = "lblCachthuc";
            lblCachthuc.Size = new Size(74, 20);
            lblCachthuc.TabIndex = 30;
            lblCachthuc.Text = "Cách thức";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(283, 160);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(119, 20);
            lblDate.TabIndex = 29;
            lblDate.Text = "Ngày thanh toán";
            // 
            // lblMaDangTuyen
            // 
            lblMaDangTuyen.AutoSize = true;
            lblMaDangTuyen.Location = new Point(283, 99);
            lblMaDangTuyen.Name = "lblMaDangTuyen";
            lblMaDangTuyen.Size = new Size(108, 20);
            lblMaDangTuyen.TabIndex = 28;
            lblMaDangTuyen.Text = "Mã đăng tuyển";
            // 
            // lblHinhthuc
            // 
            lblHinhthuc.AutoSize = true;
            lblHinhthuc.Location = new Point(38, 217);
            lblHinhthuc.Name = "lblHinhthuc";
            lblHinhthuc.Size = new Size(73, 20);
            lblHinhthuc.TabIndex = 27;
            lblHinhthuc.Text = "Hình thức";
            // 
            // lblGiatri
            // 
            lblGiatri.AutoSize = true;
            lblGiatri.Location = new Point(38, 160);
            lblGiatri.Name = "lblGiatri";
            lblGiatri.Size = new Size(86, 20);
            lblGiatri.TabIndex = 26;
            lblGiatri.Text = "Tổng giá trị";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Location = new Point(38, 99);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(89, 20);
            lblMaHoaDon.TabIndex = 25;
            lblMaHoaDon.Text = "Mã hoá đơn";
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(383, 280);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(100, 35);
            Button_Add.TabIndex = 8;
            Button_Add.Tag = "";
            Button_Add.Text = "Thêm";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(120, 280);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 35);
            Button_Cancel.TabIndex = 7;
            Button_Cancel.Text = "Huỷ";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // ThemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(txtMaDangTuyen);
            Controls.Add(txtMaHoaDon);
            Controls.Add(txtGiatri);
            Controls.Add(Date_Add);
            Controls.Add(cBoxCachThuc);
            Controls.Add(cBoxHinhThuc);
            Controls.Add(lblCachthuc);
            Controls.Add(lblDate);
            Controls.Add(lblMaDangTuyen);
            Controls.Add(lblHinhthuc);
            Controls.Add(lblGiatri);
            Controls.Add(lblMaHoaDon);
            Controls.Add(Button_Add);
            Controls.Add(Button_Cancel);
            Controls.Add(lblCNHoaDon);
            Name = "ThemHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemHoaDon";
            Load += ThemHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCNHoaDon;
        private TextBox txtMaDangTuyen;
        private TextBox txtMaHoaDon;
        private TextBox txtGiatri;
        private DateTimePicker Date_Add;
        private ComboBox cBoxCachThuc;
        private ComboBox cBoxHinhThuc;
        private Label lblCachthuc;
        private Label lblDate;
        private Label lblMaDangTuyen;
        private Label lblHinhthuc;
        private Label lblGiatri;
        private Label lblMaHoaDon;
        private Button Button_Add;
        private Button Button_Cancel;
    }
}