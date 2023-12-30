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
    public class ViTri_BLL
    {
        public static void Them1ViTri(ViTri_DTO vt)
        {
            try{
            ViTri_DaTa.ThemViTri(vt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã tồn tại", "Lỗi");
            }
        }
        public static void Sua1ViTri(ViTri_DTO vt)
        {
            try{
            ViTri_DaTa.SuaViTri(vt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không sửa được", "Lỗi");
            }
        }
        public static void Xoa1ViTri(ViTri_DTO vt)
        {
            try{
            ViTri_DaTa.XoaViTri(vt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không xóa được", "Lỗi");
            }
        }
        public static DataTable DSViTri()
        {
            return ViTri_DaTa.ListViTri();
        }
    }
}
