<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuSubject.ascx.cs"
    Inherits="TestOnline.hy.vn.Control.menuleft.ucMenuSubject" %>
<link href="../../Style/menuleft.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    div#wraper
    {
    	margin-top:20px;
        width: 216px;
        line-height: 2em;
        font-family: helvetica, arial, tahoma;
        font-size: 12px;
    }
    div#mainNav
    {
        width: 216px;
        padding-top:10px;
    }
    div#mainNav h1
    {
     padding-top:5px;
        font-size: 14px;
       background-image:url('../Images/Control/ucMenuLeft/left_heading_img.jpg');
        color: white;
        text-align: center;
        -moz-border-radius: 5px 5px 0px 0px;
        height:32px;
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
         height:30px;
           background-image:url('../Images/gelbuttoncenter4.gif');
         background-repeat:repeat-x;
         text-align:left;
    }
    div#mainNav ul li a
    {
        color:Blue;
        padding: 5px;
        text-align:left;
        
    }
    div#mainNav ul li a:hover
    {
        text-decoration: underline;
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
    }
     div#mainNav ul li:hover ul li
    {
        position: relative;
        border-bottom: 1px solid #bccbd8;
         height:30px;
           background-image:url('../Images/gelbuttoncenter.gif');
         background-repeat:repeat-x;
    }
</style>
<div id="wraper" style="margin-top:10px">
    <div id="mainNav">
        <h1>
            Hình thức thi</h1>
        <ul id="nav">
            <li><a href="#">Ôn luyện &raquo;</a>
            <ul>
                    <asp:Repeater runat="server" ID="rpt1">
                      <ItemTemplate>
                          <li><a  href='<%# "ListThread.aspx?SubjectID=" + Eval("SubjectID") + "&Status=1"%>'><%#Eval("SubjectName") %></a></li>
                      </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
            <li><a href="#">Thi trực tuyến &raquo;</a>
                <ul>
                    <asp:Repeater runat="server" ID="rpt2">
                      <ItemTemplate>
                          <li><a href='<%# "../../thitructuyen.aspx?SubjectID=" + Eval("SubjectID") + "&Status=2"%>'><%#Eval("SubjectName") %></a></li>
                      </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
            <li><a href="#">Thi đề đã thi &raquo;</a>
                <ul>
                   <asp:Repeater runat="server" ID="rpt3">
                      <ItemTemplate>
                          <li><a href='<%# "ListThread.aspx?SubjectID=" + Eval("SubjectID") + "&Status=3"%>'><%#Eval("SubjectName") %></a></li>
                      </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
        </ul>
    </div>
    <!--End #mainNav-->
</div>
<!--End #wrapper-->
<br />
<br />