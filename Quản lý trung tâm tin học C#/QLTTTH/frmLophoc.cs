using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clsDATABASE;

namespace QLTTTH
{
    public partial class frmLophoc : Form
    {
        public frmLophoc()
        {
            InitializeComponent();
        }
        clsQLTTTH obj = new clsQLTTTH();
        DataTable tbl = new DataTable();

        #region Su kien form load, load tree va list

        #region Load form
        private void frmLophoc_Load(object sender, EventArgs e)
        {
            tbl = obj.GetDataTable("Lop");
            Loadtreeview(tbl, treDanhsachLH);
            LoadListview(tbl, lvwDanhSachLHCS);
        }
        #endregion

        #region Load list
        void LoadListview(DataTable tbl, ListView lvw)
        {
            int a = 0;
            lvwDanhSachLHCS.Items.Clear();
            ListViewItem lvwItem;
            foreach (DataRow drw in tbl.Rows)
            {
                a++;
                lvwItem = new ListViewItem();
                lvwItem.Text = drw["MaLop"].ToString();
                lvwItem.SubItems.Add(drw["TenLop"].ToString());
                lvwItem.SubItems.Add(drw["KhoaHoc"].ToString());
                lvwItem.SubItems.Add(drw["GVCN"].ToString());
                string ngayKG = Convert.ToDateTime(drw["NgayKG"].ToString()).ToShortDateString();
                lvwItem.SubItems.Add(ngayKG);
                lvwItem.ImageIndex = 0;
                lvwDanhSachLHCS.Items.Add(lvwItem);
            }
            lblLop.Text = "Tổng số lớp học là " + a.ToString() + " lớp học";
        }
        #endregion

        #region Load tree
        void Loadtreeview(DataTable tbl, TreeView tree)
        {
            foreach (DataRow drwLop in tbl.Rows)
            {
                TreeNode nodecha = new TreeNode();
                nodecha.Text = "Tên Lớp: " + drwLop["TenLop"].ToString();
                nodecha.Tag = drwLop;
                nodecha.ImageIndex = 0;
                treDanhsachLH.Nodes.Add(nodecha);
            }
        }
        #endregion

        #endregion

