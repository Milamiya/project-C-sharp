<%@ Page Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true"
    CodeBehind="DangNhap.aspx.cs" Inherits="DoAn4.WebForm4" Title="Đăng nhập" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: right;
        }
        #txtDN
        {
            width: 200px;
        }
        #Text1
        {
            width: 200px;
        }
        .style4
        {
            text-align: center;
        }
        .style8
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            margin-left: 80PX;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Con1" runat="server">
    <div class="daukhungmain">
    <asp:Label ID="Label2" runat="server" Text="ĐĂNG NHẬP" Font-Bold="True"></asp:Label>
</div>
    <asp:Panel ID="Panel1" runat="server">
    <div style="text-align: center; width: 623px; margin-top:10px;">
        <span class="style8">
            <table style="width: 600px">
                <tr>
                    <td class="style3" width="40%">
                        Username:
                    </td>
                    <td class=" tdphai">
                        &nbsp;<asp:TextBox ID="txtUser" runat="server" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Password:
                    </td>
                    <td class=" tdphai">
                        &nbsp;<asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="191px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </span>
    </div>
    <div>
        <center>
            <asp:Label ID="Label1" runat="server" Style="color: #FF0000"></asp:Label><br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="26px" 
                ImageUrl="~/Anh/dangnhap.jpg" Width="112px" onclick="ImageButton1_Click" />
            <br />
        </center>
    </div>
    <br />
    <div class="style4">
        <a href="Dangky.aspx">Đăng ký tài khoản mới</a>
    </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
    <div style=" margin-left:5px; margin-right:5px; margin-top:10px;">
    <p><b>Chào mừng bạn đến với website thời trang <a href="TrangChu.aspx">Thuphuong.com</a>!</b><br />
    Hiện tại giỏ hàng của bạn chưa có sản phẩm nào! Bạn hãy quay về trang chủ để chọn mua quần áo mới về!</p>
    <div style="text-align:right">
    <asp:ImageButton ID="ImageButton2" runat="server" Height="26" Width="183" 
            ImageUrl="Anh/vetrangchu.jpg" 
            PostBackUrl="~/TrangChu.aspx" /></div>
    </div>
</asp:Panel>
   <asp:Panel ID="Panel3" runat="server">
    <div style=" margin-left:5px; margin-right:5px; margin-top:10px;">
    <p><b>Chào mừng bạn đến với website thời trang <a href="TrangChu.aspx">Thuphuong.com</a>!</b><br />
    Hiện tại giỏ hàng của bạn hiện đang có 
        <asp:Label ID="lblGioHang" runat="server" Text="Label"></asp:Label> &nbsp;mặt hàng. Hãy 
        nhấn vào nút tiếp tục để thanh toán!</p> 
        <div class="khungthanhtoan" style="text-align:right; margin-top:1px; margin-bottom:1px">
        <asp:ImageButton ID="ImageButton4" runat="server" Height="26" Width="183" 
            ImageUrl="Anh/vetrangchu.jpg" 
            PostBackUrl="~/TrangChu.aspx" ImageAlign="Left" />
    <asp:ImageButton ID="ImageButton3" runat="server" Height="25px" Width="81px" 
            ImageUrl="~/Anh/tieptuc.jpg"
            PostBackUrl="~/ThanhToan.aspx" ImageAlign="Middle" />
            </div>
    </div>
</asp:Panel> 
</asp:Content>
