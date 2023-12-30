<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSubject.aspx.cs" MasterPageFile="~/manager/HomeManager.Master" Inherits="TestOnline.hy.vn.manager.frmSubject" %>
<%@ Register src="../Control/Manager/ucMenu.ascx" tagname="ucMenu" tagprefix="uc1" %>
<%@ Register src="../Control/Manager/ucSubject.ascx" tagname="ucSubject" tagprefix="uc2" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
   <div style="width: 980px; height: 27px; font: 500 15px Arial; text-align:center; border: solid 1px #A7D0F2;
            padding: 0px 0px 0px 0px; background-image: url(../Images/Control/Quantri/anh1.png);
            background-repeat: repeat-x;">
            Quản lý môn học
        </div>
        <div>
    <uc2:ucSubject ID="ucSubject1" runat="server" />
    </div>

</asp:Content>