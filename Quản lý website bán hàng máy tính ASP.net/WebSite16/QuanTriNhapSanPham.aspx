<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="QuanTriNhapSanPham.aspx.cs" Inherits="QuanTriNhapSanPham" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <div id="tieudenhap">
 <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp QUẢN LÝ SẢN PHẨM</b></p>
</div>
<div id="Nhap" >

   <table id="TTNhap" style="font-weight: bold; text-align:right; margin-left:35px; margin-top:25px">
     <tr>
      <td>Tên sản phẩm:</td>
      <td class="khoangcach"></td>
      <td><asp:DropDownList ID="txtTenSP" runat=server Width="184px"></asp:DropDownList></td>
      
         <td>Hình ảnh:</td>
         <td class="khoangcach"></td>
         <td><asp:FileUpload ID="FileUpload1" runat="server" Width="184px" /></td>
     </tr>
     <tr>
       <td>Loại sản phẩm:</td>
       <td class="khoangcach"></td>
       <td><asp:DropDownList ID="txtLoaiSP" runat=server Width="184px"></asp:DropDownList></td>
     </tr>
     <tr>
        <td>Nhà sản xuất:</td>
        <td class="khoangcach"></td>
        <td> <asp:DropDownList ID="txtNhaSanXuat" runat=server Width="184px"></asp:DropDownList></td>
     </tr>
        <tr>
          <td>Thông số kỹ thuật:</td>
          <td class="khoangcach"></td>
         <td> <asp:TextBox ID="txtThongSoKyThuat" Width="180px" Height="100px" runat=server ></asp:TextBox></td>
     
         <td>Ảnh minh họa:</td>
         <td class="khoangcach"></td>
         <td><asp:Image id="hinhanh" runat="server" Width="100px" Height="100px" BorderStyle=Solid/></td>
     </tr>
     <tr>
         <td>Nhà cung cấp:</td>
         <td class="khoangcach"></td>
         <td>
             <asp:DropDownList ID="txtKhuyenMai0" runat="server" Width="184px" 
                 EnableTheming="True"></asp:DropDownList> 
         </td>
     </tr>
     <tr>
         <td>Giá nhập:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtGiaNhap" runat="server" Width=180px></asp:TextBox></td>
     </tr> 
     <tr>
         <td>Số lượng:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtSoLuong" runat=server  Width="180px"></asp:TextBox></td>
         
     </tr>
     <tr>
         <td>Thông tin khuyến mại:</td>
         <td class="khoangcach"></td>
         <td><asp:DropDownList ID="txtKhuyenMai" runat="server" Width="184px" 
                 EnableTheming="True"></asp:DropDownList> </td>
     </tr>
    <tr>
         <td>Chế độ bảo hành:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtBaoHanh" runat="server" Width="180px" Height="60px"></asp:TextBox> </td>
         </tr>
     
   
   </table>
<hr />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
<asp:Button ID="btnNhap" Text="Nhập" Width="80px"  runat="server"/> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnSua" Text="Sửa" runat="server" Width="80px" />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnXoa" Text="Xóa" Width="80px" runat=server />
<hr />
<div id="tieudevuanhap">
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp SẢN PHẨM NHẬP </b></p>
        
</div>
<div id="sanphamvuanhap">
</div>
</div>
</asp:Content>

