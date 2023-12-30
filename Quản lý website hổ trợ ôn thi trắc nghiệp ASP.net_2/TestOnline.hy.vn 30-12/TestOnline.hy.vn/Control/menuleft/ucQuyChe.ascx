<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucQuyChe.ascx.cs" Inherits="TestOnline.hy.vn.Control.menuleft.ucQuyChe" %>
<link href="../../Style/menuleft.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    div#wraper
    {
        width: 216px;
        line-height: 2em;
        font-family: helvetica, arial, tahoma;
        font-size: 12px;
    }
    div#mainNav
    {
        width: 216px;
        padding-top: 6px;
    }
    div#mainNav h1
    {
        padding-top: 5px;
        font-size: 14px;
        background-image: url( '../Images/Control/ucMenuLeft/left_heading_img.jpg' );
        color: white;
        text-align: center;
        -moz-border-radius: 5px 5px 0px 0px;
        height: 32px;
    }
    div#mainNav ul
    {
        list-style: none;
        border: 1px solid #bccbd8;
    }
    div#mainNav ul li
    {
    
        position: relative;
        border-bottom: 1px solid #bccbd8;
        height: 30px;
        background-image: url( '../Images/gelbuttoncenter4.gif' );
        background-repeat: repeat-x;
        text-align: left;
    }
    div#mainNav ul li a
    {	padding-top:3px;
        color: Blue;
        padding: 5px;
        text-align: left;
        text-decoration:none;
    }
    div#mainNav ul li a:hover
    {
        text-decoration:none;
        color:Red;
    }
    div#mainNav ul li ul
    {
        position: absolute;
        top: -1px;
        left: 215px;
        display: none;
    }
    div#mainNav ul li:hover ul
    {
        display: block;
        width: 100%;
        text-decoration:none;
    }
    div#mainNav ul li:hover ul li
    {
        position: relative;
        border-bottom: 1px solid #bccbd8;
        height: 30px;
        background-image: url( '../Images/gelbuttoncenter.gif' );
        background-repeat: repeat-x;
    }
</style>
<div id="wraper" style="margin-top: 30px">
    <div id="mainNav">
        <h1>
            Quy chế tuyển sinh</h1>
        <ul id="nav">
            <asp:Repeater runat="server" ID="rpt1">
                <ItemTemplate>
                    <li style="padding-top:7px"><a href='<%# Eval("Url") %>'>
                        <%#Eval("Titile")%> <img src="../../Images/download.gif" /> </a></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
    <!--End #mainNav-->
</div>
<!--End #wrapper-->
<br />
<br />
<br />
<br />
<br />
<br />
