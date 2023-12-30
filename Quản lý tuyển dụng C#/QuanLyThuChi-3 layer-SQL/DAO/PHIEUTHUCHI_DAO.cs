using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class PHIEUTHUCHI_DAO
    {
        public static void ThemPhieuThuChi(PHIEUTHUCHI_DTO p)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemPhieuThuChi", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);                
                cmd.Parameters.Add("@ngay", SqlDbType.Date);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@manv",SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@sotien",SqlDbType.Decimal);
                cmd.Parameters.Add("@thuchi", SqlDbType.Bit);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = p.SoPhieu;
                
                cmd.Parameters["@ngay"].Value = p.Ngay;
                cmd.Parameters["@lydo"].Value = p.LyDo;
                cmd.Parameters["@manv"].Value = p.MaNV;
                cmd.Parameters["@sotien"].Value = p.SoTien;
                cmd.Parameters["@thuchi"].Value = p.ThuChi;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void SuaPhieuThuChi(PHIEUTHUCHI_DTO p)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaPhieuThuChi", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@ngay", SqlDbType.Date);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@sotien", SqlDbType.Decimal);
                cmd.Parameters.Add("@thuchi", SqlDbType.Bit);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = p.SoPhieu;

                cmd.Parameters["@ngay"].Value = p.Ngay;
                cmd.Parameters["@lydo"].Value = p.LyDo;
                cmd.Parameters["@manv"].Value = p.MaNV;
                cmd.Parameters["@sotien"].Value = p.SoTien;
                cmd.Parameters["@thuchi"].Value = p.ThuChi;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaPhieuThuChi(PHIEUTHUCHI_DTO p)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaPhieuThuChi", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = p.SoPhieu;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable InPhieuThuChi(string str)
        {  
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_InPhieuThuChi", cnn);
                DataTable dt = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                //add value to parameters
                cmd.Parameters["@sophieu"].Value = str;
                da.Fill(dt);
                return dt;

        }
        public static DataTable ListPhieuThuChi()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaPhieuThuChi", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
    }
}
