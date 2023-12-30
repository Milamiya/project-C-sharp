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
    public class HANGHOA_DAO
    {
        public static void ThemHangHoa(HANGHOA_DTO hh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemHangHoa", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenhang", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@donvitinh", SqlDbType.NVarChar,20);
                cmd.Parameters.Add("@dongia", SqlDbType.Decimal);

                //add value to parameters
                cmd.Parameters["@mahang"].Value = hh.MaHang;
                cmd.Parameters["@tenhang"].Value = hh.TenHang;
                cmd.Parameters["@donvitinh"].Value = hh.DonViTinh;
                cmd.Parameters["@dongia"].Value = hh.DonGia;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void SuaHangHoa(HANGHOA_DTO hh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaHangHoa", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenhang", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@donvitinh", SqlDbType.NVarChar, 20);
                cmd.Parameters.Add("@dongia", SqlDbType.Decimal);

                //add value to parameters
                cmd.Parameters["@mahang"].Value = hh.MaHang;
                cmd.Parameters["@tenhang"].Value = hh.TenHang;
                cmd.Parameters["@donvitinh"].Value = hh.DonViTinh;
                cmd.Parameters["@dongia"].Value = hh.DonGia;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaHangHoa(HANGHOA_DTO hh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaHangHoa", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                
                //add value to parameters
                cmd.Parameters["@mahang"].Value = hh.MaHang;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable TimHangHoa(string str)
        {
            
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TimHangHoa", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenhang", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@tenhang"].Value = str;
                DataTable dt=new DataTable();
            try
            {
                cnn.Open();
                dt=(DataTable)cmd.ExecuteScalar();
            }
            catch(Exception err)
            {}
            finally
            {
                cnn.Close();
            }
            return dt;
            
        }
        public static DataTable ListHangHoa()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaHangHoa", cnn);
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
