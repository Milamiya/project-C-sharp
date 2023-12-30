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
    public class ThongBao_BLL
    {
        public static void Them1ThongBao(ThongBao_DTO tb)
        {
            try{
            ThongBao_DaTa.ThemThongBao(tb);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1ThongBao(ThongBao_DTO tb)
        {
            try{
            ThongBao_DaTa.SuaThongBao(tb);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1ThongBao(ThongBao_DTO tb)
        {
            try{
            ThongBao_DaTa.XoaThongBao(tb);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSThongBao()
        {
            return ThongBao_DaTa.ListThongBao();
        }
    }
}
