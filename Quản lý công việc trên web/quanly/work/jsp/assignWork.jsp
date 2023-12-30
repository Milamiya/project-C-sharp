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
                    Danh mu�c co�ng vie�c ro�ng <br />
                    hoa�c co�ng vie�c �a� th��c hie�n xong <br />
			  hoa�c co�ng vie�c �a� pha�n co�ng he�t.
                </font></h3>
                <hr />
		    <a href="prepareJob.jsp">Ta�o co�ng vie�c m��i</a>
<%
            }
            else {
%>
        <form name="frmPreperation" action="dbAssignWork.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Pha�n Co�ng Co�ng Vie�c Cho Nha�n Vie�n</font></h3>
            <table border="0">
                <tr align="center">
                    <td><b><font face="VNI-Times, VNI-Helve">Te�n Nha�n Vie�n:</font></b></td>
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
                    <td><b><font face="VNI-Times, VNI-Helve">Cho�n Co�ng Vie�c Cho Nha�n Vie�n</font></b></td>
                    <xslt:apply xsl="/xslt/deleteJob.xsl">
                        <%= xmlDoc %>
                    </xslt:apply>
                </tr>
            </table>
            <br />
            <b><font face="VNI-Times, VNI-Helve">Nga�y Ba�t �a�u:</font></b>
            <input type="text" name="startDate" value="<%= fullday %>" size="10" face="VNI-Times" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <b><font face="VNI-Times, VNI-Helve">Nga�y Ke�t Thu�c:</font></b>
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