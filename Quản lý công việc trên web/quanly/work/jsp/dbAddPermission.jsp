<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 19, 2003
        @description:
     --%>
    <head>
        <title>Add a Permission Record</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String name = request.getParameter("name");
        String comment = request.getParameter("comment");
        comment = comment.equals("") ? "null" : comment;

        String sql = "insert into permissions(TenPer, GhiChu) values('"
        		 + name + "', '" + comment + "')";

        /* Showing a error page If it isn't sucessfull */
        int rowAffected = DBResults.executeUpdate(conPool, sql);
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1">Döõ lieäu ñaõ löu vaøo cô sôû döõ kieäu.</font>
	  <hr />
        <%@ include file="../html/footerPermission.html" %>
    </body>
</html>