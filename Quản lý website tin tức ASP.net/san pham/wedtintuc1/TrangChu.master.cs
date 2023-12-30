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
//Download source code tại Sharecode.vn
public partial class TrangChu : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MenuLeft();
            DocNhieu();
            Logo();
        }
    }
    private void MenuLeft()
    {
        MenuDoc mn = new MenuDoc();
        DataTable dtb = mn.Menu();
        DataTable dtb2;
        DataRow drRow;
        for (int i = 0; i < dtb.Rows.Count; i++)
        {
            AjaxControlToolkit.AccordionPane accp = new AjaxControlToolkit.AccordionPane();
            drRow = dtb.Rows[i];
            Label lblHeader = new Label();
            lblHeader.ID = "lblHead" + i.ToString();
            lblHeader.Text = "<a href='#'>" + drRow["CateName"].ToString() + "</a>";
            dtb2 = mn.GetCategory(@"Select CateID, CateName From TB_Category  
                Where MenuLevel=1 And ParentID=" + drRow["CateID"].ToString());
            Label lblContent = new Label();
            lblContent.ID = "lblContent" + i.ToString();
            lblContent.Text = "";
            accp.ID = "accp" + i.ToString();
            foreach (DataRow dr in dtb2.Rows)
            {
                lblContent.Text += "<a href='ChuyenMuc.aspx?CateID=" + dr["CateID"] + "'>";
                lblContent.Text += @"<img src='Images/blue_bubble.png' border='0' />";
                lblContent.Text += @"&nbsp;" + @"&nbsp;" + dr["CateName"].ToString() + "</a><br>";
            }
            accp.HeaderContainer.Controls.Add(lblHeader);
            accp.ContentContainer.Controls.Add(lblContent);
            Accordion1.Panes.Add(accp);
        }
    }
    private void DocNhieu()
    {
        TinDocNhieuNhat a = new TinDocNhieuNhat();
        DataTable da = a.DocNhieuNhat();
        DataList2.DataSource = da;
        DataList2.DataBind();
    }
    private void Logo()
    {
        LienKet a = new LienKet();
        DataTable da = a.Logo();
        DataList3.DataSource = da;
        DataList3.DataBind();
    }
    protected void butSeach_Click(object sender, EventArgs e)
    {
        Response.Redirect("Search.aspx?KeyKhoa=" + txtSearch.Text + "");// Khi click vào trang but search sẽ chuyển sang cho mình sang trang search với từ khóa là textbox //Download source code tại Sharecode.vn

    }
}
