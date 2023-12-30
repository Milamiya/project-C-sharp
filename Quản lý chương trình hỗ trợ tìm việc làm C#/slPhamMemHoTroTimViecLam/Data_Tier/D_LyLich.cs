using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.OleDb;

namespace Data_Tier
{
   public class D_LyLich : General_Data
    {
       public DataSet getlylich_TheoTaiKhoan(string tentk)
       {
           OleDbCommand cmd = new OleDbCommand("select * from LyLichCaNhan where tentk=@tentk",conn);
           cmd.Parameters.Add("@tentk", OleDbType.BSTR).Value = tentk;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds,"LyLichCaNhan");
           return ds;
       }
       public DataSet getlylichtheoma(string ma)
       {
           OleDbCommand cmd = new OleDbCommand("select * from LyLichCaNhan where ma=@ma", conn);
           cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = ma;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "LyLichCaNhan");
           return ds;
       }
       public int ThemLyLich(Ly_Lich lylich)
        {
          
               try
               {
                   conn.Open();
                   OleDbCommand cmd = new OleDbCommand("insert into lylichcanhan values(@ma,@ten,@quequan,@diachithuongtru,@diachitamtru,@sdt,@cmnd,@tinhhinhsuckhoe,@tentk,@madn)", conn);
                   cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = lylich.Ma;
                   cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = lylich.Ten;
                   cmd.Parameters.Add("@quequan", OleDbType.BSTR).Value = lylich.QueQuan;
                   cmd.Parameters.Add("@diachithuongtru", OleDbType.BSTR).Value = lylich.DiaChiThuongTru;
                   cmd.Parameters.Add("@diachitamtru", OleDbType.BSTR).Value = lylich.DiaChiTamTru;
                   cmd.Parameters.Add("@sdt", OleDbType.BSTR).Value = lylich.SDT;
                   cmd.Parameters.Add("@cmnd", OleDbType.BSTR).Value = lylich.CMND;
                   cmd.Parameters.Add("@tinhhinhsuckhoe", OleDbType.BSTR).Value = lylich.Tinhhinhsuckhoe;
                   cmd.Parameters.Add("@tentk", OleDbType.BSTR).Value = lylich.TenTK;
                   cmd.Parameters.Add("@madn", OleDbType.BSTR).Value = lylich.MaDN;
                   cmd.ExecuteNonQuery();
                   conn.Close();
                   return 0;
               }
               catch (Exception ex)
               {
                   return 1;
               }


       }
       public int XoaLyLich(string ma)
       {
           if (TimKiem(ma) == false)
           {
               return 2;
           }
           conn.Open();
           OleDbCommand cmd = new OleDbCommand("delete from lylichcanhan where ma=@ma", conn);
           cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = ma;
           cmd.ExecuteNonQuery();
           conn.Close();
           return 0;


       }
       public int CapNhatLyLich(Ly_Lich lylich)
       {
           if (TimKiem(lylich.Ma) == false)
           {
               return 2;
           }
           conn.Open();
           OleDbCommand cmd = new OleDbCommand("update lylichcanhan set ma=@ma,ten=@ten,quequan=@quequan,diachithuongtru=@diachithuongtru,diachitamtru=@diachitamtru,sdt=@sdt,cmnd=@cmnd,tinhhinhsuckhoe=@tinhhhinhsuckhoe,tentk=@tentk,madn=@madn where ma=@ma", conn);
           cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = lylich.Ma;
           cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = lylich.Ten;
           cmd.Parameters.Add("@quequan", OleDbType.BSTR).Value = lylich.QueQuan;
           cmd.Parameters.Add("@diachithuongtru", OleDbType.BSTR).Value = lylich.DiaChiThuongTru;
           cmd.Parameters.Add("@diachitamtru", OleDbType.BSTR).Value = lylich.DiaChiTamTru;
           cmd.Parameters.Add("@sdt", OleDbType.BSTR).Value = lylich.SDT;
           cmd.Parameters.Add("@cmnd", OleDbType.BSTR).Value = lylich.CMND;
           cmd.Parameters.Add("@tinhhinhsuckhoe", OleDbType.BSTR).Value = lylich.Tinhhinhsuckhoe;
           cmd.Parameters.Add("@tentk", OleDbType.BSTR).Value = lylich.TenTK;
           cmd.Parameters.Add("@madn", OleDbType.BSTR).Value = lylich.MaDN;
           cmd.ExecuteNonQuery();
           conn.Close();
           return 0;

       }
       public bool TimKiem(string ma)
       {
           try
           {
               conn.Open();
               string strSQL = "Select count(*) From lylichcanhan Where Ma ='" + ma + "'";
               OleDbCommand cmd = new OleDbCommand();
               cmd.CommandText = strSQL;
               cmd.Connection = conn;
               int SoDong_Thoa_DieuKien = (int)cmd.ExecuteScalar();
               conn.Close();

               if (SoDong_Thoa_DieuKien > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message.ToString());
           }

       }

    }
}
