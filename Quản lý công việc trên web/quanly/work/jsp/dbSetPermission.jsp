<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 29, 2003
        @description:
     --%>
    <head>
        <title>Set Permission</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {

        String group = request.getParameter("group");
        String[] perids = request.getParameterValues("deletePermission");

        for (int i = 0; i < perids.length; i++) {
            String sql = "insert into groups_per(maper, magroup) values("
                       + perids[i] + ", " + group + ")";
            /* Showing a error page If it isn't sucessfull */
            int rowAffected = DBResults.executeUpdate(conPool, sql);
        }
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1">Quyeàn ñaõ ñöôïc gaùn cho nhoùm.</font>
    </body>
</html>