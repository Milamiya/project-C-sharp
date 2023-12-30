using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class XepPhongSinhVienData
    {
        
        public DataTable LayDSSinhVien_ChuaXepPhong()
        {
            DataService ser = new DataService();
            string sql = "select MAKTX,HOTEN,NAMSINH,GIOITINH from SinhVien where MAKTX not in (select MAKTX from DSSinhVien_Phong)";
            SqlCommand command = new SqlCommand(sql);
            ser.Load(command);
            return ser;
        }
        public DataTable LayDSSinhVien_ThuocPhong(string maPhong)
        {
            DataService ser = new DataService();
            string sql = "select S.MAKTX,S.HOTEN,S.NAMSINH,S.GIOITINH,P.PHONGNAM from SinhVien S,PHONG P,DSSINHVIEN_PHONG D where S.MAKTX=D.MAKTX AND D.MAPHG=P.MAPHG AND S.MAKTX in (select F.MAKTX from DSSinhVien_Phong F where F.MAPHG=@maphg)";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maPhong;
            ser.Load(command);
            return ser;
        }
        public DataTable LayDSSinhVien_ThuocDay(string maday)
        {
            DataService ser = new DataService();
            string sql = "SELECT sv.MAKTX,sv.HOTEN,sv.NAMSINH,sv.GIOITINH,P.PHONGNAM " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND  d.MADAY=@maday";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = maday;
            ser.Load(command);
            return ser;
        }
        public DataTable LayDSSinhVien_ThuocKTX(string maktx)
        {
            DataService ser = new DataService();
            string sql = "SELECT sv.MAKTX,sv.HOTEN,sv.NAMSINH,sv.GIOITINH,P.PHONGNAM " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND k.KTX=@maktx";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.Add("@maktx", SqlDbType.VarChar, 4).Value = maktx;
            ser.Load(command);
            return ser;
        }

        public void LayDSSinhVien_XepPhong(string maKTX,string maPhong)
        {
            DataService ser = new DataService();
            string sql = "insert into DSSinhVien_Phong(MAKTX,MAPHG,NGAYVAO) values(@maktx,@maphg,@ngay)";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maPhong;
            command.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = maKTX;
            command.Parameters.Add("@ngay", SqlDbType.SmallDateTime).Value = DateTime.Now;
            ser.Load(command);
            
        }
        public void LayDSSinhVien_XoaPhong(string maKTX, string maPhong)
        {
            DataService ser = new DataService();
            string sql = "delete DSSinhVien_Phong where MAKTX = @maktx and MAPHG=@maphg";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maPhong;
            command.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = maKTX;            
            ser.Load(command);

        }
    }
}
