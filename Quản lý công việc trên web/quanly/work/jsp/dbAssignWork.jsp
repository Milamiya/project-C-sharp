<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 30, 2003
        @description: Assigned Work
     --%>
    <head>
        <title>Assigned Work</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
            String staff = request.getParameter("staff");
            String[] jobids = request.getParameterValues("deleteJob");
            String end = request.getParameter("endDate");
            String start = request.getParameter("startDate");

            for (int i = 0; i < jobids.length; i++) {
                String sql = "insert into phancong(manv, macv, ngaybd, ngaykt) "
                           + "values('" + staff + "', " + jobids[i] + ", '"
                           + start + "', '" + end + "')";
                /* Showing a error page If it isn't sucessfull */
                int rowAffected = DBResults.executeUpdate(conPool, sql);
            }
        }
%>
        <h2><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng </font></h2>
        <font face="VNI-Times" size="-1">Coâng vieäc ñaõ phaân coâng cho nhaân vieân.</font>
        <a href="assignWork.jsp">Tieáp tuïc</a>
    </body>
</html>