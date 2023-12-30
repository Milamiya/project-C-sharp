<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerCommand.aspx.cs" MasterPageFile="~/manager/HomeManager.Master" Inherits="TestOnline.hy.vn.manager.ManagerCommand" %>
<%@ Register src="../Control/Manager/ucManagerCommand.ascx" tagname="ucManagerCommand" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:ucManagerCommand ID="ucManagerCommand1" runat="server" />
</asp:Content>