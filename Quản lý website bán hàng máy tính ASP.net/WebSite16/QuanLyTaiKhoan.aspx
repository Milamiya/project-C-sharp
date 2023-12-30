<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="QuanLyTaiKhoan.aspx.cs" Inherits="QuanLyTaiKhoan" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="tieudenhap">
 <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp QUẢN LÝ TÀI KHOẢN</b></p>
</div>
<div id="Nhap" >

  <table style=" margin-left:200px" cellpadding="5px">
  <tr>
  <td> <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
   </td>
   <td>
   <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
    </td>
    </tr>
    <tr>
    <td>
    <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
    
    </td>
    <td>
     <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
    </td>
  </tr>
  <tr>
  <td>
  <asp:CustomValidator ID="CustomValidator5" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
  </td>
  <td>
  <asp:CustomValidator ID="CustomValidator6" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
  </td>
  </tr>
  </table>
   
    
    
   
   <table id="TTNhap" style="font-weight: bold; text-align:right; margin-left:35px; margin-top:25px">
    <tr>
    <td>Mã tài khoản:</td>
      <td class="khoangcach"></td>
      <td><asp:TextBox ID="txtMaTK" Text="Mã tự tăng" Enabled="false" runat=server Width="180px"></asp:TextBox></td>
          <td>Ngày sinh</td>
      <td class="khoangcach"></td>
      <td><asp:TextBox ID="txtNgaySinh"  runat=server Width="180px"></asp:TextBox></td>
      
    </tr>
     <tr>
      <td>Tên tài khoản:</td>
      <td class="khoangcach"></td>
      <td><asp:TextBox ID="txtTenTaiKhoan" runat=server Width="180px"></asp:TextBox></td>
       <td>Giói Tính:</td>
          <td class="khoangcach"></td>
         <td> <asp:DropDownList ID="txtGioiTinh" Width="185px"  runat=server >
             <asp:ListItem>Nam</asp:ListItem>
             <asp:ListItem>Nữ</asp:ListItem>
             <asp:ListItem>Khác</asp:ListItem>
             </asp:DropDownList></td>
      
     </tr>
     <tr>
       <td>Mật khẩu:</td>
       <td class="khoangcach"></td>
       <td><asp:TextBox ID="txtMatKhau" runat=server Width="180px" TextMode="Password"></asp:TextBox></td>
       
         <td>Số điện thoại:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtSoDienThoai" runat="server" Width="180px"></asp:TextBox></td>
     </tr>
         <tr>
         <td>Vị trí:</td>
         <td class="khoangcach"></td>
         <td><asp:DropDownList ID="txtViTri" runat="server" Width="185px" >
             <asp:ListItem>Admin</asp:ListItem>
             <asp:ListItem>Nhân viên nhập hàng</asp:ListItem>
             <asp:ListItem>Nhân viên bán hàng</asp:ListItem>
             <asp:ListItem>Nhân viên thống kê</asp:ListItem>
             </asp:DropDownList> </td>
         
         <td>Địa chỉ:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtDiaChi" runat="server" Width=180px></asp:TextBox></td>
         </tr>
     <tr>
        <td>Tên nhân viên:</td>
        <td class="khoangcach"></td>
        <td> <asp:TextBox ID="txtTenNhanVien" runat=server Width="180px"></asp:TextBox></td>
        
        <td>Hình ảnh:</td>
        <td class="khoangcach"></td>
        <td><asp:FileUpload ID="txtHinhAnh" runat=server Width="185px"  /></td>
     </tr>
    <tr>
    <td>Phân quyền: </td>
    <td class="khoangcach"></td>
    <td style="float:left"> 
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" TextAlign="Left">
            <asp:ListItem>Quản lý nhập hàng</asp:ListItem>
            <asp:ListItem>Quản lí mặt hàng</asp:ListItem>
            <asp:ListItem>Quản lí khuyến mãi</asp:ListItem>
            <asp:ListItem>Quản lí tài khoản</asp:ListItem>
            <asp:ListItem>Quản lí nhà cung cấp</asp:ListItem>
            <asp:ListItem>Quản lí đon hàng</asp:ListItem>
            <asp:ListItem>Thống kê</asp:ListItem>
        </asp:CheckBoxList>
        </td>
        <td><asp:Button ID="btnUpload" Text="UpLoad" runat="server" 
                onclick="btnUpload_Click" /></td>
        <td class="khoangcach"></td>
        <td>
        <asp:Image ImageUrl="~/image/DefaultFriendIcon.png" Height="172px" Width="173px" ID="hinhanh" runat=server />
 </td>
    </tr>

     
   
   </table>
  
<hr />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
<asp:Button ID="btnNhap" Text="Nhập" Width="80px"  runat="server" 
        onclick="btnNhap_Click"/> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button 
        ID="btnSua" Text="Sửa" runat="server" Width="80px" onclick="btnSua_Click" />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnXoa" Text="Xóa" Width="80px" 
        runat=server onclick="btnXoa_Click" />
<hr />
<div id="tieudevuanhap">
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp TẤT CẢ TÀI KHOẢN</b></p>
        
</div>
<div id="sanphamvuanhap" >
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:WEDMAYTINHConnectionString1 %>" 
        onselecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [NhanVien]"></asp:SqlDataSource>
    <div style="margin:10px; text-align:center">
     <asp:GridView ID="GridView1" runat="server" Height="180px" Width="724px" 
        DataSourceID="SqlDataSource1" AutoGenerateColumns="false"
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
<asp:BoundField  DataField="MaNhanVien"  HeaderText="Mã nhân viên" />
<asp:BoundField DataField="HoTen" HeaderText="Họ tên" />
<asp:BoundField DataField="GioiTinh" HeaderText="Giới tính" />
<asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
<asp:BoundField DataField="SoDienThoai" HeaderText="Số điện thoại" />

<asp:BoundField DataField="ViTri" HeaderText="Vị trí" />

<asp:BoundField DataField="TenDangNhap" HeaderText="Tên đăng nhập" />

<asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" />

<asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" />

<asp:ImageField DataImageUrlField ="HinhAnh" HeaderText="Hình ảnh" />
<asp:CommandField  HeaderText="Chọn" SelectText="Chọn"  ShowSelectButton="true" />
</Columns> 
    </asp:GridView>
    </div>
</div>
</div>

</asp:Content>

