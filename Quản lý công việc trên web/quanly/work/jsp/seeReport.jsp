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
        @date       : August 30, 2003
        @description: See Report.
     --%>
    <head>
        <title>See Report</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {

            String sql = "select mabcn, BaoCaoNgay.ngay, ghichu, tiendo, tenfile from BaoCaoNgay, Files, PhanCong, Works "
                + "where PhanCong.macv=Works.macv and Works.macv=BaoCaoNgay.macv and Files.mabc=BaoCaoNgay.mabcn "
                + "and PhanCong.manv='" + user.getStaffId() + "'";

            String xmlDoc = DBResults.transferXML(conPool, sql);
%>
        <form name="frmSeeWork">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Baùo Caùo Cuûa NV Coù UserName&nbsp;<%= user.getUserId() %></font></h3>
<%
            if (xmlDoc == null) {
%>
            <font face="VNI-Times, VNI-Helve" size="+1">Khoâng coù moät baùo caùo naøo.</font>
<%
            }
            else {
%>
            <xslt:apply xsl="/xslt/showReport.xsl">
                <%= xmlDoc %>
            </xslt:apply>
<%
            }
%>
        </form>
<%
        }
    }
%>
    </body>
</html>