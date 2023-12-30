<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SubMasterPage.Master" CodeBehind="HomeTest.aspx.cs" Inherits="TestOnline.hy.vn.HomeTest" %>
<%@ Register src="Control/Manager/test.ascx" tagname="test" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="content" >

<div style="padding-left:10px">
    <uc1:test ID="test1" runat="server" />
</div>
</asp:Content>