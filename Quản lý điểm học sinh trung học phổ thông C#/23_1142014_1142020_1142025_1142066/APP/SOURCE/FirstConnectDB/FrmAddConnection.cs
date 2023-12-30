using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using Settings = FirstConnectDB.Properties.Settings;

namespace FirstConnectDB
{
    public partial class FrmAddConnection : Form
    {
        private readonly DataTable _dtServers = new DataTable();
        private EventHandler _handler;
        private Server _mServer;
        private ServerConnection _mServerConnection;

        public FrmAddConnection()
        {
            InitializeComponent();
        }

        public Server DatabaseServer
        {
            get { return _mServer; }
        }

        public new static DialogResult Show()
        {
            var frm = new FrmAddConnection {TopMost = true};
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
            return (String[]) rk.GetValue("InstalledInstances");
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
            string computername = "localhost";

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


            _dtServers.PrimaryKey = new[] {_dtServers.Columns[0]};
            cmbServerName.DataSource = _dtServers;
            cmbServerName.DisplayMember = "Name";
            cmbServerName.ValueMember = "Name";

            //Set the default server
            if (!string.IsNullOrEmpty(Settings.Default.Server))
            {
                cmbServerName.SelectedIndex = _dtServers.Rows.IndexOf(_dtServers.Rows.Find(Settings.Default.Server));
            }
            else
            {
                cmbServerName.SelectedIndex = 0;
            }

            //What type of authentication the user wants?  We will have to change the string as required.
            if (Settings.Default.SQLAuthenticationMode)
            {
                rdbServerAuthentication.Checked = true;
                rdbWindowsAuthentication.Checked = false;

                if (Settings.Default.SavePassword)
                {
                    txtUserName.Text = Settings.Default.UserName;
                    txtPassword.Text = Settings.Default.Password;
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

            string tmpDbName = Settings.Default.DatabaseName;
            if (!string.IsNullOrEmpty(tmpDbName))
            {
                btnTestConnection_Click(this, null);
                cmbDbName.SelectedItem = Settings.Default.DatabaseName;
            }
            lblSyncStatus.Visible = false;
            pnlConnectionInfo.Enabled = true;
            Cursor = Cursors.Default;
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

        private bool CheckExistsServer(DataTable tb, DataRow row)
        {
            foreach (DataRow item in tb.Rows)
            {
                if (item["Name"].ToString() == row["Name"].ToString())
                    return false;
            }
            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tìm kiếm các máy chủ trong mạng LAN có thể mất nhiều thời gian."
                                + "\nBạn có thể gõ Tên máy chủ hoặc IP của máy chủ trong mạng LAN."
                                + "\nBạn có chắc chắn muốn tìm các máy chủ hoạt động trong mạng LAN?",
                                "Network finding...",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
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

        private void ListDatabasesInServer(string selectDbName = null)
        {
            cmbDbName.Items.Clear();
            int i = 0, selected = 0;
            // Loop through the databases list
            foreach (Database db in _mServer.Databases)
            {
                //We don't want to be adding the System databases to our list
                //Check if database is system database
                if (!db.IsSystemObject)
                {
                    if (selectDbName != null && selectDbName == db.Name)
                        selected = i;
                    i++;
                    cmbDbName.Items.Add(db.Name); // Add database to combobox
                }
            }
            if (i > 0)
                cmbDbName.SelectedIndex = selected;
        }

        private void rdbServerAuthentication_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void rdbWindowsAuthentication_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            //this.chkSavePassword.Enabled = false;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                // If a server is selected
                if (!string.IsNullOrEmpty(cmbServerName.Text))
                {
                    string message = ConnectDatabase();
                    if (string.IsNullOrEmpty(message))
                    {
                        //This will populate list of databases on selected server
                        ListDatabasesInServer();
                        cmbDbName.Enabled = true;
                        btnTaoMoi.Enabled = true;
                        btnTaoMoiDuLieuMau.Enabled = true;
                        txtNewDB.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(message, "SQL Authetication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    // A server was not selected, show an error message
                    MessageBox.Show("Bạn hãy chọn hoặc gõ Tên máy chủ để thực hiện!", "Server not selected",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                cmbDbName.Enabled = false;
                btnTaoMoi.Enabled = false;
                txtNewDB.Enabled = false;
                btnTaoMoiDuLieuMau.Enabled = false;
                MessageBox.Show(ex.Message, "SQL Authetication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string ConnectDatabase()
        {
            if (!string.IsNullOrEmpty(cmbServerName.Text))
            {
                try
                {
                    _mServerConnection = new ServerConnection(cmbServerName.Text);
                    //this.m_ServerConnection
                    //First Check type of Authentication
                    if (rdbWindowsAuthentication.Checked) //Windows Authentication
                    {
                        _mServerConnection.LoginSecure = true;
                        _mServer = new Server(_mServerConnection);
                    }
                    else
                    {
                        // Create a new connection to the selected server name
                        _mServerConnection.LoginSecure = false;
                        _mServerConnection.Login = txtUserName.Text; //Login User
                        _mServerConnection.Password = txtPassword.Text; //Login Password
                        // Create a new SQL Server object using the connection we created
                        _mServer = new Server(_mServerConnection);
                    }
                    return string.Empty;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return "Không có server nào được chọn";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private static string BuildConnectString()
        {
            string connectStr;
            if (!Settings.Default.SQLAuthenticationMode)
            {
                connectStr = @"Server=" + Settings.Default.Server + ";Database=" + Settings.Default.DatabaseName +
                             ";Trusted_Connection=True;";
            }
            else
            {
                connectStr = @"Server=" + Settings.Default.Server + ";Database=" + Settings.Default.DatabaseName +
                             ";Integrated Security=SSPI;User ID=" + Settings.Default.UserName + ";Password=" +
                             Settings.Default.Password + ";";
            }
            return connectStr;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.Server = cmbServerName.SelectedValue.ToString();
            Settings.Default.SQLAuthenticationMode = rdbServerAuthentication.Checked;
            if (!string.IsNullOrEmpty(cmbDbName.Text))
            {
                Settings.Default.DatabaseName = cmbDbName.SelectedItem.ToString();
            }
            else
            {
                Settings.Default.DatabaseName = string.Empty;
            }

            if (rdbServerAuthentication.Checked)
            {
                Settings.Default.UserName = txtUserName.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.SavePassword = true;
            }
            else
            {
                Settings.Default.UserName = string.Empty;
                Settings.Default.Password = string.Empty;
                Settings.Default.SavePassword = false;
            }

            string message = ConnectDatabase();
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(this, message, "SQL Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Settings.Default.DatabaseName == "")
                {
                    MessageBox.Show("Chưa chọn được cơ sở dữ liệu để lưu cấu hình!");
                    return;
                }

                if (!CheckExists_Tables(Settings.Default.DatabaseName))
                    InitStruct_DB(Settings.Default.DatabaseName);

                Settings.Default.ConnectString = BuildConnectString();
                Settings.Default.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public static bool TestConnect()
        {
            string strConnect = Settings.Default.ConnectString;
            if (strConnect.Equals(""))
                return false;
            SqlConnection mConnect = null;
            try
            {
                mConnect = new SqlConnection(strConnect);
                mConnect.Open();
                mConnect.Close();
                return CheckExists_Tables(mConnect, Settings.Default.DatabaseName);
            }
            catch
            {
                if (mConnect != null)
                    if (mConnect.State == ConnectionState.Open)
                        mConnect.Close();
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

        private void btnTaoMoiDuLieuMau_Click(object sender, EventArgs e)
        {
            try
            {
                var dbName = cmbDbName.SelectedItem.ToString();
                if(!CheckExists_Tables(dbName))
                    InitStruct_DB(dbName);
                InitData_DB(dbName);
                MessageBox.Show("Đã tạo dữ liệu mẫu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình tạo cơ sở dữ liệu mẫu: " + ex.Message);
            }
        }
        /// <summary>
        /// Khởi tạo struct database
        /// </summary>
        /// <param name="dbname"></param>
        private  void InitStruct_DB(string dbname)
        {
            string data;
            using (var sr = new StreamReader(Application.StartupPath + @"/scripts/script_db_struct.sql"))
            {
                data = sr.ReadToEnd();
            }
            data = data.Replace("QLHS_HCMUS", dbname);
            _mServer.Databases[dbname].ExecuteNonQuery(data);
        }
        /// <summary>
        /// Kiểm tra đủ các tables hay không
        /// </summary>
        /// <param name="dbname"></param>
        /// <returns></returns>
        private bool CheckExists_Tables(string dbname)
        {
            string data;
            using (var sr = new StreamReader(Application.StartupPath + @"/scripts/script_check_tables.sql"))
            {
                data = sr.ReadToEnd();
            }
            var dsTables = _mServer.Databases[dbname].ExecuteWithResults(data);
            return dsTables.Tables[0].Rows.Count > 0;
        }

        /// <summary>
        /// Kiểm tra đủ các tables hay không
        /// </summary>
        /// <param name="dbname"></param>
        /// <returns></returns>
        private static bool CheckExists_Tables(SqlConnection connect,string dbname)
        {
            string data;
            using (var sr = new StreamReader(Application.StartupPath + @"/scripts/script_check_tables.sql"))
            {
                data = sr.ReadToEnd();
            }
            var sqlDataAdapter = new SqlDataAdapter(data, connect);
            using (var tbResult = new DataTable())
            {
                sqlDataAdapter.Fill(tbResult);
                return (tbResult.Rows.Count > 0);
            }
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
            _mServer.Databases[dbname].ExecuteNonQuery(data);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (txtNewDB.Text.Equals(""))
            {
                MessageBox.Show("Hãy gõ tên database cần thêm!");
                return;
            }
            string dbName = txtNewDB.Text;
            var newDB = new Database(_mServer, dbName);

            string msg = "";
            try
            {
                newDB.Create();
                ListDatabasesInServer(dbName);
            }
            catch (Exception exc)
            {
                msg = exc.Message;

                if (exc.InnerException != null)
                {
                    msg = exc.InnerException.Message;
                }
            }
            msg = msg.Equals("") ? "Tạo database \"" + dbName + "\" thành công!" : msg;
            MessageBox.Show(msg);
        }
    }
}