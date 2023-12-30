using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace Quanlydoanvien
{
    public partial class frmLoginmanager : DevComponents.DotNetBar.Office2007Form
    {
        public frmLoginmanager()
        {
            InitializeComponent();
        }
        
        private DataTable objDataTable;
        public OleDbConnection conn()
        {
            return new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                        "Data Source =" + Application.StartupPath + @"\Dangnhap.mdb;" +
                        "Jet OLEDB:Database Password =222222;" +
                        "User ID = admin");
        }

        private void subDestroyConnect()
        {
            OleDbConnection kn = conn();
            kn.Close();
            //Đóng kết nối
            kn.Dispose();//Giải phóng tài nguyên
            kn = null; //Hủy đối tượng
        }
        private void subSelectBySQLTructiepQuaDataReader()
        {
            //Tạo kết nối tới file Access
            OleDbConnection kn = conn();
            kn.Open();
            //Truy vấn dữ liệu
            String varSelect = "Select userid,pass,role from Login";//Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand(varSelect, kn);
            //Tạo DataReader nhận dữ liệu trả về
            OleDbDataReader objReader = objCommand.ExecuteReader();
            //Tạo đối tượng DataTable và Load DataReader vào
            objDataTable = new DataTable("abc");
            objDataTable.Load(objReader);
            //Gán dữ liệu vào Datagrid
            dgdoanvien.DataSource = objDataTable;
            //Hủy các đối tượng
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            subDestroyConnect();
        }
        private void subBindingData()
        {
            txtpass.DataBindings.Clear();
            txtpass.DataBindings.Add("Text", dgdoanvien.DataSource, "pass");
            txtrole.DataBindings.Clear();
            txtrole.DataBindings.Add("Text", dgdoanvien.DataSource, "role");
            txtuser.DataBindings.Clear();
            txtuser.DataBindings.Add("Text", dgdoanvien.DataSource, "userid");
            
           
        }
        public void selectdl()
        {
            dgdoanvien.DataSource = null;
            OleDbConnection kn = conn();           
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
            //Load bảng điểm
            kn.Open();
            OleDbCommand objcommand = new OleDbCommand("Select userid,pass,role from Login", kn);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
            
        }
        private void frmLoginmanager_Load(object sender, EventArgs e)
        {

            selectdl();
            if (demgiatri() == 0)
            {
                
                MessageBoxEx.Show("Các User đã bị xóa hết khỏi danh sách và bạn sẽ không đăng nhập vào hệ thống lần sau! Hãy thêm User mới ngay bây giờ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            OleDbConnection kn = conn();
            kn.Open();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = kn;
            objCommand.CommandType = CommandType.Text;

            objCommand.CommandText = "Insert into Login values(?,?,?,?)";
            objCommand.Parameters.Add("@userid", OleDbType.VarChar).Value = txtuser.Text;
            objCommand.Parameters.Add("@pass", OleDbType.VarChar).Value = txtpass.Text;
            objCommand.Parameters.Add("@role", OleDbType.VarChar).Value = txtrole.Text;
            objCommand.Parameters.Add("@dk", OleDbType.VarChar).Value ="";
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            subDestroyConnect();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtuser.Text == "")
                {

                    MessageBoxEx.Show("User không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Focus();
                }
                else
                    if (txtpass.Text == "")
                    {

                        MessageBoxEx.Show("Password không dược rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpass.Focus();
                    }
                    else
                        if (txtrole.Text == "")
                        {

                            MessageBoxEx.Show("Quyền hạn không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtrole.Focus();
                        }
                        else
                        {

                            subInsertCommandHasParameter();
                            selectdl();
                            MessageBoxEx.Show("Đã lưu " + txtuser.Text + " vào danh sách quản lý thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("User này đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            selectdl();
        }
        private void subDeleteCommandHasParameter()
        {
            
            //Tạo kết nối
            OleDbConnection kn = conn();
            kn.Open();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = kn;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Delete From Login Where userid = ?";
            objcommand.Parameters.Add("userid", OleDbType.VarChar).Value = txtuser.Text;
            objcommand.ExecuteNonQuery();
            
            //Hủy đối tượng
            objcommand.Dispose(); 
            objcommand = null;
            subDestroyConnect();
            txtuser.Text = "";
            txtrole.Text = "";
            txtpass.Text = "";
            
        }
        public int demgiatri()
        {
            int i;
            for (i = 0; i < dgdoanvien.RowCount - 1; i++)
            {
                i.ToString();
            }
            return i;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                
                MessageBoxEx.Show("Các User đã bị xóa hết khỏi danh sách và bạn sẽ không đăng nhập vào hệ thống lần sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa user "+txtuser.Text+" ra khỏi danh sách quản lý đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    txtuser.Text = "";
                    txtrole.Text = "";
                    txtpass.Text = "";                   
                    selectdl();

                    MessageBoxEx.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Bạn đã không xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            selectdl();
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection kn = conn();
                OleDbCommand objCommand = new OleDbCommand();
                objCommand.Connection = kn;
                objCommand.CommandType = CommandType.Text;
                kn.Open();

                if (demgiatri() != 0)
                {
                    string sql = "";
                    sql = "UPDATE Login SET  userid ='" + txtuser.Text + "', pass ='" + txtpass.Text + "',role ='" + txtrole.Text + "'WHERE userid ='" + txtuser.Text + "'";
                    objCommand.CommandText = sql;
                    objCommand.ExecuteNonQuery();
                    kn.Close();
                    MessageBoxEx.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng này!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                selectdl();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            selectdl();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtrole.Text = "";
            txtpass.Text = "";
            txtuser.Focus();
            txtrole.Text = "Admin";
        }


      
        private void xóaNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {             
                MessageBoxEx.Show("Các User đã bị xóa hết khỏi danh sách và bạn sẽ không đăng nhập vào hệ thống lần sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa user " + txtuser.Text + " ra khỏi danh sách quản lý đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {
                    
                    subDeleteCommandHasParameter();
                 
                    selectdl();


                    MessageBoxEx.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Bạn đã không xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            selectdl();
        }
       
     
    }
}
