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
/// Summary description for User
/// </summary>
public class User:DataAccess
{
	public User()
	{
        OpenConnection("wedConnectionString1");
	}
        //Tạo chú thích để khi sử dụng hàm sẽ có chỉ dẫn khi bạn gõ tên hàm và dấu (
        /// <summary>
	    ///    Output:	
		///	        0 -> Đăng nhập thành công
		///	        1 -> Sai UserName
		///	        2 -> Sai Password
        ///	        3 -> Tài khoản đã bị khóa
        /// </summary>
        /// <param name="UserName">string</param>
        /// <param name="Password">string</param>
        /// <returns></returns>
        public DataTable User_DangNhap(string UserName, string Password)
        {
            SqlParameter[] arrParam = {
              new SqlParameter("@UserName",SqlDbType.NVarChar),
              new SqlParameter("@Password", SqlDbType.NVarChar)
            };
            arrParam[0].Value = UserName;
            arrParam[1].Value = Password;
            return ThucThiStoreTraVeBang("SP_DangNhap", arrParam);
        }
        public void User_delete(string UserName, ref string error)
        {
            SqlParameter[] arrParam =
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                 new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
            arrParam[0].Value = UserName;
            arrParam[1].Direction = ParameterDirection.Output;
            ThucThiStore("SP_DeleteUser", arrParam);
            error = (arrParam[1].Value.ToString() + "" != "" ? arrParam[1].Value.ToString() : "");



        }
        public void User_Insert(
            string UserName,
                string Password,
                string RoleCode,
                string FullName,
                string Email,
                int Status,
                ref string error)
        {
            SqlParameter[] arrParam =
            {
               
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Password", SqlDbType.VarChar),
                new SqlParameter("@RoleCode", SqlDbType.VarChar),
                new SqlParameter("@FullName", SqlDbType.NVarChar),
                new SqlParameter("@Email", SqlDbType.NVarChar),
                new SqlParameter("@Status", SqlDbType.Int),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
            arrParam[0].Value = UserName;
            arrParam[1].Value = Password;
            arrParam[2].Value = RoleCode;
            arrParam[3].Value = FullName;
            arrParam[4].Value = Email;
            arrParam[5].Value = Status;
            arrParam[6].Direction = ParameterDirection.Output;
            ThucThiStore("SP_InsertUser", arrParam);
            error = (arrParam[6].Value.ToString() + "" != "" ? arrParam[6].Value.ToString() : "");
        }
        public void User_Edit(
            
	        string UserName, 
	        string Password, 
	        string RoleCode, 
	        string FullName, 
	        string Email, 
	        int Status,
	        ref string error)
        {
            SqlParameter[] arrParam =
            {
               
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Password", SqlDbType.VarChar),
                new SqlParameter("@RoleCode", SqlDbType.VarChar),
                new SqlParameter("@FullName", SqlDbType.NVarChar),
                new SqlParameter("@Email", SqlDbType.NVarChar),
                new SqlParameter("@Status", SqlDbType.Int),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
            
            arrParam[0].Value = UserName;
            arrParam[1].Value = Password;
            arrParam[2].Value = RoleCode;
            arrParam[3].Value = FullName;
            arrParam[4].Value = Email;
            arrParam[5].Value = Status;
            arrParam[6].Direction = ParameterDirection.Output; 
            ThucThiStore("SP_EditUser", arrParam);
            error = (arrParam[6].Value.ToString() + "" != "" ? arrParam[6].Value.ToString() : "");

        }
        public void User_ChanePass(
	        string UserName, 
	        string PassCu,
	        string PassMoi,
	        ref string error)
        {
            SqlParameter[] arrParam =
            {
                new SqlParameter("UserName", SqlDbType.VarChar),
                new SqlParameter("PassCu", SqlDbType.VarChar),
                new SqlParameter("PassMoi", SqlDbType.VarChar),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
            
            arrParam[0].Value = UserName;
            arrParam[1].Value=PassCu;
            arrParam[2].Value=PassMoi;
            arrParam[3].Direction = ParameterDirection.Output; //(Bạn chú ý chỗ này nhé)
            ThucThiStore("SP_DoiPass", arrParam);
            error = (arrParam[3].Value.ToString() + "" != "" ? arrParam[3].Value.ToString() : "");
        
        }

        public DataTable User_SelectByUserName(string UserName)
        {
            SqlParameter[] arrParam =
            {
                new SqlParameter("Username", SqlDbType.VarChar)
            };
            arrParam[0].Value = UserName;
            return ThucThiStoreTraVeBang("SP_SelectUserByUserName", arrParam);
        }
        public DataTable Role_Select(string RoleCode)
        {
            SqlParameter[] arrParam =
            {
                new SqlParameter("@RoleCode", SqlDbType.VarChar) 
            };
            arrParam[0].Value = RoleCode;
            return ThucThiStoreTraVeBang("Sp_LoadQuyen", arrParam);
        }
        public DataTable User_Search(string RollCode, string Keyword)
        {
            SqlParameter[] arrParam =
            {
                new SqlParameter("@RoleCode", SqlDbType.VarChar),
                 new SqlParameter("@Keyword", SqlDbType.VarChar)
            };
            arrParam[0].Value = RollCode;
            arrParam[1].Value = Keyword;
            return ThucThiStoreTraVeBang("SP_TimKiemUser", arrParam);
        }
        public DataTable TruyVan_User(string TenDangNhap, string Email)
        {
            SqlParameter[] arrParem = {
                                     new SqlParameter("@TenDangNhap", SqlDbType.VarChar),
                                     new SqlParameter("@Email", SqlDbType.VarChar)
                                     };
            arrParem[0].Value = TenDangNhap;
            arrParem[1].Value = Email;
            return ThucThiStoreTraVeBang("[sUser_TruyVan]", arrParem);
        }

}
