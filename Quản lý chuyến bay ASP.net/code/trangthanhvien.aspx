<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="trangthanhvien.aspx.cs" Inherits="trangthanhvien" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Red"
        Style="z-index: 100; left: 341px; position: absolute; top: 199px" Text="TRANG CÁ NHÂN THÀNH VIÊN"
        Width="276px"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/guiykien.aspx" Style="z-index: 102;
        left: 164px; position: absolute; top: 235px">Gửi ý kiến</asp:HyperLink>
</asp:Content>

