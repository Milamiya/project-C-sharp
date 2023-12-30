using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prBaiThiWin2_Ca2
{
    public partial class frmQuanLyTuyenDL : Form
    {
        public frmQuanLyTuyenDL()
        {
            InitializeComponent();
        }

        BOCommon com = new BOCommon();
        private void frmQuanLyTuyenDL_Load(object sender, EventArgs e)
        {
            NapVaoListView();

            cboLoaiPT.DataSource = com.LayBangLoaiPhuongTien().Tables[0];
            cboLoaiPT.DisplayMember = "TenPhuongTien";
            cboLoaiPT.ValueMember = "LoaiPT";

            btnLuu.Enabled = false;

            lvwDanhSachTuyenDL.Items[0].Selected = true;
        }

        private void NapVaoListView()
        {
            int tongphipt = 0;
            lvwDanhSachTuyenDL.Items.Clear();
            foreach (DataRow dong in com.LayBangTuyenDuLich().Tables[0].Rows)
            {
                ListViewItem li = new ListViewItem(dong[1].ToString());
                li.SubItems.Add(dong[2].ToString());
                li.Tag = dong[0].ToString();
                if (dong[5].ToString() == "MB")//Những tuyến nào có loại phương tiện bằng MB là gắn hình vào
                    li.ImageIndex = 0;

                tongphipt += int.Parse(dong[3].ToString());
                lvwDanhSachTuyenDL.Items.Add(li);
            }

            lblTongPhi.Text = tongphipt.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                txtMaTuyen.Clear();
                txtMaTuyen.Focus();
                txtTenTuyen.Clear();
                txtSoNgayDL.Clear();
                txtPhiPT.Clear();
                txtPhiAnO.Clear();
                cboLoaiPT.Text = "";
                btnLuu.Enabled = true;
                btnThem.Text = "Hủy bỏ";
                lvwDanhSachTuyenDL.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";

                lvwDanhSachTuyenDL.Items[0].Selected = true;
                lvwDanhSachTuyenDL.Enabled = true;
            }
        }

        private void lvwDanhSachTuyenDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhSachTuyenDL.SelectedItems.Count > 0)
            {
                DataTable dt = com.LayThongTinTuyenDL(lvwDanhSachTuyenDL.SelectedItems[0].Tag.ToString());
                txtMaTuyen.Text = dt.Rows[0][0].ToString();
                txtTenTuyen.Text = dt.Rows[0][1].ToString();
                txtSoNgayDL.Text = dt.Rows[0][2].ToString();
                txtPhiPT.Text = dt.Rows[0][3].ToString();
                txtPhiAnO.Text = dt.Rows[0][4].ToString();

                cboLoaiPT.SelectedValue = dt.Rows[0][5].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTuyen.Text == "")
            {
                MessageBox.Show("Mã tuyến chưa nhập");
                txtMaTuyen.Focus();
            }
            else
            {
                bool trungkhoa = false;
                foreach (DataRow dong in com.LayBangTuyenDuLich().Tables[0].Rows)
                {
                    if (dong[0].ToString().ToUpper() == txtMaTuyen.Text.ToUpper())
                    {
                        trungkhoa = true;
                        break;
                    }
                }

                if (trungkhoa == true)
                {
                    MessageBox.Show("Mã tuyến đã tồn tại");
                    txtMaTuyen.Focus();
                    txtMaTuyen.SelectAll();
                }
                else
                {
                    if (txtSoNgayDL.Text == "")
                        txtSoNgayDL.Text = "0";
                    if (txtPhiPT.Text == "")
                        txtPhiPT.Text = "0";
                    if (txtPhiAnO.Text == "")
                        txtPhiAnO.Text = "0";

                    com.ThemTuyenDL(txtMaTuyen.Text,txtTenTuyen.Text,txtSoNgayDL.Text,txtPhiPT.Text,txtPhiAnO.Text,cboLoaiPT.SelectedValue.ToString());
                    btnLuu.Enabled = false;
                    btnThem.Text = "Thêm";

                    lvwDanhSachTuyenDL.Enabled = true;
                    NapVaoListView();
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoNgayDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPhiPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPhiAnO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
                e.Handled = true;
        }

        private void frmQuanLyTuyenDL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "THONG BAO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
