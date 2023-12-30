using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QuanLyXeVaXe
{
    class DBAccess
    {
        //Download source code tại Sharecode.vn
        public SqlConnection GetCon()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Do An QLX va LX\QLX\QuanLyXeVaXe\GoodLuck.mdf;Integrated Security=True;User Instance=True");
        }
        public string CheckLogin(string name, string pass)
        {
            string quyen = "";
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("select role from tb_Login where userid = '" + name + "' and pass = '" + pass + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                quyen = dr[0].ToString();
                con.Close();
                return quyen;
            }
            con.Close();
            return quyen;
           
        }
        public bool CheckBusy(string name)//kiem tra xe ban hay khong
        {
          //  string tinhtrang = "";
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("select MaXe from tb_ChiTietHopDong where MaXe = ('"+name+"')", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               // tinhtrang = dr[0].ToString();
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool Check_LaiXe(string name)
        {
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("select MaLaiXe from tb_ChiTietHopDong where MaLaiXe = ('" + name + "')", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                // tinhtrang = dr[0].ToString();
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        //========================================================//
        
        public string CheckBusy_Xe(string name)
        {

            string tinhtrang = "";
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("select TinhTrangXe from tb_Xe where MaXe = '" + name + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tinhtrang = dr["TinhTrangXe"].ToString();
                con.Close();
                return tinhtrang;
            }
            con.Close();
            return tinhtrang;
        }

        public string CheckBusy_LaiXe(string name)
        {
            string tinhtrang = "";
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("select TinhTrangLaiXe from tb_LaiXe where Malaixe = '" + name + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tinhtrang = dr[0].ToString();
                con.Close();
                return tinhtrang;
            }
            con.Close();
            return tinhtrang;
        }



            //Check HD thanh toan
            public string CheckThanhToan_HD(string name)
        {
            string tinhtrang = "";
            SqlConnection con = GetCon();
            SqlCommand cmd = new SqlCommand("select TinhTrangHD from tb_ChiTietHopDong where MaHopDong = '" + name + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tinhtrang = dr[0].ToString();
                con.Close();
                return tinhtrang;
            }
            con.Close();
            return tinhtrang;
        }
    }
}

