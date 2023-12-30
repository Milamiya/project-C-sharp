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

namespace TestOnline.hy.vn.Control
{
    public partial class ucRegistry : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCity();
                Loadate();

            }
        }
        bool KtrEmail(string email)
        {
            bool kt=true;

            if (email.IndexOf('@') >= 0)
            {
                string[] mang = email.Split('@');
                if (mang[1].ToString().ToLower() != "yahoo.com" && mang[1].ToString().ToLower() != "yahoo.com.vn" && mang[1].ToString().ToLower() != "gmail.com" && mang[1].ToString().ToLower() != "gmail.com.vn")
                {
                    kt = false;
                }
            }//Download source code tai Sharecode.vn
            else kt = false;
            return kt;
        }
        void Loadate()
        {
            ddlDay.Items.Add("Ngày");
            ddlMonth.Items.Add("Tháng");
            ddlYear.Items.Add("Năm");
            for (int i =1; i <=31; i++)
            {
                ddlDay.Items.Add(i.ToString());
            }
            for (int i = 1; i <=12; i++)
            {
                ddlMonth.Items.Add(i.ToString());
            }
            for (int i =(DateTime.Now.Year-50); i <(DateTime.Now.Year-10); i++)
            {
                ddlYear.Items.Add(i.ToString());
            }
        }
        void LoadCity()
        {
            ddlCity.Items.Add("-- Chọn thành phố --");
            ddlCity.Items.Add("Hưng yên");
            ddlCity.Items.Add("Hà nội");
            ddlCity.Items.Add("Hải dương");
            ddlCity.Items.Add("Bắc giang");
            ddlCity.Items.Add("Nam định");
            ddlCity.Items.Add("Thái bình");
            ddlCity.Items.Add("Hà nam");
            ddlCity.Items.Add("Quảng ninh");
            ddlCity.Items.Add("Vĩnh phúc");
            ddlCity.Items.Add("Cao bằng");
        }
        bool TestEmail()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblStudent tbl = db.tblStudents.SingleOrDefault(c => c.Email.ToString().ToLower() == txtMail.Text.ToLower());
            if (tbl != null)
            {
                return false;

            }
            else return true;
        }
        bool TestCodeUserName()
        {
            TestOnlineDataContext db=new TestOnlineDataContext();
            tblStudent tbl = db.tblStudents.SingleOrDefault(c => c.StudentID.ToString().ToLower() == txtUsername.Text.ToLower());
            if (tbl != null)
            {
                return false;

            }
            else return true;
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (txtFullName.Text == "" || txtMail.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "" || txtUsername.Text == "" || ddlCity.SelectedIndex == 0 || ddlDay.SelectedIndex==0 || ddlMonth.SelectedIndex==0 || ddlYear.SelectedIndex==0)
            {
                lblThongBao.Text = "Bạn chưa nhập đầy đủ thông tin";
                lblThongBao.Visible = true;
            }
            else
            {
                if (KtrEmail(txtMail.Text) == false)
                {
                    lblThongBao.Text = "Email không đúng";
                    lblThongBao.Visible = true;
                }
                else
                {
                    if (txtPassword.Text.ToLower() != txtPassword2.Text.ToLower())
                    {
                        lblThongBao.Text = "Mật khẩu không trùng nhau";
                        lblThongBao.Visible = true;
                    }
                    else
                    {
                        if (TestEmail() == false)
                        {
                            lblThongBao.Text = "Email đã tồn tại";
                            lblThongBao.Visible = true;
                        }
                        else
                        {
                            if (TestCodeUserName() == false)
                            {
                                lblThongBao.Text = "Tài khoản đã tồn tại";
                                lblThongBao.Visible = true;
                            }
                            else
                            {
                                tblStudent tbl = new tblStudent();
                                tbl.StudentID = txtUsername.Text;
                                tbl.StudentName = txtFullName.Text;
                                    string s = ddlDay.Text.Trim() + "/" + ddlMonth.Text.Trim() + "/" + ddlYear.Text.Trim();
                                    tbl.Birthday =s;
                                tbl.City = ddlCity.SelectedItem.Text;
                                tbl.Email = txtMail.Text;
                                tbl.Password = txtPassword.Text;
                                db.tblStudents.InsertOnSubmit(tbl);
                                db.SubmitChanges();
                                Response.Redirect("ThanhCong.aspx");
                            }
                        }
                    
                    }
                }
            }
        }

        protected void btnTestEmail_Click(object sender, EventArgs e)
        {
            if (KtrEmail(txtMail.Text) == false || txtMail.Text=="")
            {
                lblThongBao.Text = "Email không đúng";
                lblThongBao.Visible = true;
            }
        }

        protected void btnTestMK_Click(object sender, EventArgs e)
        {
            if (TestCodeUserName() == false)
            {
                lblThongBao.Text = "Tài khoản đã tồn tại";
                lblThongBao.Visible = true;
            }
        }
    }
}