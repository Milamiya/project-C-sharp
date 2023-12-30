using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;

namespace QuanLyCafe.Presentation
{
    public partial class fr_Nhanvien : Form
    {
        public fr_Nhanvien()
        {
            InitializeComponent();
        }
        E_tb_Nhanvien thucthi = new E_tb_Nhanvien();
        ConnectDB cn = new ConnectDB();
        EC_tb_Nhanvien ck = new EC_tb_Nhanvien();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            cbgt.Text = "Nam";
            txtngaysinh.Text = DateTime.Now.ToShortTimeString();
            txtdt.Text = "";
            txtdc.Text = "";
            cbmaque.Text = "";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbgt.Enabled = false;
            txtngaysinh.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;
            cbmaque.Enabled = false;


            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbgt.Enabled = true;
            txtngaysinh.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;
            cbmaque.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Nhân Viên";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;
            msds.Columns[1].HeaderText = "Tên Nhân Viên";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Địa Chỉ";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Giới Tính";
            msds.Columns[3].Width = 200;
            msds.Columns[4].HeaderText = "Ngày Sinh";
            msds.Columns[4].Width = 200;
            msds.Columns[5].HeaderText = "Mã Quê";
            msds.Columns[5].Width = 200;
            msds.Columns[6].HeaderText = "SĐT";
            msds.Columns[6].Width = 200;


        }
        public void hienthi()
        {
            string sql = "SELECT manv, tennv, diachi, gioitinh, ngaysinh, maque, sdt FROM tb_Nhanvien";
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
                if (cbmaque.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            ck.MANV = txtma.Text;
                            ck.TENNV = txtten.Text;
                            ck.GIOITINH = cbgt.Text;
                            ck.NGAYSINH = txtngaysinh.Text;
                            ck.SDT = txtdt.Text;
                            ck.DIACHI = txtdc.Text;
                            ck.MAQUE = cbmaque.Text;

                            thucthi.themoinv(ck);
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
                            ck.MANV = txtma.Text;
                            ck.TENNV = txtten.Text;
                            ck.GIOITINH = cbgt.Text;
                            ck.NGAYSINH = txtngaysinh.Text;
                            ck.SDT = txtdt.Text;
                            ck.DIACHI = txtdc.Text;
                            ck.MAQUE = cbmaque.Text;

                            thucthi.suanv(ck);
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
                    cbmaque.Focus();
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
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MANV = txtma.Text;

                    thucthi.xoanv(ck);
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
        private void fr_Nhanvien_Load(object sender, EventArgs e)
        {
            thucthi.loadmaq(cbmaque);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtdc.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbgt.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtngaysinh.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cbmaque.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txtdt.Text = msds.Rows[dong].Cells[6].Value.ToString();
            locktext();
        }

        private void cbmaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbtenque.Text = thucthi.loadtenq(lbtenque.Text, cbmaque.Text);
        }
    }
}
