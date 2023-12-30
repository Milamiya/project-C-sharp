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
    public partial class Khoa : DevComponents.DotNetBar.Office2007Form
    {
        DataSet ds = new DataSet();
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        public Khoa()
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
         public void DSKhoa()
         {

             string sql = "SELECT * FROM Khoa";
             DataTable dt = ketnoi.ExecuteQuery(sql);
             this.showdatakhoa.DataSource = dt;
         }
        private void Khoa_Load(object sender, EventArgs e)
        {
            Ketnoi();

            sql = "Select * From Khoa";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtmakhoa.Text = reader["MaKhoa"].ToString();
            txttenkhoa.Text = reader["TenKhoa"].ToString();
            

            reader.Close();
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Khoa");
            DataTable dtb = ds.Tables["Khoa"];
            showdatakhoa.DataSource = dtb;

            cnn.Close();
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                row = showdatakhoa.Rows[e.RowIndex];
                txtmakhoa.Text = row.Cells[0].Value.ToString();
                txttenkhoa.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy Chọn Mã Khoa Hoac Tên Khoa");
            }

           
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                this.DSKhoa();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Không Thể Load ");
            }
            
            
        }
    }
}
