using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Windows.Forms;
using System.Data;
namespace BUS
{
    public class HANGHOA_BUS
    {
        public static void Them1HangHoa(HANGHOA_DTO hh)
        {
            try
            {
                HANGHOA_DAO.ThemHangHoa(hh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Sua1HangHoa(HANGHOA_DTO hh)
        {
            try
            {
                HANGHOA_DAO.SuaHangHoa(hh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Xoa1HangHoa(HANGHOA_DTO hh)
        {
            try
            {
                HANGHOA_DAO.XoaHangHoa(hh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static DataTable TimHangHoaTheoTen(string str)
        {
            return HANGHOA_DAO.TimHangHoa(str);
        }
        public static DataTable DSHANGHOA()
        {
            return HANGHOA_DAO.ListHangHoa();
        }
    }
}
