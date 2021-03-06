using System.Collections.Generic;
using System.IO;

namespace PasswordManager
{
    partial class PwMgr
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwMgr));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnDelOK = new System.Windows.Forms.Button();
            this.btnAddOK = new System.Windows.Forms.Button();
            this.btnEditOK = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbPW = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.lbSite = new System.Windows.Forms.Label();
            this.toolStripBar = new System.Windows.Forms.ToolStrip();
            this.tbtnAccount = new System.Windows.Forms.ToolStripSplitButton();
            this.tbtnChangePW = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbtnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.toolStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(149, 28);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 34);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(25, 12);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "PW";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(43, 30);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '*';
            this.tbLogin.Size = new System.Drawing.Size(100, 19);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelCancel);
            this.groupBox1.Controls.Add(this.btnAddCancel);
            this.groupBox1.Controls.Add(this.btnEditCancel);
            this.groupBox1.Controls.Add(this.btnDelOK);
            this.groupBox1.Controls.Add(this.btnAddOK);
            this.groupBox1.Controls.Add(this.btnEditOK);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.tbPW);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.lbPW);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.cbSite);
            this.groupBox1.Controls.Add(this.lbSite);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnDelCancel
            // 
            this.btnDelCancel.Enabled = false;
            this.btnDelCancel.Location = new System.Drawing.Point(140, 283);
            this.btnDelCancel.Name = "btnDelCancel";
            this.btnDelCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDelCancel.TabIndex = 7;
            this.btnDelCancel.Text = "Cancel";
            this.btnDelCancel.UseVisualStyleBackColor = true;
            this.btnDelCancel.Click += new System.EventHandler(this.btnDelCancel_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Enabled = false;
            this.btnAddCancel.Location = new System.Drawing.Point(140, 216);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 7;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Enabled = false;
            this.btnEditCancel.Location = new System.Drawing.Point(140, 149);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 7;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnDelOK
            // 
            this.btnDelOK.Enabled = false;
            this.btnDelOK.Location = new System.Drawing.Point(140, 254);
            this.btnDelOK.Name = "btnDelOK";
            this.btnDelOK.Size = new System.Drawing.Size(75, 23);
            this.btnDelOK.TabIndex = 6;
            this.btnDelOK.Text = "OK";
            this.btnDelOK.UseVisualStyleBackColor = true;
            this.btnDelOK.Click += new System.EventHandler(this.btnDelOK_Click);
            // 
            // btnAddOK
            // 
            this.btnAddOK.Enabled = false;
            this.btnAddOK.Location = new System.Drawing.Point(140, 187);
            this.btnAddOK.Name = "btnAddOK";
            this.btnAddOK.Size = new System.Drawing.Size(75, 23);
            this.btnAddOK.TabIndex = 6;
            this.btnAddOK.Text = "OK";
            this.btnAddOK.UseVisualStyleBackColor = true;
            this.btnAddOK.Click += new System.EventHandler(this.btnAddOK_Click);
            // 
            // btnEditOK
            // 
            this.btnEditOK.Enabled = false;
            this.btnEditOK.Location = new System.Drawing.Point(140, 120);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(75, 23);
            this.btnEditOK.TabIndex = 6;
            this.btnEditOK.Text = "OK";
            this.btnEditOK.UseVisualStyleBackColor = true;
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(8, 254);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 52);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(8, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 52);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(8, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 52);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbPW
            // 
            this.tbPW.Enabled = false;
            this.tbPW.Location = new System.Drawing.Point(41, 77);
            this.tbPW.Name = "tbPW";
            this.tbPW.ReadOnly = true;
            this.tbPW.Size = new System.Drawing.Size(174, 19);
            this.tbPW.TabIndex = 4;
            this.tbPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_KeyDown);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(41, 48);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(174, 19);
            this.tbID.TabIndex = 3;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_KeyDown);
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Enabled = false;
            this.lbPW.Location = new System.Drawing.Point(6, 82);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(25, 12);
            this.lbPW.TabIndex = 2;
            this.lbPW.Text = "PW";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(6, 53);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 12);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID";
            // 
            // cbSite
            // 
            this.cbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSite.Enabled = false;
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(41, 18);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(174, 20);
            this.cbSite.Sorted = true;
            this.cbSite.TabIndex = 1;
            this.cbSite.SelectedIndexChanged += new System.EventHandler(this.cbSite_SelectedIndexChanged);
            this.cbSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_KeyDown);
            // 
            // lbSite
            // 
            this.lbSite.AutoSize = true;
            this.lbSite.Enabled = false;
            this.lbSite.Location = new System.Drawing.Point(6, 23);
            this.lbSite.Name = "lbSite";
            this.lbSite.Size = new System.Drawing.Size(29, 12);
            this.lbSite.TabIndex = 0;
            this.lbSite.Text = "Site";
            // 
            // toolStripBar
            // 
            this.toolStripBar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAccount,
            this.tbtnHelp});
            this.toolStripBar.Location = new System.Drawing.Point(0, 0);
            this.toolStripBar.Name = "toolStripBar";
            this.toolStripBar.Size = new System.Drawing.Size(250, 25);
            this.toolStripBar.TabIndex = 5;
            // 
            // tbtnAccount
            // 
            this.tbtnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnChangePW});
            this.tbtnAccount.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAccount.Image")));
            this.tbtnAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAccount.Name = "tbtnAccount";
            this.tbtnAccount.Size = new System.Drawing.Size(71, 22);
            this.tbtnAccount.Text = "Account";
            // 
            // tbtnChangePW
            // 
            this.tbtnChangePW.Name = "tbtnChangePW";
            this.tbtnChangePW.Size = new System.Drawing.Size(180, 22);
            this.tbtnChangePW.Text = "Change Password";
            this.tbtnChangePW.Click += new System.EventHandler(this.tbtnChangePW_Click);
            // 
            // tbtnHelp
            // 
            this.tbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAbout});
            this.tbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tbtnHelp.Image")));
            this.tbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHelp.Name = "tbtnHelp";
            this.tbtnHelp.Size = new System.Drawing.Size(44, 22);
            this.tbtnHelp.Text = "Help";
            this.tbtnHelp.ToolTipText = "Help";
            // 
            // tbtnAbout
            // 
            this.tbtnAbout.Name = "tbtnAbout";
            this.tbtnAbout.Size = new System.Drawing.Size(106, 22);
            this.tbtnAbout.Text = "About";
            this.tbtnAbout.Click += new System.EventHandler(this.tbtnAbout_Click);
            // 
            // PwMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 382);
            this.Controls.Add(this.toolStripBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PwMgr";
            this.Text = "Password Manager";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PwMgr_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripBar.ResumeLayout(false);
            this.toolStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 데이터 파일로 부터 데이터 로드
        private void loadData()
        {
            StreamReader file = new StreamReader(DATA_PATH);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] tmpStr = line.Split(new string[] { "\t" }, 0);
                data tmpData = new data();
                tmpData.site = tmpStr[0];
                tmpData.id = tmpStr[1];
                tmpData.pw = tmpStr[2];
                datas.Add(tmpData);
                keys.Add(tmpData.site);
            }
            file.Close();
        }

        // 사이트 콤보박스 새로고침
        private void initCbSite()
        {
            cbSite.Items.Clear();
            for (int i = 0; i < datas.Count; i++)
            {
                cbSite.Items.Add(datas[i].site);
            }
        }

        // 로그인 완료 시 프로그램 활성화
        private void enableProc()
        {
            // 버튼 활성화
            lbLogin.Enabled = false;
            tbLogin.Enabled = false;
            btnLogin.Enabled = false;
            lbSite.Enabled = true;
            cbSite.Enabled = true;
            lbID.Enabled = true;
            tbID.Enabled = true;
            lbPW.Enabled = true;
            tbPW.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;

            // 링크된 데이터 표시
            initCbSite();
        }

        // 데이터 파일 저장
        private void saveFile()
        {
            StreamWriter file = new StreamWriter(DATA_PATH);
            for (int i = 0; i < keys.Count; i++)
            {
                string tmp = datas[i].site;
                tmp += "\t";
                tmp += datas[i].id;
                tmp += "\t";
                tmp += datas[i].pw;
                if (i == 0)
                {
                    tmp += "\t";
                    tmp += password;
                }

                file.WriteLine(tmp);
            }

            file.Close();
        }

        private void loadPW()
        {
            string path = DATA_PATH;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line = file.ReadLine();
                if(line == null)
                {
                    file.Close();
                    password = "password";
                    return;
                }
                string[] tmpStr = line.Split(new string[] { "\t" }, 0);
                password = tmpStr[3];
                file.Close();
            }
            else
            {
                StreamWriter file = File.CreateText(path);
                file.Close();
                password = "password";
            }
        }

        // 데이터 저장용 구조체
        public struct data
        {
            public data(string str)
            {
                site = "";
                id = "";
                pw = "";
            }

            public string site;
            public string id;
            public string pw;
        }


        // 파일 경로
        private string DATA_PATH = "C:\\ProgramData\\PasswordManager\\data.txt";
        /*// 더미 문자
        private string SPLIT_STRING = "ainivjfdi";
        private string DUMMY_1 = "ifn6AjiASDqsdaFF";
        private string DUMMY_2 = "39#asfij)9ajs";
        private string DUMMY_3 = "RENijavd0&ad@adf";
        private string DUMMY_4 = "REefijd@adf";
        */
        // 로그인 암호
        public static string password;
        List<data> datas = new List<data>();
        List<string> keys = new List<string>();
        private int index;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label lbSite;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditOK;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelCancel;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnDelOK;
        private System.Windows.Forms.Button btnAddOK;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStrip toolStripBar;
        private System.Windows.Forms.ToolStripSplitButton tbtnAccount;
        private System.Windows.Forms.ToolStripDropDownButton tbtnHelp;
        private System.Windows.Forms.ToolStripMenuItem tbtnChangePW;
        private System.Windows.Forms.ToolStripMenuItem tbtnAbout;
    }
}
