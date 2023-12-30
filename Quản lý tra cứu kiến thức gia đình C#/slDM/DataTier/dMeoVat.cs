using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.OleDb;
using System.Data;

namespace DataTier
{
    public class dMeoVat:General_Data
    {
        public DataSet getTable_MeoVat_Ma_Tendm(string mavn)
        {
            string cm = "SELECT MeoVat.Mamv, MeoVat.Tenmv, MeoVat.Noidung, MeoVat.Ngaynhap, MeoVat.Nguon, MeoVat.Hinhanh, ChuyenMuc.Tencm,MeoVat.Danhgia FROM ChuyenMuc INNER JOIN MeoVat ON ChuyenMuc.Macm = MeoVat.Macm where MeoVat.Mamv =@ma";
            OleDbCommand cmd = new OleDbCommand(cm, cn);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = mavn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"MeoVat");
            return ds;
        }
        public DataSet getTable_MeoVat_Ma(string mavn)
        {
            string cm = "Select * from MeoVat where Mamv=@ma";
            OleDbCommand cmd = new OleDbCommand(cm, cn);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = mavn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "MeoVat");
            return ds;
        }
        public DataSet getTable_MeoVat_forsearch()
        {
            string cm = "Select Mamv,Tenmv,Macm from MeoVat order by Tenmv";
            OleDbCommand cmd = new OleDbCommand(cm, cn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "MeoVat");
            return ds;
        }

        public int XoaMeoVat(string ma)
        {
            openCn();
            OleDbCommand cmd = new OleDbCommand("Delete from MeoVat where Mamv=@ma",cn);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = ma;
            int n = cmd.ExecuteNonQuery();
            closeCn();
            return n;

        }
        public int CapnhapMeoVat(MeoVat mv)
        {
            
            openCn();
            OleDbCommand cmd = new OleDbCommand("update MeoVat set Tenmv=@ten,Noidung=@noidung,Ngaynhap=@ngay,Nguon=@nguon,Hinhanh=@hinh,Macm=@macm where Mamv=@ma", cn);
            cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = mv.Temeovat;
            cmd.Parameters.Add("@noidung", OleDbType.BSTR).Value = mv.Noidung;
            cmd.Parameters.Add("@ngay", OleDbType.Date).Value = mv.Ngaynhap;
            cmd.Parameters.Add("@nguon", OleDbType.BSTR).Value = mv.Nguon;
            cmd.Parameters.Add("@hinh", OleDbType.BSTR).Value = mv.HinhAnh;
            cmd.Parameters.Add("@macm", OleDbType.BSTR).Value = mv.Machuyenmuc;
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = mv.Mameovat;

            int n = cmd.ExecuteNonQuery();
            closeCn();
            return n;

        }
        public int Themmeovat(MeoVat mv)
        {
            openCn();
            OleDbCommand cmd = new OleDbCommand("insert into MeoVat(Tenmv,Noidung,Ngaynhap,Nguon,Hinhanh,Macm,Danhgia) values(@ten,@noidung,@ngay,@nguon,@hinh,@macm,@danhgia)", cn);
            cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = mv.Temeovat;
            cmd.Parameters.Add("@noidung", OleDbType.BSTR).Value = mv.Noidung;
            cmd.Parameters.Add("@ngay", OleDbType.Date).Value = mv.Ngaynhap;
            cmd.Parameters.Add("@nguon", OleDbType.BSTR).Value = mv.Nguon;
            cmd.Parameters.Add("@hinh", OleDbType.BSTR).Value = mv.HinhAnh;
            cmd.Parameters.Add("@macm", OleDbType.BSTR).Value = mv.Machuyenmuc;
            cmd.Parameters.Add("@danhgia", OleDbType.Integer).Value = mv.Danhgia;


            int n = cmd.ExecuteNonQuery();
            closeCn();
            return n;
        }
        public int UpdateDanhgia(string ma, int diem)
        {
            openCn();
            OleDbCommand cmd = new OleDbCommand("update MeoVat set Danhgia=@diem where Mamv=@ma",cn);
            cmd.Parameters.Add("@diem", OleDbType.Integer).Value = diem;
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = ma;
            int n = cmd.ExecuteNonQuery();
            closeCn();
            return n;
            
        }
        public Boolean Kiemtraanhkosudung(string tenanh)
        {
            openCn();
            OleDbCommand cmd = new OleDbCommand("Select count(*) from MeoVat where Hinhanh=@anh", cn);
            cmd.Parameters.Add("@anh", OleDbType.BSTR).Value = tenanh;
            int n = (int)cmd.ExecuteScalar();
            closeCn();
     
            if (n == 0)
            {
               return true;
            }
            return false;
        }
        public int getMamv_cuoi_tblMeovat()
        {
            openCn();
            OleDbCommand cmd = new OleDbCommand("SELECT  top 1 Mamv FROM MeoVat order by Mamv Desc", cn);
            int n = (int)cmd.ExecuteScalar();
            closeCn();

            return n;
        }
    }
}
