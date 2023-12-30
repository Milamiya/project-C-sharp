using System;
using System.Collections.Generic;
using System.Data;
using QLHS.DAL;
using QLHS.DTO;
using Util;

namespace QLHS.BUS
{
    public class BangDiemBUS
    {
        private readonly BangDiemDAL _bangDiemDAL;
        private readonly HocSinhDAL _hocSinhDAL;
        private readonly LopDAL _lopDAL;
        private readonly MonHocDAL _monHocDAL;
        private readonly PhanLopDAL _phanLopDAL;
        private readonly QuyDinhBUS _quyDinhBUS;

        public BangDiemBUS()
        {
            _bangDiemDAL = new BangDiemDAL();
            _lopDAL = new LopDAL();
            _phanLopDAL = new PhanLopDAL();
            _quyDinhBUS = new QuyDinhBUS();
            _hocSinhDAL = new HocSinhDAL();
            _monHocDAL = new MonHocDAL();
        }

        /// <summary>
        /// Lấy bảng điểm môn học theo học kỳ của lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <param name="maHocKy">String: Mã học kỳ</param>
        /// <param name="maMonHoc">String: Mã môn học</param>
        /// <returns></returns>
        public DataTable LayDT_BangDiem_Lop_MonHoc_HocKy(string maLop, string maHocKy, string maMonHoc)
        {
            return _bangDiemDAL.LayBangDiem_MonHoc_HocKy_Lop(maLop, maHocKy, maMonHoc);
        }

