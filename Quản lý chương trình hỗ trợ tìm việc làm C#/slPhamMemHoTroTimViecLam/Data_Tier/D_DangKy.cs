using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;

namespace Data_Tier
{
    public class D_DangKy : General_Data
    {
        public int DangKy(E_DangKy dk)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into TaiKhoan values(@tentk,@matkhau)", conn);
                cmd.Parameters.Add("@tentk", OleDbType.BSTR).Value = dk.TenTK;
                cmd.Parameters.Add("@matkhau", OleDbType.BSTR).Value = dk.MatKhau;
                cmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (System.Exception ex)
            {
                return 1;
            }

        }
        public bool TimKiem(string tentk)
        {
            try
            {
                conn.Open();
                string strSQL = "Select count(*) From taikhoan Where tentk =@tentk";
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                cmd.Parameters.Add("@tentk", OleDbType.BSTR).Value = tentk;

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
        public int CapNhatTK(E_DangKy dk)
        {
            try
            {
                if (TimKiem(dk.TenTK) == false)
                {
                    return 2;
                }
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update taikhoan set tentk=@tentk,matkhau=@matkhau where tentk=@tentk", conn);
                cmd.Parameters.Add("@tentk", OleDbType.BSTR).Value = dk.TenTK;
                cmd.Parameters.Add("@matkhau", OleDbType.BSTR).Value = dk.MatKhau;
                cmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (System.Exception ex)
            {
                return 1;
            }

        }
    }
}
