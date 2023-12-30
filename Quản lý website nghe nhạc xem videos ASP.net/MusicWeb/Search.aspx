<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="Than_Cac_Phan">
<div align="left" class="TieuDeWebControl">
<asp:Label ID="Label1" runat="server" Text="- Kết quả tìm kiếm -"></asp:Label> 
</div>
    <asp:DataList ID="Video__" runat="server" Width="100%" RepeatColumns="1">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="80px" 
                        ImageUrl='<%# "~/img_video/"+Eval("Hinh") %>' 
                        PostBackUrl='<%#Eval("MaVideo","~/Play.aspx?V={0}") %>' 
                        Width="25%"/>
                        Video : 
                <asp:HyperLink ID="cl2" runat="server" 
                    NavigateUrl='<%# Eval("MaVideo","~/Play.aspx?V={0}") %>' 
                    Text='<%# Eval("TenVideo") %>'></asp:HyperLink>
                      || Trình Bài : 
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenCaSi") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
    <p id="gachchan"></p>
        <%--Download source code tai Sharecode.vn--%>
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
        </ItemTemplate>
    </asp:DataList>
    </div>
    <%--Download source code tai Sharecode.vn--%>
</asp:Content>

