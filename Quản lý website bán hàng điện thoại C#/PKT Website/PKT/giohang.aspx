<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="PKT.giohang3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="same">
        <div id="ch">
        <div id="tt-o" class="style2">CHỌN HÀNG</div>
        <div id="tt-o" class="style2">THANH TOÁN</div>
        <div id="tt-o" class="style2">XÁC NHẬN</div>
        </div>
        <div id="same-1"> <p><strong>GIỎ HÀNG</strong></p> </div>
        <div id="gh1-1"> <b>Hình SP</b> </div>
        <div id="gh1-2"> <b>Tên Sản Phẩm</b> </div>
        <div id="gh1-3"> <b>Giá Bán</b> </div>
        <div id="gh1-4"> <b>SL</b> </div>
        <div id="gh1-5"> <b>KM</b> </div>
        <div id="gh1-6"> <b>Thành Tiền</b> </div>
        <div id="gh1-7"> <b>Xóa</b> </div>
                    
        <asp:Repeater ID="data" runat="server">
            <ItemTemplate>
                <div id="gh2-1"> <img src="<%# Eval("HinhAnh") %>"/> </div>
                <div id="gh2-2"> <p><%# Eval ("TenSP") %></p> </div>
                <div id="gh2-3"> <p><%# Eval("GiaBan","{0:0,000}") %></p> </div>
                <div id="gh2-4"> <p><asp:TextBox ID="count" Text=<%# Eval("SLBan") %> runat="server"></asp:TextBox></p> </div>
                <div id="gh2-5"> <p>0</p> </div>
                <div id="gh2-6"> <p><%# Eval("ThanhTien", "{0:0,000}")%></p> </div>
                <div id="gh2-7"> <p><asp:CheckBox ID="delete" runat="server" /></p> </div>
            </ItemTemplate>
        </asp:Repeater>
                    
        <div id="gh4"> Tổng giá trị đơn hàng: 
            <asp:Label ID="tong" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div id="gh5"> &nbsp;<asp:Button ID="update" runat="server" 
                onclick="update_Click" Text="Cập Nhật" />
            <a href="index.aspx"><input type="button" value="Tiếp tục mua hàng" /></a>
            </br> &nbsp;<asp:Button ID="buttom_order" runat="server" 
                onclick="buttom_order_Click" Text="Đặt hàng" />
            <br />
            <asp:Label ID="info" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
