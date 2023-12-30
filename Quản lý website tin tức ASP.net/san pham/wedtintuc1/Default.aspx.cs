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

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cateChaTTCN.Text = LoadTitleTable("4");
        ltrTinCN.Text = LoadTieuDeTinDauTien("4");
        ltr3CN.Text = Load3TinMoi("4");
        cateChaMMT.Text = LoadTitleTable("64");
        ltrMangMT.Text = LoadTieuDeTinDauTien("15");
        ltr3MangMT.Text = Load3TinMoi("15");
        cateChaCNPM.Text = LoadTitleTable("24");
        ltrTinCNPM.Text = LoadTieuDeTinDauTien("24");
        ltr3CNPM.Text = Load3TinMoi("24");
        cateChaKHMT.Text = LoadTitleTable("30");
        ltrKHMT.Text = LoadTieuDeTinDauTien("30");
        ltr3TinKHMT.Text = Load3TinMoi("30");
        cateChaHanhTrang.Text = LoadTitleNoLink("37");
        ltrTinHanhTrang.Text = LoadTieuDeTinDauTien("37");
        ltr3HT.Text = Load3TinMoi("37");
        cateTuyenDung.Text = LoadTitleNoLink("42");
        ltrTinTuyenDung.Text = LoadTieuDeTinDauTien("42");
        ltr3TuyenDung.Text = Load3TinMoi("42");
        cateChaCS.Text = LoadTitleNoLink("46");
        ltrTinCS.Text = LoadTieuDeTinDauTien("46");
        ltr3CS.Text = Load3TinMoi("46");
        cateConDuong.Text = LoadTitleNoLink("57");
        ltrTinCD.Text = LoadTieuDeTinDauTien("57");
        ltr3CD.Text = Load3TinMoi("57");
    }
    private string LoadTitleTable(string head)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TitleHead(head);
        if (dtb.Rows.Count > 0)
        {

            html += @"<a href='ChuyenMucCha.aspx?CateID=" + dtb.Rows[0]["CateID"].ToString() + @"' style='color: black; text-decoration: none;'>
                        " + dtb.Rows[0]["CateName"] + @"</a>";

        }
        return html;
    }
    private string LoadTitleNoLink(string head)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TitleHead(head);
        if (dtb.Rows.Count > 0)
        {

            html += @"<a href='#' style='color: black; text-decoration: none;'>
                        " + dtb.Rows[0]["CateName"] + @"</a>";

        }
        return html;
    }
    private string LoadSlideHot()
    {
        string html = "";
        int i = 1;
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.SlideHot();
        if (dtb.Rows.Count > 0)
        {
            foreach (DataRow dr in dtb.Rows)
            {
                html += @"<div style='background: url(" + dr["ImageUrl"] + @") no-repeat scroll left top transparent;'
                        id='slide-div-'" + i.ToString() + @" class='top-slide'>
                        <div id='banner-title'>
                            <a href='" + dr["Link"] + "'>" + dr["BannerName"] + @"</a>
                        </div>
                        <div id='banner-des'>" + dr["Content"] + @"
                        </div>
                    </div>";
                i++;
            }
        }
        return html;
    }
    private string Load3TinMoi(string cateID)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TinLienQuan(cateID);
        if (dtb.Rows.Count > 0)
        {
            foreach (DataRow dr in dtb.Rows)
            {

                html += "<img height='5' width='6' src='images/mgod_tintuc_arrow.gif'>&nbsp;";
                html += "<a href='ChiTiet.aspx?idNews=" + dr["idNews"].ToString() + @"'";
                html += "onmouseover='showtip(\"<h3>" + dr["Title"] + "</h3>";
                html += "<img width=\\\"125\\\" height=\\\"100\\\" src=\\\"" + dr["Picture"] + "\\\" />";
                html += "<div>" + dr["Description"] + "</div> \");' onmouseout='hidetip();'";
                html += "style='color: black;'  >" + dr["Title"] + @"</a><br>";
            }
        }
        return html;
    }
    private string LoadTieuDeTinDauTien(string cateID)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TenChuyenMuc(cateID);
        if (dtb.Rows.Count > 0)
        {
            html += @"<p ><strong><a href='ChiTiet.aspx?idNews=" + dtb.Rows[0]["idNews"].ToString() + @"'style='color: black;'>" + dtb.Rows[0]["Title"] + @"</a></strong></p><p align='justify' style='font-family:Times New Roman; font-size:14px'><img height='80' style='margin-right:8px;margin-top:5px' align='left' width='115' src='" + dtb.Rows[0]["Picture"] + @"'/>" + dtb.Rows[0]["Description"] + @"</p>";
        }
        return html;
    }
}
