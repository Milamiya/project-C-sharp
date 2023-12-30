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
    public partial class FrmStaffSearch : Form
    {
        public FrmStaffSearch()
        {
            InitializeComponent();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStaffSearch_Load(object sender, EventArgs e)
        {
            //Connection to DB

            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s = "Select \"Mã cán bộ\" = Macb,\"Mã đơn vị\" = Madv,\"Tên cán bộ\" = Tencb," +
                "\"Địa chỉ\" = Diachi,\"Điện thoại nhà riêng\" = DTNR,\"Điện thoại di động\" = DTDD," +
                "\"Chức vụ\" = Chucvu" + " From Canbo"; ;
            comm.CommandText = s;

            SqlDataAdapter dtA = new SqlDataAdapter();
            dtA.SelectCommand = comm;
            DataSet dtSet = new DataSet();


            dtA.Fill(dtSet, "Canbo");
            dtSet.DataSetName = "Danh bạ điện thoại cán bộ";
            dtGridStaffSearch.DataSource = dtSet.DefaultViewManager;
            dtGridStaffSearch.AllowSorting = true;

            dtGridStaffSearch.NavigateTo(0, "Canbo");


            //cbxUnit

            DataSet dtSet1 = new DataSet();

            comm.CommandText = "Select \"Ten\" = 'Khoa '+TenKhoa" + " From Khoa" + " Union" + " Select TenPhong" + " From Phongban";

            dtA.Fill(dtSet1, "DONVI");


            DataTable dttb = new DataTable();
            dttb = dtSet1.Tables["DONVI"];
            cbxUnit.Items.Add((object)"");
            
            foreach (DataRow dtRow in dttb.Rows)
            {
                //(string.Format("{0}", dtRow["Ten"]));
                cbxUnit.Items.Add(dtRow["Ten"]);

            }


            //cbxPosition

            DataSet dtSet2 = new DataSet();
            comm.CommandText = "Select distinct \"Chucvu\" = Chucvu" + " From CanBo";
            dtA.Fill(dtSet2, "Canbo");

            DataTable dttb1 = new DataTable();
            dttb1 = dtSet2.Tables["Canbo"];
            cbxPosition.Items.Add((object)"");
            foreach (DataRow dtRow1 in dttb1.Rows)
            {
                cbxPosition.Items.Add(dtRow1["Chucvu"]);

            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            SqlDataAdapter dtA = new SqlDataAdapter();
            string unit;

            if (cbxUnit.Text != "" && cbxUnit.Text[0] == 'K') unit = cbxUnit.Text.Substring(5);
            else if (cbxUnit.Text != "") unit = cbxUnit.Text;
            else unit = "";

            string pos;
            if (cbxPosition.Text != "") pos = cbxPosition.Text;
            else pos = "%%";

            comm.CommandText = "Select \"Mã cán bộ\" = Macb,\"Mã đơn vị\" = Madv,\"Tên cán bộ\" = Tencb," +
                "\"Địa chỉ\" = Diachi,\"Điện thoại nhà riêng\" = DTNR,\"Điện thoại di động\" = DTDD," +
                "\"Chức vụ\" = Chucvu" + " From Canbo,Khoa" + " where (Canbo.Madv=Khoa.MaKhoa) " +
                "and Tencb like N'%" + tbxName.Text + "%' and TenKhoa like N'%" + unit + "%' and chucvu like N'" + pos + "' " +
                "union Select Canbo.* From Canbo,Phongban" + " where (Canbo.Madv=Phongban.MaPhong) and" +
                " Tencb like N'%" + tbxName.Text + "%' and TenPhong like N'%" + unit + "%' and chucvu like N'" + pos + "' ";

            dtA.SelectCommand = comm;
            DataSet dtSet = new DataSet();
            dtA.Fill(dtSet, "CanboKhoa");
            if (dtSet.Tables["CanboKhoa"].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào");
                return;
            }
            dtSet.DataSetName = "Kết quả tìm kiếm";
            dtGridStaffSearch.DataSource = dtSet.DefaultViewManager;
            dtGridStaffSearch.AllowSorting = true;
            dtGridStaffSearch.FlatMode = true;
            dtGridStaffSearch.NavigateTo(0, "CanboKhoa");



        }

        private void tbxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, EventArgs.Empty);
        }






    }
}
