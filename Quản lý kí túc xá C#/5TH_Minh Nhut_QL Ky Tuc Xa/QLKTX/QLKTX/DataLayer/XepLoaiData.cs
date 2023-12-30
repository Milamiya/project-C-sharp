using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;
namespace QLKTX.DataLayer
{
    public class XepLoaiData
    {
        DataService ser = new DataService();
        SqlCommand com = null;
        public DataTable LayDSXepLoai()
        {
            SqlCommand com = new SqlCommand("Select * from XEPLOAI");
            ser.Load(com);
            return ser;
        }
        public bool Them(XepLoaiInfo xeploai)
        {
            SqlCommand com = new SqlCommand("Insert into XEPLOAI(MAXEPLOAI,TENXEPLOAI,DIEMCANTREN,DIEMCANDUOI) values(@ma,@ten,@cantren,@canduoi)");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = xeploai.MaXepLoai;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = xeploai.TenXepLoai;
            com.Parameters.Add("@cantren", SqlDbType.Decimal).Value = xeploai.DiemCanTren;
            com.Parameters.Add("@canduoi", SqlDbType.Decimal).Value = xeploai.DiemCanDuoi;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Xoa(XepLoaiInfo xeploai)
        {
            SqlCommand com = new SqlCommand("Delete XEPLOAI where MAXEPLOAI=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = xeploai.MaXepLoai;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Sua(XepLoaiInfo xeploai)
        {
            SqlCommand com = new SqlCommand("Update XEPLOAI set TENXEPLOAI=@ten, DIEMCANTREN=@cantren, DIEMCANDUOI=@canduoi where MACAP=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = xeploai.MaXepLoai;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = xeploai.TenXepLoai;
            com.Parameters.Add("@cantren", SqlDbType.Decimal).Value = xeploai.DiemCanTren;
            com.Parameters.Add("@canduoi", SqlDbType.Decimal).Value = xeploai.DiemCanDuoi;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public DataTable LayMaLonNhat()
        {
            SqlCommand com = new SqlCommand("Select MAX(MAXEPLOAI) from XEPLOAI");
            ser.Load(com);
            return ser;
        }
        //////////////
        public void ThemXepLoai(QLKTX.BusinessObject.XepLoaiInfo xeploai)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "Insert Into XepLoai(MAXEPLOAI,TENXEPLOAI,DIEMCANTREN,DIEMCANDUOI) values(@maso,@ten,@diemCanTren,@diemCanDuoi)";
            com.Parameters.Add("@maso", SqlDbType.VarChar, 5).Value = xeploai.MaXepLoai;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = xeploai.TenXepLoai;
            com.Parameters.Add("@diemCanTren", SqlDbType.Decimal).Value = xeploai.DiemCanTren;
            com.Parameters.Add("@diemCanDuoi", SqlDbType.Decimal).Value = xeploai.DiemCanDuoi;

            ser.Load(com);
        }

        public void XoaXepLoai(QLKTX.BusinessObject.XepLoaiInfo namhoc)
        {
            com = new SqlCommand();
            com.CommandText = "Delete XepLoai where MAXEPLOAI=@maso";
            com.Parameters.Add("@maso", SqlDbType.VarChar, 5).Value = namhoc.MaXepLoai;

            ser.Load(com);
        }

        public void SuaXepLoai(QLKTX.BusinessObject.XepLoaiInfo xeploai)
        {
            com = new SqlCommand();
            com.CommandText = "Update XepLoai set TENXEPLOAI = @ten,DIEMCANTREN= @diemCanTren,DIEMCANDUOI=@diemCanDuoi where MAXEPLOAI=@maso";
            com.Parameters.Add("@maso", SqlDbType.VarChar, 5).Value = xeploai.MaXepLoai;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = xeploai.TenXepLoai;
            com.Parameters.Add("@diemCanTren", SqlDbType.Decimal).Value = xeploai.DiemCanTren;
            com.Parameters.Add("@diemCanDuoi", SqlDbType.Decimal).Value = xeploai.DiemCanDuoi;

            ser.Load(com);
        }
    }
}

