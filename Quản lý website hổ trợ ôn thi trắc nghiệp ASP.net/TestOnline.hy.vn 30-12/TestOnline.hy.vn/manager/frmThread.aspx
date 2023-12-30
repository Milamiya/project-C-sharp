<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/manager/HomeManager.Master" CodeBehind="frmThread.aspx.cs" Inherits="TestOnline.hy.vn.manager.frmThread" %>
<%@ Register src="../Control/Manager/ucThread.ascx" tagname="ucThread" tagprefix="uc1" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
 <div style="width: 980px; height: 27px; font: 500 15px Arial; text-align:center; border: solid 1px #A7D0F2;
            padding: 0px 0px 0px 0px; background-image: url(../Images/Control/Quantri/anh1.png);
            background-repeat: repeat-x;">
            Quản lý đề thi
        </div>
        <div>
    <uc1:ucThread ID="ucThread1" runat="server" />
    </div>
</asp:Content>