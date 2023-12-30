<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults,
                     java.sql.Connection,
                     java.sql.ResultSet"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 17, 2003
        @description: See Assigned Work.
     --%>
    <head>
        <title>Combine Report</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {

            String sql = "select macv, tencv from works";

            ResultSet rs = DBResults.executeQuery(conPool, sql);
            if (rs.next()) {
%>
        <form name="frmCombineReport" action="combineReport.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Toång Hôïp Baùo Caùo</font></h3>
            <table border="0" align="center">
                <tr>
                    <td>
                        <b><font face="VNI-Times, VNI-Helve">Choïn CV Ñeå Toång Hôïp</font></b>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <select name="work" multiple size="5">
<%
                boolean done = true;
                while(done) {
                    String workId = rs.getString(1);
                    String workName = rs.getString(2);
                    String option = "";
                    if (rs.getRow() == 1) {
                        option = "selected";
                    }

%>
                            <option value="<%= workId %>" <%= option %>><%= workName %></option>
<%
                    done = rs.next();
                }
%>
                        </select>
                    </td>
                </tr>
            </table>
            <p align="center">
                <input type="submit" name="combineReport" value="  OK   " />
            </p>
        </form>
<%
            }
            else {
%>
        <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Danh muïc coâng vieäc roãng</font></h3>
<%
            }
        }
    }
%>
    </body>
</html>