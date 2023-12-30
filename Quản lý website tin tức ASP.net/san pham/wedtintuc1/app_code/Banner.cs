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
using System.Data.SqlClient;

/// <summary>
/// Summary description for Banner
/// </summary>
public class Banner:DataAccess
{
	public Banner()
	{
        OpenConnection("sunConnectionString1");
	}
    public DataTable SelectBannerByID(int intCateID)
    {
        SqlParameter[] arrParam = 
            {
                new SqlParameter("@idBanner", SqlDbType.Int) 
            };
        arrParam[0].Value = intCateID;
        return ThucThiStoreTraVeBang("sTB_Banner_SelecByID", arrParam);
    }
    public void Banner_Edit(
         int Action,
         int idBanner,
         string BannerName,
         string Link,
         string ImageUrl,
        string Content,
         DateTime CreateDate,
        string Location,
        int Status,
         ref string error)
    {
        SqlParameter[] arrParam =
            {
                new SqlParameter("@Action", SqlDbType.Int),
                new SqlParameter("@idBanner", SqlDbType.Int),
                new SqlParameter("@BannerName", SqlDbType.NVarChar),
                new SqlParameter("@Link", SqlDbType.NVarChar),
                new SqlParameter("@ImageUrl", SqlDbType.VarChar),
                new SqlParameter("@Content", SqlDbType.NVarChar),
                new SqlParameter("@CreateDate", SqlDbType.DateTime),
                new SqlParameter("@Location", SqlDbType.VarChar),
                new SqlParameter("@Status", SqlDbType.Int),
                new SqlParameter("@error", SqlDbType.NVarChar,200),
            };
        arrParam[0].Value = Action;
        arrParam[1].Value = idBanner;
        arrParam[2].Value = BannerName;
        arrParam[3].Value = Link;
        arrParam[4].Value = ImageUrl;
        arrParam[5].Value = Content;
        arrParam[6].Value = CreateDate;
        arrParam[7].Value = Location;
        arrParam[8].Value = Status;
        arrParam[9].Direction = ParameterDirection.Output;
       ThucThiStore("sTB_Banner_Edit", arrParam);
        error = (arrParam[9].Value.ToString() + "" != "" ? arrParam[9].Value.ToString() : "");
    }
}
