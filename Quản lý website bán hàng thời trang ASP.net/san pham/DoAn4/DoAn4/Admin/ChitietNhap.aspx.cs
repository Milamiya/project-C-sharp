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
using System.Data.SqlClient;

namespace DoAn4.Admin
{
    public partial class WebForm8 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
               
            if (Session["Username"] != null)
            { }
            else
            {
                Response.Redirect("Login.aspx");
            }
            string maHD = Request.QueryString.Get("Import_ID");
            Label7.Text = maHD;
            load();
            tinh();
        }
        void tinh()
        {
            Label1.Text = GridView1.Rows.Count.ToString();
            double tongsoluong = 0;
            double tongtiennhap = 0;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                tongsoluong += double.Parse(gr.Cells[3].Text);
                tongtiennhap += double.Parse(gr.Cells[4].Text);
            }
            Label2.Text = tongsoluong.ToString("###,###");
            Label3.Text = tongtiennhap.ToString("###,###") + "  " + "VNĐ";
        }
        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = from a in db.tbl_ImportDetails
                        where a.Import_ID == int.Parse(Label7.Text)
                        select a;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            //txtMahoadon.Text = "";
            txtSL.Text = "";
            txtThanhtien.Text = "";
            Label8.Text = "";
            Label4.Text = "";
            Label6.Text = "";
        }

        protected void txtSL_TextChanged(object sender, EventArgs e)
        {
            int thanhtien = int.Parse(DropDownList3.Text) * int.Parse(txtSL.Text);
            txtThanhtien.Text = thanhtien.ToString();
        }

        bool KTMaSP(string  ma)
        {
            var a = from s in db.tbl_ImportDetails
                    where s.Import_ID == int.Parse(Label7.Text)
                    select new { s.Product_ID};
            foreach (var item in a)
            {
                if (item.Product_ID == int.Parse(ma))
                    return false;
            }
            return true;
        }

        bool KTSoluong(string sl)
        {
            if (txtSL.Text == "")
            {
                return false;
            }
            return true;
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            if (KTMaSP(DropDownList2.Text) && KTSoluong(txtSL.Text))
            {
                if (KTSoluong(txtSL.Text))
                {
                    tbl_ImportDetail im = new tbl_ImportDetail();
                    im.Import_ID = int.Parse(Label7.Text);
                    im.Product_ID = int.Parse(DropDownList2.Text);
                    im.Price_Import = double.Parse(DropDownList3.Text);
                    im.Amount = int.Parse(txtSL.Text);
                    im.Money = double.Parse(txtThanhtien.Text);
                    db.tbl_ImportDetails.InsertOnSubmit(im);
                    tbl_Product t = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(DropDownList2.Text));
                    t.Amount = t.Amount + int.Parse(txtSL.Text);
                    db.SubmitChanges();
                    load();
                    //tbl_Product p = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(Label7.Text));
                    //p.Amount = p.Amount + im.Amount;
                    //+int.Parse(txtSL.Text);
                    //
                    //db.capnhatSL(int.Parse(Label7.Text), int.Parse(DropDownList2.Text)); 
                    //db.SubmitChanges();
                    Label6.Text = "Nhập thành công";
                    tinh();

                    //var a = from d in db.tbl_ImportDetails
                    //        where d.Product_ID == int.Parse(Label7.Text)
                    //        select d.Amount;
                    //tbl_Product p = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(Label7.Text));
                    //p.Amount = p.Amount + int.Parse(txtSL.Text);
                    //db.SubmitChanges();
                }
                else
                    Label8.Text = "Bạn chưa nhập số lượng.";
            }
            else
            {
                Label4.Text = "Sản phẩm này đã tồn tại.Bạn chỉ được sửa Số lượng.";
                txtThanhtien.Text = "";
                var a = from s in db.tbl_ImportDetails
                        where s.Import_ID == int.Parse(Label7.Text) && s.Product_ID == int.Parse(DropDownList2.Text)
                        select new{ s.Amount};
                foreach (var item in a)
                {
                    txtSL.Text = item.Amount.ToString(); 
                    Label8.Text = "Số lượng hiện có trong hoá đơn.";
                }
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (KTMaSP(DropDownList2.Text)==false)
            {
                tbl_ImportDetail im = db.tbl_ImportDetails.SingleOrDefault(c => c.Import_ID == int.Parse(Label7.Text) && c.Product_ID == int.Parse(DropDownList2.Text));
                im.Import_ID = int.Parse(Label7.Text);
                im.Product_ID = int.Parse(DropDownList2.Text);
                im.Price_Import = double.Parse(DropDownList3.Text);
                im.Amount = int.Parse(txtSL.Text);
                im.Money = double.Parse(txtThanhtien.Text);

                var a = from s in db.tbl_ImportDetails
                        where s.Import_ID == int.Parse(Label7.Text) && s.Product_ID == int.Parse(DropDownList2.Text)
                        select new { s.Amount };
                foreach (var item in a)
                {
                    tbl_Product t = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(DropDownList2.Text));
                    t.Amount = t.Amount - int.Parse(item.Amount.ToString()) + int.Parse(txtSL.Text);
                }            
                db.SubmitChanges();
                load();
                rong();
                Label6.Text = "Sửa thành công";
                Label4.Text = "";
                tinh();
            }
            else
            {
                Label6.Text = "Sản phẩm này không có trong hoá đơn.";
                txtThanhtien.Text = "";
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (KTMaSP(DropDownList2.Text) == false)
            {
                tbl_ImportDetail im = db.tbl_ImportDetails.SingleOrDefault(c => c.Import_ID == int.Parse(Label7.Text) && c.Product_ID == int.Parse(DropDownList2.Text));
                db.tbl_ImportDetails.DeleteOnSubmit(im);
                var a = from s in db.tbl_ImportDetails
                        where s.Import_ID == int.Parse(Label7.Text) && s.Product_ID == int.Parse(DropDownList2.Text)
                        select new { s.Amount };
                foreach (var item in a)
                {
                    txtSL.Text = item.Amount.ToString();
                    tbl_Product t = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse(DropDownList2.Text));
                    t.Amount = t.Amount - int.Parse(txtSL.Text);
                }               
                db.SubmitChanges();
                load();
                rong();
                Label6.Text = "Xoá thành công";
                tinh();
            }
            else
            {
                Label6.Text = "Sản phẩm này không có trong hoá đơn.";
            }
        }

        protected void DropDownList3_TextChanged(object sender, EventArgs e)
        {
            int thanhtien = int.Parse(DropDownList3.Text) * int.Parse(txtSL.Text);
            txtThanhtien.Text = thanhtien.ToString();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = from s in db.tbl_ImportDetails
                    where s.Import_ID == int.Parse(Label7.Text) && s.Product_ID == int.Parse(DropDownList2.Text)
                    select new { s.Amount };
            foreach (var item in a)
            {
                txtSL.Text = item.Amount.ToString();
            }
            Label4.Text = "";
            Label8.Text = "";
           // txtSL.Text = "";
            Label6.Text = "";
            txtThanhtien.Text = "";
        }

        protected void btntiep_Click(object sender, EventArgs e)
        {
            rong();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("ChitietNhap.aspx");
            DropDownList2.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMaSP");
            tbl_ImportDetail im = db.tbl_ImportDetails.SingleOrDefault(c => c.Product_ID == int.Parse(lblMa.Text));
           // txtMahoadon.Text = im.Import_ID.ToString();
            DropDownList2.Text = im.Product_ID.ToString();
            DropDownList3.Text = im.Price_Import.ToString();
            txtSL.Text = im.Amount.ToString();
            txtThanhtien.Text = im.Money.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.RowIndex].FindControl("lbMaSP");
            tbl_ImportDetail im = db.tbl_ImportDetails.SingleOrDefault(c => c.Product_ID == int.Parse(lblMa.Text));
            db.tbl_ImportDetails.DeleteOnSubmit(im);
            db.SubmitChanges();
            load();
        }
    }
}
