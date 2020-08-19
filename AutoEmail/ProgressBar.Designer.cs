namespace AutoEmail
{
    partial class ProgressBar
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
            this.ProcessBar = new Sunny.UI.UIProcessBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ProcessBar
            // 
            this.ProcessBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ProcessBar.Location = new System.Drawing.Point(12, 12);
            this.ProcessBar.MinimumSize = new System.Drawing.Size(70, 23);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Size = new System.Drawing.Size(632, 52);
            this.ProcessBar.TabIndex = 0;
            this.ProcessBar.Text = "0.0%";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 76);
            this.Controls.Add(this.ProcessBar);
            this.Name = "ProgressBar";
            this.Text = "信件寄出中";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIProcessBar ProcessBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}