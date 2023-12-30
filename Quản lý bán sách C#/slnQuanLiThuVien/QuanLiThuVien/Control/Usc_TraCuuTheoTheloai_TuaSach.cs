using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace QuanLiThuVien.Control
{
    public partial class Usc_TraCuuTheoTheloai_TuaSach : UserControl
    {
        public Usc_TraCuuTheoTheloai_TuaSach()
        {
            InitializeComponent();
        }

        #region các hàm xử lí

        void HienThiThongTinTuaSach()
        {
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();


            if (dt.Rows.Count > 0)
            {
                lvwTuaSach.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwTuaSach.Items.Add(i.ToString());
                    li.SubItems.Add(dr["MaTuaSach"].ToString());
                    li.SubItems.Add(dr["TenTuaSach"].ToString());
                    li.SubItems.Add(dr["MaTacGia"].ToString());
                    li.SubItems.Add(dr["MaTheLoai"].ToString());
                    li.Tag = dr["MaTuaSach"].ToString();
                    i++;
                }
            }
        }

        void HienThiThongTheLoai()
        {
            DataTable dt = new TheLoaiBLL().truyXuatDuLieuBang_TheLoai();


            if (dt.Rows.Count > 0)
            {
                lvwTheLoai.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwTheLoai.Items.Add(i.ToString());
                    li.SubItems.Add(dr["MaLoaiSach"].ToString());
                    li.SubItems.Add(dr["TenLoaiSach"].ToString());

                    li.Tag = dr["MaLoaiSach"].ToString();
                    i++;
                }
            }
        }

        void LoadTheLoai()
        {
            cboMaTheLoai.DisplayMember = "TenLoaiSach";
            cboMaTheLoai.ValueMember = "MaLoaiSach";
            cboMaTheLoai.DataSource = new TheLoaiBLL().truyXuatDuLieuBang_TheLoai();
        }

        void LoadTacGia()
        {
            cboMaTacGia.DisplayMember = "TenTacGia";
            cboMaTacGia.ValueMember = "MaTacGia";
            cboMaTacGia.DataSource = new TacGiaBLL().truyXuatDuLieuBang_TacGia();
        }



        void HienThiTuaSachTheoMa(string MaTuaSach)
        {
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTuaSach"].ToString() == MaTuaSach)
                    {
                        txtMaTuaSach.Text = dr["MaTuaSach"].ToString();
                        txtTenTuaSach.Text = dr["TenTuaSach"].ToString();
                        cboMaTacGia.SelectedValue = dr["MaTacGia"];
                        cboMaTheLoai.SelectedValue = dr["MaTheLoai"];
                        txtNDTomTat.Text = dr["NDTomTat"].ToString();

                    }
                }
            }
        }

        void HienThiTheLoaiTheoMa(string MaLoaiSach)
        {
            DataTable dt = new TheLoaiBLL().truyXuatDuLieuBang_TheLoai();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaLoaiSach"].ToString() == MaLoaiSach)
                    {
                        txtMaTheLoai.Text = dr["MaLoaiSach"].ToString();
                        txtTenTheLoai.Text = dr["TenLoaiSach"].ToString();


                    }
                }
            }
        }


        void XoaTuaSach(string MaTuaSach)
        {
            TuaSachBLL cls = new TuaSachBLL(MaTuaSach);
            int kq = cls.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTinTuaSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại.Có mã đầu sách thuộc Mã tựa sách này", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaTuaSach.Focus();
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTuaSach.Focus();
                        break;
                    }

            }
        }

        void ThemThongTinTuaSach(string MaTuaSach, string TenTuaSach, string MaTheLoai, string MaTacGia, string NDTomTat)
        {
            TuaSachBLL cls = new TuaSachBLL(MaTuaSach, TenTuaSach, MaTheLoai, MaTacGia, NDTomTat);

            int kq = cls.Them();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTinTuaSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("trùng mã tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTuaSach.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không Có tên thể loại ,Kiểm tra lại!!", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Không Có tên tác giả ,Kiểm tra lại!!", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        void CapNhatThongTinTuaSach(string MaTuaSach, string TenTuaSach, string MaTheLoai, string MaTacGia, string NDTomTat)
        {
            TuaSachBLL cls = new TuaSachBLL(MaTuaSach, TenTuaSach, MaTheLoai, MaTacGia, NDTomTat);

            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTinTuaSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Có Mã tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTuaSach.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không Có tên thể loại ,Kiểm tra lại!!", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Không Có tên tác giả ,Kiểm tra lại!!", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        bool KiemTraTheLoai(string MaTheLoai, string TenTheLoai)
        {
            bool bolMaTheLoai = false, bolTenTheLoai = false;
            if (txtMaTheLoai.Text.Trim() != "")
            {
                bolMaTheLoai = MaTheLoai.ToLower().Contains(txtMaTheLoai.Text.ToLower()) ? true : false;
            }
            if (txtTenTheLoai.Text.Trim() != "")
            {
                bolTenTheLoai = TenTheLoai.ToLower().Contains(txtTenTheLoai.Text.ToLower()) ? true : false;
            }
            
            if (bolMaTheLoai || bolTenTheLoai )
                return true;

            return false;
        }

        bool KiemTraTuaSach(string MaTuaSach, string TenTuaSach, string MaTheLoai, string MaTacGia)
        {
            bool bolMaTuaSach = false, bolTenTuaSach = false, bolMaTacGia = false, bolMaTheLoai = false;
            if (txtMaTuaSach.Text.Trim() != "")
            {
                bolMaTuaSach = MaTuaSach.ToLower().Contains(txtMaTuaSach.Text.ToLower()) ? true : false;
            }
            if (txtTenTuaSach.Text.Trim() != "")
            {
                bolTenTuaSach = TenTuaSach.ToLower().Contains(txtTenTuaSach.Text.ToLower()) ? true : false;
            }
            if (cboMaTacGia.SelectedValue.ToString() != "")
            {
                bolMaTacGia = MaTacGia.ToLower().Contains(cboMaTacGia.SelectedValue.ToString().ToLower()) ? true : false;
            }

            if (cboMaTheLoai.SelectedValue.ToString() != "")
            {
                bolMaTheLoai = MaTheLoai.ToLower().Contains(cboMaTheLoai.SelectedValue.ToString().ToLower()) ? true : false;
            }

            if (bolMaTuaSach || bolTenTuaSach || bolMaTacGia || bolMaTheLoai)
                return true;

            return false;
        }

        void TraCuuTuaSach()
        {
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();
            if (dt.Rows.Count > 0)
            {
                lvwTuaSach.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (KiemTraTuaSach(dr["MaTuaSach"].ToString(), dr["TenTuaSach"].ToString(), dr["MaTheLoai"].ToString(), dr["MaTacGia"].ToString()))
                    {
                        ListViewItem li = lvwTuaSach.Items.Add(i.ToString());
                        li.SubItems.Add(dr["MaTuaSach"].ToString());
                        li.SubItems.Add(dr["TenTuaSach"].ToString());
                        li.SubItems.Add(dr["MaTacGia"].ToString());
                        li.SubItems.Add(dr["MaTheLoai"].ToString());



                        lvwTuaSach.Tag = dr["MaTuaSach"].ToString();
                        i++;
                    }

                }
            }
        }

        void TraCuuTheLoai()
        {
            DataTable dt = new TheLoaiBLL().truyXuatDuLieuBang_TheLoai();
            if (dt.Rows.Count > 0)
            {
                lvwTheLoai.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (KiemTraTheLoai(dr["MaLoaiSach"].ToString(), dr["TenLoaiSach"].ToString()))
                    {
                        ListViewItem li = lvwTheLoai.Items.Add(i.ToString());
                        li.SubItems.Add(dr["MaLoaiSach"].ToString());
                        li.SubItems.Add(dr["TenLoaiSach"].ToString());




                        lvwTheLoai.Tag = dr["MaLoaiSach"].ToString();
                        i++;
                    }

                }
            }
        }

        void XoaTheLoai(string MaTheLoai)
        {
            TheLoaiBLL cls = new TheLoaiBLL(MaTheLoai);
            int kq = cls.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTheLoai();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại Mã thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTheLoai.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không thể xóa.Mã thể loại này c1 trong bảng tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTheLoai.Focus();
                        break;
                    }

            }
        }


        void CapNhatThongTheLoai(string MaTheLoai, string TenTheLoai)
        {
            TheLoaiBLL cls = new TheLoaiBLL(MaTheLoai, TenTheLoai);

            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTheLoai();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Có Mã thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTuaSach.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Có mã thể loại này trong tựa sách.không cập nhật  được", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

            }
        }

        void ThemThongTheLoai(string MaTheLoai, string TenTheLoai)
        {
            TheLoaiBLL cls = new TheLoaiBLL(MaTheLoai, TenTheLoai);

            int kq = cls.Them();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiThongTheLoai();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Mã thể loại đã tồn tại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTheLoai.Focus();
                        break;
                    }
                 
                   
            }
        }


        #endregion

        private void Usc_TraCuuTheoDauSach_Theloai_TuaSach_Load(object sender, EventArgs e)
        {
            HienThiThongTinTuaSach();
            HienThiThongTheLoai();
           
            LoadTacGia();
            LoadTheLoai();
            btnXoaTS.Enabled = false;
            btnCapNhatTS.Enabled = false;
            btnCapNhatTL.Enabled = false;
            btnXoaTL.Enabled = false;
        }

        private void lvwTuaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTuaSach.SelectedItems.Count > 0)
            {

                foreach (int i in lvwTuaSach.SelectedIndices)
                {
                    string MaTuaSach = lvwTuaSach.Items[i].Tag.ToString();
                    HienThiTuaSachTheoMa(MaTuaSach);
                    break;
                }
            }
            btnXoaTS.Enabled = true;
            btnCapNhatTS.Enabled = true;
            btnTraCuuTS.Enabled = false;
            btnLuuTS.Enabled = false;
        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            if (txtMaTuaSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã tựa sách", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTuaSach.Focus();
                return;
            }


            XoaTuaSach(txtMaTuaSach.Text.Trim());
            lvwTuaSach.Items.Clear();
            HienThiThongTinTuaSach();


        }

        private void btnThemMoiTS_Click(object sender, EventArgs e)
        {
            txtMaTuaSach.Clear();
            txtTenTuaSach.Clear();
            txtNDTomTat.Clear();
            btnTraCuuTS.Enabled = true;
            btnLuuTS.Enabled = true;
            btnXoaTS.Enabled = false;
            btnCapNhatTS.Enabled = false;
            HienThiThongTinTuaSach();
            txtMaTuaSach.Focus();
        }

        private void btnCapNhatTS_Click(object sender, EventArgs e)
        {
            if (txtMaTuaSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTuaSach.Focus();
                return;
            }
            if (txtTenTuaSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTuaSach.Focus();
                return;
            }

            if (cboMaTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaTacGia.Focus();
                return;
            }
            if (cboMaTheLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaTheLoai.Focus();
                return;
            }


            CapNhatThongTinTuaSach(txtMaTuaSach.Text.Trim(), txtTenTuaSach.Text.Trim(), cboMaTacGia.SelectedValue.ToString(), cboMaTheLoai.SelectedValue.ToString(), txtNDTomTat.Text.Trim());
        }

        private void btnLuuTS_Click(object sender, EventArgs e)
        {

            if (txtMaTuaSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTuaSach.Focus();
                return;
            }
            if (txtTenTuaSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTuaSach.Focus();
                return;
            }


            ThemThongTinTuaSach(txtMaTuaSach.Text.Trim(), txtTenTuaSach.Text.Trim(), cboMaTacGia.SelectedValue.ToString(), cboMaTheLoai.SelectedValue.ToString(), txtNDTomTat.Text.Trim());
        }

        private void btnTraCuuTS_Click(object sender, EventArgs e)
        {
            TraCuuTuaSach();
        }

        private void lvwTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTheLoai.SelectedItems.Count > 0)
            {

                foreach (int i in lvwTheLoai.SelectedIndices)
                {
                    string MaLoaiSach = lvwTheLoai.Items[i].Tag.ToString();
                    HienThiTheLoaiTheoMa(MaLoaiSach);
                    break;
                }
            }
            btnXoaTL.Enabled = true;
            btnCapNhatTL.Enabled = true;
            btnLuuTL.Enabled = false;
            btnTraCuuTL.Enabled = false;
        }

        private void btnThemMoiTL_Click(object sender, EventArgs e)
        {
            btnTraCuuTL.Enabled = true;
            btnLuuTL.Enabled = true;
            btnCapNhatTL.Enabled = false;
            btnXoaTL.Enabled = false;
            HienThiThongTheLoai();
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtMaTheLoai.Focus();

        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (txtMaTheLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã thể loại", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTheLoai.Focus();
                return;
            }


            XoaTheLoai(txtMaTheLoai.Text.Trim());
            lvwTheLoai.Items.Clear();
            HienThiThongTheLoai();
        }

        private void btnCapNhatTL_Click(object sender, EventArgs e)
        {
            if (txtMaTheLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTheLoai.Focus();
                return;
            }
            if (txtTenTheLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
                return;
            }


            CapNhatThongTheLoai(txtMaTheLoai.Text.Trim(), txtTenTheLoai.Text.Trim());
        }

        private void btnLuuTL_Click(object sender, EventArgs e)
        {
            if (txtMaTheLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTheLoai.Focus();
                return;
            }
            if (txtTenTheLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên thể loại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
                return;
            }


            ThemThongTheLoai(txtMaTheLoai.Text.Trim(), txtTenTheLoai.Text.Trim());
        }

        private void btnTraCuuTL_Click(object sender, EventArgs e)
        {
            TraCuuTheLoai();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
