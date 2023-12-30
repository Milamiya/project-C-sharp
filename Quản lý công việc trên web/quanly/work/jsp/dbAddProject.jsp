<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     com.dinhgiang.beans.UserBean,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 28, 2003
        @description:
     --%>
    <head>
        <title>Add a Record into Database</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String name = request.getParameter("name");
        String place = request.getParameter("place");

        String sql = "insert into dean(TenDA, DiaDiem, Ngay) values('"
                   + name + "', '" + place + "', now())";

        /* Showing a error page If it isn't sucessfull */
        int rowAffected = DBResults.executeUpdate(conPool, sql);
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Th��c hie�n tha�nh co�ng</font></h3>
        <font face="VNI-Times" size="-1">D�� lie�u �a� l�u va�o c� s�� d�� kie�u.</font>
	  <hr />
        <a href="prepareJob.jsp">Tr�� la�i trang <font color="#FF0066">the�m co�ng vie�c</font></a>
    </body>
</html>