<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangky.aspx.cs" Inherits="demo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp; &nbsp;
    <table style="z-index: 100; left: 273px; position: absolute; top: 236px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Tên đăng nhập" Font-Bold="True"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Không được rỗng" Width="111px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="Mật khẩu" Font-Bold="True"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Không được rỗng" Width="119px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Text="Nhập lại mật khẩu" Width="125px" Font-Bold="True"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="147px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2"
                    ControlToValidate="TextBox3" ErrorMessage="Nhập lại không đúng" Width="127px"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label4" runat="server" Text="E-mail" Font-Bold="True"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="E-mail không hợp lệ" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Width="127px"></asp:RegularExpressionValidator></td>
        </tr>
    </table>
    <table style="z-index: 101; left: 276px; position: absolute; top: 403px; width: 407px;">
        <tr>
            <td style="width: 665px">
                <asp:Label ID="Label5" runat="server" Text="Họ tên" Font-Bold="True"></asp:Label></td>
            <td style="width: 137px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            <td style="width: 128px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="Không được rỗng" Width="112px"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 665px">
                <asp:Label ID="Label6" runat="server" Text="Ngày sinh" Font-Bold="True"></asp:Label></td>
            <td style="width: 137px">
                <asp:TextBox ID="TextBox6" runat="server" Width="149px"></asp:TextBox></td>
            <td style="width: 128px">
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="Không hợp lệ" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td style="width: 665px">
                <asp:Label ID="Label7" runat="server" Text="Giới tính" Font-Bold="True"></asp:Label></td>
            <td style="width: 137px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Nam</asp:ListItem>
                    <asp:ListItem>Nữ</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 128px">
            </td>
        </tr>
        <tr>
            <td style="width: 665px">
                <asp:Label ID="Label8" runat="server" Text="Nơi ở" Font-Bold="True"></asp:Label></td>
            <td style="width: 137px">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
            <td style="width: 128px">
            </td>
        </tr>
        <tr>
            <td style="width: 665px">
                <asp:Label ID="Label9" runat="server" Text="Nghề nghiệp" Font-Bold="True"></asp:Label></td>
            <td style="width: 137px">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
            <td style="width: 128px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Đăng ký" style="z-index: 100; left: 159px; position: absolute; top: 145px" /></td>
        </tr>
    </table>
    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Larger" Style="z-index: 100;
        left: 380px; position: absolute; top: 199px" Text="THÔNG TIN ĐĂNG KÍ" ForeColor="White"></asp:Label>
    <asp:Image ID="Image5" runat="server" ImageUrl="~/hinh anh/67.jpg" Style="z-index: 101;
        left: 153px; position: absolute; top: 357px" />
    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Larger" Style="z-index: 103;
        left: 383px; position: absolute; top: 366px" Text="THÔNG TIN BỔ SUNG"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
        <asp:ListItem>0</asp:ListItem>
    </asp:DropDownList>
</asp:Content>

