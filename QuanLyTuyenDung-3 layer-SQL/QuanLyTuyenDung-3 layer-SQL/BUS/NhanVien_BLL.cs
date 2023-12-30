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
    public class NhanVien_BLL
    {
        public static void Them1NhanVien(NhanVien_DTO nv)
        {
            try {
            NhanVien_DaTa.ThemNhanVien(nv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1NhanVien(NhanVien_DTO nv)
        {
            try{
            NhanVien_DaTa.SuaNhanVien(nv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1NhanVien(NhanVien_DTO nv)
        {
            try{
            NhanVien_DaTa.XoaNhanVien(nv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSNhanVien()
        {
            return NhanVien_DaTa.ListNhanVien();
        }
    }
}
