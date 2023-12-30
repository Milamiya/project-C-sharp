using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class SlideNews : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal1.Text = LoadHead();
    }
    private string LoadHead()
    {
        string strHTML = "";
        int i = 1, j = 1;
        strHTML += "<div id=\"featured\">";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.NamBanTinMoiNhat();
        if (dtb.Rows.Count > 0)
        {
            strHTML += "<ul class='ui-tabs-nav'>";
            //Phần liệt kê ảnh bên phải
            foreach (DataRow dr in dtb.Rows)
            {
                strHTML += @"
                <li class='ui-tabs-nav-item' id='nav-fragment-" + j.ToString() + @"'> 
                     <a href='#fragment-" + j.ToString() + @"'> 
                         <img src='" + dr["Picture"] + @"'/> 
                         <span>" + dr["Title"] + @"</span> 
                     </a>
                </li>";
                j++;
            }
            strHTML += @"
                </ul>";
            //Phần hiển thị ảnh lớn bên trái
            foreach (DataRow dr2 in dtb.Rows)
            {
                strHTML += @"
                    <div id='fragment-" + i.ToString() + @"' class='ui-tabs-panel ui-tabs-hide'> 
                         <a style='color: rgb(255, 255, 255);' href='ChiTiet.aspx?idNews="+dr2["idNews"]+@"'>
                            <img width='349' height='247'  src='" + dr2["Picture"] + @"'/> 
                         </a>
                        <div class='info'> 
                            <h2><a href='ChiTiet.aspx?idNews="+dr2["idNews"].ToString()+"'>" + dr2["Title"] + @"</a></h2> 
                             <p></p>
                        </div>
                    </div>";
                i++;
            }
        }
        strHTML += "</div>";
        return strHTML;
    }
}
