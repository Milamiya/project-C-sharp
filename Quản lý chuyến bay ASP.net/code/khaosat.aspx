<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="khaosat.aspx.cs" Inherits="khaosat" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Style="z-index: 100;
        left: 361px; position: absolute; top: 201px" Text="THÔNG TIN KHẢO SÁT"></asp:Label>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="z-index: 102; left: 256px;
        position: absolute; top: 234px" Text="Mời bạn vui lòng điền vào mẫu khảo sát của chúng tôi."
        Width="368px"></asp:Label>
    <table style="z-index: 100; left: 215px; position: absolute; top: 267px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Họ tên"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Số điện thoại"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Địa chỉ"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Chất lượng chuyến bay"
                    Width="157px"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="125px">
                    <asp:ListItem>Tốt</asp:ListItem>
                    <asp:ListItem>Kh&#225;</asp:ListItem>
                    <asp:ListItem>Trung b&#236;nh</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Chất lượng nhân viên phục vụ"
                    Width="199px"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="126px">
                    <asp:ListItem>Tốt</asp:ListItem>
                    <asp:ListItem>Kh&#225;</asp:ListItem>
                    <asp:ListItem>Chưa tốt</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Giá vé"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList3" runat="server" Width="127px">
                    <asp:ListItem>Đắt</asp:ListItem>
                    <asp:ListItem>B&#236;nh thường</asp:ListItem>
                    <asp:ListItem>Rẻ</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Bạn muốn cải  thiện"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>Th&#225;i độ nh&#226;n vi&#234;n</asp:ListItem>
                    <asp:ListItem>Số chuyến bay</asp:ListItem>
                    <asp:ListItem>Số chỗ ngồi</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Ý kiến cá nhân"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="Không rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hoàn tất" /></td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

