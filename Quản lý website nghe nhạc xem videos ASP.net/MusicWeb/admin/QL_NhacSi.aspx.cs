using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class admin_QL_NhacSi : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = null;
        if (Session["DangNhap"] == null)
            Response.Redirect("~/login.aspx");
        if (Request.QueryString.HasKeys())
        {
            act = Request.QueryString["Ns"].ToString();
        }
        switch (act)
        {
            case "Xem":
                MultiView1.ActiveViewIndex = 0;
                break;

            case "Sua":
                MultiView1.ActiveViewIndex = 1;
                break;

            case "Them":
                MultiView1.ActiveViewIndex = 2;
                break;

            default:
                break;
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        if (CheckFileType(FileUp_hinh.FileName))
        {
            String filePath = "~/img_Nhacsi/" + FileUp_hinh.FileName;
            FileUp_hinh.SaveAs(MapPath(filePath));
        }
        string updatequery = "Update  Nhacsi Set TenNhacSi=N'" + txt_tennhacsi.Text + "',NgaySinh=N'" + txt_ngaysinh.Text + "',QuocTich=N'" + txt_quoctich.Text + "',HinhAnh=N'" + FileUp_hinh.FileName + "',GioiThieu=N'" + txt_gioithieu.Text + "' Where MaNhacSi ='" + txt_tim_nhacsi.Text + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("QL_NhacSi.aspx?Ns=Xem");
    }
    protected void btn_tim_nhacsi_Click(object sender, EventArgs e)
    {
        string tim = txt_tim_nhacsi.Text;
        string insertquery = "Select * From  Nhacsi Where MaNhacSi ='" + tim + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(insertquery, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            txt_tennhacsi.Text = dr["TenNhacSi"].ToString();
            txt_ngaysinh.Text = dr["NgaySinh"].ToString();
            txt_quoctich.Text = dr["QuocTich"].ToString();
            string hinh = dr["HinhAnh"].ToString();
            txt_gioithieu.Text = dr["GioiThieu"].ToString();
            string imgL = "../img_Nhacsi/" + hinh;
            Image11.ImageUrl = imgL;

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
    protected void btn_xoa_nhacsi_Click(object sender, EventArgs e)
    {
        string insertquery = "Delete From  Nhacsi Where MaNhacSi ='" + txt_xoa_nhacsi.Text + "'";
        SqlCommand cmd = new SqlCommand(insertquery, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('Xóa Thành Công')</script>");
        Response.Redirect("QL_NhacSi.aspx?Ns=Xem");
    }
    protected void btn_add_nhacsi_Click(object sender, EventArgs e)
    {
        string th = Drop_thang.SelectedValue.ToString();
        string ng = Drop_ngay.SelectedValue.ToString();
        string nam = txt_namsinh.Text;
        string ns = th + "/" + ng + "/" + nam;
        if (CheckFileType(FileUp_hinh.FileName))
        {
            String filePath = "~/img_Nhacsi/" + FileUp_hinh.FileName;
            FileUp_hinh.SaveAs(MapPath(filePath));
        }

        string insert = "insert into Nhacsi (TenNhacSi,NgaySinh,QuocTich,HinhAnh,GioiThieu) Values (N'" + txt_add_tennhacsi.Text + "',N'" + ns + "',N'" + txt_add_quoctich.Text + "',N'" + FileUp_hinh.FileName + "',N'" + txt_add_gioithieu.Text + "')";
        con.Open();
        SqlCommand cmdd = new SqlCommand(insert, con);
        cmdd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("QL_NhacSi.aspx?Ns=Xem");
    }
}