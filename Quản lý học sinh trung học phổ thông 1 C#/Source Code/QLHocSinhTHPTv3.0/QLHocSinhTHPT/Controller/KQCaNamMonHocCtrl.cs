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
    public class KQCaNamMonHocCtrl
    {
        #region Fields
        DiemCtrl            m_DiemCtrl          = new DiemCtrl();
        KQCaNamMonHocData   m_KQCaNamMonHocData = new KQCaNamMonHocData();
        #endregion

        #region Luu ket qua
        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            float diemTBMonCN   = (float)Math.Round(m_DiemCtrl.DiemTrungBinhMonCaNam(maHocSinh, maMonHoc, maNamHoc, maLop), 2);
            float diemThiLai    = 0;

            m_KQCaNamMonHocData.XoaKetQua(maHocSinh, maLop, maMonHoc, maNamHoc);
            m_KQCaNamMonHocData.LuuKetQua(maHocSinh, maLop, maMonHoc, maNamHoc, diemThiLai, diemTBMonCN);
        }
        #endregion

        #region Lay danh sach ket qua ca nam mon hoc do vao report
        public static IList<KQCaNamMonHocInfo> LayDsKQCaNamMonHoc(String maLop, String maMonHoc, String maNamHoc)
        {
            KQCaNamMonHocData m_KQCNMHData = new KQCaNamMonHocData();
            DataTable m_DT = m_KQCNMHData.LayDsKQCaNamMonHocForReport(maLop, maMonHoc, maNamHoc);

            IList<KQCaNamMonHocInfo> dS = new List<KQCaNamMonHocInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQCaNamMonHocInfo ketqua = new KQCaNamMonHocInfo();

                HocSinhInfo hs      = new HocSinhInfo();
                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen            = Convert.ToString(Row["HoTen"]);

                LopInfo l           = new LopInfo();
                l.MaLop             = Convert.ToString(Row["MaLop"]);
                l.TenLop            = Convert.ToString(Row["TenLop"]);

                MonHocInfo mh       = new MonHocInfo();
                mh.MaMonHoc         = Convert.ToString(Row["MaMonHoc"]);
                mh.TenMonHoc        = Convert.ToString(Row["TenMonHoc"]);        

                NamHocInfo nh       = new NamHocInfo();
                nh.MaNamHoc         = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc        = Convert.ToString(Row["TenNamHoc"]);

                ketqua.HocSinh      = hs;
                ketqua.Lop          = l;
                ketqua.MonHoc       = mh;
                ketqua.NamHoc       = nh;
                ketqua.DiemThiLai   = Convert.ToSingle(Row["DiemThiLai"]);
                ketqua.DTBCaNam     = Convert.ToSingle(Row["DTBCaNam"]);

                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion
    }
}
