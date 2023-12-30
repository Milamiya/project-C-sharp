using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCuaHangTivi.DataAccess;
using System.Data.SqlClient;

namespace QuanLyCuaHangTivi.Presentation
{
    public partial class fr_TK_TV : Form
    {
        public fr_TK_TV()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh WHERE tb_Hangsx.mahang= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh WHERE tb_Manhinh.mamanhinh= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh where tb_Tivi.maco like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op4.Checked)
            {
                string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh WHERE tb_Hangsx.tenhang  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op5.Checked)
            {
                string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh WHERE tb_Manhinh.tenmanhinh  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }

        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Tivi";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Tivi";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Hãng SX";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Mã Kiểu";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Mã Màu";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Mã Màn Hình";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Mã Cỡ";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Nơi Sản Xuất";
            msds.Columns[7].Width = 200;

            msds.Columns[8].HeaderText = "Giá Nhập";
            msds.Columns[8].Width = 200;

            msds.Columns[9].HeaderText = "Gía Bán";
            msds.Columns[9].Width = 200;

            msds.Columns[10].HeaderText = "Ảnh";
            msds.Columns[10].Width = 100;

            msds.Columns[11].HeaderText = "Ghi Chú";
            msds.Columns[11].Width = 100;

            msds.Columns[12].HeaderText = "Số Lượng";
            msds.Columns[12].Width = 100;

            msds.Columns[13].HeaderText = "Bảo Hành";
            msds.Columns[13].Width = 100;

        }
        public void hienthi()
        {
            string sql = @"SELECT     tb_Tivi.mativi, tb_Tivi.tentivi, tb_Hangsx.mahang, tb_Tivi.makieu, tb_Tivi.mamau, tb_Manhinh.mamanhinh, tb_Tivi.maco, tb_Tivi.manoisx, tb_Tivi.dongianhap, 
                      tb_Tivi.dongiaban, tb_Tivi.anh, tb_Tivi.ghichu, tb_Tivi.soluong, tb_Tivi.thoigianbaohanh
FROM         tb_Tivi INNER JOIN
                      tb_Hangsx ON tb_Tivi.mahangsx = tb_Hangsx.mahang INNER JOIN
                      tb_Manhinh ON tb_Tivi.mamanhinh = tb_Manhinh.mamanhinh";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void fr_TK_TV_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
