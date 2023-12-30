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

public partial class ChuyenMucCha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[] a;
        if (!IsPostBack)
        {
            string cateID = Request.QueryString["CateID"];
            if (!string.IsNullOrEmpty(cateID))
            {
                int cateid = Convert.ToInt32(cateID);
                ltrTieuDeChuyenMuc.Text = TieuDeChuyenMuc(cateid);
                ltrLastNews.Text = TinMoiNhat(cateid);
                ltrHotNews.Text = TinHot(cateid);
                TinMoiNhat A = new TinMoiNhat();
                this.Title = A.TenChuyenMuc(cateid).Rows[0]["CateName"].ToString();
                DataTable dtb = A.LoadIDChuyenMucCon(cateid);
                DataTable dtb2 = new DataTable();
                Label lblCateID = new Label();
                if (dtb.Rows.Count > 0)
                {
                    a = new int[dtb.Rows.Count];
                    for (int i = 0; i < a.Length; i++)
                    {
                        lblCateID.Text = "";
                        lblCateID.Text = dtb.Rows[i]["CateID"] + "";
                        a[i] = int.Parse(lblCateID.Text);
                    }
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[0] != 0)
                        {
                            if (A.LoadTinTheoChuyenMuc(a[0]).Rows.Count > 0)
                            {
                                lbl1.Text = A.TenChuyenMuc(a[0]).Rows[0]["CateName"].ToString();
                                dtl1.DataSource = A.LoadTinTheoChuyenMuc(a[0]);
                                dtl1.DataBind();
                            }
                        }
                    }
                    if (a[0] != 0)
                    {
                        if (A.LoadTinTheoChuyenMuc(a[0]).Rows.Count > 0)
                        {
                            lbl1.Text = A.TenChuyenMuc(a[0]).Rows[0]["CateName"].ToString();
                            dtl1.DataSource = A.LoadTinTheoChuyenMuc(a[0]);
                            dtl1.DataBind();
                        }
                    }
                    if (a[1] != 0)
                    {
                        if (A.LoadTinTheoChuyenMuc(a[1]).Rows.Count > 0)
                        {
                            lbl2.Text = A.TenChuyenMuc(a[1]).Rows[0]["CateName"].ToString();
                            dtl2.DataSource = A.LoadTinTheoChuyenMuc(a[1]);
                            dtl2.DataBind();
                        }
                    }
                    if (a[2] != 0)
                    {
                        if (A.LoadTinTheoChuyenMuc(a[2]).Rows.Count > 0)
                        {
                            lbl3.Text = A.TenChuyenMuc(a[2]).Rows[0]["CateName"].ToString();
                            dtl3.DataSource = A.LoadTinTheoChuyenMuc(a[2]);
                            dtl3.DataBind();
                        }
                    }
                    if (a[3] != 0)
                    {
                        if (A.LoadTinTheoChuyenMuc(a[3]).Rows.Count > 0)
                        {
                            lbl4.Text = A.TenChuyenMuc(a[3]).Rows[0]["CateName"].ToString();
                            dtl4.DataSource = A.LoadTinTheoChuyenMuc(a[3]);
                            dtl4.DataBind();
                        }
                    }
                    if (a[4] != 0)
                    {
                        if (A.LoadTinTheoChuyenMuc(a[4]).Rows.Count > 0)
                        {
                            lbl5.Text = A.TenChuyenMuc(a[4]).Rows[0]["CateName"].ToString();
                            dtl5.DataSource = A.LoadTinTheoChuyenMuc(a[4]);
                            dtl5.DataBind();
                        }
                    }

                }
            }
        }
    }
    private string TieuDeChuyenMuc(int cateID)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TenChuyenMuc(cateID);
        if (dtb.Rows.Count > 0)
        {
            html += @" <div class='left'>
            <span class='top'><a href='ChuyenMucCha.aspx?CateID=" + dtb.Rows[0]["CateID"].ToString() + @"'>
                " + dtb.Rows[0]["CateName"] + @"</a>
             </span>
         </div>";
        }
        return html;
    }
    private string TinMoiNhat(int cateid)
    {
        string html = "";
        TruyVanTin Tvt = new TruyVanTin();
        DataTable dtb = Tvt.TinMoiChuyenMucCha(cateid);
        if (dtb.Rows.Count > 0)
        {
            html += @"<div>
                <a href='ChiTiet.aspx?idNews=" + dtb.Rows[0]["idNews"].ToString() + @"'>
                    <img height='280' width='430' src='" + dtb.Rows[0]["Picture"] + @"'></a>
                 </div>
            <div class='head01'>
                <img src='images/ico_new.gif'>&nbsp<a href='ChiTiet.aspx?idNews=" + dtb.Rows[0]["idNews"].ToString() + @"'>" + dtb.Rows[0]["Title"] + @"</a>
            </div>
            <p>" + dtb.Rows[0]["Description"] + @"</p>";
        }
        return html;
    }
    private string TinHot(int cateid)
    {
        string html = "";
        TruyVanTin tvt = new TruyVanTin();
        DataTable dtb = tvt.TinHotChuyenMucCha(cateid);
        if (dtb.Rows.Count > 0)
        {
            foreach (DataRow dr in dtb.Rows)
            {
                html += @"<li><a href='ChiTiet.aspx?idNews=" + dr["idNews"].ToString() + @"'
                        title='" + dr["Description"] + @"'>" + dr["Title"] + @"</a></li>";
            }
        }
        return html;
    }
}
