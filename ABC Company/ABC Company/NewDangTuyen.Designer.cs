namespace ABC_Company
{
    partial class NewDangTuyen
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
            companyCode = new TextBox();
            label6 = new Label();
            UploadDate = new TextBox();
            cancel = new Button();
            label4 = new Label();
            add = new Button();
            description = new RichTextBox();
            number = new TextBox();
            position = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // companyCode
            // 
            companyCode.Location = new Point(592, 46);
            companyCode.Name = "companyCode";
            companyCode.Size = new Size(125, 27);
            companyCode.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 49);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 41;
            label6.Text = "Ma cong ty";
            // 
            // UploadDate
            // 
            UploadDate.Location = new Point(205, 129);
            UploadDate.Name = "UploadDate";
            UploadDate.Size = new Size(125, 27);
            UploadDate.TabIndex = 40;
            // 
            // cancel
            // 
            cancel.Location = new Point(398, 375);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 37;
            cancel.Text = "Huy";
            cancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 129);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 36;
            label4.Text = "Ngay dang tuyen";
            // 
            // add
            // 
            add.Location = new Point(205, 375);
            add.Name = "add";
            add.Size = new Size(125, 29);
            add.TabIndex = 35;
            add.Text = "Them moi";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // description
            // 
            description.Location = new Point(205, 183);
            description.Name = "description";
            description.Size = new Size(287, 145);
            description.TabIndex = 33;
            description.Text = "";
            // 
            // number
            // 
            number.Location = new Point(205, 86);
            number.Name = "number";
            number.Size = new Size(125, 27);
            number.TabIndex = 32;
            // 
            // position
            // 
            position.Location = new Point(205, 46);
            position.Name = "position";
            position.Size = new Size(125, 27);
            position.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 183);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 30;
            label3.Text = "Mo ta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 86);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 29;
            label2.Text = "So luong";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 28;
            label1.Text = "Vi tri";
            // 
            // NewDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(companyCode);
            Controls.Add(label6);
            Controls.Add(UploadDate);
            Controls.Add(cancel);
            Controls.Add(label4);
            Controls.Add(add);
            Controls.Add(description);
            Controls.Add(number);
            Controls.Add(position);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewDangTuyen";
            Text = "Tao Dang Tuyen";
            Load += NewDangTuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox companyCode;
        private Label label6;
        private TextBox UploadDate;
        private Button cancel;
        private Label label4;
        private Button add;
        private RichTextBox description;
        private TextBox number;
        private TextBox position;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}