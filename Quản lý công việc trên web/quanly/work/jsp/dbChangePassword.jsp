<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 27, 2003
        @description:
     --%>
    <head>
        <title>Change Password</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    String confirmError = "";
    String enterError = "";
    if (conPool != null) {

        String user = request.getParameter("username");
        String pwd = request.getParameter("password");
        String oldP = request.getParameter("oldPassword");
        String newP = request.getParameter("newPassword");
        String conP = request.getParameter("confirmPassword");
        if (pwd.equals(oldP)) {
            if (conP.equals(newP)) {

                String sql = "update nhanvien set password='"
                    + newP + "' where username='" + user
                    + "' and password='" + oldP + "'";
                int rowAffected = DBResults.executeUpdate(conPool, sql);
                if (rowAffected > 0) {
%>
        <h3><font face="VNI-Times" color="#AA0000">Th��c hie�n tha�nh co�ng</font></h3>
        <font face="VNI-Times" size="-1">Ma�t kha�u �a� ����c thay �o�i.</font>
        <hr />
        <a href="../jsp/logOut.jsp" target="_top">Thoa�t kho�i ng���i du�ng na�y �e� �a�ng nha�p la�i v��i ma�t kha�u m��i</a>
<%
                }
            }
            else {
                confirmError = "Confirming Password is wrong";
%>
        <h3><font face="VNI-Times" color="#AA0000">Xua�t hie�n lo�i khi thay �o�i ma�t kha�u.</font></h3>
        <%= confirmError %>
<%
            }
        }
        else {
            enterError = "Password is wrong.";
%>
        <h3><font face="VNI-Times" color="#AA0000">Xua�t hie�n lo�i khi thay �o�i ma�t kha�u.</font></h3>
        <%= enterError %>
<%
        }
    }
%>
    </body>
</html>