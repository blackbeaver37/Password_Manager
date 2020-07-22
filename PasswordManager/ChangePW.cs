using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            InitializeComponent();
        }

        private void tbCrtPw_TextChanged(object sender, EventArgs e)
        {
            if(tbCrtPw.Text == this.password)
            {
                lbWrongCrtPw.Text = "";
                lb2PW.Enabled = true;
                lb3PW.Enabled = true;
                tbNewPw.Enabled = true;
                tbNewPw.ReadOnly = false;
                tbChkPw.Enabled = true;
                tbChkPw.ReadOnly = false;
            }
            else
            {
                lbWrongCrtPw.Text = "Wrong Password !!";
                lb2PW.Enabled = false;
                lb3PW.Enabled = false;
                tbNewPw.Enabled = false;
                tbNewPw.ReadOnly = true;
                tbChkPw.Enabled = false;
                tbChkPw.ReadOnly = true;
            }
        }

        private void tbNewPw_TextChanged(object sender, EventArgs e)
        {
            tmpPw = tbNewPw.Text;
        }

        private void tbChkPw_TextChanged(object sender, EventArgs e)
        {
            if (tbChkPw.Text == tmpPw)
            {
                lbWrongChkPw.Text = "";
                btnChange.Enabled = true;
            }
            else
            {
                lbWrongChkPw.Text = "Wrong Password !!";
                btnChange.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            PwMgr.password = tmpPw;
            if(MessageBox.Show("Password is Changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Close();
            }
        }

        private void tbChkPw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnChange_Click(sender, e);
            }
        }
    }
}
