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
using System.Collections.Generic;

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucThread : System.Web.UI.UserControl
    {
        TestOnlineDataContext db = new TestOnlineDataContext();
        tool cls = new tool();
        static string threadID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSubject();
                loadLevel();
                LoadStatus();
              
                txtCreateDate.ReadOnly = true;
                txtCreateDate.Text = DateTime.Now.ToShortDateString();
                LoadDate();
                txtThreadID.Text = sinhmatudong();
                txtThreadID.ReadOnly = true;
                LoadGrid();
            }
        }
        /// <summary>
        /// Làm mới các điều khiển
        /// </summary>
        void Refresh()
        {
            txtHour.Text = "";
            txtMimute.Text = "";
            txtMaxScores.Text = "";
            txtNumberQuestion.Text = "";
            txtThreadID.Text = "";
            txtThreadName.Text = "";
            ddlLevel.SelectedIndex = 0;
            ddlStatus.SelectedIndex = 0;
            ddlSubject.SelectedIndex = ddlSubject.Items.Count - 1;
            btnCreate.Enabled = true;
            btnEdit1.Enabled = false;
            txtThreadID.ReadOnly = false; txtCreateDate.ReadOnly = true;
            txtCreateDate.Text = DateTime.Now.ToShortDateString();
            ddlDate.SelectedIndex = 0;
            ddlMonth.SelectedIndex = 0;
            ddlYear.SelectedIndex = 0;
            txtThreadID.ReadOnly = true;
            txtThreadID.Text = sinhmatudong();
            txtThreadID.ReadOnly = true;
        }
        /// <summary>
        /// Load ngày tháng năm
        /// </summary>
        void LoadDate()
        {
            ddlDate.Items.Add("Ngày");
            for (int i = 1; i <= 31; i++)
            {
                ddlDate.Items.Add(i.ToString());
            }
            ddlMonth.Items.Add("Tháng");
            for (int i = 1; i <= 12; i++)
            {
                ddlMonth.Items.Add(i.ToString());
            }
            ddlYear.Items.Add("Năm");
            int year = DateTime.Now.Year;
            for (int i = year; i <= year + 2; i++)
            {
                ddlYear.Items.Add(i.ToString());
            }
            ddlDate.SelectedIndex = 0;
            ddlMonth.SelectedIndex = 0;
            ddlYear.SelectedIndex = 0;

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
        //Lay muc do cho loai de thi
        void loadLevel()
        {
            ddlLevel.Items.Add("-- Chọn mức độ --");
            ddlLevel.Items.Add("1");
            ddlLevel.Items.Add("2");
            ddlLevel.Items.Add("3");
            ddlLevel.SelectedIndex = 0;

        }
        /// <summary>
        /// Load hình thức thi của đề thi
        /// </summary>
        void LoadStatus()
        {
            ddlStatus.Items.Add("-- Hình thức -- ");
            ddlStatus.Items.Add("1");
            ddlStatus.Items.Add("2");
            ddlStatus.Items.Add("3");
            ddlStatus.SelectedIndex = 0;
        }

        /// <summary>
        /// Load dữ liệu lên gridview
        /// </summary>
        void LoadGrid()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            var cl = from c in db.tblThreads
                     orderby c.ThreadsID descending
                     where c.Status!=4
                     select new { c.SubjectID,c.ThreadsID, c.TheadName, c.Level, c.tblSubject.SubjectName, c.Status, c.MaxScores, c.NumberQuestions, c.DateTest, c.CreateDate,c.Hour,c.Minute };
            if (ddlSubject.SelectedIndex != ddlSubject.Items.Count - 1)
            {
                 cl = from c in cl
                         orderby c.ThreadsID descending
                         where c.SubjectID.Trim() == ddlSubject.SelectedValue.ToString().Trim()
                      select new { c.SubjectID, c.ThreadsID, c.TheadName, c.Level, c.SubjectName, c.Status, c.MaxScores, c.NumberQuestions, c.DateTest, c.CreateDate, c.Hour, c.Minute };
 
            }
            if (ddlStatus.SelectedIndex == 0)
            {
               

            }
            else
            {
                cl = from c in cl
                     orderby c.ThreadsID descending
                     where c.Status == int.Parse(ddlStatus.SelectedItem.Text)
                     select new { c.SubjectID, c.ThreadsID, c.TheadName, c.Level, c.SubjectName, c.Status, c.MaxScores, c.NumberQuestions, c.DateTest, c.CreateDate, c.Hour, c.Minute };
            }
            grvThread.DataSource = cl;
            grvThread.DataBind();
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
 void taodethi(int mucdo, string mamon, string made)
        {

            List<string> ketqua = new List<string>();
            //de kho
            if (mucdo == 1)
            {
                int socaukho = int.Parse(txtNumberQuestion.Text) * 60 / 100;
                int socaude = int.Parse(txtNumberQuestion.Text) * 20 / 100;
                int socautrungbinh = int.Parse(txtNumberQuestion.Text) - (socaukho + socaude);
                var cl = from c in db.tblQuestions where c.SubjectID == mamon select new { c.QuestionsID, c.Level };
                List<string> caukho = new List<string>();
                List<string> cautrungbinh = new List<string>();
                List<string> caude = new List<string>();
                foreach (var item in cl)
                {
                    if (item.Level == 1)
                        caude.Add(item.QuestionsID.ToString());
                    if (item.Level == 2)
                    {
                        cautrungbinh.Add(item.QuestionsID.ToString());
                    }
                    if (item.Level == 3)
                    {
                        caukho.Add(item.QuestionsID.ToString());
                    }
                }
                int i = 0;
                while (i!=socaude)
                {
                    Random r = new Random();
                    int tmp = r.Next(caude.Count);
                    ketqua.Add(caude[tmp]);
                    caude.Remove(caude[tmp]);
                    i++;
                }
                int j = 0;
                while (j!=socautrungbinh)
                {
                    Random r = new Random();
                    int tmp = r.Next(cautrungbinh.Count);
                    ketqua.Add(cautrungbinh[tmp]);
                    cautrungbinh.Remove(cautrungbinh[tmp]);
                    j++;
                }
                int k = 0;
                while (k!=socaukho)
                {
                    Random r = new Random();
                    int tmp = r.Next(caukho.Count);
                    ketqua.Add(caukho[tmp]);
                    caukho.Remove(caukho[tmp]);
                    k++;
                }
            }
            //de trung binh
            if (mucdo == 2)
            {
                int socaukho = int.Parse(txtNumberQuestion.Text) * 50 / 100;
                int socaude = int.Parse(txtNumberQuestion.Text) * 25 / 100;
                int socautrungbinh = int.Parse(txtNumberQuestion.Text) - (socaukho + socaude);
                var cl = from c in db.tblQuestions where c.SubjectID == mamon select new { c.QuestionsID, c.Level };
                List<string> caukho = new List<string>();
                List<string> cautrungbinh = new List<string>();
                List<string> caude = new List<string>();
                foreach (var item in cl)
                {
                    if (item.Level == 1)
                        caude.Add(item.QuestionsID.ToString());
                    if (item.Level == 2)
                    {
                        cautrungbinh.Add(item.QuestionsID.ToString());
                    }
                    if (item.Level == 3)
                    {
                        caukho.Add(item.QuestionsID.ToString());
                    }
                }
                int i = 0;
                while (i != socaude)
                {
                    Random r = new Random();
                    int tmp = r.Next(caude.Count);
                    ketqua.Add(caude[tmp]);
                    caude.Remove(caude[tmp]);
                    i++;
                }
                int j = 0;
                while (j != socautrungbinh)
                {
                    Random r = new Random();
                    int tmp = r.Next(cautrungbinh.Count);
                    ketqua.Add(cautrungbinh[tmp]);
                    cautrungbinh.Remove(cautrungbinh[tmp]);
                    j++;
                }
                int k = 0;
                while (k != socaukho)
                {
                    Random r = new Random();
                    int tmp = r.Next(caukho.Count);
                    ketqua.Add(caukho[tmp]);
                    caukho.Remove(caukho[tmp]);
                    k++;
                }
            }
            // de de
            if (mucdo == 3)
            {
                int socaukho = int.Parse(txtNumberQuestion.Text) * 40 / 100;
                int socaude = int.Parse(txtNumberQuestion.Text) * 30 / 100;
                int socautrungbinh = int.Parse(txtNumberQuestion.Text) - (socaukho + socaude);
                var cl = from c in db.tblQuestions where c.SubjectID == mamon select new { c.QuestionsID, c.Level };
                List<string> caukho = new List<string>();
                List<string> cautrungbinh = new List<string>();
                List<string> caude = new List<string>();
                foreach (var item in cl)
                {
                    if (item.Level == 1)
                        caude.Add(item.QuestionsID.ToString());
                    if (item.Level == 2)
                    {
                        cautrungbinh.Add(item.QuestionsID.ToString());
                    }
                    if (item.Level == 3)
                    {
                        caukho.Add(item.QuestionsID.ToString());
                    }
                }
                int i = 0;
                while (i != socaude)
                {
                    Random r = new Random();
                    int tmp = r.Next(caude.Count);
                    ketqua.Add(caude[tmp]);
                    caude.Remove(caude[tmp]);
                    i++;
                }
                int j = 0;
                while (j != socautrungbinh)
                {
                    Random r = new Random();
                    int tmp = r.Next(cautrungbinh.Count);
                    ketqua.Add(cautrungbinh[tmp]);
                    cautrungbinh.Remove(cautrungbinh[tmp]);
                    j++;
                }
                int k = 0;
                while (k != socaukho)
                {
                    Random r = new Random();
                    int tmp = r.Next(caukho.Count);
                    ketqua.Add(caukho[tmp]);
                    caukho.Remove(caukho[tmp]);
                    k++;
                }
            }
            tblThreadQuestion tbl;
            foreach (string item in ketqua)
            {
                tbl = new tblThreadQuestion();
                tbl.QuestionsID = int.Parse(item);
                tbl.ThreadsID = made;
                db.tblThreadQuestions.InsertOnSubmit(tbl);
                db.SubmitChanges();
            }
        }
        bool TestHour()
        {
            bool kt = true;
            if (txtHour.Text != "")
            {
                if (int.Parse(txtHour.Text) > 24 || int.Parse(txtHour.Text) < 0)
                {
                    kt = false;
                }
            }
            if (txtMimute.Text != "")
            {
                if (int.Parse(txtMimute.Text) > 59 || int.Parse(txtMimute.Text) < 0)
                {
                    kt = false;
                }
            }
            return kt;
        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            lblThongBao.Text = "";
        }
        /// <summary>
        /// Thêm 1 bản ghi mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreateNews_Click(object sender, EventArgs e)
        {
            if (txtMaxScores.Text == "" || txtNumberQuestion.Text == "" || txtThreadID.Text == "" || txtThreadName.Text == "" || ddlLevel.SelectedIndex == 0 || ddlStatus.SelectedIndex == 0 || ddlSubject.SelectedIndex == (ddlSubject.Items.Count - 1) || ddlDate.SelectedIndex == 0 || ddlMonth.SelectedIndex == 0 || ddlYear.SelectedIndex == 0)
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (cls.KtraNumberFloat(txtMaxScores.Text) == true)
                {
                    if (cls.KtraNumber(txtNumberQuestion.Text) == true)
                    {
                        if (TestCode(txtThreadID.Text) == false)
                        {
                            if (cls.KtraNumber(txtHour.Text) == true && cls.KtraNumber(txtMimute.Text) == true)
                            {
                                if (TestHour() == true)
                                {
                                    #region Tạo đề thi
                                    tblThread tbl = new tblThread();
                                    tbl.SubjectID = ddlSubject.SelectedValue.ToString().Trim();
                                    tbl.Status = int.Parse(ddlStatus.Text);
                                    tbl.TheadName = txtThreadName.Text;
                                    tbl.ThreadsID = txtThreadID.Text;
                                    tbl.MaxScores = float.Parse(txtMaxScores.Text);
                                    tbl.Level = int.Parse(ddlLevel.Text);
                                    //tbl.DateTest = DateTime.Parse(date);
                                    tbl.CreateDate = DateTime.Now;
                                    try
                                    {
                                        string date = ddlMonth.Text + "/" + ddlDate.Text + "/" + ddlYear.Text + " " + txtHour.Text + ":" + txtMimute.Text + ":" + "00";
                                        tbl.DateTest = Convert.ToDateTime(date);
                                    }
                                    catch
                                    {
                                        string date = ddlDate.Text.Trim() + "/" + ddlMonth.Text.Trim() + "/" + ddlYear.Text + " " + txtHour.Text + ":" + txtMimute.Text + ":" + "00";
                                        tbl.DateTest = Convert.ToDateTime(date);
                                    }
                                    tbl.NumberQuestions = int.Parse(txtNumberQuestion.Text);
                                    db.tblThreads.InsertOnSubmit(tbl);
                                    db.SubmitChanges();
                                    lblThongBao.Text = "Bạn đã nhập thành công";
                                    lblThongBao.Visible = true;
                                

                                    /// Soc đề
                                    try
                                    {
                                        taodethi(int.Parse(ddlLevel.Text), ddlSubject.SelectedValue.ToString(), txtThreadID.Text);
                                    }
                                    catch
                                    {
                                        lblThongBao.Text = "Vượt quá số câu hỏi";
                                    }
                                    var cl = db.tblThreadQuestions.Where(c => c.ThreadsID == txtThreadID.Text);
                                    if (cl.Count()<=0)
                                    {
                                        tblThread tl = db.tblThreads.SingleOrDefault(c => c.ThreadsID == txtThreadID.Text);
                                        if (tl != null)
                                        { db.tblThreads.DeleteOnSubmit(tl); db.SubmitChanges(); }
                                    }
                                    txtThreadID.Text = sinhmatudong();
                                    LoadGrid();
                                    #endregion
                                }
                                else
                                { lblThongBao.Text = "Bạn nhập giờ thi và phút thi không đúng !"; }
                            }
                            else
                            {
                                lblThongBao.Text = "Bạn nhập giờ thi và phút thi không đúng";
                            }

                        }
                        else
                        {
                            lblThongBao.Text = "Trùng mã đề thi";


                        }
                    }
                    else
                    {
                        lblThongBao.Text = "Số câu hỏi bạn phải nhập số";
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
        /// <summary>
        /// Sửa dữ liệu với hàng được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit1_Click(object sender, EventArgs e)
        {
            if (txtMaxScores.Text == "" || txtNumberQuestion.Text == "" || txtThreadID.Text == "" || txtThreadName.Text == "" || ddlLevel.SelectedIndex == 0 || ddlStatus.SelectedIndex == 0 || ddlSubject.SelectedIndex == (ddlSubject.Items.Count - 1) || ddlDate.SelectedIndex == 0 || ddlMonth.SelectedIndex == 0 || ddlYear.SelectedIndex == 0)
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (cls.KtraNumberFloat(txtMaxScores.Text) == true)
                {
                    if (cls.KtraNumber(txtNumberQuestion.Text) == true)
                    {
                        if (cls.KtraNumber(txtHour.Text) == true && cls.KtraNumber(txtMimute.Text) == true && TestHour() == true)
                        {
                            tblThread tbl = db.tblThreads.SingleOrDefault(c => c.ThreadsID.Trim() == threadID.Trim());
                            if (tbl != null)
                            {
                                tbl.SubjectID = ddlSubject.SelectedValue.ToString().Trim();
                                tbl.Status = int.Parse(ddlStatus.Text);
                                tbl.TheadName = txtThreadName.Text;
                                tbl.ThreadsID = txtThreadID.Text;
                                tbl.MaxScores = float.Parse(txtMaxScores.Text);
                                tbl.Level = int.Parse(ddlLevel.Text);
                                try
                                {
                                    string date = ddlDate.Text.Trim() + "/" + ddlMonth.Text.Trim() + "/" + ddlYear.Text;
                                    tbl.DateTest = DateTime.Parse(date);
                                }
                                catch
                                {
                                    string date = ddlMonth.Text + "/" + ddlDate.Text + "/" + ddlYear.Text;
                                    tbl.DateTest = DateTime.Parse(date);
                                }
                                tbl.CreateDate = DateTime.Now;
                                tbl.NumberQuestions = int.Parse(txtNumberQuestion.Text);
                                db.SubmitChanges();
                                lblThongBao.Text = "Bạn đã sửa thành công";
                                lblThongBao.Visible = true;
                                LoadGrid();
                            }
                            else
                            {
                                lblThongBao.Text = "Không tồn tại bản ghi cần sửa";
                                lblThongBao.Visible = true;
                            }
                        }
                        else
                        {
                            lblThongBao.Text = "Bạn nhập giờ thi và phút thi không đúng";
                        }
                    }
                    else
                    {
                        lblThongBao.Text = "Số câu hỏi bạn phải nhập số";
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
        /// <summary>
        /// Xóa nhiều hàng theo lựa chọn trên gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvThread.Rows)
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
        /// <summary>
        /// Sự kiện khi chọn ở combobox môn sẽ load dữ liệu theo môn tương ứng lên gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        /// <summary>
        /// Sự kiện phân trang trong gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grvThread_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageIndex = e.NewPageIndex;
            LoadGrid();
            grvThread.PageIndex = pageIndex;
            grvThread.DataBind();

        }
        /// <summary>
        /// Sự kiện khi muốn xóa hoặc sửa click chọn trên gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void grvThread_RowCommand(object sender, GridViewCommandEventArgs e)
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

                    ddlDate.Text = doc.DateTest.Value.Date.ToString();
                    ddlMonth.Text = doc.DateTest.Value.Month.ToString();
                    ddlYear.Text = doc.DateTest.Value.Year.ToString();
                    txtCreateDate.Text = doc.CreateDate.ToShortDateString();
                    txtMaxScores.Text = doc.MaxScores.ToString();
                    txtNumberQuestion.Text = doc.NumberQuestions.ToString();
                    txtThreadID.Text = doc.ThreadsID;
                    txtThreadName.Text = doc.TheadName;
                    ddlLevel.Text = doc.Level.ToString();
                    ddlStatus.Text = doc.Status.ToString().Trim();
                    ddlSubject.SelectedValue = doc.SubjectID.ToString();
                    txtMimute.Text = doc.Minute;
                    txtHour.Text = doc.Hour;
                    txtThreadID.ReadOnly = true;
                    btnCreate.Enabled = false;
                    btnEdit1.Enabled = true;
                    lblThongBao.Text = "";
                }
            }
        }

        protected void grvThread_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void grvThread_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvThread.ClientID + "')");

            }
        }

        protected void grvThread_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGrid();
        }

        protected void grvThread_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LoadGrid();
        }

        protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        
    }
}