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
using Microsoft.Win32;

/// <summary>
/// Summary description for dienthoaiitem
/// </summary>
public class dienthoaiitem
{
    //Lớp định nghĩa dienthoaiItem chứa trong giỏ hàng
    public string madt;
    public int soluong;
	public dienthoaiitem(string madt,int soluong)
	{
         this.madt=madt;
         this.soluong=soluong ;
		
	}
}
