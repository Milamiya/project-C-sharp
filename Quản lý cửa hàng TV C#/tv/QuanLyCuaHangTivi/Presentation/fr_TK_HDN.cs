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
using QuanLyCuaHangTivi.Business.Component;

namespace QuanLyCuaHangTivi.Presentation
{
    public partial class fr_TK_HDN : Form
    {
        public fr_TK_HDN()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_CTHDN thucthi = new E_tb_CTHDN();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT     sohdn, mativi, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN where mativi='"+cbhang.Text+"' or soluong='"+txtten.Text+"'";
            msds.DataSource = cn.taobang(sql);

            SqlConnection con = cn.getcon();
            con.Open();
        }

        private void fr_TK_HDN_Load(object sender, EventArgs e)
        {
            thucthi.loadmasp(cbhang);
            hienthi();
            khoitaoluoi();
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDN";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Mã Tivi";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Số Lượng";
            msds.Columns[2].Width = 80;
            msds.Columns[3].HeaderText = "Đơn Giá";
            msds.Columns[3].Width = 80;
            msds.Columns[4].HeaderText = "Giảm Giá";
            msds.Columns[4].Width = 80;
            msds.Columns[5].HeaderText = "Thành Tiền";
            msds.Columns[5].Width = 80;
        }
        public void hienthi()
        {
            string sql = "SELECT sohdn, mativi, soluong, dongia, giamgia, thanhtien FROM tb_CTHDN";
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

        private void cbhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtensp(lbhang.Text, cbhang.Text);
        }
    }
}
