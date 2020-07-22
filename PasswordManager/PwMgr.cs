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
    public partial class PwMgr : Form
    {
        public PwMgr()
        {
            InitializeComponent();
            loadPW();
        }

        // Login 버튼
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == password)
            {
                enableProc();
                loadData();
                initCbSite();
            }

            else
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLogin.Clear();
            }
        }

        // 콤보박스 가운데 정렬 DrawItem 적용X
        private void comboBox_commute_option_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                // Always draw the background
                e.DrawBackground();
                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);
                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;
                    // Draw the string
                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        // 사이트 콤보박스 변경
        private void cbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = keys.IndexOf(cbSite.Text);

            tbID.Text = datas[index].id;
            tbPW.Text = datas[index].pw;
        }

        // Edit 버튼
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbSite.Text != "")
            {
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnEditOK.Enabled = true;
                btnEditCancel.Enabled = true;

                cbSite.DropDownStyle = ComboBoxStyle.Simple;
                tbID.ReadOnly = false;
                tbPW.ReadOnly = false;
            }
        }

        // Edit - OK 버튼
        private void btnEditOK_Click(object sender, EventArgs e)
        {
            data tmpdata = new data();
            tmpdata.site = cbSite.Text;
            tmpdata.id = tbID.Text;
            tmpdata.pw = tbPW.Text;

            if (tmpdata.site != "" && tmpdata.id != "" && tmpdata.pw != "")
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnEditOK.Enabled = false;
                btnEditCancel.Enabled = false;

                datas[index] = tmpdata;
                keys[index] = cbSite.Text;

                cbSite.DropDownStyle = ComboBoxStyle.DropDownList;
                initCbSite();
                cbSite.Text = datas[index].site;
                tbID.ReadOnly = true;
                tbPW.ReadOnly = true;

                saveFile();
            }
            else
            {
                MessageBox.Show("Input Correct Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Edit - Cancel 버튼
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEditOK.Enabled = false;
            btnEditCancel.Enabled = false;

            cbSite.DropDownStyle = ComboBoxStyle.DropDownList;
            tbID.ReadOnly = true;
            tbPW.ReadOnly = true;

            cbSite.Text = datas[index].site;
            tbID.Text = datas[index].id;
            tbPW.Text = datas[index].pw;
        }

        // Add 버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnAddOK.Enabled = true;
            btnAddCancel.Enabled = true;

            cbSite.DropDownStyle = ComboBoxStyle.Simple;
            cbSite.Text = "";
            tbID.ReadOnly = false;
            tbID.Text = "";
            tbPW.ReadOnly = false;
            tbPW.Text = "";
        }

        // Add - OK 버튼
        private void btnAddOK_Click(object sender, EventArgs e)
        {
            data tmpdata = new data();
            tmpdata.site = cbSite.Text;
            tmpdata.id = tbID.Text;
            tmpdata.pw = tbPW.Text;

            if (tmpdata.site != "" && tmpdata.id != "" && tmpdata.pw != "")
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnAddOK.Enabled = false;
                btnAddCancel.Enabled = false;

                datas.Add(tmpdata);
                keys.Add(tmpdata.site);
                index = keys.Count - 1;

                cbSite.DropDownStyle = ComboBoxStyle.DropDownList;
                initCbSite();
                cbSite.Text = datas[index].site;
                tbID.ReadOnly = true;
                tbPW.ReadOnly = true;

                saveFile();
            }
            else
            {
                MessageBox.Show("Input Correct Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add - Cancel 버튼
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnAddOK.Enabled = false;
            btnAddCancel.Enabled = false;

            cbSite.DropDownStyle = ComboBoxStyle.DropDownList;
            tbID.ReadOnly = true;
            tbPW.ReadOnly = true;

            cbSite.Text = datas[index].site;
            tbID.Text = datas[index].id;
            tbPW.Text = datas[index].pw;
        }

        // Delete 버튼
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cbSite.Text != "")
            {
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnDelOK.Enabled = true;
                btnDelCancel.Enabled = true;

                cbSite.Enabled = false;
            }
        }

        // Delete - OK 버튼
        private void btnDelOK_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnDelOK.Enabled = false;
            btnDelCancel.Enabled = false;

            datas.RemoveAt(index);
            keys.RemoveAt(index);
            initCbSite();
            tbID.Text = "";
            tbPW.Text = "";

            cbSite.Enabled = true;

            saveFile();
        }

        // Delete - Cancel 버튼
        private void btnDelCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnDelOK.Enabled = false;
            btnDelCancel.Enabled = false;

            cbSite.Enabled = true;
        }

        // password 입력 후 엔터
        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        // password 입력 후 엔터 또는 ESC
        private void data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnEditOK.Enabled) btnEditOK_Click(sender, e);
                else if (btnAddOK.Enabled) btnAddOK_Click(sender, e);
                else if (btnDelOK.Enabled) btnDelOK_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (btnEditOK.Enabled) btnEditCancel_Click(sender, e);
                else if (btnAddOK.Enabled) btnAddCancel_Click(sender, e);
                else if (btnDelOK.Enabled) btnDelCancel_Click(sender, e);
            }
        }

        // Edit, Add, Del 단축키
        private void PwMgr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E) btnEdit_Click(sender, e);
            else if (e.KeyCode == Keys.A) btnAdd_Click(sender, e);
            else if (e.KeyCode == Keys.D) btnDel_Click(sender, e);

        }

        // 툴바 About 메뉴
        private void tbtnAbout_Click(object sender, EventArgs e)
        {
            AbountForm abountForm = new AbountForm();
            abountForm.Show();
        }

        private void tbtnChangePW_Click(object sender, EventArgs e)
        {
            ChangePW changePW = new ChangePW();
            changePW.Show();
        }
    }
}