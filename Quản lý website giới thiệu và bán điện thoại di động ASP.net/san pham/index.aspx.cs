using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using SiteUtils;

public partial class sanpham : System.Web.UI.Page
{
    GioHangData gh;
    protected void Page_Load(object sender, EventArgs e)
    {
        ado.ketNoi();
        string query = "Select*,'chitiet.aspx?tensp='+tensp as chitiet from tblsanpham s,tblhang h where s.mahang=h.mahang ";
        OleDbDataAdapter adapter = new OleDbDataAdapter(query, ado.con);
        DataSet dataset = new DataSet();
        adapter.Fill(dataset);
        clp1.PageSize = 12;
        clp1.DataSource = dataset.Tables[0].DefaultView;
        clp1.BindToControl = DataList2;
        DataList2.DataSource = clp1.DataSourcePaged;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ado.ketNoi();
        Label lbg = (Label)DataList2.Items[DataList2.SelectedIndex].FindControl("Label10");
        HyperLink hy = (HyperLink)DataList2.Items[DataList2.SelectedIndex].FindControl("HyperLink1");

       
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
