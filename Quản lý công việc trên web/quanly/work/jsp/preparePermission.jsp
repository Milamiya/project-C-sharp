<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
        import="java.sql.Connection,
                java.sql.ResultSet,
                com.dinhgiang.utils.DBResults,
                com.dinhgiang.beans.UserBean"
        errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : AUGUST 19, 2003
        @description: display a table to prepare for modifing
        a permission. Data get from table 'Permission' in database
        'CongViec'
     --%>
    <head>
        <title>Permission is modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%!
    String id, name, comment;
    String header, file, type;
%>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        String idRequest = request.getParameter("perid");
        if (idRequest != null) {

            header = "Caäp Nhaät Danh Muïc Quyeàn";
            file = "dbModifyPermission.jsp";
            type = "hidden";
            Connection conPool = (Connection) session.getAttribute("conJobPool");
            if (conPool != null) {

                String sql = "select * from Permissions where maper=" + idRequest;
                ResultSet rs = DBResults.executeQuery(conPool, sql);
                if (rs.next()) { // one and only record
                    id = rs.getString(1);
                    name = rs.getString(2);
                    comment = rs.getString(3);
                }
            }
        }
        else {
            id = "";
            name = "";
            comment = "";
            header = "Theâm Vaøo Danh Muïc Quyeàn";
            file = "dbAddPermission.jsp";
            type = "text";
        }
    }
%>
    <div align="center">
        <h3><font face="VNI-Times, VNI-Helve" color="#AA0000"><%= header %></font></h3>
        <form name="frmPreparePermission" action="<%= file %>" method="POST">
            <table>
<% 
    if (type.equals("hidden")) { 
%>
                <tr>
                    <td><b><font face="VNI-Times">Maõ Quyeàn:</font></b></td>
                    <td><%= id %><input type="<%= type %>" name="perid" value="<%= id %>" size="10" /></td>
                </tr>
<%
    }
%>
                <tr>
                    <td><b><font face="VNI-Times">Teân Quyeàn*:</font></b></td>
                    <td><input type="text" name="name" value="<%= name %>" size="32" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Ghi Chuù:</font></b></td>
                    <td><textarea name="comment" rows="3" cols="30" ><%= comment %></textarea></td>
                </tr>
            </table>
            <br />
            <input type="submit" name="save" value="  OK   " />
            <% if (type.equals("text")) { // == true %>
            <input type="reset" name="new" value="Reset" />
            <% } %>
        </form>
    </div>
    <p align="center">
        <%@ include file="../html/footerPermission.html" %>
    </p>
    </body>
</html>