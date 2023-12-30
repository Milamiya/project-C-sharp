using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangTivi.Business.Component;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;

namespace QuanLyCuaHangTivi.Presentation
{
    public partial class fr_Comanhinh : Form
    {
        public fr_Comanhinh()
        {
            InitializeComponent();
        }
        E_tb_Comanhinh thucthi = new E_tb_Comanhinh();
        ConnectDB cn = new ConnectDB();
        EC_tb_Comanhinh ck = new EC_tb_Comanhinh();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtten.Text = "";
        }
        public void locktext()
        {
            txtten.Enabled = false;
            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtten.Enabled = true;
            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Cỡ";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 300;

        }
        public void hienthi()
        {
            string sql = "SELECT maco FROM tb_Comanhinh";
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
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                try
                {
                    ck.MACO = txtten.Text;
                    thucthi.themoic(ck);
                    locktext();
                    hienthi();
                    MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { }
            }
            else
            { }
            locktext();
            hienthi();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MACO = txtten.Text;

                    thucthi.xoac(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        private void fr_Comanhinh_Load(object sender, EventArgs e)
        {
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            
            txtten.Text = msds.Rows[dong].Cells[0].Value.ToString();
            locktext();
        }
    }
}
