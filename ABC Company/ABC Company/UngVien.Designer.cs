namespace ABC_Company
{
    partial class UngVien
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
            dgvDt = new DataGridView();
            label1 = new Label();
            txtTukhoa = new TextBox();
            btnTimkiem = new Button();
            label2 = new Label();
            btnDangky = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDt).BeginInit();
            SuspendLayout();
            // 
            // dgvDt
            // 
            dgvDt.AllowUserToAddRows = false;
            dgvDt.AllowUserToDeleteRows = false;
            dgvDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDt.Dock = DockStyle.Bottom;
            dgvDt.Location = new Point(0, 146);
            dgvDt.Name = "dgvDt";
            dgvDt.ReadOnly = true;
            dgvDt.RowHeadersWidth = 62;
            dgvDt.RowTemplate.Height = 33;
            dgvDt.Size = new Size(1122, 304);
            dgvDt.TabIndex = 0;
            dgvDt.CellDoubleClick += dgvDt_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 56);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Từ khóa";
            // 
            // txtTukhoa
            // 
            txtTukhoa.Location = new Point(218, 56);
            txtTukhoa.Name = "txtTukhoa";
            txtTukhoa.Size = new Size(283, 31);
            txtTukhoa.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(520, 56);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(112, 34);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(666, 59);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 4;
            label2.Text = "Đăng ký ứng viên";
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(824, 54);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(112, 34);
            btnDangky.TabIndex = 5;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // UngVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 450);
            Controls.Add(btnDangky);
            Controls.Add(label2);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTukhoa);
            Controls.Add(label1);
            Controls.Add(dgvDt);
            Name = "UngVien";
            Text = "Danh sách ứng viên";
            Load += UngVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDt;
        private Label label1;
        private TextBox txtTukhoa;
        private Button btnTimkiem;
        private Label label2;
        private Button btnDangky;
    }
}