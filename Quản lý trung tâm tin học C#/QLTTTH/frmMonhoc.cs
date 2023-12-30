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
    public partial class frmMonhoc : Form
    {
        public frmMonhoc()
        {
            InitializeComponent();
        }
        DataTable tblMH = new DataTable();
        clsQLTTTH obj = new clsQLTTTH();

        #region Su kien thoat
        private void frmMonhoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng thông tin môn học?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }

        #region nut thoat tab hieu chinh
        private void btnThoatMH_Click(object sender, EventArgs e)
        {
            #region Kiem tra nut them truoc khi thoat
            if (btnThemMH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu môn học này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        if (obj.KTMaMH(txtMaMH.Text) == false)
                        {
                            LuuThem();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã môn học, vui lòng nhập lại mã môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaMH.SelectAll();
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

            #region Kiem tra nut sua truoc khi thoat
            if (btnSuaMH.Text == "Hủy")
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

            #region Neu ca 2 DK phia tren sai thi thuc hien lenh nay
            else
                this.Close();
            #endregion
        }
        #endregion

        #region nut thoat tab xem mon hoc
        private void btnThoatMHX_Click(object sender, EventArgs e)
        {
            #region Kiem tra nut them truoc khi thoat
            if (btnThemMH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu môn học này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        if (obj.KTMaMH(txtMaMH.Text) == false)
                        {
                            LuuThem();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã môn học, vui lòng nhập lại mã môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaMH.SelectAll();
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

            #region Kiem tra nut sua truoc khi thoat
            if (btnSuaMH.Text == "Hủy")
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

            #region Neu ca 2 DK phia tren sai thi thuc hien lenh nay
            else
                this.Close();
            #endregion
        }
        #endregion

        #endregion

        #region Su kien Load tree, load list, form

        #region Load tree
        void Loadtreeview(DataTable tblMonhoc, TreeView treMH)
        {
            foreach (DataRow drwMH in tblMH.Rows)
            {
                TreeNode nodecha = new TreeNode();
                nodecha.Text = "Tên Môn Học: " + drwMH["TenMH"].ToString();
                nodecha.Tag = drwMH;
                nodecha.ImageIndex = 0;
                treXemMH.Nodes.Add(nodecha);
            }
        }
        #endregion

        #region Load form
        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            tblMH = obj.GetDataTable("Monhoc");
            Loadtreeview(tblMH, treXemMH);
            Loadlistview(tblMH, lvwDanhsachMH);
        }
        #endregion

        #region Load list
        void Loadlistview(DataTable tblMH, ListView lvwMon)
        {
            int a = 0;
            lvwDanhsachMH.Items.Clear();
            ListViewItem lvwItem;
            foreach (DataRow drwMH in tblMH.Rows)
            {
                a++;
                lvwItem = new ListViewItem();
                lvwItem.Text = drwMH["MaMH"].ToString();
                lvwItem.SubItems.Add(drwMH["TenMH"].ToString());
                lvwItem.SubItems.Add(drwMH["Sotiet"].ToString());
                lvwItem.ImageIndex = 0;
                lvwDanhsachMH.Items.Add(lvwItem);
            }
            lblMonhoc.Text = "Tổng số môn học là " + a.ToString() + " môn học";
        }
        #endregion

        #endregion

        #region Ham xem toan bo danh sach
        void HientoanboMH(DataTable tblBang, ListView lvwDanhsach)
        {
            int a = 0;
            lvwXemMH.Items.Clear();
            ListViewItem lvwItem;
            foreach (DataRow drwMH in tblMH.Rows)
            {
                a++;
                lvwItem = new ListViewItem();
                lvwItem.Text = drwMH["MaMH"].ToString();
                lvwItem.SubItems.Add(drwMH["TenMH"].ToString());
                lvwItem.SubItems.Add(drwMH["Sotiet"].ToString());
                lvwItem.ImageIndex = 0;
                lvwXemMH.Items.Add(lvwItem);
            }
            lblMonhocX.Text = "Tổng số môn học là " + a.ToString() + " môn học";
        }
        #endregion

        #region Su kien chon tree va list

        #region Chon tree
        private void treXemMH_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow drw;
            if (treXemMH.SelectedNode != null && treXemMH.SelectedNode.Parent == null)
            {
                    drw = (DataRow)treXemMH.SelectedNode.Tag;
                    lvwXemMH.Items.Clear();
                    lblMonhocX.Text = "";
                    foreach (DataRow drwMH in tblMH.Rows)
                    {
                        if (drw["MaMH"].ToString().Equals(drwMH["MaMH"]))
                        {
                            txtMaMHX.Text = drwMH["MaMH"].ToString();
                            txtTenMHX.Text = drwMH["TenMH"].ToString();
                            txtSotietX.Text = drwMH["Sotiet"].ToString();
                        }
                    }   
            }
        }
        #endregion

        #region chon list Xem
        private void lvwXemMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwXemMH.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwXemMH.SelectedItems[lvwXemMH.SelectedItems.Count - 1];
                if (item != null)
                {
                    txtMaMHX.Text = item.SubItems[0].Text;
                    txtTenMHX.Text = item.SubItems[1].Text;
                    txtSotietX.Text = item.SubItems[2].Text;
                }
            }
        }
        #endregion

        #region Chon list chinh sua
        private void lvwDanhsachMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhsachMH.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDanhsachMH.SelectedItems[lvwDanhsachMH.SelectedItems.Count - 1];
                if (item != null)
                {
                    txtMaMH.Text = item.SubItems[0].Text;
                    txtTenMH.Text = item.SubItems[1].Text;
                    txtSotiet.Text = item.SubItems[2].Text;
                }
            }
        }
        #endregion

        #endregion

        #region Kiem tra truoc khi nhap
        public Boolean Kiemtra()
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtSotiet.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiết học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion 

        #region Hieu chinh kieu nhin list view
        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachMH.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachMH.View = View.Details;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachMH.View = View.SmallIcon;
        }

        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachMH.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachMH.View = View.List;
        }
        #endregion

        #region Xu ly luu moi, luu sua

        #region Xu ly luu moi
        private void LuuThem()
        {
            try
            {
                obj.ThemMH(txtMaMH.Text.ToString(), txtTenMH.Text.ToString(), txtSotiet.Text.ToString());
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = txtMaMH.Text;
                lvwItem.SubItems.Add(txtTenMH.Text);
                lvwItem.SubItems.Add(txtSotiet.Text);
                lvwItem.ImageIndex = 0;
                lvwDanhsachMH.Items.Add(lvwItem);
                treXemMH.Nodes.Clear();
                tblMH = obj.GetDataTable("MonHoc");
                Loadtreeview(tblMH, treXemMH);
                lblMonhoc.Text = "Tổng số môn học là " + lvwDanhsachMH.Items.Count + " môn học";
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
                obj.SuaMH(txtMaMH.Text.ToString(), txtTenMH.Text.ToString(), txtSotiet.Text.ToString());
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = txtMaMH.Text;
                lvwItem.SubItems.Add(txtTenMH.Text);
                lvwItem.SubItems.Add(txtSotiet.Text);
                lvwItem.ImageIndex = 0;
                lvwDanhsachMH.Items.Add(lvwItem);
                MessageBox.Show("Lưu thay đổi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tblMH = obj.GetDataTable("MonHoc");
                Loadlistview(tblMH, lvwDanhsachMH);
                treXemMH.Nodes.Clear();
                Loadtreeview(tblMH, treXemMH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #endregion

        #region Cac nut thi hanh lenh

        #region Nut them
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (btnThemMH.Text == "Thêm")
            {
                btnThemMH.Text = "Hủy";
                btnThemMH.ImageIndex = 6;
                txtMaMH.Text = "";
                txtTenMH.Text = "";
                txtSotiet.Text = "";
                txtMaMH.Enabled = true;
                txtTenMH.Enabled = true;
                txtSotiet.Enabled = true;
                btnLuuMH.Enabled = true;
                btnSuaMH.Enabled = false;
                btnXoaMH.Enabled = false;
                lvwDanhsachMH.Enabled = false;
            }
            else
            {
                btnThemMH.Text = "Thêm";
                btnThemMH.ImageIndex = 0;
                txtMaMH.Text = "";
                txtTenMH.Text = "";
                txtSotiet.Text = "";
                txtMaMH.Enabled = false;
                txtTenMH.Enabled = false;
                txtSotiet.Enabled = false;
                btnLuuMH.Enabled = false;
                btnSuaMH.Enabled = true;
                btnXoaMH.Enabled = true;
                lvwDanhsachMH.Enabled = true;
            }
        }
        #endregion

        #region Nut sua
        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (lvwDanhsachMH.SelectedItems.Count == 0 || txtMaMH.Text=="")
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa chữa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnSuaMH.Text == "Sửa")
                {
                    btnSuaMH.Text = "Hủy";
                    btnSuaMH.ImageIndex = 6;
                    txtTenMH.Enabled = true;
                    txtSotiet.Enabled = true;
                    btnLuuMH.Enabled = true;
                    btnThemMH.Enabled = false;
                    btnXoaMH.Enabled = false;
                    lvwDanhsachMH.Enabled = false;
                }
                else
                {
                    btnSuaMH.Text = "Sửa";
                    btnSuaMH.ImageIndex = 4;
                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtSotiet.Text = "";
                    txtTenMH.Enabled = false;
                    txtSotiet.Enabled = false;
                    btnLuuMH.Enabled = false;
                    btnThemMH.Enabled = true;
                    btnXoaMH.Enabled = true;
                    lvwDanhsachMH.Enabled = true;
                }
            }
        }
        #endregion

        #region nut luu
        private void btnLuuMH_Click(object sender, EventArgs e)
        {
            #region luu moi
            if (btnThemMH.Text == "Hủy")
            {
                if (Kiemtra() == true)
                {
                    if (obj.KTMaMH(txtMaMH.Text) == false)
                    {
                        LuuThem();
                        btnThemMH.Text = "Thêm";
                        btnThemMH.ImageIndex = 0;
                        txtMaMH.Text = "";
                        txtTenMH.Text = "";
                        txtSotiet.Text = "";
                        txtMaMH.Enabled = false;
                        txtTenMH.Enabled = false;
                        txtSotiet.Enabled = false;
                        btnLuuMH.Enabled = false;
                        btnSuaMH.Enabled = true;
                        btnXoaMH.Enabled = true;
                        lvwDanhsachMH.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã môn học, vui lòng nhập lại mã môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaMH.SelectAll();
                    }
                }
                else
                    return;
            }
            #endregion

            #region luu sua
            if (btnSuaMH.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        LuuSua();
                        btnSuaMH.Text = "Sửa";
                        btnSuaMH.ImageIndex = 4;
                        txtMaMH.Text = "";
                        txtTenMH.Text = "";
                        txtSotiet.Text = "";
                        txtTenMH.Enabled = false;
                        txtSotiet.Enabled = false;
                        btnLuuMH.Enabled = false;
                        btnXoaMH.Enabled = true;
                        btnThemMH.Enabled = true;
                        lvwDanhsachMH.Enabled = true;
                    }
                    else
                        return;
                }
                else
                {
                    btnSuaMH.Text = "Sửa";
                    btnSuaMH.ImageIndex = 4;
                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtSotiet.Text = "";
                    txtTenMH.Enabled = false;
                    txtSotiet.Enabled = false;
                    btnLuuMH.Enabled = false;
                    btnXoaMH.Enabled = true;
                    btnThemMH.Enabled = true;
                    lvwDanhsachMH.Enabled = true;
                }
            }
            #endregion
        }
        #endregion

        #region Nut xoa
        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (lvwDanhsachMH.SelectedItems.Count == 0 || txtMaMH.Text=="")
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn chắc chắn là bạn muốn xóa môn học này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        obj.XoaMH(txtMaMH.Text);
                        tblMH = obj.GetDataTable("MonHoc");
                        Loadlistview(tblMH, lvwDanhsachMH);
                        treXemMH.Nodes.Clear();
                        Loadtreeview(tblMH, treXemMH);
                        txtMaMH.Text = "";
                        txtTenMH.Text = "";
                        txtSotiet.Text = "";
                        MessageBox.Show("Đã xóa môn học vừa chọn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Nut tim
        private void btnTimMH_Click(object sender, EventArgs e)
        {
            frmTimMH monhoc = new frmTimMH();
            monhoc.ShowDialog();
        }
        #endregion

        #region Nut hien toan bo
        private void btnHientatcaMH_Click(object sender, EventArgs e)
        {
            lvwXemMH.Items.Clear();
            HientoanboMH(tblMH, lvwXemMH);
        }
        #endregion

        #region KeyPress so tiet
        private void txtSotiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Số tiết không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion


    }
}