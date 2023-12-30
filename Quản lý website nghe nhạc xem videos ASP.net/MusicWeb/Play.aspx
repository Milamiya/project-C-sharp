<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="Play.aspx.cs" Inherits="Play" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<head>
    <link href="../MusicWeb/AudioPlayer/css/audioplayer.css" rel="stylesheet" type="text/css" />
<link href="../MusicWeb/AudioPlayer/css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>

<div class="play_">
<div class="left_play">
<div><a href="#" target="_blank"><img border="0" src="img_QuangCao/dat-quang-cao.gif" width="100%" height="150px" /></a></div>
<div id="Play__" runat="server" ></div>
<div class="menu_play"><p></p>
<table cellspacing="0" class="__ThongTinBH">
                    <tr>
                        <td class="TraiClear" align="right">
                            Bạn đang nghe ca khúc:</td>
                        <td class="PhaiClear">
                            <asp:Label ID="lblTenCaKhuc" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="TraiClear" align="right">
                            Ca sỹ trình bày:</td>
                        <td class="PhaiClear">
                            <asp:Label ID="lblCasy" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>                                       
                    <tr>
                        <td class="TraiClear" align="right">
                            Thể loại:</td>
                        <td class="PhaiClear">
                            <asp:Label ID="lblTheLoai" runat="server" Text="Label"></asp:Label></td>
                    </tr>                                                                        
</table>
</div>
<div><p></p>
<div class="TieuDe__" >&nbsp;&nbsp;&nbsp;Những Bài Hát Của 
    <asp:Label ID="Lab_casi" runat="server" Text="Label"></asp:Label></div>
    <p></p>
<asp:DataList ID="Music__" runat="server" Width="100%">
        <ItemTemplate>
        <div class="Music___">
                <asp:HyperLink ID="cl2" runat="server" 
                    NavigateUrl='<%# Eval("MaBaiHat","~/Play.aspx?M={0}") %>' 
                    Text='<%# Eval("TenBaiHat") %>'></asp:HyperLink>
                <br />
                <table class="Top_Banner">
                    <tr>
                        <td style="width:90%">
                            Thể Loại :
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("TenTheLoai") %>'></asp:Label>
                            &nbsp;|| Lượt Nghe :<asp:Label ID="Label3" runat="server" Text='<%# Eval("LuotXem") %>'></asp:Label>
                        </td>
                        <td>
                            
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
<div class="right_play">
<a href="http://www.didongviet.vn/" target="_blank"><img border="0" src="img_QuangCao/QC_DiDongViet.jpg" width="99%" /></a><br />
<a href="#" target="_blank"><img border="0" src="img_QuangCao/matbao.gif" width="99%" /></a><br />
<a href="#" target="_blank"><img border="0" src="img_QuangCao/vinamilk.gif" width="99%" /></a>
<a href="#" target="_blank"><img border="0" src="img_QuangCao/sonpholo.jpg" width="99%" /></a>
</div>
</div>
</body>
</asp:Content>

