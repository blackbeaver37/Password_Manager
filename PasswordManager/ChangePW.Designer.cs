namespace PasswordManager
{
    partial class ChangePW
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
            this.lb1PW = new System.Windows.Forms.Label();
            this.lb2PW = new System.Windows.Forms.Label();
            this.lb3PW = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbWrongChkPw = new System.Windows.Forms.Label();
            this.lbWrongCrtPw = new System.Windows.Forms.Label();
            this.tbChkPw = new System.Windows.Forms.TextBox();
            this.tbNewPw = new System.Windows.Forms.TextBox();
            this.tbCrtPw = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1PW
            // 
            this.lb1PW.AutoSize = true;
            this.lb1PW.Location = new System.Drawing.Point(16, 16);
            this.lb1PW.Name = "lb1PW";
            this.lb1PW.Size = new System.Drawing.Size(112, 12);
            this.lb1PW.TabIndex = 0;
            this.lb1PW.Text = "Current Password";
            // 
            // lb2PW
            // 
            this.lb2PW.AutoSize = true;
            this.lb2PW.Enabled = false;
            this.lb2PW.Location = new System.Drawing.Point(24, 57);
            this.lb2PW.Name = "lb2PW";
            this.lb2PW.Size = new System.Drawing.Size(95, 12);
            this.lb2PW.TabIndex = 1;
            this.lb2PW.Text = "New Password";
            // 
            // lb3PW
            // 
            this.lb3PW.AutoSize = true;
            this.lb3PW.Enabled = false;
            this.lb3PW.Location = new System.Drawing.Point(19, 87);
            this.lb3PW.Name = "lb3PW";
            this.lb3PW.Size = new System.Drawing.Size(105, 12);
            this.lb3PW.TabIndex = 2;
            this.lb3PW.Text = "Check Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.lbWrongChkPw);
            this.panel1.Controls.Add(this.lbWrongCrtPw);
            this.panel1.Controls.Add(this.tbChkPw);
            this.panel1.Controls.Add(this.tbNewPw);
            this.panel1.Controls.Add(this.tbCrtPw);
            this.panel1.Controls.Add(this.lb1PW);
            this.panel1.Controls.Add(this.lb3PW);
            this.panel1.Controls.Add(this.lb2PW);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 195);
            this.panel1.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(18, 138);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(229, 40);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbWrongChkPw
            // 
            this.lbWrongChkPw.AutoSize = true;
            this.lbWrongChkPw.ForeColor = System.Drawing.Color.Red;
            this.lbWrongChkPw.Location = new System.Drawing.Point(147, 106);
            this.lbWrongChkPw.Name = "lbWrongChkPw";
            this.lbWrongChkPw.Size = new System.Drawing.Size(0, 12);
            this.lbWrongChkPw.TabIndex = 7;
            // 
            // lbWrongCrtPw
            // 
            this.lbWrongCrtPw.AutoSize = true;
            this.lbWrongCrtPw.ForeColor = System.Drawing.Color.Red;
            this.lbWrongCrtPw.Location = new System.Drawing.Point(147, 36);
            this.lbWrongCrtPw.Name = "lbWrongCrtPw";
            this.lbWrongCrtPw.Size = new System.Drawing.Size(0, 12);
            this.lbWrongCrtPw.TabIndex = 6;
            // 
            // tbChkPw
            // 
            this.tbChkPw.Enabled = false;
            this.tbChkPw.Location = new System.Drawing.Point(147, 84);
            this.tbChkPw.Name = "tbChkPw";
            this.tbChkPw.PasswordChar = '*';
            this.tbChkPw.ReadOnly = true;
            this.tbChkPw.Size = new System.Drawing.Size(100, 19);
            this.tbChkPw.TabIndex = 5;
            this.tbChkPw.TextChanged += new System.EventHandler(this.tbChkPw_TextChanged);
            this.tbChkPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChkPw_KeyDown);
            // 
            // tbNewPw
            // 
            this.tbNewPw.Enabled = false;
            this.tbNewPw.Location = new System.Drawing.Point(147, 54);
            this.tbNewPw.Name = "tbNewPw";
            this.tbNewPw.PasswordChar = '*';
            this.tbNewPw.ReadOnly = true;
            this.tbNewPw.Size = new System.Drawing.Size(100, 19);
            this.tbNewPw.TabIndex = 4;
            this.tbNewPw.TextChanged += new System.EventHandler(this.tbNewPw_TextChanged);
            // 
            // tbCrtPw
            // 
            this.tbCrtPw.Location = new System.Drawing.Point(147, 13);
            this.tbCrtPw.Name = "tbCrtPw";
            this.tbCrtPw.PasswordChar = '*';
            this.tbCrtPw.Size = new System.Drawing.Size(100, 19);
            this.tbCrtPw.TabIndex = 3;
            this.tbCrtPw.TextChanged += new System.EventHandler(this.tbCrtPw_TextChanged);
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 220);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChangePW";
            this.Text = "Change Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            this.password = PwMgr.password;

        }

        #endregion

        private string password;
        private string tmpPw;

        private System.Windows.Forms.Label lb1PW;
        private System.Windows.Forms.Label lb2PW;
        private System.Windows.Forms.Label lb3PW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWrongChkPw;
        private System.Windows.Forms.Label lbWrongCrtPw;
        private System.Windows.Forms.TextBox tbChkPw;
        private System.Windows.Forms.TextBox tbNewPw;
        private System.Windows.Forms.TextBox tbCrtPw;
        private System.Windows.Forms.Button btnChange;
    }
}