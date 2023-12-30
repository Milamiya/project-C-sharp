using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace qlhocvien
{
    public partial class MonHoc : DevComponents.DotNetBar.Office2007Form
    {
        DataSet ds = new DataSet();
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        public MonHoc()
        {
            InitializeComponent();
        }
        public void Ketnoi()
        {
            try
            {
                            cnn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0 ;" + "Data Source =" +
                                Application.StartupPath + @"\qlhocvien.mdb;" +
                                "Jet OLEDB:Database Password =;" +
                                "User ID = admin";


            cnn.Open();

            cmd.Connection = cnn;
            }
            catch (Exception)
            {

                MessageBox.Show(" Không Thể Kết Nối Database");
            }


        }
        public void DSMonHoc()
        {

            string sql = "SELECT * FROM MonHoc";
            DataTable dt = ketnoi.ExecuteQuery(sql);
            this.showdatamonhoc.DataSource = dt;
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            try
            {
            Ketnoi();

            sql = "Select * From MonHoc";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtmamhmh.Text = reader["MaMH"].ToString();
            txttenmhmh.Text = reader["TenMH"].ToString();
            txtmagvmh.Text = reader["MaGV"].ToString();
            txttongsotiet.Text = reader["TongSoTiet"].ToString();
            txtsotiethoc.Text = reader["SoTiet"].ToString();
            txtmahvmh.Text = reader["MaHV"].ToString();
            reader.Close();
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "MonHoc");
            DataTable dtb = ds.Tables["MonHoc"];
            showdatamonhoc.DataSource = dtb;

            cnn.Close();
            }
            catch 
            {
                MessageBox.Show("Lỗi");
                
            }
        }

        private void showdatamonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                row = showdatamonhoc.Rows[e.RowIndex];
                txtmamhmh.Text = row.Cells[0].Value.ToString();
                txttenmhmh.Text = row.Cells[1].Value.ToString();
                txtmagvmh.Text = row.Cells[2].Value.ToString();
                txttongsotiet.Text = row.Cells[3].Value.ToString();
                txtsotiethoc.Text = row.Cells[4].Value.ToString();
                txtmahvmh.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Không Thể Load ");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                this.DSMonHoc();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Lỗi Không Thể Load ");
            }
        }


    }
}
