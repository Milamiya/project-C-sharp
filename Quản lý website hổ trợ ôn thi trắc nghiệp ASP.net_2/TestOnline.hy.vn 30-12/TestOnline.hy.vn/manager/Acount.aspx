<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/manager/HomeManager.Master" CodeBehind="Acount.aspx.cs" Inherits="TestOnline.hy.vn.manager.Acount" %>
<%@ Register src="../Control/Manager/ucAcount.ascx" tagname="ucAcount" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:ucAcount ID="ucAcount1" runat="server" />
</asp:Content>