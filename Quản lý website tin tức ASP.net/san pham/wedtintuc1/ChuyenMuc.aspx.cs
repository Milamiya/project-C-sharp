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

public partial class ChuyenMuc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Mình lấy ra cái CateID của chuyên mục trên thanh địa chỉ của trình duyệt mình gán vào chuỗi string cateID
            string cateID = Request.QueryString["CateID"];
            // Kiểm tra cái string cateID này có khác null hay không
            if (!string.IsNullOrEmpty(cateID))
            {
                int cateid = Convert.ToInt32(cateID);
                // Chuyển kiểu dữ liệu cái cateID thành kiểu int mà khai báo là int cateid
                TinMoiNhat A = new TinMoiNhat();
                // Khởi tạo lớp TinMoiNhat
                DataTable dtb = A.BanTinChuyenMuc(cateid);
                // Trong lớp TinMoiNhat mình có phương thức Tìm ra bản tin của chuyên mục đó: BanTinChuyenMuc(cateid); theo cateID (mã chuyên mục)
                this.Title = A.TenChuyenMucCha(cateid).Rows[0]["CateName"].ToString() + "->" + A.TenChuyenMuc(cateid).Rows[0]["CateName"].ToString();
                // Mình hiện tên tiêu dề trình duyệt là theo cấp độ chuyên mục từ chuyên mục cha(A.TenChuyenMucCha(cateid).Rows[0]["CateName"].ToString()) đến chuyên mục con(A.TenChuyenMuc(cateid).Rows[0]["CateName"].ToString())
                CollectionPager1.PageSize = 8;
                // Vì cái kết quả truy vấn ra có thể nhiều nên phân trang số lượng là 8 bản tin trên/ trang
                CollectionPager1.DataSource = dtb.DefaultView;
                // Đổ dữ liệu vào phân trang này là một bảng dtb chính là từ thằng này  DataTable dtb = A.BanTinChuyenMuc(cateid);
                CollectionPager1.BindToControl = DataList4;
                // Đẩy dữ liệu khi đã phân trang bằng collectionpager vào datalist
                DataList4.DataSource = CollectionPager1.DataSourcePaged;
                // Nguồn dữ liệu khi đã phân trang lúc đó sẽ hiện bản tin trên trang web
                ltrLastNews.Text = TinMoiNhat(cateid);
                // Tin mới nhất. Dược lấy từ phương thức này TinMoiNhat(cateid);
                ltrHotNews.Text = TinHot(cateid);
                // Tin đọc nhiều nhất sẽ lấy ra những bản tin được đọc nhiều nhất dựa trên cái mã chuyên mục và đếm theo số lần click lúc đó nó sẽ đếm theo số lượt đọc
                ltrTieuDeChuyenMuc.Text = TieuDeChuyenMuc(cateid);
                // Tiêu đề theo cấp chuyên mục     private string TieuDeChuyenMuc(int cateID)
            }
        }
    }
    private string TieuDeChuyenMuc(int cateID)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TenChuyenMuc(cateID);
        DataTable dtbCha = a.TenChuyenMucCha(cateID);
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
    private string TinMoiNhat(int cateid)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.MotBanTin(cateid);
        if (dtb.Rows.Count > 0)
        {
            html += @"<div>
                <a href='ChiTiet.aspx?idNews=" + dtb.Rows[0]["idNews"].ToString() + @"'>
                    <img height='280' width='430' src='" + dtb.Rows[0]["Picture"] + @"'></a>
                 </div>
            <div class='head01'>
                <img src='images/ico_new.gif'>&nbsp<a href='ChiTiet.aspx?idNews=" + dtb.Rows[0]["idNews"].ToString() + @"'>" + dtb.Rows[0]["Title"] + @"</a>
            </div>
            <p>" + dtb.Rows[0]["Description"] + @"</p>";
        }
        return html;
    }
    private string TinHot(int cateid)
    {
        string html = "";
        TinMoiNhat a = new TinMoiNhat();
        DataTable dtb = a.TinHot(cateid);
        if (dtb.Rows.Count > 0)
        {
            foreach (DataRow dr in dtb.Rows)
            {
                html += @"<li><a href='ChiTiet.aspx?idNews=" + dr["idNews"].ToString() + @"'
                        title='" + dr["Description"] + @"'>" + dr["Title"] + @"</a></li>";
            }
        }
        return html;
    }
}
