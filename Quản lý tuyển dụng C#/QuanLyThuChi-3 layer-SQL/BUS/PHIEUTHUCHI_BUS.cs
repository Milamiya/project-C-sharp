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
    public class PHIEUTHUCHI_BUS
    {
        public static void Them1PhieuThuChi(PHIEUTHUCHI_DTO ptc)
        {
            try
            {
                PHIEUTHUCHI_DAO.ThemPhieuThuChi(ptc);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Sua1PhieuThuChi(PHIEUTHUCHI_DTO ptc)
        {
            try
            {
                PHIEUTHUCHI_DAO.SuaPhieuThuChi(ptc);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Xoa1PhieuThuChi(PHIEUTHUCHI_DTO ptc)
        {
            try
            {
                PHIEUTHUCHI_DAO.XoaPhieuThuChi(ptc);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static DataTable In1PhieuThuChi(string ptc)
        {
            return PHIEUTHUCHI_DAO.InPhieuThuChi(ptc);
        }
        public static DataTable DSPHIEUTHUCHI()
        {
            return PHIEUTHUCHI_DAO.ListPhieuThuChi();
        }
    }
}
