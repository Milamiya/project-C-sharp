<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.DBResults,
                     java.sql.ResultSet,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 16, 2003
        @description: Set up the work between two employees.
     --%>
    <head>
        <title>Set up the Work</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");

    if (conPool != null) {
        String work = request.getParameter("work");
        String staff1 = request.getParameter("staff1");
        String staff2 = request.getParameter("staff2");

        String sql = "select * from phancong where manv='"
                   + staff1 + "' and macv=" + work;
        ResultSet rs = DBResults.executeQuery(conPool, sql);
        if (rs.next()) { // the only one record.
            sql = "insert into phancong(macv, manv, ngaybd, thietlap) values('"
                + staff2 + "', " + work + ", now(), 1)";
            int affectedRow = DBResults.executeUpdate(conPool, sql);
%>
        <h3 align="center">
            <font face="VNI-Times, VNI-Helve" color="#AA0000">Hai nhaân vieân ñaõ ñöôïc chuyeån giao coâng vieäc.</font>
            <br /><a href="setupWork.jsp">Trôû veà trang tröôùc</a>
        </h3>
<%
        }
        else {
%>
        <h3 align="center">
            <font face="VNI-Times, VNI-Helve" color="#AA0000">Nhaân vieân naøy khoâng coù coâng vieäc naøy.</font>
            <br /><a href="setupWork.jsp">Trôû veà trang tröôùc</a>
        </h3>
<%
        }
        rs.close();
    }
%>
    </body>
</html>