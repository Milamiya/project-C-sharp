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
    public class Nganh_BLL
    {
        public static void Them1Nganh(Nganh_DTO nganh)
        {
            try{
            Nganh_DaTa.ThemNganh(nganh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1Nganh(Nganh_DTO nganh)
        {
            try{
            Nganh_DaTa.SuaNganh(nganh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1Nganh(Nganh_DTO nganh)
        {
            try{
            
            Nganh_DaTa.XoaNganh(nganh);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSNganh()
        {
            return Nganh_DaTa.ListNganh();
        }
    }
}
