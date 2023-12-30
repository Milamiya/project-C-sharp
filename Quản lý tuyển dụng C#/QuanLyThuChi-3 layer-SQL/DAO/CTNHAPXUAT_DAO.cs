using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class CTNHAPXUAT_DAO
    {
        public static void ThemCTNhapXuat(CTNHAPXUAT_DTO ctnx)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemCTNhapXuat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = ctnx.SoPhieu;
                cmd.Parameters["@mahang"].Value = ctnx.MaHang;
                cmd.Parameters["@soluong"].Value = ctnx.SoLuong;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaCTNhapXuat(CTNHAPXUAT_DTO ctnx)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaCTNhapXuat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);

                //add value to parameters
                cmd.Parameters["@sophieu"].Value = ctnx.SoPhieu;
                cmd.Parameters["@mahang"].Value = ctnx.MaHang;
                cmd.Parameters["@soluong"].Value = ctnx.SoLuong;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaCTNhapXuat(CTNHAPXUAT_DTO ctnx)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaCTNhapXuat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                
                //add value to parameters
                cmd.Parameters["@sophieu"].Value = ctnx.SoPhieu;
                cmd.Parameters["@mahang"].Value = ctnx.MaHang;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListCTNhapXuat()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaCTNhapXuat", cnn);
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
