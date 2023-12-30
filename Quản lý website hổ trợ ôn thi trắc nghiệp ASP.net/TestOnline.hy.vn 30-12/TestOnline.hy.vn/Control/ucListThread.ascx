<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListThread.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.ucListThread" %>
<style type="text/css">
    .Title
    {
        float: left;
        width: 100%;
        text-align: left;
        padding-left: 10px;
        color: Blue;
        font: 500 14px Arial;
        padding-top:2px;
    }
    .Title .Title1
    {
        color: Blue;
    }
    .Title .Title1:hover
    {
        color: Red;
    }
    .CreateDate
    {
        color: #666666;
        font: 500 10px Arial;
        padding-top: 15px;
    }
    .List_DownLoad
    {
        color: Black;
        font: 500 11px Arial;
    }
    .List_DownLoad:hover
    {
        color: Red;
    }
    .LstPage_Continue
    {
        padding-left: 630px;
        font: 500 12px Arial;
        color: Blue;
        width: 738px;
        text-decoration: none;
    }
    .LstPage_Continue:hover
    {
        color: Red;
    }
    .ListPage_border
    {
        width: 708px;
        border: solid 1px gray;
        border-top: none;
        border-bottom-left-radius: 8px;
        border-bottom-right-radius: 8px;
     height: 370px;
    }
</style>
<div style="width: 710px; border-top-left-radius: 8px; border-top-right-radius: 8px;
    margin-left: 5px; height: 30px; background-repeat: repeat-x; background-image: url('../Images/menu_title1.gif')">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/70px-Logo_book2.png'">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-left: 5px; padding-top: 5px;">
        Mức độ dễ
    </div>
    <br />
    <div class="ListPage_border">
        <asp:Repeater runat="server" ID="rpt1">
            <ItemTemplate>
                <div class="Title">
                    <img src="../Images/arow2.gif" style="float: left; padding-top: 5px; padding-right: 5px" /><a
                        class="Title1" href='<%# "HomeTest.aspx?threadid=" + Eval("ThreadsID")%>'><%# Eval("TheadName") %></a><a class="CreateDate">&nbsp(<%# Eval("CreateDate")%>)</a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
<div style="width: 710px; border-top-left-radius: 8px; border-top-right-radius: 8px;margin-top: 370px; margin-left: 5px; height:30px; background-repeat: repeat-x;background-image: url('../Images/menu_title1.gif')">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/70px-Logo_book2.png'">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-left: 5px; padding-top: 5px;">
        Mức độ trung bình
    </div>
    <br />
    <div class="ListPage_border">
        <asp:Repeater runat="server" ID="rpt2">
            <ItemTemplate>
                <div class="Title">
                    <a class="Title1" href='<%# "HomeTest.aspx?threadid=" + Eval("ThreadsID")%>' id='<%# Eval("TheadName") %>' href="#">
                        <img src="../Images/arow2.gif" style="float: left; padding-top: 10px; padding-right: 5px" />
                        <%# Eval("TheadName") %></a><a class="CreateDate">&nbsp(<%# Eval("CreateDate")%>)</a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
<div style="width: 710px; border-top-left-radius: 8px; border-top-right-radius: 8px;
    margin-top: 370px; margin-left: 5px;height: 400px; background-repeat: repeat-x;
    background-image: url('../Images/menu_title1.gif')">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/70px-Logo_book2.png'">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-left: 5px; padding-top: 5px;">
        Mức độ khó
    </div>
    <br />
    <div class="ListPage_border">
        <asp:Repeater runat="server" ID="rpt3">
            <ItemTemplate>
                <div class="Title">
                    <a class="Title1" href='<%# "HomeTest.aspx?threadid=" + Eval("ThreadsID")%>' id='<%# Eval("TheadName") %>' href="#">
                        <img src="../Images/arow2.gif" style="float: left; padding-top: 10px; padding-right: 5px" />
                        <%# Eval("TheadName") %></a><a class="CreateDate">&nbsp(<%# Eval("CreateDate")%>)</a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
