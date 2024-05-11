namespace ABC_Company
{
    partial class DanhSachDN
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
            DSDN = new DataGridView();
            label1 = new Label();
            txtTukhoa = new TextBox();
            btnTimkiem = new Button();
            btnDangky = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DSDN).BeginInit();
            SuspendLayout();
            // 
            // DSDN
            // 
            DSDN.AllowUserToAddRows = false;
            DSDN.AllowUserToDeleteRows = false;
            DSDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DSDN.BackgroundColor = SystemColors.Control;
            DSDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DSDN.Dock = DockStyle.Bottom;
            DSDN.GridColor = SystemColors.ActiveCaptionText;
            DSDN.Location = new Point(0, 182);
            DSDN.Margin = new Padding(2);
            DSDN.Name = "DSDN";
            DSDN.ReadOnly = true;
            DSDN.RowHeadersWidth = 62;
            DSDN.RowTemplate.Height = 33;
            DSDN.Size = new Size(830, 272);
            DSDN.TabIndex = 0;
            DSDN.CellDoubleClick += DSDN_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 124);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Công Ty";
            // 
            // txtTukhoa
            // 
            txtTukhoa.Location = new Point(184, 121);
            txtTukhoa.Margin = new Padding(2);
            txtTukhoa.Name = "txtTukhoa";
            txtTukhoa.Size = new Size(343, 27);
            txtTukhoa.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(554, 121);
            btnTimkiem.Margin = new Padding(2);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(90, 27);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(690, 121);
            btnDangky.Margin = new Padding(2);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(90, 27);
            btnDangky.TabIndex = 5;
            btnDangky.Text = "Đăng Ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(242, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(355, 38);
            label2.TabIndex = 6;
            label2.Text = "Danh Sách Doanh Nghiệp";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // DanhSachDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 454);
            Controls.Add(label2);
            Controls.Add(btnDangky);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTukhoa);
            Controls.Add(label1);
            Controls.Add(DSDN);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "DanhSachDN";
            Text = "Danh sách Doanh Nghiệp";
            Load += UngVien_Load;
            ((System.ComponentModel.ISupportInitialize)DSDN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DSDN;
        private Label label1;
        private TextBox txtTukhoa;
        private Button btnTimkiem;
        private Button btnDangky;
        private Label label2;
    }
}