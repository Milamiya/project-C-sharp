<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="Top.aspx.cs" Inherits="Top" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="__Top">
<div class="__Top_TieuDe"></div>
<div class="Top_XepHang">
<asp:DataList ID="Album__" runat="server" Width="100%" RepeatColumns="1">
        <ItemTemplate>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="120px" 
                        ImageUrl='<%# "~/img_album/"+Eval("Hinh") %>' 
                        PostBackUrl='<%#Eval("MaAlbum","~/Play.aspx?A={0}") %>' 
                        Width="200px"/>
                <div id="TenAlbum">
                <asp:HyperLink ID="cl3" runat="server" 
                    NavigateUrl='<%# Eval("MaAlbum","~/Play.aspx?A={0}") %>' 
                    Text='<%# Eval("TenAlbum") %>'></asp:HyperLink>
                </div>
                <br />
        </ItemTemplate>
    </asp:DataList>
</div>
</div>
</asp:Content>

