namespace ABC_Company
{
    partial class DangKyUngTuyen
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
            register = new Button();
            cancel = new Button();
            detail = new TextBox();
            paper = new TextBox();
            applier = new TextBox();
            name = new TextBox();
            applierName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 83);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Ma chi tiet dang tuyen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 127);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Ma ho so";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 173);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Ma ung vien";
            // 
            // register
            // 
            register.Location = new Point(223, 304);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 3;
            register.Text = "Ung tuyen";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(447, 304);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 4;
            cancel.Text = "Huy";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // detail
            // 
            detail.Location = new Point(416, 83);
            detail.Name = "detail";
            detail.ReadOnly = true;
            detail.Size = new Size(125, 27);
            detail.TabIndex = 5;
            // 
            // paper
            // 
            paper.Location = new Point(416, 124);
            paper.Name = "paper";
            paper.Size = new Size(125, 27);
            paper.TabIndex = 6;
            // 
            // applier
            // 
            applier.Location = new Point(416, 166);
            applier.Name = "applier";
            applier.Size = new Size(125, 27);
            applier.TabIndex = 7;
            applier.TextChanged += applier_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(416, 209);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(201, 27);
            name.TabIndex = 8;
            // 
            // applierName
            // 
            applierName.AutoSize = true;
            applierName.Location = new Point(223, 216);
            applierName.Name = "applierName";
            applierName.Size = new Size(92, 20);
            applierName.TabIndex = 9;
            applierName.Text = "Ten ung vien";
            // 
            // DangKyUngTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(applierName);
            Controls.Add(name);
            Controls.Add(applier);
            Controls.Add(paper);
            Controls.Add(detail);
            Controls.Add(cancel);
            Controls.Add(register);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangKyUngTuyen";
            Text = "DangKyUngTuyen";
            Load += DangKyUngTuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button register;
        private Button cancel;
        private TextBox detail;
        private TextBox paper;
        private TextBox applier;
        private TextBox name;
        private Label applierName;
    }
}