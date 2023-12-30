<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrangSanPham.aspx.cs" Inherits="TrangSanPham" Title="Untitled Page" %>
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

<script language="javascript">

function Chuyengia(gia)
{
     var giatrave = "  VND";
        var strgia = gia.ToString();

        for(var i=strgia.Length-1;i>=0;i--)
        {
            if (i % 3 == 0&&i!=strgia.Length-1)
            {
                giatrave = strgia[i] + "." + giatrave;
            }
            else
            {

                giatrave = strgia[i] + giatrave;
            }
        }
        return giatrave;
}

</script>

<div id="tieudedssanpham">

    <p  class="p" align="center">
        <b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp DANH SÁCH SẢN PHẨM </b></p>
</div>

<div id="tieudedssanphambenphai">
<table style="margin-left:100px; margin-top:6px;">
<td><asp:DropDownList ID="SapXep" AutoPostBack="true" Width="140px" runat="server" 
        Height="24px" onselectedindexchanged="SapXep_SelectedIndexChanged" >
        <asp:ListItem>---Sắp xếp---</asp:ListItem>
    <asp:ListItem>Giá tăng dần</asp:ListItem>
    <asp:ListItem>Giá giảm dần</asp:ListItem>
    <asp:ListItem>Khuyến mãi</asp:ListItem>
    <asp:ListItem>Hàng mới</asp:ListItem>
    <asp:ListItem>Nhiều người mua</asp:ListItem>
    <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    </td>
    
<td><asp:DropDownList ID="drSanPham" runat="server" AutoPostBack="true" 
        Width="140px" Height="24px" 
        onselectedindexchanged="drSanPham_SelectedIndexChanged">
    <asp:ListItem>---Sản phẩm---</asp:ListItem>
    <asp:ListItem>Lap top</asp:ListItem>
    <asp:ListItem>Máy tính bàn</asp:ListItem>
    <asp:ListItem>Linh kiện máy tính</asp:ListItem>
    <asp:ListItem></asp:ListItem>

</asp:DropDownList></td>
</table>
</div>
<div id="dssanpham">
<div id="datalist" style=" margin-top:20px; margin-left:5px">
<asp:DataList ID="dl1"  runat="server" RepeatDirection="Horizontal"  
        Width="468px"    
          CellPadding="1" 
        onselectedindexchanged="DataList1_SelectedIndexChanged" 
        style="margin-bottom: 12px" DataMember="0"  
        RepeatColumns="4" Font-Strikeout="False" Font-Underline="False" 
        onitemdatabound="dl1_ItemDataBound" onitemcommand="dl1_ItemCommand" 
          
         >
        <ItemTemplate>
       <div style="width:173px; height:60px; text-align:center " >
            <asp:LinkButton ID="TenSPLabel"   runat="server" Text='<%# Eval("TenSP") %>' ToolTip='<%# Eval("ThongSoKyThuat") %>' Font-Underline="false" Font-Size="12"  PostBackUrl= '<%#"~/chitietsanpham.aspx?MaSanPham=" + Eval("MaSanPham")%>'
               />
            </div>
            <div style="width:173px; height:100px; text-align:center">
            <asp:Image ID="HinhAnhLabel"  runat="server"   ImageUrl ='<%# Eval("HinhAnh") %>' ToolTip='<%# Eval("ThongSoKyThuat") %>' />
            <br />
            </div>
            <%--<div style="width:173px; height:25px;  text-align:center ">
            <asp:Label ID="GiaBanLabel" Font-Size=10  runat="server" Text='<%# Eval("GiaBan")%>' />
            <br />
            </div>
             <div style="width:173px; height:25px; text-align:center ">
            <asp:Label ID="GiaBanMoiLabel" Font-Size=11  runat="server" Text="" />
            <br />
            </div>
            <div style="border-style: none none dotted none; border-width: thin; border-color: #808080 ; width:173px;  height:40px ; text-align:center ;  " >
           
            <asp:LinkButton ID="TenKhuyenMai"  runat="server"  ForeColor="Red" Font-Underline="false"
                Text="" />
                <asp:ImageButton ImageUrl='image/but_buy.jpg' runat="server" />
            
            <br /> 
            <br />
            </div>--%>
              </div>
            <div style="width:173px; height:25px; text-align:center ">
            <asp:Label ID="GiaBanLabel" style="float:right"  Font-Size=10 runat="server" Text='<%# Eval("GiaBan") %>' />
            <br />
            </div>
            <div style="width:173px; height:25px; text-align:center ">
            <asp:Label style="float:right" ID="GiaBanMoiLabel" Font-Size=11 Font-Bold=true runat="server" Text="" />
            <br />
            </div>
            <div style="border-style: none none dotted none; border-width: thin; border-color: #808080 ;width:173px; height:55px; text-align:center" >
            <asp:Label  ID="TenKhuyenMai" style="float:left" ForeColor=Red Font-Size=10  Font-Italic=true
              runat="server" 
                Text="" />
                <br />
                <asp:ImageButton style="float:right" runat="server" ID="btnImg" ImageUrl='image/but_buy.jpg'  />
            
            </div>
            
            
        </ItemTemplate>
