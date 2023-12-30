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
using System.Data.SqlClient;
public partial class hello_Default : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {        
       
    }
    clsDatabase cls = new clsDatabase();
    //public void LoadData()
    //{
    //    DataTable dt;
    //    DataSet ds;
    //    SqlDataAdapter sqlDa;
    //    int sobantintrongtrang = 2;
    //    dt = cls.LoadDuLieuPKN(SqlDataSource1.SelectCommand);
    //    lbTongsobantin.Text = dt.Rows.Count.ToString();
    //    int sotrang = dt.Rows.Count % sobantintrongtrang == 0 ? dt.Rows.Count / sobantintrongtrang : dt.Rows.Count / sobantintrongtrang + 1;
    //    lbSobantintrongtrang.Text = Convert.ToString(sotrang);
    //    int bantin = int.Parse(lbBanTin.Text);
    //    if (bantin <= sotrang)
    //    {
    //        ds = cls.GetDataSet();
    //        sqlDa = cls.GetDataAdapter();
    //        sqlDa.Fill(ds, (bantin - 1) * sobantintrongtrang, sobantintrongtrang, "tb");
    //        DataList1.DataSource = ds.Tables["tb"];
    //        DataList1.DataBind();
    //    }
    //    if (bantin == sotrang)
    //    {
    //        lkbNext.Enabled = false;
    //    }
    //    else
    //    {
    //        lkbNext.Enabled = true;
    //    }
    //    if (bantin == 1) lkbPreview.Enabled = false;
    //    else lkbPreview.Enabled = true;
    //}
    //protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    //{
    //    if (e.CommandName == "Sua")
    //    {
    //        DataList1.EditItemIndex = e.Item.ItemIndex;
    //        LoadData();
    //        //DataList1.DataBind();
    //    }
    //    if (e.CommandName == "Xoa")
    //    {
    //        SqlDataSource1.DeleteParameters.Clear();
    //        Label lblID = (Label)e.Item.FindControl("ProductIDLabel");
    //        SqlDataSource1.DeleteParameters.Add("ProductID", TypeCode.String, lblID.Text);
    //        SqlDataSource1.Delete();
    //        SqlDataSource1.DataBind();
    //        DataList1.DataBind();
    //    }
    //    if (e.CommandName == "Luu")
    //    {
    //        SqlDataSource1.UpdateParameters.Clear();
    //        Label lbl = (Label)e.Item.FindControl("ProductIDLabel");
    //        TextBox t1 = (TextBox)e.Item.FindControl("txtProductName");
    //        //TextBox t2 = (TextBox)e.Item.FindControl("txtImageURL");
    //        FileUpload fu = (FileUpload)e.Item.FindControl("FileUpload1");  
    //        TextBox t3 = (TextBox)e.Item.FindControl("txtPromotion");
    //        TextBox t4 = (TextBox)e.Item.FindControl("txtPrice");
    //        TextBox t5 = (TextBox)e.Item.FindControl("txtNumber");
    //        TextBox t6 = (TextBox)e.Item.FindControl("txtManufacturer");
    //        TextBox t7 = (TextBox)e.Item.FindControl("txtMicroprosesor");
    //        TextBox t8 = (TextBox)e.Item.FindControl("txtRAM");
    //        TextBox t9 = (TextBox)e.Item.FindControl("txtHardDrive");
    //        TextBox t10 = (TextBox)e.Item.FindControl("txtOS");
    //        TextBox t11 = (TextBox)e.Item.FindControl("txtDisplay");
    //        TextBox t12 = (TextBox)e.Item.FindControl("txtCamera");
    //        TextBox t13 = (TextBox)e.Item.FindControl("txtGraphicDrive");
    //        TextBox t14 = (TextBox)e.Item.FindControl("txtPin");
    //        TextBox t15 = (TextBox)e.Item.FindControl("txtVolume");
    //        TextBox t16 = (TextBox)e.Item.FindControl("txtOrigin");
    //        TextBox t17 = (TextBox)e.Item.FindControl("txtWarranty");
    //        SqlDataSource1.UpdateParameters.Add("ProductID", TypeCode.String, lbl.Text);
    //        SqlDataSource1.UpdateParameters.Add("ProductName", TypeCode.String, t1.Text);
    //        SqlDataSource1.UpdateParameters.Add("ImageURL", TypeCode.String, "Image/"+ fu.FileName);            
    //        SqlDataSource1.UpdateParameters.Add("Promotion", TypeCode.String, t3.Text);
    //        SqlDataSource1.UpdateParameters.Add("Price", TypeCode.String, t4.Text);
    //        SqlDataSource1.UpdateParameters.Add("Number", TypeCode.String, t5.Text);
    //        SqlDataSource1.UpdateParameters.Add("Manufacturer", TypeCode.String, t6.Text);
    //        SqlDataSource1.UpdateParameters.Add("Microprocessor", TypeCode.String, t7.Text);
    //        SqlDataSource1.UpdateParameters.Add("Memory", TypeCode.String, t8.Text);
    //        SqlDataSource1.UpdateParameters.Add("HardDrive", TypeCode.String, t9.Text);
    //        SqlDataSource1.UpdateParameters.Add("OS", TypeCode.String, t10.Text);
    //        SqlDataSource1.UpdateParameters.Add("Display", TypeCode.String, t11.Text);
    //        SqlDataSource1.UpdateParameters.Add("Camera", TypeCode.String, t12.Text);
    //        SqlDataSource1.UpdateParameters.Add("GraphicsCard", TypeCode.String, t13.Text);
    //        SqlDataSource1.UpdateParameters.Add("Pin", TypeCode.String, t14.Text);
    //        SqlDataSource1.UpdateParameters.Add("Volume", TypeCode.String, t15.Text);
    //        SqlDataSource1.UpdateParameters.Add("Origin", TypeCode.String, t16.Text);
    //        SqlDataSource1.UpdateParameters.Add("Warranty", TypeCode.String, t17.Text);
    //        SqlDataSource1.Update();
    //        SqlDataSource1.DataBind();
    //        //DataList1.DataBind();
    //        DataList1.EditItemIndex = -1;
    //        LoadData();            
    //        //DataList1.DataBind();
    //    }
    //    if (e.CommandName == "Huy")
    //    {
    //        DataList1.EditItemIndex = -1;
    //        LoadData();
    //        //DataList1.DataBind();
    //    }
    //}
    protected void lkbPreview_Click(object sender, EventArgs e)
    {
        //lbBanTin.Text = (int.Parse(lbBanTin.Text) - 1).ToString();
        //LoadData();
    }
    protected void lkbNext_Click(object sender, EventArgs e)
    {
        //lbBanTin.Text = (int.Parse(lbBanTin.Text) + 1).ToString();
        //LoadData();
    }
    
    public void Chon(object sender, EventArgs e)
    {
        CheckBox cbAll = (CheckBox)GridView1.HeaderRow.Cells[0].Controls[1];        
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox cb=(CheckBox) GridView1.Rows[i].Cells[0].Controls[1];
            cb.Checked = cbAll.Checked;
        }       
    }

    protected void btSua_Click(object sender, EventArgs e)
    {

    }

    protected void btXoa_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox item = (CheckBox)GridView1.Rows[i].Cells[0].Controls[1];
            if (item.Checked)
            {
                GridView1.DeleteRow(i);
            }
        }
    }    
}
