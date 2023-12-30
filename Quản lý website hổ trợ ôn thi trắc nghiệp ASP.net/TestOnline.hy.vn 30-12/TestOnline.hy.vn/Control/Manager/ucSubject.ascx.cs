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
    public partial class ucSubject : System.Web.UI.UserControl
    {
        /// <summary>
        /// Load dữ liệu lên gridview
        /// </summary>
        void LoadGrid()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            var cl = from c in db.tblSubjects
                     orderby c.SubjectID descending
                     select c;
            grvSubject.DataSource = cl;
            grvSubject.DataBind();
        }
        /// <summary>
        /// Kiểm tra trùng mã
        /// </summary>
        bool TestCode(string code)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblSubject tbl = db.tblSubjects.SingleOrDefault(c => c.SubjectID.Trim() == txtSubjectCode.Text.Trim());
            if (tbl != null) return true;
            else
                return false;
        }
        /// <summary>
        /// Kiểm tra trùng tên
        /// </summary>
        bool TestName(string name)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblSubject tbl = db.tblSubjects.SingleOrDefault(c => c.SubjectName.ToLower().Trim() == txtSubjectName.Text.ToLower().Trim());
            if (tbl != null) return true;
            else
                return false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadGrid();
                
            }

        }
        /// <summary>
        /// Thêm môn mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreateNews_Click(object sender, EventArgs e)
        {
            if (txtSubjectCode.Text == "" || txtSubjectName.Text == "")
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (TestCode(txtSubjectCode.Text) == false)
                {
                    if (TestName(txtSubjectName.Text) == false)
                    {
                        TestOnlineDataContext db = new TestOnlineDataContext();
                        tblSubject tbl = new tblSubject();
                        tbl.SubjectID = txtSubjectCode.Text;
                        tbl.SubjectName = txtSubjectName.Text;
                        db.tblSubjects.InsertOnSubmit(tbl);
                        db.SubmitChanges();
                        LoadGrid();
                    }
                    else
                    {
                        lblThongBao.Text = "Tồn tại tên môn học";
                        lblThongBao.Visible = true;
                    }
                }
                else
                {
                    lblThongBao.Text = "Tồn tại mã môn học";
                    lblThongBao.Visible = true;
                }
            }
        }

        protected void grvSubject_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblSubject doc = db.tblSubjects.SingleOrDefault(d => d.SubjectID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {

                    db.tblSubjects.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                }
            }
        }

        protected void grvSubject_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGrid();

        }
    }
}