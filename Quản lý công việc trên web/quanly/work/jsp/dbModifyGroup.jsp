<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
        import="java.sql.Connection,
                java.sql.ResultSet,
                com.dinhgiang.utils.DBResults"
        errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 15, 2003
        @description: display a table to prepare for modifing
        a permission. Data get from table 'Permission' in database
        'CongViec'
     --%>
    <head>
        <title>Group is modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String id = request.getParameter("groupid");
        String name = request.getParameter("name");
        String chief = request.getParameter("chief");
        String date = request.getParameter("date");

        String sql = "update groups set tengroup='"
                   + name + "',trggroup='" + chief + "',ngaync='"
                   + date + "' where magroup=" + id;

        /* Showing a error page If it isn't sucessfull */
        int rowAffected = DBResults.executeUpdate(conPool, sql);
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1">Döõ lieäu ñaõ ñöôïc thay ñoåi trong cô sôû döõ kieäu.</font>
	  <hr />
        <%@ include file="../html/footerGroup.html" %>
    </body>
</html>