using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
namespace BUS
{
    public class KetNoi
    {
        public static Boolean thucnn()
        {
            return DataServices.testketnoi();
        }
    }
    public class TaiKhoan_BUS
    {
        public static void Them1TaiKhoanMoi(TaiKhoan_DTO tk)
        {
            try
            {
                TaiKhoan_DAO.ThemTaiKhoan(tk);
                MessageBox.Show("Bạn đã tạo tài khoản mới thành công", "Thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show("Tài khoản đã tồn tại hoặc giá trị nhập vào chưa đúng", "Lỗi");
            }
        }
        public static void Sua1TaiKhoan(TaiKhoan_DTO tk)
        {
            try
            {
                TaiKhoan_DAO.SuaTaiKhoan(tk);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1TaiKhoan(TaiKhoan_DTO tk)
        {
            try
            {
                TaiKhoan_DAO.XoaTaiKhoan(tk);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static int KiemTra1TaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.KiemTraTaiKhoan(tk);
        }
        public static int KiemTra1TaiKhoanRS(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.KiemTraTaiKhoanRS(tk);
        }
        public static int CheckQuyen1TaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.CheckQuyenTK(tk);
        }
    }
}
