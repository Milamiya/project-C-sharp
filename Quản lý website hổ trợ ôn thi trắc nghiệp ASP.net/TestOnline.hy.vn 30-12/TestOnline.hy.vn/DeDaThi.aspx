<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeDaThi.aspx.cs" MasterPageFile="~/SubMasterPage.Master" Inherits="TestOnline.hy.vn.DeDaThi" %>
<%@ Register src="Control/ucListThread_DaThi.ascx" tagname="ucListThread_DaThi" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="content">

    <uc1:ucListThread_DaThi ID="ucListThread_DaThi1" runat="server" />

</asp:Content>