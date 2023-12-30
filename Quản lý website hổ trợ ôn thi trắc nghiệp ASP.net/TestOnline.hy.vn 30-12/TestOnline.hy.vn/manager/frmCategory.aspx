<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/manager/HomeManager.Master" CodeBehind="frmCategory.aspx.cs" Inherits="TestOnline.hy.vn.manager.frmCategory" %>

<%@ Register src="../Control/Manager/ucCategories.ascx" tagname="ucCategories" tagprefix="uc1" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
     <div style="width: 980px; height: 27px; font: 500 15px Arial; text-align:center; border: solid 1px #A7D0F2;
            padding: 0px 0px 0px 0px; background-image: url(../Images/Control/Quantri/anh1.png);
            background-repeat: repeat-x;">
            Quản lý hình thức thi
        </div>
        <div>
    <uc1:ucCategories ID="ucCategories1" runat="server" />
</div>
</asp:Content>