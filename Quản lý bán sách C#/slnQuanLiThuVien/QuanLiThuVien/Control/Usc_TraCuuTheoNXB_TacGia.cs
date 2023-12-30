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
    public partial class Usc_TraCuuTheoNXB_TacGia : UserControl
    {
        public Usc_TraCuuTheoNXB_TacGia()
        {
            InitializeComponent();
        }


        #region các hàm xử lí
        void HienThiNSX()
        {
            DataTable dt = new NhaXuatBanBLL().truyXuatDuLieuBang_NhaXuatBan();


            if (dt.Rows.Count > 0)
            {
                lvwNXB.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwNXB.Items.Add(i.ToString());
                    li.SubItems.Add(dr["MaNSX"].ToString());
                    li.SubItems.Add(dr["TenNSX"].ToString());

                    li.Tag = dr["MaNSX"].ToString();
                    i++;
                }
            }
        }

        void HienThiTacGia()
        {
            DataTable dt = new TacGiaBLL().truyXuatDuLieuBang_TacGia();


            if (dt.Rows.Count > 0)
            {
                lvwTacGia.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwTacGia.Items.Add(i.ToString());
                    li.SubItems.Add(dr["MaTacGia"].ToString());
                    li.SubItems.Add(dr["TenTacGia"].ToString());

                    li.Tag = dr["MaTacGia"].ToString();
                    i++;
                }
            }
        }

        void HienThiTacGiaTheoMa(string MaTacGia)
        {
            DataTable dt = new TacGiaBLL().truyXuatDuLieuBang_TacGia();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTacGia"].ToString() == MaTacGia)
                    {
                        txtMaTacGia.Text = dr["MaTacGia"].ToString();
                        txtTenTG.Text = dr["TenTacGia"].ToString();



                    }
                }
            }
        }


        void HienThiNSXTheoMa(string MaNSX)
        {
            DataTable dt = new NhaXuatBanBLL().truyXuatDuLieuBang_NhaXuatBan();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaNSX"].ToString() == MaNSX)
                    {
                        txtMaNXB.Text = dr["MaNSX"].ToString();
                        txtTenNXB.Text = dr["TenNSX"].ToString();
                        
                       

                    }
                }
            }
        }

        void XoaNXB(string MaNSX)
        {
           NhaXuatBanBLL  cls = new NhaXuatBanBLL(MaNSX);
            int kq = cls.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiNSX();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại Mã nhà sản xuất", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Mã nhà xuất bản có trong bảng đầu sach", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }
            }
        }

        void XoaTacGia(string MaTacGia)
        {
            TacGiaBLL cls = new TacGiaBLL(MaTacGia);
            int kq = cls.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiTacGia();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại Mã tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Mã tác giả có trong bảng tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }
            }
        }

        void LuuMoiNXB(string MaNSX, string TenNSX)
        {

            NhaXuatBanBLL cls = new NhaXuatBanBLL(MaNSX,TenNSX);

            int kq = cls.Them();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiNSX();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Trùng Mã nhà sản xuất", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }
               

            }
        }

        void LuuMoiTacGia(string MaTacGia, string TenTacGia)
        {

            TacGiaBLL cls = new TacGiaBLL(MaTacGia, TenTacGia);

            int kq = cls.Them();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiTacGia();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Trùng Mã tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTacGia.Focus();
                        break;
                    }


            }
        }

        void CapNhatTacGia(string MaTacGia, string TenTacGia)
        {

            TacGiaBLL cls = new TacGiaBLL(MaTacGia, TenTacGia);

            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiTacGia();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không có Mã tác giả trong bảng Tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTacGia.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Mã tác giả có  trong bảng Tựa sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTacGia.Focus();
                        break;
                    }

            }
        }

        void CapNhatNSX(string MaNSX, string TenNSX)
        {

            NhaXuatBanBLL cls = new NhaXuatBanBLL(MaNSX, TenNSX);

            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiNSX();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không có Mã nhà sản xuất trong bảng Nhà sản xuất", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Mã nhà sản xuất có  trong bảng Đầu sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        break;
                    }


            }
        }

        bool KiemTraNSX(string MaNSX, string TenNSX)
        {
            bool bolMaNSX = false, bolTenNSX = false;
            if (txtMaNXB.Text.Trim() != "")
            {
                bolMaNSX = MaNSX.ToLower().Contains(txtMaNXB.Text.ToLower()) ? true : false;
            }
            if (txtTenNXB.Text.Trim() != "")
            {
                bolTenNSX = TenNSX.ToLower().Contains(txtTenNXB.Text.ToLower()) ? true : false;
            }
           
            
            if (bolMaNSX || bolTenNSX)
                return true;

            return false;
        }

        bool KiemTraTacGia(string MaTacGia, string TenTacGia)
        {
            bool bolMaTacGia = false, bolTenTacGia = false;
            if (txtMaTacGia.Text.Trim() != "")
            {
                bolMaTacGia = MaTacGia.ToLower().Contains(txtMaTacGia.Text.ToLower()) ? true : false;
            }
            if (txtTenTG.Text.Trim() != "")
            {
                bolTenTacGia = TenTacGia.ToLower().Contains(txtTenTG.Text.ToLower()) ? true : false;
            }


            if (bolMaTacGia || bolTenTacGia)
                return true;

            return false;
        }

        void TraCuuNSX()
        {
            DataTable dt = new NhaXuatBanBLL().truyXuatDuLieuBang_NhaXuatBan();
            if (dt.Rows.Count > 0)
            {
                lvwNXB.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (KiemTraNSX(dr["MaNSX"].ToString(), dr["TenNSX"].ToString()))
                    {
                        ListViewItem li = lvwNXB.Items.Add(i.ToString());
                        li.SubItems.Add(dr["MaNSX"].ToString());
                        li.SubItems.Add(dr["TenNSX"].ToString());

                        lvwNXB.Tag = dr["MaNSX"].ToString();
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("tra cứu thất bại");
                        return;
                    }

                }
            }
        }

        void TraCuuTacGia()
        {
            DataTable dt = new TacGiaBLL().truyXuatDuLieuBang_TacGia();
            if (dt.Rows.Count > 0)
            {
                lvwTacGia.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (KiemTraTacGia(dr["MaTacGia"].ToString(), dr["TenTacGia"].ToString()))
                    {
                        ListViewItem li = lvwTacGia.Items.Add(i.ToString());
                        li.SubItems.Add(dr["MaTacGia"].ToString());
                        li.SubItems.Add(dr["TenTacGia"].ToString());

                        lvwNXB.Tag = dr["MaTacGia"].ToString();
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("tra cứu thất bại");
                        return;
                    }
                }
            }
        }
        #endregion

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã Nhà xuất bản", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNXB.Focus();
                return;
            }
             
                XoaNXB(txtMaNXB.Text.Trim());
                lvwNXB.Items.Clear();
                HienThiNSX();
                txtMaNXB.Focus();           
          
        }

        private void Usc_TraCuuTheoNXB_Load(object sender, EventArgs e)
        {
            HienThiNSX();
            HienThiTacGia();
            btnCapNhatNXB.Enabled = false;
            btnXoaNXB.Enabled = false;
            btnXoaTG.Enabled = false;
            btnCapNhatTG.Enabled = false;
        }

        private void lvwNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (lvwNXB.SelectedItems.Count > 0)
            {

                foreach (int i in lvwNXB.SelectedIndices)
                {
                    string MaNSX = lvwNXB.Items[i].Tag.ToString();
                    HienThiNSXTheoMa(MaNSX);
                    break;
                }
            }
           
            btnCapNhatNXB.Enabled = true;
            btnXoaNXB.Enabled = true;
            btnLuuNXB.Enabled = false;
            btnTraCuuNXB.Enabled = false;
        }

        private void btnThemMoiNXB_Click(object sender, EventArgs e)
        {
            btnXoaNXB.Enabled = false;
            btnLuuNXB.Enabled = true;
            btnTraCuuNXB.Enabled = true;
            btnCapNhatNXB.Enabled = false;
            HienThiNSX();
            txtTenNXB.Clear();
            txtMaNXB.Clear();
            txtMaNXB.Focus();
        }

        private void lvwTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTacGia.SelectedItems.Count > 0)
            {

                foreach (int i in lvwTacGia.SelectedIndices)
                {
                    string MaTacGia = lvwTacGia.Items[i].Tag.ToString();
                    HienThiTacGiaTheoMa(MaTacGia);
                    break;
                }
            }

            btnCapNhatTG.Enabled = true;
            btnXoaTG.Enabled = true;
            btnLuuTG.Enabled = false;
            btnTraCuuTG.Enabled = false;
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã tác giả", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTacGia.Focus();
                return;
            }

            XoaTacGia(txtMaTacGia.Text.Trim());
            lvwTacGia.Items.Clear();
            HienThiTacGia();
            txtMaTacGia.Focus();           
          
        }

        private void btnThemMoiTG_Click(object sender, EventArgs e)
        {
            btnXoaTG.Enabled = false;
            btnLuuTG.Enabled = true;
            btnTraCuuTG.Enabled = true;
            btnCapNhatTG.Enabled = false;
            txtMaTacGia.Clear();
            txtTenTG.Clear();
            HienThiTacGia();
            txtMaTacGia.Focus();
        }

        private void btnLuuTG_Click(object sender, EventArgs e)
        {

            if (txtMaTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã cuốn sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTacGia.Focus();
                return;
            }
            if (txtTenTG.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên cuốn sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTG.Focus();
                return;
            }

            LuuMoiTacGia(txtMaTacGia.Text.Trim(), txtTenTG.Text.Trim());
        }

        private void btnLuuNXB_Click(object sender, EventArgs e)
        {

            if (txtMaNXB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNXB.Focus();
                return;
            }
            if (txtTenNXB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNXB.Focus();
                return;
            }

            LuuMoiNXB(txtMaNXB.Text.Trim(), txtTenNXB.Text.Trim());
        }

        private void btnCapNhatNXB_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  nhà xuất bản", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNXB.Focus();
                return;
            }
            if (txtTenNXB.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên nhà xuất bản", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNXB.Focus();
                return;
            }

           
            CapNhatNSX(txtMaNXB.Text.Trim(), txtTenNXB.Text.Trim());
        }

        private void btnCapNhatTG_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTacGia.Focus();
                return;
            }
            if (txtTenTG.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên tác giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTG.Focus();
                return;
            }


            CapNhatTacGia(txtMaTacGia.Text.Trim(), txtTenTG.Text.Trim());
        }

        private void btnTraCuuTG_Click(object sender, EventArgs e)
        {
            TraCuuTacGia();
        }

        private void btnTraCuuNXB_Click(object sender, EventArgs e)
        {
            TraCuuNSX();
        }

     

      
       
    }
}
