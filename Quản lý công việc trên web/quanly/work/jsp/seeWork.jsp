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
        @description: See Assigned Work.
     --%>
    <head>
        <title>See Assigned Work</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
                /*- Xem cong veic duoc giao
                    cong viec da hoan thanh - and works.daxong = 1
                    hay chua hoan thanh - and works.daxong = 0
                    hay caû hai ? - khong co dieu kien
                */
                String sql = "select works.macv, tencv, noidung, tenda, ngaybd, ngaykt from works, phancong, dean "
                    + "where works.macv=phancong.macv and dean.mada = works.mada "
                    + "and manv='" + user.getStaffId() + "'";

                String xmlDoc = DBResults.transferXML(conPool, sql);
%>
        <form name="frmSeeWork">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Coâng Vieäc Cuûa NV Coù UserName&nbsp;<%= user.getUserId() %></font></h3>
<%
            if (xmlDoc == null) {
%>
            <font face="VNI-Times, VNI-Helve" size="+1">Baïn chöa ñöôïc giao coâng vieäc naøo..</font>
<%
            }
            else {
%>
            <xslt:apply xsl="/xslt/showAssignedJob.xsl">
                <%= xmlDoc %>
            </xslt:apply>
<%
            }
%>
        </form>
<%--
            } else {
%>
        <h3 align="center"><font face="VNI-Times, color="#AA0000">Loãi Khi thuïc hieän</font></h3>
        <font face="VNI-Times, VNI-Helve" size="-1">Baïn vaãn chöa ñöôïc phaân coâng coâng vieäc naøo.</font>
--%>
<%
        }
    }
%>
    </body>
</html>