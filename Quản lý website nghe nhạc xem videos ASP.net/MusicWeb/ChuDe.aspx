<%@ Page Title="Tam anh music" Language="C#" MasterPageFile="~/Master_Home.master" AutoEventWireup="true" CodeFile="ChuDe.aspx.cs" Inherits="ChuDe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="Than_Cac_Phan">
<div class="TieuDeWebControl">
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</div>
<div class="O_Chua_baiHat">
<asp:DataList ID="DataList5" runat="server" RepeatColumns="4" Width="100%" 
                RepeatDirection="Horizontal" >
                <ItemTemplate>
                <div>
                <div class="TieuDeBaiViet" align="left" style="height: 20px">
                <asp:Image ID="Image1" runat="server" ImageUrl="img_button/red-arrow.gif" />
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("MaBaiHat","~/Play.aspx?M={0}") %>' Text='<%#Eval("TenBaiHat") %>' runat="server"></asp:HyperLink>
                </div>
                </div>                    
                </ItemTemplate>
            </asp:DataList>
</div>
</div>
</asp:Content>

