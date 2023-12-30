<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="khachhang_thaydoithongtin.aspx.cs" Inherits="PKT.khachhang_thaydoithongtin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 140px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="same">
    <div>
   <ul id="menucushome">
        <li><a id="a1" href="khachhang_home.aspx">Thông tin cá nhân</a></li>
        <li><a id="a3" href="khachhang_thaydoithongtin.aspx">Thay đổi thông tin</a></li>
        <li><a id="a1" href="khachhang_lichsu.aspx">Lịch sử mua hàng</a></li>
   </ul> 
   </div>
   <div id="same-1">THAY ĐỔI THÔNG TIN CÁ NHÂN<br />
       <table style="width: 94%;">
       <tr>
           <td class="style1">
               Họ tên:</td>
           <td>
               <asp:TextBox ID="ten" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="ten_TextChanged"></asp:TextBox>
               <asp:Label ID="e5" runat="server" style="font-style: italic; color: #FF0000"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Ngày sinh:</td>
           <td>
               &nbsp;<asp:DropDownList ID="ngay" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ngay_SelectedIndexChanged" Width="40px" 
                        TabIndex="2">
                    </asp:DropDownList>
&nbsp;<asp:DropDownList ID="thang" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="thang_SelectedIndexChanged" Width="40px" 
                        TabIndex="3">
                    </asp:DropDownList>
&nbsp;<asp:DropDownList ID="nam" runat="server" Width="60px" TabIndex="4">
                    </asp:DropDownList>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Giới tính:</td>
           <td>
               <asp:RadioButton ID="gtnam" runat="server" GroupName="gt" Text="Nam" />
               <asp:RadioButton ID="nu" runat="server" GroupName="gt" Text="Nữ" />
           </td>
       </tr>
       <tr>
           <td class="style1">
               Số CMND:</td>
           <td>
               <asp:TextBox ID="cmnd" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="cmnd_TextChanged"></asp:TextBox>
               <asp:Label ID="e6" runat="server" style="color: #FF0000; font-style: italic"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Địa chỉ:</td>
           <td>
               <asp:TextBox ID="dc" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="dc_TextChanged"></asp:TextBox>
               <asp:Label ID="e7" runat="server" style="color: #FF0000; font-style: italic"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Số điện thoại:</td>
           <td>
               <asp:TextBox ID="sdt" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="sdt_TextChanged"></asp:TextBox>
               <asp:Label ID="e8" runat="server" style="color: #FF0000; font-style: italic"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Email:</td>
           <td>
               <asp:TextBox ID="email" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="email_TextChanged"></asp:TextBox>
               <asp:Label ID="e9" runat="server" style="font-style: italic; color: #FF0000"></asp:Label>
           </td>
       </tr>
       </table>
       <br />
       <asp:Button ID="sumit" runat="server" style="text-align: left" 
           Text="Thay đổi" onclick="sumit_Click" />
       <asp:Label ID="e10" runat="server" style="font-style: italic; color: #FF0000"></asp:Label>
       <br />
       <br />
       THAY ĐỔI MẬT KHẨU<br />

       <table style="width: 94%;">
       <tr>
           <td class="style1">
               Mật khẩu cũ:</td>
           <td>
               <asp:TextBox ID="pass" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="pass_TextChanged"></asp:TextBox>
               <asp:Label ID="e1" runat="server" style="font-style: italic; color: #FF0000"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Mật khẩu mới:</td>
           <td>
               <asp:TextBox ID="passnew" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="passnew_TextChanged"></asp:TextBox>
               <asp:Label ID="e2" runat="server" style="font-style: italic; color: #FF0000"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="style1">
               Nhập lại mật khẩu mới:</td>
           <td>
               <asp:TextBox ID="cofirm" runat="server" Width="268px" AutoPostBack="True" 
                   ontextchanged="cofirm_TextChanged"></asp:TextBox>
               <asp:Label ID="e3" runat="server" style="color: #FF0000; font-style: italic"></asp:Label>
           </td>
       </tr>
       </table>
       <br />
       <asp:Button ID="sumit2" runat="server" style="text-align: left" 
           Text="Thay đổi" onclick="sumit2_Click" />
       <asp:Label ID="e4" runat="server" style="font-style: italic; color: #FF0000"></asp:Label>
    </div>
</div>


</asp:Content>
