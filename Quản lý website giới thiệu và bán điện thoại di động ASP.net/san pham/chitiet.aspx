<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="chitiet.aspx.cs" Inherits="Default3" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center; color: black"><h1><b>CHI TIẾT SẢN PHẨM</b></h1><br />
        <table style="width: 100%">
            <tr>
                <td colspan="2" style="font-size: medium; text-align: left">
                <asp:Label ID="lblTenSP" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td rowspan="6" style="width: 115px">
                <asp:Image ID="imgSP" runat="server" Height="137px" Width="122px" />
                </td>
                <td style="font-size: medium; text-align: left">
                    <asp:HyperLink ID="HyperLink16" runat="server">Đặc tính kỹ thuật</asp:HyperLink>
&nbsp;|
                    <asp:HyperLink ID="HyperLink18" runat="server">Thông tin bảo hành</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                <asp:Label ID="lblMoTa" runat="server" style="font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: left; font-size: medium">
                Trong kho:
                <asp:Label ID="lblKho" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                <asp:Label ID="lbbh" runat="server" Text="Bảo hành:" style="font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; text-align: left; height: 12px">
                Giá:
                <asp:Label ID="lblGia" runat="server"></asp:Label>
                &nbsp;VNĐ<br />
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; text-align: left; height: 15px">
                Khuyến mại
                <asp:Label ID="lblkm" runat="server"></asp:Label><br />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="20px" ImageUrl="~/Images/Chonmua.jpg"
                     Width="64px" onclick="ImageButton2_Click" 
                    oncommand="ImageButton2_Command" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

