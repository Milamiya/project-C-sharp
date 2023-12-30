using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;

namespace Data_Tier
{
    public class D_NganhNghe : General_Data
    {

        public DataSet getAllnganhnghe()
        {
            OleDbCommand cmd = new OleDbCommand("select * from nganhnghe", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "nganhnghe");
            return ds;
        }
        public DataSet getTenNN_TheoMaNN(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("select ten from NganhNghe where Ma=@Ma", conn);
            cmd.Parameters.Add("@Ma", OleDbType.BSTR).Value = maNN;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "nganhnghe");
            return ds;
        }
        public DataSet getMaNN_TheoTen(string ten)
        {
            OleDbCommand cmd = new OleDbCommand("select ma from nganhnghe where ten=@ten", conn);
            cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = ten;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "nganhnghe");
            return ds;
        }
        public int ThemNganhNghe(Nganh_Nghe nn)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into nganhnghe values(@ma,@ten)", conn);
                cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = nn.MaNganhNghe;
                cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = nn.TenNganhNghe;
                cmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (Exception ex)
            {
                return 1;
            }

        }
        public int XoaNganhNghe(string ma)
        {
            if (TimKiem(ma) == false)
                return 2;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("delete from nganhnghe where ma=@ma", conn);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = ma;
            cmd.ExecuteNonQuery();
            conn.Close();
            return 0;


        }
        public int CapNhatNganhNghe(Nganh_Nghe nn)
        {
            if (TimKiem(nn.MaNganhNghe) == false)
            {
                return 2;
            }
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("update nganhnghe set ma=@ma,ten=@ten where ma=@ma", conn);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = nn.MaNganhNghe;
            cmd.Parameters.Add("@ten", OleDbType.BSTR).Value = nn.TenNganhNghe;
            cmd.ExecuteNonQuery();
            conn.Close();
            return 0;

        }
        public bool TimKiem(string mann)
        {
            try
            {
                conn.Open();
                string strSQL = "Select count(*) From nganhnghe Where Ma ='" + mann + "'";
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
