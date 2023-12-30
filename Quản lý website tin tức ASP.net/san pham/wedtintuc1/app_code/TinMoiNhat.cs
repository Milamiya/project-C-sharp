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
/// Summary description for TinMoiNhat
/// </summary>
public class TinMoiNhat
{
    DataAccess da = new DataAccess();
	public TinMoiNhat()
	{
        da.OpenConnection("wedConnectionString1");
	}
    public DataTable TinMoi()
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 3 * FROM TB_News ORDER BY idNews DESC ");
    }
    public DataTable TinTrangChu()
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_News WHERE idNews=(SELECT MAX(idNews) FROM TB_News)");
    }
    public DataTable TinLienQuan(string cateCha)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 3 * FROM TB_News WHERE CateID IN(SELECT CateID FROM TB_Category WHERE ParentID='" + cateCha + "') AND idNews <(SELECT MAX(idNews) FROM TB_News WHERE CateID IN(SELECT CateID FROM TB_Category WHERE ParentID='" + cateCha + "')) ORDER BY idNews DESC");
    }
    public DataTable TinLienQuan()
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 3 * FROM TB_News WHERE idNews<(SELECT MAX(idNews) FROM TB_News ) ORDER BY idNews DESC");
    }
    public DataTable TenChuyenMuc(string cateIDCha)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 1 * FROM TB_News WHERE CateID IN(SELECT CateID FROM TB_Category WHERE ParentID='"+cateIDCha+"') ORDER BY idNews DESC");
    }
    public DataTable MotBanTin(int cateid)
    {
       return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 1 idNews,Title,Picture,Description FROM TB_News WHERE CateID="+cateid+" ORDER BY idNews DESC");
    }
    public DataTable NamBanTinMoiNhat()
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 5 * FROM TB_News WHERE Status=1 ORDER BY idNews DESC");
    }
    public DataTable TinHot(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 7 * FROM TB_News WHERE CateID="+cateID+" ORDER BY Numread DESC");
    }
    public DataTable TinKhac(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 7 * FROM TB_News WHERE CateID="+cateID+" AND idNews <(SELECT MIN(idNews) FROM TB_News WHERE idNews IN (SELECT TOP 8 idNew FROM TB_News WHERE CateID="+cateID+" ORDER BY idNews DESC ) ) ORDER BY idNews DESC");
    }
    public DataTable SlideHot()
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 5 * FROM TB_Banner WHERE Location='head'");
    }
    public DataTable TitleHead(string cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_Category WHERE MenuLevel=0 AND CateID=" + cateID + "");
    }
    public DataTable BanTinChuyenMuc(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_News WHERE CateID="+cateID+" ORDER BY idNews DESC");
    }
    public DataTable LoadIDChuyenMucCon(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT CateID FROM TB_Category tc WHERE tc.CateID IN (SELECT tc2.CateID FROM TB_Category tc2 WHERE tc2.ParentID="+cateID+")");
    }
    public DataTable LoadTinTheoChuyenMuc(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 4 * FROM TB_News WHERE CateID="+cateID+" ORDER BY idNews DESC ");
    }
    public DataTable TenChuyenMuc(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_Category WHERE CateID="+cateID+"");
    }
    public DataTable TenChuyenMucCha(int cateID)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_Category WHERE CateID=(SELECT ParentID FROM TB_Category WHERE CateID="+cateID+")");
    }
    public DataTable Tin(int idnews)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT * FROM TB_News WHERE idNews="+idnews+"");
    }
    public DataTable TinDaDang(int idNews)
    {
        return da.ThucThiCauTruyVan_TraVeBang("SELECT TOP 5 * FROM TB_News WHERE idNews!="+idNews+" AND CateID=(SELECT CateID FROM TB_News WHERE idNews="+idNews+")");
    }
}
