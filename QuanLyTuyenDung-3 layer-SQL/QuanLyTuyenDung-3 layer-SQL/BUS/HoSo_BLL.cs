using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
namespace BUS
{
    public class HoSo_BLL
    {
        public static void Them1HoSoMoi(HoSo_DTO hs)
        {
            try
            {
                HoSo_DaTa.ThemHoSo(hs);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại"+err.Message, "Lỗi");
            }
        }
        public static void Sua1HoSo(HoSo_DTO hs)
        {
            try
            { 
                HoSo_DaTa.SuaHoSo(hs);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1HoSo(HoSo_DTO hs)
        {
            try
            {
                HoSo_DaTa.XoaHoSo(hs);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSHoSo()
        {
            return HoSo_DaTa.ListHoSo();
        }
        public static DataTable DSHoSoTheoTen(string hoten)
        {
            return HoSo_DaTa.ListHoSoTheoTen(hoten);
        }
        public static DataTable DSHoSoTheoTinTuyenDung(string matt)
        {
            return HoSo_DaTa.ListHoSoTheoTinTuyenDung(matt);
        }
    }
}
