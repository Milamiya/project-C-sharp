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
        @date       : August 30, 2003
        @description:
     --%>
    <head>
        <title>Show the Group detail</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
            String sql = "select * from Groups";
            xmlDoc = DBResults.transferXML(conPool, sql);
        	if (xmlDoc == null) {
%>
        <h3 align="center">
            Danh mu�c nho�m ro�ng. 
            <a href="prepareGroup.jsp">
                &nbsp;Ta�o m��i&nbsp;<img src="../images/new.gif" border="0" />
            </a>
        </h3>
<%
            }
            else {
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Danh Sa�ch Nho�m</font></h3>
        <xslt:apply xsl="/xslt/showGroup.xsl">
            <%= xmlDoc %>
        </xslt:apply>
        <p>
            <a href="../html/controlGroup.html">Tr�� ve� trang �ie�u khie�n</a>
        </p>
<%
            }
        }
    }
%>
    </body>
</html>