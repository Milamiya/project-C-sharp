using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;  

public partial class Rerister : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string select = "select TenDangNhap from UserDaTa where TenDangNhap='" + txt_user.Text + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(select, con);
        SqlDataReader datareader = cmd.ExecuteReader();
        if (datareader.HasRows == false)
        {
            con.Close();
            string username = txt_user.Text;
            string password = txt_pass.Text;
            string repassword = txt_repass.Text;
            string ten = txt_hoten.Text;
            string gioitinh = Drop_Gioitinh.SelectedValue.ToString();
            int maquyen = 1;
            string th = Drop_thang.SelectedValue.ToString();
            string ng = Drop_ngay.SelectedValue.ToString();
            string nam = txt_namsinh.Text;
            string ns = th + "/" + ng + "/" + nam;
            string email = txt_email.Text;
            string mail = Drop_mail.SelectedValue.ToString();
            string m = email + "@" + mail;
            string hochieu = txt_hochieu.Text;
                String filePath = "~/img_user/" + FileUp_hinhuser.FileName;
                FileUp_hinhuser.SaveAs(MapPath(filePath));
            if (password.Length >= 6)
            {
                string insert = "insert into UserDaTa (TenDangNhap,MatKhau,MaQuyen,HoTen,CMT,Email,Hinh,Gioitinh,NamSinh) Values (N'" + username + "',N'" + password + "',N'" + maquyen + "',N'" + ten + "',N'" + hochieu + "',N'" + m + "',N'" + FileUp_hinhuser.FileName + "',N'" + gioitinh + "',N'" + ns + "')";
                con.Open();
                SqlCommand cmdd = new SqlCommand(insert, con);
                cmdd.ExecuteNonQuery();
                con.Close();
                Session.Add("DangNhap", txt_user.Text);
                Response.Redirect("Home.aspx");
            }
            else
                Response.Write("<script>alert('Mật khẩu quá ngắn')</script>");
        }
        else
        {
            con.Close();
            Response.Write("<script>alert('Tài khoản đã tồn tại')</script>");
            txt_user.Text = "";
        }
    }
    bool CheckFileType(string fileName)
    {
        string ext = Path.GetExtension(fileName);
        switch (ext.ToLower())
        {
            case ".gif":
                return true;
            case ".png":
                return true;
            case ".jpg":
                return true;
            case ".jpeg":
                return true;
            default:
                return false;
        }
    }
}