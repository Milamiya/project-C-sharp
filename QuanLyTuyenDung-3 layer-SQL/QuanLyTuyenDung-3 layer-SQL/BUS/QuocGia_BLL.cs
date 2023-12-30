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
    public class QuocGia_BLL
    {
        public static void Them1QuocGia(QuocGia_DTO qg)
        {
            try{
            QuocGia_DaTa.ThemQuocGia(qg);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1QuocGia(QuocGia_DTO qg)
        {
            try{
            QuocGia_DaTa.SuaQuocGia(qg);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1QuocGia(QuocGia_DTO qg)
        {
            try{
            QuocGia_DaTa.XoaQuocGia(qg);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSQuocGia()
        {
            return QuocGia_DaTa.ListQuocGia();
        }
    }
}