        /// <summary>
        /// Kiểm tra hợp lệ các cột điểm trên 1 dòng của bảng điểm BangDiemDTO
        /// </summary>
        /// <param name="bd">BangDiemDTO</param>
        /// <returns>Bool</returns>
        public bool KiemTraHopLe_DataRow_Lop_MonHoc_HocKy(BangDiemDTO bd)
        {
            const int diemNull = -1;
            string msg = "";
            if (bd.DM_1 == diemNull && bd.DM_2 == diemNull)
                msg = "miệng";
            else if (bd.D15_1 == diemNull && bd.D15_2 == diemNull && bd.D15_3 == diemNull && bd.D15_4 == diemNull)
                msg = "15 phút";
            else if (bd.D1T_1 == diemNull && bd.D1T_2 == diemNull)
                msg = "1 tiết";
            else if (bd.DThi == diemNull)
                msg = "cuối kỳ";
            if (!msg.Equals(""))
                msg = "Bạn chưa nhập cột điểm " + msg + " cho học sinh "
                      + bd.HocSinh.TenHocSinh + " (" + bd.HocSinh.MaHocSinh + ").";
            if (msg != "")
            {
                ExceptionUtil.Throw(msg);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tính điểm trung bình môn trên 1 dòng bảng điểm
        /// </summary>
        /// <param name="bd">BangDiemDTO (Quy định: VỚi điểm == -1 xem như chưa nhập</param>
        /// <returns>double: Điểm trung bình</returns>
        public double TinhDTB_DataRow_Lop_MonHoc_HocKy(BangDiemDTO bd)
        {
            int soCotM = 0, soCot15 = 0, soCot1T = 0;
            double tongM = 0, tong15 = 0, tong1T = 0;
            // Đếm cột miệng nhập
            if (bd.DM_1 >= 0)
            {
                tongM += bd.DM_1;
                soCotM++;
            }
            if (bd.DM_2 >= 0)
            {
                tongM += bd.DM_2;
                soCotM++;
            }
            // Đếm cột 15' nhập
            if (bd.D15_1 >= 0)
            {
                tong15 += bd.D15_1;
                soCot15++;
            }
            if (bd.D15_2 >= 0)
            {
                tong15 += bd.D15_2;
                soCot15++;
            }
            if (bd.D15_3 >= 0)
            {
                tong15 += bd.D15_3;
                soCot15++;
            }
            if (bd.D15_4 >= 0)
            {
                tong15 += bd.D15_4;
                soCot15++;
            }
            // Đếm số cột 1T
            if (bd.D1T_1 >= 0)
            {
                tong1T += bd.D1T_1;
                soCot1T++;
            }
            if (bd.D1T_2 >= 0)
            {
                tong1T += bd.D1T_2;
                soCot1T++;
            }
            double tongDiem = (tong15/soCot15)*1 // 15' hệ số 1
                              + (tongM/soCotM)*1 // M   hệ số 1
                              + (tong1T/soCot1T)*2 // 1T  hệ số 2
                              + bd.DThi*3;

            return ObjectUtil.LamTron(tongDiem/7);
        }

        /// <summary>
        /// Lưu bảng điểm 1 môn học / 1 học sinh / 1 học kỳ / 1 lớp / 1 năm học
        /// </summary>
        /// <param name="bd">BangDiemDTO</param>
        /// <returns>Bool</returns>
        public bool LuuBangDiem_HocSinh_MonHoc_HocKy(BangDiemDTO bd)
        {
            return _bangDiemDAL.LuuBangDiem_MonHoc_HocSinh_HocKy(bd);
        }

        /// <summary>
        /// Xóa bảng điểm 1 môn học / 1 học sinh / 1 học kỳ / 1 lớp / 1 năm học
        /// </summary>
        /// <param name="bd">BangDiemDTO</param>
        /// <returns>bool</returns>
        public bool XoaBangDiem_HocSinh_MonHoc_HocKy(BangDiemDTO bd)
        {
            return _bangDiemDAL.XoaBangDiem_MonHoc_HocSinh_HocKy(bd);
        }

        /// <summary>
        /// Xóa bảng điểm của 1 học sinh thuộc 1 lớp nào đó
        /// </summary>
        /// <param name="maHocSinh">String: Mã học sinh</param>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns></returns>
        public bool XoaBangDiem_HocSinh_Lop(string maHocSinh, string maLop)
        {
            return _bangDiemDAL.XoaBangDiem_HocSinh_Lop(maHocSinh, maLop);
        }

        /// <summary>
        /// Cập nhật lớp mới cho bảng điểm của 1 học sinh
        /// </summary>
        /// <param name="maHocSinh">String: Mã học sinh</param>
        /// <param name="maLopCu">String: Mã lớp cũ</param>
        /// <param name="maLopMoi">String: Mã lớp mới</param>
        /// <returns></returns>
        public bool CapNhat_BangDiem_HocSinh_LopMoi(string maHocSinh, string maLopCu, string maLopMoi)
        {
            return _bangDiemDAL.CapNhat_BangDiem_HocSinh_LopMoi(maHocSinh, maLopCu, maLopMoi);
        }

        /// <summary>
        /// Lấy bảng điểm tổng kết học kỳ theo lớp
        /// </summary>
        /// <param name="maLop">String: mã lớp</param>
        /// <param name="maHocKy">String: Mã học kỳ</param>
        /// <returns>List BangDiemHocKyDTO</returns>
        public List<BangDiemHocKyDTO> LayList_BangDiem_Lop_HocKy(string maLop, string maHocKy)
        {
            var bangDiemHocKy = new List<BangDiemHocKyDTO>();
            // Lấy ds học sinh của lớp
            List<HocSinhDTO> dsHocsinh = _hocSinhDAL.LayList_HocSinh_LopHoc(maLop);
            MonHoc_HeSoDTO dsHeSoMonHoc = _monHocDAL.LayDTO_HeSoMonHoc();
            foreach (HocSinhDTO hocsinh in dsHocsinh)
            {
                var bangDiemCaNhan = new BangDiemHocKyDTO
                                         {
                                             STT = hocsinh.STT,
                                             MaHocSinh = hocsinh.MaHocSinh,
                                             TenHocSinh = hocsinh.TenHocSinh
                                         };
                // Tinh điểm tb
                DataTable tbBangDiem = _bangDiemDAL.LayBangDiem_HocKy_HocSinh(maLop, hocsinh.MaHocSinh, maHocKy);
                int soMonHoc = tbBangDiem.Rows.Count;
                int soMonDuDiem = 0;
                double tongDiem = 0;
                double tongHeSo = 0;
                double heso = 0;
                foreach (DataRow dr in tbBangDiem.Rows)
                {
                    object dtb;
                    if (dr["DTB"] is DBNull)
                        dtb = "_";
                    else
                        dtb = dr["DTB"];

                    switch (Convert.ToString(dr["MaMonHoc"]))
                    {
                        case "toan":
                            bangDiemCaNhan.Dtoan = dtb;
                            heso = dsHeSoMonHoc.toan;
                            break;
                        case "ly":
                            bangDiemCaNhan.Dly = dtb;
                            heso = dsHeSoMonHoc.ly;
                            break;
                        case "hoa":
                            bangDiemCaNhan.Dhoa = dtb;
                            heso = dsHeSoMonHoc.hoa;
                            break;
                        case "sinh":
                            bangDiemCaNhan.Dsinh = dtb;
                            heso = dsHeSoMonHoc.sinh;
                            break;
                        case "ngvan":
                            bangDiemCaNhan.Dngvan = dtb;
                            heso = dsHeSoMonHoc.nngu;
                            break;
                        case "su":
                            bangDiemCaNhan.Dsu = dtb;
                            heso = dsHeSoMonHoc.su;
                            break;
                        case "dia":
                            bangDiemCaNhan.Ddia = dtb;
                            heso = dsHeSoMonHoc.dia;
                            break;
                        case "nngu":
                            bangDiemCaNhan.Dnngu = dtb;
                            heso = dsHeSoMonHoc.nngu;
                            break;
                        case "tin":
                            bangDiemCaNhan.Dtin = dtb;
                            heso = dsHeSoMonHoc.tin;
                            break;
                        case "tduc":
                            bangDiemCaNhan.Dtduc = dtb;
                            heso = dsHeSoMonHoc.tduc;
                            break;
                        case "gdcd":
                            bangDiemCaNhan.Dgdcd = dtb;
                            heso = dsHeSoMonHoc.gdcd;
                            break;
                        case "qphong":
                            bangDiemCaNhan.Dqphong = dtb;
                            heso = dsHeSoMonHoc.qphong;
                            break;
                        case "cnghe":
                            bangDiemCaNhan.Dcnghe = dtb;
                            heso = dsHeSoMonHoc.cnghe;
                            break;
                    }
                    if (!Convert.ToString(dtb).Equals("_"))
                    {
                        tongDiem += heso*Convert.ToDouble(dtb);
                        tongHeSo += heso;
                        soMonDuDiem++;
                    }
                }
                if (soMonDuDiem == soMonHoc)
                {
                    bangDiemCaNhan.DTB = ObjectUtil.LamTron(tongDiem/tongHeSo, 2);
                }
                else
                    bangDiemCaNhan.DTB = "_";

                bangDiemHocKy.Add(bangDiemCaNhan);
            }

            return bangDiemHocKy;
        }

        /// <summary>
        /// Lấy bảng tổng kết môn học theo học kỳ của lớp
        /// </summary>
        /// <param name="maKhoi"></param>
        /// <param name="maHocKy">String: Mã học kỳ</param>
        /// <param name="maMonHoc">String: Mã môn học</param>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <returns>List TongKetMonDTO</returns>
        public List<TongKetMonDTO> LayList_BangTongKet_MonHoc_Khoi_HocKy(string maMonHoc, string maKhoi, string maHocKy,
                                                                         string maNamHoc)
        {
            // Lấy tất cả các lớp trong khối
            IEnumerable<LopDTO> dsLop = _lopDAL.LayListLop_MaNam_MaKhoi(maNamHoc, maKhoi);
            var bangDiemTongKetMon = new List<TongKetMonDTO>();
            int stt = 1;
            foreach (LopDTO lop in dsLop)
            {
                // Kiểm tra đã nhập điểm đủ cho lớp này hay chưa
                int siSo = _phanLopDAL.Dem_SiSo_Lop(lop.MaLop);
                DataTable bdiemLop = _bangDiemDAL.LayBangDiem_MonHoc_Lop(lop.MaLop, maMonHoc, maHocKy);
                // Tính toán số lượng đạt và tỉ lệ
                double diemDat = _quyDinhBUS.LayDiemChuan_DatMon();
                int soLuongDat = 0;

                // Chưa nhập đủ điểm
                if (bdiemLop.Rows.Count == siSo)
                {
                    foreach (DataRow dr in bdiemLop.Rows)
                    {
                        if (Convert.ToDouble(dr["DTB"]) >= diemDat)
                            soLuongDat++;
                    }
                }

                // tạo bảng báo cáo tổng kết môn
                bangDiemTongKetMon.Add(new TongKetMonDTO
                                           {
                                               STT = stt++,
                                               TenGiaoVien = lop.GiaoVien.TenGiaoVien,
                                               TenLop = lop.TenLop,
                                               SiSo = siSo,
                                               SoLuongDat =
                                                   (siSo > 0 && bdiemLop.Rows.Count == siSo)
                                                       ? soLuongDat.ToString()
                                                       : "__",
                                               TyLe =
                                                   (siSo > 0 && bdiemLop.Rows.Count == siSo)
                                                       ? ((soLuongDat*100)/siSo).ToString()
                                                       : "__"
                                           });
            }
            return bangDiemTongKetMon;
        }

        /// <summary>
        /// Tính điểm trung bình cho học sinh / học kỳ
        /// </summary>
        /// <param name="maHocSinh">string: mã học sinh</param>
        /// <param name="maLop">string: mã lớp</param>
        /// <param name="maHocKy">string: mã học kỳ</param>
        /// <returns></returns>
        public double TinhDTB_HocSinh_Lop_HocKy(string maHocSinh, string maLop, string maHocKy)
        {
            // Lấy bảng điểm học sinh ở học kỳ hiện tại
            DataTable bdHocSinh = _bangDiemDAL.LayBangDiem_HocKy_HocSinh(maLop, maHocSinh, maHocKy);
            double tongHeSo = 0, tongDiem = 0;
            // Duyệt từng môn và tính điểm TB
            foreach (DataRow bdmon in bdHocSinh.Rows)
            {
                if (bdmon["DTB"] is DBNull)
                {
                    return 0;
                }
                double heSo = Convert.ToDouble(bdmon["HeSo"]);
                tongHeSo += heSo;
                tongDiem += Convert.ToDouble(bdmon["DTB"])*heSo;
            }
            return ObjectUtil.LamTron(tongDiem/tongHeSo, 2);
        }

        /// <summary>
        /// Lấy bảng tổng kết theo học kỳ của khối
        /// </summary>
        /// <param name="maKhoi"></param>
        /// <param name="maHocKy">String: Mã học kỳ</param>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <returns></returns>
        public IList<TongKetHocKyDTO> LayList_BangTongKet_Khoi_HocKy(string maKhoi, string maHocKy, string maNamHoc)
        {
            IList<TongKetHocKyDTO> bangDiemTongKetHocKy = new List<TongKetHocKyDTO>();

            // Lấy danh sách các lớp trong khối hiện tại
            IEnumerable<LopDTO> dsLop = _lopDAL.LayListLop_MaNam_MaKhoi(maNamHoc, maKhoi);

            int stt = 1, siSo;
            double diemDat = _quyDinhBUS.LayDiemChuan_DatMon();

            // Đánh giá tỉ lệ từng lớp
            foreach (LopDTO lop in dsLop)
            {
                int soLuongDat = 0;
                IList<HocSinhDTO> listHsLop = _hocSinhDAL.LayList_HocSinh_LopHoc(lop.MaLop);
                siSo = listHsLop.Count;

                bool duDieuKienXetTiLe;
                if (siSo != 0)
                {
                    // Duyệt từng học sinh trong lớp hiện tại, kiểm tra DTB, tính tỉ lệ
                    duDieuKienXetTiLe = true;
                    foreach (HocSinhDTO hs in listHsLop)
                    {
                        double dTBinhHs = TinhDTB_HocSinh_Lop_HocKy(hs.MaHocSinh, lop.MaLop, maHocKy);
                        if (dTBinhHs == 0)
                        {
                            duDieuKienXetTiLe = false;
                            break;
                        }
                        if (dTBinhHs >= diemDat)
                        {
                            soLuongDat++;
                        }
                    }
                }
                else
                    duDieuKienXetTiLe = false;

                bangDiemTongKetHocKy.Add(new TongKetHocKyDTO
                                             {
                                                 STT = stt++,
                                                 TenLop = lop.TenLop,
                                                 TenGiaoVien = lop.GiaoVien.TenGiaoVien,
                                                 SiSo = siSo,
                                                 SoLuongDat = duDieuKienXetTiLe ? soLuongDat.ToString() : "__",
                                                 TyLe = duDieuKienXetTiLe ? ((soLuongDat*100)/siSo).ToString() : "__"
                                             });
            }
            return bangDiemTongKetHocKy;
        }
    }
}