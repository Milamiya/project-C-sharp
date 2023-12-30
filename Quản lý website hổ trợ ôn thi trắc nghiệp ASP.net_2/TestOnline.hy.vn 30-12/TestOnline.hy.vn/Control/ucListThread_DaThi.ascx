<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListThread_DaThi.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.ucListThread_DaThi" %>
<style type="text/css">
    .color_lable
    {
        color: Blue;
        text-decoration:none;
    }
    .color_lable:hover
    {
        color:Red;
    }
</style>
<div style="padding-left:10px">
<asp:Repeater ID="rptList" runat="server">
    <ItemTemplate>
        <div style="color:Blue; text-align:left">
        <a class="color_lable" href='<%# "HomeTest.aspx?threadid=" + Eval("ThreadsID")%>'>
            <%#Eval("TheadName")%></a></div>
        <div style="text-align:left; color:Black">
            Cuộc thi diễn ra vào ngày &nbsp<%#Eval("DateTest")%>
        </div>
        <div  style="text-align:left">
            <a class="color_lable" href='<%# "BangXephang.aspx?threadID=" + Eval("ThreadsID")%>'>Bảng xếp hạng</a></div>
            <br />
            <br />
    </ItemTemplate>
</asp:Repeater>
</div>
<asp:Label runat="server" Visible="false" ID="lblThongBao"></asp:Label>