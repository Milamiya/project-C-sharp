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
    public class Huyen_BLL
    {
        public static void Them1Huyen(Huyen_DTO huyen)
        {
            try
            {
                Huyen_DaTa.ThemHuyen(huyen);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
            
        }
        public static void Sua1Huyen(Huyen_DTO huyen)
        {
            try
            {
            Huyen_DaTa.SuaHuyen(huyen);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1Huyen(Huyen_DTO huyen)
        {
            try
            {
            Huyen_DaTa.XoaHuyen(huyen);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSHuyen()
        {
            return Huyen_DaTa.ListHuyen();
        }
    }
}

