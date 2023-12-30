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
    public partial class FrmPlaceSearch : Form
    {
        public FrmPlaceSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPlaceSearch_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            string s = "Select \"Mã địa điểm\" = Madd,\"Tên địa điểm\" = Tendd," +
                "\"Người Quản lí\"= Quanli,\"Điện thoại nhà riêng\"=DTNR," +
                "\"Điện thoại di động\" = DTDD,\"Địa chỉ\" = Diachi" + " From Diadiem";
            comm.CommandText = s;

            SqlDataAdapter dtA = new SqlDataAdapter();
            dtA.SelectCommand = comm;
            DataSet dtSet = new DataSet();
            dtA.Fill(dtSet, "Diadiem");
            dtSet.DataSetName = "Danh bạ điện thoại của người quản lí các địa điểm";
            dtGridPlaceSearch.DataSource = dtSet.DefaultViewManager;
            dtGridPlaceSearch.AllowSorting = true;
            dtGridPlaceSearch.FlatMode = true;
            dtGridPlaceSearch.NavigateTo(0, "Diadiem");


            //cbxPlaceSearch

            tbxSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            SqlDataAdapter dtA = new SqlDataAdapter();

            string s = "Select \"Mã địa điểm\" = Madd,\"Tên địa điểm\" = Tendd," +
                "\"Người Quản lí\"= Quanli,\"Điện thoại nhà riêng\"=DTNR," +
                "\"Điện thoại di động\" = DTDD,\"Địa chỉ\" = Diachi" + " From Diadiem" + " Where Tendd like '%" + tbxSearch.Text + "%'";

            comm.CommandText = s;

            //MessageBox.Show(comm.CommandText);
            //Tim kiem theo tbxName



            dtA.SelectCommand = comm;
            DataSet dtSet = new DataSet();
            int numrow = dtA.Fill(dtSet, "Diadiem");
            if (numrow == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào");
                return;
            }
            dtSet.DataSetName = "Kết quả tìm kiếm";
            dtGridPlaceSearch.DataSource = dtSet.DefaultViewManager;
            dtGridPlaceSearch.AllowSorting = true;
            dtGridPlaceSearch.FlatMode = true;
            dtGridPlaceSearch.NavigateTo(0, "Ddiem");
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, EventArgs.Empty);
        }

    }
}

