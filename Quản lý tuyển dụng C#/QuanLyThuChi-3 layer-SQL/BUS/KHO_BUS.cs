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
    public class KHO_BUS
    {
        public static void Them1Kho(KHO_DTO kho)
        {
            try
            {
                KHO_DAO.ThemKho(kho); 
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Sua1Kho(KHO_DTO kho)
        {
            try
            {
                KHO_DAO.SuaKho(kho);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Xoa1Kho(KHO_DTO kho)
        {
            try
            {
                KHO_DAO.XoaKho(kho);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static DataTable DSKHO()
        {
            return KHO_DAO.ListKho();
        }
    }
}
