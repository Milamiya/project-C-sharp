<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="java.sql.Connection,
                     com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 05, 2003
        @description: see employee information.
     --%>
    <head>
        <title>Update Value</title>
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {
        String id = request.getParameter("id");
        String work = request.getParameter("work");
        String grade = request.getParameter("grade");
        String comment = request.getParameter("comment");

        String sql = "insert into DanhGia(madg, maxl, chuthich, ngay) values("
                   + id + ", " + grade + ", '" + comment + "', now())";
        int rowAffected = DBResults.executeUpdate(conPool, sql);

        if (rowAffected > 0) {
            sql = "update Works set madg=" + id
                + " where macv=" + work;
            rowAffected = DBResults.executeUpdate(conPool, sql);
        }
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1">Döõ lieäu ñaõ löu vaøo cô sôû döõ kieäu.</font>
    </body>
</html>