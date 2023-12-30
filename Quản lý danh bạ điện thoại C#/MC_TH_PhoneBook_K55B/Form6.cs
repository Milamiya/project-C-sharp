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
    public partial class FrmStaffUp : Form
    {
        public FrmStaffUp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStaffUp_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            SqlDataAdapter dtA = new SqlDataAdapter();
            dtA.SelectCommand = comm;

            //cbxUnit

            DataSet dtSet = new DataSet();

            comm.CommandText = "Select \"Ten\" = 'Khoa '+TenKhoa" + " , Ma = MaKhoa From Khoa" + " Union" + " Select TenPhong, MaPhong" + " From Phongban";

            int numberRow = dtA.Fill(dtSet, "DONVI");


            DataTable dttb = new DataTable();
            dttb = dtSet.Tables["DONVI"];


            foreach (DataRow dtRow in dttb.Rows)
            {
                //(string.Format("{0}", dtRow["Ten"]));
                cbxUnit.Items.Add(dtRow["Ten"].ToString() + " " + dtRow["Ma"].ToString().Trim());

            }

            //cbxPosition

            DataSet dtSet1 = new DataSet();
            comm.CommandText = "Select distinct \"Chucvu\" = Chucvu" + " From CanBo";
            int numberRow1 = dtA.Fill(dtSet1, "Canbo");

            DataTable dttb1 = new DataTable();
            dttb1 = dtSet1.Tables["Canbo"];

            
            foreach (DataRow dtRow1 in dttb1.Rows)
            {
                cbxPosition.Items.Add(dtRow1["Chucvu"]);


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s;
            s = "INSERT INTO Canbo" + " VALUES('" + tbxStaffCode.Text + "','" + cbxUnit.Text.Substring(cbxUnit.Text.LastIndexOf(" ") + 1) + "'," +
                "N'" + tbxStaffName.Text + "',N'" + tbxAddress.Text + "','" + tbxHomePhone.Text + "'," +
                "'" + tbxMobi.Text + "',N'" + cbxPosition.Text + "')";

            comm.CommandText = s;
            
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

        private void tbxStaffCode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT *" + " From Canbo" + " Where Macb='" + tbxStaffCode.Text + "'";

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

            tbxStaffName.Text = dtRow["Tencb"].ToString();
            tbxAddress.Text = dtRow["Diachi"].ToString();
            tbxHomePhone.Text = dtRow["DTNR"].ToString();
            tbxMobi.Text = dtRow["DTDD"].ToString();
            cbxPosition.Text = dtRow["Chucvu"].ToString();

            //cbxUnit
            string ma = dtRow["Madv"].ToString().Trim();
            string s1;
            s1 = " Select Ten = 'Khoa ' + Tenkhoa" + " From Khoa" + " where makhoa = '" + dtRow["Madv"].ToString() + "'" +
                " union" + " Select TenPhong" + " From Phongban" + " Where MaPhong = '" + dtRow["Madv"].ToString() + "'";
            
            comm.CommandText = s1;
            dtAp.SelectCommand = comm;

            DataSet dtSet1 = new DataSet();
            conn.Open();
            numberRow = dtAp.Fill(dtSet1, "Ten");
            conn.Close();
            if (numberRow != 1) return;
            DataTable dttb1 = dtSet1.Tables["Ten"];
            dtRow = dttb1.Rows[0];
            cbxUnit.Text = dtRow["Ten"].ToString() + " " + ma;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string s;
            s = "Delete Canbo" + " Where Macb='" + tbxStaffCode.Text + "'";

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
            s = "Update Canbo" + " Set Madv = '" + cbxUnit.Text.Substring(cbxUnit.Text.LastIndexOf(" ")+1) + "'," +
                "Tencb = N'" + tbxStaffName.Text + "',Diachi = N'" + tbxAddress.Text + "',DTNR = '" + tbxHomePhone.Text + "'," +
                "DTDD = '" + tbxMobi.Text + "',Chucvu = N'" + cbxPosition.Text + "'" +
                " Where Macb = '" + tbxStaffCode.Text + "'";

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
