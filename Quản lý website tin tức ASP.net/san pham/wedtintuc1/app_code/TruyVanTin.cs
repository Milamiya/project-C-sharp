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
/// Summary description for TruyVanTin
/// </summary>
public class TruyVanTin:DataAccess
{
	public TruyVanTin()
	{
        OpenConnection("wedConnectionString1");
	}
    public DataTable SelectTin(int idNews)
    {
        SqlParameter[] arrParam =
            {
                new SqlParameter("idNews", SqlDbType.Int)
            };
        arrParam[0].Value = idNews;
        return ThucThiStoreTraVeBang("SP_SelectTin", arrParam);
    }
    public DataTable TB_News_Select(
          string strUserName,
           int intStatus,
           int intCateID,
           string strKeyword,
           string strStartDate,
           string strToDate)
    {
        SqlParameter[] arrParam =
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Status", SqlDbType.Int),
                new SqlParameter("@CateID", SqlDbType.Int),
                new SqlParameter("@Keyword", SqlDbType.NVarChar),
                new SqlParameter("@StartDate", SqlDbType.VarChar),
                new SqlParameter("@ToDate", SqlDbType.VarChar) 
            };
        arrParam[0].Value = strUserName;
        arrParam[1].Value = intStatus;
        arrParam[2].Value = intCateID;
        arrParam[3].Value = strKeyword;
        arrParam[4].Value = strStartDate;
        arrParam[5].Value = strToDate;
        return ThucThiStoreTraVeBang("sTB_News_Select", arrParam);
    }
    public void News_Edit(
            int intAction,
            int intIdNews,
            int intCateID,
            string strUserName,
            string strTitle,
            string strDescription,
            string strContent,
            string strKeyword,
            string strAuthor,
            string strPicture,
            DateTime dtCreateDate,
            DateTime dtPublishDate,
            string strLink,
            int intStatus,
            string strUserPublish,
            int intFeedBack,
            ref string error
            )
    {
        SqlParameter[] arrParam =
            {
                new SqlParameter("@Action", SqlDbType.Int),
                new SqlParameter("@idNews", SqlDbType.Int),
                new SqlParameter("@CateID", SqlDbType.Int),
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Title", SqlDbType.NVarChar),
                new SqlParameter("@Description", SqlDbType.NVarChar),
                new SqlParameter("@Content", SqlDbType.NVarChar),
                new SqlParameter("@Keyword", SqlDbType.NVarChar),
                new SqlParameter("@Author", SqlDbType.NVarChar),
                new SqlParameter("@Picture", SqlDbType.NVarChar),
                new SqlParameter("@CreateDate", SqlDbType.DateTime),
                new SqlParameter("@PublishDate", SqlDbType.DateTime),
                new SqlParameter("@Link", SqlDbType.NVarChar),
                new SqlParameter("@Status", SqlDbType.Int),
                new SqlParameter("@UserPublish", SqlDbType.VarChar),
                new SqlParameter("@FeedBack", SqlDbType.Int),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
        arrParam[0].Value = intAction;
        arrParam[1].Value = intIdNews;
        arrParam[2].Value = intCateID;
        arrParam[3].Value = strUserName;
        arrParam[4].Value = strTitle;
        arrParam[5].Value = strDescription;
        arrParam[6].Value = strContent;
        arrParam[7].Value = strKeyword;
        arrParam[8].Value = strAuthor;
        arrParam[9].Value = strPicture;
        arrParam[10].Value = dtCreateDate;
        arrParam[11].Value = dtPublishDate;
        arrParam[12].Value = strLink;
        arrParam[13].Value = intStatus;
        arrParam[14].Value = strUserPublish;
        arrParam[15].Value = intFeedBack;
        arrParam[16].Direction = ParameterDirection.Output;
        ThucThiStore("SP_NewsUpdate", arrParam);
        error = (arrParam[16].Value.ToString() + "" != "" ? arrParam[16].Value.ToString() : "");
    }
    public void News_UpdateStatus(int intIdNews, int intStatus, ref string strError)
    {
        SqlParameter[] arrParam =
            {
                new SqlParameter("@idNews", SqlDbType.Int),
                new SqlParameter("@Status", SqlDbType.Int),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
               
            };
        arrParam[0].Value = intIdNews;
        arrParam[1].Value = intStatus;
        arrParam[2].Direction = ParameterDirection.Output;
        ThucThiStore("sTB_News_UpdateStatus", arrParam);
        strError = (arrParam[2].Value.ToString() + "" != "" ? arrParam[2].Value.ToString() : "");
    }
    public DataTable TinMoiChuyenMucCha(int cateID)
    {                  
        return ThucThiCauTruyVan_TraVeBang("SELECT TOP 1 idNews,Title,Picture, Description FROM TB_News WHERE CateID IN(SELECT CateID FROM TB_Category WHERE ParentID="+cateID+" )  ORDER BY idNews DESC");
    }
    public DataTable TinHotChuyenMucCha(int cateID)
    {
        return ThucThiCauTruyVan_TraVeBang("SELECT TOP 5 idNews,Title,Picture, Description FROM TB_News WHERE CateID IN(SELECT CateID FROM TB_Category WHERE ParentID="+cateID+" )  ORDER BY Numread DESC");
    }

}
