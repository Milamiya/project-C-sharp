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
            String sql = "select works.macv, tencv, noidung, daxong, "
                       + "tenda from works, dean, phancong "
                       + "where works.mada=dean.mada and phancong.macv=works.macv "
                       + "and phancong.manv='" + staffId + "'";
            xmlDoc = DBResults.transferXML(conPool, sql);
        }
    }
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Danh Saùch Coâng Vieäc</font></h3>
<%
    if (xmlDoc == null) {
%>
            <font face="VNI-Times, VNI-Helve" size="+1">Nhaân vieân naøy chöa coù coâng vieäc naøo.</font>
<%
    }
    else {
%>
        <xslt:apply xsl="/xslt/showJob.xsl">
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