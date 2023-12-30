using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MC_TH_PhoneBook_K55B
{
    public partial class FrmDepartmentUp : Form
    {
        public FrmDepartmentUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDepartmentUp_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s;
            s = "INSERT INTO Phongban" + " VALUES('" + tbxDepartmentCode.Text + "',N'" +
                tbxDepartmentName.Text + "'," +
                "'" + tbxPlaceCode.Text + "','" + tbxDepartmentNum.Text + "','" + tbxDeanCode.Text + "',"+
            "'"+tbxPhone.Text+"')";

            comm.CommandText = s;
            //MessageBox.Show(s);
            conn.Open();
            try
            {
                int numrow = comm.ExecuteNonQuery();
                if (numrow != 1) throw new SystemException();
                MessageBox.Show("Đã thêm dữ liệu thành công.");
                conn.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm dữ liệu (dữ liệu đã tồn tại).");
                return;
            }

            
        }

        private void tbxDepartmentCode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT *" + " From Phongban" + " Where MaPhong='" + tbxDepartmentCode.Text + "'";

            SqlDataAdapter dtAp = new SqlDataAdapter();
            dtAp.SelectCommand = comm;
            DataSet dtSet = new DataSet();
            conn.Open();

            int numberRow = dtAp.Fill(dtSet, "Pban");

            conn.Close();
            if (numberRow != 1)
                return;


            DataTable dttb = dtSet.Tables["Pban"];
            DataRow dtRow = dttb.Rows[0];

            tbxDepartmentCode.Text = dtRow["MaPhong"].ToString();
            tbxDepartmentName.Text = dtRow["TenPhong"].ToString();
            tbxPlaceCode.Text = dtRow["Madd"].ToString();
            tbxDepartmentNum.Text = dtRow["SoPhong"].ToString();
            tbxDeanCode.Text = dtRow["MaTPhong"].ToString();
            tbxPhone.Text = dtRow["SoDT"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            //SqlDataAdapter dtA = new SqlDataAdapter();
            //dtA.SelectCommand = comm;
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string s;
            s = "Delete Phongban" + " Where MaPhong='" + tbxDepartmentCode.Text + "'";

            comm.CommandText = s;
            conn.Open();
            try
            {
                int numrow = comm.ExecuteNonQuery();
                if (numrow != 1) throw new SystemException();
                MessageBox.Show("Đã xoá dữ liệu thành công.");
                conn.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xoá dữ liệu (dữ liệu không tồn tại).");
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s;
            s = "Update Phongban" + " Set TenPhong = N'" + tbxDepartmentName.Text + "'," +
                "Madd = '" + tbxPlaceCode.Text + "',Sophong = '" + tbxDepartmentNum.Text + "',"+
                " MaTPhong= '" + tbxDeanCode.Text + "'," +
                "SoDT = '" + tbxPhone.Text + "'" + " Where MaPhong = '" + tbxDepartmentCode.Text + "'";

               
            comm.CommandText = s;
            conn.Open();
            try
            {
                int numrow = comm.ExecuteNonQuery();
                if (numrow != 1) throw new SystemException();
                MessageBox.Show("Đã sửa dữ liệu thành công.");
                conn.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Có lỗi trong quá trình sửa dữ liệu (dữ liệu này không tồn tại).");
                return;
            }
        }
    }
}
