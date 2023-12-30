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

public partial class GiaoDien_ThemmoiSP : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    clsThaoTac cls = new clsThaoTac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cls.LoadLoaiSP(ddlLoaiSP);
            cls.LoadHangSX(ddlTenHSX);

            LoadSize();
            LoadTime();
        }
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
        for (int k = 1990; k<= DateTime.Now.Year; k++)
        {
            ddlNam.Items.Add(k.ToString());
        }
    }
    void LoadSize()
    {
        string chuoi ="X,M,L,XL,S,25,26,27,28,29";
        string[] a = chuoi.Split(',');

        for (int i = 0; i < a.Length; i++)
        {
            ddlSize.Items.Add(a[i]);
        }
        
    }
    DateTime ChuyenDoiNgay()
    
    {
        DateTime dt;
        int ngay = int.Parse(ddlNgay.SelectedItem.Text.ToString());
        int thang = int.Parse(ddlThang.SelectedItem.Text.ToString());
        int nam = int.Parse(ddlNam.SelectedItem.Text.ToString());
        dt = new DateTime(nam,thang,ngay);
        return dt;
    }
    void ThemSP()
    {
        Product pr = new Product();
        pr.ProductID = txtMaSP.Text;
        pr.Size = ddlSize.SelectedItem.Text.ToString();
        int TT = 0;
        if (ckHienThi.Checked == true)
        {
            TT = 1;
        }
        else TT = 0;
        pr.Status = TT;
        pr.ProductName = txtTenSP.Text;
        pr.Price = int.Parse(txtGiaBan.Text);
        pr.Images = fuSP.PostedFile.FileName;
        pr.Color = txtMau.Text;
        pr.Date = ChuyenDoiNgay();
        pr.Number = int.Parse(txtSoLuong.Text);
        //pr.ManufactureID = 2;
        //pr.ProductGroupID = 16;
        pr.ManufactureID = int.Parse(ddlTenHSX.SelectedItem.Value.ToString());
        pr.ProductGroupID = int.Parse(ddlLoaiSP.SelectedItem.Value.ToString());
        db.Products.InsertOnSubmit(pr);
        db.SubmitChanges();
    }
    void Xoa()
    {
        txtTenSP.Text = "";
        txtMaSP.Text = "";
        txtGiaBan.Text = "";
        txtMau.Text = "";
        txtMoTa.Text = "";
        txtSoLuong.Text = "";
        
       
    }
    protected void btThemSP_Click(object sender, EventArgs e)
    {
       
            ThemSP();
        
    }
    protected void ddlLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(ddlLoaiSP.SelectedValue.ToString());
        Response.Redirect("ThemmoiSP.aspx");
    }
}
