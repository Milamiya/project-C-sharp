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
    public class PHIEUNHAPXUAT_DAO
    {
        public static void ThemPhieuNhapXuat(PHIEUNHAPXUAT_DTO p)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemPhieuNhapXuat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@ngay", SqlDbType.Date);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@nhapxuat", SqlDbType.Bit);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = p.SoPhieu;
                cmd.Parameters["@manv"].Value = p.MaNV;
                cmd.Parameters["@ngay"].Value = p.Ngay;
                cmd.Parameters["@lydo"].Value = p.LyDo;
                cmd.Parameters["@nhapxuat"].Value = p.NhapXuat;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void SuaPhieuNhapXuat(PHIEUNHAPXUAT_DTO p)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaPhieuNhapXuat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@ngay", SqlDbType.Date);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@nhapxuat", SqlDbType.Bit);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = p.SoPhieu;
                cmd.Parameters["@manv"].Value = p.MaNV;
                cmd.Parameters["@ngay"].Value = p.Ngay;
                cmd.Parameters["@lydo"].Value = p.LyDo;
                cmd.Parameters["@nhapxuat"].Value = p.NhapXuat;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaPhieuNhapXuat(PHIEUNHAPXUAT_DTO p)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaPhieuNhapXuat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = p.SoPhieu;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable InPhieuNhapXuat(PHIEUNHAPXUAT_DTO p)
        {
            SqlConnection cnn = DataServices.ketnoi();
            SqlCommand cmd = new SqlCommand("sp_InPhieuNhapXuat", cnn);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);

            //add value to parameters
            cmd.Parameters["@sophieu"].Value = p.SoPhieu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static DataTable ListPhieuNhapXuat()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaPhieuNhapXuat", cnn);
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
