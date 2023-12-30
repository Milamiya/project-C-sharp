using System.Collections.Generic;
using QLHS.DAL;
using QLHS.DTO;

namespace QLHS.BUS
{
    public class ChuyenLopBUS
    {
        private readonly BangDiemBUS _bangDiemBUS;
        private readonly ChuyenLopDAL _chuyenLopDAL;
        private readonly PhanLopBUS _phanLopBUS;

        public ChuyenLopBUS()
        {
            _chuyenLopDAL = new ChuyenLopDAL();
            _phanLopBUS = new PhanLopBUS();
            _bangDiemBUS = new BangDiemBUS();
        }

        public bool ChuyenLop_HocSinh_Lop(Dictionary<string, string> dsHocSinhChon, ChuyenLopDTO thongTinCL)
        {
            IList<bool> listSuccess = new List<bool>();
            foreach (var item in dsHocSinhChon)
            {
                if (thongTinCL.GiuLaiBangDiem)
                    _bangDiemBUS.CapNhat_BangDiem_HocSinh_LopMoi(item.Key, thongTinCL.TuLop, thongTinCL.DenLop);
                else
                    _bangDiemBUS.XoaBangDiem_HocSinh_Lop(item.Key, thongTinCL.TuLop);

                if (!_phanLopBUS.KiemTraTonTai_HocSinh_TrongLop(item.Key, thongTinCL.DenLop))
                {
                    _phanLopBUS.ThayDoi_LopMoi_HocSinh(item.Key, thongTinCL.TuLop, thongTinCL.DenLop);
                }
                listSuccess.Add(_chuyenLopDAL.Luu_ThongTin_ChuyenLop(item.Key, thongTinCL));
            }
            foreach (bool item in listSuccess)
            {
                if (!item)
                    return false;
            }
            return true;
        }

        public bool KiemTraHocSinh_ThuocLop_DuocChuyenTuLop(string maHocSinh, string maLopMoi, string maLopCu)
        {
            return _chuyenLopDAL.KiemTra_HocSinhThuocLop_DuocChuyenTuLop(maHocSinh, maLopMoi, maLopCu);
        }

        public bool Xoa_ChuyenLop(string maHocSinh, string tuLop, string denLop)
        {
            return _chuyenLopDAL.Xoa_ChuyenLop(maHocSinh, tuLop, denLop);
        }
    }
}