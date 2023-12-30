<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UploaderBean,
                     com.dinhgiang.utils.DBResults,
                     java.sql.Connection,
                     java.util.Enumeration"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 24, 2003
        @description: add a date report into Database Server,
        stores in tables File and BaoCaoNgay.
     --%>
    <head>
        <title>Add a Date Report</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
//    Connection conPool = (Connection) session.getAttribute("conJobPool");
//    if (conPool != null) {
        UploaderBean upload = UploaderBean.getInstance(request);
        String sql = upload.makeInsertSQL("BaoCaoNgay");
        String[] sqls = upload.makeSQLStatement();
        String up = upload.makeUpdateSQL("BaoCaoNgay");
//      int rowAffected = DBResults.executeUpdate(con, sql);
//    }
    // otherwise, catch exception (error.jsp)
%>
In SQL Statement: <%= sql %> <br />
Up SQL Statement: <%= up %><br />
<%
    for (int i = 0; i < sqls.length; i++) {
        if (sqls[i] == null) {
            break;
        }
        out.println("sql " + i + ": " + sqls[i] + "<br />");
    }
%>
    </body>
</html>