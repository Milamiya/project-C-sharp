<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
        import="java.sql.Connection,
                java.sql.ResultSet,
                java.util.GregorianCalendar,
                com.dinhgiang.utils.DBResults,
                com.dinhgiang.beans.UserBean"
        errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 19, 2003
        @description: display a table to prepare for modifing
        a permission. Data get from table 'Permission' in database
        'CongViec'
     --%>
    <head>
        <title>Group is modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%!
    String id, name, chief, date;
    String header, file, type;
%>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (user != null) {

        String idRequest = request.getParameter("groupid");
        if (idRequest != null) {

            header = "Caäp Nhaät Danh Muïc Nhoùm";
            file = "dbModifyGroup.jsp";
            type = "hidden";
            if (conPool != null) {

                String sql = "select * from Groups where magroup=" + idRequest;
                ResultSet rs = DBResults.executeQuery(conPool, sql);
                if (rs.next()) { // one and only record
                    id = rs.getString(1);
                    name = rs.getString(2);
                    chief = rs.getString(3);
                    date = rs.getString(4);
                }
                rs.close();
            }
        }
        else {
            id = "";
            name = "";
            chief = "";

            GregorianCalendar calendar = new GregorianCalendar();
            int day = calendar.get(GregorianCalendar.DATE);
            int month = calendar.get(GregorianCalendar.MONTH) + 1;
            int year = calendar.get(GregorianCalendar.YEAR);
            date = "" + year + "/" + month + "/" + day;
            header = "Theâm Vaøo Danh Muïc Nhoùm";
            file = "dbAddGroup.jsp";
            type = "text";
        }
    }
%>
    <div align="center">
        <h3><font face="VNI-Times, VNI-Helve" color="#AA0000"><%= header %></font></h3>
        <form name="frmPrepareGroup" action="<%= file %>" method="POST">
            <table>
<% 
    if (type.equals("hidden")) { 
%>
                <tr>
                    <td><b><font face="VNI-Times">Maõ Nhoùm:</font></b></td>
                    <td><%= id %><input type="<%= type %>" name="groupid" value="<%= id %>" size="10" /></td>
                </tr>
<%
    }
%>
                <tr>
                    <td><b><font face="VNI-Times">Teân Nhoùm*:</font></b></td>
                    <td><input type="text" name="name" value="<%= name %>" size="32" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Tröôûng Nhoùm*:</font></b></td>
                    <td>
                        <select name="chief">
<%
    String sql = "select manv, tennv from nhanvien";
    ResultSet rs = DBResults.executeQuery(conPool, sql);
    if (rs != null) { // one and only record
        while (rs.next()) {
            String staffId = rs.getString(1);
            String staffName = rs.getString(2);

            /*- if request from update page and had group
                chief, set default value with this value.
             */
            if (staffId.equals(chief)) {
%>
                            <option value="<%= staffId %>" selected><%= staffName %></option>
<%
            }
            else {
%>                          <option value="<%= staffId %>"><%= staffName %></option>
<%
            } // end of if else
        } // end of while
        rs.close();
    } // end of if
%>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Ngaøy Nhaän Chöùc*:</font></b></td>
                    <td><input type="text" name="date" value="<%= date %>" size="32" /></td>
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
        <%@ include file="../html/footerGroup.html" %>
    </p>
    </body>
</html>