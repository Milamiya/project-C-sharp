<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeManagement.aspx.cs"
    Inherits="TestOnline.hy.vn.manager.HomeManagement" %>

<%@ Register Src="../Control/Manager/ucMenu.ascx" TagName="ucMenu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản trị hệ thống ôn thi trắc nghiệm</title>
    <style type="text/css">
        .cot
        {
            border: solid thin gray;
        }
        .HomePage_Link
        {
            font: 500 15px Arial;
            color: Blue;
            text-decoration: none;
             float:right;
        }
        .HomePage_Link:hover
        {
            color: Red;
        }
        .Khung1
        {
            height: 102px;
            width: 102px;
            margin-top: 49px;
            margin-left: 74px;
        }
        .Khung2
        {
            width: 180px;
            height: 35px;
            float: left;
            margin-left: 0px;
            text-align: center;
        }
    </style>
</head>
<body>
    <center>
        <form id="form1" runat="server">
        <div>
            <uc1:ucMenu ID="ucMenu1" runat="server" />
        </div>
        <div style="width: 980px; height: 27px; font: 500 15px Arial; border: solid 1px #A7D0F2;
            padding: 0px 0px 0px 0px; background-image: url(../Images/Control/Quantri/anh1.png);
            background-repeat: repeat-x;">
            Danh mục quản trị
        </div>
        <div style="width: 980px; font: 500 15px Arial; border: solid 1px #A7D0F2">
            <table>
                <tr>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/hinhthucthi.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý hình thức thi</a></div>
                    </td>
                   
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/subject.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý môn học</a></div>
                    </td>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/question.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý câu hỏi</a></div>
                    </td>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/dethi.jpg" style="width: 102px" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý đề thi</a></div>
                    </td>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/dethi.jpg" style="width: 102px" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Đại học & cao đẳng</a></div>
                    </td>
                </tr>
                <tr>
                <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/hinhthucthi.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" style="float:none" href="#">Quản lý thí sinh</a></div>
                    </td>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/danhmuc.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý nhóm người dùng</a></div>
                    </td>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/nguoidung.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý người dùng</a></div>
                    </td>
                   <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/nguoidung.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Phân quyền hệ thống</a></div>
                    </td>
                    <td>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/danhmuc.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý ý kiến</a></div>
                    </td>
                    <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/nguoidung.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý phản hồi</a></div>
                    </td>
                   <td>
                        <div class="Khung1">
                            <a href="#">
                                <img src="../Images/Control/Quantri/nguoidung.jpg" /></a></div>
                        <div class="Khung2">
                            <a class="HomePage_Link" href="#">Quản lý câu hỏi</a></div>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
        </form>
    </center>
</body>
</html>
