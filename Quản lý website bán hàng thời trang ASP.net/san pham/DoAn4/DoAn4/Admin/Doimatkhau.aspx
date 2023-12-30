<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Doimatkhau.aspx.cs" Inherits="DoAn4.Admin.WebForm19" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style2
    {
        font-size: medium;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
        text-align: center;
    }
    .style3
    {
        width: 100%;
        height: 110px;
    }
    .style4
    {
        width: 382px;
        text-align: right;
        font-weight: normal;
        font-size: small;
    }
    .style5
    {
        width: 382px;
        text-align: right;
        font-weight: normal;
        font-size: small;
        height: 27px;
    }
    .style6
    {
        height: 27px;
        text-align: left;
    }
    .style7
    {
        text-align: left;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style2">
    ĐỔI MẬT KHẨU<hr width="60%" />
    <div>
        <table cellpadding="0" cellspacing="0" class="style3">
            <tr>
                <td class="style5">
                    Tài khoản:</td>
                <td class="style6">
&nbsp;
                    <asp:TextBox ID="txtTK" runat="server" Width="200px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Mật khẩu cũ:</td>
                <td class="style7">
&nbsp;
                    <asp:TextBox ID="txtMKcu" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    Mật khẩu mới:</td>
                <td class="style7">
&nbsp;
                    <asp:TextBox ID="txtMKM" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Xác nhận mật khẩu mới:</td>
                <td class="style7">
&nbsp;
                    <asp:TextBox ID="txtXN" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <div style="height: 61px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" style="font-size: small; color: #0000FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDoi" runat="server" onclick="btnDoi_Click" Text="Đồng ý" 
                Width="60px" />
        </div>
    </div>
</div>
</asp:Content>
