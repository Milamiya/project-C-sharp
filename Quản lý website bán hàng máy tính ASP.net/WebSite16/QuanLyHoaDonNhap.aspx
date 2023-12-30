<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="QuanLyHoaDonNhap.aspx.cs" Inherits="QuanLyHoaDonNhap" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="tieudenhap">
 <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp QUẢN HÓA ĐON NHẬP</b></p>
</div>
<div id="Nhap" >
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
    <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
   <table id="TTNhap" style="font-weight: bold; text-align:right; margin-left:35px; margin-top:25px">
     <tr>
     
      <td>Số hóa đơn:</td>
      <td class="khoangcach"></td>
      <td><asp:TextBox ID="txtSoHD" runat=server Width="184px" Enabled="False">Số hóa đơn 
          tự tăng</asp:TextBox>
      
        <td>Ngày nhập</td>
        <td class="khoangcach" style="width: 91px"><asp:TextBox ID="txtNgayNhap" runat="server" Width="184px"></asp:TextBox></td>
      
     </tr>
   
   </table>
<hr />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
<asp:Button ID="btnNhap" Text="Nhập" Width="80px"  runat="server" onclick="btnNhap_Click"/> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button 
        ID="btnSua" Text="Sửa" runat="server" Width="80px" onclick="btnSua_Click" />
&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnXoa" Text="Xóa" Width="80px" 
        runat=server onclick="btnXoa_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button 
        ID="btnLamMoi" Text="Làm mói" Width="80px" 
        runat=server onclick="btnLamMoi_Click" />
<hr />
<div id="tieudevuanhap">
<p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp TẤT CẢ HÓA ĐON </b></p>
        
</div>
<div id="sanphamvuanhap">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" DataSourceID="LinqDataSource1" 
        AutoGenerateColumns="false" Width="739px" 
        style="margin-left:5px; margin-top:10px; text-align:center" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        
        <Columns>
<asp:BoundField  DataField="SoHoaDon"  HeaderText="Số hóa đon" />
<asp:BoundField DataField="NgayNhap" HeaderText="Ngày nhập" />
<asp:BoundField DataField="HoTen" HeaderText="Nhân viên nhập" />
<%--<asp:BoundField DataField="TongTienHoaDon" HeaderText="Tổng tiền nhập" />--%>
<asp:CommandField  HeaderText="Chọn" SelectText="Chọn"  ShowSelectButton="true" />
</Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        onselecting="LinqDataSource1_Selecting">
    </asp:LinqDataSource>
</div>
</div>
</asp:Content>

