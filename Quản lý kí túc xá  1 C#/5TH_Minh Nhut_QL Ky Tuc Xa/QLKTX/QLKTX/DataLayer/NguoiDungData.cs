using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;

namespace QLKTX.DataLayer
{
    public class NguoiDungData
    {
        DataService ser = new DataService();
        public DataTable LayDSNguoiDung()
        {
            SqlCommand command = new SqlCommand("Select * from NguoiDung");
            ser.Load(command);
            return ser;
        }
        public DataTable LayDSNguoiDung_DK_DAY(string maday)
        {
            SqlCommand command = new SqlCommand("Select * from NguoiDung where MA=@ma");
            command.Parameters.Add("@ma", SqlDbType.Int).Value = maday;
            ser.Load(command);
            return ser;
        }
        public bool Them(NguoiDungInfo NguoiDung)
        {
            SqlCommand command = new SqlCommand("insert into NGUOIDUNG(MA,HOTEN,[USER],PASS,QUYEN)"
                                                          + " values(@ma,@hoten,@user,@pass,@quyen)");
            command.Parameters.Add("@ma", SqlDbType.Int).Value = NguoiDung.Ma;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar, 30).Value = NguoiDung.HoTen;
            command.Parameters.Add("@user", SqlDbType.VarChar, 32).Value = NguoiDung.Username;
            command.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = NguoiDung.Password;
            command.Parameters.Add("@quyen", SqlDbType.Char, 1).Value = NguoiDung.Quyen;
            
            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
            
        }
        public bool Xoa(NguoiDungInfo NguoiDung)
        {
            SqlCommand command = new SqlCommand("Delete NguoiDung where MA = @ma");
            command.Parameters.Add("@ma", SqlDbType.Int).Value = NguoiDung.Ma;

            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Sua(NguoiDungInfo NguoiDung)
        {

            SqlCommand command = new SqlCommand("Update NguoiDung set HOTEN=@hoten,"
                                    +"[USER]=@user,PASS=@pass,QUYEN=@quyen"+
                                    " where MA=@ma");
            command.Parameters.Add("@ma", SqlDbType.Int).Value = NguoiDung.Ma;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar, 30).Value = NguoiDung.HoTen;
            command.Parameters.Add("@user", SqlDbType.VarChar, 32).Value = NguoiDung.Username;
            command.Parameters.Add("@pass", SqlDbType.VarChar,32).Value = NguoiDung.Password;
            command.Parameters.Add("@quyen", SqlDbType.Char, 1).Value = NguoiDung.Quyen;
            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MA) from NGUOIDUNG");
            ser.Load(s);
            return ser;
        }        
    }
}
