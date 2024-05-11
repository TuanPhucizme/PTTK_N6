namespace ABC_Company
{
    partial class DangKyDN
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
            cty1 = new Label();
            mathue = new Label();
            ngdd = new Label();
            dchi = new Label();
            emaikl = new Label();
            txtTenCty = new TextBox();
            txtNguoiDD = new TextBox();
            txtMaThue = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            btnThem = new Button();
            btnHuy = new Button();
            label2 = new Label();
            txtMaCty = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 28);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng Ký Doanh Nghiệp";
            // 
            // cty1
            // 
            cty1.AutoSize = true;
            cty1.Location = new Point(55, 143);
            cty1.Name = "cty1";
            cty1.Size = new Size(89, 20);
            cty1.TabIndex = 1;
            cty1.Text = "Tên Công Ty";
            // 
            // mathue
            // 
            mathue.AutoSize = true;
            mathue.Location = new Point(55, 191);
            mathue.Name = "mathue";
            mathue.Size = new Size(87, 20);
            mathue.TabIndex = 2;
            mathue.Text = "Mã Số Thuế";
            // 
            // ngdd
            // 
            ngdd.AutoSize = true;
            ngdd.Location = new Point(55, 246);
            ngdd.Name = "ngdd";
            ngdd.Size = new Size(113, 20);
            ngdd.TabIndex = 3;
            ngdd.Text = "Người Đại Diện";
            // 
            // dchi
            // 
            dchi.AutoSize = true;
            dchi.Location = new Point(55, 296);
            dchi.Name = "dchi";
            dchi.Size = new Size(57, 20);
            dchi.TabIndex = 4;
            dchi.Text = "Địa Chỉ";
            // 
            // emaikl
            // 
            emaikl.AutoSize = true;
            emaikl.Location = new Point(55, 352);
            emaikl.Name = "emaikl";
            emaikl.Size = new Size(46, 20);
            emaikl.TabIndex = 5;
            emaikl.Text = "Email";
            // 
            // txtTenCty
            // 
            txtTenCty.Location = new Point(189, 143);
            txtTenCty.Name = "txtTenCty";
            txtTenCty.Size = new Size(508, 27);
            txtTenCty.TabIndex = 6;
            // 
            // txtNguoiDD
            // 
            txtNguoiDD.Location = new Point(189, 243);
            txtNguoiDD.Name = "txtNguoiDD";
            txtNguoiDD.Size = new Size(508, 27);
            txtNguoiDD.TabIndex = 7;
            // 
            // txtMaThue
            // 
            txtMaThue.Location = new Point(189, 198);
            txtMaThue.Name = "txtMaThue";
            txtMaThue.Size = new Size(508, 27);
            txtMaThue.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(189, 296);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(508, 27);
            txtDiaChi.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 352);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(508, 27);
            txtEmail.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(270, 406);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(499, 406);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 90);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 13;
            label2.Text = "Mã Công Ty";
            // 
            // txtMaCty
            // 
            txtMaCty.Location = new Point(189, 87);
            txtMaCty.Name = "txtMaCty";
            txtMaCty.Size = new Size(508, 27);
            txtMaCty.TabIndex = 14;
            txtMaCty.TextChanged += textBox6_TextChanged;
            // 
            // DangKyDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(txtMaCty);
            Controls.Add(label2);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMaThue);
            Controls.Add(txtNguoiDD);
            Controls.Add(txtTenCty);
            Controls.Add(emaikl);
            Controls.Add(dchi);
            Controls.Add(ngdd);
            Controls.Add(mathue);
            Controls.Add(cty1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "DangKyDN";
            Text = "Đăng Ký Doanh Nghiệp";
            Load += DangKyDN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label cty1;
        private Label mathue;
        private Label ngdd;
        private Label dchi;
        private Label emaikl;
        private TextBox txtTenCty;
        private TextBox txtNguoiDD;
        private TextBox txtMaThue;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private Button btnThem;
        private Button btnHuy;
        private Label label2;
        private TextBox txtMaCty;
    }
}