        #region Su kien dong
        private void frmLophoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng thông tin lớp học?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }
        #region nut thoat tab xem
        private void btnThoatL_Click(object sender, EventArgs e)
        {
            #region kiem tra them truoc khi thoat
            if (btnThemLH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu lớp học này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        if (obj.KTMaLop(txtMaLH.Text) == false)
                        {
                            LuuThem();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã lớp, vui lòng nhập lại mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaLH.SelectAll();
                        }
                    }
                    else
                        return;
                }
                if (DialogResult.No == d)
                    this.Close();
                if (DialogResult.Cancel == d)
                    return;
            }
            #endregion

            #region kiem tra sua truoc khi thoat
            if (btnSuaLH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        LuuSua();
                        this.Close();
                    }
                    else
                        return;
                }
                if (DialogResult.No == d)
                    this.Close();
                if (DialogResult.Cancel == d)
                    return;
            }
            #endregion

            #region neu ca 2 DK tren sai thi thuc hien lenh nay
            else
                this.Close();
            #endregion
        }
        #endregion

        #region nut thoat tab hieu chinh
        private void btnThoatLH_Click(object sender, EventArgs e)
        {
            #region kiem tra them truoc khi thoat
            if (btnThemLH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu lớp học này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        if (obj.KTMaLop(txtMaLH.Text) == false)
                        {
                            LuuThem();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã lớp, vui lòng nhập lại mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaLH.SelectAll();
                        }
                    }
                    else
                        return;
                }
                if (DialogResult.No == d)
                    this.Close();
                if (DialogResult.Cancel == d)
                    return;
            }
            #endregion

            #region kiem tra sua truoc khi thoat
            if (btnSuaLH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        LuuSua();
                        this.Close();
                    }
                    else
                        return;
                }
                if (DialogResult.No == d)
                    this.Close();
                if (DialogResult.Cancel == d)
                    return;
            }
            #endregion

            #region neu ca 2 DK tren sai thi thuc hien lenh nay
            else
                this.Close();
            #endregion
        }
        #endregion

        #endregion

        #region Su kien chon tree va list
        private void treDanhsachLH_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow drw;
            if (treDanhsachLH.SelectedNode.Parent == null&&treDanhsachLH.SelectedNode!=null)
            {
                drw = (DataRow)treDanhsachLH.SelectedNode.Tag;
                lvwDanhsachSVLH.Items.Clear();
                lblLopX.Text = "";
                foreach (DataRow drwLH in tbl.Rows)
                {
                    if (drw["MaLop"].ToString().Equals(drwLH["MaLop"]))
                    {
                        txtMalopX.Text = drwLH["MaLop"].ToString();
                        txtTenlopX.Text = drwLH["TenLop"].ToString();
                        txtKhoahocX.Text = drwLH["KhoaHoc"].ToString();
                        txtGVCNX.Text = drwLH["GVCN"].ToString();
                        dtpKG.Text = drwLH["NgayKG"].ToString();
                    }
                }

            }
        }

        private void lvwDanhSachLHCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhSachLHCS.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDanhSachLHCS.SelectedItems[lvwDanhSachLHCS.SelectedItems.Count - 1];
                if (item != null)
                {
                    txtMaLH.Text = item.SubItems[0].Text;
                    txtTenLH.Text = item.SubItems[1].Text;
                    txtKhoahoc.Text = item.SubItems[2].Text;
                    txtGVCN.Text = item.SubItems[3].Text;
                    dtpNgayKG.Text = item.SubItems[4].Text;
                }
            }
        }

        private void lvwDanhsachSVLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhsachSVLH.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDanhsachSVLH.SelectedItems[lvwDanhsachSVLH.SelectedItems.Count - 1];
                if (item != null)
                {
                    txtMalopX.Text = item.SubItems[0].Text;
                    txtTenlopX.Text = item.SubItems[1].Text;
                    txtKhoahocX.Text = item.SubItems[2].Text;
                    txtGVCNX.Text = item.SubItems[3].Text;
                    dtpKG.Text = item.SubItems[4].Text;
                }
            }
        }
        #endregion

        #region Ham hien tat ca len list
        void HientatcaLHlenlistview(DataTable tblHL,ListView lvw)
        {
            int a = 0;
            lvwDanhsachSVLH.Items.Clear();
            ListViewItem lvwItem;
            foreach (DataRow drw in tbl.Rows)
            {
                a++;
                lvwItem = new ListViewItem();
                lvwItem.Text = drw["MaLop"].ToString();
                lvwItem.SubItems.Add(drw["TenLop"].ToString());
                lvwItem.SubItems.Add(drw["KhoaHoc"].ToString());
                lvwItem.SubItems.Add(drw["GVCN"].ToString());
                string NgayKg = Convert.ToDateTime(drw["NgayKG"].ToString()).ToShortDateString();
                lvwItem.SubItems.Add(NgayKg);
                lvwItem.ImageIndex = 0;
                lvwDanhsachSVLH.Items.Add(lvwItem);
            }
            lblLopX.Text = "Tổng số lớp học là " + a.ToString() + " lớp học"; 
        }
        #endregion

        #region Hieu chinh khung nhin trong list
        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhSachLHCS.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhSachLHCS.View = View.Details;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhSachLHCS.View = View.SmallIcon;
        }

        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhSachLHCS.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhSachLHCS.View = View.List;
        }
        #endregion

        #region Cac nut thi hanh lenh

        #region Nut hien tat ca
        private void btnHientatcaLH_Click(object sender, EventArgs e)
        {
            lvwDanhsachSVLH.Items.Clear();
            HientatcaLHlenlistview(tbl, lvwDanhsachSVLH);
        }
        #endregion

        #region Nut tim
        private void btnTimLH_Click(object sender, EventArgs e)
        {
            frmTimLH lophoc = new frmTimLH();
            lophoc.ShowDialog();
        }
        #endregion

        #region Nut them
        private void btnThemLH_Click(object sender, EventArgs e)
        {
            if (btnThemLH.Text == "Thêm")
            {
                btnThemLH.Text = "Hủy";
                btnThemLH.ImageIndex = 6;
                txtMaLH.Text = "";
                txtTenLH.Text = "";
                txtGVCN.Text = "";
                txtKhoahoc.Text = "";
                dtpNgayKG.Text = "";
                txtMaLH.Enabled = true;
                txtTenLH.Enabled = true;
                txtGVCN.Enabled = true;
                txtKhoahoc.Enabled = true;
                dtpNgayKG.Enabled = true;
                btnLuuLH.Enabled = true;
                btnSuaLH.Enabled = false;
                btnXoaLH.Enabled = false;
                lvwDanhSachLHCS.Enabled = false;
            }
            else
            {
                btnThemLH.Text = "Thêm";
                btnThemLH.ImageIndex = 0;
                txtMaLH.Text = "";
                txtTenLH.Text = "";
                txtGVCN.Text = "";
                txtKhoahoc.Text = "";
                dtpNgayKG.Text = "";
                txtMaLH.Enabled = false;
                txtTenLH.Enabled = false;
                txtGVCN.Enabled = false;
                txtKhoahoc.Enabled = false;
                dtpNgayKG.Enabled = false;
                btnLuuLH.Enabled = false;
                btnSuaLH.Enabled = true;
                btnXoaLH.Enabled = true;
                lvwDanhSachLHCS.Enabled = true;
            }
        }
        #endregion

        #region Nut sua
        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            if (lvwDanhSachLHCS.SelectedItems.Count == 0 || txtMaLH.Text=="")
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa chữa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnSuaLH.Text == "Sửa")
                {
                    btnSuaLH.Text = "Hủy";
                    btnSuaLH.ImageIndex = 6;
                    txtTenLH.Enabled = true;
                    txtGVCN.Enabled = true;
                    txtKhoahoc.Enabled = true;
                    dtpNgayKG.Enabled = true;
                    btnLuuLH.Enabled = true;
                    btnThemLH.Enabled = false;
                    btnXoaLH.Enabled = false;
                    lvwDanhSachLHCS.Enabled = false;
                }
                else
                {
                    btnSuaLH.Text = "Sửa";
                    btnSuaLH.ImageIndex = 2;
                    txtMaLH.Text = "";
                    txtTenLH.Text = "";
                    txtGVCN.Text = "";
                    txtKhoahoc.Text = "";
                    dtpNgayKG.Text = "";
                    txtTenLH.Enabled = false;
                    txtGVCN.Enabled = false;
                    txtKhoahoc.Enabled = false;
                    dtpNgayKG.Enabled = false;
                    btnLuuLH.Enabled = false;
                    btnThemLH.Enabled = true;
                    btnXoaLH.Enabled = true;
                    lvwDanhSachLHCS.Enabled = true;
                }
            }
        }
        #endregion

        #region Nut xoa
        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            if (lvwDanhSachLHCS.SelectedItems.Count == 0 || txtMaLH.Text=="")
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn chắc chắn là bạn muốn xóa lớp học này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        obj.XoaLop(txtMaLH.Text);
                        tbl = obj.GetDataTable("Lop");
                        LoadListview(tbl, lvwDanhSachLHCS);
                        treDanhsachLH.Nodes.Clear();
                        Loadtreeview(tbl, treDanhsachLH);
                        txtMaLH.Text = "";
                        txtTenLH.Text = "";
                        txtGVCN.Text = "";
                        txtKhoahoc.Text = "";
                        dtpNgayKG.Text = "";
                        MessageBox.Show("Đã xóa lớp học vừa chọn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Nut luu
        private void btnLuuLH_Click(object sender, EventArgs e)
        {
            #region luu moi
            if (btnThemLH.Text == "Hủy")
            {
                if (Kiemtra() == true)
                {
                    if (obj.KTMaLop(txtMaLH.Text) == false)
                    {
                        LuuThem();
                        btnThemLH.Text = "Thêm";
                        btnThemLH.ImageIndex = 0;
                        txtMaLH.Text = "";
                        txtTenLH.Text = "";
                        txtGVCN.Text = "";
                        txtKhoahoc.Text = "";
                        dtpNgayKG.Text = "";
                        txtMaLH.Enabled = false;
                        txtTenLH.Enabled = false;
                        txtGVCN.Enabled = false;
                        txtKhoahoc.Enabled = false;
                        dtpNgayKG.Enabled = false;
                        btnLuuLH.Enabled = false;
                        btnSuaLH.Enabled = true;
                        btnXoaLH.Enabled = true;
                        lvwDanhSachLHCS.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã lớp, vui lòng nhập lại mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLH.SelectAll();
                    }
                }
                else
                    return;
            }
            #endregion

            #region luu sua
            if (btnSuaLH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        LuuSua();
                        btnSuaLH.Text = "Sửa";
                        btnSuaLH.ImageIndex = 2;
                        txtMaLH.Text = "";
                        txtTenLH.Text = "";
                        txtGVCN.Text = "";
                        txtKhoahoc.Text = "";
                        dtpNgayKG.Text = "";
                        txtMaLH.Enabled = false;
                        txtTenLH.Enabled = false;
                        txtGVCN.Enabled = false;
                        txtKhoahoc.Enabled = false;
                        dtpNgayKG.Enabled = false;
                        btnLuuLH.Enabled = false;
                        btnThemLH.Enabled = true;
                        btnXoaLH.Enabled = true;
                        lvwDanhSachLHCS.Enabled = true;
                    }
                    else
                        return;
                }
                else
                {
                    btnSuaLH.Text = "Sửa";
                    btnSuaLH.ImageIndex = 2;
                    txtMaLH.Text = "";
                    txtTenLH.Text = "";
                    txtGVCN.Text = "";
                    txtKhoahoc.Text = "";
                    dtpNgayKG.Text = "";
                    txtMaLH.Enabled = false;
                    txtTenLH.Enabled = false;
                    txtGVCN.Enabled = false;
                    txtKhoahoc.Enabled = false;
                    dtpNgayKG.Enabled = false;
                    btnLuuLH.Enabled = false;
                    btnThemLH.Enabled = true;
                    btnXoaLH.Enabled = true;
                    lvwDanhSachLHCS.Enabled = true;
                }
            }
            #endregion
        }
        #endregion

        #endregion

        #region Kiem tra truoc khi nhap
        public Boolean Kiemtra()
        {
            if (txtMaLH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtTenLH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên lớp học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtKhoahoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khóa học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtGVCN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giáo viên chủ nhiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (System.DateTime.Now.Date < dtpNgayKG.Value.Date)
            {
                MessageBox.Show("Ngày khai giảng phải nhỏ hơn hoặc bằng với ngày hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion 

        #region Xu ly luu moi, luu sua, keypress khoa hoc

        #region Xu ly luu moi
        private void LuuThem()
        {
            try
            {
                obj.ThemLH(txtMaLH.Text.ToString(), txtTenLH.Text.ToString(), txtKhoahoc.Text.ToString(),txtGVCN.Text.ToString(),(DateTime)dtpNgayKG.Value);
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = txtMaLH.Text;
                lvwItem.SubItems.Add(txtTenLH.Text);
                lvwItem.SubItems.Add(txtKhoahoc.Text);
                lvwItem.SubItems.Add(txtGVCN.Text);
                lvwItem.SubItems.Add(dtpNgayKG.Text);
                lvwItem.ImageIndex = 0;
                lvwDanhSachLHCS.Items.Add(lvwItem);
                treDanhsachLH.Nodes.Clear();
                tbl = obj.GetDataTable("Lop");
                Loadtreeview(tbl, treDanhsachLH);
                lblLop.Text = "Tổng số lớp học là " + lvwDanhSachLHCS.Items.Count + " lớp học";
                MessageBox.Show("Lưu dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion 

        #region Xu ly luu sua
        private void LuuSua()
        {
            try
            {
                obj.SuaLH(txtMaLH.Text.ToString(), txtTenLH.Text.ToString(), txtKhoahoc.Text.ToString(), txtGVCN.Text.ToString(),(DateTime)dtpNgayKG.Value);
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = txtMaLH.Text;
                lvwItem.SubItems.Add(txtTenLH.Text);
                lvwItem.SubItems.Add(txtKhoahoc.Text);
                lvwItem.SubItems.Add(txtGVCN.Text);
                lvwItem.SubItems.Add(dtpNgayKG.Text);
                lvwItem.ImageIndex = 0;
                lvwDanhSachLHCS.Items.Add(lvwItem);
                MessageBox.Show("Lưu thay đổi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbl = obj.GetDataTable("Lop");
                LoadListview(tbl, lvwDanhSachLHCS);
                treDanhsachLH.Nodes.Clear();
                Loadtreeview(tbl, treDanhsachLH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region keypress
        private void txtKhoahoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar))&&(!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Khóa học chỉ được nhập số và ký tự dấu (-)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion

    }
}