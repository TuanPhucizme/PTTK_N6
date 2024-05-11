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
            payment = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // candidate
            // 
            candidate.Location = new Point(129, 296);
            candidate.Name = "candidate";
            candidate.Size = new Size(100, 30);
            candidate.TabIndex = 0;
            candidate.Text = "Ung vien";
            candidate.UseVisualStyleBackColor = true;
            candidate.Click += candidate_Click;
            // 
            // company
            // 
            company.Location = new Point(235, 296);
            company.Name = "company";
            company.Size = new Size(130, 30);
            company.TabIndex = 1;
            company.Text = "Doanh nghiep";
            company.UseVisualStyleBackColor = true;
            company.Click += company_Click;
            // 
            // jobPost
            // 
            jobPost.Location = new Point(368, 296);
            jobPost.Name = "jobPost";
            jobPost.Size = new Size(100, 30);
            jobPost.TabIndex = 2;
            jobPost.Text = "Dang tuyen";
            jobPost.UseVisualStyleBackColor = true;
            jobPost.Click += jobPost_Click;
            // 
            // bill
            // 
            bill.Location = new Point(474, 296);
            bill.Name = "bill";
            bill.Size = new Size(100, 30);
            bill.TabIndex = 3;
            bill.Text = "Hoa don";
            bill.UseVisualStyleBackColor = true;
            bill.Click += bill_Click;
            // 
            // payment
            // 
            payment.Location = new Point(580, 296);
            payment.Name = "payment";
            payment.Size = new Size(100, 30);
            payment.TabIndex = 4;
            payment.Text = "Thanh toan";
            payment.UseVisualStyleBackColor = true;
            payment.Click += payment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(315, 39);
            label1.Name = "label1";
            label1.Size = new Size(153, 35);
            label1.TabIndex = 5;
            label1.Text = "Cong ty ABC";
            // 
            // Man_Hinh_Quan_Li
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(payment);
            Controls.Add(bill);
            Controls.Add(jobPost);
            Controls.Add(company);
            Controls.Add(candidate);
            Name = "Man_Hinh_Quan_Li";
            Text = "Man_Hinh_Quan_Li";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button candidate;
        private Button company;
        private Button jobPost;
        private Button bill;
        private Button payment;
        private Label label1;
    }
}