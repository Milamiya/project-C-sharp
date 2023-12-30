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
/// Summary description for TimKiemData
/// </summary>
public class TimKiemData
{
    DataTable dt;
	public TimKiemData()
	{
        dt = new DataTable();
        dt.Columns.Add("Anh");
        dt.Columns.Add("TenSP");
        dt.Columns.Add("Gia");
        dt.Columns.Add("soluong");
        dt.Columns.Add("chitiet");     
       
	}

    public DataTable setTable()
    {
        return this.dt;
    }

    public DataTable dienVaoBang(DataTable tb, string Anh, string TenSP, double Gia, double soluong,string chitiet)
    {
        DataRow dr = tb.NewRow();
        dr[0] = Anh;
        dr[1] = TenSP;        
        dr[2] = Gia;
        dr[3] =  soluong;
        dr[4] =  chitiet;    
        tb.Rows.Add(dr);                  
        return tb;
    }
}
