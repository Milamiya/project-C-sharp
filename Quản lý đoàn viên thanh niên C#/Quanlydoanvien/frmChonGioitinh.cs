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
    public partial class frmChonGioitinh : DevComponents.DotNetBar.Office2007Form
    {
        public frmChonGioitinh()
        {
            InitializeComponent();
        }
        private OleDbConnection objConnect;
        private DataTable objDataTable;

        private void subCreateConnect()
        {
            try
            {
                String varChuoiConnect = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                            "Jet OLEDB:Database Password =000000;" +
                            "User ID = admin";
                objConnect = new OleDbConnection(varChuoiConnect);
                objConnect.Open();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể kết nối tới CSDL. Xin kiểm tra lại kết nối!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void subDestroyConnect()
        {
            objConnect.Close(); //Đóng kết nối
            objConnect.Dispose();//Giải phóng tài nguyên
            objConnect = null; //Hủy đối tượng
        }

        private void subSelectBySQLTructiepQuaDataReader()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Truy vấn dữ liệu
            String varSelect = "Select DISTINCT GIOITINH from DOANVIEN";//Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand(varSelect, objConnect);
            //Tạo DataReader nhận dữ liệu trả về
            OleDbDataReader objReader = objCommand.ExecuteReader();
            //Tạo đối tượng DataTable và Load DataReader vào
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
            //Gán dữ liệu vào Datagrid
            dgchon.DataSource = objDataTable;
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
            txttendv.DataBindings.Clear();
            txttendv.DataBindings.Add("Text", dgchon.DataSource, "GIOITINH");
        }
        public void selectdl()
        {
            dgchon.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from DOANVIEN", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        public delegate void PassData(string value);
        public PassData passData;
        private void frmChonGioitinh_Load(object sender, EventArgs e)
        {
            selectdl();
        }

        private void btnchonten_Click(object sender, EventArgs e)
        {
            if (passData != null)
            {
                passData(txttendv.Text);

            }
            this.Hide();  
        }
    }
}
