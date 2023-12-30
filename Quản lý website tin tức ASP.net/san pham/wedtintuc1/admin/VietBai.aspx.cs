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
public partial class admin_VietBai : System.Web.UI.Page
{
    private long idNews = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null || Session["Password"] != null)
        {
            hidUser.Value = Session["UserName"].ToString() + "";
            idNews = long.Parse("0" + Request.QueryString["idNews"]);
            if (!IsPostBack)
            {
                txtThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy");
                LoadDropChuyenMuc(drChuyenMuc, 0);
                LoadChiTiet(idNews);
            }
            KiemTraQuyen(hidUser.Value + "");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    private void LoadDropChuyenMuc(DropDownList drName, int CateID)
    {
        ListItem list = new ListItem();
        drName.Items.Clear();
        drName.Items.Add(list);
        list.Selected = true;
        list.Value = "0";
        list.Text = "----- Chọn Chuyên Mục -----";
        ChuyenMucClass Cmc = new ChuyenMucClass();
        Tool tc = new Tool();
        DataTable dtb = Cmc.Category_GetTree(CateID);
        if (dtb.Rows.Count > 0)
        {
            tc.LoadDropDownList(drName, dtb, "TenChuyenMuc", "CateID");
        }
        Cmc = null;
        tc = null;
    }
    private void GhiFileAnh()
    {
        try
        {
            if (picUp.PostedFile != null)
            {
                HttpPostedFile myfile = picUp.PostedFile;
                int nFileLen = myfile.ContentLength;
                byte[] mydata = new byte[nFileLen];
                myfile.InputStream.Read(mydata, 0, nFileLen);
                string strFilename = Path.GetFileName(myfile.FileName);
                WriteToFile(Server.MapPath("../Upload/" + strFilename), ref mydata);
            }
        }
        catch
        { }
    }
    private void WriteToFile(string strPath, ref byte[] Buffer)
    {
        try
        {
            FileStream newFile = new FileStream(strPath, FileMode.Create);
            newFile.Write(Buffer, 0, Buffer.Length);
            newFile.Close();
        }
        catch { }
    }
    protected void butThayAnh_Click(object sender, EventArgs e)
    {
        imagePic.Visible = false;
        picUp.Visible = true;
        butThayAnh.Visible = false;
    }
    private void LoadChiTiet(long idNews)
    {
        SP_News news = new SP_News();
        DataTable dtb = news.News_SelectByID(idNews);
        if (dtb.Rows.Count > 0)
        {
            txtTitle.Text = dtb.Rows[0]["Title"] + "";
            drChuyenMuc.SelectedValue = dtb.Rows[0]["CateID"] + "";
            txtMieuTa.Text = dtb.Rows[0]["Description"] + "";
            fckNoiDung.Value = dtb.Rows[0]["Content"] + "";
            txtTacGia.Text = dtb.Rows[0]["Author"] + "";
            txtLienKet.Text = dtb.Rows[0]["Link"] + "";
            txtThoiGian.Text = dtb.Rows[0]["CreateDate"] + "";
            txtTuKhoa.Text = dtb.Rows[0]["Keyword"] + "";
            if (dtb.Rows[0]["FeedBack"] + "" == "1")
            {
                rdoChoPhep.Checked = true;
            }
            else
                rdoKhongCHoPhep.Checked = true;
            if (dtb.Rows[0]["Picture"] + "" != "")
            {
                imagePic.Visible = true;
                imagePic.ImageUrl = "../" + dtb.Rows[0]["Picture"] + "";
                picUp.Visible = false;
                butThayAnh.Visible = true;
            }
        }
        else
        {
            picUp.Visible = true;
            butThayAnh.Visible = false;
        }
        news = null;
    }
    private void KiemTraQuyen(string Username)
    {
        string stQuyen = "";
        User a = new User();
        DataTable dtb = a.User_SelectByUserName(Username);
        if (dtb.Rows.Count > 0)
        {
            stQuyen = dtb.Rows[0]["RoleCode"] + "";
        }
        switch (stQuyen)
        {
            case "1":
            //admin
            case "2":
                //dang bai
                chkDuyet.Visible = true;
                chkDang.Visible = true;
                break;
            case "3":
                //duyet bai
                chkDang.Visible = false;
                chkDuyet.Visible = true;
                break;
            case "4":
                chkDang.Visible = false;
                chkDuyet.Visible = false;
                break;

        }
        a = null;
    }
    protected void butGuiBai_Click(object sender, EventArgs e)
    {
        string strError = "";
        int Active = 0, FeedBack = 0, Status = 0;
        if (rdoChoPhep.Checked == true)
            FeedBack = 1;
        else
            FeedBack = 0;
        if (chkDang.Checked == true)
        {
            Status = 1;
        }
        else
        {
            if (chkDuyet.Checked == true)
                Status = 0;
            //else
            //    Status = 2;
        }
        if (idNews == 0)
            Active = 0;
        else
            Active = 2;
        if (txtTitle.Text + "" == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn chưa nhập tiêu đề bài viết');", true);
        }
        else
        {
            if (drChuyenMuc.SelectedValue + "" == "0")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectMe", "alert('Chưa chọn chuyên mục ');", true);
            }
            if (txtMieuTa.Text + "" == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectMe", "alert('Chưa nhập miêu tả ');", true);
            }
        }
        if (fckNoiDung.Value + "" == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectMe", "alert('Chưa nhập nội dung tin ');", true);
        }
        if (txtTacGia.Text + "" == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectMe", "alert('Chưa nhập tác giả ');", true);
        }
        else
        {
            HttpPostedFile myfile = picUp.PostedFile;
            string strFileName = picUp.FileName + "";
            if (strFileName != "")
            {
                GhiFileAnh();
            }
            else
            {
                strFileName = imagePic.ImageUrl;
                GhiFileAnh();
            }
            SP_News news = new SP_News();
            news.News_Insert(idNews, int.Parse("0" + drChuyenMuc.SelectedValue),
                            hidUser.Value + "", txtTitle.Text + "", txtMieuTa.Text + "", fckNoiDung.Value + "",
                            txtTuKhoa.Text + "", txtTacGia.Text + "", "Upload/" + strFileName, DateTime.Now, DateTime.Now, txtLienKet.Text + "",
                           Status, hidUser.Value + "", FeedBack, ref strError);
            if (strError + "" != "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectMe", "alert('" + strError + "');", true);
            }
            news = null;
        }
    }
}
