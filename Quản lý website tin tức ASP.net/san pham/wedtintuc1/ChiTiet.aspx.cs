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

public partial class ChiTiet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string idnews = Request.QueryString["idNews"];
            // lấy cái idnews trên thanh địa chỉ và truyền vào một chuối idnews mà mình khởi tạo string idnews
            //Download source code tại Sharecode.vn
            if (!string.IsNullOrEmpty(idnews))
            {
                // Kiểm tra string idnews khác null hay không
                int id = Convert.ToInt32(idnews);
                // Vì idnews trong CSDL mình dùng int nên phải con vớt cái chuỗi sang kiểu int
                TruyVanTin a = new TruyVanTin();
                // Khởi tạo cái lơp TruyVanTin
                DataTable dtb = a.SelectTin(id);
                // Tạo một bảng để chưa dữ liệu trả về là phương thức SelecTin()
                this.Title = dtb.Rows[0]["Title"].ToString();
                // Mình hiện tiêu dề bài viết lên trình duyệt //Download source code tại Sharecode.vn
                DataList1.DataSource = dtb;
                DataList1.DataBind();
                // Đổ dữ liệu mà mình da select ra vào datalist từ cái "DataTable dtb = a.SelectTin(id);"
                ltrTieuDeChuyenMuc.Text = TieuDeChuyenMuc(id);
                // Hiện cái tiêu đề mà bản tin ở trong chuyên mục đó
            }
        }
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        // Tin liên quan//Download source code tại Sharecode.vn
        // Đay là sự kiện trong datalist khi cứ load cái này lên thì ta sẽ có thể lấy đc cái mã hdf_IDNews để hiển thị tin liên quan mà không có cái bản tin hiện hành mà mình đang xem

        HiddenField hdf_ID_news = (HiddenField)e.Item.FindControl("hdf_IDNews");
        // Tạo ra một hiddenfild dể lưu trữ dữ liệu mà tìm trong Datalist 1 cái hdf_IDNews gán cho hdf_ID_news dữ liệu là id bản tin
        int id = Convert.ToInt32(hdf_ID_news.Value);
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TinDaDang(id);
        // Phương thức này tìm ra những bản tin đã đăng mà không có cái bản tin hiện hành chính là id trong a.TinDaDang(id);
        DataList2.DataSource = dtb;
        DataList2.DataBind();

    }
    private string TieuDeChuyenMuc(int idNews)
    {
        string html = "";
        ChuyenMucClass a = new ChuyenMucClass();
        DataTable dtb = a.TenChuyenMucCon(idNews);
        DataTable dtbCha = a.TenChuyenMucCha(idNews);
        if (dtb.Rows.Count > 0 && dtbCha.Rows.Count > 0)
        {
            html += @" <div class='left'>
            <span class='top'><a href='ChuyenMuc.aspx?CateID=" + dtbCha.Rows[0]["CateID"].ToString() + @"'>
                " + dtbCha.Rows[0]["CateName"] + @"</a>
                              <a href='ChuyenMuc.aspx?CateID=" + dtb.Rows[0]["CateID"].ToString() + @"'> -->
                " + dtb.Rows[0]["CateName"] + @"</a>
             </span>
         </div>";
        }
        return html;
    }
}
