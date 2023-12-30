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

namespace DoAn4
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        GioHang gh = new GioHang();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["UserName"] != null)
                LinkDangNhap.Text = "Đăng xuất";
            else
                LinkDangNhap.Text = "Đăng nhập";
            if (Session["GioHang"] != null)
            {
                GioHang gh = (GioHang)Session["giohang"];
                DataTable tb = gh.GetDataTable();
                int dem = 0;
                
                if (tb.Rows.Count > 0)
                {
                    lbkohang.Visible = false;
                    Panel1.Visible = true;
                    double tongtien = 0;
                    dem = tb.Rows.Count;
                    lbgiohang.Text = "Hiện có: "+dem.ToString() + " mặt hàng";
                        for (int i = 0; i < tb.Rows.Count; i++)
                        {
                             tongtien = tongtien+ Convert.ToDouble(tb.Rows[i][8].ToString());
                        }
                    lbltongtien.Text = "Tổng tiền: " + tongtien.ToString("###,###").Replace(',', '.') + "Đ";
                }
                else
                {
                    Panel1.Visible = false;
                    lbkohang.Visible = true;
                }
            }
            else
            {
                Panel1.Visible = false;
                lbkohang.Visible = true;
            }
            //lblsonguoitruycap.Text = "Số lượt truy cập:" + Application["soluottruycap"].ToString();
            lbSoNguoiOnline.Text = "Số người online:" + Application["songuoionline"].ToString();
            
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList4_PreRender(object sender, EventArgs e)
        {
            DropLoai.Items.Insert(0, "--Chọn loại trang phục--");
        }

        protected void DropDownList1_PreRender(object sender, EventArgs e)
        {
            DropNSX.Items.Insert(0,"--Chọn hãng SX--");
        }

        protected void timkiem_Click(object sender, ImageClickEventArgs e)
        {
            string dk = "";
            if (DropLoai.SelectedIndex > 0)
            {
                if (dk != "")
                    dk += " and ";
                dk += " tbl_Type.Type_Name = N'" + DropLoai.Text + "'";
            }
            if (DropNSX.SelectedIndex > 0)
            {
                if (dk != "")
                    dk += " and ";
                dk += " tbl_Producer.Producer_Name = N'" + DropNSX.Text + "'";
            }
            if (DropGiaMin.SelectedIndex > 0)
            {
                if (dk != "")
                    dk += " and ";
                dk += " tbl_Product.Price_Export>='" + DropGiaMin.SelectedValue + "'";
            }
            if (DropGiaMax.SelectedIndex > 0)
            {
                if (dk != "")
                    dk += " and ";
                dk += " tbl_Product.Price_Export<='" + DropGiaMax.SelectedValue + "'";
            }
            Response.Redirect("~/Ketquatimkiem.aspx?DieuKien=" + dk);
        }

        protected void LinkThanhToan_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("~/DangNhap.aspx");
            }
            else
            {
                Response.Redirect("~/ThanhToan.aspx");
            }
        }

        protected void LinkDangNhap_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                Session["UserName"] = null;
                Response.Redirect("~/TrangChu.aspx");
            }
            if (Session["UserName"] == null)
            {
                Response.Redirect("~/DangNhap.aspx");
            }
        }
    }
}
