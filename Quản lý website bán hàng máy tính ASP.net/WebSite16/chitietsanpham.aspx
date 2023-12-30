<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="chitietsanpham.aspx.cs" Inherits="chitietsanpham" Title="Untitled Page" %>
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
        ></asp:LinkButton>
</a>
</td>
<td>
<asp:Image ID="Image3" ImageUrl="~/image/register.png" runat=server   /> 
</td>
<td>
<%--<a href="#" class="menu2a">--%>
<asp:LinkButton ID="btnDangKy" Text="Đăng ký" CssClass="menu2a" runat="server" 
        ></asp:LinkButton>
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
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp CHI TIẾT SẢN PHẨM </b></p>
       
</div>
<div id="dssanpham" style="width:980px; height:auto">
<div id= "image" style="margin-top:20px; margin-left:20px; width: 257px; height:219px">
    <asp:Image ID="Image6" runat="server" Height="212px" Width="232px"  />

    </div>
    <div id="TenSP" 
        style="width:650px; margin-top:-220px; margin-left:290px; height: 29px;">
    <asp:Label ID="lblTenSanPham" Width=650px Height=29px runat="server" 
            Font-Bold="True" Font-Italic="False" Font-Size="15pt" ForeColor="#669999" ></asp:Label>
</div>
<div id="ThongSoTongThe" style="width:650px; margin-left:290px; margin-top:10px; height: 137px;">

    <asp:Label ID="lblThongSoTongThe" runat="server" Width=650px Height=137px ></asp:Label>

</div>
<div id="GiaBan" style="width:650px; margin-left:290px; margin-top:10px; height:25px">
    <asp:Label ID="Label3" runat="server" Text="Giá:" Font-Bold="True"></asp:Label>
     <asp:Label ID="lblGiaBan" runat="server" Font-Bold="True"  ></asp:Label>
     
</div>
<div id="GiaMoi" style="width:650px; margin-left:290px; margin-top:10px; height:25px">
    
     <asp:Label ID="lblGiaMoi" runat="server" Font-Bold="True" ForeColor="#FF6600" ></asp:Label>
     
</div>
<div id="KhoHang" style="width:650px; margin-left:290px; margin-top:10px; height:21px">
<asp:Label ID="Label1" runat="server" Text="Kho hàng:" Font-Bold="True"></asp:Label>
     <asp:Label ID="lblKhoHang" runat="server" ></asp:Label>
</div>
<div id="BaoHanh" style="width:650px; margin-left:290px; margin-top:10px; height:21px">
<asp:Label ID="Label2" runat="server" Text="Bảo hành:" Font-Bold="True"></asp:Label>
     <asp:Label ID="lblBaoHanh" runat="server" ></asp:Label>
</div>
<div id="KhuyenMai" style="width:650px; margin-left:290px; margin-top:10px; height:21px">
<asp:Label ID="Label4" runat="server" Text="Khuyến mại:" Font-Bold="True" 
        ForeColor="Red"></asp:Label>
     <asp:Label ID="lblKhuyenMai" runat="server" ></asp:Label>
</div>
<div id="Div1" 
        style="width:650px; margin-left:290px; margin-top:10px; height:40px; margin-bottom: 0px;">
<asp:ImageButton ID="btnMua" runat ="server" ImageUrl="~/image/add_to_cart.jpg"  
        Height="40px" Width="113px" onclick="btnMua_Click" />
</div>
  <div id="tieudechitietthongso">

    <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp CHI TIẾT THÔNG SỐ </b></p>
       
</div>
<div id="ThongSoChiTiet" style="width:650px; margin-left:20px; margin-top:55px; height:500px;">
    <asp:DataList ID="DataList1" runat="server" 
        GridLines="Both" RepeatColumns="1" RepeatDirection="Horizontal">
        <ItemTemplate>
        <table>
        <tr>
        <td>
            Hãng sản xuất
            </td>
            <td>
            <asp:Label ID="HangSanXuatLabel" runat="server" 
                Text='<%# Eval("HangSanXuat") %>' />
                </td>
            </tr>
            <tr>
            <td>
            Model
            </td>
            <td>
            <asp:Label ID="ModelLabel" runat="server" Text='<%# Eval("Model") %>' /></td>
            </tr>
            <tr>
            <td>
           Bộ vi xử lý
           </td>
           <td>
            <asp:Label ID="BoViXuLyLabel" runat="server" Text='<%# Eval("BoViXuLy") %>' />
           </td>
           </tr>
           <tr>
           <td>
            Bộ nhớ Ram
            </td>
            <td>
            <asp:Label ID="BoNhoRamLabel" runat="server" Text='<%# Eval("BoNhoRam") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Ổ đĩa cứng
            </td>
            <td>
            <asp:Label ID="ODiaCungLabel" runat="server" Text='<%# Eval("ODiaCung") %>' />
           </td>
            </tr>
            <tr>
            <td>
            Card đồ hoạ
            </td>
            <td>
            <asp:Label ID="CardDoHoaLabel" runat="server" Text='<%# Eval("CardDoHoa") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Ổ đĩa quang
            </td>
            <td>
            <asp:Label ID="ODiaquangLabel" runat="server" Text='<%# Eval("ODiaquang") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Nhận dạng vân tay</td>
            <td>
            <asp:Label ID="NhanDangVanTayLabel" runat="server" 
                Text='<%# Eval("NhanDangVanTay") %>' />
                </td>
            </tr>
            <tr>
            <td>
            Khối lượng</td>
            <td>
            <asp:Label ID="KhoiLuongLabel" runat="server" Text='<%# Eval("KhoiLuong") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Hệ điều hành
            </td>
            <td>
            <asp:Label ID="HeDieuHanhLabel" runat="server" 
                Text='<%# Eval("HeDieuHanh") %>' />
                </td>
            </tr>
            <tr>
            <td>
            Bluetooth
            </td>
            <td>
            <asp:Label ID="BluetoothLabel" runat="server" Text='<%# Eval("Bluetooth") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Wifi
            </td>
            <td>
            <asp:Label ID="WifiLabel" runat="server" Text='<%# Eval("Wifi") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Card mạng
            </td>
            <td>
            <asp:Label ID="CardMangLabel" runat="server" Text='<%# Eval("CardMang") %>' />
           </td>
            </tr>
            <tr>
            <td>
            Camera
            </td>
            <td>
            <asp:Label ID="CameraLabel" runat="server" Text='<%# Eval("Camera") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Phụ kiện
            </td>
            <td>
            <asp:Label ID="PhuKienLabel" runat="server" Text='<%# Eval("PhuKien") %>' />
            </td>
            </tr>
            <tr>
            <td>
            Màn hình
            </td>
            <td>
            <asp:Label ID="ManHinhLabel" runat="server" Text='<%# Eval("ManHinh") %>' />
            </td>
            </tr>
            <br />
            </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="WedMayTinhDataContext" 
        Select="new (HangSanXuat, Model, BoViXuLy, BoNhoRam, ODiaCung, CardDoHoa, ODiaquang, NhanDangVanTay, KhoiLuong, HeDieuHanh, Bluetooth, Wifi, CardMang, Camera, PhuKien, ManHinh)" 
        TableName="ChiTietThongSos">
    </asp:LinqDataSource>
</div>
</div>
</asp:Content>

