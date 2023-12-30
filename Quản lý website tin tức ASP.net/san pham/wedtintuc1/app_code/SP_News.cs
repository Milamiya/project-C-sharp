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
/// Summary description for SP_News
/// </summary>
public class SP_News:DataAccess
{
	public SP_News()
	{
        OpenConnection("wedConnectionString1");
	}
    public DataTable News_SelectByID(long lgNewsID)
    {
        SqlParameter[] arrParam =
            {
                new SqlParameter("@idNews", SqlDbType.BigInt) 
            };
        arrParam[0].Value = lgNewsID;
        return ThucThiStoreTraVeBang("sTB_News_SelectByID", arrParam);
    }
     public void News_Edit(
           
            long intIdNews,
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
                
                new SqlParameter("@idNews", SqlDbType.BigInt),
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
           
           arrParam[0].Value = intIdNews;
           arrParam[1].Value = intCateID;
           arrParam[2].Value = strUserName;
           arrParam[3].Value = strTitle;
           arrParam[4].Value = strDescription;
           arrParam[5].Value = strContent;
           arrParam[6].Value = strKeyword;
           arrParam[7].Value = strAuthor;
           arrParam[8].Value = strPicture;
           arrParam[9].Value = dtCreateDate;
           arrParam[10].Value = dtPublishDate;
           arrParam[11].Value = strLink;
           arrParam[12].Value = intStatus;
           arrParam[13].Value = strUserPublish;
           arrParam[14].Value = intFeedBack;
           arrParam[15].Direction = ParameterDirection.Output;
           ThucThiStore("SP_NewEdit", arrParam);
           error = (arrParam[15].Value.ToString() + "" != "" ? arrParam[15].Value.ToString() : "");
       }
     public void News_Insert(

            long intIdNews,
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
                
                new SqlParameter("@idNews", SqlDbType.BigInt),
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

         arrParam[0].Value = intIdNews;
         arrParam[1].Value = intCateID;
         arrParam[2].Value = strUserName;
         arrParam[3].Value = strTitle;
         arrParam[4].Value = strDescription;
         arrParam[5].Value = strContent;
         arrParam[6].Value = strKeyword;
         arrParam[7].Value = strAuthor;
         arrParam[8].Value = strPicture;
         arrParam[9].Value = dtCreateDate;
         arrParam[10].Value = dtPublishDate;
         arrParam[11].Value = strLink;
         arrParam[12].Value = intStatus;
         arrParam[13].Value = strUserPublish;
         arrParam[14].Value = intFeedBack;
         arrParam[15].Direction = ParameterDirection.Output;
         ThucThiStore("SP_NewInsert", arrParam);
         error = (arrParam[15].Value.ToString() + "" != "" ? arrParam[15].Value.ToString() : "");
     }
     public void News_Delete(

            long intIdNews,
            
            ref string error
            )
     {
         SqlParameter[] arrParam =
            {
                
                new SqlParameter("@idNews", SqlDbType.BigInt),
                
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };

         arrParam[0].Value = intIdNews;
        
         arrParam[1].Direction = ParameterDirection.Output;
         ThucThiStore("SP_NewDelete", arrParam);
         error = (arrParam[1].Value.ToString() + "" != "" ? arrParam[1].Value.ToString() : "");
     }
}
