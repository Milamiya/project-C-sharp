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
    public class CTKHO_BUS
    {
        public static void Them1CTKho(CTKHO_DTO ctkho)
        {
            try
            {
                CTKHO_DAO.ThemCTKHO(ctkho);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Sua1CTKho(CTKHO_DTO ctkho)
        {
            try
            {
                CTKHO_DAO.SuaCTKHO(ctkho);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Xoa1CTKho(CTKHO_DTO ctkho)
        {
            try
            {
                CTKHO_DAO.XoaCTKHO(ctkho);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static DataTable DSCTKHO()
        {
            return KHO_DAO.ListKho();
        }
    }
}
