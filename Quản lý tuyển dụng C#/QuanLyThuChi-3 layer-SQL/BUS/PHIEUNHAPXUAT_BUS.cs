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
    public class PHIEUNHAPXUAT_BUS
    {
        public static void Them1PhieuNhapXuat(PHIEUNHAPXUAT_DTO pnx)
        {
            try
            {
                PHIEUNHAPXUAT_DAO.ThemPhieuNhapXuat(pnx);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Sua1PhieuNhapXuat(PHIEUNHAPXUAT_DTO pnx)
        {
            try
            {
                PHIEUNHAPXUAT_DAO.SuaPhieuNhapXuat(pnx);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Xoa1PhieuNhapXuat(PHIEUNHAPXUAT_DTO pnx)
        {
            try
            {
                PHIEUNHAPXUAT_DAO.XoaPhieuNhapXuat(pnx);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static DataTable In1PhieuNhapXuat(PHIEUNHAPXUAT_DTO ptc)
        {
            return PHIEUNHAPXUAT_DAO.InPhieuNhapXuat(ptc);
        }
        public static DataTable DSPHIEUNHAPXUAT()
        {
            return PHIEUNHAPXUAT_DAO.ListPhieuNhapXuat();
        }
    }
}
