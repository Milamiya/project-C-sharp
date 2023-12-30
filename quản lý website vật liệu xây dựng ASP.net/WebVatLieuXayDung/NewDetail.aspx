<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="NewDetail.aspx.cs" Inherits="NewDetail" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="Styles/Other.css" rel="stylesheet" type="text/css" />
    <div class="TieuDeTin">
        <h3>
            <asp:Label ID="lbTieuDeTin" runat="server" Text="Label"></asp:Label>
        </h3>
    </div>
    <div class="MoTa">
        <h3>
            <asp:Label ID="lbMoTa" runat="server" Text="Label"></asp:Label></h3>
    </div>
    <div class="ChiTiet">
        <h3>
            <asp:Label ID="lbChiTiet" runat="server" Text="Label"></asp:Label></h3>
    </div>
    <div class="TrichDan">
        <h3>
            <asp:Label ID="lbTrichDan" runat="server" Text="Label"></asp:Label></h3>
    </div>
    <div class="TinCu">
        <h3>
            Các tin gần nhất</h3>
        <ul>
            <li><a href="#"><span>Nhật Bản tư vấn dự án điện hạt nhân Ninh Thuận</span></a></li>
            <li><a href="#"><span>Nhật Bản tư vấn dự án điện hạt nhân Ninh Thuận</span></a></li>
            <li><a href="#"><span>Nhật Bản tư vấn dự án điện hạt nhân Ninh Thuận</span></a></li>
            <li><a href="#"><span>Nhật Bản tư vấn dự án điện hạt nhân Ninh Thuận</span></a></li>
            <li><a href="#"><span>Nhật Bản tư vấn dự án điện hạt nhân Ninh Thuận</span></a></li>
            <li><a href="#"><span>Nhật Bản tư vấn dự án điện hạt nhân Ninh Thuận</span></a></li>
        </ul>
    </div>
</asp:Content>
