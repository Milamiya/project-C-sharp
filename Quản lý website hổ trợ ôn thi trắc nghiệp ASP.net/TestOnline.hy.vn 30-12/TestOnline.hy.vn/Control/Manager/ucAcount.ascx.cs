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

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucAcount : System.Web.UI.UserControl
    {
        static string acountID_ ="";
        /// <summary>
        /// Load dữ liệu lên gridview
        /// </summary>
        void LoadGridView()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            var cl = from c in db.tblAcounts
                     select c;
            grvManager.DataSource = cl;
            grvManager.DataBind();

        }
        /// <summary>
        /// Làm mới các điều khiển
        /// </summary>
        void Resfresh()
        {
            txtAcountID.Text = "";
            txtAddress.Text = "";
            ddlDay.SelectedIndex = 0;
            ddlMonth.SelectedIndex = 0;
            ddlYear.SelectedIndex = 0;
            txtFullName.Text = "";
            txtPass.Text = "";
            txtAcountID.ReadOnly = false;
        }
        void LoadComboboxBirthday()
        {
            ddlDay.Items.Add("-- Ngày --");
            for (int i =1; i <= 31; i++)
            {
                ddlDay.Items.Add(i.ToString());
            }
            ddlMonth.Items.Add("-- Tháng --");
            for (int i = 1; i <= 12; i++)
            {
                ddlMonth.Items.Add(i.ToString());
            }
            ddlYear.Items.Add("-- Year --");
            for (int i =DateTime.Now.Year-10; i >=DateTime.Now.Year-50; i--)
            {
                ddlYear.Items.Add(i.ToString());
            }
        }
        /// <summary>
        /// Kiểm tra mã tài khoản có trùng hay không
        /// </summary>
        bool TestCodeAcountID(string acountID)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblAcount tbl = db.tblAcounts.SingleOrDefault(c => c.AcountID.ToString().Trim().ToLower() == acountID.ToLower().Trim());
            if (tbl != null)
            {
                return true;
            }
            else return false;
 
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
                LoadComboboxBirthday();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Resfresh();
            lblThongBao.Text = "";
        }

        protected void btnCreateNews_Click(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (txtAcountID.Text == "" || txtAddress.Text == "" || txtFullName.Text == "" || txtPass.Text == "" || ddlDay.SelectedIndex == 0 || ddlMonth.SelectedIndex == 0 || ddlYear.SelectedIndex == 0)
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (TestCodeAcountID(txtAcountID.Text) == false)
                {
                    tblAcount tbl = new tblAcount();
                    tbl.AcountID = txtAcountID.Text;
                    tbl.Address = txtAddress.Text;
                    tbl.Brithday = ddlDay.Text + "/" + ddlMonth.Text + "/" + ddlYear.Text;
                    tbl.FullName = txtFullName.Text;
                    tbl.Pass = txtPass.Text;
                    db.tblAcounts.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                    lblThongBao.Text = "Bạn đã nhập thành công";
                    lblThongBao.Visible = true;
                    LoadGridView();
                }
            }

        }

        protected void btnEdit1_Click(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (txtAcountID.Text == "" || txtAddress.Text == "" || txtFullName.Text == "" || txtPass.Text == "" || ddlDay.SelectedIndex == 0 || ddlMonth.SelectedIndex == 0 || ddlYear.SelectedIndex == 0)
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {

                tblAcount tbl = db.tblAcounts.SingleOrDefault(c => c.AcountID.ToString().ToLower().Trim() == txtAcountID.Text.ToLower().Trim());
                if (tbl != null)
                {
                    tbl.AcountID = txtAcountID.Text;
                    tbl.Address = txtAddress.Text;
                    tbl.Brithday = ddlDay.Text + "/" + ddlMonth.Text + "/" + ddlYear.Text;
                    tbl.FullName = txtFullName.Text;
                    tbl.Pass = txtPass.Text;
                    db.SubmitChanges();
                    lblThongBao.Text = "Bạn đã sửa thành công";
                    lblThongBao.Visible = true;
                    LoadGridView();
                }
                
            }

        }

        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvManager.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null)
                {
                    if (chk.Checked)
                    {

                        LinkButton link = (LinkButton)row.FindControl("btnSua");
                        tblAcount at = db.tblAcounts.SingleOrDefault(c => c.AcountID.ToString() == link.CommandArgument.ToString());
                        if (at != null)
                        {
                            // delete file when xoa

                            db.tblAcounts.DeleteOnSubmit(at);
                            db.SubmitChanges();
                            record++;
                        }
                    }
                }
            }
            if (record > 0)
            {

                LoadGridView();
                // when will announciment

                lblThongBao.Text = "Bạn vừa xóa thành công " + record.ToString() + " bản ghi!";
                lblThongBao.Visible = true;

            }
            else
            {
                lblThongBao.Text = "Không có bản ghi nào được chọn !";
                lblThongBao.Visible = true;
            }
            btnEdit1.Enabled = false;
        }

        protected void grvManager_PageIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void grvManager_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageIndex = e.NewPageIndex;
            LoadGridView();
            grvManager.PageIndex = pageIndex;
            grvManager.DataBind();
        }

        protected void grvManager_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            acountID_ =e.CommandArgument.ToString();
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblAcount doc = db.tblAcounts.SingleOrDefault(d => d.AcountID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    db.tblAcounts.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGridView();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                    Resfresh();
                }

            }
            // Chọn hàng muốn sửa
            if (e.CommandName == "Edit")
            {
                tblAcount doc = db.tblAcounts.SingleOrDefault(d => d.AcountID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    txtAcountID.Text = doc.AcountID;
                    txtAddress.Text = doc.Address;
                    txtFullName.Text = doc.FullName;
                    txtPass.Text = doc.Pass;
                    string []mang = doc.Brithday.Split('/');
                    ddlDay.Text = mang[0];
                    ddlMonth.Text = mang[1];
                    ddlYear.Text = mang[2];
                    txtAcountID.ReadOnly = true;
                    btnCreate.Enabled = false;
                    btnEdit1.Enabled = true;
                    lblThongBao.Text = "";
                }
            }

          
        }

        protected void grvManager_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void grvManager_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvManager.ClientID + "')");

            }

        }

        protected void grvManager_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGridView();

        }

      

        protected void grvManager_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LoadGridView();
        }
    }
}