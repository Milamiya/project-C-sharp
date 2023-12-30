<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/manager/HomeManager.Master" CodeBehind="Student.aspx.cs" Inherits="TestOnline.hy.vn.manager.Student" %>

<%@ Register src="../Control/Manager/ucStudents.ascx" tagname="ucStudents" tagprefix="uc1" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
 <div style="width: 980px; height: 27px; font: 500 15px Arial; text-align:center; border: solid 1px #A7D0F2;
            padding: 0px 0px 0px 0px; background-image: url(../Images/Control/Quantri/anh1.png);
            background-repeat: repeat-x;">
            Quản lý thí sinh
        </div>
        <div>
   
            <uc1:ucStudents ID="ucStudents1" runat="server" />
   
    </div>
</asp:Content>