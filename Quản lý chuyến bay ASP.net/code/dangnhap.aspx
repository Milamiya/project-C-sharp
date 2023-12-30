<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangnhap.aspx.cs" Inherits="dangnhap" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 326px; position: absolute;
        top: 235px" Text="Tên đăng nhập" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 101; left: 471px; position: absolute;
        top: 233px"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 328px; position: absolute;
        top: 266px" Text="Mật khẩu" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 103; left: 471px; position: absolute;
        top: 266px" TextMode="Password" Width="148px"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" Style="z-index: 104;
        left: 368px; position: absolute; top: 198px" Text="THÔNG TIN ĐĂNG NHẬP" Width="223px" ForeColor="White"></asp:Label>
    <asp:Button ID="Button1" runat="server" Style="z-index: 105; left: 439px; position: absolute;
        top: 302px" Text="Đăng nhập" OnClick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
        ErrorMessage="Không rỗng" Style="z-index: 109; left: 636px; position: absolute;
        top: 266px" Width="73px"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
        ErrorMessage="Không rỗng" Style="z-index: 107; left: 635px; position: absolute;
        top: 234px" Width="77px"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Style="z-index: 108; left: 350px; position: absolute;
        top: 337px" Text="Mời bạn nhập tên đăng nhập và mật khẩu" Width="256px"></asp:Label>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
</asp:Content>

