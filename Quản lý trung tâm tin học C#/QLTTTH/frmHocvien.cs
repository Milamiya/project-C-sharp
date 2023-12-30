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
    public partial class frmHocvien : Form
    {
        public frmHocvien()
        {
            InitializeComponent();
        }

        clsQLTTTH obj = new clsQLTTTH();
        DataTable dt = new DataTable();
        #region Su kien load form, tree va list

        #region load form
        private void frmHocvien_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = obj.GetDataTable("Lop");
            dt = obj.GetDataTable("HocVien");
            Loadtreeview(tbl, treDSLHSV);
            Loadlistview(dt, lvwDanhsachHV);

           // goi du lieu ma lop len combobox malop
            cboMalop.DisplayMember = "TenLop";
            cboMalop.ValueMember = "MaLop";
            cboMalop.DataSource = obj.GetDataTable("Lop");
            cboMalop.SelectedIndex = -1;

            // goi du lieu ma lop len combobox ben tab xem ttsv
            cboMalopHV.DisplayMember = "TenLop";
            cboMalopHV.ValueMember = "MaLop";
            cboMalopHV.DataSource = obj.GetDataTable("Lop");
            cboMalopHV.SelectedIndex = -1;
        }
        #endregion

        #region loadtree
        void Loadtreeview(DataTable tblH, TreeView treL)
        {
            foreach (DataRow drwLop in tblH.Rows)
            {
                TreeNode nodeParent = new TreeNode();
                nodeParent.Text = "Tên Lớp: " + drwLop["TenLop"].ToString();
                nodeParent.Tag = drwLop;
                string Malop = drwLop["MaLop"].ToString();
                foreach (DataRow drw in tblH.Rows)
                {
                    if (drw["MaLop"].ToString().Equals(Malop))
                    {
                        TreeNode nodeChild = new TreeNode();
                        nodeChild.Text="Mã lớp: "+drw["MaLop"].ToString();
                        nodeParent.ImageIndex = 0;
                        nodeParent.Nodes.Add(nodeChild);
                    }
                }
                treDSLHSV.Nodes.Add(nodeParent);
            }
        }
        #endregion

        #region loadlist
        void Loadlistview(DataTable tbl, ListView lvw)
        {
            int a = 0;
            lvwDanhsachHV.Items.Clear();
            foreach (DataRow drw in tbl.Rows)
            {
                ListViewItem lvwItem = new ListViewItem();
                a++;
                lvwItem.Text = drw["MaHV"].ToString();
                lvwItem.SubItems.Add(drw["TenHV"].ToString());
                if ((Boolean)drw["Phai"] == true)
                    lvwItem.SubItems.Add("Nam");
                else
                    lvwItem.SubItems.Add("Nữ");
                string ngaysinh = Convert.ToDateTime(drw["NgaySinh"].ToString()).ToShortDateString();
                lvwItem.SubItems.Add(ngaysinh);
                lvwItem.SubItems.Add(drw["DiaChi"].ToString());
                lvwItem.SubItems.Add(drw["DienThoai"].ToString());
                lvwItem.SubItems.Add(drw["MaLop"].ToString());
                lvwItem.ImageIndex = 0;
                lvwDanhsachHV.Items.Add(lvwItem);
            }
            lblTonghocvien.Text = "Tổng số học viên là " + a.ToString() + " học viên";
        }
        #endregion

        #region loadlist xem hoc vien

        void loadlistxem(DataTable tbl, ListView lvw)
        {
            int a = 0;
            lvwHV.Items.Clear();
            foreach (DataRow drw in dt.Rows)
            {
                ListViewItem lvwItem = new ListViewItem();
                a++;
                lvwItem.Text = drw["MaHV"].ToString();
                lvwItem.SubItems.Add(drw["TenHV"].ToString());
                if ((Boolean)drw["Phai"] == true)
                    lvwItem.SubItems.Add("Nam");
                else
                    lvwItem.SubItems.Add("Nữ");
                string ngaysinh = Convert.ToDateTime(drw["NgaySinh"].ToString()).ToShortDateString();
                lvwItem.SubItems.Add(ngaysinh);
                lvwItem.SubItems.Add(drw["DiaChi"].ToString());
                lvwItem.SubItems.Add(drw["DienThoai"].ToString());
                lvwItem.SubItems.Add(drw["MaLop"].ToString());
                lvwItem.ImageIndex = 0;
                lvwHV.Items.Add(lvwItem);
            }
            if (a != 0)
                lblSohvxem.Text = "Tổng số học viên là " + a.ToString() + " học viên";
            else
                lblSohvxem.Text = "";
        }

        #endregion

        #endregion

        #region Xu ly su kien dong

        #region nut dong tab hieu chinh
        private void btnThoatHV_Click(object sender, EventArgs e)
        {
            #region Kiem tra them truoc khi thoat
            if (btnThemHV.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu học viên này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        if (obj.KTMaHV(txtMaHV.Text) == false)
                        {
                            LuuThem();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã học viên, vui lòng nhập lại mã học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaHV.SelectAll();
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
            if (btnSuaHV.Text == "Hủy")
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

            #region neu ca 2 dieu kien tren sai thi thuc hien lenh nay
            else
                this.Close();
            #endregion
        }
        #endregion
        private void frmHocvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng thông tin học viên?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }
        #region nut dong tab xem
        private void btnDongHVX_Click(object sender, EventArgs e)
        {
            #region kiem tra them truoc khi thoat
            if (btnThemHV.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu học viên này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        if (obj.KTMaHV(txtMaHV.Text) == false)
                        {
                            LuuThem();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã học viên, vui lòng nhập lại mã học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaHV.SelectAll();
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
            if (btnSuaHV.Text == "Hủy")
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

        #region Xu ly su kien chon list xem, chinh sua va cay

        #region Xu ly su kien chon listview Xem 
        private void lvwHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwHV.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwHV.SelectedItems[lvwHV.SelectedItems.Count - 1];
                if (item != null)
                {
                    txtMaHVX.Text = item.SubItems[0].Text;
                    txtTenHVX.Text = item.SubItems[1].Text;
                    if (item.SubItems[2].Text == "Nam")
                        rbtNamX.Checked = true;
                    else
                        rbtNuX.Checked = true;
                    dtpNgaysinhX.Text = item.SubItems[3].Text;
                    txtDCHV.Text = item.SubItems[4].Text;
                    txtDTHV.Text = item.SubItems[5].Text;
                    cboMalopHV.SelectedValue = item.SubItems[6].Text;   
                }
            }
        }
        #endregion

        #region Xu ly su kien chon cay
        private void treDSLHSV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int a = 0;
            DataRow drw;
            if (treDSLHSV.SelectedNode.Parent == null && treDSLHSV.SelectedNode != null)
            {
                drw = (DataRow)treDSLHSV.SelectedNode.Tag;
                lvwHV.Items.Clear();
                foreach (DataRow drwHVien in dt.Rows)
                {
                    if (drw["MaLop"].ToString().Equals(drwHVien["MaLop"]))
                    {
                        a++;
                        ListViewItem lvwitem = new ListViewItem();
                        lvwitem.Text = drwHVien["MaHV"].ToString();
                        lvwitem.SubItems.Add(drwHVien["TenHV"].ToString());
                        if ((Boolean)drwHVien["Phai"] == true)
                            lvwitem.SubItems.Add("Nam");
                        else
                            lvwitem.SubItems.Add("Nữ");
                        string ngaythang = Convert.ToDateTime(drwHVien["NgaySinh"].ToString()).ToShortDateString();
                        lvwitem.SubItems.Add(ngaythang);
                        lvwitem.SubItems.Add(drwHVien["Diachi"].ToString());
                        lvwitem.SubItems.Add(drwHVien["Dienthoai"].ToString());
                        lvwitem.SubItems.Add(drwHVien["MaLop"].ToString());
                        lvwitem.ImageIndex = 0;
                        lvwHV.Items.Add(lvwitem);
                    }
                }
                if (a != 0)
                    lblSohvxem.Text = "Số học viên là " + a.ToString() + " học viên";
                else
                    lblSohvxem.Text = "Lớp này chưa có học viên";
            }
        }
        #endregion

        #region Xu ly su kien chon listview hieu chinh
        private void lvwDanhsachHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhsachHV.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDanhsachHV.SelectedItems[lvwDanhsachHV.SelectedItems.Count - 1];
                if (item != null)
                {
                    txtMaHV.Text = item.SubItems[0].Text;
                    txtTenHV.Text = item.SubItems[1].Text;
                    if (item.SubItems[2].Text == "Nam")
                        rbtNam.Checked = true;
                    else
                        rbtNu.Checked = true;
                    dtpNgaysinh.Text = item.SubItems[3].Text;
                    txtDiachi.Text = item.SubItems[4].Text;
                    txtDienthoai.Text = item.SubItems[5].Text;
                    cboMalop.SelectedValue = item.SubItems[6].Text;
                }
            }
        }
        #endregion

        #endregion

        #region Kiem tra truoc khi nhap
        public Boolean Kiemtra()
        {
            if (txtMaHV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã học viên","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtTenHV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên học viên","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điện thoại học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboMalop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (rbtNam.Checked == false&&rbtNu.Checked==false)
            {
                MessageBox.Show("Vui lòng chọn giới tính nam hoặc nữ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            if (System.DateTime.Now.Year - dtpNgaysinh.Value.Year < 14)
            {
                MessageBox.Show("Năm sinh không được nhỏ hơn 14 tuổi","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion 

        #region Xu ly Luu moi, luu sua

        #region Xu ly luu moi
        private void LuuThem()
        {
            try
            {
                obj.ThemHV(txtMaHV.Text.ToString(), txtTenHV.Text.ToString(), rbtNam.Checked ? true : false, (DateTime)dtpNgaysinh.Value, txtDiachi.Text.ToString(), txtDienthoai.Text.ToString(), cboMalop.SelectedValue.ToString());
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = txtMaHV.Text;
                lvwItem.SubItems.Add(txtTenHV.Text);
                lvwItem.SubItems.Add(rbtNam.Checked ? "Nam" : "Nữ");
                lvwItem.SubItems.Add(dtpNgaysinh.Text);
                lvwItem.SubItems.Add(txtDiachi.Text);
                lvwItem.SubItems.Add(txtDienthoai.Text);
                lvwItem.SubItems.Add(cboMalop.Text);
                lvwItem.ImageIndex = 0;
                lvwDanhsachHV.Items.Add(lvwItem);
                lblTonghocvien.Text = " Tổng số học viên là " + lvwDanhsachHV.Items.Count + " học viên";
                dt = obj.GetDataTable("HocVien");
                loadlistxem(dt, lvwHV);
                Loadlistview(dt, lvwDanhsachHV);
                lvwHV.Items.Clear();
                lblSohvxem.Text = "";
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
                obj.SuaHV(txtMaHV.Text.ToString(),txtTenHV.Text.ToString(), rbtNam.Checked ? true : false, (DateTime)dtpNgaysinh.Value, txtDiachi.Text.ToString(), txtDienthoai.Text.ToString(), cboMalop.SelectedValue.ToString());
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = txtMaHV.Text;
                lvwItem.SubItems.Add(txtTenHV.Text);
                lvwItem.SubItems.Add(rbtNam.Checked ? "Nam" : "Nữ");
                lvwItem.SubItems.Add(dtpNgaysinh.Text);
                lvwItem.SubItems.Add(txtDiachi.Text);
                lvwItem.SubItems.Add(txtDienthoai.Text);
                lvwItem.SubItems.Add(cboMalop.Text);
                lvwItem.ImageIndex = 0;
                lvwDanhsachHV.Items.Add(lvwItem);
                MessageBox.Show("Lưu thay đổi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = obj.GetDataTable("HocVien");
                Loadlistview(dt, lvwDanhsachHV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #endregion

        #region Cac nut thi hanh lenh

        #region Su kien nut luu
        private void btnLuuHV_Click(object sender, EventArgs e)
        {
            #region luu moi
            if (btnThemHV.Text == "Hủy")
            {
                if (Kiemtra() == true)
                {
                    if (obj.KTMaHV(txtMaHV.Text) == false)
                    {
                        LuuThem();
                        btnThemHV.Text = "Thêm";
                        btnThemHV.ImageIndex = 1;
                        txtMaHV.Text = "";
                        txtTenHV.Text = "";
                        txtDiachi.Text = "";
                        txtDienthoai.Text = "";
                        dtpNgaysinh.Text = "";
                        rbtNam.Checked = false;
                        rbtNu.Checked = false;
                        cboMalop.SelectedIndex = -1;
                        txtMaHV.Enabled = false;
                        txtTenHV.Enabled = false;
                        txtDiachi.Enabled = false;
                        txtDienthoai.Enabled = false;
                        rbtNam.Enabled = false;
                        rbtNu.Enabled = false;
                        dtpNgaysinh.Enabled = false;
                        cboMalop.Enabled = false;
                        btnLuuHV.Enabled = false;
                        btnSuaHV.Enabled = true;
                        btnXoaHV.Enabled = true;
                        lvwDanhsachHV.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã học viên, vui lòng nhập lại mã học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaHV.SelectAll();
                    }
                }
                else
                    return;
            }
            #endregion

            #region luu sua
            if (btnSuaHV.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtra() == true)
                    {
                        LuuSua();
                        btnSuaHV.Text = "Sửa";
                        btnSuaHV.ImageIndex = 4;
                        txtMaHV.Text = "";
                        txtTenHV.Text = "";
                        txtDiachi.Text = "";
                        txtDienthoai.Text = "";
                        dtpNgaysinh.Text = "";
                        rbtNam.Checked = false;
                        rbtNu.Checked = false;
                        cboMalop.SelectedIndex = -1;
                        txtTenHV.Enabled = false;
                        txtDiachi.Enabled = false;
                        txtDienthoai.Enabled = false;
                        rbtNam.Enabled = false;
                        rbtNu.Enabled = false;
                        dtpNgaysinh.Enabled = false;
                        cboMalop.Enabled = false;
                        btnLuuHV.Enabled = false;
                        btnThemHV.Enabled = true;
                        btnXoaHV.Enabled = true;
                        lvwDanhsachHV.Enabled = true;
                    }
                    else
                        return;
                }
                else
                {
                    btnSuaHV.Text = "Sửa";
                    btnSuaHV.ImageIndex = 4;
                    txtMaHV.Text = "";
                    txtTenHV.Text = "";
                    txtDiachi.Text = "";
                    txtDienthoai.Text = "";
                    dtpNgaysinh.Text = "";
                    rbtNam.Checked = false;
                    rbtNu.Checked = false;
                    cboMalop.SelectedIndex = -1;
                    txtTenHV.Enabled = false;
                    txtDiachi.Enabled = false;
                    txtDienthoai.Enabled = false;
                    rbtNam.Enabled = false;
                    rbtNu.Enabled = false;
                    dtpNgaysinh.Enabled = false;
                    cboMalop.Enabled = false;
                    btnLuuHV.Enabled = false;
                    btnThemHV.Enabled = true;
                    btnXoaHV.Enabled = true;
                    lvwDanhsachHV.Enabled = true;
                }
            }
            #endregion
        }
        #endregion 

        #region Su kien nut xoa
        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            if (lvwDanhsachHV.SelectedItems.Count == 0 || txtMaHV.Text=="")
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn chắc chắn là bạn muốn xóa học viên này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        obj.XoaHV(txtMaHV.Text);
                        dt = obj.GetDataTable("HocVien");
                        Loadlistview(dt, lvwDanhsachHV);
                        loadlistxem(dt, lvwHV);
                        lvwHV.Items.Clear();
                        lblSohvxem.Text = "";
                        txtMaHV.Text = "";
                        txtTenHV.Text = "";
                        txtDiachi.Text = "";
                        txtDienthoai.Text = "";
                        dtpNgaysinh.Text = "";
                        if (rbtNam.Checked == true)
                            rbtNam.Checked = false;
                        else
                            rbtNu.Checked = false;
                        MessageBox.Show("Đã xóa học viên vừa chọn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Su kien nut them
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            if (btnThemHV.Text == "Thêm")
            {
                btnThemHV.Text = "Hủy";
                btnThemHV.ImageIndex = 6;
                txtMaHV.Text = "";
                txtTenHV.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
                if (rbtNam.Checked == true)
                    rbtNam.Checked = false;
                else
                    rbtNu.Checked = false;
                dtpNgaysinh.Text = "";
                cboMalop.SelectedIndex = -1;
                txtMaHV.Enabled = true;
                txtTenHV.Enabled = true;
                txtDiachi.Enabled = true;
                txtDienthoai.Enabled = true;
                rbtNam.Enabled = true;
                rbtNu.Enabled = true;
                dtpNgaysinh.Enabled = true;
                cboMalop.Enabled = true;
                btnLuuHV.Enabled = true;
                btnSuaHV.Enabled = false;
                btnXoaHV.Enabled = false;
                lvwDanhsachHV.Enabled = false;

            }
            else
            {
                btnThemHV.Text = "Thêm";
                btnThemHV.ImageIndex = 1;
                txtMaHV.Text = "";
                txtTenHV.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
                dtpNgaysinh.Text = "";
                cboMalop.SelectedIndex = -1;
                txtMaHV.Enabled = false;
                txtTenHV.Enabled = false;
                txtDiachi.Enabled = false;
                txtDienthoai.Enabled = false;
                rbtNam.Enabled = false;
                rbtNu.Enabled = false;
                dtpNgaysinh.Enabled = false;
                cboMalop.Enabled = false;
                btnLuuHV.Enabled = false;
                btnSuaHV.Enabled = true;
                btnXoaHV.Enabled = true;
                lvwDanhsachHV.Enabled = true;
            }
        }
        #endregion 

        #region Su kien nut sua
        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            if (lvwDanhsachHV.SelectedItems.Count == 0 || txtMaHV.Text=="")
            {
                MessageBox.Show("Vui lòng chọn học viên cần sửa chữa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnSuaHV.Text == "Sửa")
                {
                    btnSuaHV.Text = "Hủy";
                    btnSuaHV.ImageIndex = 6;
                    txtTenHV.Enabled = true;
                    txtDiachi.Enabled = true;
                    txtDienthoai.Enabled = true;
                    rbtNam.Enabled = true;
                    rbtNu.Enabled = true;
                    dtpNgaysinh.Enabled = true;
                    cboMalop.Enabled = true;
                    btnLuuHV.Enabled = true;
                    btnThemHV.Enabled = false;
                    btnXoaHV.Enabled = false;
                    lvwDanhsachHV.Enabled = false;
                }
                else
                {
                    btnSuaHV.Text = "Sửa";
                    btnSuaHV.ImageIndex = 4;
                    txtMaHV.Text = "";
                    txtTenHV.Text = "";
                    txtDiachi.Text = "";
                    txtDienthoai.Text = "";
                    dtpNgaysinh.Text = "";
                    cboMalop.SelectedIndex = -1;
                    txtTenHV.Enabled = false;
                    txtDiachi.Enabled = false;
                    txtDienthoai.Enabled = false;
                    rbtNam.Enabled = false;
                    rbtNu.Enabled = false;
                    dtpNgaysinh.Enabled = false;
                    cboMalop.Enabled = false;
                    btnLuuHV.Enabled = false;
                    btnThemHV.Enabled = true;
                    btnXoaHV.Enabled = true;
                    lvwDanhsachHV.Enabled = true;
                }
            }
        }
        #endregion

        #region Su kien nut xem tat ca
        private void btnXemtatca_Click(object sender, EventArgs e)
        {
            lvwHV.Items.Clear();
            loadlistxem(dt, lvwHV);
        }
        #endregion

        #endregion

        #region Hieu chinh kieu nhin trong listview

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachHV.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachHV.View = View.Details;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachHV.View = View.SmallIcon;
        }

        private void tilesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lvwDanhsachHV.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDanhsachHV.View = View.List;
        }
        #endregion

        #region Hien form tim kiem hoc vien va xu ly su kien khong cho nhap ky tu trong text DT
        private void btnTimHV_Click(object sender, EventArgs e)
        {
            frmTimHV hocvien = new frmTimHV();
            hocvien.ShowDialog();
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}