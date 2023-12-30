<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/manager/HomeManager.Master" CodeBehind="ThreadUniversity.aspx.cs" Inherits="TestOnline.hy.vn.manager.ThreadUniversity" %>
<%@ Register src="../Control/Manager/ThreadQuestionUniversity.ascx" tagname="ThreadQuestionUniversity" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:ThreadQuestionUniversity ID="ThreadQuestionUniversity1" runat="server" />
</asp:Content>
