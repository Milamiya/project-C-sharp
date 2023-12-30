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

namespace DoAn4
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        GioHang gh = new GioHang();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (Session["GioHang"] != null)
                {
                    GioHang gh = (GioHang)Session["giohang"];
                    DataTable tb = gh.GetDataTable();
                    if (tb.Rows.Count > 0)
                    {
                        PanelKhongHang.Visible = false;
                        Bind();
                    }
                    else
                    {
                        PanelKhongHang.Visible = true;
                        PanelCoHang.Visible = false;
                    }
                }
                else
                {
                    PanelKhongHang.Visible = true;
                    PanelCoHang.Visible = false;
                }
        }
        public void Bind()
        {
            GioHang gh = (GioHang)Session["giohang"];
            DataTable tb = gh.GetDataTable();
            GridView1.DataSource = tb;
            GridView1.DataBind();
            double tongtien = 0;
            double TongTL = 0;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                TableCell tc = gr.Controls[1] as TableCell;
                TextBox t = tc.Controls[1] as TextBox;
                tongtien += double.Parse(gr.Cells[8].Text);
                TongTL += double.Parse(t.Text) * double.Parse(gr.Cells[6].Text);

            }
            lblTongTien.Text = tongtien.ToString("###,###").Replace(',', '.') + "Đ";
            lblTongTL.Text = TongTL.ToString()+"g";
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            int dem = GridView1.Rows.Count;
            string ma = GridView1.Rows[dem-1].Cells[7].Text;
            Response.Redirect("ChiTiet.aspx?Product_ID="+ma);
        }
        private bool Ktra(string t)
        {
            bool kt = true;
            if (t == null || t == "") kt = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].ToString() != "1" && t[i].ToString() != "2" && t[i].ToString() != "3" && t[i].ToString() != "4" && t[i].ToString() != "5" && t[i].ToString() != "6" && t[i].ToString() != "7" && t[i].ToString() != "8" && t[i].ToString() != "8" && t[i].ToString() != "9")
                {
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        protected void btnCapNhat_Click(object sender, ImageClickEventArgs e)
        {
            GioHang gh = (GioHang)Session["giohang"];
            DataTable tb = gh.GetDataTable();
            if (Session["giohang"] != null)
            {
                if (tb.Rows.Count > 0)
                {
                    int dem = tb.Rows.Count;
                    CheckBox cb;
                    TextBox t;
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {
                        string ma = GridView1.Rows[i].Cells[7].Text;
                        InfoDataContext db = new InfoDataContext();
                        tbl_Product pro = db.tbl_Products.SingleOrDefault(a => a.Product_ID.ToString() == ma.Trim());
                        cb = (CheckBox)GridView1.Rows[i].FindControl("CheckXoa");
                        if (cb.Checked)
                        {
                            xoa(tb, ma);
                            dem--;
                        }
                        else
                        {
                            t = (TextBox)GridView1.Rows[i].FindControl("txtSL");
                            if((Ktra(t.Text)==false)||(int.Parse(t.Text)>pro.Amount))
                            {
                                xoa(tb, ma);
                                dem--;
                            }
                            else
                            {
                                double sl = double.Parse(t.Text);
                                double gia = double.Parse(GridView1.Rows[i].Cells[2].Text);
                                foreach (DataRow dr in tb.Rows)
                                {
                                    if (dr[7].ToString().Trim() == ma.Trim())
                                    {
                                        dr[1] = sl;
                                        dr[8] = sl * gia;
                                        break;
                                    }
                                }
                            }
                        }
                        if (dem==0)
                        {
                            PanelKhongHang.Visible = true;
                            PanelCoHang.Visible = false;
                        }
                    }
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                    double tongtien = 0;
                    double TongTL = 0;
                    foreach (GridViewRow gr in GridView1.Rows)
                    {
                        TableCell tc = gr.Controls[1] as TableCell;
                        TextBox txt = tc.Controls[1] as TextBox;
                        tongtien += double.Parse(gr.Cells[8].Text);
                        TongTL += double.Parse(txt.Text) * double.Parse(gr.Cells[6].Text);

                    }
                    lblTongTien.Text = tongtien.ToString("###,###").Replace(',', '.') + "Đ";
                    lblTongTL.Text = TongTL.ToString() + "g";
                }
            }
        }
        private void xoa(DataTable tb, string ma)
        {
            foreach (DataRow dr in tb.Rows)
            {
                if (dr[7].ToString() == ma)
                {
                    tb.Rows.Remove(dr);
                    break;
                }
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }

        protected void btnThanhToan_Click(object sender, ImageClickEventArgs e)
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
    }
}
