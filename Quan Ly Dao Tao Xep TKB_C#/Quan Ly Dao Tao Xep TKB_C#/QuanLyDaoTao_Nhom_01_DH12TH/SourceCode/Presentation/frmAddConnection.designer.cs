namespace QuanLyDaoTao.Presentation
{
    partial class frmAddConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddConnection));
            this.pnlConnectionInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoMoiDuLieuMau = new System.Windows.Forms.Button();
            this.grbDatabaseConnection = new System.Windows.Forms.GroupBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewDB = new System.Windows.Forms.TextBox();
            this.cmbDbName = new System.Windows.Forms.ComboBox();
            this.lblSelectDbName = new System.Windows.Forms.Label();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grbLogOn = new System.Windows.Forms.GroupBox();
            this.ckbRemeberPass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rdbServerAuthentication = new System.Windows.Forms.RadioButton();
            this.rdbWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.lblSyncStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlConnectionInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbDatabaseConnection.SuspendLayout();
            this.grbLogOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConnectionInfo
            // 
            this.pnlConnectionInfo.Controls.Add(this.groupBox1);
            this.pnlConnectionInfo.Controls.Add(this.grbDatabaseConnection);
            this.pnlConnectionInfo.Controls.Add(this.lblDataSource);
            this.pnlConnectionInfo.Controls.Add(this.cmbServerName);
            this.pnlConnectionInfo.Controls.Add(this.btnCancel);
            this.pnlConnectionInfo.Controls.Add(this.lblServerName);
            this.pnlConnectionInfo.Controls.Add(this.btnOK);
            this.pnlConnectionInfo.Controls.Add(this.btnRefresh);
            this.pnlConnectionInfo.Controls.Add(this.grbLogOn);
            this.pnlConnectionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnectionInfo.Location = new System.Drawing.Point(0, 66);
            this.pnlConnectionInfo.Name = "pnlConnectionInfo";
            this.pnlConnectionInfo.Size = new System.Drawing.Size(396, 474);
            this.pnlConnectionInfo.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMoiDuLieuMau);
            this.groupBox1.Location = new System.Drawing.Point(8, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu mẫu";
            // 
            // btnTaoMoiDuLieuMau
            // 
            this.btnTaoMoiDuLieuMau.Enabled = false;
            this.btnTaoMoiDuLieuMau.Location = new System.Drawing.Point(10, 16);
            this.btnTaoMoiDuLieuMau.Name = "btnTaoMoiDuLieuMau";
            this.btnTaoMoiDuLieuMau.Size = new System.Drawing.Size(358, 23);
            this.btnTaoMoiDuLieuMau.TabIndex = 10;
            this.btnTaoMoiDuLieuMau.Text = "Tạo dữ liệu mẫu cho ứng dụng";
            this.btnTaoMoiDuLieuMau.UseVisualStyleBackColor = true;
            this.btnTaoMoiDuLieuMau.Click += new System.EventHandler(this.btnTaoMoiDuLieuMau_Click);
            // 
            // grbDatabaseConnection
            // 
            this.grbDatabaseConnection.Controls.Add(this.btnTaoMoi);
            this.grbDatabaseConnection.Controls.Add(this.label1);
            this.grbDatabaseConnection.Controls.Add(this.txtNewDB);
            this.grbDatabaseConnection.Controls.Add(this.cmbDbName);
            this.grbDatabaseConnection.Controls.Add(this.lblSelectDbName);
            this.grbDatabaseConnection.Location = new System.Drawing.Point(8, 295);
            this.grbDatabaseConnection.Name = "grbDatabaseConnection";
            this.grbDatabaseConnection.Size = new System.Drawing.Size(378, 78);
            this.grbDatabaseConnection.TabIndex = 5;
            this.grbDatabaseConnection.TabStop = false;
            this.grbDatabaseConnection.Text = "Chọn database làm việc";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Enabled = false;
            this.btnTaoMoi.Location = new System.Drawing.Point(299, 31);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(69, 30);
            this.btnTaoMoi.TabIndex = 8;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tạo mới cơ sở dữ liệu:";
            // 
            // txtNewDB
            // 
            this.txtNewDB.Enabled = false;
            this.txtNewDB.Location = new System.Drawing.Point(180, 38);
            this.txtNewDB.Name = "txtNewDB";
            this.txtNewDB.Size = new System.Drawing.Size(115, 21);
            this.txtNewDB.TabIndex = 9;
            // 
            // cmbDbName
            // 
            this.cmbDbName.AllowDrop = true;
            this.cmbDbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDbName.Enabled = false;
            this.cmbDbName.FormattingEnabled = true;
            this.cmbDbName.Location = new System.Drawing.Point(10, 37);
            this.cmbDbName.Name = "cmbDbName";
            this.cmbDbName.Size = new System.Drawing.Size(149, 21);
            this.cmbDbName.TabIndex = 1;
            // 
            // lblSelectDbName
            // 
            this.lblSelectDbName.AutoSize = true;
            this.lblSelectDbName.Location = new System.Drawing.Point(7, 21);
            this.lblSelectDbName.Name = "lblSelectDbName";
            this.lblSelectDbName.Size = new System.Drawing.Size(133, 13);
            this.lblSelectDbName.TabIndex = 0;
            this.lblSelectDbName.Text = "Chọn cơ sở dữ liệu có sẵn:";
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(15, 8);
            this.lblDataSource.MaximumSize = new System.Drawing.Size(361, 91);
            this.lblDataSource.MinimumSize = new System.Drawing.Size(361, 91);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(361, 91);
            this.lblDataSource.TabIndex = 0;
            this.lblDataSource.Text = resources.GetString("lblDataSource.Text");
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(18, 108);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(236, 21);
            this.cmbServerName.TabIndex = 2;
            this.cmbServerName.SelectedIndexChanged += new System.EventHandler(this.cmbServerName_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(29, 50);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(76, 13);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Server Name :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(163, 436);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 30);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Lưu cấu hình";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(278, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Tìm trong mạng";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grbLogOn
            // 
            this.grbLogOn.Controls.Add(this.ckbRemeberPass);
            this.grbLogOn.Controls.Add(this.txtPassword);
            this.grbLogOn.Controls.Add(this.btnTestConnection);
            this.grbLogOn.Controls.Add(this.txtUserName);
            this.grbLogOn.Controls.Add(this.lblPassword);
            this.grbLogOn.Controls.Add(this.lblUserName);
            this.grbLogOn.Controls.Add(this.rdbServerAuthentication);
            this.grbLogOn.Controls.Add(this.rdbWindowsAuthentication);
            this.grbLogOn.Location = new System.Drawing.Point(8, 136);
            this.grbLogOn.Name = "grbLogOn";
            this.grbLogOn.Size = new System.Drawing.Size(378, 153);
            this.grbLogOn.TabIndex = 4;
            this.grbLogOn.TabStop = false;
            this.grbLogOn.Text = "Đăng nhập vào Server";
            // 
            // ckbRemeberPass
            // 
            this.ckbRemeberPass.AutoSize = true;
            this.ckbRemeberPass.Location = new System.Drawing.Point(100, 118);
            this.ckbRemeberPass.Name = "ckbRemeberPass";
            this.ckbRemeberPass.Size = new System.Drawing.Size(92, 17);
            this.ckbRemeberPass.TabIndex = 7;
            this.ckbRemeberPass.Text = "Nhớ mật khẩu";
            this.ckbRemeberPass.UseVisualStyleBackColor = true;
            this.ckbRemeberPass.CheckedChanged += new System.EventHandler(this.ckbRemeberPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(268, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(282, 118);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(86, 30);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "Kết nối";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 69);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(268, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(36, 72);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Tài khoản";
            // 
            // rdbServerAuthentication
            // 
            this.rdbServerAuthentication.AutoSize = true;
            this.rdbServerAuthentication.Location = new System.Drawing.Point(24, 41);
            this.rdbServerAuthentication.Name = "rdbServerAuthentication";
            this.rdbServerAuthentication.Size = new System.Drawing.Size(191, 17);
            this.rdbServerAuthentication.TabIndex = 1;
            this.rdbServerAuthentication.Text = "Sử dụng chứng thực quyền Server";
            this.rdbServerAuthentication.UseVisualStyleBackColor = true;
            this.rdbServerAuthentication.Click += new System.EventHandler(this.rdbServerAuthentication_Click);
            // 
            // rdbWindowsAuthentication
            // 
            this.rdbWindowsAuthentication.AutoSize = true;
            this.rdbWindowsAuthentication.Checked = true;
            this.rdbWindowsAuthentication.Location = new System.Drawing.Point(24, 18);
            this.rdbWindowsAuthentication.Name = "rdbWindowsAuthentication";
            this.rdbWindowsAuthentication.Size = new System.Drawing.Size(197, 17);
            this.rdbWindowsAuthentication.TabIndex = 0;
            this.rdbWindowsAuthentication.TabStop = true;
            this.rdbWindowsAuthentication.Text = "Sử dụng chứng thực quyền Window";
            this.rdbWindowsAuthentication.UseVisualStyleBackColor = true;
            this.rdbWindowsAuthentication.Click += new System.EventHandler(this.rdbWindowsAuthentication_Click);
            // 
            // lblSyncStatus
            // 
            this.lblSyncStatus.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSyncStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSyncStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyncStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblSyncStatus.Image")));
            this.lblSyncStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSyncStatus.Location = new System.Drawing.Point(215, 0);
            this.lblSyncStatus.Name = "lblSyncStatus";
            this.lblSyncStatus.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSyncStatus.Size = new System.Drawing.Size(181, 21);
            this.lblSyncStatus.TabIndex = 18;
            this.lblSyncStatus.Text = "Đang tìm máy chủ...";
            this.lblSyncStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QuanLyDaoTao.Properties.Resources.sql2008;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddConnection
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lblSyncStatus);
            this.Controls.Add(this.pnlConnectionInfo);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(412, 578);
            this.MinimumSize = new System.Drawing.Size(412, 578);
            this.Name = "frmAddConnection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình kết nối máy chủ";
            this.pnlConnectionInfo.ResumeLayout(false);
            this.pnlConnectionInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbDatabaseConnection.ResumeLayout(false);
            this.grbDatabaseConnection.PerformLayout();
            this.grbLogOn.ResumeLayout(false);
            this.grbLogOn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSyncStatus;
        private System.Windows.Forms.Panel pnlConnectionInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoMoiDuLieuMau;
        private System.Windows.Forms.GroupBox grbDatabaseConnection;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewDB;
        private System.Windows.Forms.ComboBox cmbDbName;
        private System.Windows.Forms.Label lblSelectDbName;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grbLogOn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RadioButton rdbServerAuthentication;
        private System.Windows.Forms.RadioButton rdbWindowsAuthentication;
        private System.Windows.Forms.CheckBox ckbRemeberPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}