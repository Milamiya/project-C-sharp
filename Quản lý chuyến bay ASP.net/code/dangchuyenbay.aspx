<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangchuyenbay.aspx.cs" Inherits="dangchuyenbay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 100; left: 370px;
        position: absolute; top: 200px" Text="ĐĂNG CHUYẾN BAY MỚI"></asp:Label>
    <table style="z-index: 100; left: 321px; position: absolute; top: 236px">
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Mã chuyến bay"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Nơi đi"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Nơi đến"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Ngày đi"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Sunday</asp:ListItem>
                    <asp:ListItem>Monday</asp:ListItem>
                    <asp:ListItem>Tuesday</asp:ListItem>
                    <asp:ListItem>Wednesday</asp:ListItem>
                    <asp:ListItem>Thursday</asp:ListItem>
                    <asp:ListItem>Friday</asp:ListItem>
                    <asp:ListItem>Saturday</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px; height: 28px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Giờ đi"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="95px">
                    <asp:ListItem>1h00</asp:ListItem>
                    <asp:ListItem>2h00</asp:ListItem>
                    <asp:ListItem>3h00</asp:ListItem>
                    <asp:ListItem>4h00</asp:ListItem>
                    <asp:ListItem>5h00</asp:ListItem>
                    <asp:ListItem>6h00</asp:ListItem>
                    <asp:ListItem>7h00</asp:ListItem>
                    <asp:ListItem>8h00</asp:ListItem>
                    <asp:ListItem>9h00</asp:ListItem>
                    <asp:ListItem>10h00</asp:ListItem>
                    <asp:ListItem>11h00</asp:ListItem>
                    <asp:ListItem>12h00</asp:ListItem>
                    <asp:ListItem>13h00</asp:ListItem>
                    <asp:ListItem>14h00</asp:ListItem>
                    <asp:ListItem>15h00</asp:ListItem>
                    <asp:ListItem>16h00</asp:ListItem>
                    <asp:ListItem>17h00</asp:ListItem>
                    <asp:ListItem>18h00</asp:ListItem>
                    <asp:ListItem>19h00</asp:ListItem>
                    <asp:ListItem>20h00</asp:ListItem>
                    <asp:ListItem>21h00</asp:ListItem>
                    <asp:ListItem>22h00</asp:ListItem>
                    <asp:ListItem>23h00</asp:ListItem>
                    <asp:ListItem>24h00</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px; height: 28px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Giá phổ thông"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Giá thương gia" Width="104px"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox7"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Chỗ phổ thông"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox8"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 28px">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Chỗ thương gia"></asp:Label></td>
            <td style="width: 100px; height: 28px">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 28px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox9"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hoàn tất" /></td>
            <td style="width: 100px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/trangadmin.aspx">Về trang admin</asp:HyperLink></td>
        </tr>
    </table>
</asp:Content>

