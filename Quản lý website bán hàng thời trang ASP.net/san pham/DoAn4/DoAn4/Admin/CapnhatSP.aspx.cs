using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.IO;

namespace DoAn4.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
            if (Session["Username"] != null)
            { }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = from a in db.tbl_Products
                        select new {a.Product_ID,a.Product_Name,a.Type_ID,a.Style_ID,a.Supplier_ID,a.Producer_ID,a.Image,a.Price_Import,a.Price_Export };
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txtTenSP.Text = "";
            txtMau.Text = "";
            txtKichthuoc.Text = "";
            txtChatlieu.Text = "";
            txtGianhap.Text = "";
            txtGiaxuat.Text = "";
            txtTrongluong.Text = "";
        }

        bool KTtontai(string ten, string loaisp, string pc, string ncc, string hsx, string mau, string kc, string cl, string gianhap, string gx, string trl)
        {
            var a = from s in db.tbl_Products
                    select new { s.Product_Name, s.Type_ID, s.Style_ID, s.Supplier_ID, s.Producer_ID, s.Image, s.Color, s.Material, s.Size, s.Price_Import, s.Price_Export, s.Weight };
            foreach (var item in a)
            {
                if (item.Product_Name == ten && item.Type_ID == int.Parse(loaisp) && item.Style_ID == int.Parse(pc) && item.Supplier_ID == int.Parse(ncc) && item.Producer_ID == int.Parse(hsx) && item.Color == mau && item.Material == cl && item.Size == kc && item.Price_Import == double.Parse(gianhap) && item.Price_Export == double.Parse(gx) && item.Weight == double.Parse(trl))
                    return false;
            }
            return true;
        }

        bool KTrong(string tensp, string gianhap,string giaxuat)
        {
            if (tensp == "" || gianhap == "" || giaxuat == "")
            {
                return false;
            }
            return true;
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            if (KTrong(txtTenSP.Text, txtGianhap.Text, txtGiaxuat.Text))
            {
                string anh = "";
                if (FileUpload1.HasFile)
                {
                    anh = FileUpload1.FileName.Replace(" ", "_");
                    FileUpload1.SaveAs(Server.MapPath("..//AnhSanPham") + anh);
                }
                tbl_Product p = new tbl_Product();
                p.Product_Name = txtTenSP.Text;
                p.Type_ID = int.Parse(drLoaiSP.SelectedValue);
                p.Style_ID = int.Parse(drPhongcach.SelectedValue);
                p.Supplier_ID = int.Parse(drNhacungcap.SelectedValue);
                p.Producer_ID = int.Parse(drNhacungcap.SelectedValue);
                p.Image = anh;
                p.Color = txtMau.Text;
                p.Material = txtChatlieu.Text;
                p.Size = txtKichthuoc.Text;
                p.Price_Import = double.Parse(txtGianhap.Text);
                p.Price_Export = int.Parse(txtGiaxuat.Text);
                p.Amount = 0;
                p.Weight = int.Parse(txtTrongluong.Text);
                db.tbl_Products.InsertOnSubmit(p);
                db.SubmitChanges();
                load();
                rong();
                Label2.Text = "Nhập thành công.";
                txtTenSP.Focus();
            }
            else
            {
                Label2.Text = "Chưa nhập đủ thông tin.";
                Label6.Text = "";
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                Label6.Text = "Bạn chưa chọn sản phẩm.";
                Label2.Text = "";
            }
            else
            {
                tbl_Product p = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(txtMa.Text));
                p.Product_Name = txtTenSP.Text.ToString();
                p.Type_ID = int.Parse(drLoaiSP.Text.ToString());
                p.Style_ID = int.Parse(drPhongcach.Text.ToString());
                p.Supplier_ID = int.Parse(drNhacungcap.Text.ToString());
                p.Producer_ID = int.Parse(drHangsanxuat.Text.ToString());
                string anh = "";
                if (FileUpload1.HasFile)
                {
                    anh = FileUpload1.FileName.Replace(" ", "_");
                    FileUpload1.SaveAs(Server.MapPath("..//AnhSanPham") + anh);
                }
                p.Image = anh;
                p.Color = txtMau.Text.ToString();
                p.Material = txtChatlieu.Text.ToString();
                p.Size = txtKichthuoc.Text.ToString();
                p.Price_Import = double.Parse( txtGianhap.Text);
                p.Price_Export = int.Parse(txtGiaxuat.Text.ToString());
                p.Weight = int.Parse(txtTrongluong.Text.ToString());
                db.SubmitChanges();
                load();
                Label2.Text = "Sửa thành công.";
                Label6.Text = "";
                rong();
                txtTenSP.Focus();
            }
        }

        bool KTMaSP(string ma)
        {
            var a = from s in db.tbl_ImportDetails
                    where s.Product_ID == int.Parse(txtMa.Text)
                    select new { s.Product_ID };
            foreach (var item in a)
            {
                if (item.Product_ID == int.Parse(ma))
                    return false;
            }
            return true;
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                Label6.Text = "Bạn chưa chọn sản phẩm.";
            }
            else
            {
                if (KTMaSP(txtMa.Text))
                {                  
                    tbl_Product p = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(txtMa.Text));
                    db.tbl_Products.DeleteOnSubmit(p);
                    db.SubmitChanges();
                    load();
                    Label2.Text = "Xoá thành công.";
                    rong();
                    txtTenSP.Focus();
                }
                else
                {
                    Label2.Text = "Không thể xoá sản phẩm.";
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            load();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatSP.aspx");
            txtTenSP.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label2.Text = "Bạn chọn lại hình ảnh";
            Label lbMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Product p = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(lbMa.Text));
            txtMa.Text = p.Product_ID.ToString();
            txtTenSP.Text = p.Product_Name.ToString();
            drLoaiSP.Text = p.Type_ID.ToString();
            drPhongcach.Text = p.Style_ID.ToString();
            drNhacungcap.Text = p.Supplier_ID.ToString();
            drHangsanxuat.Text = p.Producer_ID.ToString();
           // FileUpload1.PostedFile = p.Image.ToString();
            txtMau.Text = p.Color.ToString();
            txtChatlieu.Text = p.Material.ToString();
            txtKichthuoc.Text = p.Size.ToString();
            txtGianhap.Text = p.Price_Import.ToString();
            txtGiaxuat.Text = p.Price_Export.ToString();
            txtTrongluong.Text = p.Weight.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
            Label6.Text = "";
        }
    }
}
