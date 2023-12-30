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
    public class Tinh_BLL
    {
        public static void Them1Tinh(Tinh_DTO tinh)
        {
            try{
            Tinh_DaTa.ThemTinh(tinh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1Tinh(Tinh_DTO tinh)
        {
            try{
            Tinh_DaTa.SuaTinh(tinh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1Tinh(Tinh_DTO tinh)
        {
            try{
            Tinh_DaTa.XoaTinh(tinh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSTinh()
        {
            return Tinh_DaTa.ListTinh();
        }
    }
}
