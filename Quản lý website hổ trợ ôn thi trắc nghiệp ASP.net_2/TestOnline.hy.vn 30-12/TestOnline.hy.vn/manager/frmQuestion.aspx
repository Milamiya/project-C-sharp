<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmQuestion.aspx.cs" MasterPageFile="~/manager/HomeManager.Master" Inherits="TestOnline.hy.vn.manager.frmQuestion" %>
<%@ Register src="../Control/Manager/ucQuestion.ascx" tagname="ucQuestion" tagprefix="uc1" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
 <div style="width: 980px; height: 27px; font: 500 15px Arial; text-align:center; border: solid 1px #A7D0F2;
            padding: 0px 0px 0px 0px; background-image: url(../Images/Control/Quantri/anh1.png);
            background-repeat: repeat-x;">
            Quản lý câu hỏi
        </div>
        <div>
    <uc1:ucQuestion ID="ucQuestion1" runat="server" />
    </div>
</asp:Content>