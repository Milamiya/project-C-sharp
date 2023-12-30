using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for clsThaoTac
/// </summary>
public class clsThaoTac
{
    DataClassesDataContext db = new DataClassesDataContext();
	public clsThaoTac()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void LoadLoaiSP(DropDownList ddl)
    {
        var c = from p in db.ProductGroups select new { p.ProductGroupID,p.ProductGroupName };
        ddl.DataSource = c;
        ddl.DataTextField = "ProductGroupName";
        ddl.DataValueField = "ProductGroupID";
        ddl.DataBind();
    }
    public void LoadHangSX(DropDownList ddl)
    {
        var c = from p in db.Manufactures select new {p.ManufactureID,p.ManufactureName };
        ddl.DataSource = c;
        ddl.DataTextField = "ManufactureName";
        ddl.DataValueField = "ManufactureID";
        ddl.DataBind();
    }
    public void LoadChiTietSP(string productID,DataList dl)
    {
        var c = from p in db.Products
                where p.ProductID == productID
                select new { p.ProductName, p.ProductID, p.Price, p.Images,p.Descriptions};
        dl.DataSource = c;
        dl.DataBind();
    }
    public void LoadSPCL(string productID, DataList dl)
    {
        var c=(from p in db.Products
              where p.ProductID==productID 
              select p.ProductGroup.ProductGroupID).First();


        var t = from p in db.Products
                where p.ProductGroup.ProductGroupID == c
                select new { p.ProductID, p.ProductName, p.Price, p.Images };
        dl.DataSource = t; dl.DataBind();
    }
}
