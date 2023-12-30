<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>
    <%@ page language="java"
        import="java.sql.Connection,
                com.dinhgiang.utils.JobPool,
                com.dinhgiang.utils.DBResults"
        errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 15, 2003
        @description: display a table to prepare for modifing
        a group. Data get from table 'Groups' in database
        'CongViec'
     --%>
    <head>
        <title>Preparation for modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");

    if (conPool != null) {
        String sql = "select * from NhanVien";
        xmlDoc = DBResults.transferXML(conPool, sql);
        if (xmlDoc == null) {
%>
        <h3 align="center">
            Danh muïc nhaân vieân roãng. 
            <a href="prepareStaff.jsp">
                &nbsp;Taïo môùi&nbsp;<img src="../images/new.gif" border="0" />
            </a>
        </h3>
<%
        }
        else {
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Haõy Choïn Muïc Muoán Söûa</font></h3>
        <form name="frmModifyStaff">
            <xslt:apply xsl="/xslt/modifyStaff.xsl">
                <%= xmlDoc %>
            </xslt:apply>
        </form>
        <p align="right">
            <a href="../html/controlStaff.html">Trôû veà trang ñieàu khieån</a>
        </p>
<%
        }
    }
%>
    </body>
</html>