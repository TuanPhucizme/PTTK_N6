namespace ABC_Company
{
    partial class UngTuyen
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
            ((System.ComponentModel.ISupportInitialize)dgvDt).BeginInit();
            SuspendLayout();
            // 
            // dgvDt
            // 
            dgvDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDt.Dock = DockStyle.Bottom;
            dgvDt.Location = new Point(0, 129);
            dgvDt.Name = "dgvDt";
            dgvDt.RowHeadersWidth = 62;
            dgvDt.RowTemplate.Height = 33;
            dgvDt.Size = new Size(800, 321);
            dgvDt.TabIndex = 0;
            // 
            // UngTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDt);
            Name = "UngTuyen";
            Text = "UngTuyen";
            Load += UngTuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDt;
    }
}