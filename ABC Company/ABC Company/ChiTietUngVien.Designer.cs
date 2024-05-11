namespace ABC_Company
{
    partial class ChiTietUngVien
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
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            txtMaUngVien = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtLoaiChungTu = new TextBox();
            label6 = new Label();
            txtTinhTrangNop = new TextBox();
            label7 = new Label();
            btnUpdate = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 30);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 0;
            label1.Text = "Thông tin chi tiết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(177, 115);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(150, 31);
            txtHoTen.TabIndex = 2;
            // 
            // txtMaUngVien
            // 
            txtMaUngVien.Location = new Point(486, 115);
            txtMaUngVien.Name = "txtMaUngVien";
            txtMaUngVien.Size = new Size(150, 31);
            txtMaUngVien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 121);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 3;
            label3.Text = "Mã ứng viên";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(177, 202);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(150, 31);
            txtDiaChi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 202);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(486, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 202);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // txtLoaiChungTu
            // 
            txtLoaiChungTu.Location = new Point(177, 285);
            txtLoaiChungTu.Name = "txtLoaiChungTu";
            txtLoaiChungTu.Size = new Size(150, 31);
            txtLoaiChungTu.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 288);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 9;
            label6.Text = "Bằng cấp";
            // 
            // txtTinhTrangNop
            // 
            txtTinhTrangNop.Location = new Point(486, 285);
            txtTinhTrangNop.Name = "txtTinhTrangNop";
            txtTinhTrangNop.Size = new Size(150, 31);
            txtTinhTrangNop.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 291);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 11;
            label7.Text = "Tình trạng nộp";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(468, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(624, 361);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ChiTietUngVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(txtTinhTrangNop);
            Controls.Add(label7);
            Controls.Add(txtLoaiChungTu);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtDiaChi);
            Controls.Add(label4);
            Controls.Add(txtMaUngVien);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChiTietUngVien";
            Text = "ChiTietUngVien";
            Load += ChiTietUngVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtMaUngVien;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtLoaiChungTu;
        private Label label6;
        private TextBox txtTinhTrangNop;
        private Label label7;
        private Button btnUpdate;
        private Button btnBack;
    }
}