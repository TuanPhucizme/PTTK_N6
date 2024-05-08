namespace PROJECT_ADIS
{
    partial class CapNhatHoaDon
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
            Button_Cancel = new Button();
            Button_Update = new Button();
            lblMaHoaDon = new Label();
            lblGiatri = new Label();
            lblHinhthuc = new Label();
            lblMaDangTuyen = new Label();
            lblDate = new Label();
            lblCachthuc = new Label();
            cBoxHinhThuc = new ComboBox();
            cBoxCachThuc = new ComboBox();
            Date_Update = new DateTimePicker();
            txtGiatri = new TextBox();
            txtMaHoaDon = new TextBox();
            txtMaDangTuyen = new TextBox();
            SuspendLayout();
            // 
            // lblCNHoaDon
            // 
            lblCNHoaDon.AutoSize = true;
            lblCNHoaDon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCNHoaDon.Location = new Point(102, 9);
            lblCNHoaDon.Name = "lblCNHoaDon";
            lblCNHoaDon.Size = new Size(363, 46);
            lblCNHoaDon.TabIndex = 7;
            lblCNHoaDon.Text = "CẬP NHẬT HOÁ ĐƠN";
            lblCNHoaDon.TextAlign = ContentAlignment.TopCenter;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(102, 293);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 35);
            Button_Cancel.TabIndex = 7;
            Button_Cancel.Text = "Huỷ";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Update
            // 
            Button_Update.Location = new Point(365, 293);
            Button_Update.Name = "Button_Update";
            Button_Update.Size = new Size(100, 35);
            Button_Update.TabIndex = 8;
            Button_Update.Text = "Cập nhật";
            Button_Update.UseVisualStyleBackColor = true;
            Button_Update.Click += Button_Update_Click;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Location = new Point(28, 85);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(89, 20);
            lblMaHoaDon.TabIndex = 1;
            lblMaHoaDon.Text = "Mã hoá đơn";
            // 
            // lblGiatri
            // 
            lblGiatri.AutoSize = true;
            lblGiatri.Location = new Point(28, 146);
            lblGiatri.Name = "lblGiatri";
            lblGiatri.Size = new Size(86, 20);
            lblGiatri.TabIndex = 11;
            lblGiatri.Text = "Tổng giá trị";
            // 
            // lblHinhthuc
            // 
            lblHinhthuc.AutoSize = true;
            lblHinhthuc.Location = new Point(28, 213);
            lblHinhthuc.Name = "lblHinhthuc";
            lblHinhthuc.Size = new Size(73, 20);
            lblHinhthuc.TabIndex = 12;
            lblHinhthuc.Text = "Hình thức";
            // 
            // lblMaDangTuyen
            // 
            lblMaDangTuyen.AutoSize = true;
            lblMaDangTuyen.Location = new Point(273, 85);
            lblMaDangTuyen.Name = "lblMaDangTuyen";
            lblMaDangTuyen.Size = new Size(108, 20);
            lblMaDangTuyen.TabIndex = 13;
            lblMaDangTuyen.Text = "Mã đăng tuyển";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(273, 146);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(119, 20);
            lblDate.TabIndex = 14;
            lblDate.Text = "Ngày thanh toán";
            // 
            // lblCachthuc
            // 
            lblCachthuc.AutoSize = true;
            lblCachthuc.Location = new Point(273, 213);
            lblCachthuc.Name = "lblCachthuc";
            lblCachthuc.Size = new Size(74, 20);
            lblCachthuc.TabIndex = 15;
            lblCachthuc.Text = "Cách thức";
            // 
            // cBoxHinhThuc
            // 
            cBoxHinhThuc.FormattingEnabled = true;
            cBoxHinhThuc.Items.AddRange(new object[] { "Tiền mặt", "Thẻ" });
            cBoxHinhThuc.Location = new Point(120, 210);
            cBoxHinhThuc.Name = "cBoxHinhThuc";
            cBoxHinhThuc.Size = new Size(125, 28);
            cBoxHinhThuc.TabIndex = 5;
            // 
            // cBoxCachThuc
            // 
            cBoxCachThuc.FormattingEnabled = true;
            cBoxCachThuc.Items.AddRange(new object[] { "Toàn bộ", "Trả góp" });
            cBoxCachThuc.Location = new Point(407, 210);
            cBoxCachThuc.Name = "cBoxCachThuc";
            cBoxCachThuc.Size = new Size(125, 28);
            cBoxCachThuc.TabIndex = 6;
            // 
            // Date_Update
            // 
            Date_Update.Format = DateTimePickerFormat.Short;
            Date_Update.Location = new Point(407, 141);
            Date_Update.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            Date_Update.Name = "Date_Update";
            Date_Update.Size = new Size(125, 27);
            Date_Update.TabIndex = 4;
            Date_Update.Value = new DateTime(2024, 5, 7, 0, 0, 0, 0);
            // 
            // txtGiatri
            // 
            txtGiatri.Location = new Point(120, 143);
            txtGiatri.Name = "txtGiatri";
            txtGiatri.Size = new Size(125, 27);
            txtGiatri.TabIndex = 3;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(120, 82);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(125, 27);
            txtMaHoaDon.TabIndex = 1;
            // 
            // txtMaDangTuyen
            // 
            txtMaDangTuyen.Location = new Point(407, 82);
            txtMaDangTuyen.Name = "txtMaDangTuyen";
            txtMaDangTuyen.Size = new Size(125, 27);
            txtMaDangTuyen.TabIndex = 2;
            // 
            // CapNhatHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(txtMaDangTuyen);
            Controls.Add(txtMaHoaDon);
            Controls.Add(txtGiatri);
            Controls.Add(Date_Update);
            Controls.Add(cBoxCachThuc);
            Controls.Add(cBoxHinhThuc);
            Controls.Add(lblCachthuc);
            Controls.Add(lblDate);
            Controls.Add(lblMaDangTuyen);
            Controls.Add(lblHinhthuc);
            Controls.Add(lblGiatri);
            Controls.Add(lblMaHoaDon);
            Controls.Add(Button_Update);
            Controls.Add(Button_Cancel);
            Controls.Add(lblCNHoaDon);
            Name = "CapNhatHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CapNhatHoaDon";
            Load += CapNhatHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCNHoaDon;
        private Button Button_Cancel;
        private Button Button_Update;
        private Label lblMaHoaDon;
        private Label lblGiatri;
        private Label lblHinhthuc;
        private Label lblMaDangTuyen;
        private Label lblDate;
        private Label lblCachthuc;
        private ComboBox cBoxHinhThuc;
        private ComboBox cBoxCachThuc;
        private DateTimePicker Date_Update;
        private TextBox txtGiatri;
        private TextBox txtMaHoaDon;
        private TextBox txtMaDangTuyen;
    }
}