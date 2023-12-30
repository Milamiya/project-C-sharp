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
        <title>Add a Group Record</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String name = request.getParameter("name");
        String chief = request.getParameter("chief");
        String date = request.getParameter("date");

        String sql = "insert into groups(TenGroup, TrgGroup, NgayNC) values('"
			 + name + "', '" + chief + "', '" + date + "')";

        /* Showing a error page If it isn't sucessfull */
        int rowAffected = DBResults.executeUpdate(conPool, sql);
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Th��c hie�n tha�nh co�ng</font></h3>
        <font face="VNI-Times" size="-1">D�� lie�u �a� l�u va�o c� s�� d�� kie�u.</font>
	  <hr />
        <%@ include file="../html/footerGroup.html" %>
    </body>
</html>