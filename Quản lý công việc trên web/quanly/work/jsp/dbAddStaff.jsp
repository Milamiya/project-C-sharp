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
        <title>Add a Group Record</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String id = request.getParameter("staffid");
        String name = request.getParameter("name");
        String birthday = request.getParameter("birthday");
        String sex = request.getParameter("sex");
        String address = request.getParameter("address");

        String phone = request.getParameter("phone");
        phone = phone.equals("") ? "null" : phone;

        String groupid = request.getParameter("group");
        String username = request.getParameter("username");
        String password = request.getParameter("password");

        sex = (sex == null) ? "0" : "1";

        String sql = "insert into nhanvien values("
            + id + ", " + groupid + ", '" + name + "', '"
            + birthday + "', '" + address + "', " + sex
            + ", '" + phone + "', '" + username + "', '"
            + password + "')";

        /* Showing a error page If it isn't sucessfull */
        int rowAffected = DBResults.executeUpdate(conPool, sql);
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1">Döõ lieäu ñaõ löu vaøo cô sôû döõ kieäu.</font>
	  <hr />
        <%@ include file="../html/footerStaff.html" %>
    </body>
</html>