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
/// Summary description for TinDocNhieuNhat
/// </summary>
public class TinDocNhieuNhat
{
    DataAccess da = new DataAccess();
	public TinDocNhieuNhat()
	{
        da.OpenConnection("wedConnectionString1");
	}
    public DataTable DocNhieuNhat()
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 5 * FROM TB_News WHERE Status=1 ORDER BY Numread DESC ");
    }
}
