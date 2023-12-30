
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class NamHocData
    {
        DataService ser = new DataService();
        SqlCommand com;
        public NamHocData()
        {
        }
        public DataTable LayDSNamHoc()
        {
            SqlCommand com = new SqlCommand("Select * from NamHoc");
            ser.Load(com);
            return ser;
        }
        public void Update()
        {
            ser.Update();
        }
        public void ThemNamHoc(QLKTX.BusinessObject.NamHocInfo namhoc)
        {
            com = new SqlCommand();
            com.CommandText = "Insert Into NamHoc values(@maso,@ten,@ngayBatdau,@ngayKetThuc)";
            com.Parameters.Add("@maso", SqlDbType.VarChar, 5).Value = namhoc.MaNamHoc;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = namhoc.TenNamHoc;
            com.Parameters.Add("@ngayBatDau", SqlDbType.DateTime).Value = namhoc.NgayBatDau;
            com.Parameters.Add("@ngayKetThuc", SqlDbType.DateTime).Value = namhoc.NgayKetThuc;

            ser.Load(com);
        }

        public void XoaNamHoc(QLKTX.BusinessObject.NamHocInfo namhoc)
        {
            com = new SqlCommand();
            com.CommandText = "Delete NamHoc where MANAMHOC=@maso";
            com.Parameters.Add("@maso", SqlDbType.VarChar, 5).Value = namhoc.MaNamHoc;            

            ser.Load(com);
        }

        public void SuaNamHoc(QLKTX.BusinessObject.NamHocInfo namhoc)
        {
            com = new SqlCommand();
            com.CommandText = "Update NamHoc set TENNAMHOC = @ten,NGAYBATDAU= @ngayBatdau,NGAYKETTHUC=@ngayKetThuc where MANAMHOC=@maso";
            com.Parameters.Add("@maso", SqlDbType.VarChar, 5).Value = namhoc.MaNamHoc;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = namhoc.TenNamHoc;
            com.Parameters.Add("@ngayBatDau", SqlDbType.DateTime).Value = namhoc.NgayBatDau;
            com.Parameters.Add("@ngayKetThuc", SqlDbType.DateTime).Value = namhoc.NgayKetThuc;

            ser.Load(com);
        }

    }
}
