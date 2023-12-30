<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="thongtintaikhoan.aspx.cs" Inherits="thongtintaikhoan" Title="Tai khoan cua ban" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="black"
        Text="THÔNG TIN TÀI KHOẢN"></asp:Label>    </center><br />
    &gt;&gt;
    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default.aspx" ForeColor="Blue">Trang chủ</asp:LinkButton><br />&gt;&gt;
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/doimatkhau.aspx" ForeColor="Blue">Đổi mật khẩu</asp:LinkButton>

    <br />
    <table align="center" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td colspan="2" height="30" width="80%">
                <asp:Label ID="lblthongbao" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td height="30" style="width: 32%">
                <asp:Label ID="Label5" runat="server" Text="Họ tên:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblhoten" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td height="30" style="width: 32%">
                <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblemail" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td height="30" style="width: 32%">
                Mật khẩu:</td>
            <td>
                <asp:Label ID="lblmatkhau" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td height="30" style="width: 32%">
                Số CMTND:</td>
            <td>
                <asp:Label ID="lblcmt" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td height="30" style="width: 32%">
                Mã tài khoản:</td>
            <td>
                <asp:Label ID="lblmataikhoan" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td height="30" style="width: 32%">
                <asp:Label ID="Label7" runat="server" Text="Điện thoại:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbldienthoai" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 32%">
                <asp:Label ID="Label8" runat="server" Text="Địa chỉ:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbldiachi" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 32%">
                &nbsp;</td>
            <td>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
        </tr>
    </table>
    <br />
 </asp:Content>