</asp:DataList>
</div>
<table style="margin-left:300px; margin-bottom:5px">
<tr>
<td>
Bạn đang xem trang
</td>
<td>
<asp:DropDownList ID="txtTrang" runat="server" AutoPostBack="true"
        onselectedindexchanged="txtTrang_SelectedIndexChanged" ></asp:DropDownList>
</td>
</tr>
</table>
</div>
<div id ="tieudeloctim">
</div>
<div id="loctim">
<table  style=" float:left; font-size:16.5px" >
<tr>
<td>TÌM THEO GIÁ</td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt24" 
        Font-Underline=false  CssClass="text" runat=server 
        Text="2.000.000 --> 4.000.000" onclick="lbt24_Click"></asp:LinkButton> </td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt46" 
        Font-Underline=false runat=server Text="4.000.000 --> 6.000.000" 
        onclick="lbt46_Click"></asp:LinkButton> </td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt68" 
        Font-Underline=false runat=server Text="6.000.000 --> 8.000.000" 
        onclick="lbt68_Click"></asp:LinkButton> </td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt810" 
        Font-Underline=false runat=server Text="8.000.000 --> 10.000.000" 
        onclick="lbt810_Click"></asp:LinkButton> </td>

</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt1012" 
        Font-Underline=false runat=server Text="10.000.000 --> 12.000.000" 
        onclick="lbt1012_Click"></asp:LinkButton> </td>

</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt1214" 
        Font-Underline=false runat=server Text="12.000.000 --> 14.000.000" 
        onclick="lbt1214_Click"></asp:LinkButton> </td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt1416" 
        Font-Underline=false runat=server Text="14.000.000 --> 16.000.000" 
        onclick="lbt1416_Click"></asp:LinkButton> </td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt1620" 
        Font-Underline=false runat=server Text="16.000.000 --> 20.000.000" 
        onclick="lbt1620_Click"></asp:LinkButton> </td>
</tr>
<tr>
<td> <img src="image/up_level.png" /> <asp:LinkButton ID="lbt20" 
        Font-Underline=false runat=server Text="             > 20.000.000" 
        onclick="lbt20_Click"></asp:LinkButton> </td>
</tr>
</table>
<table>
<tr>
<td>THƯƠNG HIỆU</td>
<td>
    &nbsp;</td>
</tr>
</table>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="WedMayTinhDataContext" Select="new (HinhAnh, TenNhaSanXuat)" 
        TableName="NhaSanXuats">
    </asp:LinqDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="LinqDataSource1" 
        Height="225px" RepeatColumns="2" RepeatDirection="Horizontal" 
        Width="223px" onselectedindexchanged="DataList1_SelectedIndexChanged" 
        onitemcommand="DataList1_ItemCommand" 
        onitemdatabound="DataList1_ItemDataBound" >
        <ItemStyle HorizontalAlign="Center" />
        <ItemTemplate>
            <asp:ImageButton  ID="HinhAnh" runat="server"  ImageUrl='<%# Eval("HinhAnh") %>' OnClick="btnHinhAnh_Click" />
            <br />
            <asp:Label ID="TenNhaSanXuat"  runat="server" Text='<%# Eval("TenNhaSanXuat") %>'></asp:Label>
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
</div>
</asp:Content>

