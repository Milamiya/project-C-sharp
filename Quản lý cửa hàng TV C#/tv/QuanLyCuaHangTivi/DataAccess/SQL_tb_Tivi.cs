using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangTivi.DataAccess
{
	class SQL_tb_Tivi
	{
		ConnectDB cn = new ConnectDB();
		public bool kiemtraTV(string matv)
		{
			return cn.kiemtra("select count(*) from [tb_Tivi] where mativi=N'" + matv + "'");
		}
		public void themmoiTV(EC_tb_Tivi tv)
		{
			SqlConnection con = cn.getcon();
			try
			{

				con.Open();
				string sql = @"INSERT INTO tb_Tivi (mativi, tentivi, mahangsx, makieu, mamau, mamanhinh, maco, manoisx, dongianhap, dongiaban, anh, ghichu, soluong, thoigianbaohanh)
							 VALUES (N'" + tv.MATIVI + "',N'" + tv.TENTIVI + "',N'" + tv.MAHANGSX + "',N'" + tv.MAKIEU + "',N'" + tv.MAMAU + "',N'" + tv.MAMANHINH + "',N'" + tv.MACO + "',N'" + tv.MANOISX + "',N'" + tv.DONGIANHAP + "',N'" + tv.DONGIABAN + "',@hinhanh,N'" + tv.GHICHU + "',N'" + tv.SOLUONG + "',N'" + tv.THOIGIANBAOHANH + "')";
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)tv.ANH));
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
		public void xoaTV(EC_tb_Tivi tv)
		{
			cn.ExcuteNonQuery("DELETE FROM [tb_Tivi] WHERE  mativi=N'" + tv.MATIVI + "'");
		}

		public void suatv(EC_tb_Tivi tv)
		{
			SqlConnection con = cn.getcon();
			try
			{
				con.Open();
				string sql = @"UPDATE    tb_Tivi SET tentivi =N'" + tv.TENTIVI + "', mahangsx =N'" + tv.MAHANGSX + "', makieu =N'" + tv.MAKIEU + "', mamau =N'" + tv.MAMAU + "', mamanhinh =N'" + tv.MAMANHINH + "', maco =N'" + tv.MACO + "', manoisx =N'" + tv.MANOISX + "', dongianhap =N'" + tv.DONGIANHAP + "', dongiaban =N'" + tv.DONGIABAN + "', anh =@hinhanh, ghichu =N'" + tv.GHICHU + "', soluong =N'" + tv.SOLUONG + "', thoigianbaohanh =N'" + tv.THOIGIANBAOHANH + "' where mativi=N'" + tv.MATIVI + "'";
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)tv.ANH));
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
		//load kieeur
		public void loadmaK(ComboBox mak)
		{
			cn.LoadLenCombobox(mak, "SELECT     makieu FROM tb_Kieudang", 0);
		}
		public string Loadtenk(string tenk, string mak)
		{
			tenk= cn.LoadLable("SELECT [tenkieu] From [tb_Kieudang] where makieu= N'" + mak + "'");
			return tenk;
		}
		//load hang sx
		public void loadmaHSX(ComboBox mah)
		{
			cn.LoadLenCombobox(mah, "SELECT     mahang FROM tb_Hangsx", 0);
		}
		public string LoadtenHSX(string tenh, string mah)
		{
			tenh= cn.LoadLable("SELECT [tenhang] From [tb_Hangsx] where mahang= N'" + mah + "'");
			return tenh;
		}
		//load man hinh
		public void loadmaMH(ComboBox mamh)
		{
            cn.LoadLenCombobox(mamh, "SELECT mamanhinh FROM tb_Manhinh", 0);
		}
		public string LoadtenMH(string tenh, string mah)
		{
            tenh = cn.LoadLable("SELECT [tenmanhinh] From [tb_Manhinh] where mamanhinh= N'" + mah + "'");
			return tenh;
		}
		//Load co minh hinh
		public void loadmaC(ComboBox mac)
		{
			cn.LoadLenCombobox(mac, "SELECT     maco FROM tb_Comanhinh", 0);
		}
		//load nơi sản xuất
		public void loadmasx(ComboBox masx)
		{
			cn.LoadLenCombobox(masx, "SELECT     manoisx FROM tb_NoiSX", 0);
		}
		public string Loadtensx(string tensx, string masx)
		{
			tensx = cn.LoadLable("SELECT [tennoisx] From [tb_NoiSX] where manoisx= N'" + masx + "'");
			return tensx;
		}		
		//load màu
		public void loadmam(ComboBox mam)
		{
			cn.LoadLenCombobox(mam, "SELECT  mamau FROM tb_Mau", 0);
		}
		public string Loadtenm(string tenm, string mam)
		{
			tenm = cn.LoadLable("SELECT [tenmau] From [tb_Mau] where mamau= N'" + mam + "'");
			return tenm;
		}
	}
}
