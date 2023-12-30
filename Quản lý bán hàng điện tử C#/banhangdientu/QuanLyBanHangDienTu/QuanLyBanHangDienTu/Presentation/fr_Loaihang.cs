using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangDienTu.Business.Component;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_Loaihang : Form
    {
        public fr_Loaihang()
        {
            InitializeComponent();
        }
        E_tb_Loaihang thucthi = new E_tb_Loaihang();
        ConnectDB cn = new ConnectDB();
        EC_tb_Loaihang ck = new EC_tb_Loaihang();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            cbn.Text = "";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbn.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbn.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Loại";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Mã Nhóm";
            msds.Columns[1].Width = 300;
            msds.Columns[2].HeaderText = "Tên Loại";
            msds.Columns[2].Width = 300;

        }
        public void hienthi()
        {
            string sql = "SELECT     maloai, manhom, tenloai  FROM tb_Loaihang";
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
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MANHOM = txtma.Text;

                    thucthi.xoakh(ck);
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
        private void fr_Khachhang_Load(object sender, EventArgs e)
        {
            thucthi.loadman(cbn);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbn.Text = msds.Rows[dong].Cells[1].Value.ToString();
            locktext();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MALOAI = txtma.Text;
                        ck.TENLOAI = txtten.Text;
                        ck.MANHOM = cbn.Text;

                        thucthi.themoikh(ck);
                        locktext();
                        hienthi();
                        MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        ck.MALOAI = txtma.Text;
                        ck.TENLOAI = txtten.Text;
                        ck.MANHOM = cbn.Text;

                        thucthi.suakh(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txtma.Enabled = true;
                locktext();
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void cbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbn.Text = thucthi.loadtenn(lbn.Text, cbn.Text);
        }
    }
}
