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
    public class ThongTinTuyenDung_DaTa
    {
        public static void ThemThongTinTuyenDung(ThongTinTuyenDung_DTO thongtintuyendung)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemThongTinTuyenDung", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matt", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tentt", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);
                cmd.Parameters.Add("@ngayyeucau", SqlDbType.Date);
                cmd.Parameters.Add("@ngayhethan", SqlDbType.Date);
                cmd.Parameters.Add("@motacongviec", SqlDbType.NVarChar);
                cmd.Parameters.Add("@mucluong", SqlDbType.Float);
                cmd.Parameters.Add("@noilamviec", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@manganh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@mamucdo", SqlDbType.NChar, 3);
                cmd.Parameters.Add("@matrinhdo", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@mavitri", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@matt"].Value = thongtintuyendung.MaTT;
                cmd.Parameters["@tentt"].Value = thongtintuyendung.TenTT;
                cmd.Parameters["@soluong"].Value = thongtintuyendung.SoLuong;
                cmd.Parameters["@ngayyeucau"].Value = thongtintuyendung.NgayYeuCau;
                cmd.Parameters["@ngayhethan"].Value = thongtintuyendung.NgayHetHan;
                cmd.Parameters["@motacongviec"].Value = thongtintuyendung.MoTaCongViec;
                cmd.Parameters["@mucluong"].Value = thongtintuyendung.MucLuong;
                cmd.Parameters["@noilamviec"].Value = thongtintuyendung.NoiLamViec;
                cmd.Parameters["@manganh"].Value = thongtintuyendung.MaNganh;
                cmd.Parameters["@mamucdo"].Value = thongtintuyendung.MaMucDo;
                cmd.Parameters["@matrinhdo"].Value = thongtintuyendung.MaTrinhDo;
                cmd.Parameters["@mavitri"].Value = thongtintuyendung.MaViTri;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaThongTinTuyenDung(DTO.ThongTinTuyenDung_DTO thongtintuyendung)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaThongTinTuyenDung", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matt", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tentt", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);
                cmd.Parameters.Add("@ngayyeucau", SqlDbType.Date);
                cmd.Parameters.Add("@ngayhethan", SqlDbType.Date);
                cmd.Parameters.Add("@motacongviec", SqlDbType.NVarChar);
                cmd.Parameters.Add("@mucluong", SqlDbType.Float);
                cmd.Parameters.Add("@noilamviec", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@manganh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@mamucdo", SqlDbType.NChar, 3);
                cmd.Parameters.Add("@matrinhdo", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@mavitri", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@matt"].Value = thongtintuyendung.MaTT;
                cmd.Parameters["@tentt"].Value = thongtintuyendung.TenTT;
                cmd.Parameters["@soluong"].Value = thongtintuyendung.SoLuong;
                cmd.Parameters["@ngayyeucau"].Value = thongtintuyendung.NgayYeuCau;
                cmd.Parameters["@ngayhethan"].Value = thongtintuyendung.NgayHetHan;
                cmd.Parameters["@motacongviec"].Value = thongtintuyendung.MoTaCongViec;
                cmd.Parameters["@mucluong"].Value = thongtintuyendung.MucLuong;
                cmd.Parameters["@noilamviec"].Value = thongtintuyendung.NoiLamViec;
                cmd.Parameters["@manganh"].Value = thongtintuyendung.MaNganh;
                cmd.Parameters["@mamucdo"].Value = thongtintuyendung.MaMucDo;
                cmd.Parameters["@matrinhdo"].Value = thongtintuyendung.MaTrinhDo;
                cmd.Parameters["@mavitri"].Value = thongtintuyendung.MaViTri;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaThongTinTuyenDung(DTO.ThongTinTuyenDung_DTO thongtintuyendung)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaThongTinTuyenDung", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matt", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@matt"].Value = thongtintuyendung.MaTT;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListTinTuyenDung()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaTinTuyenDung", cnn);
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
