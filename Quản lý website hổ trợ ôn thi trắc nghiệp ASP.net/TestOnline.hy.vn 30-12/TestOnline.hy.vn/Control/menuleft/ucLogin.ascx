<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="TestOnline.hy.vn.Control.ucLogin" %>
<link href="../../Style/style.css" rel="stylesheet" type="text/css" />

<script src="../../Js/crawler.js" type="text/javascript"></script>

<style type="text/css">
    .LI_Khung1_DN
    {
        width: 215px;
        height: 170px;
        border: solid 1px gray;
        border-bottom-left-radius: 6px;
        border-bottom-right-radius: 6px;
    }
    .LI_Head1_DN
    {
        width: 217px;
        background-image: url(       '../Images/Control/ucMenuLeft/left_heading_img.jpg' );
        height: 37px;
        text-align: center;
        color: White;
    }
    .LI_Text1
    {
        width: 120px;
        float: left;
        padding-bottom: 5px;
    }
    .LI_Lable1
    {
        color: Blue;
        padding-left: 5px;
        width: 75px;
        font: 500 13px Arial;
        float: left;
        padding-bottom: 5px;
    }
    .LI_Pass1
    {
        float: left;
        color: Blue;
        margin-top: 5px;
        margin-left: 10px;
        text-decoration: none;
    }
    .LI_Pass1:hover
    {
        color: Red;
    }
    .Mau1
    {
        color: Purple;
        margin-left: 30px;
        color: #000066;
        width: 80px;
        margin-top: 5px;
        height: 22px;
        background-image: url(      '../Images/Control/ucLogIn/icon_Blog26.png' );
        background-repeat: no-repeat;
        float: left;
        text-align: center;
    }
    .Mau1:hover
    {
        color: Red;
    }
    .hover_lable
    {
        color: Blue;
    }
    .hover_lable:hover
    {
        color: Red;
    }
</style>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
        <asp:Panel runat="server" ID="pnHide">
            <div class="LI_Head1_DN">
                <p style="padding-top: 10px; color: White; width: 215px; height: auto">
                    Đăng nhập</p>
            </div>
            <div class="LI_Khung1_DN">
                <br />
                <div class="LI_Lable1">
                    Tài khoản :</div>
                <div class="LI_Lable1">
                    <asp:TextBox runat="server" Width="120px" ID="txtUsename"></asp:TextBox></div>
                <div class="LI_Lable1">
                    Mật khẩu :</div>
                <div class="LI_Lable1">
                    <asp:TextBox runat="server" Width="120px" ID="txtPass"></asp:TextBox></div>
                <div style="margin-left: 10px;">
                    <asp:Button runat="server" Text="Đăng nhập" Width="80px" OnClick="Unnamed1_Click" />
                    &nbsp
                    <asp:Button ID="Button1" Width="80px" runat="server" Text="Đăng ký" OnClick="Button1_Click" /></div>
                 <div  style="width:180px; color:Black">
                    <asp:Label runat="server" ID="lblHienThi" Text="Nhập đầy đủ các thông tin"></asp:Label>
                 </div>
                <div style="padding-top: 10px">
                    <a class="LI_Pass1" href="" style="margin-top: -4px">Quên mật khẩu ?</a> &nbsp
                    <asp:CheckBox runat="server" ID="chkCheck" Text="Ghi nhớ" /></div>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Panel runat="server" ID="pnShow">
            <div class="LI_Head1">
                <p style="padding-top: 10px; color: White; width: 215px; height: auto">
                    Thông tin tài khoản</p>
            </div>
            <div style="width: 215px; padding-top: 10px; height: 80px; border: solid 1px gray;
                border-bottom-left-radius: 6px; border-bottom-right-radius: 6px;">
                <div style="float: left; width: 10px">
                    <img src="../../Images/offline.png" /></div>
                <div style="float: left; padding-left: 9px; text-align: left; width: 190px">
                    <asp:Label runat="server" ID="lblUserName"></asp:Label></div><br />
                <div style="float: left; width: 10px">
                    <img src="../../Images/offline.png" /></div>
                <div style="float: left; padding-left: 9px; text-align: left; width: 190px">
                    <a class="hover_lable" href="ChangePassword.aspx">Đổi mật khẩu</a></div><br />
                <div style="float: left; width: 10px">
                    <img src="../../Images/offline.png" /></div>
                <div style="float: left; padding-left: 9px; text-align: left; width: 190px">
                    <a class="hover_lable" href="#">
                        <asp:LinkButton runat="server" ID="lblLink" Text="Đăng xuất" OnClick="lblLink_Click"></asp:LinkButton></a></div><br />
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
