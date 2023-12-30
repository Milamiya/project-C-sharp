<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuLeft.ascx.cs" Inherits="TestOnline.hy.vn.Control.ucMenuLeft" %>
<style type="text/css">
    .LI_Khung1_XH
    {
        width: 215px;
        height:320px;
        border: solid 1px gray;
        border-bottom-left-radius: 6px;
        border-bottom-right-radius: 6px;
    }
    .LI_Head1_XH
    {
    	margin-top:10px;
        width: 217px;
        background-image: url(        '../Images/Control/ucMenuLeft/left_heading_img.jpg' );
        height: 37px;
        text-align: center;
        color: White;
    }
  
</style>
<div class="LI_Head1_XH">
    <p style="padding-top: 10px; color: White; width: 215px; height: auto">
       Vị trí xếp hạng</p>
</div>
<div class="LI_Khung1_XH">
<div style="padding-top:5px">
<asp:Repeater runat="server" ID="rptListName">
<ItemTemplate>
 <div style="float: left; color:Black ;width: 10px; padding-top:8px; padding-left:2px">
        <img src="../../Images/arow2.gif" /></div>
    <div style="float: left;color:Black ; padding-left:7px; text-align: left; width: 196px">
       <%#Eval("StudentName")%> &nbsp  <%#Eval("Score")%></div>
</ItemTemplate>
</asp:Repeater>
</div>
  </div>