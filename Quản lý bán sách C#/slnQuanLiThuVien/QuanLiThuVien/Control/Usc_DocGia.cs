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
    public partial class Usc_DocGia : UserControl
    {
        public Usc_DocGia()
        {
            InitializeComponent();
        }

        #region các hàm xử lí

      
        /// <summary>
        /// hàm load đọc giả
        /// </summary>
        void LoadDocGia()
        {
            DataTable dtdocgia = new DocGiaBLL().truyXuatDuLieuBang_DocGia();
            if (dtdocgia.Rows.Count > 0)
            {
                lvwDSDocGia.Items.Clear();
                int i = 1;
                StringBuilder sb = new StringBuilder();
                foreach (DataRow dg in dtdocgia.Rows)
                {
                    
                    ListViewItem li = lvwDSDocGia.Items.Add(dg["MaDocGia"].ToString());
                   // li.SubItems.Add(dg["MaDocGia"].ToString());
                    li.SubItems.Add(dg["HoDocGia"].ToString() + " " + dg["TenLotDocGia"] + " " + dg["TenDocGia"]);
                    li.SubItems.Add(dg["NgaySinh"].ToString());

                    string gioitinh = ((bool)dg["GioiTinh"]) ? "Nam" : "Nữ";
                    li.SubItems.Add(gioitinh);
                    li.SubItems.Add(dg["SoNha"].ToString() + "," + dg["Duong"].ToString() + "," + dg["Quan"].ToString());
                    li.SubItems.Add(dg["NgayDangKi"].ToString());
                    li.SubItems.Add(dg["NgayHetHanDK"].ToString());
                    li.SubItems.Add(i.ToString());
                    li.SubItems.Add(dg["SoDienThoai"].ToString());
                     li.Tag = dg["MaDocGia"].ToString();
                    i++;
                }
            }
        }

        /// <summary>
        /// hàm lưu mới dọc giả
        /// </summary>
        /// <param name="MaDocGia">mã đọc giả</param>
        /// <param name="HoDocGia">họ đọc giả</param>
        /// <param name="TenLotDocGia">tên lót đọc giả</param>
        /// <param name="TenDocGia">tên đọc giả</param>
        /// <param name="GioiTinh">giới tính</param>
        /// <param name="NgaySinh">ngày sinh</param>
        /// <param name="SoNha">số nhà</param>
        /// <param name="Duong">đường</param>
        /// <param name="Quan">quận</param>
        /// <param name="SoDienThoai">sô điện thoại</param>
        /// <param name="NgayDangKi">ngày đăng kí</param>
        /// <param name="NgayHethanDK">ngày hết hạn đăng kí</param>
        void LuuMoiDocGia(string MaDocGia, string HoDocGia, string TenLotDocGia, string TenDocGia,bool GioiTinh,DateTime NgaySinh,string SoNha,string Duong,
            string Quan,string SoDienThoai,DateTime NgayDangKi,DateTime NgayHethanDK)
        {

            DocGiaBLL cls = new DocGiaBLL(MaDocGia, HoDocGia, TenLotDocGia, TenDocGia, GioiTinh, NgaySinh, SoNha, Duong, Quan, SoDienThoai, NgayDangKi, NgayHethanDK);

            int kq = cls.Them();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Thêm Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDocGia();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Thêm Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Trùng Mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaDocGia.Focus();
                        break;
                    }

            }
        }
        /// <summary>
        /// hàm kiểm tra giới tính là nam hay nữ(nam:true; nữ:false)
        /// </summary>
        /// <returns></returns>
        bool KTGioiTinh()
        {
           bool GioiTinh = false;
            if (radNam.Checked == true)
                GioiTinh = true;
            

            return GioiTinh;
        }


        /// <summary>
        /// hiển thị đọc giả theo mã đọc giả
        /// </summary>
        /// <param name="MaDocGia">mã đọc giả</param>
        void HienDocGiaTheoMa(string MaDocGia)
        {
            DataTable dt = new DocGiaBLL().truyXuatDuLieuBang_DocGia();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MaDocGia"].ToString() == MaDocGia)
                    {
                        txtMaDocGia.Text = dr["MaDocGia"].ToString();
                        txtHoTenDocGia.Text = dr["HoDocGia"].ToString() + " " + dr["TenLotDocGia"].ToString() + " " + dr["TenDocGia"].ToString();
                        txtDiaChi.Text = dr["SoNha"].ToString() + "," + dr["Duong"].ToString() + "," + dr["Quan"].ToString(); ;
                        dtbNgaySinh.Text = dr["NgaySinh"].ToString();
                        dtNgayDangKi.Text = dr["NgayDangKi"].ToString();
                        dtNgayHetHan.Text = dr["NgayHetHanDK"].ToString();
                        txtSoDienThoaiDG.Text = dr["SoDienThoai"].ToString();


                        if ((bool)dr["GioiTinh"] == false)
                            radNu.Checked = true;
                        else
                            radNam.Checked = true;
                       


                    }
                }
            }
        }

        /// <summary>
        /// hàm xóa đọc giả theo mã đọc giả
        /// </summary>
        /// <param name="MaDocGia">mã đọc giả</param>
        void XoaDocGia(string MaDocGia)
        {
            DocGiaBLL cls = new DocGiaBLL(MaDocGia);
            int kq = cls.Xoa();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Xóa Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDocGia();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Tồn Tại Mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Đọc gỉa này đang mượn sách.Không thể xóa được", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        /// <summary>
        /// hàm cập nhật thông tin dọc giả
        /// </summary>
        /// <param name="MaDocGia">mã đọc giả</param>
        /// <param name="HoDocGia">họ đọc giả</param>
        /// <param name="TenLotDocGia">tên lót đọc giả</param>
        /// <param name="TenDocGia">tên đọc giả</param>
        /// <param name="GioiTinh">giới tính</param>
        /// <param name="NgaySinh">ngày sinh</param>
        /// <param name="SoNha">số nhà</param>
        /// <param name="Duong">đường</param>
        /// <param name="Quan">quận</param>
        /// <param name="SoDienThoai">sô điện thoại</param>
        /// <param name="NgayDangKi">ngày đăng kí</param>
        /// <param name="NgayHethanDK">ngày hết hạn đăng kí</param>
        void CapNhatDocGia(string MaDocGia,string HoDocGia,string TenLotDocGia,string TenDocGia,bool GioiTinh,DateTime NgaySinh,string SoNha,string Duong,
                            string Quan,string SoDienThoai,DateTime NgayDangKi,DateTime NgayHetHanDK)
        {
            DocGiaBLL cls = new DocGiaBLL(MaDocGia,HoDocGia,TenLotDocGia,TenDocGia,GioiTinh,NgaySinh,SoNha,Duong,Quan,SoDienThoai,NgayDangKi,NgayHetHanDK);

            int kq = cls.CapNhat();

            switch (kq)
            {
                case 0:
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDocGia();
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Cập Nhật Thất Bại", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Không Có Mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaDocGia.Focus();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Không Có đang mượn sách không thể sữa thông tin", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaDocGia.Focus();
                        break;
                    }
            }
        }

        
        /*bool KiemTra(string MaDocGia, string HoDocGia, string TenLotDocGia, string TenDocGia, bool GioiTinh, DateTime NgaySinh, string SoNha, string Duong,
                            string Quan, string SoDienThoai, DateTime NgayDangKi, DateTime NgayHetHanDK)
        {*/
        /// <summary>
        /// hàm kiểm tra xem nội dung nào cần tra cứu
        /// </summary>
        /// <param name="MaDocGia">mã đọc gả</param>
        /// <param name="HoDocGia">họ đọc giả</param>
        /// <param name="TenLotDocGia">tên lót đọc giả</param>
        /// <param name="TenDocGia">tên đọc giả</param>
        /// <param name="GioiTinh">giới tính </param>
        /// <param name="SoNha">số nhà</param>
        /// <param name="Duong">đường</param>
        /// <param name="Quan">quận</param>
        /// <param name="SoDienThoai">số điện thoại</param>
        /// <returns></returns>
        bool KiemTra(string MaDocGia, string HoDocGia, string TenLotDocGia, string TenDocGia,bool GioiTinh,  string SoNha, string Duong,
                           string Quan, string SoDienThoai)
        {

            bool bolMaDocGia = false, bolHoDocGia = false, bolTenLotDocGia = false; bool bolTenDocGia = false;
            bool bolSoNha = false, bolDuong = false, bolQuan = false; bool bolSoDienThoai = false;// bolNgayDangKi = false, bolNgayHethanDk = false, bolNgaySinh = false;
            
            if (txtMaDocGiaTC.Text.Trim() != "")
            {
                bolMaDocGia = MaDocGia.ToLower().Contains(txtMaDocGiaTC.Text.ToLower()) ? true : false;
            }
            //lấy họ
            if (txtHoDGTC.Text.Trim() != "")
            {
                bolHoDocGia = HoDocGia.ToLower().Contains(txtHoDGTC.Text.ToLower()) ? true : false;
            }

            if (txtTenDG.Text.Trim() != "")
            {
                bolTenDocGia = TenDocGia.ToLower().Contains(txtTenDG.Text.ToLower()) ? true : false;
            }
            if (txtTenLotDG.Text.Trim() != "")
            {
                bolTenLotDocGia = TenLotDocGia.ToLower().Contains(txtTenLotDG.Text.ToLower()) ? true : false;
            }
            if (txtSDT_TC.Text.Trim() != "")
            {
                bolSoDienThoai = SoDienThoai.ToLower().Contains(txtSDT_TC.Text.ToLower()) ? true : false;
            }
            if (txtSoNhaDG.Text.Trim() != "")
            {
                bolSoNha = SoNha.ToLower().Contains(txtSoNhaDG.Text.ToLower()) ? true : false;
            }
            if (txtQuanDG.Text.Trim() != "")
            {
                bolQuan = Quan.ToLower().Contains(txtQuanDG.Text.ToLower()) ? true : false;
            }
            //lấy đường
            if (txtDuongDGTC.Text.Trim() != "")
            {
                bolDuong = Duong.ToLower().Contains(txtDuongDGTC.Text.ToLower()) ? true : false;
            }
            
                //chưa có các ngày(sinh,dk,hethan)

            if (radNamTC.Checked == true || radNuTC.Checked == true)
            {
                GioiTinh = true;
            }
            else
                GioiTinh = false;
           
            if (bolMaDocGia || bolHoDocGia || bolTenLotDocGia || bolTenDocGia ||GioiTinh ||bolSoDienThoai || bolSoNha ||bolQuan|| bolDuong )
                return true;

            return false;
        }



        /// <summary>
        /// hàm tra cứu
        /// </summary>
        void TraCuu()
        {
            DataTable dt = new DocGiaBLL().truyXuatDuLieuBang_DocGia();
            if (dt.Rows.Count > 0)
            {
                lvwDSDocGia.Items.Clear();
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (KiemTra(dr["MaDocGia"].ToString(),dr["HoDocGia"].ToString(),dr["TenLotDocGia"].ToString(),dr["TenDocGia"].ToString(),(bool)dr["GioiTinh"],dr["Sonha"].ToString(),
                        dr["Duong"].ToString(),dr["Quan"].ToString(),dr["SoDienThoai"].ToString()))
                    {
                        ListViewItem li = lvwDSDocGia.Items.Add(dr["MaDocGia"].ToString());
                        
                        li.SubItems.Add(dr["HoDocGia"].ToString()+ " "+dr["TenLotDocGia"].ToString()+ " "+dr["TenDocGia"].ToString());
                        li.SubItems.Add(dr["NgaySinh"].ToString());

                        //chọn nam
                        if (radNamTC.Checked == true)
                        {
                            if ((bool)dr["GioiTinh"] == true)
                                li.SubItems.Add("Nam");
                            if ((bool)dr["GioiTinh"] == false)
                            {

                                li.Remove();
                                continue;
                            }
                        }
                            //chon nữ
                        else if (radNuTC.Checked == true)
                        {
                            if ((bool)dr["GioiTinh"] == false)
                                li.SubItems.Add("Nữ");
                            if ((bool)dr["GioiTinh"] == true)
                            {
                                li.Remove();
                                continue;
                            }
                        }
                            //lấy nam+nữ
                        else
                        {
                            string gioitinh = ((bool)dr["GioiTinh"]) ? "Nam" : "Nữ";
                            li.SubItems.Add(gioitinh);
}
                        
                        li.SubItems.Add(dr["SoNha"].ToString() + "," + dr["Duong"].ToString() + "," + dr["Quan"].ToString());
                        li.SubItems.Add(dr["NgayDangKi"].ToString());
                        li.SubItems.Add(dr["NgayHethanDK"].ToString());
                        li.SubItems.Add(i.ToString());
                        li.SubItems.Add(dr["SoDienThoai"].ToString());
                        
                        i++;
                    }

                }
            }
        }

        #endregion

        private void Usc_DocGia_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            btnCapNhatDocGia.Enabled = false;
            btnXoaDocGia.Enabled = false;
        }

        private void btnThemMoiDocGia_Click(object sender, EventArgs e)
        {
            LoadDocGia();
            btnLuuDocGia.Enabled = true;
            btnTraCuuDG.Enabled = true;
            btnCapNhatDocGia.Enabled = false;
            btnXoaDocGia.Enabled = false;
            txtMaDocGia.Clear();
            txtHoTenDocGia.Clear();
            txtDiaChi.Clear();
            txtSoDienThoaiDG.Clear();
            //dtbNgaySinh.va = DateTime.Today();
            txtMaDocGia.Focus();

        }

        private void btnLuuDocGia_Click(object sender, EventArgs e)
        {
            //chưa xong _tách dia chỉ

            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return;
            }
            if (txtHoTenDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập tên đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenDocGia.Focus();
                return;
            }


            //tách họ tên            
            string ho="", ten="", tenLot="", hoTen=""; int a, b, lengh;
            hoTen = Convert.ToString(txtHoTenDocGia.Text).Trim();
            lengh = hoTen.LastIndexOf("");
            a = hoTen.IndexOf(" ");//vi tri rong dau tien
            b = hoTen.LastIndexOf(" ");//vi tri rong cuoi
            ho = hoTen.Substring(0, a).Trim();
            ten = hoTen.Substring(b).Trim();
            tenLot = hoTen.Substring(a, b - a).Trim();


            //tách địa chỉ
            string sonha = "", duong = "", quan = "",diachi=""; int c, d, leng;
                diachi = Convert.ToString(txtDiaChi.Text).Trim();
                leng = diachi.LastIndexOf("");
                c = diachi.IndexOf(",");//vi tri  dau tien_dấu phẩy
                d = diachi.LastIndexOf(",");//vi tri cuoi_dấu phẩy
                sonha = diachi.Substring(0, c).Trim();
                quan = diachi.Substring(d+1).Trim();
                duong = diachi.Substring(c+1, d - (c+1)).Trim();
                  //giới tính
            bool gt=KTGioiTinh();

            LuuMoiDocGia(txtMaDocGia.Text.Trim(),ho,tenLot,ten,gt,dtbNgaySinh.Value,sonha,duong,quan,txtSoDienThoaiDG.Text,dtNgayDangKi.Value,dtNgayHetHan.Value);
        }

        private void lvwDSDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int i in lvwDSDocGia.SelectedIndices)
            {
                string MaDocGia = lvwDSDocGia.Items[i].Tag.ToString();
                HienDocGiaTheoMa(MaDocGia);
                break;
            }
            btnCapNhatDocGia.Enabled = true;
            btnXoaDocGia.Enabled = true;
            btnLuuDocGia.Enabled = false;
            btnThemMoiDocGia.Enabled = true;
            btnTraCuuDG.Enabled = false;
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XoaDocGia(txtMaDocGia.Text);
            btnThemMoiDocGia_Click(sender,e);
        }

        private void btnCapNhatDocGia_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã  đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return;
            }
            if (txtHoTenDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên đọc giả", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenDocGia.Focus();
                return;
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập địa chỉ", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }


            if (radNam.Checked==false && radNu.Checked==false)
            {
                MessageBox.Show("Chưa chọn giới tính", "Thư viện HOA HỒNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             //tách họ tên            
            string ho="", ten="", tenLot="", hoTen=""; int a, b, lengh;
            hoTen = Convert.ToString(txtHoTenDocGia.Text).Trim();
            lengh = hoTen.LastIndexOf("");
            a = hoTen.IndexOf(" ");//vi tri rong dau tien
            b = hoTen.LastIndexOf(" ");//vi tri rong cuoi
            ho = hoTen.Substring(0, a).Trim();
            ten = hoTen.Substring(b).Trim();
            tenLot = hoTen.Substring(a, b - a).Trim();


            //tách địa chỉ
            string sonha = "", duong = "", quan = "",diachi=""; int c, d, leng;
                diachi = Convert.ToString(txtDiaChi.Text).Trim();
                leng = diachi.LastIndexOf("");
                c = diachi.IndexOf(",");//vi tri  dau tien_dấu phẩy
                d = diachi.LastIndexOf(",");//vi tri cuoi_dấu phẩy
                sonha = diachi.Substring(0, c).Trim();
                quan = diachi.Substring(d+1).Trim();
                duong = diachi.Substring(c+1, d - (c+1)).Trim();
                  //giới tính
            bool gt=KTGioiTinh();


            string GioiTinh = (radNam.Checked) ? "Nam" : "Nữ";
            CapNhatDocGia(txtMaDocGia.Text.Trim(), ho, tenLot, ten, gt, dtbNgaySinh.Value, sonha, duong, quan, txtSoDienThoaiDG.Text, dtNgayDangKi.Value, dtNgayHetHan.Value);
        }

        private void btnTraCuuDG_Click(object sender, EventArgs e)
        {
            TraCuu();
        }

        

       
    }
}
