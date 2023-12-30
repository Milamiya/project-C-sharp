<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults,
                     java.sql.ResultSet,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 29, 2003
        @description:
     --%>
    <head>
        <title>Preparation for Setting Permission</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");

    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        String xmlDoc = null;
        if (conPool != null) {
            String sql = "select * from permissions";
            xmlDoc = DBResults.transferXML(conPool, sql);
        }
%>
        <form name="frmSetPermission" action="dbSetPermission.jsp" name="POST">
            <h3 align="center"><font face="VNI-Times" color="#AA0000">Gaùn Quyeàn Cho Nhoùm</font></h3>
            <table border="0">
                <tr align="center">
                    <td><b><font face="VNI-Times, VNI-Heleve">Teân Nhoùm:</font></b></td>
                    <td>
                        <select name="group">
<%
        String sql = "select magroup, tengroup from groups";
        ResultSet rs = DBResults.executeQuery(conPool, sql);
        while (rs.next()) {
            String groupid = rs.getString(1);
            String groupName = rs.getString(2);
%>
                            <option value="<%= groupid %>"><%= groupName %></option>
<%
        }
        rs.close();
%>                        </select>
                    </td>
                </tr>
                <tr align="left">
                    <td><b><font face="VNI-Times, VNI-Heleve">Haõy Choïn Caùc Quyeàn</font></b></td>
                    <xslt:apply xsl="/xslt/deletePermission.xsl">
                        <%= xmlDoc %>
                    </xslt:apply>
                </tr>
            </table>
            <p align="center">
                <input type="submit" name="setPermission" value="  OK   " />
            </p>
        </form>
<%
    }
%>
    </body>
</html>