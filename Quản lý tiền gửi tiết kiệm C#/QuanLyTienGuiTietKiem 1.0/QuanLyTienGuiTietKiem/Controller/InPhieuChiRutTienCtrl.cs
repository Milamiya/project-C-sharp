using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.DataLayer;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class InPhieuChiRutLaiCtrl
    {
        #region STK

        public static IList<InPhieuChiInfo> LayDsSoTietKiemTheoMa(String MaSoTK)
        {
            IList<InPhieuChiInfo> ds = new List<InPhieuChiInfo>();

            InPhieuChiRutLaiData data = new InPhieuChiRutLaiData();
            DataTable tbl = data.LaySoTheoMa(MaSoTK);

            IList<InPhieuChiInfo> TK = new List<InPhieuChiInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                InPhieuChiInfo PT = new InPhieuChiInfo();

                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.HoTen = Convert.ToString(row["HoTen"]);
                m_KH.CMND = Convert.ToString(row["CMND"]);
                m_KH.DiaChi = Convert.ToString(row["DiaChi"]);

                ChiTietPhatSinhGDInfo m_PSGD = new ChiTietPhatSinhGDInfo();
                m_PSGD.SoTien = Convert.ToInt64(row["SoTien"]);
                //m_PSGD.SoHieuTaiKhoanCo.SoHieuTaiKhoan = Convert.ToString(row["SoHieuTaiKhoanCo"]);
                

                DMTaiKhoanInfo m_DMTK = new DMTaiKhoanInfo();
                m_DMTK.TenTaiKhoan = Convert.ToString(row["TenTaiKhoan"]);
                //m_DMTK.SoHieuTaiKhoan = Convert.ToString(row["SoHieuTaiKhoan"]);

                SoTietKiemInfo m_STK = new SoTietKiemInfo();
                m_STK.MaSoTietKiem = Convert.ToString(row["MaSoTietKiem"]);
                m_STK.LaiDaTra = Convert.ToInt64(row["LaiDaTra"]);

                LoaiTietKiemInfo m_LTK = new LoaiTietKiemInfo();
                  m_LTK.TenLoaiTietKiem = Convert.ToString("TenLoaiTietKiem");

                DMLoaiTienInfo m_DMT = new DMLoaiTienInfo();
                m_DMT.LoaiTien = Convert.ToString(row["LoaiTien"]);

                PT.KhachHang = m_KH;
                PT.ChiTietPhatSinhGD = m_PSGD;
                PT.LoaiTietKiem = m_LTK;
                PT.SoTietKiem = m_STK;
                PT.DMTaiKhoan = m_DMTK;

                PT.DMLoaiTien = m_DMT;

                TK.Add(PT);
            }
            return TK;
        }

        public static String LaySoTienTheoMa(String MaSoTK)
        {
            InPhieuThuData data = new InPhieuThuData();
            DataTable tbl = data.LaySoTheoMa(MaSoTK);

            String soTien = Convert.ToString(tbl.Rows[0]["SoTien"]);

            return soTien;
        }

        #endregion
    }
}
