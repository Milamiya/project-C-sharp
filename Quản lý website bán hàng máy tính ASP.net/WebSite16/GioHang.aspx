<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GioHang.aspx.cs" Inherits="GioHang" Title="Untitled Page" %>
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
        onclick="btnDangNhap_Click" ></asp:LinkButton>
</a>
</td>
<td>
<asp:Image ID="Image3" ImageUrl="~/image/register.png" runat=server   /> 
</td>
<td>
<%--<a href="#" class="menu2a">--%>
<asp:LinkButton ID="btnDangKy" Text="Đăng ký" CssClass="menu2a" runat="server" 
        onclick="btnDangKy_Click"></asp:LinkButton>
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
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp GIỎ HÀNG </b></p>
</div>

<div id="tieudedssanphambenphai" style="width:353px">
</div>
<div id="dssanpham" style="height :auto; width:600px; right: 395px;">
<div id=grv style="margin-top:10px">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="LinqDataSource1" 
        AutoGenerateColumns="False" Height="49px" HorizontalAlign="Center" 
        style="margin-right: 21px" Width="584px" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        ForeColor="#000066">
        <RowStyle HorizontalAlign="Center" />
    <Columns>
    <asp:BoundField DataField="MaSanPham" HeaderText="Mã sản phẩm" ReadOnly="True" 
            SortExpression="MaSanPham" />
            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
        <asp:TemplateField HeaderText="Số lượng">
        <ItemTemplate>
        <asp:TextBox runat="server" Width="50px" ID="txtSoLuong" Text='<%# Eval("SoLuong") %>' ></asp:TextBox>
        </ItemTemplate>
        
        </asp:TemplateField>
            
   
           <asp:BoundField DataField="DonGia" HeaderText="Đơn giá" />
          
<asp:CommandField  HeaderText="Xóa" SelectText="Xóa"  ShowSelectButton="true" />
    </Columns>
        <HeaderStyle BackColor="#000066" ForeColor="White" />
    </asp:GridView>
    </div>
    <table id=tbl 
        style="margin-left:100px; width: 410px; height: 57px; margin-bottom: 7px;">
    <tr>
    <td>Tổng tiền thanh toán</td>
    <td><asp:Label ID="lblTongTien" runat="server" Font-Overline="False" 
            Font-Strikeout="False"></asp:Label>
        </td></tr>
   <td><asp:ImageButton ID="btnCapNhap" ImageUrl="~/image/cart_capnhatgiohang.gif" 
           runat=server onclick="btnCapNhap_Click" />
    <td><asp:ImageButton ID="btnDatHang" ImageUrl="~/image/cart_dathang.gif" 
            runat="server" onclick="btnDatHang_Click" style="height: 19px" /></td>
   <td><asp:ImageButton ID="btnIn" ImageUrl="~/image/print_bill.gif" runat=server 
           Height="19px" Width="115px" /></td>
    </table>
    <br />
    Bấm vào <asp:LinkButton ID=lbtMuaTiep Text="đây" runat="server" 
        onclick="lbtMuaTiep_Click"></asp:LinkButton> để tiếp tục mua hàng
        <br />
        Bấm vào 
    <asp:LinkButton ID=LinkButton1 Text="đây" runat="server" onclick="LinkButton1_Click" 
        ></asp:LinkButton> để xem đơn đặt hàng của bạn.
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="WedMayTinhDataContext" onselecting="LinqDataSource1_Selecting" 
     >
    </asp:LinqDataSource>
    
</div>
</asp:Content>

