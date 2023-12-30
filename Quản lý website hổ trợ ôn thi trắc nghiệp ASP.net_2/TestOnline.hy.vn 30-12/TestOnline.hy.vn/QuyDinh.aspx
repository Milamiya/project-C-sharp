<%@ Page Language="C#" MasterPageFile="~/SubMasterPage.Master" AutoEventWireup="true"
    CodeBehind="QuyDinh.aspx.cs" Inherits="TestOnline.hy.vn.QuyDinh" Title="Untitled Page" %>

<%@ Register src="Control/ucQuyDinh.ascx" tagname="ucQuyDinh" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID=content runat="server">
    
    <div style="color:Black">
    <uc1:ucQuyDinh ID="ucQuyDinh1" runat="server" />
    </div>
</asp:Content>
