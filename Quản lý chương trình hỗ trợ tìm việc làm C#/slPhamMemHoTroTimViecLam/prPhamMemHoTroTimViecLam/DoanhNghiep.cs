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
    public partial class DoanhNghiep : Form
    {
        public DoanhNghiep()
        {
            InitializeComponent();
        }
        DataTable tbNganhNghe, tbDoanhNghiep, tbDN_Listview, tbTenNN, tbNN;
        B_NganhNghe objNN = new B_NganhNghe();
        B_DoanhNghiep objDN = new B_DoanhNghiep();
        bool danap = false;
        private void DoanhNghiep_Load(object sender, EventArgs e)
        {
            tbNN = new DataTable();
            NapComBoBox();
            NapALL_DoanhNghiep();
        }
        private void NapComBoBox()
        {
            tbNganhNghe = objNN.gettbnganhnghe();
            cboNganh.DataSource = tbNganhNghe;
            cboNganh.DisplayMember = "Ten";
            cboNganh.ValueMember = "Ma";
            danap = true;
        }
        private void NapALL_DoanhNghiep()
        {
            lstDN.Items.Clear();
            tbDoanhNghiep = objDN.getAllDoanhNghiep();
            foreach (DataRow dr in tbDoanhNghiep.Rows)
            {
                ListViewItem li = lstDN.Items.Add(dr["ma"].ToString());
                li.SubItems.Add(dr["Ten"].ToString());
                li.SubItems.Add(dr["DiaChi"].ToString());
                li.SubItems.Add(dr["SDT"].ToString());
                li.SubItems.Add(dr["Email"].ToString());
                li.SubItems.Add(dr["ChuDN"].ToString());
                li.SubItems.Add(dr["MaNganhNghe"].ToString());
                li.Tag = dr["ma"].ToString();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn thoát ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
        private bool KiemTra_txt()
        {
            if (txtMaDN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã");
                return false;
            }
            else if (txtTenDN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên");
                return false;
            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ");
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email");
                return false;
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SDT");
                return false;
            }
            else if (txtChuDN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Chu Doanh Nghiệp");
                return false;
            }
            else return true;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra_txt())
            {


                string maNN = "";
                tbNN = objNN.LayMaNN_TheoTen(cboNganh.Text);
                DataRow dr = tbNN.Rows[0];
                maNN = dr["ma"].ToString();
                Doanh_Nghiep obj = new Doanh_Nghiep(txtMaDN.Text, txtTenDN.Text, txtDiachi.Text, txtSDT.Text, txtEmail.Text, txtChuDN.Text, maNN);
                int kq = objDN.ThemDoanhNghiep(obj);
                if (kq == 0)
                {
                    MessageBox.Show("Thêm thành công");
                    NapComBoBox();
                    NapALL_DoanhNghiep();
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Mã doanh nghiệp đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void LayTenDN_TheoMaNN(string maNN)
        {
            tbTenNN = objDN.getTenNN_TheoMaNN(maNN);
            DataRow dr = tbTenNN.Rows[0];
            cboNganh.Text = dr["ten"].ToString();


        }
        private void lstDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDN.SelectedItems.Count > 0)
            {
                string ma = lstDN.SelectedItems[0].Tag.ToString();
                tbDN_Listview = objDN.gettbdoanhnghieptheomadoanhnghiep(ma);
                DataRow dr = tbDN_Listview.Rows[0];
                txtMaDN.Text = dr["ma"].ToString();
                txtTenDN.Text = dr["ten"].ToString();
                txtDiachi.Text = dr["diachi"].ToString();
                txtSDT.Text = dr["sdt"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtChuDN.Text = dr["chudn"].ToString();
                LayTenDN_TheoMaNN(dr["manganhnghe"].ToString());
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra_txt())
            {


                string maNN = "";
                tbNN = objNN.LayMaNN_TheoTen(cboNganh.Text);
                DataRow dr = tbNN.Rows[0];
                maNN = dr["ma"].ToString();
                Doanh_Nghiep obj = new Doanh_Nghiep(txtMaDN.Text, txtTenDN.Text, txtDiachi.Text, txtSDT.Text, txtEmail.Text, txtChuDN.Text, maNN);
                int loi = objDN.CapNhatDoanhNghiep(obj);
                if (loi == 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    NapComBoBox();
                    NapALL_DoanhNghiep();
                }
                else if (loi == 2)
                {
                    MessageBox.Show("Không có mã doanh nghiệp trong hệ thống");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTra_txt())
            {


                if (MessageBox.Show("Ban có thật sự xóa?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int loi = objDN.XoaDoanhNghiep(txtMaDN.Text);
                    if (loi == 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        NapComBoBox();
                        NapALL_DoanhNghiep();
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
        }

    }
}
