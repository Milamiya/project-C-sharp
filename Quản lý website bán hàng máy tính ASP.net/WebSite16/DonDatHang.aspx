<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DonDatHang.aspx.cs" Inherits="DonDatHang" Title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Label style="margin-left:30px; margin-top:30px" Text="Gửi đơn hàng" runat="server"></asp:Label>
<br />
<img src="image/dondathang.jpg" />
<div style="border-style:solid; border-width:thin">
Đơn hàng:
    <asp:GridView style="margin-top:5px" ID="GridView1" runat="server" 
        Width="1018px" Height="77px" AutoGenerateColumns="False" 
        onrowdatabound="GridView1_RowDataBound" ondatabound="GridView1_DataBound">
        <RowStyle  ForeColor='#000066' />
    <Columns>
    <asp:BoundField DataField="MaSanPham" HeaderText="Mã sản phẩm"  />
       <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
       <asp:BoundField  DataField="SoLuong" HeaderText="Số lượng" />
       
        <asp:TemplateField>
        <HeaderTemplate>
        <asp:Label Text="Giá bán" runat="server" ></asp:Label>
        </HeaderTemplate>
        <ItemTemplate>
        <asp:Label ID="lblDonGia" runat="server" Text='<%# Eval("DonGia") %>' ></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
    </Columns>

        <HeaderStyle BackColor="#000066" ForeColor="White" />
        
    </asp:GridView>
    Tổng tiền: <asp:Label ID="lblTongTien" runat="server"></asp:Label>
    </div>
 <div style="border-style:solid; border-width:thin; margin-top:30px">
 Thông tin khách hàng:
 <table>
 <tr>
 <td>Tên khách hàng:</td><td><asp:Label ID="lblTenKH" runat="server"></asp:Label></td>
 </tr>
 <tr><td>Địa chỉ:</td><td><asp:Label ID="lblDiaChi" runat="server"></asp:Label></td></tr>
 <tr>
 <td>Email:</td><td><asp:Label ID="lblEmail" runat="server"></asp:Label> </td>
 </tr>
 <tr>
 <td>Số điện thoại:</td><td><asp:Label ID="lblSoDienThoai" runat="server"></asp:Label></td>
 </tr>
 </table>
 </div> 
 <div style="border-style:solid; border-width:thin; margin-top:30px">
 Yêu cầu khách hàng:
 <br />
     <textarea id="TextArea1" 
         style="height: 135px; width: 534px; margin-bottom: 4px" runat="server"></textarea>
         
         <br />
         
         <asp:Button ID="btnGui" Text="Gửi đặt hàng-->" runat="server" onclick="btnGui_Click" 
          />
 </div>  
</asp:Content>

