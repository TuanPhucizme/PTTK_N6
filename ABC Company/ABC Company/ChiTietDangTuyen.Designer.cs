namespace WinFormsApp1
{
    partial class ChiTietDangTuyen
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
            label3 = new Label();
            position = new TextBox();
            description = new RichTextBox();
            update = new Button();
            register = new Button();
            label4 = new Label();
            cancel = new Button();
            label5 = new Label();
            company = new TextBox();
            delete = new Button();
            number = new TextBox();
            UploadDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Vi tri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "So luong";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 178);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Mo ta";
            // 
            // position
            // 
            position.Location = new Point(184, 41);
            position.Name = "position";
            position.Size = new Size(125, 27);
            position.TabIndex = 9;
            // 
            // description
            // 
            description.Location = new Point(184, 178);
            description.Name = "description";
            description.Size = new Size(287, 145);
            description.TabIndex = 16;
            description.Text = "";
            // 
            // update
            // 
            update.Location = new Point(377, 370);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 17;
            update.Text = "Cap nhat";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // register
            // 
            register.Location = new Point(184, 370);
            register.Name = "register";
            register.Size = new Size(166, 29);
            register.TabIndex = 18;
            register.Text = "Dang ky ung tuyen";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 124);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 20;
            label4.Text = "Ngay dang tuyen";
            // 
            // cancel
            // 
            cancel.Location = new Point(577, 370);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 21;
            cancel.Text = "Huy";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 41);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 22;
            label5.Text = "Cong ty";
            // 
            // company
            // 
            company.Location = new Point(577, 41);
            company.Name = "company";
            company.Size = new Size(125, 27);
            company.TabIndex = 23;
            // 
            // delete
            // 
            delete.Location = new Point(477, 370);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 27;
            delete.Text = "Xoa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // number
            // 
            number.Location = new Point(184, 81);
            number.Name = "number";
            number.Size = new Size(125, 27);
            number.TabIndex = 30;
            number.KeyPress += number_KeyPress;
            // 
            // UploadDate
            // 
            UploadDate.Location = new Point(184, 124);
            UploadDate.Name = "UploadDate";
            UploadDate.Size = new Size(125, 27);
            UploadDate.TabIndex = 31;
            // 
            // ChiTietDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UploadDate);
            Controls.Add(number);
            Controls.Add(delete);
            Controls.Add(company);
            Controls.Add(label5);
            Controls.Add(cancel);
            Controls.Add(label4);
            Controls.Add(register);
            Controls.Add(update);
            Controls.Add(description);
            Controls.Add(position);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChiTietDangTuyen";
            Text = "ChiTietDangTuyen";
            Load += ChiTietDangTuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox position;
        private RichTextBox description;
        private Button update;
        private Button register;
        private Label label4;
        private Button cancel;
        private Label label5;
        private TextBox company;
        private Button delete;
        private TextBox number;
        private TextBox UploadDate;
    }
}