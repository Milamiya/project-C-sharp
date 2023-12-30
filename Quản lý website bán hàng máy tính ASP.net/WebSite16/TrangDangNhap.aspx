<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrangDangNhap.aspx.cs" Inherits="TrangDangNhap" Title="Untitled Page" %>
<asp:Content ID="ct1" ContentPlaceHolderID="Conten0" runat="server">

<div id="menu2" >
<table style="color:White;  margin-top:-3px;" cellpadding=2px>
<tr>
<td>
 <asp:Image ID="Image1" ImageUrl=   "~/image/yahoo_icon.png" runat="server" /> 
</td>
<td>
<a href="#" class="menu2a">
Chăm sóc khách hàng
</a>
</td>
<td>
<asp:Image ID="Image2" ImageUrl="~/image/login_icon.png"  runat=server   /> 
</td>
<td>
<a href="#" class="menu2a">
<asp:LinkButton ID="btnDangNhap" Text="Đăng nhập" CssClass="menu2a" runat="server" 
        ></asp:LinkButton>
</a>
</td>
<td>
<asp:Image ID="Image3" ImageUrl="~/image/register.png" runat=server   /> 
</td>
<td>
<%--<a href="#" class="menu2a">--%>
<asp:LinkButton ID="btnDangKy" Text="Đăng ký" CssClass="menu2a" runat="server" 
     ></asp:LinkButton>
<%--</a>--%>
</td>
<td> 
<asp:Image ID="Image4" ImageUrl="~/image/job_icn.png"   runat="server" /> 
</td>
<td>
<a href="#" class="menu2a">
Thông tin tuyển dụng
</a></td>
<td> <asp:Image ID="Image5" ImageUrl="~/image/giohang2.jpg" runat="server" /> </td>
<td><asp:LinkButton ID=btnGioHangCuaBan CssClass="menu2a" Text="Giỏ hàng của bạn" runat=server></asp:LinkButton></td>
</tr></table>
</div>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="tieudedssanpham">

    <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp ĐĂNG NHẬP </b></p>
</div>

<div id="tieudedssanphambenphai" style="width:353px">
</div>
<div id="dssanpham" style="height:200px; width:600px; right: 396px;">
<table width=600px align="center" style="text-align:right">
<tr>
<td>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
</td>

</tr>
<tr>
<td>
Nếu đã có tài khoản: Xin mời quý khách hàng đăng nhập</td>
</tr>
<tr>
<td>
&nbsp;User name:
</td>
<td><asp:TextBox ID=txtUser runat=server Width="172px"></asp:TextBox></td>
</tr>
<tr>
<td>
Mật khẩu:
</td>
<td>
<asp:TextBox ID=txtPass runat=server Width=172px TextMode="Password"></asp:TextBox>
</td>

</tr>
<tr>
<td><asp:Button ID=bntDangNhap runat=server Text="Đăng nhập" 
        onclick="bntDangNhap_Click" /></td></tr>
</table>
<br />
Nếu quý khách quên mật khẩu: Bấm vào đây để lấy lại mật khẩu 
<br />
Nếu chưa đăng ký: Vui lòng đăng ký tài khoản tại đây 
</div>
</asp:Content>

