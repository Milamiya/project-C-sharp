using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Properties;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmAddConnection : XtraForm
    {
        #region Biến thành viên

        private readonly DataTable _dtServers = new DataTable();
        private EventHandler _handler;
        private Server _server;
        private ServerConnection _serverConnection;

        #endregion

        #region Thuộc tính

        /// <summary>
        /// Read-only
        /// </summary>
        public Server Server
        {
            get { return _server; }
        }

        /// <summary>
        /// Read-only
        /// </summary>
        public ServerConnection ServerConnection
        {
            get { return _serverConnection; }
        }

        #endregion

        #region Phương thức

        public frmAddConnection()
        {
            InitializeComponent();
        }

        public new static DialogResult Show()
        {
            frmAddConnection frm = new frmAddConnection { TopMost = true };
            return frm.ShowDialog();
        }

        private IEnumerable<string> GetInstance()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\");
            }
            catch (Exception)
            {
                rk = Registry.LocalMachine.OpenSubKey(@"\SOFTWARE\Microsoft\Microsoft SQL Server\");
            }
            if (rk == null)
                return null;
            return (String[])rk.GetValue("InstalledInstances");
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            // Application was idle and thats when we do the work.
            // Lets first un-register the event.
            Application.Idle -= _handler;

            // Find local instance
            _dtServers.Columns.Add(new DataColumn("Name"));
            IEnumerable<string> instances = GetInstance();
            string computername = SystemInformation.ComputerName;

            DataRow dr;
            foreach (string si in instances)
            {
                if (si != computername)
                {
                    dr = _dtServers.NewRow();
                    dr["Name"] = computername + @"\" + si;
                    _dtServers.Rows.Add(dr);
                }
            }
            dr = _dtServers.NewRow();
            dr["Name"] = computername; // computername
            _dtServers.Rows.Add(dr);


            _dtServers.PrimaryKey = new[] { _dtServers.Columns[0] };
            cmbServerName.DataSource = _dtServers;
            cmbServerName.DisplayMember = "Name";
            cmbServerName.ValueMember = "Name";

            //Set the default server
            if (!string.IsNullOrEmpty(QuanLyDaoTao.Properties.Settings.Default.Server))
            {
                cmbServerName.SelectedIndex = _dtServers.Rows.IndexOf(_dtServers.Rows.Find(QuanLyDaoTao.Properties.Settings.Default.Server));
            }
            else
            {
                cmbServerName.SelectedIndex = 0;
            }

            //What type of authentication the user wants?  We will have to change the string as required.
            if (QuanLyDaoTao.Properties.Settings.Default.SQLAuthenticationMode)
            {
                rdbServerAuthentication.Checked = true;
                rdbWindowsAuthentication.Checked = false;

                if (QuanLyDaoTao.Properties.Settings.Default.SavePassword)
                {
                    txtUserName.Text = QuanLyDaoTao.Properties.Settings.Default.UserName;
                    txtPassword.Text = QuanLyDaoTao.Properties.Settings.Default.Password;
                    ckbRemeberPass.Checked = true;
                }
                else
                {
                    lblSyncStatus.Visible = false;
                    pnlConnectionInfo.Enabled = true;
                    Cursor = Cursors.Default;
                    return;
                }
            }
            else
            {
                rdbServerAuthentication.Checked = false;
                rdbWindowsAuthentication.Checked = true;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }

            string tmpDbName = QuanLyDaoTao.Properties.Settings.Default.DatabaseName;
            if (!string.IsNullOrEmpty(tmpDbName))
            {
                btnTestConnection_Click(this, null);
                cmbDbName.SelectedItem = QuanLyDaoTao.Properties.Settings.Default.DatabaseName;
            }
            lblSyncStatus.Visible = false;
            pnlConnectionInfo.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MsgboxUtil.YesNo("Tìm kiếm các máy chủ trong mạng LAN có thể mất nhiều thời gian."
                                + "\nBạn có thể gõ Tên máy chủ hoặc IP của máy chủ trong mạng LAN."
                                + "\nBạn có chắc chắn muốn tìm các máy chủ hoạt động trong mạng LAN?");
            if (result == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                //tìm tất cả các server sql có trong mạng
                DataTable mdtServers = SmoApplication.EnumAvailableSqlServers(false);
                DataRow dr;
                foreach (DataRow item in mdtServers.Rows)
                {
                    if (!CheckExistsServer(_dtServers, item))
                    {
                        dr = _dtServers.NewRow();
                        dr["Name"] = item["Name"];
                        _dtServers.Rows.Add(dr);
                    }
                }
                cmbServerName.DataSource = _dtServers;
                cmbServerName.DisplayMember = "Name";
                cmbServerName.ValueMember = "Name";
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Kiểm tra xem server truyền vào thông qua datarow đã có trong bảng server chưa.
        /// </summary>
        /// <param name="tb">bảng server</param>
        /// <param name="dr">datarow chứa server cần kiểm tra</param>
        /// <returns>false: nếu đã có rồi
        /// \ntrue: nếu chưa có</returns>
        private bool CheckExistsServer(DataTable tb, DataRow dr)
        {
            foreach (DataRow item in tb.Rows)
            {
                if (item["Name"].ToString() == dr["Name"].ToString())
                    return true;
            }
            return false;
        }

        /// <summary>
        /// add tất cả những database name có trong server vào combobox database name
        /// </summary>
        /// <param name="selectDbName"></param>
        private void ListDatabasesInServer(string selectDbName)
        {
            cmbDbName.Items.Clear();
            int i = 0, selected = 0;
            foreach (Database db in _server.Databases)
            {
                //ko add những database hệ thống vào
                //nếu ko phải là database hệ thống
                if (!db.IsSystemObject)
                {
                    if (selectDbName != null && selectDbName == db.Name)
                        selected = i;
                    i++;
                    cmbDbName.Items.Add(db.Name);
                }
            }
            if (i > 0)
                cmbDbName.SelectedIndex = selected;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //nếu một server được chọn
                if (!string.IsNullOrEmpty(cmbServerName.Text))
                {
                    //tạo kết nối đến server
                    string message = this.ConnectDatabase();
                    //nếu kết nối thành công
                    if (string.IsNullOrEmpty(message))
                    {
                        //add những CSDL hiện có của server vào combobox
                        this.ListDatabasesInServer(null);
                        //tùy chỉnh
                        cmbDbName.Enabled = true;
                        btnTaoMoi.Enabled = true;
                        btnTaoMoiDuLieuMau.Enabled = true;
                        txtNewDB.Enabled = true;
                    }
                        //nếu kết nối không thành công, xuất thông báo lỗi
                    else
                    {
                        MsgboxUtil.Exclamation(message);
                        return;
                    }
                }
                else
                {
                    MsgboxUtil.Exclamation("Bạn hãy chọn hoặc gõ tên 1 máy chủ để thực hiện");
                    return;
                }
            }
            catch (Exception ex)
            {
                cmbDbName.Enabled = false;
                btnTaoMoi.Enabled = false;
                txtNewDB.Enabled = false;
                btnTaoMoiDuLieuMau.Enabled = false;
                MsgboxUtil.Exclamation(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Tạo kết nối đến server được chọn trong combobox server
        /// </summary>
        /// <returns>Chuỗi thông báo lỗi nếu có lỗi xảy ra</returns>
        private string ConnectDatabase()
        {
            if (!string.IsNullOrEmpty(cmbServerName.Text))
            {
                try
                {
                    //tạo kết nối đến server
                    _serverConnection = new ServerConnection(cmbServerName.Text);
                    //kiểm tra kiểu quyền chứng thực
                    if (rdbWindowsAuthentication.Checked) //chứng thực quyền window
                    {
                        _serverConnection.LoginSecure = true;
                        _server = new Server(_serverConnection);
                    }
                    else
                    {
                        //tạo kết nối tới server được chọn trong combobox
                        _serverConnection.LoginSecure = false;
                        //user name
                        _serverConnection.Login = txtUserName.Text;
                        _serverConnection.Password = txtPassword.Text;
                        //tạo đối tượng sever sql sử dụng đối tượng kết nối vừa tạo
                        _server = new Server(_serverConnection);
                    }
                    return string.Empty;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return "Không có server nào được chọn.";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void rdbServerAuthentication_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            ckbRemeberPass.Enabled = true;
        }

        private void rdbWindowsAuthentication_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
            ckbRemeberPass.Enabled = false;
        }

        /// <summary>
        /// Sinh chuỗi kết nối
        /// </summary>
        /// <returns></returns>
        private static string BuildConnectionString()
        {
            string connectionStr;
            //nếu chứng thực bằng quyền window
            if (!QuanLyDaoTao.Properties.Settings.Default.SQLAuthenticationMode)
                connectionStr = @"Server=" + QuanLyDaoTao.Properties.Settings.Default.Server + "; Database=" 
                    + QuanLyDaoTao.Properties.Settings.Default.DatabaseName + "; Trusted_Connection=True;";
            else
                connectionStr = @"Server=" + QuanLyDaoTao.Properties.Settings.Default.Server + "; Database=" + QuanLyDaoTao.Properties.Settings.Default.DatabaseName
                    + "; User ID=" + QuanLyDaoTao.Properties.Settings.Default.UserName + "; Password=" + QuanLyDaoTao.Properties.Settings.Default.Password + ";";
            return connectionStr;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyDaoTao.Properties.Settings.Default.Server = cmbServerName.SelectedValue.ToString();
                QuanLyDaoTao.Properties.Settings.Default.SQLAuthenticationMode = rdbServerAuthentication.Checked;
                if (!string.IsNullOrEmpty(cmbDbName.Text))
                    QuanLyDaoTao.Properties.Settings.Default.DatabaseName = cmbDbName.SelectedItem.ToString();
                else
                    QuanLyDaoTao.Properties.Settings.Default.DatabaseName = string.Empty;

                //nếu chọn check box nhớ mật khẩu
                if (ckbRemeberPass.Checked)
                {
                    QuanLyDaoTao.Properties.Settings.Default.UserName = txtUserName.Text;
                    QuanLyDaoTao.Properties.Settings.Default.Password = txtPassword.Text;
                    QuanLyDaoTao.Properties.Settings.Default.SavePassword = true;
                }
                else
                {
                    QuanLyDaoTao.Properties.Settings.Default.UserName = txtUserName.Text;
                    QuanLyDaoTao.Properties.Settings.Default.Password = txtPassword.Text;
                    QuanLyDaoTao.Properties.Settings.Default.SavePassword = false;
                }
                //tạo kết nối đến server
                string message = ConnectDatabase();
                //nếu kết nối ko thành công
                if (!string.IsNullOrEmpty(message))
                {
                    MsgboxUtil.Exclamation(message);
                }
                //kết nối thành công
                else
                {
                    //chưa chọn database
                    if (QuanLyDaoTao.Properties.Settings.Default.DatabaseName == "")
                    {
                        MsgboxUtil.Exclamation("Chưa chọn database!");
                        return;
                    }
                    if (!this.CheckExists_Tables(QuanLyDaoTao.Properties.Settings.Default.DatabaseName))
                        this.InitStruct_DB(QuanLyDaoTao.Properties.Settings.Default.DatabaseName);

                    QuanLyDaoTao.Properties.Settings.Default.ConnectString = frmAddConnection.BuildConnectionString();
                    QuanLyDaoTao.Properties.Settings.Default.Save();
                    this.DialogResult = DialogResult.OK;
                    if (StaticClass.DangNhap)
                        StaticClass.Log.GhiFile("Kết nối với CSDL: " + QuanLyDaoTao.Properties.Settings.Default.DatabaseName);
                    MsgboxUtil.Info("Ứng dụng sẽ tự khởi động lại để cấu hình kết nối!");
                    DialogResult = DialogResult.OK;
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        /// <summary>
        /// Kiểm tra CSDL truyền vào có đầy đủ các bảng như đã thiết kế không
        /// </summary>
        /// <param name="dbName">tên database cần kiểm tra</param>
        /// <returns>true: đầy đủ các bảng.\nFalse: Không đầy đủ các bảng</returns>
        private bool CheckExists_Tables(string dbName)
        {
            try
            {
                string data;
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"/scripts/script_check_tables.sql"))
                {
                    data = sr.ReadToEnd();
                }
                DataSet dsTables = _server.Databases[dbName].ExecuteWithResults(data);
                return dsTables.Tables[0].Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Kiểm tra CSDL truyền vào có đầy đủ các bảng như đã thiết kế không
        /// </summary>
        /// <param name="dbName">tên database cần kiểm tra</param>
        /// <returns>true: đầy đủ các bảng.\nFalse: Không đầy đủ các bảng</returns>
        private static bool CheckExists_Tables(SqlConnection connect, string dbName)
        {
            string data;
            using (StreamReader sr = new StreamReader(Application.StartupPath + @"/scripts/script_check_tables.sql"))
            {
                data = sr.ReadToEnd();
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(data, connect);
            using (DataTable tbResult = new DataTable())
            {
                sqlDataAdapter.Fill(tbResult);
                return (tbResult.Rows.Count > 0);
            }
        }

        /// <summary>
        /// Tạo cấu trúc các bảng cho database
        /// </summary>
        /// <param name="dbName"></param>
        private void InitStruct_DB(string dbName)
        {
            try
            {
                string data;
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"/scripts/script_db_struct.sql"))
                {
                    data = sr.ReadToEnd();
                }
                data = data.Replace("QuanLyDaoTao", dbName);
                _server.Databases[dbName].ExecuteNonQuery(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool TestConnect()
        {
            string connStr = QuanLyDaoTao.Properties.Settings.Default.ConnectString;
            if (connStr.Equals(""))
                return false;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connStr);
                connection.Open();
                connection.Close();
                return CheckExists_Tables(connection, QuanLyDaoTao.Properties.Settings.Default.DatabaseName);
            }
            catch
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                return false;
            }
        }

        private void cmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDbName.Items.Clear();
            cmbDbName.Enabled = false;
            btnTaoMoi.Enabled = false;
            txtNewDB.Enabled = false;
            btnTaoMoiDuLieuMau.Enabled = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lblSyncStatus.Visible = true;
            lblSyncStatus.BringToFront();
            pnlConnectionInfo.Enabled = false;
            // Lets do the work when we've got some time.
            _handler = Application_Idle;
            Application.Idle += _handler;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (txtNewDB.Text.Equals(""))
            {
                MsgboxUtil.Error("Hãy gõ tên database cần thêm!");
                return;
            }
            string dbName = txtNewDB.Text;
            Database newDB = new Database(_server, dbName);

            string msg = "";
            try
            {
                newDB.Create();
                ListDatabasesInServer(dbName);
            }
            catch (Exception ex)
            {
                msg = ex.Message;

                if (ex.InnerException != null)
                {
                    msg = ex.InnerException.Message;
                }
            }
            if (msg.Equals(""))
            {
                if(StaticClass.DangNhap)
                    StaticClass.Log.GhiFile("Tạo mới CSDL: " + dbName);
                MsgboxUtil.Success("Tạo database \"" + dbName + "\" thành công!");
            }
            else
                MsgboxUtil.Error(msg);
        }

        /// <summary>
        /// Khởi tạo dữ liệu mẫu
        /// </summary>
        /// <param name="dbname"></param>
        private void InitData_DB(string dbname)
        {
            string data;
            using (var sr = new StreamReader(Application.StartupPath + @"/scripts/script_db_data.sql"))
            {
                data = sr.ReadToEnd();
            }
            _server.Databases[dbname].ExecuteNonQuery(data);
        }

        private void btnTaoMoiDuLieuMau_Click(object sender, EventArgs e)
        {
            try
            {
                var dbName = cmbDbName.SelectedItem.ToString();
                if (!CheckExists_Tables(dbName))
                    InitStruct_DB(dbName);
                InitData_DB(dbName);
                MsgboxUtil.Success("Đã tạo dữ liệu mẫu thành công!");
                if (StaticClass.DangNhap)
                    StaticClass.Log.GhiFile("Tạo dữ liệu mẫu cho ứng dụng");
            }
            catch (SqlException ex)
            {
                MsgboxUtil.Error(ex.Message);
            }
        }

        #endregion

        private void ckbRemeberPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRemeberPass.Checked)
                QuanLyDaoTao.Properties.Settings.Default.SavePassword = true;
            else
                QuanLyDaoTao.Properties.Settings.Default.SavePassword = false;
        }
    }
}
