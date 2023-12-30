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
        @date       : August 15, 2003
        @description:
     --%>
    <head>
        <title>Show the Permission detail</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
            String sql = "select * from Permissions";
            xmlDoc = DBResults.transferXML(conPool, sql);
        	if (xmlDoc == null) {
%>
        <h3 align="center">
            Danh muïc queàn roãng. 
            <a href="preparePermission.jsp">
                &nbsp;Taïo môùi&nbsp;<img src="../images/new.gif" border="0" />
            </a>
        </h3>
<%
            }
            else {
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Chi Tieát Caùc Quyeàn</font></h3>
        <xslt:apply xsl="/xslt/showPermission.xsl">
            <%= xmlDoc %>
        </xslt:apply>
        <p>
            <a href="../html/controlPermission.html">Trôû veà trang ñieàu khieån</a>
        </p>
<%
            }
        }
    }
%>
    </body>
</html>