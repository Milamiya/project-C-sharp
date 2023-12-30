using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Sanpham
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHang(string mahang)
        {
            return cn.kiemtra("select count(*) from [tb_Sanpham] where masp=N'" + mahang + "'");
        }
        public void themmoiHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.getcon();
            try
            {

                con.Open();
                string sql = @"INSERT INTO tb_Sanpham  (masp, tensp, maloai, gianhap, giaban, soluong, macongdung, hinhanh) VALUES (N'" + hang.MASP + "',N'" + hang.TENSP + "',N'" + hang.MALOAI + "',N'" + hang.GIANHAP + "',N'" + hang.GIABAN + "',N'" + hang.SOLUONG + "',N'" + hang.MACONGDUNG + "',@hinhanh)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)hang.HINHANH));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void xoaHang(EC_tb_Sanpham hang)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Sanpham] WHERE  masp=N'" + hang.MASP + "'");
        }

        public void suaHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.getcon();
            try
            {
                con.Open();
                string sql = @"UPDATE    tb_Sanpham
                SET  tensp =N'" + hang.TENSP + "', maloai =N'" + hang.MALOAI + "', giaban =N'" + hang.GIABAN + "', soluong =N'" + hang.SOLUONG + "', macongdung =N'" + hang.MACONGDUNG + "',hinhanh =@hinhanh where masp=N'" + hang.MASP + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)hang.HINHANH));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //load loại
        public void loadmaloai(ComboBox maloai)
        {
            cn.LoadLenCombobox(maloai, "SELECT     maloai FROM tb_Loai", 0);
        }
        public string Loadtenloai(string tenloai, string maloai)
        {
            tenloai = cn.LoadLable("SELECT [tenloai] From [tb_Loai] where maloai= N'" + maloai + "'");
            return tenloai;
        }
        //load công dụng
        public void loadcd(ComboBox macd)
        {
            cn.LoadLenCombobox(macd, "SELECT     macongdung FROM tb_Congdung", 0);
        }
        public string Loadtencd(string tenm, string mam)
        {
            tenm = cn.LoadLable("SELECT [tencongdung] From [tb_Congdung] where macongdung= N'" + mam + "'");
            return tenm;
        }
        }
    }
