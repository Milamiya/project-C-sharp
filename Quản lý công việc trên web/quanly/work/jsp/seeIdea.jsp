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
        @description: see employee information.
     --%>
    <head>
        <title>Show the Staff Detail</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
            String sql = "select manv, tennv, ngaysinh, diachi, "
                       + "phone, tengroup from nhanvien, groups "
                       + "where nhanvien.magroup=groups.magroup";
            xmlDoc = DBResults.transferXML(conPool, sql);
        }
    }
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Choïn Moät Nhaân Vieân Caàn Xem Goùp YÙ </font></h3>
        <xslt:apply xsl="/xslt/seeIdea.xsl">
            <%= xmlDoc %>
        </xslt:apply>
    </body>
</html>