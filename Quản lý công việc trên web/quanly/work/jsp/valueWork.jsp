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

        if (conPool != null) {
            // The only finished, assigned and not valued works then they displayed
            String sql = "select works.macv, tencv from works, phancong "
                       + "where daxong=1 and works.macv=phancong.macv and isnull(madg)";
            ResultSet rs = DBResults.executeQuery(conPool, sql);
            if (rs.next()) {
%>
        <form name="frmValueWork" action="dbValueWork.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">�a�nh Gia� Co�ng Vie�c</font></h3>
            <table border="0" align="center">
                <tr>
                    <td><b><font face="VNI-Times, VNI-Helve">Ma� �a�nh Gia�:</font></b></td>
                    <td><input type="text" name="id" value="1" size="8" /></td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times, VNI-Helve">Co�ng Vie�c:</font></b></td>
                    <td>
                        <select name="work">
<%
            while(true) {
                String workid = rs.getString(1);
                String workName = rs.getString(2);
%>
                            <option value="<%= workid %>"><%= workName %></option>
<%
                if (rs.next() == false)
                    break;
            }
%>
                        </select>
                    </td>
                </tr>
                <!-- Grade List -->
                <tr>
                    <td><b><font face="VNI-Times, VNI-Helve">Xe�p Loa�i:</font></b></td>
                    <td>
                        <select name="grade">
<%
            sql = "select maxl, xeploai from xeploai";
            rs = DBResults.executeQuery(conPool, sql);
            while (rs.next()) {
                String gradeid = rs.getString(1);
                String gradeName = rs.getString(2);
%>
                            <option value="<%= gradeid %>"><%= gradeName %></option>
<%
            }
            rs.close();
%>
                        </select>
                        &nbsp;&nbsp;&nbsp;
                        <a href="../html/addGrade.html">
                            <img src="../images/new.gif" border="0" />
                        </a>
                    </td>
                </tr>
                <tr>
                    <td><b><font face="VNI-Times, VNI-Helve">Chu� Th�ch:</font></b></td>
                    <td><textarea name="comment" cols="30" rows="3">&nbsp;</textarea></td>
                </tr>
            </table>
            <p align="center">
                <input type="submit" name="dbValueWork" value="  OK   " />
            </p>
        </form>
<%
            }
            else {
%>
            <h3 align="left">
                <font face="VNI-Times, VNI-Helve">
                Co�ng vie�c hoa�c ch�a ����c pha�n co�ng <br />
                hoa�c ch�a ����c hoa�n tha�nh <br />
                hoa�c �a� ����c �a�nh gia�
                </font>
            </h3>
		<hr/ >
		<a href="assignWork.jsp">Pha�n co�ng</a><br />
		<a href="modifyJob.jsp">Hoa�n tha�nh co�ng vie�c</a>
<%
            }
        }
    }
%>
    </body>
</html>