<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SubMasterPage.Master" CodeBehind="Registry.aspx.cs" Inherits="TestOnline.hy.vn.Registry" %>

<%@ Register src="Control/ucRegistry.ascx" tagname="ucRegistry" tagprefix="uc1" %>

<asp:Content runat="server" ContentPlaceHolderID="content">

    <uc1:ucRegistry ID="ucRegistry1" runat="server" />

</asp:Content>