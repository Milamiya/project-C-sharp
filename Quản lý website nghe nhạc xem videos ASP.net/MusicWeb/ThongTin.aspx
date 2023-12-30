<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="ThongTin.aspx.cs" Inherits="ThongTin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="AlBum_Hot">
<p></p>
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
    <div class="Video_Hot">
<p></p>
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
    <p></p>
    </div>
<div class="Music_Hot">
    <asp:DataList ID="Music__" runat="server" Width="100%">
        <ItemTemplate>
        <div class="Music___">
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
    </div>
    <p></p>
    <asp:DataList ID="NgheSi__" runat="server" Width="100%" RepeatColumns="1">
        <ItemTemplate>
            <table class="Top_Banner" align="left"  >
                <tr>
                    <td style="width: 40%">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="120px" 
                            ImageUrl='<%# "~/img_Casi/"+Eval("HinhAnh") %>' 
                            PostBackUrl='<%#Eval("MaCaSi","~/CaSi.aspx?L={0}") %>' Width="250px" />
                    </td>
                    <td style="width:20%">
                        <asp:HyperLink ID="cl2" runat="server" 
                            NavigateUrl='<%# Eval("MaCaSi","~/CaSi.aspx?L={0}") %>' 
                            Text='<%# Eval("TenCaSi") %>'></asp:HyperLink>
                    </td>
                    <td style="width:30%"> Yêu Thích :
                    <asp:HyperLink ID="HyperLink1" runat="server"   
                            Text='<%# Eval("YeuThich") %>' ForeColor="Red"></asp:HyperLink>
                    </td>
                    <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="20px" 
                            ImageUrl="~/img_button/like.jpg" 
                            PostBackUrl='<%#Eval("MaCaSi","~/Like.aspx?L={0}") %>' />
                    </td>
                </tr>
            </table>
                <br />
                <br />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

