<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="QuanlyBanner.aspx.cs" Inherits="GiaoDien_QuanlyBanner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="padding-top:10px;border-style:groove">
<h3 style="padding-left:100px; height: 30px; border-bottom-style:groove">
THÊM MỚI BANNER
</h3>
<table >
<TR>
<td style="text-align:right" class="style1">
Mã banner:

</td><br />
<td class="style4">
    
    <asp:TextBox ID="txtMa" runat="server" Height="25px" Width="171px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator>
</td>
</TR>&nbsp &nbsp
<tr>
<td style="text-align:right" class="style1">
Tên banner
</td >
<td class="style4">
    <asp:TextBox ID="txtTen" runat="server" Height="25px" Width="171px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td style="text-align:right" class="style3">
Ngày đăng ảnh:
</td ><br />
<td class="style5">
    <asp:DropDownList ID="ddlNgay" Width="50px" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlThang" Width="50px" runat="server">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlNam" Width="70px" runat="server">
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td style="text-align:right">
Ảnh:
</td ><br />
<td class="style6">
    <asp:FileUpload ID="Fluanh" runat="server" Height="20px" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td class="style7">
</td>
<td class="style8">
    <asp:Button ID="btnThem" runat="server" Text="Thêm mới" Width="81px" 
        Height="30px" onclick="btnThem_Click" />
</td>
</tr>
</table>

</div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    
    <style type="text/css">
        .style1
        {
            height: 35px;
        }
        .style3
        {
            height: 32px;
        }
        .style4
        {
            height: 35px;
            width: 405px;
        }
        .style5
        {
            height: 32px;
            width: 405px;
        }
        .style6
        {
            width: 405px;
        }
        .style7
        {
            height: 12px;
        }
        .style8
        {
            width: 405px;
            height: 12px;
        }
    </style>

    
</asp:Content>
