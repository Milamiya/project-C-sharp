<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="LienHe.aspx.cs" Inherits="LienHe" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style type="text/css">
        .hoidap
        {
            text-align: left;
            margin-top: 5px;
            font-weight: bold;
            background-color: #0071b7;
            color: #FFFFFF;
            font-size: 13px;
            padding-top: 5px;
            padding-left: 5px;
        }
        .bovien
        {
            border: solid 1px #4497cb;
            text-align: left;
            margin-top: 2px;
        }
    </style>
    <div>
        <img src="Images/Designs/contact.png">
    </div>
    <table style="padding-top: 10px; padding-left: 20px;">
        <tbody>
            <tr>
                <td>
                    <b><font color="#3333CC">XIN VUI LÒNG LIÊN HỆ VỚI CHÚNG TÔI THEO ĐỊA CHỈ SAU:</font></b>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        <br>
                        <b>Công ty vật liệu xây dựng
                            <br>
                            <br>
                            Địa chỉ: Dãy nhà 2 tầng - Tòa nhà ABC<br>
                            Dân Tiến - Khoái Châu - Hưng Yên<br>
                            Điện thoại: 0321-713.319 / 0321-713.153<br>
                            <br>
                    </p>
                    <center>
                        Các cơ sở trực thuộc:</center>
                    <br>
                    <b>Cơ sở Hải Dương</b><br>
                    (+84) 320.3894.540<br>
                    Địa chỉ: 189 Nguyễn Lương Bằng - Phường Thanh Bình - TP Hải Dương - Hải Dương<br>
                    <br>
                    <b>Cơ sở Phố Nối</b><br>
                    Địa chỉ: Nhân Hoà - Mỹ Hào - Hưng Yên
                    <br>
                    <br>
                    <strong>Quản trị mạng:</strong><br>
                    (+84) 321.713.152
                    <br>
                    E-mail: <a href="mailto:admin@utehy.edu.vn">vatlieuxaydung.com</a><br>
                    Website: <a href="vatlieuxaydung.com">http://vatlieuxaydung.com</a><br>
                    <br>
                    <p>
                    </p>
                    <p>
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
    <br />
    <br />
    <br />
    <td colspan="2">
        <form class="form-validate" id="emailForm" name="emailForm" method="post" action="/index.php?option=com_contact&amp;view=contact&amp;id=1&amp;Itemid=22">
        <div class="contact_email">
            <label for="contact_name">
                &nbsp;Tên bạn:
            </label>
            <br>
            <input type="text" value="" class="inputbox" style="width: 340px;" id="contact_name"
                name="name">
            <br>
            <label for="contact_email" id="contact_emailmsg">
                &nbsp;Địa chỉ email:
            </label>
            <br>
            <input type="text" maxlength="100" class="inputbox required validate-email" value=""
                style="width: 340px;" name="email" id="contact_email">
            <br>
            <label for="contact_subject">
                &nbsp;Tiêu đề thông điệp:
            </label>
            <br>
            <input type="text" value="" class="inputbox" style="width: 340px;" id="contact_subject"
                name="subject">
            <br>
            <br>
            <label for="contact_text" id="contact_textmsg">
                &nbsp;Nội dung thông điệp:
            </label>
            <br>
            <textarea class="inputbox required" id="contact_text" name="text" rows="10" style="width: 340px;"></textarea>
            <br>
            <br>
            <button type="submit">
                Gửi</button><br>
        </div>
        <input type="hidden" value="com_contact" name="option">
        <input type="hidden" value="contact" name="view">
        <input type="hidden" value="1" name="id">
        <input type="hidden" value="submit" name="task">
        <input type="hidden" value="1" name="931a584e264874441f23277e1110b80b">
        </form>
        <br>
    </td>
    </div> </div>
</asp:Content>
