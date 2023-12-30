using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.DataAccess
{
	class SQL_tb_Hanghoa
	{
		ConnectDB cn = new ConnectDB();
		public bool kiemtrasp(string masp)
		{
			return cn.kiemtra("select count(*) from [tb_Hanghoa] where mahang=N'" + masp + "'");
		}
		public void themmoisp(EC_tb_Hanghoa sp)
		{
			SqlConnection con = cn.getcon();
			try
			{

				con.Open();
				string sql = @"INSERT INTO tb_Hanghoa
					  (mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu)
							 VALUES (N'" + sp.MAHANG + "',N'" + sp.TENHANG + "',N'" + sp.MANHOM + "',N'" + sp.MALOAI + "',N'" + sp.MADONVI + "',N'" + sp.MACHATLIEU + "',N'" + sp.MANUOC + "',N'" + sp.SOLUONG + "',N'" + sp.DONGIANHAP + "',N'" + sp.DONGIABAN + "',N'" + sp.THOAIGIANBH + "',@hinhanh,N'" + sp.GHICHU + "')";
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)sp.HINHANH));
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
		public void xoasp(EC_tb_Hanghoa sp)
		{
			cn.ExcuteNonQuery("DELETE FROM [tb_Hanghoa] WHERE  mahang=N'" + sp.MAHANG + "'");
		}

		public void suasp(EC_tb_Hanghoa sp)
		{
			SqlConnection con = cn.getcon();
			try
			{
				con.Open();
				string sql = @"UPDATE    tb_Hanghoa
				SET tenhang =N'" + sp.TENHANG + "', manhom =N'" + sp.MANHOM + "', maloai =N'" + sp.MALOAI + "', madonvi =N'" + sp.MADONVI + "', machatlieu =N'" + sp.MACHATLIEU + "', manuoc =N'" + sp.MANUOC + "', soluong =N'" + sp.SOLUONG + "', dongianhap =N'" + sp.DONGIANHAP + "', dongiaban =N'" + sp.DONGIABAN + "', thoigianbh =N'" + sp.THOAIGIANBH + "', hinhanh =hinhanh, ghichu =N'" + sp.GHICHU + "' where mahang=N'" + sp.MAHANG + "'";
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)sp.HINHANH));
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
        //load nhóm
        public void loadmanh(ComboBox manh)
        {
            cn.LoadLenCombobox(manh, "SELECT     manhom FROM tb_Nhomhang", 0);
        }
        public string Loadtennh(string tennh, string manh)
        {
            tennh = cn.LoadLable("SELECT [tennhom] From [tb_Nhomhang] where manhom= N'" + manh + "'");
            return tennh;
        }
		//load loại
		public void loadmal(ComboBox mal)
		{
            cn.LoadLenCombobox(mal, "SELECT     maloai FROM tb_Loaihang", 0);
		}
		public string Loadtenloai(string tenl, string mal)
		{
            tenl = cn.LoadLable("SELECT [tenloai] From [tb_Loaihang] where maloai= N'" + mal + "'");
			return tenl;
		}

		//load dvt
		public void loadmadv(ComboBox madv)
		{
            cn.LoadLenCombobox(madv, "SELECT     madonvi FROM tb_Donvitinh", 0);
		}
		public string Loadtendv(string tendv, string madv)
		{
            tendv = cn.LoadLable("SELECT [tendonvi] From [tb_Donvitinh] where madonvi= N'" + madv + "'");
			return tendv;
		}
        //load cl
        public void loadmacl(ComboBox macl)
        {
            cn.LoadLenCombobox(macl, "SELECT     machatlieu FROM tb_Chatlieu", 0);
        }
        public string Loadtencl(string tencl, string macl)
        {
            tencl = cn.LoadLable("SELECT [tenchatlieu] From [tb_Chatlieu] where machatlieu= N'" + macl + "'");
            return tencl;
        }
        //load nsx
        public void loadmansx(ComboBox mansx)
        {
            cn.LoadLenCombobox(mansx, "SELECT     manuoc FROM tb_Nuocsx", 0);
        }
        public string Loadtensx(string tennsx, string mansx)
        {
            tennsx = cn.LoadLable("SELECT [tennuoc] From [tb_Nuocsx] where manuoc= N'" + mansx + "'");
            return tennsx;
        }
	}
}
