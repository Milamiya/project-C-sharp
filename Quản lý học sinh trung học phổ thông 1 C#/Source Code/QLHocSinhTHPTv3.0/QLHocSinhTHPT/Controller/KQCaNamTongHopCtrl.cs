using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Collections.Generic;
using DevComponents.Editors;
using QLHocSinhTHPT.Bussiness;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class KQCaNamTongHopCtrl
    {
        #region Fields
        DiemCtrl            m_DiemCtrl           = new DiemCtrl();
        HocLucCtrl          m_HocLucCtrl         = new HocLucCtrl();
        KQCaNamTongHopData  m_KQCaNamTongHopData = new KQCaNamTongHopData();
        #endregion

        #region Luu ket qua
        public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc)
        {
            float diemTBChungCacMonCN = (float)Math.Round(m_DiemCtrl.DiemTrungBinhChungCacMonCaNam(maHocSinh, maLop, maNamHoc), 2);
            String hocLuc = m_HocLucCtrl.XepLoaiLocLucCaNam(maHocSinh, maLop, maNamHoc);
            String ketQua = "KQ0001";

            m_KQCaNamTongHopData.XoaKetQua(maHocSinh, maLop, maNamHoc);
            m_KQCaNamTongHopData.LuuKetQua(maHocSinh, maLop, maNamHoc, hocLuc, "HK0001", diemTBChungCacMonCN, ketQua);
        }
        #endregion

        #region Lay danh sach ket qua ca nam tong hop do vao report
        public static IList<KQCaNamTongHopInfo> LayDsKQCaNamTongHop(String maLop, String maNamHoc)
        {
            KQCaNamTongHopData m_KQCNTHData = new KQCaNamTongHopData();
            DataTable m_DT = m_KQCNTHData.LayDsKQCaNamTongHopForReport(maLop, maNamHoc);

            IList<KQCaNamTongHopInfo> dS = new List<KQCaNamTongHopInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQCaNamTongHopInfo ketqua = new KQCaNamTongHopInfo();

                HocSinhInfo hs      = new HocSinhInfo();
                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen            = Convert.ToString(Row["HoTen"]);

                LopInfo l           = new LopInfo();
                l.MaLop             = Convert.ToString(Row["MaLop"]);
                l.TenLop            = Convert.ToString(Row["TenLop"]);

                NamHocInfo nh       = new NamHocInfo();
                nh.MaNamHoc         = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc        = Convert.ToString(Row["TenNamHoc"]);

                HocLucInfo hl       = new HocLucInfo();
                hl.MaHocLuc         = Convert.ToString(Row["MaHocLuc"]);
                hl.TenHocLuc        = Convert.ToString(Row["TenHocLuc"]);

                HanhKiemInfo hkiem  = new HanhKiemInfo();
                hkiem.MaHanhKiem    = Convert.ToString(Row["MaHanhKiem"]);
                hkiem.TenHanhKiem   = Convert.ToString(Row["TenHanhKiem"]);

                KetQuaInfo kq       = new KetQuaInfo();
                kq.MaKetQua         = Convert.ToString(Row["MaKetQua"]);
                kq.TenKetQua        = Convert.ToString(Row["TenKetQua"]);

                ketqua.HocSinh      = hs;
                ketqua.Lop          = l;
                ketqua.NamHoc       = nh;
                ketqua.HocLuc       = hl;
                ketqua.HanhKiem     = hkiem;
                ketqua.KetQua       = kq;
                ketqua.DTBCaNam     = Convert.ToSingle(Row["DTBCaNam"]);

                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion
    }
}
