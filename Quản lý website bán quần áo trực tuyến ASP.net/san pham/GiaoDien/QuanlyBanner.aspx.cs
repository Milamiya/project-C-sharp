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

public partial class GiaoDien_QuanlyBanner : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadTime();
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        if (kiemtra(txtMa.Text) == 0)
        {
            Banner b = new Banner();
            b.BannerID = txtMa.Text;
            b.BannertName = txtTen.Text;
            b.Date = ChuyenDoiNgay();
            b.Images = Fluanh.PostedFile.FileName;
            db.Banners.InsertOnSubmit(b);
            db.SubmitChanges();
        }
        {

        }
    }
    public int kiemtra(string ma)
    {
        int dem = db.Banners.Count(p => p.BannerID == ma);
        return dem;
    }
    void xoacotrl()
    {
        txtMa.Text = "";
        txtTen.Text = "";
        
    }
    DateTime ChuyenDoiNgay()
    {
        DateTime dt;
        int ngay = int.Parse(ddlNgay.SelectedItem.Text.ToString());
        int thang = int.Parse(ddlThang.SelectedItem.Text.ToString());
        int nam = int.Parse(ddlNam.SelectedItem.Text.ToString());
        dt = new DateTime(nam, thang, ngay);
        return dt;
    }
    public void LoadTime()
    {
        ddlNgay.Items.Add("Ngày");
        ddlThang.Items.Add("Tháng");
        ddlNam.Items.Add("Năm");
        for (int i = 1; i <= 31; i++)
        {
            ddlNgay.Items.Add(i.ToString());
        }
        for (int j = 1; j <= 12; j++)
        {
            ddlThang.Items.Add(j.ToString());
        }
        for (int k = 1990; k <= DateTime.Now.Year; k++)
        {
            ddlNam.Items.Add(k.ToString());
        }
    }
}
