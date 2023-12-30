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
    public partial class frmKetqua : Form
    {
        public frmKetqua()
        {
            InitializeComponent();
        }
        clsQLTTTH obj = new clsQLTTTH();
        DataTable tbl = new DataTable();

        #region Xu ly thoat
        private void frmKetqua_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng kết quả học tập?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }

        #region nut thoat
        private void button5_Click(object sender, EventArgs e)
        {
            #region Kiem tra them truoc khi thoat
            if (btnThemKQ.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu kết quả của học viên này không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    if (Kiemtratruocluu() == true)
                    {
                        LuuThem();
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

            #region Kiem tra sua truoc khi thoat
            if (btnSuaKQ.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == d)
                {
                    if (Kiemtratruocluu() == true)
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

            #region Neu ca 2 DK tren deu sai thi thuc hien lenh nay
            else
                this.Close();
            #endregion
        }
        #endregion

        #endregion

        #region Su kien load form va listview

        #region Load form
        private void frmKetqua_Load(object sender, EventArgs e)
        {
            tbl = obj.GetDataTable("Diem");
            LoadListview(tbl, lvwKetquaHT);

            cboMaHVK.DisplayMember = "MaHV";
            cboMaHVK.ValueMember = "MaHV";
            cboMaHVK.DataSource = obj.GetDataTable("HocVien");
            cboMaHVK.SelectedIndex = -1;

            DataSet dsMH = obj.Getdataset("MonHoc");
            cboMaMHK.DataSource = dsMH.Tables[0];
            cboMaMHK.DisplayMember = "TenMH";
            cboMaMHK.ValueMember = "MaMH";
            cboMaMHK.SelectedIndex = -1;
        }
        #endregion

        #region Load list
        void LoadListview(DataTable tbl, ListView lvw)
        {
            int a = 0;
            lvwKetquaHT.Items.Clear();
            ListViewItem lvwItem;
            foreach (DataRow drw in tbl.Rows)
            {
                a++;
                lvwItem = new ListViewItem();
                lvwItem.Text = drw["MaHV"].ToString();
                lvwItem.SubItems.Add(drw["MaMH"].ToString());
                lvwItem.SubItems.Add(drw["LanThi"].ToString());
                lvwItem.SubItems.Add(drw["Diem"].ToString());
                lvwItem.ImageIndex = 0;
                lvwKetquaHT.Items.Add(lvwItem);
            }
            lblKetqua.Text = "Có tổng số " + a.ToString() + " kết quả học tập";
        }
        #endregion

        #endregion

        #region Xu ly chon list, goi form xem kQ, kiem tra nhap text lanthi

        #region Xu ly chon list
        private void lvwKetquaHT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwKetquaHT.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwKetquaHT.SelectedItems[lvwKetquaHT.SelectedItems.Count - 1];
                if (item != null)
                {
                    cboMaHVK.SelectedValue = item.SubItems[0].Text;
                    cboMaMHK.SelectedValue = item.SubItems[1].Text;
                    txtLanthi.Text = item.SubItems[2].Text;
                    txtDiem.Text = item.SubItems[3].Text;
                }
            }
        }
        #endregion

        #region Xu ly nut xem goi form xem KQ
        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            frmTimKQ kq = new frmTimKQ();
            kq.ShowDialog();
        }
        #endregion

        #region Su kien keypress cua text lan thi va diem

        #region keypress lan thi
        private void txtLanthi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Lần thi không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region keypress diem
        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Điểm chỉ được phép nhập số và ký tự dấu (.)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion

        #region kiem tra diem khi luu
        bool Kiemtradiemnhap()
        {
            try
            {
                double Mark = Convert.ToDouble(txtDiem.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Điểm chỉ được phép nhập số và ký tự dấu (.)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.SelectAll();
                return false;
            }
        }
        #endregion

        #endregion

        #region Kiem tra truoc luu
        public bool Kiemtratruocluu()
        {
            if (txtDiem.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập điểm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (Convert.ToDouble(txtDiem.Text) < 0 || Convert.ToDouble(txtDiem.Text) > 10)
            {
                MessageBox.Show("Điểm chỉ được phép nhập từ 0 đến 10", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiem.SelectAll();
                return false;
            }
            if (txtLanthi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập lần thi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (Convert.ToInt32(txtLanthi.Text) <=0||Convert.ToInt32(txtLanthi.Text)>=4)
            {
                MessageBox.Show("Lần thi phải lớn hơn 0 và nhỏ hơn 4", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLanthi.SelectAll();
                return false;
            }
            if (cboMaHVK.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboMaMHK.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tên môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion 

        #region Xu ly luu moi, luu sua

        #region Luu moi
        private void LuuThem()
        {
            try
            {
                obj.ThemKQ(cboMaHVK.SelectedValue.ToString(), cboMaMHK.SelectedValue.ToString(), txtLanthi.Text.ToString(), txtDiem.Text.ToString());
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = cboMaHVK.Text;
                lvwItem.SubItems.Add(cboMaMHK.Text);
                lvwItem.SubItems.Add(txtLanthi.Text);
                lvwItem.SubItems.Add(txtDiem.Text);
                lvwItem.ImageIndex = 0;
                lvwKetquaHT.Items.Add(lvwItem);
                lblKetqua.Text = "Có tổng số " + lvwKetquaHT.Items.Count + " kết quả học tập";
                tbl = obj.GetDataTable("Diem");
                LoadListview(tbl, lvwKetquaHT);
                MessageBox.Show("Lưu dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Luu sua
        private void LuuSua()
        {
            try
            {
                obj.SuaKQ(cboMaHVK.SelectedValue.ToString(), cboMaMHK.SelectedValue.ToString(), txtLanthi.Text.ToString(), txtDiem.Text.ToString());
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = cboMaHVK.Text;
                lvwItem.SubItems.Add(cboMaMHK.Text);
                lvwItem.SubItems.Add(txtLanthi.Text);
                lvwItem.SubItems.Add(txtDiem.Text);
                lvwItem.ImageIndex = 0;
                lvwKetquaHT.Items.Add(lvwItem);
                MessageBox.Show("Lưu thay đổi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbl = obj.GetDataTable("Diem");
                LoadListview(tbl, lvwKetquaHT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #endregion

        #region Xu ly cac nut them, sua, luu, xoa

        #region Nut them
        private void btnThemKQ_Click(object sender, EventArgs e)
        {
            if (btnThemKQ.Text == "Thêm")
            {
                btnThemKQ.Text = "Hủy";
                btnThemKQ.ImageIndex = 6;
                txtLanthi.Text = "";
                txtDiem.Text = "";
                cboMaHVK.SelectedIndex = -1;
                cboMaMHK.SelectedIndex = -1;
                cboMaHVK.Enabled = true;
                cboMaMHK.Enabled = true;
                txtLanthi.Enabled = true;
                txtDiem.Enabled = true;
                btnLuu.Enabled = true;
                lvwKetquaHT.Enabled = false;
                btnSuaKQ.Enabled = false;
                btnXoaKQ.Enabled = false;
            }
            else
            {
                btnThemKQ.Text = "Thêm";
                btnThemKQ.ImageIndex = 2;
                txtLanthi.Text = "";
                txtDiem.Text = "";
                cboMaHVK.SelectedIndex = -1;
                cboMaMHK.SelectedIndex = -1;
                cboMaHVK.Enabled = false;
                cboMaMHK.Enabled = false;
                txtLanthi.Enabled = false;
                txtDiem.Enabled = false;
                btnLuu.Enabled = false;
                lvwKetquaHT.Enabled = true;
                btnXoaKQ.Enabled = true;
                btnSuaKQ.Enabled = true;
            }
        }
        #endregion

        #region Nut sua
        private void btnSuaKQ_Click(object sender, EventArgs e)
        {
            if (lvwKetquaHT.SelectedItems.Count==0 || txtLanthi.Text=="")
            {
                MessageBox.Show("Vui lòng chọn kết quả của học viên cần sửa chữa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnSuaKQ.Text == "Sửa")
                {
                    btnSuaKQ.Text = "Hủy";
                    btnSuaKQ.ImageIndex = 6;
                    txtDiem.Enabled = true;
                    btnLuu.Enabled = true;
                    lvwKetquaHT.Enabled = false;
                    btnThemKQ.Enabled = false;
                    btnXoaKQ.Enabled = false;
                }
                else
                {
                    btnSuaKQ.Text = "Sửa";
                    btnSuaKQ.ImageIndex = 3;
                    txtDiem.Text = "";
                    txtLanthi.Text = "";
                    cboMaHVK.SelectedIndex = -1;
                    cboMaMHK.SelectedIndex = -1;
                    txtDiem.Enabled = false;
                    btnLuu.Enabled = false;
                    lvwKetquaHT.Enabled = true;
                    btnXoaKQ.Enabled = true;
                    btnThemKQ.Enabled = true;
                }
            }
        }
        #endregion

        #region Nut luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            #region luu moi
            if (btnThemKQ.Text == "Hủy")
            {
                if (Kiemtradiemnhap() == true && Kiemtratruocluu() == true) 
                {
                    LuuThem();
                    btnThemKQ.Text = "Thêm";
                    btnThemKQ.ImageIndex = 2;
                    txtDiem.Text = "";
                    txtLanthi.Text = "";
                    cboMaHVK.SelectedIndex = -1;
                    cboMaMHK.SelectedIndex = -1;
                    cboMaHVK.Enabled = false;
                    cboMaMHK.Enabled = false;
                    txtLanthi.Enabled = false;
                    txtDiem.Enabled = false;
                    btnLuu.Enabled = false;
                    lvwKetquaHT.Enabled = true;
                    btnXoaKQ.Enabled = true;
                    btnSuaKQ.Enabled = true;
                }
                else
                    return;
            }
            #endregion

            #region luu khi sua
            if (btnSuaKQ.Text == "Hủy")
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    if (Kiemtradiemnhap() == true && Kiemtratruocluu() == true)
                    {
                        LuuSua();
                        btnSuaKQ.Text = "Sửa";
                        btnSuaKQ.ImageIndex = 3;
                        txtDiem.Text = "";
                        txtLanthi.Text = "";
                        cboMaHVK.SelectedIndex = -1;
                        cboMaMHK.SelectedIndex = -1;
                        txtDiem.Enabled = false;
                        btnLuu.Enabled = false;
                        lvwKetquaHT.Enabled = true;
                        btnXoaKQ.Enabled = true;
                        btnThemKQ.Enabled = true;
                    }
                    else
                        return;
                }
                else
                {
                    btnSuaKQ.Text = "Sửa";
                    btnSuaKQ.ImageIndex = 3;
                    txtDiem.Text = "";
                    txtLanthi.Text = "";
                    cboMaHVK.SelectedIndex = -1;
                    cboMaMHK.SelectedIndex = -1;
                    txtDiem.Enabled = false;
                    btnLuu.Enabled = false;
                    lvwKetquaHT.Enabled = true;
                    btnXoaKQ.Enabled = true;
                    btnThemKQ.Enabled = true;
                }
            }
            #endregion
        }
        #endregion

        #region Nut xoa
        private void btnXoaKQ_Click(object sender, EventArgs e)
        {
            if (lvwKetquaHT.SelectedItems.Count == 0 ||txtLanthi.Text=="")
            {
                MessageBox.Show("Vui lòng chọn kết quả của học viên cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn chắc chắn là bạn muốn xóa kết quả học tập của học viên này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        obj.XoaKQ(cboMaHVK.SelectedValue.ToString());
                        tbl = obj.GetDataTable("Diem");
                        LoadListview(tbl, lvwKetquaHT);
                        txtDiem.Text = "";
                        txtLanthi.Text = "";
                        cboMaHVK.SelectedIndex = -1;
                        cboMaMHK.SelectedIndex = -1;
                        MessageBox.Show("Đã xóa hoàn toàn kết quả của học viên vừa chọn trong danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Xu ly kieu nhin trong list
        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwKetquaHT.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwKetquaHT.View = View.Details;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwKetquaHT.View = View.SmallIcon;
        }

        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwKetquaHT.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwKetquaHT.View = View.List;
        }
        #endregion

    }
}