namespace PasswordManager
{
    partial class AbountForm
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
            this.ab_lbVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ab_lbVersion
            // 
            this.ab_lbVersion.AutoSize = true;
            this.ab_lbVersion.Location = new System.Drawing.Point(12, 9);
            this.ab_lbVersion.Name = "ab_lbVersion";
            this.ab_lbVersion.Size = new System.Drawing.Size(78, 12);
            this.ab_lbVersion.TabIndex = 0;
            this.ab_lbVersion.Text = "Version : 1.0";
            // 
            // AbountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 242);
            this.Controls.Add(this.ab_lbVersion);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AbountForm";
            this.Text = "Abount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ab_lbVersion;
    }
}