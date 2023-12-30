<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Banner.ascx.cs" Inherits="TestOnline.hy.vn.Control.Banner" %>

<link href="../Style/style.css" rel="stylesheet" type="text/css" />
<script src="../Js/crawler.js" type="text/javascript"></script>
<style type="text/css">
    .bn_Form
    {
        padding-top: 10px;
        width: 1000px;
        height: 320px;
    }
    .bn_menu
    {
        width: 960px;
        height:35px;
        background-image: url( '../Images/Control/ucBanner/menu.png' );
        background-repeat: repeat-x;
        border-top-left-radius: 10px;
        border-top-right-radius: 10px;
        padding-top:15px;
        
    }
    .bn_banner
    {
        width: 1000px;
        height: 250px;
        background-image: url( '../Images/Control/ucBanner/banner.jpg' );
    }
   	.bn_menuStyle
    {
    	color:Blue;
    	font:500 18px Arial;
    	text-decoration:none;
    	padding-left:10px;
    	padding-right:10px;
    	padding-bottom:1px;
    	 height:20px;
    	 
    	}
    .bn_menuStyle:hover
    {
    	color:Red;
    	font:500 18px Arial;
    	text-decoration:none;
    	}
</style>
<center>
    <div class="bn_Form">
        <div class="bn_menu">
            <asp:Repeater runat="server" ID="rptMenu2">
                    <ItemTemplate>
                    <a class="bn_menuStyle" id='<%# Eval("CategoryID") %>' href='<%# Eval("Url")+"?CategoryID="+Eval("CategoryID") %>'>
                            <%# Eval("CategoryName")%></a>|
                        
                        
                    </ItemTemplate>
                </asp:Repeater>
        </div>
        <div class="bn_banner">
        </div>
    </div>
</center>