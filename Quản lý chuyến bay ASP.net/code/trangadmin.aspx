<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="trangadmin.aspx.cs" Inherits="trangadmin" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Font-Strikeout="False"
        ForeColor="Red" Style="z-index: 100; left: 350px; position: absolute; top: 199px"
        Text="TRANG THAO TÁC ADMIN"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" style="z-index: 101; left: 159px; position: absolute; top: 236px" Font-Underline="True" NavigateUrl="~/quantri.aspx">Quản trị chuyến bay</asp:HyperLink>
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/dangchuyenbay.aspx"
        Style="z-index: 102; left: 294px; position: absolute; top: 237px">Đăng chuyến bay</asp:HyperLink>
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/dangtinmoi.aspx" Style="z-index: 103;
        left: 411px; position: absolute; top: 237px">Đăng tin mới</asp:HyperLink>
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/doihinhnen.aspx" Style="z-index: 104;
        left: 499px; position: absolute; top: 237px">Đổi hình nền</asp:HyperLink>
    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/dangkhachsan.aspx" Style="z-index: 106;
        left: 585px; position: absolute; top: 237px" Width="108px">Đăng khách sạn</asp:HyperLink>
</asp:Content>

