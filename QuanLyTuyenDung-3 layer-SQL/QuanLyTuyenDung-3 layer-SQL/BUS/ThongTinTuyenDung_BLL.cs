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
    public class ThongTinTuyenDung_BLL
    {
        public static void Them1ThongTinTuyenDung(ThongTinTuyenDung_DTO tt)
        {
            try{
            ThongTinTuyenDung_DaTa.ThemThongTinTuyenDung(tt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1ThongTinTuyenDung(ThongTinTuyenDung_DTO tt)
        {
            try{
            ThongTinTuyenDung_DaTa.SuaThongTinTuyenDung(tt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1ThongTinTuyenDung(ThongTinTuyenDung_DTO tt)
        {
            try{
            ThongTinTuyenDung_DaTa.XoaThongTinTuyenDung(tt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSTiNTuyenDung()
        {
            return ThongTinTuyenDung_DaTa.ListTinTuyenDung();
        }
    }
}
