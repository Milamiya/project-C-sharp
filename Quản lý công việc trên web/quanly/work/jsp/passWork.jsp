<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>

    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults,
                     java.sql.Connection,
                     java.sql.ResultSet"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 01, 2003
        @description: See Assigned Work.
     --%>
    <head>
        <title>See Setup Works</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {

            String staffId = request.getParameter("staffId");
            String staff = "";
            String button = "";
            if (staffId == null) {
                staffId = user.getStaffId();
                staff =  "Coù<br />UserName " + user.getUserId();
            }
            else {
                staff = "<br />" + request.getParameter("staffName");
                button = "<input type=\"button\" name=\"btnBack\" value=\"Back\" onclick=\"history.back()\" />";
            }
            String sql = "select thietlap.ngay, works.tencv from thietlap, works "
                       + "where works.macv = thietlap.macv "
                       + "and thietlap.manv='" + staffId + "'";

            String xmlDoc = DBResults.transferXML(conPool, sql);
%>
        <form name="frmPassWork">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Coâng Vieäc Ñaõ Chuyeån Giao Cho NV&nbsp;<%= staff %></font></h3>
<%
            if (xmlDoc == null) {
%>
            <font face="VNI-Times, VNI-Helve" size="+1">Khoâng coù söï chuyeån giao coâng vieäc giöõa baïn vaø caùc nhaân vieân khaùc naøo..</font>
<%
            }
            else {
%>
            <xslt:apply xsl="/xslt/passWork.xsl">
                <%= xmlDoc %>
            </xslt:apply>
<%
            }
%>
            <p align="center">
                <%= button %>
            </p>
        </form>
<%
        }
    }
%>
    </body>
</html>