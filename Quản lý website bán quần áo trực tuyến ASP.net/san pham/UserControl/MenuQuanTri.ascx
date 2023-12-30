<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuQuanTri.ascx.cs" Inherits="UserControl_MenuQuanTri" %>
<link href="../CSS/QuanTri.css" rel="Stylesheet" type="text/css" />

<div id="menutrai">
    <div class="khungtrai-top">
        Danh mục quản lý</div>
    <ul id="menuQT">
        <li><a href="#">Quản lý nhà sản xuất</a></li>
        <li><a href="#">Quản lý loại sản phẩm</a></li>
        <li><a href="#">Quản lý chi tiết sản phẩm</a></li>
        <li><a href="#">Quản lý Khách hàng</a></li>
        <li><a href="#">Cập nhật tin tức</a></li>
        <li><a href="#">Quản lý hỗ trợ khách hàng</a></li>
        <li><span><a href="#">Quản lý đơn hàng</a></span>
            <ul id="menucon">
                <li><a href="../GiaoDien/DonHangChuaXuLy.aspx">Đơn hàng chưa xử lý</a></li>
                <li><a href="../GiaoDien/DonHangDaXuLy.aspx">Đơn hàng xử lý thành công</a></li>
                <li><a href="../GiaoDien/DonHangKhongXuLy.aspx">Đơn hàng xử lý không thành công</a></li>            
            </ul>
        </li>
        <li><a href="#">Quản lý sản phẩm khuyến mãi</a>
            <ul id="menucon">
                <li><a href="#">Nhập sản phẩm khuyến mãi</a></li>
            </ul>
        </li>
        <li><a href="#">Quản lý PTTT</a></li>
        <li><a href="#">Quản lý báo giá</a></li>
        <li><a href="#">Thống kê - tìm kiếm</a></li>     
    </ul>
</div>