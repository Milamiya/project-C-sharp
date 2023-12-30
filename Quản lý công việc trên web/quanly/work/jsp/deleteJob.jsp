<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 28, 2003
        @description:
     --%>
    <head>
        <title>Preparation for deleting</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");

    if (conPool != null) {
        String sql = "select * from works";
        xmlDoc = DBResults.transferXML(conPool, sql);
        if (xmlDoc == null) {
%>
        <h3 align="center">
            <font face="VNI-Times">Danh mu�c co�ng vie�c ro�ng.</font>
            <a href="prepareJob.jsp">
                &nbsp;Ta�o m��i&nbsp;<img src="../images/new.gif" border="0" />
            </a>
        </h3>
<%
        }
        else {
%>
        <h3 align="center">
            <font face="VNI-Times" color="#AA0000">Ha�y Cho�n Mo�t Hoa�c Nhie�u Mu�c Muo�n Xoa�</font>
        </h3>
        <form name="frmDeleteJob" action="dbDeleteJob.jsp" method="POST">
            <xslt:apply xsl="/xslt/deleteJob.xsl">
                <%= xmlDoc %>
            </xslt:apply>
            <p align="right">
               <input type="submit" name="subOK" value="  OK   " />
               <%-- <a href="javascript:form.submit()">
                    <img src="../images/removeVN.gif" alt="Huy" border="0" />
                 </a>
                 --%>
            </p>
        </form>
        <p align="right">
            <a href="../html/controlJob.html">Tr�� ve� trang �ie�u khie�n</a>
        </p>
<%
        }
    }
%>
    </body>
</html>