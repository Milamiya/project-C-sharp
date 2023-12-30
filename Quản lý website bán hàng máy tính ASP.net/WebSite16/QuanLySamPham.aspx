<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="QuanLySamPham.aspx.cs" Inherits="QuanLySamPham" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <div id="tieudenhap">
 <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp QUẢN LÝ SẢM PHẨM</b></p>
</div>
<div id="Nhap"  style="height:auto">
<div id="eror" style="margin-top:10px">
<table id="tberor">
<tr>

    <td><asp:CustomValidator ID="CustomValidator8" runat="server" 
            ErrorMessage="CustomValidator" 
            onservervalidate="CustomValidator8_ServerValidate"></asp:CustomValidator></td>
    
    <td><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
</tr>
<tr>
    <td><asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>

    <td><asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
</tr>
<tr>
    <td><asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
    
   <td> <asp:CustomValidator ID="CustomValidator5" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
 </tr>
 <tr>
    <td><asp:CustomValidator ID="CustomValidator6" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
    
    <td><asp:CustomValidator ID="CustomValidator7" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
   </tr>
    </table>
    </div>
   <table id="TTNhap" style="font-weight: bold; text-align:right; margin-left:10px;">
     <tr>
      <td>Số hóa đon:</td>
      <td class="khoangcach"></td>
      <td> 
          <cc1:ComboBox ID="txtSoHD" runat="server" Width="158px"  
                 style="margin-top:0px; z-index:100; " AutoCompleteMode="SuggestAppend" 
                  RenderMode="Block" DropDownStyle="Simple" >
             </cc1:ComboBox></td>
             <td><a href=QuanLyHoaDonNhap.aspx style="text-decoration:none">Tạo mới một hóa đơn </a>
            </td>
      
     </tr>
     <tr>
      <td>Tên sản phẩm:</td>
      <td class="khoangcach"></td>
      <td> <cc1:ComboBox ID="txtTenSP"   Font-Names="Times New Roman" runat="server" Width="158px"  
                 style="margin-top:0px; z-index:100; " AutoCompleteMode="SuggestAppend" 
                  RenderMode="Block" 
              onselectedindexchanged="txtTenSP_SelectedIndexChanged" >
             </cc1:ComboBox></td>
       <td>Loại sản phẩm:</td>
       <td class="khoangcach"></td>
       <td> <cc1:ComboBox ID="txtLoaiSP" runat="server" Width="158px"  Font-Names="Times New Roman" 
                 style="margin-top:0px; z-index:100; " AutoCompleteMode="SuggestAppend" 
                  RenderMode="Block" >
           <asp:ListItem>Lap top</asp:ListItem>
           <asp:ListItem>Linh kiện máy tính</asp:ListItem>
           <asp:ListItem>Máy tính bàn</asp:ListItem>
           <asp:ListItem></asp:ListItem>
             </cc1:ComboBox></td>
      
     </tr>
     <tr>
        <td>Nhà sản xuất:</td>
        <td class="khoangcach"></td>
        <td>  <cc1:ComboBox ID="txtNhaSanXuat" runat="server" Width="158px"  
                 style="margin-top:0px; z-index:100; " AutoCompleteMode="SuggestAppend" 
                  RenderMode="Block" >
             </cc1:ComboBox></td>
            
         <td>Hình ảnh:</td>
         <td class="khoangcach"></td>
         <td><asp:FileUpload ID="FileUpload1" runat="server" Width="184px" /></td>
     </tr>
        <tr>
          <td>Thông số kỹ thuật:</td>
          <td class="khoangcach"></td>
         <td> <asp:TextBox ID="txtThongSoKyThuat" Width="180px" Height="100px" runat=server ></asp:TextBox></td>
     
         <td>Ảnh minh họa:
         <br /><asp:Button ID="btnupload" runat="server" Text="UpLoad" 
                 onclick="btnupload_Click" />
                                </td>
         <td class="khoangcach"></td>
         <td><asp:Image id="hinhanh" runat="server" Width="181px" Height="100px" 
                 BorderStyle=Solid /></td>
     </tr>
     <tr>
         <td >Nhà cung cấp:</td>
         <td class="khoangcach" ></td>
         <td>
             <cc1:ComboBox ID="txtNhaCungCap" runat="server" Width="158px"  
                 style="margin-top:0px; z-index:100; " AutoCompleteMode="SuggestAppend" 
                  RenderMode="Block" >
             </cc1:ComboBox>
         </td>
         
         <td >Giá nhập:</td>
         <td class="khoangcach" ></td>
         <td ><asp:TextBox ID="txtGiaNhap" runat="server" Width=180px></asp:TextBox></td>
     </tr>
     <tr>
         <td>Số lượng:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtSoLuong" runat=server  Width="180px" ></asp:TextBox></td>
        
         <td>&nbsp;</td>
         <td class="khoangcach"></td>
         <td> &nbsp;</td>
         
     </tr>
    <tr>
         <td>Chế độ bảo hành:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtBaoHanh" runat="server" Width="180px" Height="60px"></asp:TextBox> </td>
       <td>Ghi chú:</td>
         <td class="khoangcach"></td>
         <td><asp:TextBox ID="txtGhichu" runat="server" Width="180px" Height="60px"></asp:TextBox> </td>
       
         </tr>
     
   
   </table>
