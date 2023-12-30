<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xacnhan.aspx.cs" Inherits="PKT.xaxnhan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 209px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="same">
        <div id="xn">
        <div id="tt-o" class="style2">CHỌN HÀNG</div>
        <div id="tt-o" class="style2">THANH TOÁN</div>
        <div id="tt-o" class="style2">XÁC NHẬN</div>
        </div>
        <div id="same-1"> <p>ĐƠN HÀNG CỦA BẠN</p> </div>
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
                <div id="gh2-4"> <p><%# Eval("SLBan") %></p> </div>
                <div id="gh2-5"> <p>0</p> </div>
                <div id="gh2-6"> <p><%# Eval("ThanhTien", "{0:0,000}")%></p> </div>
                <div id="gh2-7"> </div>
            </ItemTemplate>
        </asp:Repeater>
                    
        <div id="gh4"> Tổng giá trị đơn hàng: 
            <asp:Label ID="tong" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div id="same-1"> <p><strong>THÔNG TIN NGƯỜI ĐẶT HÀNG</strong></p>
            <p>
                <table style="width:100%; font-size: large;">
                    <tr>
                        <td class="style1" style="text-align: right">
                            Họ Tên:</td>
                        <td>
                            <asp:Label ID="ten" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            CMND:</td>
                        <td>
                            <asp:Label ID="cmnd" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Địa Chỉ:</td>
                        <td>
                            <asp:Label ID="dc" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Số Điên Thoại</td>
                        <td>
                            <asp:Label ID="sdt" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Email</td>
                        <td>
                            <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Ghi Chú</td>
                        <td>
                            <asp:Label ID="gc" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br /> </p>
        
            <div id="r3"><asp:Button ID="xacnhan" runat="server" Text="Xác nhận" 
                onclick="xacnhan_Click" />
            &nbsp;
            <asp:Button ID="edit" runat="server" Text="Chỉnh sửa" onclick="edit_Click" /></div>
            <div id="r3">PKTPhone.com cam kết áp dụng mức bảo mật cao nhất thông tin Quý khách đặt hàng.</div> 
    </div>
 </div>
</asp:Content>
