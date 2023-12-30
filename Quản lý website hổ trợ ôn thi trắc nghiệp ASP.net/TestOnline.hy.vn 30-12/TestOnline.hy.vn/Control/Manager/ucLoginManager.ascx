<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLoginManager.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.Manager.ucLoginManager" %>
<style type="text/css">
    .LI_Khung1_XH
    {
        padding-top: -5px;
        width: 350px;
        height: 130px;
        border: solid 1px gray;
        border-bottom-left-radius: 6px;
        border-bottom-right-radius: 6px;
        position:inherit;
    }
    .LI_Head1_XH
    {
        margin-top: 10px;
        width: 352px;
        background-image: url(          '../Images/nav_bg.gif' );
        height: 30px;
        text-align: center;
        color: White;
        background-repeat: repeat-x;
        border-top-left-radius: 6px;
        border-top-right-radius: 6px;
        font:500 16px Arial;
        padding-top:5px;
       
    }
</style>
<div style="text-align: center;width:355px; margin-left:auto; margin-right:auto">
    <div class="LI_Head1_XH">
            Đăng nhập hệ thống
    </div>
    <div class="LI_Khung1_XH">
        <div style="padding-top: 5px">
            <table width="100%" cellspacing="5px">
                <tr>
                    <td style="width: 160px; padding-right: 5px" align="right">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Black">Tên đăng nhập:</asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtUserName" runat="server" TextMode="SingleLine" Width="180px"
                            TabIndex="1">haitk61</asp:TextBox>
                    </td>
                    <td align="left">
                        <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txtUserName"
                            ErrorMessage="*" ToolTip="Tên đăng nhập không được nhập rỗng"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 160px" align="right" style="padding-right: 5px">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Black">Mật khẩu:</asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="180px" TabIndex="2">123456</asp:TextBox>
                    </td>
                    <td align="left">
                        <asp:RequiredFieldValidator ID="rfvPass" runat="server" ControlToValidate="txtPass"
                            ErrorMessage="*" ToolTip="Mật khẩu không được nhập rỗng"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right" valign="middle">
                        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td align="center" valign="middle">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" Width="85px" Style="margin-right: 2px;"
                            OnClick="btnDangNhap_Click" TabIndex="4" ToolTip="Đăng nhập " />
                        <asp:Button ID="btnHuybo" runat="server" OnClick="btnHuybo_Click" Text="Hủy bỏ" Width="85px"
                            TabIndex="5" />
                    </td>
                    <td align="left">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
