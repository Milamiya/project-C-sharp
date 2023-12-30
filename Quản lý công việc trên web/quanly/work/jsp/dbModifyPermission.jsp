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
        <title>Permission is modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String id = request.getParameter("perid");
        String name = request.getParameter("name");
        String comment = request.getParameter("comment");

        String sql = "update permissions set tenper='"
        + name + "',ghichu='" + comment + "' where maper=" + id;

        /* Showing a error page If it isn't sucessfull */
        int rowAffected = DBResults.executeUpdate(conPool, sql);
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Th��c hie�n tha�nh co�ng</font></h3>
        <font face="VNI-Times" size="-1">D�� lie�u �a� ����c thay �o�i trong c� s�� d�� kie�u.</font>
	  <hr />
        <%@ include file="../html/footerPermission.html" %>
    </body>
</html>