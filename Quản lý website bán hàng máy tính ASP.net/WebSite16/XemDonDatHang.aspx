<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="XemDonDatHang.aspx.cs" Inherits="XemDonDatHang" Title="Untitled Page" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border-style:solid; border-width:thin">
Đơn hàng:&nbsp;<asp:GridView style="margin-top:50px" ID="GridView1" runat="server" 
        AutoGenerateColumns="False"  Width="560px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
        
        <RowStyle  ForeColor='#000066' />
        <Columns>
            <asp:BoundField DataField="MaDonHang" HeaderText="Mã đơn hàng"  />
            
            <asp:BoundField DataField="TenKhachHang" HeaderText="Tên khách hàng"/>
            <asp:BoundField DataField="NgayDatHang" HeaderText="Ngày đặt hàng"  />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng tiền" />
            <asp:BoundField DataField="TinhTrang" HeaderText="Tình trạng"  />
            <asp:CommandField  HeaderText="Chọn"     SelectText="Chọn"  ShowSelectButton="true" />
        </Columns>
        
        <HeaderStyle BackColor="#000066" ForeColor="White" />
    </asp:GridView>
      <asp:GridView style="margin-top:5px" ID="GridView2" runat="server" 
        Width="781px" Height="77px" AutoGenerateColumns="False" 
       
            Enabled="False">
        <RowStyle  ForeColor='#000066' />
    <Columns>
    <asp:BoundField DataField="MaSanPham" HeaderText="Mã sản phẩm"  />
       <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
       <asp:BoundField  DataField="SoLuong" HeaderText="Số lượng" />
       
        <asp:TemplateField>
        <HeaderTemplate>
        <asp:Label ID="Label1" Text="Giá bán" runat="server" ></asp:Label>
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
         
          <asp:Button style="margin-left:20px " Width=80px ID="btnHuyBo" 
         Text="Hủy bỏ" runat="server" onclick="btnHuyBo_Click" />
          <asp:Button style="margin-left:20px" Width=80px runat="server" ID="btnIn" Text="In đơn hàng" />
 </div> 
</asp:Content>

