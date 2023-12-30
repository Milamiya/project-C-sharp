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
    public partial class FrmPlaceUp : Form
    {
        public FrmPlaceUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s;
            s = "INSERT INTO Diadiem" + " VALUES('" + tbxPlaceCode.Text + "',N'" +
                tbxPlaceName.Text + "'," +
                "N'" + tbxManagement.Text + "','" + tbxHomePhone.Text + "','" + tbxMobi.Text + "'," +
            "N'" + tbxAddress.Text + "')";

            comm.CommandText = s;
            //MessageBox.Show(s);
            conn.Open();
            try
            {
                int numrow = comm.ExecuteNonQuery();
                if (numrow!= 1) throw new SystemException();
                MessageBox.Show("Đã thêm dữ liệu thành công.");
                conn.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm dữ liệu (dữ liệu đã tồn tại).");
                return;
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxPlaceCode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT *" + " From Diadiem" + " Where Madd='" + tbxPlaceCode.Text + "'";

            SqlDataAdapter dtAp = new SqlDataAdapter();
            dtAp.SelectCommand = comm;
            DataSet dtSet = new DataSet();
            conn.Open();

            int numberRow = dtAp.Fill(dtSet, "Ddiem");

            conn.Close();
            if (numberRow != 1)
                return;


            DataTable dttb = dtSet.Tables["Ddiem"];
            DataRow dtRow = dttb.Rows[0];

            tbxPlaceCode.Text = dtRow["Madd"].ToString();
            tbxPlaceName.Text = dtRow["Tendd"].ToString();
            tbxManagement.Text = dtRow["Quanli"].ToString();
            tbxHomePhone.Text = dtRow["DTNR"].ToString();
            tbxMobi.Text = dtRow["DTDD"].ToString();
            tbxAddress.Text = dtRow["Diachi"].ToString();
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
            s = "Delete Diadiem" + " Where Madd='" + tbxPlaceCode.Text + "'";

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
            s = "Update Diadiem" + " Set Tendd = N'" + tbxPlaceName.Text + "'," +
                "Quanli = N'" + tbxManagement.Text + "',DTNR = '" + tbxHomePhone.Text + "'," +
                " DTDD= '" + tbxMobi.Text + "'," +
                "Diachi = N'" + tbxAddress.Text + "'" + " Where Madd = '" + tbxPlaceCode.Text + "'";


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
