using System;
using System.Collections.Generic;
using System.Text;
using QLKTX.BusinessObject;
using System.Data.SqlClient;
using System.Data;

namespace QLKTX.DataLayer
{
    public class ThanNhanData
    {
        DataService ser = new DataService();
        public bool ThemVaoCSDL(ThanNhanInfo tn)
        {
            String sql = "Insert into ThanNhan(MATHANNHAN,MAKTX,HOTEN,NGHENGHIEP,QUANHE) VALUES("+
                                                "@mathannha,@maktx,@hoten,@nghenghiep,@quanhe)";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.Add("@mathannha", SqlDbType.Int).Value = tn.MaThanNhan;
            command.Parameters.Add("@maktx",SqlDbType.NVarChar,7).Value = tn.SinhVien.MaKTX;
            command.Parameters.Add("@hoten",SqlDbType.NVarChar,30).Value = tn.HoTenThanNhan;
            command.Parameters.Add("@nghenghiep",SqlDbType.Int).Value = tn.NgheNghiep.MaNgheNghiep;
            command.Parameters.Add("@quanhe", SqlDbType.Int).Value = tn.QuanHe.MaQuanHe;
            //try
            {
                
                ser.Load(command);
                return true;
            }
            //catch (Exception e)
            {
              //  e.ToString();
                return false;
            }
        }
        public bool XoaRaKhoiCSDL(ThanNhanInfo tn)
        {
            String sql = "DELETE ThanNhan where MATHANNHAN=" + tn.MaThanNhan + " and MAKTX='" + tn.SinhVien.MaKTX + "'";
            try
            {
                SqlCommand command = new SqlCommand(sql);
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
    }
}
