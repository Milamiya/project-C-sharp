<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuLeft1.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.ucMenuLeft1" %>
<style type="text/css">
    .LI_Khung1_
    {
        width: 215px;
        height:225px;
        border: solid 1px gray;
        border-bottom-left-radius: 6px;
        border-bottom-right-radius: 6px;
    }
    .LI_Head1_
    {
    	margin-top:10px;
        width: 217px;
        background-image: url(        '../Images/Control/ucMenuLeft/left_heading_img.jpg' );
        height: 37px;
        text-align: center;
        color: White;
    }
    .LI_Text1
    {
        width: 120px;
        float: left;
        padding-bottom: 5px;
    }
    .LI_Lable1
    {
        color: Blue;
        padding-left: 5px;
        width: 75px;
        font: 500 13px Arial;
        float: left;
        padding-bottom: 5px;
    }
    .LI_Pass1
    {
        float: left;
        color: Blue;
        margin-top: 5px;
        margin-left: 10px;
        text-decoration: none;
    }
    .LI_Pass1:hover
    {
        color: Red;
    }
    .Mau1
    {
        color: Purple;
        margin-left: 30px;
        color: #000066;
        width: 80px;
        margin-top: 5px;
        height: 22px;
        background-image: url(       '../Images/Control/ucLogIn/icon_Blog26.png' );
        background-repeat: no-repeat;
        float: left;
        text-align: center;
    }
    .Mau1:hover
    {
        color: Red;
    }
    .hover_lable_
    {
        color: Blue;
    }
    .hover_lable_:hover
    {
        color: Red;
    }
</style>
<div class="LI_Head1_">
    <p style="padding-top: 10px; color: White; width: 215px; height: auto">
        Đề test host</p>
</div>
<div class="LI_Khung1_">
<div style="padding-top:5px">
<asp:Repeater runat="server" ID="rptListThread">
<ItemTemplate>
 <div style="float: left; width: 10px; padding-top:8px; padding-left:2px">
        <img src="../../Images/arow2.gif" /></div>
    <div style="float: left; padding-left:7px; text-align: left; width: 196px">
         <a href='<%# "HomeTest.aspx?threadid=" + Eval("ThreadsID")%>' class="hover_lable_"><%# Eval("TheadName")%></a></div>
</ItemTemplate>
</asp:Repeater>
</div>
  </div>