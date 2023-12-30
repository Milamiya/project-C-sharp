using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;

namespace Data_Tier
{
   public class D_DoanhNghiep : General_Data
    {
       public DataSet getEmail_TheoMaDN(string maDN)
       {
           OleDbCommand cmd = new OleDbCommand("select email from DoanhNghiep where Ma=@Ma", conn);
           cmd.Parameters.Add("@Ma", OleDbType.BSTR).Value = maDN;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "DoanhNghiep");
           return ds;
       }
       public DataSet getMa_TheoEmail(string email)
       {
           OleDbCommand cmd = new OleDbCommand("select ma from DoanhNghiep where email=@email", conn);
           cmd.Parameters.Add("@email", OleDbType.BSTR).Value = email;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "DoanhNghiep");
           return ds;
       }
       public DataSet getDoanhNghiep_theo_DiaDiem(string diadiem)
       {
           OleDbCommand cmd = new OleDbCommand("select * from DoanhNghiep where diachi like '%"+diadiem+"'", conn);
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "DoanhNghiep");
           return ds;
       }
       public DataSet getDoanhNghiep_theo_maNganhNghe(string maNN)
       {
           OleDbCommand cmd = new OleDbCommand("select * from DoanhNghiep where MaNganhNghe=@Ma", conn);
           cmd.Parameters.Add("@Ma", OleDbType.BSTR).Value = maNN;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds,"DoanhNghiep");
           return ds;
       }
       public DataSet getDoanhNghiep_theo_maDoanhNghiep(string maDN) {
           OleDbCommand cmd = new OleDbCommand("select * from DoanhNghiep where Ma=@Ma", conn);
           cmd.Parameters.Add("@Ma", OleDbType.BSTR).Value = maDN;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "DoanhNghiep");
           return ds;
       }
       public int ThemDoanhNghiep(Doanh_Nghiep dn)
       {
           try
           {

               if (TimKiem(dn.Ma) == true)
                   return 2;
               conn.Open();
               OleDbCommand cmd = new OleDbCommand("insert into doanhnghiep values(@ma,@ten,@diachi,@sdt,@email,@chudn,@manganhnghe)", conn);
               cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = dn.Ma;
               cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = dn.Ten;
               cmd.Parameters.Add("@diachi", OleDbType.BSTR).Value = dn.DiaChi;
               cmd.Parameters.Add("@sdt", OleDbType.BSTR).Value = dn.SDT;
               cmd.Parameters.Add("@email", OleDbType.BSTR).Value = dn.Email;
               cmd.Parameters.Add("@chudn", OleDbType.BSTR).Value = dn.ChuDN;
               cmd.Parameters.Add("@manganhnghe", OleDbType.BSTR).Value = dn.MaNganhNghe;
               cmd.ExecuteNonQuery();
               conn.Close();
               return 0;
           }
           catch (Exception ex)
           {
               return 1;
           }

       }
       public int XoaDoanhNghiep(string ma)
       {
           if (TimKiem(ma) == true)
               return 2;
           conn.Open();
           OleDbCommand cmd = new OleDbCommand("delete from doanhnghiep where ma=@ma", conn);
           cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = ma;
           cmd.ExecuteNonQuery();
           conn.Close();
           return 0;


       }
       public int CapNhatDoanhNghiep(Doanh_Nghiep dn)
       {
           if (TimKiem(dn.Ma) == false)
           {
               return 2;
           }
           conn.Open();
           OleDbCommand cmd = new OleDbCommand("update doanhnghiep set ma=@ma,ten=@ten,diachi=@diachi,sdt=@sdt,email=@email,chudn=@chudn,manganhnghe=@manganhnghe where ma=@ma", conn);
           cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = dn.Ma;
           cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = dn.Ten;
           cmd.Parameters.Add("@diachi", OleDbType.BSTR).Value = dn.DiaChi;
           cmd.Parameters.Add("@sdt", OleDbType.BSTR).Value = dn.SDT;
           cmd.Parameters.Add("@email", OleDbType.BSTR).Value = dn.Email;
           cmd.Parameters.Add("@chudn", OleDbType.BSTR).Value = dn.ChuDN;
           cmd.Parameters.Add("@manganhnghe", OleDbType.BSTR).Value = dn.MaNganhNghe;
           cmd.ExecuteNonQuery();
           conn.Close();
           return 0;

       }
       
       public bool TimKiem(string madn)
       {
           try
           {
               OpenCnn();
               string strSQL = "Select count(*) From doanhnghiep Where Ma ='" + madn + "'";
               OleDbCommand cmd = new OleDbCommand();
               cmd.CommandText = strSQL;
               cmd.Connection = conn;
               int SoDong_Thoa_DieuKien = (int)cmd.ExecuteScalar();
               CloseCnn();

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
