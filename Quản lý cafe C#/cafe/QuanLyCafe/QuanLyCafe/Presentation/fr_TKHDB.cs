using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DataAccess;
using System.Data.SqlClient;

namespace QuanLyCafe.Presentation
{
    public partial class fr_TKHDB : Form
    {
        public fr_TKHDB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDB";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Nhân Viên";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Ngày Bán";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Khách Hàng";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Tổng Tiền";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT     mahdb, ngayban,manv, makh,tongtien FROM tb_HDB";
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

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT     tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT     tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb WHERE tb_CTHDB.masp= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT     tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb WHERE tb_HDB.ngayban = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT     tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb WHERE tb_HDB.manv = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
        }
    }
}
