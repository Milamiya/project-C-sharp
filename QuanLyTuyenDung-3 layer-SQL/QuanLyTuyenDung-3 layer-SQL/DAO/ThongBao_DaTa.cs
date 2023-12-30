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
    public class ThongBao_DaTa
    {
        public static void ThemThongBao(DTO.ThongBao_DTO thongbao)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemThongBao", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matb", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@loaitb", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@matb"].Value = thongbao.MaTB;
                cmd.Parameters["@loaitb"].Value = thongbao.LoaiTB;
                cmd.Parameters["@lydo"].Value = thongbao.LyDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaThongBao(DTO.ThongBao_DTO thongbao)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaThongBao", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matb", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@loaitb", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@matb"].Value = thongbao.MaTB;
                cmd.Parameters["@loaitb"].Value = thongbao.LoaiTB;
                cmd.Parameters["@lydo"].Value = thongbao.LyDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaThongBao(DTO.ThongBao_DTO thongbao)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaThongBao", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matb", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@matb"].Value = thongbao.MaTB;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListThongBao()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaThongBao", cnn);
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
