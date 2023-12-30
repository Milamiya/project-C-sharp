<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults,
                     java.sql.ResultSet,
                     java.sql.Connection,
                     java.util.GregorianCalendar"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 30, 2003
        @description: Assign work for employees.
     --%>
    <head>
        <title>Preperation for Assigning Work</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");

        GregorianCalendar calendar = new GregorianCalendar();
        int date = calendar.get(GregorianCalendar.DATE);
        int month = calendar.get(GregorianCalendar.MONTH) + 1;
        int year = calendar.get(GregorianCalendar.YEAR);
        String fullday = "" + year + "/" + month + "/" + date;

        if (conPool != null) {

            String sql = "select macv from phancong"; // where manv='" + user.getUserId() + "'";
            ResultSet rs = DBResults.executeQuery(conPool, sql);
            if (rs.next()) {

                sql = "select distinct works.macv, tencv, noidung, tenda as mada "
                       + "from works, dean "
                       + "where works.mada=dean.mada "
                       + "and daxong=0 and works.macv not in(";
                while(true) {
                    sql = (rs.getRow() == 1) ? (sql + rs.getString(1)) : (sql + ", " + rs.getString(1));
                    if (!rs.next()) {
                        sql = sql + ")";
                        break;
                    }
                }
            }
            else {
                sql = "select works.macv, tencv, noidung, tenda as mada "
                       + "from works, dean "
                       + "where works.mada=dean.mada "
                       + "and daxong=0";
            }

            String xmlDoc = DBResults.transferXML(conPool, sql);
            if (xmlDoc == null) {
%>
                <h3><font face="VNI-Times, VNI-Helve">
                    Danh muïc coâng vieäc roãng <br />
                    hoaëc coâng vieäc ñaõ thöïc hieän xong <br />
			  hoaëc coâng vieäc ñaõ phaân coâng heát.
                </font></h3>
                <hr />
		    <a href="prepareJob.jsp">Taïo coâng vieäc môùi</a>
<%
            }
            else {
%>
        <form name="frmPreperation" action="dbAssignWork.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Phaân Coâng Coâng Vieäc Cho Nhaân Vieân</font></h3>
            <table border="0">
                <tr align="center">
                    <td><b><font face="VNI-Times, VNI-Helve">Teân Nhaân Vieân:</font></b></td>
                    <td>
                        <select name="staff">
<%
                sql = "select manv, tennv from NhanVien";
                rs = DBResults.executeQuery(conPool, sql);
                while(rs.next()) {
                    String staffid = rs.getString(1);
                    String staffName = rs.getString(2);
%>
                            <option value="<%= staffid %>"><%= staffName %></option>
<%
                }
                rs.close();
%>
                        </select>
                    </td>
                </tr>
                <tr align="left">
                    <td><b><font face="VNI-Times, VNI-Helve">Choïn Coâng Vieäc Cho Nhaân Vieân</font></b></td>
                    <xslt:apply xsl="/xslt/deleteJob.xsl">
                        <%= xmlDoc %>
                    </xslt:apply>
                </tr>
            </table>
            <br />
            <b><font face="VNI-Times, VNI-Helve">Ngaøy Baét Ñaàu:</font></b>
            <input type="text" name="startDate" value="<%= fullday %>" size="10" face="VNI-Times" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <b><font face="VNI-Times, VNI-Helve">Ngaøy Keát Thuùc:</font></b>
            <input type="text" name="endDate" value="<%= fullday %>" size="10" face="VNI-Times" />
            <p align="center">
                <input type="submit" name="subOK" value="  OK   " />
            </p>
        </form>
<%
            }
        }
    }
%>
    </body>
</html>