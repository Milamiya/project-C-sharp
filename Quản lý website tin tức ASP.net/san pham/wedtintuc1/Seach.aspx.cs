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

public partial class Seach : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string tukhoa = Request.QueryString["KeyKhoa"];
           
            if (!string.IsNullOrEmpty(tukhoa))
            {
               
                TimKiem tk = new TimKiem();
              
                DataTable dtb = tk.TimKiemBaiViet(tukhoa);
                
                this.Title = "Tìm kiếm: Keyword= " + tukhoa;
               
                if (dtb.Rows.Count > 0)
                {
                    
                    pnSearch.GroupingText = "Tìm thấy <u>" + dtb.Rows.Count + "</u> kết quả với từ khóa ''<b>" + tukhoa + "</b>''";
                    //Download source code tại Sharecode.vn
                    dtlSearch.DataSource = dtb;
                    dtlSearch.DataBind();
                }
            }
        }
    }
}
