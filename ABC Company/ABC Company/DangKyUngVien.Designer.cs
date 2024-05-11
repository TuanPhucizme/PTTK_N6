namespace ABC_Company
{
    partial class DangKyUngVien
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
            txt1 = new Label();
            txtTen = new TextBox();
            txtDc = new TextBox();
            lb1 = new Label();
            txtE = new TextBox();
            lb2 = new Label();
            txtCccd = new TextBox();
            lb4 = new Label();
            btnAdd = new Button();
            label3 = new Label();
            txtDate = new TextBox();
            label2 = new Label();
            txtMuv = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 34);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 0;
            label1.Text = "Điền thông tin";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Location = new Point(397, 94);
            txt1.Name = "txt1";
            txt1.Size = new Size(66, 25);
            txt1.TabIndex = 1;
            txt1.Text = "Họ tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(482, 94);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(202, 31);
            txtTen.TabIndex = 2;
            // 
            // txtDc
            // 
            txtDc.Location = new Point(128, 160);
            txtDc.Name = "txtDc";
            txtDc.Size = new Size(202, 31);
            txtDc.TabIndex = 4;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(43, 163);
            lb1.Name = "lb1";
            lb1.Size = new Size(65, 25);
            lb1.TabIndex = 3;
            lb1.Text = "Địa chỉ";
            // 
            // txtE
            // 
            txtE.Location = new Point(482, 157);
            txtE.Name = "txtE";
            txtE.Size = new Size(202, 31);
            txtE.TabIndex = 6;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(397, 160);
            lb2.Name = "lb2";
            lb2.Size = new Size(54, 25);
            lb2.TabIndex = 5;
            lb2.Text = "Email";
            // 
            // txtCccd
            // 
            txtCccd.Location = new Point(482, 238);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(202, 31);
            txtCccd.TabIndex = 10;
            // 
            // lb4
            // 
            lb4.AutoSize = true;
            lb4.Location = new Point(397, 241);
            lb4.Name = "lb4";
            lb4.Size = new Size(58, 25);
            lb4.TabIndex = 9;
            lb4.Text = "CCCD";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(313, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 238);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 14;
            label3.Text = "Ngày sinh";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(128, 232);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(202, 31);
            txtDate.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 100);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 16;
            label2.Text = "Mã ứng viên";
            // 
            // txtMuv
            // 
            txtMuv.Location = new Point(128, 94);
            txtMuv.Name = "txtMuv";
            txtMuv.Size = new Size(202, 31);
            txtMuv.TabIndex = 17;
            // 
            // DangKyUngVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMuv);
            Controls.Add(label2);
            Controls.Add(txtDate);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(txtCccd);
            Controls.Add(lb4);
            Controls.Add(txtE);
            Controls.Add(lb2);
            Controls.Add(txtDc);
            Controls.Add(lb1);
            Controls.Add(txtTen);
            Controls.Add(txt1);
            Controls.Add(label1);
            Name = "DangKyUngVien";
            Text = "DangKyUngVien";
            Load += DangKyUngVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txt1;
        private TextBox txtTen;
        private TextBox txtDc;
        private Label lb1;
        private TextBox txtE;
        private Label lb2;
        private TextBox txtCccd;
        private Label lb4;
        private Button btnAdd;
        private Label label3;
        private TextBox txtDate;
        private Label label2;
        private TextBox txtMuv;
    }
}