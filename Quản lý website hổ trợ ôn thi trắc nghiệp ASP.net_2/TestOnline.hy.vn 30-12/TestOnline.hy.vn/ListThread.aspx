<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SubMasterPage.Master" CodeBehind="ListThread.aspx.cs" Inherits="TestOnline.hy.vn.ListThread" %>
<%@ Register src="Control/ucListThread.ascx" tagname="ucListThread" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="content">
    <uc1:ucListThread ID="ucListThread1" runat="server" />
</asp:Content>