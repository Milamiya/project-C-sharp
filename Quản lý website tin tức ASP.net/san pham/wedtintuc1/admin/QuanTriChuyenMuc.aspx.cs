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

public partial class admin_QuanTriChuyenMuc : System.Web.UI.Page
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

                    LoadGridChuyenMuc(0);
                    LoadDropChuyenMuc(drChuyenMuc, 0);
                    LoadDropChuyenMuc(drChuyenMucChaEdit, 0);
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
    private void LoadGridChuyenMuc(int cateid)
    {
        pnDanhSachCM.GroupingText = "";
        grvDanhSachCM.DataSource = null;
        grvDanhSachCM.DataBind();
        ChuyenMucClass cmc = new ChuyenMucClass();
        DataTable dtb = cmc.Category_GetTree(cateid);
        if (dtb.Rows.Count > 0)
        {
            pnDanhSachCM.GroupingText = "Tìm thấy <u>" + dtb.Rows.Count.ToString() + "</u> chuyên mục";
            grvDanhSachCM.DataSource = dtb;
            grvDanhSachCM.DataBind();
        }
        cmc = null;
    }
    private void LoadDropChuyenMuc(DropDownList drName, int cateID)
    {
        ListItem list = new ListItem();
        drName.Items.Clear();
        drName.Items.Add(list);
        list.Selected = true;
        list.Value = "0";
        list.Text = "----- Chọn chuyên mục cha -----";
        ChuyenMucClass cmc = new ChuyenMucClass();
        Tool tl = new Tool();
        DataTable dtb = cmc.Category_GetTree(cateID);
        if (dtb.Rows.Count > 0)
        {
            tl.LoadDropDownList(drName, dtb, "TenChuyenMuc", "CateID");
        }
        cmc = null;
        tl = null;

    }

    private void ResetForm()
    {
        hidSearch.Value = "";
        txtTenChuyenMuc.Text = "";
        txtLink.Text = "";
        drChuyenMucChaEdit.SelectedValue = "0";
        hidAction.Value = "";
    }
    private void LoadChiTietChuyenMuc(int cateID)
    {
        ChuyenMucClass cmc = new ChuyenMucClass();
        DataTable dtb = cmc.Category_GetTree(cateID);
        if (dtb.Rows.Count > 0)
        {
            txtTenChuyenMuc.Text = dtb.Rows[0]["CateName"] + "";
            txtLink.Text = dtb.Rows[0]["Link"] + "";
            drChuyenMucChaEdit.SelectedValue = dtb.Rows[0]["ParentID"] + "";
        }
        cmc = null;
    }
    private void LuuCM(int cateid)
    {
        string error = "";
        ChuyenMucClass cmc = new ChuyenMucClass();
        if (txtTenChuyenMuc.Text + "" == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn chưa nhập tên cho chuyên mục');", true);
        }
        else
        {
            cmc.Category_Edit( cateid, int.Parse("0" + drChuyenMucChaEdit.SelectedValue),
                txtTenChuyenMuc.Text + "", txtLink.Text, ref error);
            if (error + "" != "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + error + "');", true);
                LoadGridChuyenMuc(0);
                ResetForm();
                LoadDropChuyenMuc(drChuyenMuc, 0);
                LoadDropChuyenMuc(drChuyenMucChaEdit, 0);
            }
        }
        cmc = null;
    }
    protected void lbtThoat_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void lbtTruyVan_Click(object sender, EventArgs e)
    {

    }
    protected void lbtThem_Click(object sender, EventArgs e)
    {
        
        string error = "";
        ChuyenMucClass cmc = new ChuyenMucClass();
        if (txtTenChuyenMuc.Text == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn chưa nhập tên chuyên mục');", true);
        }
        else
        {
            cmc.Category_Edit( 0, int.Parse("0" + drChuyenMucChaEdit.SelectedValue),
                txtTenChuyenMuc.Text + "", txtLink.Text + "", ref error);
            if (error + "" != "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + error + "');", true);
                LoadGridChuyenMuc(0);
                ResetForm();
                LoadDropChuyenMuc(drChuyenMucChaEdit, 0);

            }
        }
        cmc = null;
    }
    protected void lbtSua_Click(object sender, EventArgs e)
    {
         hidAction.Value = "2";
        int numcheck = 0;
        if (grvDanhSachCM.Rows.Count > 0)
        {
            for (int i = 0; i < grvDanhSachCM.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)grvDanhSachCM.Rows[i].FindControl("checked");
                Label lblCateID = (Label)grvDanhSachCM.Rows[i].FindControl("lbCateID");
                if (chk.Checked == true)
                {
                    hidCateID.Value = lblCateID.Text + "";
                    numcheck++;
                }
            }
            if (numcheck > 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn chỉ được chọn một Chuyên mục để sửa');", true);
            }
            else
            {
                if (numcheck == 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn chưa chọn chuyên mục nào nào');", true);
                }
                else
                {
                    LoadChiTietChuyenMuc(int.Parse("0" + hidCateID.Value));
                }
            }
        }
    }
    protected void lbtXoa_Click(object sender, EventArgs e)
    {
        string error = "";
        int numcheck = 0;
        ChuyenMucClass cmc = new ChuyenMucClass();
        if (grvDanhSachCM.Rows.Count > 0)
        {
            for (int i = 0; i < grvDanhSachCM.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)grvDanhSachCM.Rows[i].FindControl("checked");
                Label lblcateid = (Label)grvDanhSachCM.Rows[i].FindControl("lbCateID");
                if (chk.Checked == true)
                {
                   cmc.Category_delete( int.Parse("0" + lblcateid.Text), ref error);
                    numcheck++;
                }
            }
            if (numcheck > 0)
            {
                if (error != "")
                {
                    LoadGridChuyenMuc(0);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + error + "');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Bạn cần chọn ít nhất một Chuyên mục để xóa');", true);

            }
        }
        cmc = null;
    }
    protected void lbtLuu_Click(object sender, EventArgs e)
    {

    }
}
