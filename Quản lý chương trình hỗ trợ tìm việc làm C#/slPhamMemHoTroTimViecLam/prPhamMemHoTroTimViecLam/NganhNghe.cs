using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
using Entities;

namespace prPhamMemHoTroTimViecLam
{
    public partial class NganhNghe : Form
    {
        public NganhNghe()
        {
            InitializeComponent();

        }
        DataTable tbNganhNghe;
        bool danap = false;
        BindingSource bs = new BindingSource();
        B_NganhNghe ObjNN = new B_NganhNghe();
        B_DoanhNghiep ObjDN = new B_DoanhNghiep();
        private void NganhNghe_Load(object sender, EventArgs e)
        {
            CapNhapListBox();
        }
        private void CapNhapListBox()
        {
            tbNganhNghe = ObjNN.gettbnganhnghe();
            lstNN.DataSource = tbNganhNghe;
            lstNN.DisplayMember = "Ten";
            lstNN.ValueMember = "Ma";
            danap = true;
            bs.DataSource = tbNganhNghe;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Nganh_Nghe obj = new Nganh_Nghe(txtMaNN.Text, txtTenNN.Text);
            int kq = ObjNN.ThemNganhNghe(obj);
            if (kq == 0)
            {
                MessageBox.Show("Thêm thành công");
                CapNhapListBox();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void lstNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danap)
            {
                bs.Position = lstNN.SelectedIndex;
                string s = lstNN.SelectedValue.ToString();
                DataTable tbdn = ObjDN.gettbdoanhnghieptheomanganhnghe(s);
                lsvNN.Items.Clear();
                int i = 1;
                txtMaNN.Text = lstNN.SelectedValue.ToString();
                txtTenNN.Text = lstNN.Text;
                foreach (DataRow dr in tbdn.Rows)
                {
                    ListViewItem li = lsvNN.Items.Add(i + "");
                    i++;
                    li.SubItems.Add(dr["Ten"].ToString());
                    li.SubItems.Add(dr["DiaChi"].ToString());
                    li.SubItems.Add(dr["SDT"].ToString());
                    li.SubItems.Add(dr["Email"].ToString());
                    li.SubItems.Add(dr["ChuDN"].ToString());
                    li.SubItems.Add(dr["MaNganhNghe"].ToString());

                    li.Tag = dr["Ma"];
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn thoát ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự xóa?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int loi = ObjNN.XoaNganhNghe(txtMaNN.Text);
                if (loi == 0)
                {
                    MessageBox.Show("Xóa thành công");
                    CapNhapListBox();
                }
                else if (loi == 2)
                {
                    MessageBox.Show("Không có mã ngành nghề trong hệ thống");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            Nganh_Nghe obj = new Nganh_Nghe(txtMaNN.Text, txtTenNN.Text);
            int loi = ObjNN.CapNhatNganhNghe(obj);
            if (loi == 0)
            {
                MessageBox.Show("Cập nhật thành công");
                CapNhapListBox();
            }
            else if (loi == 2)
            {
                MessageBox.Show("Không có mã ngành nghề trong hệ thống");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void lsvNN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
