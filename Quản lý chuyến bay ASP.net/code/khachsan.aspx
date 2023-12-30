<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="khachsan.aspx.cs" Inherits="khachsan" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White"
        Style="z-index: 100; left: 380px; position: absolute; top: 199px" Text="TÌM KHÁCH SẠN"></asp:Label>
    <table style="z-index: 100; left: 297px; position: absolute; top: 238px">
        <tr>
            <td style="width: 109px; height: 30px">
                <asp:Label ID="Label2" runat="server" Text="Thành phố (tỉnh)" Font-Bold="True" Width="109px"></asp:Label></td>
            <td style="width: 100px; height: 30px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>H&#224; Nội</asp:ListItem>
                    <asp:ListItem>Hồ Ch&#237; Minh</asp:ListItem>
                    <asp:ListItem>Đ&#224; Nẵng</asp:ListItem>
                    <asp:ListItem>Huế</asp:ListItem>
                    <asp:ListItem>Nha Trang</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px; height: 30px">
            </td>
        </tr>
        <tr>
            <td style="width: 109px; height: 30px">
                <asp:Label ID="Label3" runat="server" Text="Hạng" Font-Bold="True"></asp:Label></td>
            <td style="width: 100px; height: 30px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="98px">
                    <asp:ListItem>5 sao</asp:ListItem>
                    <asp:ListItem>4 sao</asp:ListItem>
                    <asp:ListItem>3 sao</asp:ListItem>
                    <asp:ListItem>Dưới 2 sao</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px; height: 30px">
            </td>
        </tr>
        <tr>
            <td style="width: 109px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" Text="Tìm kiếm" OnClick="Button1_Click" /></td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <asp:Image ID="Image5" runat="server" ImageUrl="~/hinh anh/67.jpg" Style="z-index: 101;
        left: 153px; position: absolute; top: 353px" />
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White"
        Style="z-index: 102; left: 401px; position: absolute; top: 361px" Text="THÔNG TIN"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
        Style="z-index: 104; left: 156px; position: absolute; top: 401px" Width="592px">
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</asp:Content>

