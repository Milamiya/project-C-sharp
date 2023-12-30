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
    public partial class FrmFacultyUp : Form
    {
        public FrmFacultyUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();

            //string s;
            //s = "Select * From Canbo Where Macb='"+tbx;

            //SqlDataAdapter dtA = new SqlDataAdapter();
            //DataSet dtSet = new DataSet();
            string s1;
            s1 = "INSERT INTO Khoa" + " VALUES('" + tbxFacultyCode.Text + "',N'" +
                tbxFacultyName.Text + "'," +
                "'" + tbxPlaceCode.Text + "','" + tbxDean.Text + "','" + tbxPhone.Text + "')";

            comm.CommandText = s1;
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



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            string s1;
            s1 = "Select * From Canbo Where Madv='" + tbxFacultyCode.Text + "'";

            comm.CommandText = s1;
            SqlDataAdapter dtA = new SqlDataAdapter();
            DataSet dtSet = new DataSet();
            dtA.SelectCommand = comm;
            int numrow1 = dtA.Fill(dtSet, "Canbo");


            if (dtSet.Tables["Canbo"].Rows.Count == 0)

                MessageBox.Show("Cho phép xoá dữ liệu", "Thông báo");
            else
            {
                MessageBox.Show("Không được phép xoá vì có dữ liệu", "Thông báo");
                return;
            }

                string s;
                s = "Delete Khoa" + " Where MaKhoa='" + tbxFacultyCode.Text + "'";

                comm.CommandText = s;
                conn.Open();
                try
                {
                    int numrow = comm.ExecuteNonQuery();
                    if (numrow != 1) throw new SystemException();
                    MessageBox.Show("Đã xoá dữ liệu thành công.");
                    
                    conn.Close();
                    return;
                }
                catch (SystemException ex)
                {
                    MessageBox.Show("Có lỗi trong quá trình xoá dữ liệu (dữ liệu không tồn tại).");
                    return;
                }
            }

        private void tbxFacultyCode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT MaKhoa, Ten = 'Khoa ' + TenKhoa, Madd,MaTKhoa,SDT" + " From Khoa" + " Where MaKhoa='" + tbxFacultyCode.Text + "'";

            SqlDataAdapter dtAp = new SqlDataAdapter();
            dtAp.SelectCommand = comm;
            DataSet dtSet = new DataSet();
            conn.Open();

            int numberRow = dtAp.Fill(dtSet, "Change");

            conn.Close();
            if (numberRow != 1)
                return;


            DataTable dttb = dtSet.Tables["Change"];
            DataRow dtRow = dttb.Rows[0];

            tbxFacultyName.Text = dtRow["Ten"].ToString();
            tbxPlaceCode.Text = dtRow["Madd"].ToString();
            tbxDean.Text = dtRow["MaTKhoa"].ToString();
            tbxPhone.Text = dtRow["SDT"].ToString();
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s;
            s = "Update Khoa" + " Set TenKhoa = N'" + tbxFacultyName.Text + "'," +
                "Madd = '" + tbxPlaceCode.Text + "',MaTKhoa = '" + tbxDean.Text + "',SDT = '" + tbxPhone.Text + "'" +
                " Where MaKhoa = '" + tbxFacultyCode.Text + "'";

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
