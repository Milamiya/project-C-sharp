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
    public partial class fr_HDN : Form
    {
        public fr_HDN()
        {
            InitializeComponent();
        }
        E_tb_HDN thucthi = new E_tb_HDN();
        ConnectDB cn = new ConnectDB();
        EC_tb_HDN ck = new EC_tb_HDN();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtngay.Text = DateTime.Now.ToShortTimeString();
            cbncc.Text = "";
            cbnv.Text = "";
            txttt.Text = "0";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtngay.Enabled = false;
            cbncc.Enabled = false;
            cbnv.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtngay.Enabled = true;
            cbncc.Enabled = true;
            cbnv.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
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
            string sql = "SELECT     sohdn, manv, ngaynhap, mancc, tongtien FROM tb_HDN";
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

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (cbnv.Text != "")
                {
                    if (cbncc.Text != "")
                    {
                        if (themmoi == true)
                        {
                            try
                            {
                                ck.SOHDN = txtma.Text;
                                ck.MANV = cbnv.Text;
                                ck.NGAYNHAN = txtngay.Text;
                                ck.MANCC = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.themoihdn(ck);
                                locktext();
                                hienthi();
                                MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_CTHDN fr = new fr_CTHDN();
                                fr.SOHDN = txtma.Text;
                                this.Close();
                                fr.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            try
                            {
                                ck.SOHDN = txtma.Text;
                                ck.MANV = cbnv.Text;
                                ck.NGAYNHAN = txtngay.Text;
                                ck.MANCC = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.suahdn(ck);
                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_CTHDN fr = new fr_CTHDN();
                                fr.SOHDN = txtma.Text;
                                this.Hide();
                                fr.ShowDialog();
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
                        cbncc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbnv.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.SOHDN = txtma.Text;

                    thucthi.xoahdn(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbnv.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbncc.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            locktext();
        }

        private void fr_HDN_Load(object sender, EventArgs e)
        {
            locktext();
            thucthi.loadmanv(cbnv);
            thucthi.loadmancc(cbncc);
            hienthi();
            khoitaoluoi();
        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnv.Text = thucthi.loadtenl(lbnv.Text, cbnv.Text);
        }

        private void cbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbncc.Text = thucthi.loadtenncc(lbncc.Text, cbncc.Text);
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fr_CTHDN fr = new fr_CTHDN();
            fr.SOHDN = txtma.Text;
            this.Close();
            fr.Show();
        }
    }
}
