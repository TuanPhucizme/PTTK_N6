namespace ABC_Company
{
    partial class Man_Hinh_Quan_Li
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
            candidate = new Button();
            company = new Button();
            jobPost = new Button();
            bill = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // candidate
            // 
            candidate.Location = new Point(420, 199);
            candidate.Name = "candidate";
            candidate.Size = new Size(130, 30);
            candidate.TabIndex = 0;
            candidate.Text = "Ung vien";
            candidate.UseVisualStyleBackColor = true;
            candidate.Click += candidate_Click;
            // 
            // company
            // 
            company.Location = new Point(74, 199);
            company.Name = "company";
            company.Size = new Size(130, 30);
            company.TabIndex = 1;
            company.Text = "Doanh nghiep";
            company.UseVisualStyleBackColor = true;
            company.Click += company_Click;
            // 
            // jobPost
            // 
            jobPost.Location = new Point(245, 199);
            jobPost.Name = "jobPost";
            jobPost.Size = new Size(130, 30);
            jobPost.TabIndex = 2;
            jobPost.Text = "Dang tuyen";
            jobPost.UseVisualStyleBackColor = true;
            jobPost.Click += jobPost_Click;
            // 
            // bill
            // 
            bill.Location = new Point(595, 199);
            bill.Name = "bill";
            bill.Size = new Size(130, 30);
            bill.TabIndex = 3;
            bill.Text = "Hoa don";
            bill.UseVisualStyleBackColor = true;
            bill.Click += bill_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 85);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 5;
            label1.Text = "Công Ty ABC";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Man_Hinh_Quan_Li
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 391);
            Controls.Add(label1);
            Controls.Add(bill);
            Controls.Add(jobPost);
            Controls.Add(company);
            Controls.Add(candidate);
            Name = "Man_Hinh_Quan_Li";
            Text = "Màn Hình Chính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button candidate;
        private Button company;
        private Button jobPost;
        private Button bill;
        private Label label1;
    }
}