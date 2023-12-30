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
using ex = Microsoft.Office.Interop.Excel;

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucQuestion : System.Web.UI.UserControl
    {
        TestOnlineDataContext db = new TestOnlineDataContext();
        static int questionID = 0;
        /// <summary>
        /// Làm mới các điều khiển
        /// </summary>
        void Refres()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtContent.Text = "";
            txtD.Text = "";
            ddlSubject.SelectedIndex = 0;
            ddlLevel.SelectedIndex = 0;
            ddlAnswer.SelectedIndex = 0;
            btnCreate.Enabled = true;
            btnEdit1.Enabled = false;
            ddlSubject.SelectedIndex = ddlSubject.Items.Count - 1;
        }
        /// <summary>
        /// Load dữ liệu lên gridviewd
        /// </summary>
        void LoadGrid()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            var cl = from c in db.tblQuestions
                     orderby c.QuestionsID descending
                     where c.SubjectID.Trim().ToString() == ddlSubject.SelectedValue.Trim().ToString()
                     select new { c.QuestionsID, c.tblSubject.SubjectName, c.Answer, c.ChocieA, c.ChocieB, c.ChocieC, c.ChocieD, c.Content, c.Level };
            grvQuestion.DataSource = cl;
            grvQuestion.DataBind();
        }
        /// <summary>
        /// Load dữ liệu lên combobox subject
        /// </summary>
        void LoadSubject()
        {

            TestOnlineDataContext db = new TestOnlineDataContext();
            ddlSubject.DataSource = db.tblSubjects;
            ddlSubject.DataBind();
            ddlSubject.Items.Add("-- Chọn môn học --");
            ddlSubject.SelectedIndex =ddlSubject.Items.Count - 1;
        }
        /// <summary>
        /// Load lên những đáp án A,B,C,D
        /// </summary>
        void LoadAnswer()
        {
            ddlAnswer.Items.Add("-- Chọn đáp án --");
            ddlAnswer.Items.Add("A");
            ddlAnswer.Items.Add("B");
            ddlAnswer.Items.Add("C");
            ddlAnswer.Items.Add("D");
            ddlAnswer.SelectedIndex = 0;
        }
        /// <summary>
        /// Load lên mức độ
        /// </summary>
        void LoadLevel()
        {
            ddlLevel.Items.Add("-- Chọn mức độ --");

            ddlLevel.Items.Add("1");
            ddlLevel.Items.Add("2");
            ddlLevel.Items.Add("3");
            ddlLevel.SelectedIndex = 0;

        }
        /// <summary>
        /// Kiểm tra xem mã môn học có tồn tại không
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool TestCodeSubject(string code)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblSubject tbl = db.tblSubjects.SingleOrDefault(c => c.SubjectID.Trim().ToLower() == code.Trim().ToLower());
            if (tbl != null)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Kiểm tra xem câu hỏi này đã tồn tại chưa
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool TestQuestionCode(string code)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblQuestion tbl = db.tblQuestions.SingleOrDefault(c => c.Content.Trim().ToLower() == txtContent.Text.Trim().ToLower());
            if (tbl != null)
            {
                return true;
            }
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
                fPath = HttpContext.Current.Server.MapPath(@"\FileUpload\Question\" + fUpload.FileName);
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
            {
               
                LoadSubject();
                LoadAnswer();
                LoadLevel();
                LoadGrid();
            }
        }
        protected void btnCreateNews_Click(object sender, EventArgs e)
        {
            if (txtD.Text == "" || txtContent.Text == "" || txtC.Text == "" || txtB.Text == "" || txtA.Text == "" || ddlAnswer.SelectedIndex == 0 || ddlLevel.SelectedIndex == 0 || ddlSubject.SelectedIndex==(ddlSubject.Items.Count-1))
            {
                lblThongBao.Text = "Bạn chưa nhập đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (TestQuestionCode(txtContent.Text) == false)
                {
                    tblQuestion tbl = new tblQuestion();
                    tbl.Content = txtContent.Text;
                    tbl.ChocieA = txtA.Text;
                    tbl.ChocieB = txtB.Text;
                    tbl.ChocieC = txtC.Text;
                    tbl.ChocieD = txtD.Text;
                    if (ddlAnswer.SelectedIndex == 1)
                    {
                        tbl.Answer = txtA.Text;
                    }
                    if (ddlAnswer.SelectedIndex == 2)
                    {
                        tbl.Answer = txtB.Text;
                    }
                    if (ddlAnswer.SelectedIndex == 3)
                    { tbl.Answer = txtC.Text; }
                    if (ddlAnswer.SelectedIndex == 4)
                    { tbl.Answer = txtD.Text; }
                    tbl.SubjectID = ddlSubject.SelectedValue.Trim().ToString();
                    tbl.Level = int.Parse(ddlLevel.Text);
                    db.tblQuestions.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Text = "Bạn đã nhập thành công";
                    lblThongBao.Visible = true;
                }
                else
                { lblThongBao.Text = "Câu hỏi này đã tồn tại"; }

            }

        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Refres();
            lblThongBao.Text = "";
        }

        protected void btnEdit1_Click(object sender, EventArgs e)
        {
            if ( txtD.Text == "" || txtContent.Text == "" || txtC.Text == "" || txtB.Text == "" || txtA.Text == "" || ddlAnswer.SelectedIndex == 0 || ddlLevel.SelectedIndex == 0 || ddlSubject.Text.Trim() == "")
            {
                lblThongBao.Text = "Bạn chưa nhập đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                tblQuestion tbl = db.tblQuestions.SingleOrDefault(c => c.QuestionsID == questionID);
                if (tbl != null)
                {
                    tbl.Content = txtContent.Text;
                    tbl.ChocieA = txtA.Text;
                    tbl.ChocieB = txtB.Text;
                    tbl.ChocieC = txtC.Text;
                    tbl.ChocieD = txtD.Text;
                    if (ddlAnswer.SelectedIndex == 1)
                    {
                        tbl.Answer = txtA.Text;
                    }
                    if (ddlAnswer.SelectedIndex == 2)
                    {
                        tbl.Answer = txtB.Text;
                    }
                    if (ddlAnswer.SelectedIndex == 3)
                    { tbl.Answer = txtC.Text; }
                    if (ddlAnswer.SelectedIndex == 4)
                    { tbl.Answer = txtD.Text; }
                    tbl.SubjectID = ddlSubject.SelectedValue.Trim().ToString();
                    tbl.Level = int.Parse(ddlLevel.Text.Trim());
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Text = "Bạn sửa  thành công";
                    lblThongBao.Visible = true;
                    btnEdit1.Enabled = true;
                    btnCreate.Enabled = false;
                 
                }

            }
        }
        /// <summary>
        /// Xóa nhiều hàng theo lựa chọn trên gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvQuestion.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null)
                {
                    if (chk.Checked)
                    {

                        LinkButton link = (LinkButton)row.FindControl("btnSua");
                        tblQuestion at = db.tblQuestions.SingleOrDefault(c => c.QuestionsID.ToString() == link.CommandArgument.ToString());
                        if (at != null)
                        {
                            // delete file when xoa

                            db.tblQuestions.DeleteOnSubmit(at);
                            db.SubmitChanges();
                            record++;
                        }
                    }
                }
            }
            if (record > 0)
            {

                LoadGrid();
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
        /// <summary>
        /// Sự kiện phân trang trong gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grvQuestion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageIndex = e.NewPageIndex;
            LoadGrid();
            grvQuestion.PageIndex = pageIndex;
            grvQuestion.DataBind();
        }

        protected void grvQuestion_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            questionID = int.Parse(e.CommandArgument.ToString());
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblQuestion doc = db.tblQuestions.SingleOrDefault(d => d.QuestionsID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    db.tblQuestions.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                    Refres();
                }

            }
            // Chọn hàng muốn sửa
            if (e.CommandName == "Edit")
            {
                tblQuestion doc = db.tblQuestions.SingleOrDefault(d => d.QuestionsID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    txtContent.Text = doc.Content;
                    txtA.Text = doc.ChocieA;
                    txtB.Text = doc.ChocieB;
                    txtC.Text = doc.ChocieC;
                    txtD.Text = doc.ChocieD;
                    ddlSubject.SelectedValue = doc.SubjectID;
                    ddlLevel.Text = doc.Level.ToString();
                    if (doc.ChocieA.Trim().ToLower() == doc.Answer.Trim().ToLower())
                    {
                        ddlAnswer.Text = "A";
                    }
                    if (doc.ChocieB.Trim().ToLower() == doc.Answer.Trim().ToLower())
                    {
                        ddlAnswer.Text = "B";
                    }
                    if (doc.ChocieC.Trim().ToLower() == doc.Answer.Trim().ToLower())
                    {
                        ddlAnswer.Text = "C";
                    }
                    if (doc.ChocieD.Trim().ToLower() == doc.Answer.Trim().ToLower())
                    {
                        ddlAnswer.Text = "D";
                    }
                    btnCreate.Enabled = false;
                    btnEdit1.Enabled = true;
                    lblThongBao.Text = "";
                }
            }
        }
        protected void grvQuestion_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void grvQuestion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvQuestion.ClientID + "')");

            }
        }

        protected void grvQuestion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGrid();
        }

        protected void grvQuestion_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LoadGrid();
        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        /// <summary>
        /// Nhập dữ liệu bằng excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLuu_Click(object sender, EventArgs e)
        {
            if (fulFile.HasFile)
            {
                UploadFile(fulFile);
                #region lấy dữ liệu từ excel vào Gridview
                // OpenFileDialog openFi = new OpenFileDialog();
                // fulFile.filt.Filter = "Kiểu file: (*.xls)|*.xls";
                ex.Application excelObj = new Microsoft.Office.Interop.Excel.Application();
                // if (openFi.ShowDialog() == DialogResult.OK)
                // {
                ex.Workbook myWorkBook = excelObj.Workbooks.Open(Server.MapPath(@"/FileUpload/Question/" + fulFile.FileName), 0, true, 5, "", "", true, ex.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0);
                ex.Sheets sheets = myWorkBook.Worksheets;
                ex.Worksheet worksheet = (ex.Worksheet)sheets.get_Item(1);
                object rowIndex = 7;
                int index = 0;
                int count = 7;
                while (((ex.Range)worksheet.Cells[rowIndex, 2]).Value2 != null)
                {
                    if (Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 1]).Value2) != null && ((Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 3]).Value2) != null)))
                    {
                        string subjectCode = Convert.ToString(((ex.Range)worksheet.Cells[2, 2]).Value2);
                        string content = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 2]).Value2);
                        string daA = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 3]).Value2);
                        string daB = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 4]).Value2);
                        string daC = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 5]).Value2);
                        string daD = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 6]).Value2);
                        string answer = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 7]).Value2);
                        string level = Convert.ToString(((ex.Range)worksheet.Cells[rowIndex, 8]).Value2);
                        if (TestCodeSubject(subjectCode) == true)
                        {
                            if (TestQuestionCode(content) == false)
                            {
                                tblQuestion tbl = new tblQuestion();
                                tbl.Content = content;
                                tbl.ChocieA = daA;
                                tbl.ChocieB = daB;
                                tbl.ChocieC = daC;
                                tbl.ChocieD = daD;
                                if (answer.Trim().ToLower() == "a")
                                {
                                    tbl.Answer = daA;
                                }
                                if (answer.Trim().ToLower() == "b")
                                {
                                    tbl.Answer = daB;
                                }
                                if (answer.Trim().ToLower() == "c")
                                {
                                    tbl.Answer = daC;
                                }
                                if (answer.Trim().ToLower() == "d")
                                {
                                    tbl.Answer = daD;
                                }
                                tbl.SubjectID = subjectCode;
                                tbl.Level = int.Parse(level);
                                db.tblQuestions.InsertOnSubmit(tbl);
                                db.SubmitChanges();
                             
                            }
                            lblThongBao.Text = "Imput thành công";
                            lblThongBao.Visible = true;
                        }
                        else
                        {
                            lblThongBao.Text = "Không tồn tại mã môn học nhập từ file excel";
                            lblThongBao.Visible = true; break;
                        }
                        index++;
                    }
                    rowIndex = ++count;

                }
                LoadGrid();
                #endregion
            }
            else
            {
                lblThongBao.Text = "Chưa chọn file câu hỏi";
                lblThongBao.Visible = true;
            }
        }
    }
}