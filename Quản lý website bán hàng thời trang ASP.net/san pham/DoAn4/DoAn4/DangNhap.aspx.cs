using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace DoAn4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        InfoDataContext db = new InfoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        private bool KiemTra()
        {
            var tmp = from a in db.tbl_Customers
                    select new { a.User,a.Password};
            foreach (var sub in tmp)
            {
                if (sub.User == txtUser.Text && sub.Password == txtPass.Text)
                    return true;
            }
            return false;
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                Label1.Text = "Bạn chưa nhập đầy đủ thông tin.";
            }
            else
            {
                Session["Username"] = txtUser.Text;
                if (KiemTra())
                {
                    GioHang gh = (GioHang)Session["giohang"];
                    DataTable tb = gh.GetDataTable();
                    int dem = 0;
                    if (tb.Rows.Count > 0)
                    {
                        Panel1.Visible = false;
                        Panel2.Visible = false;
                        Panel3.Visible = true;
                        dem = tb.Rows.Count;
                        lblGioHang.Text = dem.ToString();
                    }
                    else
                    {
                        Panel2.Visible = true;
                        Panel1.Visible = false;
                        Panel3.Visible = false;
                    }
                    
                    string user = Convert.ToString(Session["User"]);
                    tbl_Customer cus = db.tbl_Customers.SingleOrDefault(t =>t.User == txtUser.Text);
                    if (cus != null)
                    {
                        Session["hoten"] = cus.FullName.ToString();
                        Session["email"] = cus.Email;
                        Session["diachi"] = cus.Address;
                        Session["SDT"] = cus.Phone;
                    }
                }
                else
                    Label1.Text = "Sai Tài khoản hoặc Mật khẩu";
            }
        }
    }
}
