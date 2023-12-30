<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="doihinhnen.aspx.cs" Inherits="doihinhnen" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <table>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Đổi banner trên" Width="107px"></asp:Label></td>
            <td style="width: 100px">
    <asp:FileUpload ID="FileUpload1" runat="server" /></td>
            <td style="width: 100px">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hoàn tất" /></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Đổi banner dưới" Width="111px"></asp:Label></td>
            <td style="width: 100px">
                <asp:FileUpload ID="FileUpload2" runat="server" /></td>
            <td style="width: 100px">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Hoàn tất" /></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/trangadmin.aspx">Về trang admin</asp:HyperLink>
</asp:Content>

