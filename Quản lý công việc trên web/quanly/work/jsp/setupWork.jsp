<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults,
                     java.sql.ResultSet,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 30, 2003
        @description: Set up the work between two employees.
     --%>
    <head>
        <title>Set up the Work</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");

        if (conPool != null) {
%>
        <form name="frmSetupWork" action="dbSetupWork.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Thieát Laäp Cheá Ñoä Laøm Vieäc Giöõa Hai Nhaân Vieân</font></h3>
            <table border="0" align="center" cellspacing="10">
                <tr>
                    <!-- Nhan Vien 1 -->
                    <td>
                        <b><font face="VNI-Times, VNI-Helve">Nhaân Vieân</font></b>
                        <select name="staff1">
<%
        String sql = "select manv, tennv from nhanvien";
        ResultSet rs = DBResults.executeQuery(conPool, sql);
        while(rs.next()) {
            String staffid = rs.getString(1);
            String staffName = rs.getString(2);
%>
                            <option value="<%= staffid %>"><%= staffName %></option>
<%
        }
%>
                        </select>
                    </td>
                    <td>
                        <b><font face="VNI-Times, VNI-Helve">Coù CV</font></b>
                        <!-- Cong Viec 1 -->
                        <select name="work">
<%
        sql = "select macv, tencv from works";
        rs = DBResults.executeQuery(conPool, sql);
        while(rs.next()) {
            String workid = rs.getString(1);
            String workName = rs.getString(2);
%>
                            <option value="<%= workid %>"><%= workName %></option>
<%
        }
%>
                        </select>
                   </td>
                </tr>
                <tr>
                    <!-- Nhan Vien 2 -->
                    <td><b><font face="VNI-Times, VNI-Helve">Chuyeån Giao Cho Nhaân Vieân </font></b></td>
                    <td>
                        <select name="staff2">
<%
        sql = "select manv, tennv from nhanvien";
        rs = DBResults.executeQuery(conPool, sql);
        while(rs.next()) {
            String staffid = rs.getString(1);
            String staffName = rs.getString(2);
            String option = "";
            if (rs.getRow() == 2) {
                option = "selected";
            }
%>
                            <option value="<%= staffid %>" <%= option %>><%= staffName %></option>
<%
        }
%>
                        </select>
                    </td>
                </tr>
            </table>
            <p align="center">
                <input type="submit" name="dbSetupWork" value="  OK   " />
            </p>
        </form>
<%
        }
    }
%>
    </body>
</html>