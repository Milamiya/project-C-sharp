using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; 
namespace QLKTX.DataLayer
{
    public class ChuyenPhongData
    {
        DataService ser = new DataService();
        public DataTable LayDSSVThuocKTX(string MaKTX)
        {
            SqlCommand com = new SqlCommand();
            string sql="SELECT S.MAKTX,S.HOTEN,S.GIOITINH,P.MAPHG,P.TENPHG,D.TENDAY,K.TENKTX "
                    +"FROM SINHVIEN S, PHONG P, [DAY] D, KTX K, DSSINHVIEN_PHONG DS "
                    +"WHERE S.MAKTX=DS.MAKTX AND "
                    +"P.MAPHG=DS.MAPHG AND "
                    +"P.MADAY=D.MADAY AND "
                    +"D.KTX=K.KTX and K.KTX=@MaKTX";
            com.CommandText = sql;
            com.Parameters.Add("@MaKTX", SqlDbType.VarChar, 4).Value = MaKTX;
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSSVThuocPhong(string MaPHG)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT S.MAKTX,S.HOTEN,S.GIOITINH,P.MAPHG,P.TENPHG,D.TENDAY,K.TENKTX "
                    + "FROM SINHVIEN S, PHONG P, [DAY] D, KTX K, DSSINHVIEN_PHONG DS "
                    + "WHERE S.MAKTX=DS.MAKTX AND "
                    + "P.MAPHG=DS.MAPHG AND "
                    + "P.MADAY=D.MADAY AND "
                    + "D.KTX=K.KTX and P.MAPHG=@MaPHG";
            com.CommandText = sql;
            com.Parameters.Add("@MaPHG", SqlDbType.VarChar, 4).Value = MaPHG;
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSSVThuocDay(string MaDAY)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT S.MAKTX,S.HOTEN,S.GIOITINH,P.MAPHG,P.TENPHG,D.TENDAY,K.TENKTX "
                    + "FROM SINHVIEN S, PHONG P, [DAY] D, KTX K, DSSINHVIEN_PHONG DS "
                    + "WHERE S.MAKTX=DS.MAKTX AND "
                    + "P.MAPHG=DS.MAPHG AND "
                    + "P.MADAY=D.MADAY AND "
                    + "D.KTX=K.KTX and D.MADAY=@MaDAY";
            com.CommandText = sql;
            com.Parameters.Add("@MaDAY", SqlDbType.VarChar, 4).Value = MaDAY;
            ser.Load(com);
            return ser;
        }
        public void ChuyenPhong(string MaKTX, string MaPHGCu, string MaPHGMoi)
        {
            SqlCommand com = new SqlCommand();
            string sql = "Update DSSINHVIEN_PHONG set MAPHG=@Mamoi, NgayVao=@ngay where MAPHG=@Macu and MAKTX=@MAKTX";
            com.CommandText = sql;
            com.Parameters.Add("@Mamoi", SqlDbType.VarChar, 4).Value = MaPHGMoi;
            com.Parameters.Add("@ngay", SqlDbType.DateTime).Value = DateTime.Now;
            com.Parameters.Add("@MaCu", SqlDbType.VarChar, 4).Value = MaPHGCu;
            com.Parameters.Add("@MAKTX", SqlDbType.VarChar, 7).Value = MaKTX;
            ser.Load(com);

        }
        public DataTable SoSVTrongPhong(string MaPHG)
        {
            SqlCommand com = new SqlCommand();
            string sql = "select count(*) as so from DSSINHVIEN_PHONG where MAPHG=@MaPHG";
            com.CommandText = sql;
            com.Parameters.Add("@MaPHG", SqlDbType.VarChar, 4).Value = MaPHG;            
            ser.Load(com);
            return ser;
        }
        public DataTable SoSVToiDaTrongPhong(string MaPHG)
        {
            SqlCommand com = new SqlCommand();
            string sql = "select SOLUONGTOIDA from PHONG where MAPHG=@MaPHG";
            com.CommandText = sql;
            com.Parameters.Add("@MaPHG", SqlDbType.VarChar, 4).Value = MaPHG;
            ser.Load(com);
            return ser;
        }
        public DataTable KiemTraGioiTinh(string MAKTX, string MAPHG)
        {
            
            SqlCommand com = new SqlCommand();
            string sql = "select S.GioiTinh, p.PHONGNAM from SINHVIEN s,PHONG p "
                +"where p.MAPHG=@MAPHG and s.MAKTX=@MAKTX";
            com.CommandText = sql;
            com.Parameters.Add("@MAPHG", SqlDbType.VarChar, 4).Value = MAPHG;
            com.Parameters.Add("@MAKTX", SqlDbType.VarChar, 7).Value = MAKTX;
            ser.Load(com);
            return ser;
        }
    }
}
