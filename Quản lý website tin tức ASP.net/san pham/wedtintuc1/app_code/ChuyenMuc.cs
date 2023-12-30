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
/// Summary description for ChuyenMuc
/// </summary>
public class ChuyenMucClass:DataAccess
{
	public ChuyenMucClass()
	{
        OpenConnection("wedConnectionString1");
	}
    //public DataTable LayChuyenMuc()
    //{
    //    return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 4 * FROM TB_Category WHERE ParentID=0 ORDER BY CateID ");
    //}
    public DataTable TenChuyenMucCha(int idNews)
    {
        return ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_CATEGORY WHERE CATEID=(SELECT ParentID FROM TB_CATEGORY WHERE CATEID=( SELECT CATEID FROM TB_NEWS WHERE IDNEWS="+idNews+"))");
    }
    public DataTable TenChuyenMucCon(int idNews)
    {
        return ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_CATEGORY WHERE CATEID=(SELECT CATEID FROM TB_NEWS WHERE idNews="+idNews+")");
    }
    public DataTable Category_GetTree(int intCateID)
    {
        SqlParameter[] arrParam = 
            {
                new SqlParameter("@CateID", SqlDbType.Int) 
            };
        arrParam[0].Value = intCateID;
        return ThucThiStoreTraVeBang("SP_CayChuyenMuc", arrParam);
    }
    public void Category_delete(int CateID, ref string error)
    {
        SqlParameter[] arrParam =
            {
                
                new SqlParameter("@CateID", SqlDbType.Int),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
        arrParam[0].Value = CateID;
        arrParam[1].Direction = ParameterDirection.Output;
        ThucThiStore("sTB_Category_delete", arrParam);
        error = (arrParam[1].Value.ToString() + "" != "" ? arrParam[1].Value.ToString() : "");
    }
    public void Category_Edit(
           
           int CateID,
           int ParentID,
           string CateName,
           string Link,
           ref string error)
    {
        SqlParameter[] arrParam =
            {
                
                new SqlParameter("@CateID", SqlDbType.Int),
                new SqlParameter("@ParentID", SqlDbType.Int),
                new SqlParameter("@CateName", SqlDbType.NVarChar),
                new SqlParameter("@Link", SqlDbType.NVarChar),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
        arrParam[0].Value = CateID;
        arrParam[1].Value = ParentID;
        arrParam[2].Value = CateName;
        arrParam[3].Value = Link;
        arrParam[4].Direction = ParameterDirection.Output;
        ThucThiStore("sTB_Category_Edit", arrParam);
        error = (arrParam[4].Value.ToString() + "" != "" ? arrParam[4].Value.ToString() : "");
    }
    public void Category_Insert(
            int CateID,
           int ParentID,
           string CateName,
           string Link,
           ref string error)
    
    {
        SqlParameter[] arrParam =
            {
                
                new SqlParameter("@CateID", SqlDbType.Int),
                new SqlParameter("@ParentID", SqlDbType.Int),
                new SqlParameter("@CateName", SqlDbType.NVarChar),
                new SqlParameter("@Link", SqlDbType.NVarChar),
                new SqlParameter("@error", SqlDbType.NVarChar,200)
            };
        
        arrParam[0].Value = CateID;
        arrParam[1].Value = ParentID;
        arrParam[2].Value = CateName;
        arrParam[3].Value = Link;
        arrParam[4].Direction = ParameterDirection.Output;
        ThucThiStore("sTB_Category_Insert", arrParam);
        error = (arrParam[4].Value.ToString() + "" != "" ? arrParam[4].Value.ToString() : "");
    }
    public DataTable Category_Search(int intParentID, string strKeyword)
    {
        SqlParameter[] arrParam = 
            {
                new SqlParameter("@ParentID", SqlDbType.Int),
                new SqlParameter("@TuKhoa", SqlDbType.NVarChar)
            };
        arrParam[0].Value = intParentID;
        arrParam[1].Value = strKeyword;
        return ThucThiStoreTraVeBang("spTB_ChuyenMuc_TruyVan", arrParam);
    }
}
