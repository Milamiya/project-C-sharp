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
        a Job. Data get from table 'Job' in database
        'CongViec'
     --%>
    <head>
        <title>Job is modifing</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%!
    String id, name, idOfProject, content, finish; // idOfEstimate don't change
    String header, file, type;
%>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    Connection conPool = (Connection) session.getAttribute("conJobPool");
    if (user != null) {

        String idRequest = request.getParameter("jobid");
        if (idRequest != null) {

            header = "Caäp Nhaät Danh Muïc Coâng Vieäc";
            file = "dbModifyJob.jsp";
            type = "hidden";
            if (conPool != null) {

                String sql = "select * from works where macv=" + idRequest;
                ResultSet rs = DBResults.executeQuery(conPool, sql);
                if (rs.next()) { // one and only record
                    id = rs.getString(1);
                    idOfProject = rs.getString(2);
                    //idOfEstimate = rs.getString(3); // idOfEstimate discarded
                    name = rs.getString(4);
                    content = rs.getString(5);
                    finish = rs.getString(6);
                }
                rs.close();
            }
        }
        else {
            id = "";
            idOfProject = "";
            name = "";
            name = "";
            content = "";
            finish = "";

            header = "Theâm Vaøo Danh Muïc Coâng Vieäc";
            file = "dbAddJob.jsp";
            type = "text";
        }
    }
%>
    <div align="center">
        <h3><font face="VNI-Times, VNI-Helve" color="#AA0000"><%= header %></font></h3>
        <form name="frmPrepareJob" action="<%= file %>" method="POST">
            <table>
<% 
    if (type.equals("hidden")) { 
        String check = (finish.equals("0")) ? "" : "checked";
%>
                <tr>
                    <td><b><font face="VNI-Times">Maõ CV:</font></b></td>
                    <td><%= id %><input type="<%= type %>" name="jobid" value="<%= id %>" size="10" />
                        <b><font face="VNI-Times">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hoaøn Thaønh?:</font></b>
                        <input type="checkbox" name="finish" <%= check %> value="ON" />
			  </td>
                </tr>
<%
    }
%>
                <tr>
                    <td><b><font face="VNI-Times">Teân CV*:</font></b></td>
                    <td>
                    <input type="text" name="name" value="<%= name %>" size="45" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Trong Ñeà AÙn*:</font></b></td>
                    <td>
                        <select name="project">
<%
    String sql = "select mada, tenda from dean";
    ResultSet rs = DBResults.executeQuery(conPool, sql);
    if (rs != null) {
        while (rs.next()) {
            String projectId = rs.getString(1);
            String projectName = rs.getString(2);

            /*- if request from update page and had project
                id and set default value with this value.
             */
            String option = "";
            if (projectId.equals(idOfProject)) {
                option = "selected";
            }
%>
                            <option value="<%= projectId %>" <%= option %>><%= projectName %></option>
<%
        } // end of while
        rs.close();
    } // end of if
%>
                        </select>
                        &nbsp;&nbsp;&nbsp;
                        <a href="../html/addProject.html">
                            <img src="../images/new.gif" border="0" width="16" height="16" />
                        </a>
                    </td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Noäi Dung CV*:</font></b></td>
                    <td><textarea name="content" rows="3" cols="30" ><%= content %></textarea></td>
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
        <%@ include file="../html/footerJob.html" %>
    </p>
    </body>
</html>