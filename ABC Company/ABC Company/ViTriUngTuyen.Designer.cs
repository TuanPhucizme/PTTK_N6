namespace ABC_Company
{
    partial class ViTriUngTuyen
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
            radioI = new RadioButton();
            radioJ = new RadioButton();
            radioF = new RadioButton();
            radioS = new RadioButton();
            btnU = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 33);
            label1.Name = "label1";
            label1.Size = new Size(255, 45);
            label1.TabIndex = 0;
            label1.Text = "Vị trí ứng tuyển";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 149);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 1;
            label2.Text = "Chọn vị trí ứng tuyển:";
            // 
            // radioI
            // 
            radioI.AutoSize = true;
            radioI.Location = new Point(309, 149);
            radioI.Name = "radioI";
            radioI.Size = new Size(83, 29);
            radioI.TabIndex = 2;
            radioI.TabStop = true;
            radioI.Text = "Intern";
            radioI.UseVisualStyleBackColor = true;
            // 
            // radioJ
            // 
            radioJ.AutoSize = true;
            radioJ.Location = new Point(309, 246);
            radioJ.Name = "radioJ";
            radioJ.Size = new Size(84, 29);
            radioJ.TabIndex = 3;
            radioJ.TabStop = true;
            radioJ.Text = "Junior";
            radioJ.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(499, 149);
            radioF.Name = "radioF";
            radioF.Size = new Size(94, 29);
            radioF.TabIndex = 4;
            radioF.TabStop = true;
            radioF.Text = "Fresher";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioS
            // 
            radioS.AutoSize = true;
            radioS.Location = new Point(499, 246);
            radioS.Name = "radioS";
            radioS.Size = new Size(87, 29);
            radioS.TabIndex = 5;
            radioS.TabStop = true;
            radioS.Text = "Senior";
            radioS.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            btnU.Location = new Point(322, 355);
            btnU.Name = "btnU";
            btnU.Size = new Size(112, 34);
            btnU.TabIndex = 6;
            btnU.Text = "Cập nhật";
            btnU.UseVisualStyleBackColor = true;
            btnU.Click += btnU_Click;
            // 
            // ViTriUngTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnU);
            Controls.Add(radioS);
            Controls.Add(radioF);
            Controls.Add(radioJ);
            Controls.Add(radioI);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViTriUngTuyen";
            Text = "ViTriUngTuyen";
            Load += ViTriUngTuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioI;
        private RadioButton radioJ;
        private RadioButton radioF;
        private RadioButton radioS;
        private Button btnU;
    }
}