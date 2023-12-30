<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangtinmoi.aspx.cs" Inherits="dangtinmoi" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Font-Underline="False"
        ForeColor="White" Style="z-index: 100; left: 406px; position: absolute; top: 199px"
        Text="ĐĂNG TIN MỚI"></asp:Label>
    <table style="z-index: 100; left: 241px; position: absolute; top: 235px">
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label2" runat="server" Text="Mã chuyến bay"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label3" runat="server" Text="Tên chuyến bay"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label4" runat="server" Text="Giá vé phổ thông" Width="106px"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label5" runat="server" Text="Giá vé thương gia" Width="108px"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label6" runat="server" Text="Hình ảnh"></asp:Label></td>
            <td style="width: 100px">
                <asp:FileUpload ID="FileUpload1" runat="server" /></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px; height: 110px">
                <asp:Label ID="Label7" runat="server" Text="Ngày đăng"></asp:Label></td>
            <td style="width: 100px; height: 110px">
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
            <td style="width: 100px; height: 110px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label8" runat="server" Text="Lịch bay"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Thứ 2-4-6</asp:ListItem>
                    <asp:ListItem>Thứ 3-5-7</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label9" runat="server" Text="Giờ bay"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>6h00-10h00-14h00</asp:ListItem>
                    <asp:ListItem>8h00-12h00-16h00</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label10" runat="server" Text="Thông tin tóm tắt"></asp:Label></td>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 100;
                    left: 186px; position: absolute; top: 432px" Text="Đăng tin mới" Width="100px" />
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 106px">
                <asp:Label ID="Label11" runat="server" Text="Thông tin chi tiết"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/trangadmin.aspx" Style="z-index: 100;
                    left: 325px; position: absolute; top: 435px" Width="101px">Về trang admin</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

