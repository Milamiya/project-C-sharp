<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menungang.ascx.cs" Inherits="UserControl_Menungang" %>
<link href="../CSS/Menu.css" rel="Stylesheet" type="text/css"/>
<div style="width:980px">
<div class="banner">
    <asp:Image ImageUrl="~/Image/banner9.jpg" runat="server" ID="anhnen" Width="980px" Height="150px" />
</div>
<div id="menungang">
    <ul id="top">
        <li><a href="../GiaoDien/Trangchu.aspx"title="menuitem1">trang chủ</a></li>
        <li><a href="#" title="menuitem2">giới thiệu</a></li>
        <li><a href="#" title="menuitem3">Thời trang nữ</a>
            <ul class="down">
                <li><a href="../GiaoDien/Aosominu.aspx" title="mnitem1">áo sơ mi</a></li>
                <li><a href="../GiaoDien/Aothunnu.aspx" title="mnitem2">áo thun</a></li>
                <li><a href="../GiaoDien/Vay.aspx" title="mnitem3">váy</a></li>
                <li><a href="../GiaoDien/Quanjeannu.aspx" title="mnitem4">quần jeans</a></li>
                <li><a href="../GiaoDien/Quanshortnu.aspx" title="mnitem5">quần short</a></li>
            </ul>
         </li>
        <li><a href="#" title="menuitem4">thời trang nam</a>
            <ul class="down">
                <li><a href="../GiaoDien/Aosominam.aspx" title="mnitem6">áo sơ mi</a></li>
                <li><a href="../GiaoDien/Aophongnam.aspx" title="mnitem7">áo phông</a></li>
                <li><a href="../GiaoDien/Quanjeannam.aspx" title="mnitem8">quần jeans</a></li>
                <li><a href="../GiaoDien/Quanshortnam.aspx" title="mnitem9">quần short</a></li>
            </ul>
         </li>
        <li><a href="#" title="menuitem5">tin tức</a>
            <ul class="down">
                <li><a href="#" title="mnitem6">Bản tin thời trang</a></li>
                <li><a href="#" title="mnitem7">Xu hướng thời trang</a></li>
                <li><a href="#" title="mnitem8">Khuyến mãi</a></li>
            </ul>
        </li>
        <li><a href="../GiaoDien/DangNhap.aspx"title="menuitem6">đăng nhập</a></li>
        <li><a href="../GiaoDien/DangNhap_QuanTri.aspx">Quản trị</a></li>
    </ul>

</div>
<div id="timkiem">
    <input type="text" value="Từ khóa" 
        style="float:left;width:400px;height:25px; margin:0 auto  5px 485px" />
    <input name="submit" type="submit" value="Tìm" style="float:left;margin-left:5px; width:80px;height:25px;background-color:#4CC417;-moz-border-radius:5px" />
</div>
</div>
