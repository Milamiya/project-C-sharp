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
/// Summary description for MenuDoc
/// </summary>
public class MenuDoc
{
    DataAccess da = new DataAccess();
	public MenuDoc()
	{
        da.OpenConnection("wedConnectionString1");
	}
    public DataTable Menu()
    {
        return da.ThucThiCauTruyVan_TraVeBang("Select CateID, CateName From  TB_Category Where MenuLevel=0");
    }
    public DataTable GetCategory(string sql)
    {
        return da.ThucThiCauTruyVan_TraVeBang(sql);
    }
}
