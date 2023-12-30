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
using System.Data.SqlClient;
public partial class hello_Default : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        ddlLoaiTin.DataSource = cls.LoadDuLieuPKN("select * from tbNewsCategories");
        ddlLoaiTin.DataTextField = "CategoriesName";
        ddlLoaiTin.DataBind();
    }
    
    protected void btLuu_Click(object sender, EventArgs e)
    {
        string day = ddlDay.Text;
        string month = ddlMonth.Text;
        string year = ddlYear.Text;
        string ngaydang = month + "/" + day + "/" + year;
        cls.ThucThiSQL("Update tbNews set Title=N'"+txtTieuDe.Text+"', Description=N'"+FCKMota.Value+"', Contents =N'"+FCKNoiDung.Value+"',Created=N'"+ngaydang+"',Poster=N'"+txtNguoiDang.Text+"' where NewsID=N'"+ddlTieuDe.SelectedValue+"'");        
    }
    public void LoadData(DataTable dt)
    {
        foreach (DataRow dr in dt.Rows)
        {
            txtTieuDe.Text = dr[1].ToString();
            ddlLoaiTin.Text = dr[2].ToString();            
            FCKMota.Value = dr[4].ToString();
            FCKNoiDung.Value = dr[5].ToString();
            string mang = dr[6].ToString();
            object[] a = new object[3];
            string chuoi = mang.Replace('/', ' ');
            a = chuoi.Split(' ');
            ddlMonth.Text = a[0].ToString();
            ddlDay.Text = a[1].ToString();
            ddlYear.Text = a[2].ToString();
            txtNguoiDang.Text = dr[7].ToString();
            break;
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = cls.LoadDuLieuPKN("select * from tbNews where NewsID='" + ddlTieuDe.SelectedValue + "'");
        LoadData(dt);
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

        DataTable dt = cls.LoadDuLieuPKN("select * from tbNews where Created='" + ddlNgayDang.SelectedValue + "'");
        LoadData(dt);
    }
}
