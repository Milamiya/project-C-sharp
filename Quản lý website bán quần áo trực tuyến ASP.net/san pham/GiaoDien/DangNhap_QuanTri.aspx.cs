using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class GiaoDien_DangNhap_QuanTri : System.Web.UI.Page
{

    clsDatabase cls = new clsDatabase();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Kiem tra de phan quyen
        Kiemtra(txtTenDN.Text, txtMK.Text);

        //Response.Write(ok);
        //Response.Write(quyen);
        if (ok == true)
        {
            if (quyen == "1")
                Session["Tendn"] = "1";
            else
            {
                if (quyen == "2")
                {
                    Session["Tendn"] = "2";
                }
                else
                    Session["Tendn"] = "3";
            }
            Session["xinchaotdn"] = txtTenDN.Text;
            if (Session["Tendn"].ToString() == "1")
            {
                Response.Redirect("ThemmoiSP.aspx");
            }
            else
            {
                Response.Redirect("ThongTinChiTietSP.aspx");
            }

            txtTenDN.Text = "";
            txtMK.Text = "";
            //Response.Write(Session["xinchaotdn"].ToString());
        }
        else
        {
            //    lbThongbao.Visible = true;
        }

        // Response.Write(quyen);
    }
    bool ok = false;
    string quyen = "";
    protected void Kiemtra(string Tendn, string Pass)
    {
        //bool ok = false;
        dt = cls.LuuBangTrongDataSet("Select * From Roles where RoleName='" + Tendn + "' and RoleID='" + Pass + "'", "tbtame");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (Tendn == dt.Rows[i][0].ToString() && Pass == dt.Rows[i][1].ToString())
            {
                ok = true;
                quyen = dt.Rows[i][2].ToString();
                break;
            }
        }
        //return ok;
    }
}
