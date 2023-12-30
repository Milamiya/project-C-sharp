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
using System.Net;
using System.Net.Mail;

public partial class admin_QuenMatKhau : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void butXacNhan_Click(object sender, EventArgs e)
    {
        User US = new User();
        MaHoa mh = new MaHoa();
        DataTable dtb = US.TruyVan_User(txtTenDN.Text.Trim() + "", txtEmail.Text.Trim() + "");
        //
        ////
        SmtpClient SmtpServer = new SmtpClient();
        SmtpServer.Credentials = new System.Net.NetworkCredential("fly_bboy_pro@yahoo.com", "mat khau");
        SmtpServer.Port = 587;
        SmtpServer.Host = "smtp.gmail.com";
        SmtpServer.EnableSsl = true;
        MailMessage omail = new MailMessage();
        if (dtb.Rows.Count > 0)
        {
            try
            {
                omail.From = new MailAddress("fly_bboy_pro@yahoo.com", "Admin Control Panel", System.Text.Encoding.UTF8);
                omail.To.Add(txtEmail.Text);
                omail.Subject = "Mật khẩu quản trị";
                omail.Body = "Mật khẩu của bạn là:" + mh.Decrypt("tk6se", dtb.Rows[0]["Password"] + "");
                omail.Priority = MailPriority.High;
                omail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                omail.ReplyTo = new MailAddress(txtEmail.Text);
                lblThongBao.Text = "Mật khẩu được gửi thành công";
                SmtpServer.Send(omail);

            }
            catch (Exception ex)
            {
                Response.Write("Send failure: " + ex.ToString());
            }
        }
        else
        {
            lblThongBao.Text = "Tên đăng nhập hoặc Email bạn nhập chưa đúng";

        }
        US = null;
        mh = null;
    }
}
