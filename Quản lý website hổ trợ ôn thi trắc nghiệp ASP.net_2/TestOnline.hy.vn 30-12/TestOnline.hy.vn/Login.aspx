<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/SubMasterPage.Master" Inherits="TestOnline.hy.vn.Login" %>
<%@ Register src="Control/menuleft/ucLogin.ascx" tagname="ucLogin" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="content">
<div style="text-align:center; margin-top:200px;margin-left:200px">
    <uc1:ucLogin ID="ucLogin1" runat="server" />
</div>
</asp:Content>