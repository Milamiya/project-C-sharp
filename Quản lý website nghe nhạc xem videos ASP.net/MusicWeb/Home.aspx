<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="Content_home">
    <div class="List">
    <marquee onmouseout="start()" onmouseover="stop()">
        <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" HorizontalAlign="Left">
    <ItemTemplate>
    <asp:HyperLink ID="HyperLink1" Text='<%#Eval("TenBaiHat") %>'
        NavigateUrl='<%#Eval("MaBaiHat","~/Play.aspx?M={0}") %>' 
        runat="server">
        </asp:HyperLink>
    </ItemTemplate>
    </asp:DataList></marquee>
    </div>

<div class="AlBum_Hot">
<p><div class="TieuDe__" >&nbsp;&nbsp;&nbsp; AlBum Nổi Bật</div></p>
    <asp:DataList ID="Album__" runat="server" Width="100%" RepeatColumns="3">
        <ItemTemplate>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="150px" 
                        ImageUrl='<%# "~/img_album/"+Eval("Hinh") %>' 
                        PostBackUrl='<%#Eval("MaAlbum","~/Play.aspx?A={0}") %>' 
                        Width="250px"/>
                <div id="TenAlbum">
                <asp:HyperLink ID="cl2" runat="server" 
                    NavigateUrl='<%# Eval("MaAlbum","~/Play.aspx?A={0}") %>' 
                    Text='<%# Eval("TenAlbum") %>'></asp:HyperLink>
                </div>
                <br />
        </ItemTemplate>
    </asp:DataList>
    <p></p>
    </div>
<div class="Video_Hot">
<p><div class="TieuDe__" >&nbsp;&nbsp;&nbsp; Video Nổi Bật</div></p>
    <asp:DataList ID="Video__" runat="server" Width="100%" RepeatColumns="3">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="120px" 
                        ImageUrl='<%# "~/img_video/"+Eval("Hinh") %>' 
                        PostBackUrl='<%#Eval("MaVideo","~/Play_Video.aspx?V={0}") %>' 
                        Width="250px"/>
                <br />
                <asp:HyperLink ID="cl2" runat="server" 
                    NavigateUrl='<%# Eval("MaVideo","~/Play.aspx?V={0}") %>' 
                    Text='<%# Eval("TenVideo") %>'></asp:HyperLink>
                <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenCaSi") %>'></asp:Label>
                <br />
        </ItemTemplate>
    </asp:DataList>
    </div>
<div class="Music_Hot">
<p><div class="TieuDe__" >&nbsp;&nbsp;&nbsp; Bài Hát Mới</div></p>
    <asp:DataList ID="Music__" runat="server" Width="100%">
        <ItemTemplate>
        <div class="Music___">
                &nbsp;<asp:Image ID="Image7" runat="server" Height="20px" Width="35px" ImageUrl="~/img_button/new.gif" />
                <asp:HyperLink ID="cl2" runat="server" 
                    NavigateUrl='<%# Eval("MaBaiHat","~/Play.aspx?M={0}") %>' 
                    Text='<%# Eval("TenBaiHat") %>'></asp:HyperLink>
                <br />
                <table class="Top_Banner">
                    <tr>
                        <td style="width:87%">
                            Trình Bày :<asp:Label ID="Label1" runat="server" Text='<%# Eval("TenCaSi") %>'></asp:Label>
                            &nbsp;||
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("TenTheLoai") %>'></asp:Label>
                            &nbsp;|| Lượt Nghe :<asp:Label ID="Label3" runat="server" Text='<%# Eval("LuotXem") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton2" runat="server" Height="16px" 
                                ImageUrl='~/img_button/icon-ngheNhac.gif' 
                                PostBackUrl='<%# Eval("MaBaiHat","~/Play.aspx?M={0}") %>' Width="20px" 
                                BorderStyle="Double" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton3" runat="server" BorderStyle="Double" 
                                Height="16px" ImageUrl="~/img_button/iconDowload.gif" 
                                PostBackUrl='<%# "" %>' Width="20px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" id="gachchan"></td>
                    </tr>
                </table>
                </div>
        </ItemTemplate>
    </asp:DataList>
    </div>  
<div class="Binh_luan">
<p><div class="TieuDe__" >&nbsp;&nbsp;&nbsp; Bình Luận</div></p>
<div class="NoidungBinhLuan" style="height:400px; overflow:scroll;">
    <asp:DataList ID="DataList_binhluan" Width="100%" runat="server" 
        BorderColor="Black" BorderStyle="Double">
        <ItemTemplate>
            <table class="Top_Banner" 
                style=" border-color: #00FF00; height:60px; border-bottom-style: outset;">
                <tr>
                    <td style="width:50px">
                        <asp:Image ID="Image6" Width="90%" runat="server" BorderStyle="Inset" 
                            ImageUrl='<%# "~/img_user/"+Eval("Hinh") %>' />
                    </td>
                    <td style="width:10px">
                        <img alt="" src="img_button/neen.gif" 
                style="width: 10px; height:100%" />
                    </td>
                    <td style="width: 680px">
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("HoTen") %>'></asp:Label> :<asp:Label ID="Label4" runat="server" Text='<%# Eval("LoiBinh") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("NgayDang") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</div>
<p><div class="TieuDe__" >&nbsp;&nbsp;&nbsp; Lời Bình Của Bạn</div></p>
<table class="Top_Banner" style="border-style: solid">
                <tr>
                    <td style="width:60px">
                        <asp:Image ID="Image_user" Width="90%" runat="server" BorderStyle="Inset" 
                            ImageUrl="~/img_button/3anh.png"/>
                    </td>
                    <td style="width:10px">
                        <img alt="" src="img_button/neen.gif" 
                style="width: 10px; height:100%" />
                    </td>
                    <td>
                        
                        <asp:Label ID="lab_tenuser" runat="server" Text="Bình Luận"></asp:Label>
&nbsp;:<asp:TextBox ID="txt_binhluan" Width="77%" runat="server"></asp:TextBox>
                        
                    &nbsp;&nbsp;
                        <asp:Button ID="btn_gui" runat="server" Text="OK" onclick="btn_gui_Click" />
                        
                    </td>
                </tr>
            </table>

</div>
</div>
</asp:Content>

