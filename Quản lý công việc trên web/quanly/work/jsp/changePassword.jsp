<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 24, 2003
        @description: Thay doi pw
     --%>
    <head>
        <title>Change Password</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    String username = "";
    String password = "";
    if (user != null) {
        username = user.getUserId();
        password = user.getPassword();
    }
%>
        <form name="frmChangePassword" action="dbChangePassword.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times" color="#AA0000">Ha�y Thay �o�i Ma�t Kha�u Cu�a Ba�n</font><h3>
            <table align="center">
                <tr>
                    <td><b><font face="VNI-Times">Te�n �a�ng Nha�p*:</font></b></td>
                    <td><input type="text" name="usernameTemp" value="<%= username %>" disabled /></td>
                    <input type="hidden" name="username" value="<%= username %>" />
                    <input type="hidden" name="password" value="<%= password %>" />
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Ma�t Kha�u Cu�*:</font></b></td>
                    <td><input type="password" name="oldPassword" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Ma�t Kha�u M��i:</font></b></td>
                    <td><input type="password" name="newPassword" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Xa�c ��nh La�i:</font></b></td>
                    <td><input type="password" name="confirmPassword" /></td>
                </tr>
            </table>
            <p align="center">
                &nbsp;<input type="submit" name="changePassword" value="  OK   " />
            </p>
        </form>
    </body>
</html>