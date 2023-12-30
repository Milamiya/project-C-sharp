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
    public class TrinhDo_BLL
    {
        public static void Them1TrinhDo(TrinhDo_DTO td)
        {
            try{
            TrinhDo_DaTa.ThemTrinhDo(td);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1TrinhDo(TrinhDo_DTO td)
        {
            try{
            TrinhDo_DaTa.SuaTrinhDo(td);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1TrinhDo(TrinhDo_DTO td)
        {
            try{
            TrinhDo_DaTa.XoaTrinhDo(td);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSTrinhDo()
        {
            return TrinhDo_DaTa.ListTrinhDo();
        }
    }
}
