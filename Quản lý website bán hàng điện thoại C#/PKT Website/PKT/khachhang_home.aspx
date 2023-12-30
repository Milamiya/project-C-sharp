<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="khachhang_home.aspx.cs" Inherits="PKT.khachhang_home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 162px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="same">
    <div>
   <ul id="menucushome">
        <li><a id="a2" href="khachhang_home.aspx">Thông tin cá nhân</a></li>
        <li><a id="a1" href="khachhang_thaydoithongtin.aspx">Thay đổi thông tin</a></li>
        <li><a id="a1" href="khachhang_lichsu.aspx">Lịch sử mua hàng</a></li>
   </ul> 
   </div>
   <div id="same-1"><table style="width: 94%;">
       <tr>
           <td class="style1">
               Họ tên:</td>
           <td>
               <asp:Label ID="ten" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Ngày sinh:</td>
           <td>
               <asp:Label ID="ngsinh" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Giới tính:</td>
           <td>
               <asp:Label ID="gt" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Số CMND:</td>
           <td>
               <asp:Label ID="cmnd" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Địa chỉ:</td>
           <td>
               <asp:Label ID="dc" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Số điện thoại:</td>
           <td>
               <asp:Label ID="sdt" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Email:</td>
           <td>
               <asp:Label ID="email" runat="server"></asp:Label>
           </td>
       </tr>
       </table>
    </div>
</div>

</asp:Content>
