using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class CTNHAPXUAT_BUS
    {
        public static void Them1CTNhapXuat(CTNHAPXUAT_DTO ctnx)
        {
            try
            {
                CTNHAPXUAT_DAO.ThemCTNhapXuat(ctnx);
            }
            catch(Exception err)
            {
                MessageBox.Show("Lỗi:"+err.Message);
            }
        }
        public static void Sua1CTNhapXuat(CTNHAPXUAT_DTO ctnx)
        {
            try
            {
                CTNHAPXUAT_DAO.SuaCTNhapXuat(ctnx);
            }
            catch(Exception err)
            {
                MessageBox.Show("Lỗi:"+err.Message);
            }
        }
        public static void Xoa1CTNhapXuat(CTNHAPXUAT_DTO ctnx)
        {
            try
            {
                CTNHAPXUAT_DAO.XoaCTNhapXuat(ctnx);
            }
            catch(Exception err)
            {
                MessageBox.Show("Lỗi:"+err.Message);
            }
        }
        public static DataTable DSCTNHAPXUAT()
        {
            return CTNHAPXUAT_DAO.ListCTNhapXuat();
        }
    }
}
