<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenu.ascx.cs" Inherits="TestOnline.hy.vn.Control.Manager.ucMenu" %>
<link href="../../Style/menuLine.css" rel="stylesheet" type="text/css" />
<div class="banner">
</div>
<div id="wrapper" style="overflow: hidden;">
    <ul id="topnav">
        <li><a href="#">
            <img style="margin-top: -2px; height: 25px;" src="../../Images/Control/ucMenuLine/home.png" /></a></li>
        <li><a href="HomeManagement.aspx">Trang chủ</a> </li>
        <li><a href="frmCategory.aspx">Quản lý danh mục</a>
            <ul class="children">
                <li><a href="frmCategory.aspx">Quản lý hình thức thi</a>
                    <li><a href="frmSubject.aspx">Quản lý môn học</a> </li>
                    <li><a href="frmQuestion.aspx">Quản lý câu hỏi</a> </li>
                    <li><a href="frmThread.aspx">Quản lý đề thi</a> </li>
                    <li><a href="#">Kiến thức</a> </li>
            </ul>
        </li>
        <li><a href="Regulation.aspx">Quy chế thi</a> </li>
        <li><a href="ThreadUniversity.aspx">Đề thi đại học</a>
        </li>
        <li><a href="Student.aspx">Quản lý thí sinh</a> </li>
        <li><a href="Acount.aspx">Quản lý tài khoản</a>
        </li>
        </li>
        <li><a href="ManagerCommand.aspx">Ý kiến</a>
        </li>
    </ul>
    <div id="bg">
    </div>
</div>
<!--end #wrapper-->
