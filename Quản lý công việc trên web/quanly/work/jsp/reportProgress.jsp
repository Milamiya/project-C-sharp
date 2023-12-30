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
        @description: Give Idea for your company.
     --%>
    <head>
        <title>Report Progress</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
        <script language="javascript" src="../xslt/jobScript.js"></script>
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

    	Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {

            GregorianCalendar calendar = new GregorianCalendar();
            int date = calendar.get(GregorianCalendar.DATE);
            int month = calendar.get(GregorianCalendar.MONTH) + 1;
            int year = calendar.get(GregorianCalendar.YEAR);
            String fullday = "" + year + "/" + month + "/" + date;
%>
    <!--../servlet/com.dinhgiang.servlets.ReportProgressServlet-->
        <form action="../servlet/ReportProgress" enctype="multipart/form-data" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Baùo Caùo Tieán Ñoä Coâng Vieäc</font></h3>
            <table border="0" align="center">
                <tr>
                    <td><b><font face="VNI-Times">Maõ Baùo Caùo:</font></b></td>
		    <td>
                        <input type="text" name="mabcn" size="5" value="00000" />
                        <b><font face="VNI-Times">&nbsp;&nbsp;&nbsp;Ngaøy*:</font></b>&nbsp;&nbsp;&nbsp;<input type="text" name="ngay" size="10" value="<%= fullday %>" />
                    </td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Teân Coâng Vieäc*:</font></b></td>
                    <td>
                        <select name="macv">
<%
            /*- Only display the works of employee with
                username when logging on
             */
            String sql = "select works.macv, tencv from works, phancong "
                       + "where works.macv=phancong.macv and phancong.manv='"
                       + user.getStaffId() + "'";
	    ResultSet rs = DBResults.executeQuery(conPool, sql);
            while (rs.next()) {
                String jobId = rs.getString(1);
            	String jobName = rs.getString(2);
%>
                            <option value="<%= jobId %>"><%= jobName %></option>
<%
            }
	    rs.close();
%>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Coâng vieäc thöïc </font></b></td>
                    <td><font face="VNI-Times"><b>hieän ñöôïc* </b><input type="text" name="tiendo" size="3" /><b>&nbsp;&nbsp;phaàn traêm</b></font></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Ghi Chuù:</font></b></td>
		    <td><textarea name="ghichu" rows="3" cols="30"></textarea></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times">Keøm Taäp Tin:</font></b></td>
                    <td>
                        <input type="file" name="filename" size="32" />
                    </td> <!-- name="subOK" disabled onchange="testUploadFile(filename, subOK)" -->
                </tr>
            </table>
            <p align="center">
	        <input type="submit" value="  OK   " />
	    </p>
        </form>
<%
        }
    }
%>
    </body>
</html>