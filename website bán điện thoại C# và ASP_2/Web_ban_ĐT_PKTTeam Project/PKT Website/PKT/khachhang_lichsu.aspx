<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="khachhang_lichsu.aspx.cs" Inherits="PKT.khachhang_lichsu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="same">
    <div>
   <ul id="menucushome">
        <li><a id="a1" href="khachhang_home.aspx">Thông tin cá nhân</a></li>
        <li><a id="a1" href="khachhang_thaydoithongtin.aspx">Thay đổi thông tin</a></li>
        <li><a id="a4" href="khachhang_lichsu.aspx">Lịch sử mua hàng</a></li>
   </ul> 
   
   <div id="same-1">HÓA ĐƠN CỦA BẠN</div>     
   </div>
        <asp:Repeater ID="data" runat="server">
        <ItemTemplate>
        <div id="ls1"> <strong>Mã hóa đơn: </strong><%# Eval ("MaHDBan") %> <strong>Ngày: </strong><%# Eval ("NgayBan") %> <strong>Tình trạng: </strong><%# Eval ("TinhTrang") %>
        <br /><strong>Chi tiết: </strong></div>
        <div id="gh1-1"> <b>Hình SP</b> </div>
        <div id="gh1-2"> <b>Tên Sản Phẩm</b> </div>
        <div id="gh1-3"> <b>Giá Bán</b> </div>
        <div id="gh1-4"> <b>SL</b> </div>
        <div id="gh1-5"> <b>KM</b> </div>
        <div id="gh1-6"> <b>Thành Tiền</b> </div>
        <div id="gh1-7"> <b>Xóa</b> </div>
            <asp:Repeater ID="detail" runat="server">
                <ItemTemplate>
                    <div id="gh2-1"> <img src="<%# Eval("HinhAnh") %>"/> </div>
                    <div id="gh2-2"> <p><%# Eval ("TenSP") %></p> </div>
                    <div id="gh2-3"> <p><%# Eval("GiaBan","{0:0,000}") %></p> </div>
                    <div id="gh2-4"> <p><%# Eval("SLBan") %></p> </div>
                    <div id="gh2-5"> <p>0</p> </div>
                    <div id="gh2-6"> <p><%# Eval("ThanhTien", "{0:0,000}")%></p> </div>
                    <div id="gh2-7"> <p></p> </div>
                </ItemTemplate>
            </asp:Repeater>
        </ItemTemplate>
        </asp:Repeater>
        <div id="same-1">a</div>
</div>

</asp:Content>
