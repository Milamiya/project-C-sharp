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
    public class MucDo_BLL
    {
        public static void Them1MucDo(MucDo_DTO mucdo)
        {
            try
            {
            MucDo_DaTa.ThemMucDo(mucdo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1MucDo(MucDo_DTO mucdo)
        {
            try
            {
                MucDo_DaTa.SuaMucDo(mucdo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1MucDo(MucDo_DTO mucdo)
        {
            try {
            MucDo_DaTa.XoaMucDo(mucdo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSMucDo()
        {
            return MucDo_DaTa.ListMucDo();
        }
    }
}
