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
        @date       : August 19, 2003
        @description: display a table to prepare for modifing
        a staff. Data get from table 'Staff' in database
        'CongViec'
     --%>
    <head>
        <title>Staff is modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%!
    String id, name, idOfGroup, birthday, address, phone;
    String sex, username, password; // No change
    String header, file, type;
%>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (user != null) {

        String idRequest = request.getParameter("staffid");
        if (idRequest != null) {

            header = "Ca�p Nha�t Danh Mu�c Nha�n Vie�n";
            file = "dbModifyStaff.jsp";
            type = "hidden";
            if (conPool != null) {

                String sql = "select * from nhanvien where manv='" + idRequest + "'";
                ResultSet rs = DBResults.executeQuery(conPool, sql);
                if (rs.next()) { // one and only record
                    id = rs.getString(1);
                    idOfGroup = rs.getString(2);
                    name = rs.getString(3);
                    birthday = rs.getString(4);
                    address = rs.getString(5);
                    sex = rs.getString(6);
                    phone = rs.getString(7);
                    username = rs.getString(8);
                    password = rs.getString(9);
                }
                rs.close();
            }
        }
        else {
            id = "000000000";
            idOfGroup = "";
            name = "";
            birthday = "yyyy/mm/dd";
            address = "";
            sex = "";
            phone = "";
            username = "";
            password = "";

            header = "The�m Va�o Danh Mu�c Nha�n Vie�n";
            file = "dbAddStaff.jsp";
            type = "text";
        }
    }
%>
    <div align="center">
        <h3><font face="VNI-Times, VNI-Helve" color="#AA0000"><%= header %></font></h3>
        <form name="frmPrepareStaff" action="<%= file %>" method="POST">
            <table>
                <tr>
                    <td><b><font face="VNI-Times">Ma� NV*:</font></b></td>
                    <td><% if (type.equals("hidden")) {out.println(id);} %><input type="<%= type %>" name="staffid" value="<%= id %>" size="10" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Te�n NV*:</font></b></td>
                    <td><input type="text" name="name" value="<%= name %>" size="32" /></td>
                </tr>
<% if (id.equals("000000000")) { %>
                <tr>
                    <td><b><font face="VNI-Times">Nga�y Sinh*:</font></b></td>
                    <td>
                        <input type="text" name="birthday" value="<%= birthday %>" size="12" />
                        <b><font face="VNI-Times">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pha�i:</font></b>
                        <input type="checkbox" name="sex" /> <%-- value="<%= sex %>"  --%>
                    </td>
                </tr>
<% } %>
                <tr>
                    <td><b><font face="VNI-Times">��a Ch�*:</font></b></td>
                    <td><input type="text" name="address" value="<%= address %>" size="32" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">�ie�n Thoa�i:</font></b></td>
                    <td><input type="text" name="phone" value="<%= phone %>" size="32" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Trong Nho�m*:</font></b></td>
                    <td>
                        <select name="group">
<%
    String sql = "select magroup, tengroup from groups";
    ResultSet rs = DBResults.executeQuery(conPool, sql);
    if (rs != null) { // one and only record
        while (rs.next()) {
            String groupId = rs.getString(1);
            String groupName = rs.getString(2);

            /*- if request from update page and had group
                chief, set default value with this value.
             */
            String option = "";
            if (groupId.equals(idOfGroup)) {
                option = "selected";
            }
%>
                            <option value="<%= groupId %>" <%= option %>><%= groupName %></option>
<%
        } // end of while
        rs.close();
    } // end of if
%>
                        </select>
                    </td>
                </tr>
<% if (id.equals("000000000")) { %>
                <tr>
                    <td><b><font face="VNI-Times">Te�n �a�ng Nha�p*:</font></b></td>
                    <td><input type="text" name="username" value="<%= username %>" size="32" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Ma�t Kha�u:</font></b></td>
                    <td><input type="password" name="password" size="32" /></td> <%-- value="<%= password %>" --%>
                </tr>
<% } %>
            </table>
            <br />
            <input type="submit" name="save" value="  OK   " />
            <% if (type.equals("text")) { // == true %>
            <input type="reset" name="new" value="Reset" />
            <% } %>
        </form>
    </div>
    <p align="center">
        <%@ include file="../html/footerStaff.html" %>
    </p>
    </body>
</html>