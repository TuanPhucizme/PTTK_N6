namespace ABC_Company
{
    partial class ChiTietDN
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
            txtMaCTy = new TextBox();
            label2 = new Label();
            btnUpt = new Button();
            btnBack = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDiaChi = new TextBox();
            txtNgDD = new TextBox();
            txtMaThue = new TextBox();
            txtEmail = new TextBox();
            txtTenCty = new TextBox();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(219, 34);
            label1.Name = "label1";
            label1.Size = new Size(338, 37);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Doanh Nghiệp";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtMaCTy
            // 
            txtMaCTy.Location = new Point(219, 111);
            txtMaCTy.Name = "txtMaCTy";
            txtMaCTy.Size = new Size(338, 27);
            txtMaCTy.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 111);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã Công Ty";
            // 
            // btnUpt
            // 
            btnUpt.Location = new Point(645, 169);
            btnUpt.Name = "btnUpt";
            btnUpt.Size = new Size(94, 29);
            btnUpt.TabIndex = 3;
            btnUpt.Text = "Cập Nhật";
            btnUpt.UseVisualStyleBackColor = true;
            btnUpt.Click += btnUpt_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(645, 288);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 331);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 274);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 6;
            label4.Text = "Người Đại Diện";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 221);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 7;
            label5.Text = "Mã Số Thuế";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 162);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 8;
            label6.Text = "Tên Công Ty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 384);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 9;
            label7.Text = "Email";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(219, 335);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(338, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // txtNgDD
            // 
            txtNgDD.Location = new Point(219, 278);
            txtNgDD.Name = "txtNgDD";
            txtNgDD.Size = new Size(338, 27);
            txtNgDD.TabIndex = 11;
            txtNgDD.TextChanged += textBox3_TextChanged;
            // 
            // txtMaThue
            // 
            txtMaThue.Location = new Point(219, 228);
            txtMaThue.Name = "txtMaThue";
            txtMaThue.Size = new Size(338, 27);
            txtMaThue.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 391);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtTenCty
            // 
            txtTenCty.Location = new Point(219, 169);
            txtTenCty.Name = "txtTenCty";
            txtTenCty.Size = new Size(338, 27);
            txtTenCty.TabIndex = 14;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(645, 228);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // ChiTietDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(btnXoa);
            Controls.Add(txtTenCty);
            Controls.Add(txtEmail);
            Controls.Add(txtMaThue);
            Controls.Add(txtNgDD);
            Controls.Add(txtDiaChi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnUpt);
            Controls.Add(label2);
            Controls.Add(txtMaCTy);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "ChiTietDN";
            Text = "ChiTietDN";
            Load += ChiTietDN_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaCTy;
        private Label label2;
        private Button btnUpt;
        private Button btnBack;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDiaChi;
        private TextBox txtNgDD;
        private TextBox txtMaThue;
        private TextBox txtEmail;
        private TextBox txtTenCty;
        private Button btnXoa;
    }
}