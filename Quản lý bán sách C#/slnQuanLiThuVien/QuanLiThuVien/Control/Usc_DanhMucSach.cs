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
    public partial class Usc_DanhMucSach : UserControl
    {
        public Usc_DanhMucSach()
        {
            InitializeComponent();
        }

        #region  các hàm xử lí
        /// <summary>
        /// lấy mã tựa sách bằng mã đầu sách
        /// </summary>
        /// <param name="MaDauSach">mã đầu sách</param>
        /// <returns>mã tựa sách</returns>
        string GetMaTuaSach(string MaDauSach)
        {
            string MaTuaSach = "";
            DataTable dt = new DauSachBLL().truyXuatDuLieuBang_DauSach();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaDauSach"].ToString() == MaDauSach)
                    {
                        MaTuaSach = dr["MaTuaSach"].ToString();
                        break;
                    }
                }
            }
            return MaTuaSach;
        }



        /// <summary>
        /// lấy tên mã thể loại bằng Mã tựa sách trong bảng tựa sách
        /// </summary>
        /// <param name="MaTuaSach">mã tựa sách</param>
        /// <returns>mã thể loại</returns>
        string GetMaTheLoai(string MaTuaSach)
        {
            string matheloai = "";
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTuaSach"].ToString() == MaTuaSach)
                    {
                        matheloai = dr["MaTheLoai"].ToString();
                        break;
                    }
                }
            }

            return matheloai;
        }

        /// <summary>
        /// get tên thể loại bằng mã thể loại trong bảng thể loại
        /// </summary>
        /// <param name="MaTheLoai">mã thể loại</param>
        /// <returns>tên thể loại</returns>
        string GetTenTheLoai(string MaTheLoai)
        {
            string tentheloai = "";
            DataTable dt = new TheLoaiBLL().truyXuatDuLieuBang_TheLoai();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaLoaiSach"].ToString() == MaTheLoai)
                    {
                        tentheloai = dr["TenLoaiSach"].ToString();
                        break;
                    }
                }
            }

            return tentheloai;
        }

        /// <summary>
        /// get mã tác giả bằng mã tựa sách trong table tựa sách 
        /// </summary>
        /// <param name="MaTuaSach">mã tựa sách</param>
        /// <returns>mã tác giả</returns>
        string GetMaTacGia(string MaTuaSach)
        {
            string matacgia = "";
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTuaSach"].ToString() == MaTuaSach)
                    {
                        matacgia = dr["MaTacGia"].ToString();
                        break;
                    }
                }
            }

            return matacgia;
        }

        /// <summary>
        /// get tên tựa sách
        /// </summary>
        /// <param name="MaTuaSach">Mã tựa sách</param>
        /// <returns></returns>
        string GetTenTuaSach(string MaTuaSach)
        {
            string tentuasach = "";
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTuaSach"].ToString() == MaTuaSach)
                    {
                        tentuasach = dr["TenTuaSach"].ToString();
                        break;
                    }
                }
            }

            return tentuasach;
        }

        /// <summary>
        /// gét nội dung cuốn sách
        /// </summary>
        /// <param name="MaTuaSach">mã tựa sách</param>
        /// <returns>nội dung tóm tắt</returns>
        string GetNDTomTat(string MaTuaSach)
        {
            string ndTomTat = "";
            DataTable dt = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTuaSach"].ToString() == MaTuaSach)
                    {
                        ndTomTat = dr["NDTomTat"].ToString();
                        break;
                    }
                }
            }

            return ndTomTat;
        }

        /// <summary>
        /// lấy tên tác giả bẳng mã tác giả
        /// </summary>
        /// <param name="MaTacGia">mã tác giả</param>
        /// <returns>tên tác giả</returns>
        string GetTacGia(string MaTacGia)
        {
            string tentacgia = "";
            DataTable dt = new TacGiaBLL().truyXuatDuLieuBang_TacGia();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaTacGia"].ToString() == MaTacGia)
                    {
                        tentacgia = dr["TenTacGia"].ToString();//dựa vào mã tác giả để lấy tên
                        break;
                    }
                }
            }

            return tentacgia;
        }

        /// <summary>
        /// hiển thị thông tin sách
        /// </summary>
        void HienThiSach()
        {
            DataTable dt = new CuonSachBLL().truyXuatDuLieuBang_CuonSach1();


            if (dt.Rows.Count > 0)
            {
                lwvDanhMucSach.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lwvDanhMucSach.Items.Add(i.ToString());
                    li.SubItems.Add(dr["TenCuonSach"].ToString());
                    li.SubItems.Add(dr["dausach.MaDauSach"].ToString());
                    li.SubItems.Add(dr["TenLoaiSach"].ToString());
                    li.SubItems.Add(dr["TenTacGia"].ToString());
                    li.Tag = dr["MaCuonSach"].ToString();
                    i++;
                }
            }
        }


        /// <summary>
        /// xóa sách
        /// </summary>
        /// <param name="MaSach">mã cuốn sách</param>
        void XoaSach(string MaSach)
        {
            CuonSachBLL aaa = new CuonSachBLL(MaSach);
            int kq = aaa.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại Mã Phòng", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSachDMS.Focus();
                        break;
                    }
            }
        }

        /// <summary>
        /// load mã đầu sách lên combobox
        /// </summary>
        void LoadMaDauSach()
        {
            cboMaDauSachDMS.DisplayMember = "MaDauSach";
            cboMaDauSachDMS.ValueMember = "MaDauSach";
            cboMaDauSachDMS.DataSource = new DauSachBLL().truyXuatDuLieuBang_DauSach();
        }

        /// <summary>
        /// load mã tên loại sách lên combobox
        /// </summary>
        //void LoadLoaiSach()
        //{
        //    cboLoaiSachDMS.DisplayMember = "TenLoaiSach";
        //    cboLoaiSachDMS.ValueMember = "MaLoaiSach";
        //    cboLoaiSachDMS.DataSource = new TheLoaiBLL().truyXuatDuLieuBang_TheLoai();
        //}


        /// <summary>
        /// load mã tên tác giả lên combobox
        /// </summary>
        //void LoadTacGia()
        //{
        //    cboTacGiaDMS.DisplayMember = "TenTacGia";
        //    cboTacGiaDMS.ValueMember = "MaTacGia";
        //    cboTacGiaDMS.DataSource = new TacGiaBLL().truyXuatDuLieuBang_TacGia();
        //}


        /// <summary>
        /// load mã tên tựa sách lên combobox
        /// </summary>
        //void LoadTuaSach()
        //{
        //    cboMaTuaSachDMS.DisplayMember = "TenTuaSach";
        //    cboMaTuaSachDMS.ValueMember = "MaTuaSach";
        //    cboMaTuaSachDMS.DataSource = new TuaSachBLL().truyXuatDuLieuBang_TuaSach();
        //}

       
        
        /// <summary>
        /// hiển thị danh sách theo mã
        /// </summary>
        /// <param name="MaCuonSach">mã cuốn sách</param>
        void HienThiSachTheoMa(string MaCuonSach)
        {
            DataTable dt = new CuonSachBLL().truyXuatDuLieuBang_CuonSach();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaCuonSach"].ToString() == MaCuonSach)
                    {
                        txtMaSachDMS.Text = dr["MaCuonSach"].ToString();
                        txtTenSachDMS.Text =dr["TenCuonSach"].ToString();
                        lblTuaSachDMS.Text = Convert.ToString((GetMaTuaSach(dr["MaDauSach"].ToString())));
                        cboMaDauSachDMS.SelectedValue = dr["MaDauSach"];
                        lblTacGiaDMS.Text = Convert.ToString((GetMaTacGia(GetMaTuaSach(dr["MaDauSach"].ToString()))));
                        lblLoaiSachDMS.Text = Convert.ToString(GetMaTheLoai(GetMaTuaSach(dr["MaDauSach"].ToString())));

                        if ((bool)dr["TinhTrang"] == false)
                            radChuaMuon.Checked = true;
                        else
                            radDaMuon.Checked = true;
                        txtNoiDungTomLuocDMS.Text = GetNDTomTat(GetMaTuaSach(dr["MaDauSach"].ToString()));

                       
                    }
                }
            }
        }

        /// <summary>
        /// nhập thêm sách vào kho
        /// </summary>
        /// <param name="MaCuonSach">mã cuốn sách</param>
        /// <param name="TenCuonSach">tên cuốn sách</param>
        /// <param name="MaDauSach">mã đầu sách</param>
        /// <param name="TinhTrang">tình trạng</param>
        void LuuMoiSach(string MaCuonSach, string TenCuonSach, string MaDauSach, string TinhTrang)
        {

            CuonSachBLL cls = new CuonSachBLL(MaCuonSach, TenCuonSach, MaDauSach, TinhTrang);
           
                int kq = cls.Them();

                switch (kq)
                {
                    case 0:
                        {
                            MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiSach();
                            break;
                        }
                    case 1:
                        {
                            MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Trùng Mã Cuốn Sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMaSachDMS.Focus();
                            break;
                        }
                     case 3:
                    {
                        MessageBox.Show("Không Có Mã đầu sach`", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                }
            }


        /// <summary>
        /// cap  nhật sách
        /// </summary>
        /// <param name="MaCuonSach">mã cuốn sách</param>
        /// <param name="TenCuonSach">tên cuốn sách</param>
        /// <param name="MaDauSach">mã đầu sách</param>
        /// <param name="TinhTrang">tình trạng</param>
        void CapNhatSach(string MaCuonSach, string TenCuonSach, string MaDauSach, string TinhTrang)
        {
            CuonSachBLL cls = new CuonSachBLL(MaCuonSach, TenCuonSach, MaDauSach, TinhTrang);
           
            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Có Mã cuốn sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSachDMS.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không Có Mã đầu sach`", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("sách đang được mượn không thể cập nhật.!!", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        /// <summary>
        /// Kiểm tra xem có những nội dung nào cần tra cứu
        /// </summary>
        /// <param name="MaCuonSach">mã cuốn sách</param>
        /// <param name="TenCuonSach">tên cuốn sách</param>
        /// <param name="MaDauSach">mã đầu sách</param>
        /// <param name="TinhTrang">tình trạng</param>
        /// <returns></returns>
        bool KiemTra(string MaCuonSach, string TenCuonSach, string MaDauSach, bool TinhTrang)
        {
            bool bolMaCuonSach = false, bolTenCuonSach = false, bolMaDauSach = false;
            if (txtMaSachDMS.Text.Trim() != "")
            {
                bolMaCuonSach = MaCuonSach.ToLower().Contains(txtMaSachDMS.Text.ToLower()) ? true : false;
            }
            if (txtTenSachDMS.Text.Trim() != "")
            {
                bolTenCuonSach = TenCuonSach.ToLower().Contains(txtTenSachDMS.Text.ToLower()) ? true : false;
            }
            if (cboMaDauSachDMS.SelectedValue.ToString() != "")
            {
                bolMaDauSach = MaDauSach.ToLower().Contains(cboMaDauSachDMS.SelectedValue.ToString().ToLower()) ? true : false;
            }

            if (bolMaCuonSach || bolTenCuonSach || bolMaDauSach || TinhTrang)
                return true;

            return false;
        }

        /// <summary>
        /// hàm tra cứu
        /// </summary>
        void TraCuu()
        {
            DataTable dt = new CuonSachBLL().truyXuatDuLieuBang_CuonSach();
            if (dt.Rows.Count > 0)
            {
                lwvDanhMucSach.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (KiemTra(dr["MaCuonSach"].ToString(), dr["TenCuonSach"].ToString(), dr["MaDauSach"].ToString(), (bool)dr["TinhTrang"]))
                    {
                        ListViewItem li = lwvDanhMucSach.Items.Add(i.ToString());
                        li.SubItems.Add(dr["TenCuonSach"].ToString());
                        li.SubItems.Add(dr["MaDauSach"].ToString());
                        li.SubItems.Add(GetTenTheLoai(GetMaTheLoai(GetMaTuaSach(dr["MaDauSach"].ToString()))));
                        li.SubItems.Add(GetTacGia(GetMaTacGia(GetMaTuaSach(dr["MaDauSach"].ToString()))));

                        string tinhtrang = ((bool)dr["TinhTrang"]) ? "Đã Mượn" : "Chưa Mượn";
                        li.SubItems.Add(tinhtrang);

                    
                        lwvDanhMucSach.Tag = dr["MaCuonSach"].ToString();
                        i++;
                    }

                }
            }
        }


        #endregion

      
        private void btnThemMoiDMS_Click(object sender, EventArgs e)
        {
            HienThiSach();
            btnLuuDMS.Enabled = true;
            btnXoaDMS.Enabled = false;
            btnTraCuuDMS.Enabled = true;
            btnCapNhatDMS.Enabled = false;
            txtMaSachDMS.ReadOnly = false;
            txtTenSachDMS.ReadOnly = false;
            cboMaDauSachDMS.Enabled = true;
             grpTinhTrang.Enabled = true;
            txtNoiDungTomLuocDMS.ReadOnly = false;
            txtMaSachDMS.Clear();
            txtTenSachDMS.Clear();
            radChuaMuon.Enabled = true;
            radDaMuon.Enabled = true;
            txtMaSachDMS.Focus();
        }

        private void btnXoaDMS_Click(object sender, EventArgs e)
        {
            if (txtMaSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã Sách", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSachDMS.Focus();
                return;
            }

            if (radChuaMuon.Checked == true)
            {
                XoaSach(txtMaSachDMS.Text.Trim());
                lwvDanhMucSach.Items.Clear();
                HienThiSach();
                txtMaSachDMS.Focus();
            }
            else if (radChuaMuon.Checked == false)
            {
                MessageBox.Show("Sách này đang cho đọc giả mượn,không xóa được","Lỗi");
            }
           

        }

        private void Usc_DanhMucSach_Load(object sender, EventArgs e)
        {
           
            HienThiSach();
            LoadMaDauSach();
            btnCapNhatDMS.Enabled = false;
            btnXoaDMS.Enabled=false;
          
        }

      
        private void lwvDanhMucSach_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (lwvDanhMucSach.SelectedItems.Count > 0)
            {

                foreach (int i in lwvDanhMucSach.SelectedIndices)
                {
                    string MaCuonSach = lwvDanhMucSach.Items[i].Tag.ToString();
                    HienThiSachTheoMa(MaCuonSach);
                    radDaMuon.Enabled = false;
                    radChuaMuon.Enabled = false;
                    break;
                }
            }
            btnXoaDMS.Enabled = true;
            btnCapNhatDMS.Enabled = true;
            btnLuuDMS.Enabled = false;
            btnTraCuuDMS.Enabled = false;
          
           
        }

        private void btnCapNhatDMS_Click(object sender, EventArgs e)
        {
            if (txtMaSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  cuốn Sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSachDMS.Focus();
                return;
            }
            if (txtTenSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSachDMS.Focus();
                return;
            }

            if (cboMaDauSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập mã đầu sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaDauSachDMS.Focus();
                return;
            }
            string TinhTrang = (radDaMuon.Checked) ? "Đã Mượn" : "Chưa Mượn";
            CapNhatSach(txtMaSachDMS.Text.Trim(), txtTenSachDMS.Text.Trim(), cboMaDauSachDMS.SelectedValue.ToString(), TinhTrang);
        }

        private void btnTraCuuDMS_Click(object sender, EventArgs e)
        {
            TraCuu();
        }

        private void btnLuuDMS_Click(object sender, EventArgs e)
        {
            if (txtMaSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã cuốn sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSachDMS.Focus();
                return;
            }
            if (txtTenSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên cuốn sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSachDMS.Focus();
                return;
            }
            if (cboMaDauSachDMS.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập mã đầu sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSachDMS.Focus();
                return;
            }
            LuuMoiSach(txtMaSachDMS.Text.Trim(), txtTenSachDMS.Text.Trim(), cboMaDauSachDMS.SelectedValue.ToString(),radChuaMuon.Text);

        }

        private void cboMaDauSachDMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDauSachDMS.SelectedValue.ToString() != null)
            {
                lblLoaiSachDMS.Text = GetTenTheLoai(GetMaTheLoai(GetMaTuaSach(cboMaDauSachDMS.SelectedValue.ToString())));
                lblTacGiaDMS.Text = GetTacGia(GetMaTacGia(GetMaTuaSach(cboMaDauSachDMS.SelectedValue.ToString())));
                lblTuaSachDMS.Text = GetTenTuaSach(GetMaTuaSach(cboMaDauSachDMS.SelectedValue.ToString()));
            }
        }

       

        

       

      
        

       

        
    }
}
