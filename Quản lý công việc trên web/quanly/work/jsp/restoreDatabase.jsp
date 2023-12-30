<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.JobPool,
                     java.sql.Connection,
                     java.sql.ResultSet,
                     java.sql.SQLException,
                     com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 30, 2003
        @description: Refresh Database.
     --%>
    <head>
        <title>Refresh Database</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {

            String[] tables = {"Files", "GopY", "BaoCaoNgay", "BaoCaoTongHop",
                  "DanhGia", "DeAn", "ThietLap", "Works", "PhanCong"};

            String restoreDB = request.getParameter("restoreDB");
            String database = "CREATE DATABASE IF NOT EXISTS " + restoreDB;
            int affectedRow = DBResults.executeUpdate(conPool, database);
            if (affectedRow > 0) {
                database = "DROP DATABASE " + restoreDB;
                affectedRow = DBResults.executeUpdate(conPool, database);
%>
        <h3><font face="VNI-Times" color="#AA0000">Khoâng coù cô sôû döõ lieäu <%= restoreDB %>, <%= affectedRow %></font></h3>
<%
            }
            else {
                for (int i = 0; i < 9; i++) {
                    // Insert data into a new table in a new database
                    String sql = "load data infile '" + restoreDB + "/" + tables[i]
                               + "_Data.txt' replace into table CongViec." + tables[i];
                    affectedRow = DBResults.executeUpdate(conPool, sql);
                }
%>
	<h3><font face="VNI-Times" color="#AA0000">Cô sôû döõ lieäu ñaõ hoaøn toaøn khoâi phuïc</font></h3>
<%
            }
        }
    }
%>
    </body>
</html>