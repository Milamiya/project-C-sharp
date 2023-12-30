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
    public class NHANVIEN_BUS
    {
        public static void Them1NhanVien(NHANVIEN_DTO nv)
        {
            try
            {
                NHANVIEN_DAO.ThemNhanVien(nv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:"+err.Message );
            }
        }
        public static void Sua1NhanVien(NHANVIEN_DTO nv)
        {
            try
            {
                NHANVIEN_DAO.SuaNhanVien(nv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static void Xoa1NhanVien(NHANVIEN_DTO nv)
        {
            try
            {
                NHANVIEN_DAO.XoaNhanVien(nv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi:" + err.Message);
            }
        }
        public static DataTable DSNHANVIEN()
        {
            return NHANVIEN_DAO.ListNhanVien();
        }
    }
}
