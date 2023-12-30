<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="QuanLyNhaCungCap.aspx.cs" Inherits="QuanLyNhaCungCap" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="tieudenhap">
 <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp QUẢN LÝ NHÀ CUNG CẤP</b></p>
</div>
<div id="Nhap" >
<div id=eror style="margin-top:10px; margin-left:100px;">
    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="Tên nhà cung cấp đã tồn tại" ControlToValidate="txtTenNhaCungCap" 
        onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <br />
    <asp:CustomValidator ID="CustomValidator3" runat="server" 
        ErrorMessage="Tên nhà cung cấp không để trống"  
        onservervalidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
        <br />
    <asp:CustomValidator ID="CustomValidator2" runat="server" 
        ErrorMessage="Số điện thoại không đúng định dạng" 
        onservervalidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
        
</div>

   <table id="TTNhap" style="font-weight: bold; text-align:right; margin-left:35px; margin-top:0px">
   
    <tr>
      <td>Mã nhà cung cấp:</td>
      <td class="khoangcach"></td>
      <td><asp:TextBox ID="txtMaNhaCungCap" runat=server Width="184px" Enabled="false" 
              ontextchanged="txtMaNhaCungCap_TextChanged"></asp:TextBox></td>
      <td>
          Tên nhà cung cấp:</td>
      <td class="khoangcach"></td>
      <td><asp:TextBox ID="txtTenNhaCungCap" runat=server Width="184px"></asp:TextBox></td>
     </tr>
    
     <tr>
        <td>Địa chỉ:</td>
        <td class="khoangcach"></td>
        <td> <asp:TextBox ID="txtDiaChi" runat=server Height=70px Width="184px"></asp:TextBox></td>
      
       <td>Số điện thoại:</td>
       <td class="khoangcach"></td>
       <td><asp:TextBox ID="txtSoDienThoai" runat=server Width="184px"></asp:TextBox></td>
     </tr>
   
   </table>
<hr />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
<asp:Button ID="btnNhap" Text="Nhập" Width="80px"  runat="server" onclick="btnNhap_Click"/> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button 
        ID="btnSua" Text="Sửa" runat="server" Width="80px" onclick="btnSua_Click" />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnXoa" Text="Xóa" Width="80px" 
        runat=server onclick="btnXoa_Click" />
        
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" Text="Làm mói" Width="80px" 
        runat=server onclick="Button1_Click" />
<hr />
<div id="tieudevuanhap">
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp TẤT CẢ NHÀ CUNG CẤP </b></p>
        
</div>
<div id="sanphamvuanhap">
<div id="divgrd" style=" margin-left:20px; margin-top:20px">
<asp:GridView ID="grdNhaCungCap" runat="server" Width="700px"   style="text-align:center"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="false" AllowSorting="true" AllowPaging="true" PageSize="20">
<Columns>
<asp:BoundField  DataField="MaNhaCungCap"  HeaderText="Mã nhà cung cấp" />
<asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
<asp:BoundField DataField="SoDienThoai" HeaderText="Số điện thoại" />
<asp:BoundField DataField="TenNhaCungCap" HeaderText="Tên nhà cung cấp" />
<asp:CommandField  HeaderText="Chọn" SelectText="Chọn"  ShowSelectButton="true" />
</Columns>
</asp:GridView>
</div>
</div>
</div>


</asp:Content>

