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
        String[] ids = request.getParameterValues("id");
        String[] feedbacks = request.getParameterValues("feedback");

        for (int i = 0; i < feedbacks.length; i++) {
            if (!feedbacks[i].equals("")) {
                String sql = "update danhgia set phanhoi='"
                           + feedbacks[i] + "' where madg=" + ids[i];
                //out.println("\r\nSQL " + i +  ":" + sql);
                /* Showing a error page If it isn't sucessfull */
                int rowAffected = DBResults.executeUpdate(conPool, sql);
            }
        }

    }
%>
        <h3><font face="VNI-Times" color="#AA0000">Thöïc hieän thaønh coâng</font></h3>
        <font face="VNI-Times" size="-1">Döõ lieäu ñaõ löu vaøo cô sôû döõ kieäu.</font>
    </body>
</html>