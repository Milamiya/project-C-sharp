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

public partial class admin_QuanTriNguoiDung : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string quyenhan = "";
        if (Session["UserName"] != null || Session["Password"] != null)
        {
            hidUser.Value = Session["UserName"].ToString() + "";
            quyenhan = CheckQuyen(hidUser.Value);
            if (quyenhan == "1")
            {
                if (!IsPostBack)
                {
                    LoadDropQuyen(dropPhanQuyenEdit, "");
                    LoadData("", "");
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirectMe", "alert('Bạn không có quyền vào chức năng này');", true);
                Response.Redirect("Default.aspx");
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

   
   
    private string CheckQuyen(string UserName)
    {
        string quyen = "";
        User a = new User();
        DataTable dtb = a.User_SelectByUserName(UserName);
        if (dtb.Rows.Count > 0)
        {
            quyen = dtb.Rows[0]["RoleCode"] + "";

        }
        return quyen;
    }
    private void LoadDropQuyen(DropDownList drName, string roleCode)
    {
        ListItem list = new ListItem();
        drName.Items.Clear();
        drName.Items.Add(list);
        list.Selected = true;
        list.Value = "0";
        list.Text = "----- Chọn phân quyền -----";
        User us = new User();
        Tool tl = new Tool();
        DataTable dtb = us.Role_Select(roleCode);
        if (dtb.Rows.Count > 0)
        {
            tl.LoadDropDownList(drName, dtb, "RoleName", "RoleCode");
        }
        us = null;
        tl = null;

    }
    private void LoadData(string RollCode, string Keyword)
    {
        User us = new User();
        DataTable dtb = us.User_Search(RollCode, Keyword);
        if (dtb.Rows.Count > 0)
        {
            pnDanhSach.GroupingText = "Tìm thấy <u>" + dtb.Rows.Count.ToString() + "</u> User";
            grvDanhSachUS.DataSource = dtb;
            grvDanhSachUS.DataBind();
        }
        else
        {
            pnDanhSach.GroupingText = "Tìm thấy <u>0</u> User";
        }
        us = null;
    }
    private void LoadUserDetail(string strUserName)
    {
        User us = new User();
        MaHoa mh = new MaHoa();
        DataTable dtbUser = us.User_SelectByUserName(strUserName);
        if (dtbUser.Rows.Count > 0)
        {

            txtTenDN.Text = dtbUser.Rows[0]["UserName"] + "";
            txtTenDN.ReadOnly = true;
            txtMatKhau.Text = mh.Decrypt("tk6se", dtbUser.Rows[0]["Password"] + "");
            txtMail.Text = dtbUser.Rows[0]["Email"] + "";
            txtHoTen.Text = dtbUser.Rows[0]["FullName"] + "";
            if (dtbUser.Rows[0]["Status"] + "" == "1")
            {

                rdOn.Checked = true;
            }
            else
            {

                rdOff.Checked = true;
            }
            dropPhanQuyenEdit.SelectedValue = dtbUser.Rows[0]["RoleCode"] + "";
        }
        us = null;
    }
    private void ResetForm()
    {
        txtTenDN.Text = "";
        txtTenDN.ReadOnly = false;
        txtMatKhau.Text = "";
        txtMail.Text = "";
        txtHoTen.Text = "";
        rdOn.Checked = true;
        
    }

  
    protected void lbtLuu_Click(object sender, EventArgs e)
    {
        int intTrangThai = 0;
        if (rdOn.Checked == true)
        {
            intTrangThai = 1;
        }
        else
        {
            intTrangThai = 0;
        }
        string error = "";
        MaHoa mh = new MaHoa();
        User us = new User();
        if (txtTenDN.Text != "" && txtMatKhau.Text != "" && dropPhanQuyenEdit.SelectedValue != "")
        {
            us.User_Edit(
                
                txtTenDN.Text + "",
                  mh.Encrypt("tk6se", txtMatKhau.Text.Trim() + ""),
                dropPhanQuyenEdit.SelectedValue + "",
                txtHoTen.Text + "",
                txtMail.Text + "",
                intTrangThai,
                ref error
                );
            if (error != "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + error + "');", true);
                LoadData("", "");

            }
            ResetForm();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn nhập thiếu thông tin');", true);
        }


        us = null;
        mh = null;
    }
   
    protected void lbtThem_Click(object sender, EventArgs e)
    {
        hidAction.Value = "1";
        int intTrangThai = 0;
        if (rdOn.Checked == true)
        { intTrangThai = 1; }
        else
        { intTrangThai = 0; }
        string error = "";
        MaHoa mh = new MaHoa();
        User us = new User();
        if (txtTenDN.Text != "" && txtMatKhau.Text != "" && dropPhanQuyenEdit.SelectedValue != "")
        {
            us.User_Insert(

                txtTenDN.Text + "",
                  mh.Encrypt("tk6se", txtMatKhau.Text.Trim() + ""),
                dropPhanQuyenEdit.SelectedValue + "",
                txtHoTen.Text + "",
                txtMail.Text + "",
                intTrangThai,
                ref error
                );
            if (error != "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + error + "');", true);
                LoadData("", "");
                ResetForm();

            }
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn nhập thiếu thông tin');", true);
        }
        us = null;
        mh = null;
    }
    protected void lbtXoa_Click(object sender, EventArgs e)
    {
        User us = new User();
        string error = "";
        int intNumbercheck = 0;
        if (grvDanhSachUS.Rows.Count > 0)
        {
            for (int i = 0; i < grvDanhSachUS.Rows.Count; i++)
            {
                CheckBox chkchon = (CheckBox)grvDanhSachUS.Rows[i].FindControl("ckCheck");
                Label lblUsername = (Label)grvDanhSachUS.Rows[i].FindControl("lblUserName");
                if (chkchon.Checked == true)
                {
                    us.User_delete(lblUsername.Text, ref error);
                    intNumbercheck++;
                }
            }
            if (intNumbercheck > 0)
            {
                if (error != "")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + error + "');", true);
                    LoadData("", "");


                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn cần chọn ít nhất 1 user để xóa');", true);
                }
            }
        }
        us = null;

    }
    protected void lbtSua_Click(object sender, EventArgs e)
    {
        User us = new User();
        string error = "", UserName = "";
        int intNumbercheck = 0;
        if (grvDanhSachUS.Rows.Count > 0)
        {
            for (int i = 0; i < grvDanhSachUS.Rows.Count; i++)
            {
                CheckBox chkchon = (CheckBox)grvDanhSachUS.Rows[i].FindControl("ckCheck");
                Label lblUsername = (Label)grvDanhSachUS.Rows[i].FindControl("lblUserName");
                if (chkchon.Checked == true)
                {
                    UserName = lblUsername.Text + "";
                    intNumbercheck++;
                }
            }
            if (intNumbercheck > 1)
                 {
                
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn chỉ được chọn một User để sửa');", true);
                    }
                else
                {
                    if (intNumbercheck == 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn Chưa chọn User nào');", true);

                    }
                    else
                    {

                        LoadUserDetail(UserName);
                    }
                }
            }
        us = null;
        }

    protected void grvDanhSachUS_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
}

