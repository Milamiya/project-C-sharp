using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiHoSo_BLL
    {
        public static void Them1LoaiHS(LoaiHoSo_DTO lhs)
        {
            try
            {
            LoaiHoSo_DaTa.ThemLoaiHoSo(lhs);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1LoaiHS(LoaiHoSo_DTO lhs)
        {
            try{
            LoaiHoSo_DaTa.SuaLoaiHoSo(lhs);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1LoaiHS(LoaiHoSo_DTO lhs)
        {
            try
            {
            LoaiHoSo_DaTa.XoaLoaiHoSo(lhs);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSLoaiHS()
        {
            return LoaiHoSo_DaTa.ListLoaiHS();
        }
    }
}
