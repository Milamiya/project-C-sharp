using System.Collections;
using System.Collections.Generic;
using System.Data;
using QLHS.DAL;
using QLHS.DTO;
using Util;

namespace QLHS.BUS
{
    public class PhanLopBUS
    {
        private readonly HocSinhDAL _hocSinhDAL;
        private readonly PhanLopDAL _phanLopDAL;

        public PhanLopBUS()
        {
            _phanLopDAL = new PhanLopDAL();
            _hocSinhDAL = new HocSinhDAL();
        }

        /// <summary>
        /// Kiểm tra tồn tại  STT của 1 học sinh trong lớp
        /// </summary>
        /// <param name="stt">Int: Số thứ tự</param>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Bool:</returns>
        public bool KiemTra_STT_TonTai(int stt, string maLop)
        {
            return _phanLopDAL.KiemTraTonTai_STT(stt, maLop);
        }

        /// <summary>
        /// Lấy Số thứ tự tiếp theo trong bảng điểm
        /// </summary>
        /// <param name="maLop">String: mã lớp</param>
        /// <returns>Int</returns>
        public int LaySTT_TiepTheo(string maLop)
        {
            return _phanLopDAL.Lay_STT_TiepTheo(maLop);
        }

        /// <summary>
        /// Lấy STT hiện tại của 1 học sinh
        /// </summary>
        /// <param name="maHocSinh">String: Mã học sinh</param>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Int</returns>
        public int LaySTT_HienTai(string maHocSinh, string maLop)
        {
            return _phanLopDAL.Lay_STT_HienTai(maHocSinh, maLop);
        }

        /// <summary>
        /// Đếm sỉ số của 1 lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Int</returns>
        public int Dem_SiSo_Lop(string maLop)
        {
            return _phanLopDAL.Dem_SiSo_Lop(maLop);
        }

        /// <summary>
        /// Thay đổi lớp mới cho học sinh 
        /// </summary>
        /// <param name="maHocSinh">String: mã học sinh</param>
        /// <param name="maLopCu">String: Mã lớp cũ</param>
        /// <param name="maLopMoi">String: Mã lớp mới</param>
        /// <returns></returns>
        public bool ThayDoi_LopMoi_HocSinh(string maHocSinh, string maLopCu, string maLopMoi)
        {
            return _phanLopDAL.ThayDoi_LopMoi_HocSinh(maHocSinh, maLopCu, maLopMoi);
        }

        /// <summary>
        /// Cập nhật STT học sinh cho cả lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Bool</returns>
        public bool CapNhapSTT_HocSinh_Lop(string maLop)
        {
            DataTable dsHocSinh = _hocSinhDAL.LayDT_HocSinh_LopHoc(maLop);
            int i = 0;
            int soHS = dsHocSinh.Rows.Count;
            // Lop khong co hoc sinh nao
            if (soHS == 0)
                return false;
            var listHocSinh = new HocSinhChuanHoaTenDTO[soHS];

            var arrList = new ArrayList();
            foreach (DataRow dr in dsHocSinh.Rows)
            {
                listHocSinh[i] = new HocSinhChuanHoaTenDTO();
                listHocSinh[i].MaHocSinh = dr["MaHocSinh"].ToString();
                listHocSinh[i].TenHocSinh = dr["TenHocSinh"].ToString();

                arrList.Add(listHocSinh[i]);
                i++;
            }
            var compare = new HocSinhChuanHoaTenDTO.newHocSinhChuanHoaTenDTO();
            arrList.Sort(compare);

            i = 1;
            foreach (HocSinhChuanHoaTenDTO hs in arrList)
            {
                hs.STT = i++;
            }

            return _phanLopDAL.CapNhat_STT_Lop(maLop, arrList);
        }

        public bool PhanLop_DSHocSinh_Lop(Dictionary<string, string> dsHocsinhchuyen, string maLopMoi
                                          , out List<PhanLopDTO> dsTonTai)
        {
            dsTonTai = new List<PhanLopDTO>();
            string maKhoi = ObjectUtil.LayMaKhoiLopTuMaLop(maLopMoi),
                   maNamHoc = ObjectUtil.LayMaNamHocTuMaLop(maLopMoi);

            var dsThem = new Dictionary<string, string>();
            foreach (var item in dsHocsinhchuyen)
            {
                PhanLopDTO phanLopDTO = _phanLopDAL.Lay_PhanLop_HocSinh_Khoi_NamHoc(item.Key, maKhoi, maNamHoc);
                if (phanLopDTO == null)
                {
                    dsThem.Add(item.Key, item.Value);
                }
                else
                    dsTonTai.Add(phanLopDTO);
            }
            if (dsThem.Count == 0)
                return false;
            // chuyển lớp cho ds học sinh
            _phanLopDAL.ChuyenLop_HocSinh(dsThem, maLopMoi);
            // cập nhật stt cho lớp
            CapNhapSTT_HocSinh_Lop(maLopMoi);
            return true;
        }

        public bool Xoa_DSHocSinh_Lop(Dictionary<string, string> dsHocsinhchon, string maLop)
        {
            bool success = _phanLopDAL.Xoa_DSHocSinh_Lop(dsHocsinhchon, maLop);
            // cập nhật stt cho lớp
            CapNhapSTT_HocSinh_Lop(maLop);
            return success;
        }

        public DataTable LayDTLop_MaNam_MaKhoi_KhacMaLop(string maNamHoc, string maKhoi, string maLop)
        {
            return _phanLopDAL.LayDT_Lop_MaKhoi_KhacMaLop_MaNam(maNamHoc, maKhoi, maLop);
        }

        public bool KiemTraTonTai_HocSinh_TrongLop(string maHocSinh, string maLop)
        {
            return _phanLopDAL.KiemTraTonTao_HSinh_TrongLop_ChuyenLop(maHocSinh, maLop);
        }
    }
}