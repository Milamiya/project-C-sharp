<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
        import="java.sql.Connection,
                com.dinhgiang.utils.DBResults"
        errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 15, 2003
        @description: display a table to prepare for modifing
        a Group. Data get from table 'Groups' in database
        'CongViec'
     --%>
    <head>
        <title>Group is deleting</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (conPool != null) {
        //String[] values = new String[50];
        String[] values = request.getParameterValues("deleteStaff");
        //out.println("Length: " + values.length + "<br/>");
        for (int i = 0; i < values.length; i++) {
            //out.println("value " + i + ": " + values[i] + "<br/>");
            String sql = "delete from nhanvien where manv=" + values[i];
            /* Showing a error page If it isn't sucessfull */
            int rowAffected = DBResults.executeUpdate(conPool, sql);
        }
    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1"> Maåu tin ñaõ ñöôïc xoaù.</font>
	  <hr />
        <%@ include file="../html/footerStaff.html" %>
    </body>
</html>