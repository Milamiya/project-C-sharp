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
using SiteUtils;
using System.Data.OleDb;
public partial class Default2 : System.Web.UI.Page
{
    GioHangData gh;
    protected void Page_Load(object sender, EventArgs e)
    {
        ado.ketNoi();
        string query = "Select*,'chitiet.aspx?tensp='+tensp as chitiet from tblsanpham where phongcach='" + Request.QueryString.Get(0) + "'";
        OleDbDataAdapter adapter = new OleDbDataAdapter(query, ado.con);
        DataSet dataset = new DataSet();
        adapter.Fill(dataset);
        clp1.PageSize = 12;
        clp1.DataSource = dataset.Tables[0].DefaultView;
        clp1.BindToControl = DataList1;
        DataList1.DataSource = clp1.DataSourcePaged;
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ado.ketNoi();
        Label lbg = (Label)DataList1.Items[DataList1.SelectedIndex].FindControl("Label10");
        HyperLink hy = (HyperLink)DataList1.Items[DataList1.SelectedIndex].FindControl("HyperLink1");      
     
      
            lbg.Visible = true;
        gh = new GioHangData();
        DataTable tb;
        if (Session["GioHang"] == null)
            tb = gh.setTable();
        else
            tb = (DataTable)Session["GioHang"];
        string query = "select * from tblSanPham where masp='" + hy.Text + "'";

        OleDbDataAdapter da = new OleDbDataAdapter(query, ado.con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            tb = gh.dienVaoBang(tb, dr[10].ToString(), dr["TenSP"].ToString(), 1, Convert.ToDouble(dr["Gia"]), dr["masp"].ToString());
            Session["GioHang"] = tb;

        }    
    }
}
