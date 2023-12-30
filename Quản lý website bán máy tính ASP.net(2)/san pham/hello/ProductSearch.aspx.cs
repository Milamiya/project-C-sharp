using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class hello_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{            
        //    LoadData();
        //}        
        lbThongBao.Visible = false;
    }
    clsDatabase cls = new clsDatabase();
    public void LoadData(DataTable dt)
    {
        //DataTable dt;
        DataSet ds;
        SqlDataAdapter sqlDa;
        int sobantintrongtrang = 2;
        //dt = cls.LoadDuLieuPKN("select * from tbProduct where Manufacturer ='"+ddlNSX.SelectedValue+"'");
        lbTongsobantin.Text = dt.Rows.Count.ToString();
        int sotrang = dt.Rows.Count % sobantintrongtrang == 0 ? dt.Rows.Count / sobantintrongtrang : dt.Rows.Count / sobantintrongtrang + 1;
        lbSobantintrongtrang.Text = Convert.ToString(sotrang);
        int bantin = int.Parse(lbBanTin.Text);
        if (bantin <= sotrang)
        {
            ds = cls.GetDataSet();
            sqlDa = cls.GetDataAdapter();
            sqlDa.Fill(ds, (bantin - 1) * sobantintrongtrang, sobantintrongtrang, "tb");
            ddlThongSoSP.DataSource = ds.Tables["tb"];
            ddlThongSoSP.DataBind();
        }
        if (bantin == sotrang)
        {
            lkbNext.Enabled = false;
        }
        if (bantin == 1)
        {
            lkbPreview.Enabled = false;
            lkbNext.Enabled = true;
        }
        else lkbPreview.Enabled = true;
    }
    protected void lkbPreview_Click(object sender, EventArgs e)
    {
        string truong = ddlTruong.SelectedValue;
        string thongso = txtThongSo.Text;
        lbBanTin.Text = (int.Parse(lbBanTin.Text) - 1).ToString();
        DataTable dt = cls.LoadDuLieuPKN("select * from tbProduct where Manufacturer ='" + ddlNSX.SelectedValue + "' and " + truong + " like '" + thongso + "%' ");        
        LoadData(dt);  
    }
    protected void lkbNext_Click(object sender, EventArgs e)
    {
        string truong = ddlTruong.SelectedValue;
        string thongso = txtThongSo.Text;
        lbBanTin.Text = (int.Parse(lbBanTin.Text) + 1).ToString();
        DataTable dt = cls.LoadDuLieuPKN("select * from tbProduct where Manufacturer ='" + ddlNSX.SelectedValue + "' and " + truong + " like '" + thongso + "%' ");        
        LoadData(dt);  
    }
    //protected void ddlNSX_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    DataTable dt = cls.LoadDuLieuPKN("select * from tbProduct where Manufacturer ='" + ddlNSX.SelectedValue + "'");
    //    LoadData(dt);
    //}
    protected void btTimKiem_Click(object sender, EventArgs e)
    {
        try
        {
            string truong = ddlTruong.SelectedValue;
            string thongso = txtThongSo.Text;
            DataTable dt = cls.LoadDuLieuPKN("select * from tbProduct where Manufacturer='" + ddlNSX.SelectedValue + "' and " + truong + " like '" + thongso + "%'");
            LoadData(dt);
        }
        catch (Exception ex)
        {
            lbThongBao.Visible = true;
        }
    }
}
