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
using System.IO;

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucRegulation : System.Web.UI.UserControl
    {
        tool cls = new tool();
        static int regulationID = 0;
        TestOnlineDataContext db = new TestOnlineDataContext();
        /// <summary>
        /// Load dữ liệu lên combobox năm học
        /// </summary>
        void LoadYear()
        {
            int year = DateTime.Now.Year;
            ddlYear.Items.Add("-- Chọn năm --");
            ddlYear.Items.Add(year+ " - " + (year + 1));
            ddlYear.Items.Add((year-1) + " - " +year);
            ddlYear.Items.Add((year-2) + " - " + (year -1));
            ddlYear.Items.Add((year-3) + " - " + (year -2 ));
            ddlYear.Items.Add((year-4) + " - " + (year -3));
            ddlYear.SelectedIndex = 0;
        }
        /// <summary>
        /// Làm mới các điều khiển
        /// </summary>
        void Refresh()
        {
            ddlYear.SelectedIndex = 0;
            txtTitle.Text = "";
            btnCreateNews.Enabled = true;
            btnEdit1.Enabled = false;
            ddlYear.Enabled = true;
            txtCreateDate.Text = DateTime.Now.ToShortDateString();

        }
        /// <summary>
        /// Load dữ liệu lên gridview
        /// </summary>
        void LoadGridView()
        {
            var cl = from c in db.tblRegulations
                     select c;
            grvRagulation.DataSource = cl;
            grvRagulation.DataBind();
        }
        /// <summary>
        /// Kiểm tra năm đã trùng hay chưa
        /// </summary>
        /// <returns></returns>
        bool TestYear()
        { 
            TestOnlineDataContext db=new TestOnlineDataContext();
            tblRegulation tbl = db.tblRegulations.SingleOrDefault(c => c.Year.Trim() == ddlYear.Text.Trim());
            if (tbl != null) return true;
            else return false;
        }
        /// <summary>
        /// Uploads the file.
        /// </summary>
        /// <param name="fUpload">The upload control .</param>
        /// <param name="fPath">The path string.</param>
        public string UploadFile(FileUpload fUpload)
        {
            string fPath = String.Empty;
            try
            {
                fPath = HttpContext.Current.Server.MapPath(@"\FileUpload\Regulation\" + fUpload.FileName);
                FileInfo fInfo = new FileInfo(fPath);
                if (fInfo.Exists)
                {
                    fInfo.Delete();
                }
                fUpload.SaveAs(fPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return fPath;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { LoadGridView();
            LoadYear();
            Refresh();
            txtCreateDate.Text = DateTime.Now.Date.ToShortDateString();
            txtCreateDate.ReadOnly = true;
            }

        }
        /// <summary>
        /// Làm mới các điều khiển
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        /// <summary>
        /// Thêm 1 bản ghi mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreateNews_Click(object sender, EventArgs e)
        {
            if (ddlYear.SelectedIndex == 0 || txtTitle.Text == "")
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (fulFile.HasFile)
                {
                    if (TestYear() == false)
                    {
                        TestOnlineDataContext db = new TestOnlineDataContext();
                        tblRegulation doc = new tblRegulation();
                        UploadFile(fulFile);
                        doc.Year = ddlYear.Text;
                        doc.Titile = txtTitle.Text;
                        doc.Url = @"FileUpload/Regulation/" + fulFile.FileName;
                        doc.CreateDate = DateTime.Now;
                        db.tblRegulations.InsertOnSubmit(doc);
                        db.SubmitChanges();
                        //Refresh Data
                        LoadGridView();
                        //Thong bao
                        lblThongBao.Visible = true;
                        lblThongBao.Text = "Bạn đã thêm thành công";
                    }
                    else
                    {
                        lblThongBao.Visible = true;
                        lblThongBao.Text = "Đã tồn tại quy chế của năm này";

                    }
                }
                else
                {
                    lblThongBao.Text = "Bạn phải chọn file đính kèm";
                    lblThongBao.Visible = true;
                }
            }
        }
        /// <summary>
        /// Sửa bản ghi đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit1_Click(object sender, EventArgs e)
        {
            if (ddlYear.SelectedIndex == 0 || txtTitle.Text == "")
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (fulFile.HasFile)
                {
                    
                        TestOnlineDataContext db = new TestOnlineDataContext();
                        tblRegulation doc = db.tblRegulations.SingleOrDefault(c => c.Year.Trim() == ddlYear.Text.Trim());
                        UploadFile(fulFile);
                        doc.Year = ddlYear.Text;
                        doc.Titile = txtTitle.Text;
                        doc.Url = @"FileUpload/Regulation/" + fulFile.FileName;
                        //
                        doc.CreateDate = DateTime.Parse(txtCreateDate.Text);
                        db.SubmitChanges();
                        //Refresh Data
                        LoadGridView();
                        //Thong bao
                        lblThongBao.Visible = true;
                        lblThongBao.Text = "Bạn đã sửa thành công";
                    
                }
                else
                {
                    lblThongBao.Text = "Bạn phải chọn file đính kèm";
                    lblThongBao.Visible = true;
                }
            }
        }
        /// <summary>
        /// Xóa nhiều bản ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvRagulation.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null)
                {
                    if (chk.Checked)
                    {
                        LinkButton linkDocument = (LinkButton)row.FindControl("btnSua");
                        tblRegulation at = db.tblRegulations.SingleOrDefault(c => c.RegulationID.ToString() == linkDocument.CommandArgument.ToString());
                        if (at != null)
                        {

                            // delete file when xoa

                            db.tblRegulations.DeleteOnSubmit(at);
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
            btnEdit1.Enabled = false;
        }

        protected void grvRagulation_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int page = e.NewPageIndex;
            LoadGridView();
            grvRagulation.PageIndex = page;
            grvRagulation.DataBind();

        }

        protected void grvRagulation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            regulationID = int.Parse(e.CommandArgument.ToString());
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblRegulation doc = db.tblRegulations.SingleOrDefault(d => d.RegulationID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {

                    db.tblRegulations.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGridView();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                    Refresh();
                }
            }
            // Chọn hàng muốn sửa
            if (e.CommandName == "Edit")
            {
                tblRegulation menu = db.tblRegulations.SingleOrDefault(d => d.RegulationID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (menu != null)
                {

                    ddlYear.Text = menu.Year.Trim();
                    txtTitle.Text = menu.Titile;
                    txtCreateDate.Text = menu.CreateDate.ToShortDateString();
                    btnCreateNews.Enabled = false;
                    btnEdit1.Enabled = true;
                    ddlYear.Enabled = true;
                    lblThongBao.Text = "";
                    ddlYear.Enabled = false;
                }
            }
        }
        protected void grvRagulation_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }

        }

        protected void grvRagulation_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvRagulation.ClientID + "')");

            }
        }

        protected void grvRagulation_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGridView();
        }

        protected void grvRagulation_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LoadGridView();
        }
    }
}