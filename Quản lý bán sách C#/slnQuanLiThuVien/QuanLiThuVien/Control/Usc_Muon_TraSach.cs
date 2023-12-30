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
    public partial class Usc_Muon_TraSach : UserControl
    {
        public Usc_Muon_TraSach()
        {
            InitializeComponent();
        }

        #region các hàm xử lí

        string GetTenCuonSach(string MaCuonSach)
        {
            string tencuonsach = "";
            DataTable dt = new CuonSachBLL().truyXuatDuLieuBang_CuonSach();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaCuonSach"].ToString() == MaCuonSach)
                    {
                        tencuonsach = dr["TenCuonSach"].ToString();
                        break;
                    }
                }
            }

            return tencuonsach;
        }

        void HienThongTinMuonSach()
        {
            DataTable dt = new MuonBLL().truyXuatDuLieuBang_Muon();


            if (dt.Rows.Count > 0)
            {
                lvwMuonSach.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwMuonSach.Items.Add(i.ToString());
                    li.SubItems.Add(dr["MaMuon"].ToString());
                    li.SubItems.Add(dr["MaDocGia"].ToString());
                   li.SubItems.Add(GetTenCuonSach(dr["MaCuonSach"].ToString()));
                    li.SubItems.Add(dr["SoLuong"].ToString());
                    li.SubItems.Add(dr["NgayMuon"].ToString());
                    li.SubItems.Add(dr["NgayHenTra"].ToString());
                    li.SubItems.Add(dr["NgayTra"].ToString());
                    li.Tag = dr["MaMuon"].ToString();
                    i++;
                }
            }
        }

        void LoadTenCuonSach()
        {

            cboTenSach.DisplayMember = "TenCuonSach";
            cboTenSach.ValueMember = "MaCuonSach";
            cboTenSach.DataSource = new CuonSachBLL().truyXuatDuLieuBang_CuonSach();
        }

        void HienThongTinMuonTheoMaMuon(string MaMuon)
        {
            DataTable dt = new MuonBLL().truyXuatDuLieuBang_Muon();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaMuon"].ToString() == MaMuon)
                    {
                        txtMaMuon.Text = dr["MaMuon"].ToString();
                        txtMaDocGia.Text = dr["MaDocGia"].ToString();
                        cboTenSach.Text = Convert.ToString((GetTenCuonSach(dr["MaCuonSach"].ToString())));
                        txtGhiChu.Text = dr["GhiChu"].ToString();
                        txtSoLuong.Text = dr["SoLuong"].ToString() ;
                        dtNgayMuon.Text = dr["NgayMuon"].ToString();
                        dtNgayHenTra.Text = dr["NgayHenTra"].ToString();
                        dtNgayTra.Text = dr["NgayTra"].ToString();
                       

                    }
                }
            }
        }
        void XoaThongTinMuon(string MaMuon)
        {
            MuonBLL aaa = new MuonBLL(MaMuon);
            int kq = aaa.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThongTinMuonSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại Mã Mượn", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaMuon.Focus();
                        break;
                    }
            }
        }


        void LuuMoiThongTinMuonSach(string MaMuon, string MaDocGia, string MaCuonSach, int SoLuong,DateTime NgayMuon,DateTime NgayHenTra,string GhiChu)
        {

            MuonBLL cls = new MuonBLL(MaMuon, MaDocGia, MaCuonSach, SoLuong, NgayMuon, NgayHenTra, GhiChu);

            int kq = cls.Them();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThongTinMuonSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Trùng Mã Mượn", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaMuon.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không Có Tac giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 4:
                    {
                        MessageBox.Show("Không tên sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

      
             bool KiemTra(string MaMuon, string MaDocGia, int SoLuong,string GhiChu)
        {
            bool bolMaMuon = false, bolMaDocGia = false, bolTenCuonSach = false, bolSoLuong = false, bolGhiChu = false;
           
            if (txtMaMuon.Text.Trim() != "")
            {
                bolMaMuon = MaMuon.ToLower().Contains(txtMaMuon.Text.ToLower()) ? true : false;
            }
            if (txtMaDocGia.Text.Trim() != "")
            {
                bolMaDocGia = MaDocGia.ToLower().Contains(txtMaDocGia.Text.ToLower()) ? true : false;
            }
          

            if (txtGhiChu.Text.Trim() != "")
            {
                bolGhiChu = GhiChu.ToLower().Contains(txtGhiChu.Text.ToLower()) ? true : false;
            }
            if (txtSoLuong.Text.Trim() != "")
            {
                bolSoLuong = SoLuong.ToString().ToLower().Contains(txtSoLuong.Text.ToLower()) ? true : false;
            }

         


            if (bolMaMuon || bolMaDocGia || bolTenCuonSach || bolSoLuong || bolGhiChu )
                return true;

            return false;
        }

           

        void TraCuu()
        {
            DataTable dt = new MuonBLL().truyXuatDuLieuBang_Muon();
            if (dt.Rows.Count > 0)
            {
                lvwMuonSach.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    
                    if (KiemTra(dr["MaMuon"].ToString(), dr["MaDocGia"].ToString(),(int)dr["SoLuong"], dr["GhiChu"].ToString()))
                    {
                        ListViewItem li = lvwMuonSach.Items.Add(i.ToString());
                        li.SubItems.Add(dr["MaMuon"].ToString());
                        li.SubItems.Add(dr["MaDocGia"].ToString());
                       li.SubItems.Add(dr["SoLuong"].ToString());
                        li.SubItems.Add(dr["NgayMuon"].ToString());
                        li.SubItems.Add(dr["NgayHenTra"].ToString());
                        li.SubItems.Add(dr["NgayTra"].ToString());

                        lvwMuonSach.Tag = dr["MaMuon"].ToString();
                        i++;
                    }

                    
            

                }
            }
        }

        void CapNhatThongTinMuonSach(string MaMuon, string MaDocGia, string MaCuonSach, int SoLuong, DateTime NgayMuon, DateTime NgayHenTra,DateTime NgayTra, string GhiChu)
        {
            MuonBLL cls = new MuonBLL(MaMuon, MaDocGia, MaCuonSach, SoLuong, NgayMuon, NgayHenTra,NgayTra, GhiChu);

            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThongTinMuonSach();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Có mã mượn", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaMuon.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không Có mã sách hoặc mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }



        #endregion

        private void Usc_MuonSach_Load(object sender, EventArgs e)
        {
            HienThongTinMuonSach();
            LoadTenCuonSach();
            btnCapNhat_MuonSach.Enabled = false;
            btnXoa_MuonSach.Enabled = false;
            dtNgayTra.Enabled = false;
        }

        private void lvwMuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMuonSach.SelectedItems.Count > 0)
            {

                foreach (int i in lvwMuonSach.SelectedIndices)
                {
                    string MaMuon = lvwMuonSach.Items[i].Tag.ToString();
                    HienThongTinMuonTheoMaMuon(MaMuon);
                    break;
                }
            }
            btnLuu_MuonSach.Enabled = false;
            btnTraCuu_MuonSach.Enabled = false;
            btnCapNhat_MuonSach.Enabled = true;
            btnXoa_MuonSach.Enabled = true;
            
        }

        private void btnXoa_MuonSach_Click(object sender, EventArgs e)
        {
            if (txtMaMuon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã Mượn", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMuon.Focus();
                return;
            }
            if (cboTenSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Sách", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSach.Focus();
                return;
            }
            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã đọc giả", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập số lượng", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }
            if (dtNgayMuon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập ngày mượn", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtNgayMuon.Focus();
                return;
            }
            if (dtNgayHenTra.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập ngày hẹn trả", "Thư Viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtNgayHenTra.Focus();
                return;
            }
            XoaThongTinMuon(txtMaMuon.Text.Trim());
            lvwMuonSach.Items.Clear();
            HienThongTinMuonSach();
            txtMaMuon.Focus();
        }

        private void btnLuu_MuonSach_Click(object sender, EventArgs e)
        {
            if (txtMaMuon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã mượn", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMuon.Focus();
                return;
            }
            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return;
            }
            if (cboTenSach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa  nhập tên sách", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSach.Focus();
                return;
            }

            LuuMoiThongTinMuonSach(txtMaMuon.Text.Trim(), txtMaDocGia.Text.Trim(), cboTenSach.SelectedValue.ToString(), Convert.ToInt32(txtSoLuong.Text.Trim()),dtNgayMuon.Value,dtNgayHenTra.Value,txtGhiChu.Text.Trim());
        }

       
       
        private void btnThemMoi_MuonSach_Click(object sender, EventArgs e)
        {
            btnCapNhat_MuonSach.Enabled = false;
            btnXoa_MuonSach.Enabled = false;
            btnTraCuu_MuonSach.Enabled = true;
            btnLuu_MuonSach.Enabled = true;
            HienThongTinMuonSach();
            txtMaMuon.Clear();
            txtMaDocGia.Clear();
            txtSoLuong.Clear();
            txtGhiChu.Clear();
            txtMaMuon.Focus();
        }

        private void btnTraCuu_MuonSach_Click(object sender, EventArgs e)
        {
            TraCuu();
        }

        private void btnCapNhat_MuonSach_Click(object sender, EventArgs e)
        {

            if (txtMaMuon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  mượn", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaMuon.Focus();
                return;
            }
            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return;
            }


            CapNhatThongTinMuonSach(txtMaMuon.Text.Trim(), txtMaDocGia.Text.Trim(), cboTenSach.SelectedValue.ToString(), Convert.ToInt32(txtSoLuong.Text.Trim()), dtNgayMuon.Value, dtNgayHenTra.Value,dtNgayTra.Value,txtGhiChu.Text.Trim());

        }

       
      

        
     

        
    }
}
