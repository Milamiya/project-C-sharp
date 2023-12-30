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
using System.Data.SqlClient;
public partial class hello_Default2 : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["ProductID"].ToString();
        DataTable dt= cls.LoadDuLieuPKN("select * from tbProduct where ProductID='"+id+"'");
        foreach (DataRow dr in dt.Rows)
        {
            txtTenSP.Text = dr[1].ToString();
            Image1.ImageUrl = "~/"+ dr[2].ToString();                        
            txtKhuyenMai.Text = dr[3].ToString();
            txtGia.Text = dr[4].ToString();
            txtSL.Text = dr[5].ToString();
            txtNSX.Text = dr[6].ToString();
            txtBVSL.Text = dr[7].ToString();
            txtRam.Text = dr[8].ToString();
            txtOcung.Text = dr[9].ToString();
            txtHDH.Text = dr[10].ToString();
            txtManHinh.Text = dr[11].ToString();
            txtCamera.Text = dr[12].ToString();
            txtCard.Text = dr[13].ToString();
            txtPin.Text = dr[14].ToString();
            txtKhoiLuong.Text = dr[15].ToString();
            txtXuatSu.Text = dr[16].ToString();
            txtBaoHanh.Text = dr[17].ToString();
            txtNgayNhap.Text = dr[18].ToString();
        }       
    }
    protected void btLuu_Click(object sender, EventArgs e)
    {

    }
}
