using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
  public class ThuLaiPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachThuLai()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuLai");
            m_Ds.Load(cmd);

            return m_Ds;
        }

      public DataTable LayDSLaiSuat()
      {
          SqlCommand cmd = new SqlCommand("SELECT  T.MaSoKU, T.MaThoiHanVay, ThuLai.NgayTL,ThuLai.SoTienGoc, ThuLai.SoTienLaiTH, ThuLai.SoTienLaiQH, ThuLai.NgayTinhLai, T.LaiSuat, T.LSQuaHan FROM (  SELECT HoSoKheUoc.MaSoKU, HoSoKheUoc.MaThoiHanVay,LaiSuat.LaiSuat, LaiSuat.LSQuaHan FROM HoSoKheUoc LEFT JOIN  LaiSuat ON HoSoKheUoc.MaLaiSuat = LaiSuat.MaLaiSuat)T LEFT JOIN ThuLai ON T.MaSoKU = ThuLai.MaSoKU");
          m_Ds.Load(cmd);
          return m_Ds;
      }

        public DataTable LayThuLai(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuLai WHERE SoButToan = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }
      public DataTable LayTinhLai(String maku)
      {
          SqlCommand cmd = new SqlCommand("SELECT HoSoKheUoc.NgayTra, LaiSuat.LaiSuat, LaiSuat.LSQuaHan, HoSoKheUoc.MaSoKU, ThuLai.NgayTL, ThuLai.SoTienGoc, ThuLai.SoTienLaiTH,ThuLai.SoTienLaiQH, ThuLai.NgayTinhLai FROM HoSoKheUoc INNER JOIN LaiSuat ON HoSoKheUoc.MaLaiSuat = LaiSuat.MaLaiSuat INNER JOIN ThuLai ON HoSoKheUoc.MaSoKU = ThuLai.MaSoKU WHERE HoSoKheUoc.MaSoKU = @maku");
          cmd.Parameters.Add("maku", SqlDbType.Char, 10).Value = maku;

          m_Ds.Load(cmd);

          return m_Ds;
      }


        public DataTable TimThuLaiTheoMaSoKU(String masoku)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuLai WHERE MaSoKU LIKE '%' + @masoku +'%' ");
            cmd.Parameters.Add("masoku", SqlDbType.NVarChar, 50).Value = masoku;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimThuLaiTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuLai WHERE SoButToan LIKE '%' + @ma +'%' ");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar, 50).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }

        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }

        public bool Save()
        {
            return (m_Ds.ExecuteNoneQuery() > 0);
        }
    }
}
