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
using SiteUtils;
using System.Data.OleDb;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ado.ketNoi();
        string query = "SELECT tblsanpham.masp,'chitiet.aspx?tensp='+tensp as chitiet, tblsanpham.mahang, tblsanpham.tensp, tblsanpham.gia, tblsanpham.soluong, tblsanpham.dacdiem, tblsanpham.baohanh, tblsanpham.khuyenmai, tblsanpham.kieudang, tblsanpham.phongcach, tblsanpham.anh, tblsanpham.ghichu, tblhang.tenhang FROM (tblsanpham INNER JOIN tblhang ON tblsanpham.mahang = tblhang.mahang) WHERE (tblsanpham.phongcach='độc đáo')";
        OleDbDataAdapter adapter = new OleDbDataAdapter(query, ado.con);
        DataSet dataset = new DataSet();
        adapter.Fill(dataset);
        clp1.PageSize = 12;
        clp1.DataSource = dataset.Tables[0].DefaultView;
        clp1.BindToControl = DataList1;
        DataList1.DataSource = clp1.DataSourcePaged;
        //Download source code tại Sharecode.vn
    }
    protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
