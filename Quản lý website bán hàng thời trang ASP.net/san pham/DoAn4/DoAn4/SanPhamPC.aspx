<%@ Page Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="SanPhamPC.aspx.cs" Inherits="DoAn4.WebForm5" Title="Sản phẩm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Con1" runat="server">
<div class="daukhungmain">
    <asp:Label ID="lblTieuDe" runat="server" Font-Bold="False" Font-Names="Arial" 
        Font-Size="Large" ForeColor="#333333"></asp:Label>
    </div>
    <asp:DataList ID="sanpham1" runat="server" HorizontalAlign="Center" 
        RepeatColumns="3" Width="100%" DataKeyField="Product_ID" 
        RepeatDirection="Horizontal">
        <ItemTemplate>
        <div class="khungsanpham">
        <div class="khunganh">
        <a href='<%# "Chitiet.aspx?Product_ID="+Eval("Product_ID") %>'>
        <img id="anh" runat="server" src='<%# "~/AnhSanPham/"+Eval("Image") %>' />
        </a>
        <br />
        </div>
        <div class="dong">
            <asp:HyperLink ID="HyperLink3" runat="server" Font-Size="11pt" 
                    ForeColor="#333333" Text='<%# Eval("Product_Name") %>'></asp:HyperLink>
        </div>
        <div class="dong">
        <asp:Label ID="Label4" runat="server" ForeColor="#CC0000" Font-Size="11pt"
         Text='<%# Eval("Price_Export") %>'></asp:Label>
         <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" Text="VNĐ" 
                     Font-Size="11pt"></asp:Label>
        </div>
        </ItemTemplate>
    </asp:DataList>
<div style="float:right; width:150px;">
<asp:LinkButton ID="LbtBack" runat="server" onclick="LbtBack_Click">&lt;&lt;Back</asp:LinkButton>
    <asp:Label ID="LblPage" runat="server" Text="Page"></asp:Label>
    <asp:LinkButton ID="LbtNext" runat="server" onclick="LbtNext_Click">Next&gt;&gt;</asp:LinkButton>
</div>
</asp:Content>
