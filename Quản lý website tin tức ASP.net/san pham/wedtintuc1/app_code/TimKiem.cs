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
/// Summary description for TimKiem
/// </summary>
public class TimKiem:DataAccess
{
	public TimKiem()
	{
        OpenConnection("wedConnectionString1");
	}
    public DataTable TimKiemBaiViet(string tukhoa)
    {
        return ThucThiCauTruyVan_TraVeBang("SELECT * FROM tb_news WHERE title LIKE N'%" + tukhoa + "%' OR DESCRIPTION LIKE  N'%" + tukhoa + "%' OR Keyword LIKE  N'%" + tukhoa + "%' OR Author LIKE  N'%" + tukhoa + "%' OR UserPublish LIKE  N'%" + tukhoa + "%'");
    }
}
