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
    public partial class ThreadQuestionUniversity : System.Web.UI.UserControl
    {
        TestOnlineDataContext db = new TestOnlineDataContext();
        tool cls = new tool();
        static string threadID = "";
        /// <summary>
        /// Làm mới các điều khiển
        /// </summary>
        void Refresh()
        {
            txtMaxScores.Text = "";

            txtThreadID.Text = "";
            txtThreadName.Text = "";

            ddlSubject.SelectedIndex = ddlSubject.Items.Count - 1;
            btnCreate.Enabled = true;
            btnEdit1.Enabled = false;
            txtThreadID.ReadOnly = false; txtCreateDate.ReadOnly = true;
            txtCreateDate.Text = DateTime.Now.ToShortDateString();

            txtThreadID.ReadOnly = true;
            txtThreadID.Text = sinhmatudong();
            txtThreadID.ReadOnly = true;
        }
        //load ma mon tu bang subject
        void LoadSubject()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            ddlSubject.DataSource = db.tblSubjects;
            ddlSubject.DataBind();
            ddlSubject.Items.Add("-- Chọn môn thi -- ");
            ddlSubject.SelectedIndex = ddlSubject.Items.Count - 1;
        }
        /// <summary>
        /// Load dữ liệu lên gridview
        /// </summary>
        void LoadGrid()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            var cl = from c in db.tblThreads
                     orderby c.ThreadsID descending
                     where c.Status == 4
                     select new { c.SubjectID, c.ThreadsID, c.TheadName, c.tblSubject.SubjectName, c.MaxScores, c.CreateDate };
            if (ddlSubject.SelectedIndex != ddlSubject.Items.Count - 1)
            {
                cl = from c in cl
                     orderby c.ThreadsID descending
                     where c.SubjectID.Trim() == ddlSubject.SelectedValue.ToString().Trim()
                     select new { c.SubjectID, c.ThreadsID, c.TheadName, c.SubjectName, c.MaxScores, c.CreateDate };

            }
            grvThreadUniversity.DataSource = cl;
            grvThreadUniversity.DataBind();
        }
        /// <summary>
        /// Kiểm tra trùng đề đi
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool TestCode(string code)
        {
            tblThread tbl = db.tblThreads.SingleOrDefault(c => c.ThreadsID.Trim().ToLower() == code.Trim().ToLower());
            if (tbl != null)
                return true;
            else return false;
        }
        /// <summary>
        /// Thêm đề mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string sinhmatudong()
        {
            string ma = "";
            string matmp = "";
            int tam = 0;

            string kh = "D";
            int kt = 0;
            //dc = new DataClasses1DataContext();
            var a = from c in db.tblThreads select new { c.ThreadsID };
            foreach (var im in a)
            {
                kt++;
            }
            if (kt == 0)
            {
                ma = kh + "001";

            }
            else
            {

                foreach (var item in a)
                {
                    matmp = item.ThreadsID.ToString().Trim();
                    matmp = matmp.Remove(0, 1);
                    do
                    {
                        if (matmp[0].ToString() == "0")
                        {
                            matmp = matmp.Remove(0, 1);

                        }
                        if (matmp[0].ToString().Trim() != "0")
                        {
                            if (tam <= int.Parse(matmp))
                            {
                                tam = int.Parse(matmp);
                            }
                        }
                    }
                    while (matmp[0].ToString() == "0");
                }
                tam = tam + 1;
                ma = kh + "000".Remove(3 - tam.ToString().Length) + tam.ToString();
            }
            return ma;
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
            tblQuestion tbl = db.tblQuestions.SingleOrDefault(c => c.Content.Trim().ToLower() == code.ToLower());
            if (tbl != null)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Kiểm tra câu hỏi đã có trong đề này chưa
        /// </summary>
        /// <param name="threadID"></param>
        /// <param name="questionID"></param>
        /// <returns></returns>
        bool TestCodeThreadQuestion(string threadID, string questionID)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblThreadQuestion tbl = db.tblThreadQuestions.SingleOrDefault(c => c.ThreadsID == threadID && c.QuestionsID.ToString() == questionID);
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
                LoadSubject();
                txtCreateDate.ReadOnly = true;
                txtCreateDate.Text = DateTime.Now.ToShortDateString();
                txtThreadID.Text = sinhmatudong();
                txtThreadID.ReadOnly = true;
                LoadGrid();
            }
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
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            lblThongBao.Text = "";
        }

        protected void btnCreateNews_Click(object sender, EventArgs e)
        {
            if (txtMaxScores.Text == "" || txtThreadID.Text == "" || txtThreadName.Text == "" || ddlSubject.SelectedIndex == (ddlSubject.Items.Count - 1))
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (cls.KtraNumberFloat(txtMaxScores.Text) == true)
                {

                    if (TestCode(txtThreadID.Text) == false)
                    {
                        if (fulFile.HasFile)
                        {
                            UploadFile(fulFile);
                            #region Tạo đề thi
                            tblThread th = new tblThread();
                            th.SubjectID = ddlSubject.SelectedValue.ToString().Trim();
                            th.TheadName = txtThreadName.Text;
                            th.ThreadsID = txtThreadID.Text;
                            th.MaxScores = float.Parse(txtMaxScores.Text);
                            th.Status = 4;
                            //tbl.DateTest = DateTime.Parse(date);
                            th.CreateDate = DateTime.Now;
                            db.tblThreads.InsertOnSubmit(th);
                            db.SubmitChanges();
                            lblThongBao.Text = "Bạn đã nhập thành công";
                            lblThongBao.Visible = true;
                            LoadGrid();
                            txtThreadID.Text = sinhmatudong();
                            #endregion
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
                                    if (ddlSubject.SelectedValue.ToString().ToLower().Trim()==subjectCode.ToLower().Trim())
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
                                            if (TestCodeThreadQuestion(th.ThreadsID, tbl.QuestionsID.ToString()) == false)
                                            {
                                                tblThreadQuestion thq = new tblThreadQuestion();
                                                thq.QuestionsID = tbl.QuestionsID;
                                                thq.ThreadsID = th.ThreadsID;
                                                db.tblThreadQuestions.InsertOnSubmit(thq);
                                                db.SubmitChanges();
                                            }
                                        }
                                        else
                                        {
                                            var tbQuestion = db.tblQuestions.Where(c => c.Content.Trim().ToLower() == content.ToLower());
                                            foreach (var item in tbQuestion)
                                            {
                                                if (TestCodeThreadQuestion(th.ThreadsID,item.QuestionsID.ToString()) == false)
                                                {
                                                    tblThreadQuestion thq = new tblThreadQuestion();
                                                    thq.QuestionsID = item.QuestionsID;
                                                    thq.ThreadsID = th.ThreadsID;
                                                    db.tblThreadQuestions.InsertOnSubmit(thq);
                                                    db.SubmitChanges(); break;
                                                }
                                            }
                                           
                                        }
                                        lblThongBao.Text = "Imput thành công";
                                        lblThongBao.Visible = true;
                                    }
                                    else
                                    {
                                        lblThongBao.Text = "Mã môn học và mã file excel bạn chọn không trùng nhau";
                                        lblThongBao.Visible = true; break;
                                    }
                                    index++;
                                }
                                rowIndex = ++count;
                            }
                            #endregion

                        }
                        else
                        {
                            lblThongBao.Text = "Chưa chọn file câu hỏi";
                            lblThongBao.Visible = true;
                        }
                    }
                    else
                    {
                        lblThongBao.Text = "Trùng mã đề thi";
                    }

                }
                else
                {
                    lblThongBao.Text = "Tổng điểm bạn phải nhập số";
                    lblThongBao.Visible = true;
                }
            }
        }
        protected void btnEdit1_Click(object sender, EventArgs e)
        {
            if (txtMaxScores.Text == "" || txtThreadID.Text == "" || txtThreadName.Text == "" || ddlSubject.SelectedIndex == (ddlSubject.Items.Count - 1))
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (cls.KtraNumberFloat(txtMaxScores.Text) == true)
                {

                    
                        if (fulFile.HasFile)
                        {
                            
                            #region Tạo đề thi
                            tblThread th = db.tblThreads.SingleOrDefault(c => c.ThreadsID == txtThreadID.Text);
                            if (th != null)
                            {
                                UploadFile(fulFile);
                                th.SubjectID = ddlSubject.SelectedValue.ToString().Trim();
                                th.TheadName = txtThreadName.Text;
                                th.ThreadsID = txtThreadID.Text;
                                th.MaxScores = float.Parse(txtMaxScores.Text);
                                th.Status = 4;
                                //tbl.DateTest = DateTime.Parse(date);
                                th.CreateDate = DateTime.Now;
                                db.SubmitChanges();
                                lblThongBao.Text = "Bạn đã sửa thành công";
                                lblThongBao.Visible = true;
                                LoadGrid();
                                txtThreadID.Text = sinhmatudong();
                            #endregion
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
                                        if (ddlSubject.SelectedValue.ToString().ToLower().Trim() == subjectCode.ToLower().Trim())
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
                                                if (TestCodeThreadQuestion(th.ThreadsID, tbl.QuestionsID.ToString()) == false)
                                                {
                                                    tblThreadQuestion thq = new tblThreadQuestion();
                                                    thq.QuestionsID = tbl.QuestionsID;
                                                    thq.ThreadsID = th.ThreadsID;
                                                    db.tblThreadQuestions.InsertOnSubmit(thq);
                                                    db.SubmitChanges();
                                                }
                                            }
                                            else
                                            {
                                                tblQuestion tbQuestion = db.tblQuestions.SingleOrDefault(c => c.Content.Trim().ToLower() == content.ToLower());
                                                if (tbQuestion != null)
                                                {
                                                    if (TestCodeThreadQuestion(th.ThreadsID, tbQuestion.QuestionsID.ToString()) == false)
                                                    {
                                                        tblThreadQuestion thq = new tblThreadQuestion();
                                                        thq.QuestionsID = tbQuestion.QuestionsID;
                                                        thq.ThreadsID = th.ThreadsID;
                                                        db.tblThreadQuestions.InsertOnSubmit(thq);
                                                        db.SubmitChanges();
                                                    }

                                                }
                                            }
                                        }
                                        else
                                        {
                                            lblThongBao.Text = "Mã môn học và mã file excel bạn chọn không trùng nhau";
                                            lblThongBao.Visible = true; break;
                                        }
                                        index++;
                                    }
                                    rowIndex = ++count;
                                }
                                #endregion
                            }

                        }
                        else
                        {
                            lblThongBao.Text = "Chưa chọn file câu hỏi";
                            lblThongBao.Visible = true;
                        }
                   

                }
                else
                {
                    lblThongBao.Text = "Tổng điểm bạn phải nhập số";
                    lblThongBao.Visible = true;
                }
            }
        }
        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvThreadUniversity.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null)
                {
                    if (chk.Checked)
                    {
                        LinkButton link = (LinkButton)row.FindControl("btnSua");
                        tblThread at = db.tblThreads.SingleOrDefault(c => c.ThreadsID.ToString() == link.CommandArgument.ToString());
                        if (at != null)
                        {
                            // delete file when xoa

                            db.tblThreads.DeleteOnSubmit(at);
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
            Refresh();

        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void grvThreadUniversity_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageIndex = e.NewPageIndex;
            LoadGrid();
            grvThreadUniversity.PageIndex = pageIndex;
            grvThreadUniversity.DataBind();
        }

        protected void grvThreadUniversity_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            threadID = e.CommandArgument.ToString();
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblThread doc = db.tblThreads.SingleOrDefault(d => d.ThreadsID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    db.tblThreads.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                    Refresh();
                }

            }
            // Chọn hàng muốn sửa
            if (e.CommandName == "Edit")
            {
                tblThread doc = db.tblThreads.SingleOrDefault(d => d.ThreadsID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    txtCreateDate.Text = doc.CreateDate.ToShortDateString();
                    txtMaxScores.Text = doc.MaxScores.ToString();
                    txtThreadID.Text = doc.ThreadsID;
                    txtThreadName.Text = doc.TheadName;
                    ddlSubject.SelectedValue = doc.SubjectID.ToString();
                    txtThreadID.ReadOnly = true;
                    btnCreate.Enabled = false;
                    btnEdit1.Enabled = true;
                    lblThongBao.Text = "";
                }
            }

        }

        protected void grvThreadUniversity_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void grvThreadUniversity_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvThreadUniversity.ClientID + "')");

            }
        }

        protected void grvThreadUniversity_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGrid();
        }

        protected void grvThreadUniversity_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LoadGrid();
        }

      
    }
}