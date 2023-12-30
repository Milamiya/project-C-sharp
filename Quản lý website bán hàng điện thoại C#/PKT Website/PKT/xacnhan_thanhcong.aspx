<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xacnhan_thanhcong.aspx.cs" Inherits="PKT.xacnhan_thanhcong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="same">
        <div id="xn-tc">
        <div id="tt-o" class="style2">CHỌN HÀNG</div>
        <div id="tt-o" class="style2">THANH TOÁN</div>
        <div id="tt-o" class="style2">XÁC NHẬN</div>
        </div>
        <div id="same-1"> <p><strong>ĐẶT HÀNG THÀNH CÔNG</strong></p> 
            <span class="style1">Cám ơn Quý khách hàng đã đặt hàng tại PKTPhone.com. Thông tin xác nhận đơn hàng đã được gửi vào email của bạn. Quay về 
            </span> <a href="index.aspx"><span class="style1">trang chủ</span></a><span 
                class="style1"> để tiếp tục mua hàng !
</span>
<br /><span class="style1">Chúng tôi sẽ liên hệ để xác nhận đơn hàng của Quý khách trong vòng 24 giờ tới. Để phục vụ tốt hơn mọi thông tin, yêu cầu, thắc mắc xin quý khách vui lòng liên hệ
            01253.30.3000</span></div>
        
    </div>


</asp:Content>
