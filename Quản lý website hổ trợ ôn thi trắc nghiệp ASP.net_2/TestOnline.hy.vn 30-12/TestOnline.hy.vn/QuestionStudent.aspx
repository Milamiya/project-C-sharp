<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionStudent.aspx.cs" MasterPageFile="~/SubMasterPage.Master" Inherits="TestOnline.hy.vn.QuestionStudent" %>
<%@ Register src="Control/ucQuestionStudent.ascx" tagname="ucQuestionStudent" tagprefix="uc1" %>
<asp:Content ContentPlaceHolderID="content" runat="server">
    <uc1:ucQuestionStudent ID="ucQuestionStudent1" runat="server" />
</asp:Content>