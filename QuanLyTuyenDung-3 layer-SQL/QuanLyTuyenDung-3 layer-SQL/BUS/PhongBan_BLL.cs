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
    public class PhongBan_BLL
    {
        public static void Them1PhongBan(PhongBan_DTO pb)
        {
            try{
            PhongBan_DaTa.ThemPhongBan(pb);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại" , "Lỗi");
            }
        }
        public static void Sua1PhongBan(PhongBan_DTO pb)
        {
            try{
            PhongBan_DaTa.SuaPhongBan(pb);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1PhongBan(PhongBan_DTO pb)
        {
            try{
            PhongBan_DaTa.XoaPhongBan(pb);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSPhongBan()
        {
            return PhongBan_DaTa.ListPhongBan();
        }
    }
}
