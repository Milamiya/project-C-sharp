using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHangDienTu.DataAccess;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_TKHDN : Form
    {
        public fr_TKHDN()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT     tb_HDN.sohdn, tb_HDN.manv, tb_HDN.ngaynhap, tb_HDN.mancc, tb_HDN.tongtien
FROM         tb_HDN INNER JOIN
                      tb_CTHDN ON tb_HDN.sohdn = tb_CTHDN.sohdn";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT     tb_HDN.sohdn, tb_HDN.manv, tb_HDN.ngaynhap, tb_HDN.mancc, tb_HDN.tongtien
FROM         tb_HDN INNER JOIN
                      tb_CTHDN ON tb_HDN.sohdn = tb_CTHDN.sohdn WHERE tb_CTHDN.mahang= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT     tb_HDN.sohdn, tb_HDN.manv, tb_HDN.ngaynhap, tb_HDN.mancc, tb_HDN.tongtien
FROM         tb_HDN INNER JOIN
                      tb_CTHDN ON tb_HDN.sohdn = tb_CTHDN.sohdn WHERE tb_HDN.ngaynhap  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT     tb_HDN.sohdn, tb_HDN.manv, tb_HDN.ngaynhap, tb_HDN.mancc, tb_HDN.tongtien
FROM         tb_HDN INNER JOIN
                      tb_CTHDN ON tb_HDN.sohdn = tb_CTHDN.sohdn WHERE tb_HDN.mancc= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDN";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Nhân Viên";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Ngày Nhập";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Nhà Cung Cấp";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Tổng Tiền";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            string sql = @"SELECT     tb_HDN.sohdn, tb_HDN.manv, tb_HDN.ngaynhap, tb_HDN.mancc, tb_HDN.tongtien
FROM         tb_HDN INNER JOIN
                      tb_CTHDN ON tb_HDN.sohdn = tb_CTHDN.sohdn";
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

        private void fr_TKHDN_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
