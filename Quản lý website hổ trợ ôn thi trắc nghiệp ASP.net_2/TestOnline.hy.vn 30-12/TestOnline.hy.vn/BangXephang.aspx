<%@ Page Language="C#" MasterPageFile="~/SubMasterPage.Master" AutoEventWireup="true" CodeBehind="BangXephang.aspx.cs" Inherits="TestOnline.hy.vn.Bangsephang" Title="Untitled Page" %>
<%@ Register src="Control/ucBangXepHang.ascx" tagname="ucBangXepHang" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <uc1:ucBangXepHang ID="ucBangXepHang1" runat="server" />

</asp:Content>
