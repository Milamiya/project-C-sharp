<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>
    <%@ page language="java"
             import="com.dinhgiang.utils.JobPool,
                     java.sql.Connection,
                     com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 28, 2003
        @description:
     --%>
    <head>
        <title>Show the Job Detail</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
            String staffId = request.getParameter("staffInfoId");

            String sql = "select magy, noidung, gopy.ngay, mafile "
                       + "from gopy, files "
                       + "where (gopy.magy=files.mabc) "
                       + "and (gopy.manv='" + staffId + "')";

            xmlDoc = DBResults.transferXML(conPool, sql);
        }
    }
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Goùp YÙ Cuûa Nhaân Vieân</font></h3>
<%
    if (xmlDoc == null) {

%>
        <font face="VNI-Times" size="+1">Nhaân vieân naøy chöa coù goùp yù naøo.</font>
<%
    }
    else {

%>
        <xslt:apply xsl="/xslt/seeSuggestion.xsl">
            <%= xmlDoc %>
        </xslt:apply>
<%
    }
%>
        <p align="center">
            <input type="button" name="btnBack" value="Back" onclick="history.back()" />
        </p>
    </body>
</html>