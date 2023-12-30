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
    public partial class frmChon3 : DevComponents.DotNetBar.Office2007Form
    {
        public frmChon3()
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
            String varSelect = "Select MADV,SOBIENBAN from VIPHAM";//Lệnh SQL
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

            txtsobb.DataBindings.Clear();
            txtsobb.DataBindings.Add("Text", dgchon.DataSource, "SOBIENBAN");
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgchon.DataSource, "MADV");
            
        }
        public void selectdl()
        {
            dgchon.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from VIPHAM", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        private void frmChon3_Load(object sender, EventArgs e)
        {
            selectdl();
        }
        public delegate void PassData(string value);
        public PassData passData;
        public PassData passData2;
        
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (passData != null)
            {
                passData(txtsobb.Text);
                passData2(txtmadv.Text);
                

            }
            this.Hide();  
        }
    }
}
