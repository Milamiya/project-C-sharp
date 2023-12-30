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
    public partial class FrmUnitSearch : Form
    {
        public FrmUnitSearch()
        {
            InitializeComponent();
            cbxUnitSearch.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUnitSearch_Load(object sender, EventArgs e)
        {

            //cbxUnitSearch.Items.AddRange(new object[] {
            //"Khoa",
            //"Phòng ban"});
            
            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();

            SqlDataAdapter dtA = new SqlDataAdapter();
            dtA.SelectCommand = comm;

            //if (cbxUnitSearch.Text == "Khoa")

            comm.CommandText = "Select \"Mã Khoa\" = MaKhoa,\"Tên Khoa\" = TenKhoa," +
                "\"Mã địa điểm\" = Madd,\"Mã trưởng Khoa\" = MaTKhoa,\"Số điện thoại\" = SDT" + " From Khoa";
         


                DataSet dtSet = new DataSet();
                dtA.Fill(dtSet, "Khoa");
                dtSet.DataSetName = "Danh bạ điện thoại các Khoa";
                dtGridUnitSearch.DataSource = dtSet.DefaultViewManager;
                dtGridUnitSearch.AllowSorting = true;
                dtGridUnitSearch.FlatMode = true;
                dtGridUnitSearch.NavigateTo(0, "Khoa");
            
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Server=Starrynighth-PC;Database=QUANLIDANHBADIENTHOAI;Integrated security=true");
            SqlCommand comm = conn.CreateCommand();
            SqlDataAdapter dtA = new SqlDataAdapter();
            if (cbxUnitSearch.Text == "Khoa")
            {
            
            
                comm.CommandText = "Select \"Mã Khoa\" = MaKhoa,\"Tên Khoa\" = TenKhoa,"+
                    "\"Mã địa điểm\" = Madd,\"Mã trưởng Khoa\" = MaTKhoa,\"Số điện thoại\" = SDT" + " From Khoa"
                    + " Where TenKhoa like N'%" + tbxNameUnit.Text + "%'";
                //MessageBox.Show(comm.CommandText);
                //Tim kiem theo tbxName

                
                
                dtA.SelectCommand = comm;
                DataSet dtSet = new DataSet();
                int numrow = dtA.Fill(dtSet, "Khoa");
                if (numrow == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào");
                    return;
                }
                dtSet.DataSetName = "Kết quả tìm kiếm";
                dtGridUnitSearch.DataSource = dtSet.DefaultViewManager;
                dtGridUnitSearch.AllowSorting = true;
                dtGridUnitSearch.FlatMode = true;
            }
            else if (cbxUnitSearch.Text == "Phòng ban")
            {
                comm.CommandText = "Select \"Mã Phòng\" = MaPhong,\"Tên Phòng ban\" = TenPhong,\"Mã địa điểm\" = Madd,"+
                    "\"Số Phòng\" = SoPhong,\"Mã trưởng Phòng\" = MaTPhong,\"Số điện thoại\" = SoDT" + " From Phongban" 
                    + " Where TenPhong like N'%" + tbxNameUnit.Text + "%'";
                //MessageBox.Show(comm.CommandText);
                //Tim kiem theo tbxName



                dtA.SelectCommand = comm;
                DataSet dtSet1 = new DataSet();
                int numrow = dtA.Fill(dtSet1, "Phongban");
                if (numrow == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào");
                    return;
                }
                dtSet1.DataSetName = "Kết quả tìm kiếm";
                dtGridUnitSearch.DataSource = dtSet1.DefaultViewManager;
                dtGridUnitSearch.AllowSorting = true;
                dtGridUnitSearch.FlatMode = true;
                dtGridUnitSearch.NavigateTo(0, "Phongban");
            }
        }

        private void cbxUnitSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void tbxNameUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, EventArgs.Empty);
        }

       

        }

       
    }

