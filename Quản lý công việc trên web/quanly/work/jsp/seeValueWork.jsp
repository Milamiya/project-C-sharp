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
        @description: See Work Value.
     --%>
    <head>
        <title>See Work Value</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
        <script language="javascript">
    <!--
        function testSubmit(form) {
            if (form.dbSeeValueWork.disabled) { // == true
                form.dbSeeValueWork.disabled = false;
            }
        }
    //-->
        </script>
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {

            String sql = "select tencv, xeploai, chuthich, phanhoi, danhgia.madg "
                       + "from works, danhgia, phancong, xeploai "
                       + "where xeploai.maxl = danhgia.maxl and danhgia.madg=works.madg "
                       + "and works.macv=phancong.macv and phancong.manv ='" + user.getStaffId() + "'";

            String xmlDoc = DBResults.transferXML(conPool, sql);
            if (xmlDoc == null) {
%>
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Baûng Ñaùnh Giaù Cuûa NV Coù UserName&nbsp;<%= user.getUserId() %></font></h3>
            <font face="VNI-Times, VNI-Helve" size="+1">Caùc coâng vieäc cuûa baïn chöa ñöôïc ñaùnh giaù.</font>
<%
            }
            else {
%>
        <form name="frmSeeWork" action="dbSeeValueWork.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Baûng Ñaùnh Giaù Cuûa NV Coù UserName&nbsp;<%= user.getUserId() %></font></h3>
            <xslt:apply xsl="/xslt/seeValueWork.xsl">
                <%= xmlDoc %>
            </xslt:apply>
            <p align="center">
                <input type="submit" name="dbSeeValueWork" value="  OK   " disabled />
            </p>
        </form>
<%
            }
        }
    }
%>
    </body>
</html>