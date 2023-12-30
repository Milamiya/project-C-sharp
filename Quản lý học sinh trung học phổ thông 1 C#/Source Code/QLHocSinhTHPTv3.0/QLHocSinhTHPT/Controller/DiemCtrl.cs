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
    public class DiemCtrl
    {
        #region Fields
        DiemData    m_DiemData      = new DiemData();
        HocKyData   m_HocKyData     = new HocKyData();
        MonHocData  m_MonHocData    = new MonHocData();
        #endregion

        #region Luu diem
        public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, float diemSo)
        {
            m_DiemData.LuuDiem(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop, maLoaiDiem, diemSo);
        }
        #endregion

        #region Xoa diem
        public void XoaDiem(int stt)
        {
            m_DiemData.XoaDiem(stt);
        }
        #endregion

        #region Hien thi danh sach xem diem
        public void HienThiDanhSachXemDiem(ListViewEx lVXemDiem, String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {
            lVXemDiem.Items.Clear();

            DataTable m_DT = m_DiemData.LayDsDiem(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
            
            foreach (DataRow row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                
                item.Text = row["STT"].ToString();
                item.SubItems.Add(row["MaHocSinh"].ToString());
                item.SubItems.Add(row["HoTen"].ToString());
                item.SubItems.Add(row["TenMonHoc"].ToString());
                item.SubItems.Add(row["TenLoai"].ToString());
                item.SubItems.Add(row["Diem"].ToString());
                
                lVXemDiem.Items.Add(item);
            }
        }
        #endregion

        #region Tinh diem trung binh
        public float DiemTrungBinhKiemTra(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {
            DataTable m_DT = m_DiemData.LayDsDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);

            float tongDiem  = 0;
            int   tongHeSo  = 0;

            foreach (DataRow row in m_DT.Rows)
            {
                if (row["MaLoai"].ToString() != "LD0004")
                {
                    tongDiem += Convert.ToSingle(row["Diem"].ToString()) * Convert.ToInt32(row["HeSo"].ToString());
                    tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
                }
            }

            if (tongHeSo > 0)
                return tongDiem / tongHeSo;
            else
                return 0;
        }

        public float DiemTrungBinhMonHocKy(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {
            DataTable m_DT = m_DiemData.LayDsDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);

            float tongDiem = 0;
            int   tongHeSo = 0;

            foreach (DataRow row in m_DT.Rows)
            {
                tongDiem += Convert.ToSingle(row["Diem"].ToString()) * Convert.ToInt32(row["HeSo"].ToString());
                tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
            }

            if (tongHeSo > 0)
                return tongDiem / tongHeSo;
            else
                return 0;
        }

        public float DiemTrungBinhChungCacMonHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            float tongDiemCacMon = 0;
            float diemTBTungMon  = 0;
            int   tongHeSoCacMon = 0;

            DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);
            
            foreach (DataRow row in m_DT.Rows)
            {
                diemTBTungMon   =   DiemTrungBinhMonHocKy(maHocSinh, row["MaMonHoc"].ToString(), maHocKy, maNamHoc, maLop);
                tongDiemCacMon  +=  diemTBTungMon * Convert.ToInt32(row["HeSo"].ToString());
                tongHeSoCacMon  +=  Convert.ToInt32(row["HeSo"].ToString());
            }
            if (tongHeSoCacMon > 0)
                return tongDiemCacMon / tongHeSoCacMon;
            else
                return 0;
        }

        public float DiemTrungBinhChungCacMonCaNam(String maHocSinh, String maLop, String maNamHoc)
        {
            float tongDiemCacMon = 0;
            float diemTBTungMon  = 0;
            int tongHeSoCacMon   = 0;

            DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);

            foreach (DataRow row in m_DT.Rows)
            {
                diemTBTungMon = DiemTrungBinhMonCaNam(maHocSinh, row["MaMonHoc"].ToString(), maNamHoc, maLop);
                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSo"].ToString());
                tongHeSoCacMon += Convert.ToInt32(row["HeSo"].ToString());
            }
            if (tongHeSoCacMon > 0)
                return tongDiemCacMon / tongHeSoCacMon;
            else
                return 0;
        }

        public float DiemTrungBinhMonCaNam(String maHocSinh, String maMonHoc, String maNamHoc, String maLop)
        {
            DataTable m_DT = new DataTable();
            m_DT = m_HocKyData.LayDsHocKy();

            float tongDiem  = 0;
            int   tongHeSo  = 0;

            foreach (DataRow row in m_DT.Rows)
            {
                tongDiem += DiemTrungBinhMonHocKy(maHocSinh, maMonHoc, row["MaHocKy"].ToString(), maNamHoc, maLop) * Convert.ToInt32(row["HeSo"].ToString());
                tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
            }

            if (tongHeSo > 0)
                return tongDiem / tongHeSo;
            else
                return 0;
        }
        #endregion
    }
}