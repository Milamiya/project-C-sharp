using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ThanhVien
/// </summary>
public class ThanhVien:DataAccess
{
	public ThanhVien()
	{
        OpenConnection("sunConnectionString1");
	}
    public DataTable ThanhVien_DangNhap(string UserName, string Password)
    {
        SqlParameter[] arrParam = {
              new SqlParameter("@UserName",SqlDbType.NVarChar),
              new SqlParameter("@Password", SqlDbType.NVarChar)
            };
        arrParam[0].Value = UserName;
        arrParam[1].Value = Password;
        return ThucThiStoreTraVeBang("sTB_Member_DangNhap", arrParam);
    }
    public DataTable ThanhVien_DangKy(
          string TenDangNhap,
           string MatKhau,
           string Email,
           string HoVaTen,
           DateTime NgayDangKy,
           int TrangThai)
    {
        SqlParameter[] arrParam =
           {
               new SqlParameter("@Usermember",SqlDbType.VarChar),
               new SqlParameter("@Password",SqlDbType.VarChar),
               new SqlParameter("@Email",SqlDbType.VarChar),
               new SqlParameter("@FullName",SqlDbType.NVarChar),
               new SqlParameter("@RegisterDate",SqlDbType.DateTime),
               new SqlParameter("@Status",SqlDbType.Int)
           };
        arrParam[0].Value = TenDangNhap;
        arrParam[1].Value = MatKhau;
        arrParam[2].Value = Email;
        arrParam[3].Value = HoVaTen;
        arrParam[4].Value = NgayDangKy;
        arrParam[5].Value = TrangThai;
        return ThucThiStoreTraVeBang("sThanhVien_DangKy", arrParam);
    }
    public DataTable DangNhap_TruyVan(string TenDangNhap, string Email)
    {
        SqlParameter[] arrParem = {
                                     new SqlParameter("@TenDangNhap", SqlDbType.VarChar),
                                     new SqlParameter("@Email", SqlDbType.VarChar)
                                     };
        arrParem[0].Value = TenDangNhap;
        arrParem[1].Value = Email;
        return ThucThiStoreTraVeBang("[sMember_TruyVan]", arrParem);
    }
}