<hr />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
<asp:Button ID="btnNhap" Text="Nhập" Width="80px"  runat="server" 
        onclick="btnNhap_Click"/> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button 
        ID="btnSua" Text="Sửa" runat="server" Width="80px" onclick="btnSua_Click" />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnXoa" Text="Xóa" Width="80px" 
        runat="server" onclick="btnXoa_Click" />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" Text="Làm mói" 
        Width="80px" runat="server" onclick="Button1_Click" />
<hr />
<div id="tieudevuanhap">
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp HÓA ĐON HIỆN TẠI </b></p>
        
</div>
<div id="sanphamvuanhap" style="height:500px">
 <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        onselecting="LinqDataSource1_Selecting">
    </asp:LinqDataSource>
    <asp:GridView ID="GridView3" 
        style="margin-top:10px; margin-left:5px; text-align:center" runat="server" 
        Width="739px"   AllowPaging="True" 
        AllowSorting="True" DataSourceID="LinqDataSource1" 
        AutoGenerateColumns="false" 
        onselectedindexchanged="GridView3_SelectedIndexChanged" >
            <Columns>
            <asp:BoundField DataField="MaSanPham" HeaderText="MaSanPham" />
    <asp:BoundField DataField="TenNhaCungCap" HeaderText="Tên nhà cung cấp" />
    <asp:BoundField DataField="SoLuongNhap" HeaderText="Số luong nhập" />
    <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
    <asp:BoundField DataField="NgayNhap" HeaderText="Ngày nhập" />
    <asp:BoundField DataField="GiaNhap" HeaderText="Giá nhập" />
    <asp:BoundField DataField="SoHoaDon" HeaderText="Số hóa đon" />
    <asp:BoundField DataField="Ghichu" HeaderText="Ghi chú" />
    <asp:CommandField HeaderText="Chọn"  SelectText="Chọn" ShowSelectButton="true" />
    </Columns>

        
    </asp:GridView>




</div>
<div id="tieudetatcasanpham" >
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp TẤT CẢ SẢN PHẨM </b></p></div>

<div id="tatcasanpham"  style="height:auto">

   
    <asp:LinqDataSource ID="LinqDataSource2" runat="server" 
        ContextTypeName="WedMayTinhDataContext" TableName="SanPhams">
    </asp:LinqDataSource>

   
    <asp:GridView style="margin-top:10px; margin-left:5px; text-align:center" 
        ID="GridView2" runat="server" Width="739px" AutoGenerateColumns="False" 
        AllowPaging="True" AllowSorting="True" PageSize="3" 
          PagerStyle-HorizontalAlign="Center" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        DataSourceID="LinqDataSource2" >
<PagerSettings Mode="NumericFirstLast"></PagerSettings>
    <Columns>
    <asp:BoundField DataField="MaSanPham" HeaderText="Mã sản phẩm" />
    <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
    <asp:BoundField DataField="LoaiSP" HeaderText="Loại sản phẩm" />
    <asp:BoundField DataField="NhaSanXuat" HeaderText="Nhà sản xuất" />
    <asp:BoundField DataField="BaoHanh" HeaderText="Bảo hành" />
    <asp:BoundField DataField="SoLuong" HeaderText="Số luong" />
    <asp:BoundField DataField="ThongSoKyThuat" HeaderText="Thông số kỹ thuật" />
    <asp:BoundField DataField="GiaBan" HeaderText="Giá bán" />
    <asp:ImageField DataImageUrlField="HinhAnh" HeaderText="Hình ảnh"></asp:ImageField>
    <asp:BoundField DataField="GhiChu" HeaderText="Ghi chú" />
    </Columns>

<PagerStyle HorizontalAlign="Center"></PagerStyle>
    </asp:GridView>

    </div>
</div>

<script language="javascript" type="text/javascript">
// <!CDATA[

function Select1_onclick() {

}

// ]]>
</script>
</asp:Content>


