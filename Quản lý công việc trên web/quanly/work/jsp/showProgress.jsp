<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ taglib uri="http://www.dinhgiang.com/" prefix="xslt" %>
    <%@ page language="java"
             import="com.dinhgiang.utils.JobPool,
                     java.sql.Connection,
                     com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 28, 2003
        @description:
     --%>
    <head>
        <title>Show the Job Detail</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%! String xmlDoc = null; %>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
            String staffId = request.getParameter("staffInfoId");

            String sql = "select tencv, baocaongay.ngay, tiendo, ghichu "
                       + "from works, baocaongay, phancong "
                       + "where works.macv=baocaongay.macv "
                       + "and phancong.macv=works.macv "
                       + "and phancong.manv='" + staffId + "'";

            xmlDoc = DBResults.transferSpecialXML(conPool, sql);
        }
    }
%>
        <h3 align="center"><font face="VNI-Times" color="#AA0000">Xem Tie�n �o� Co�ng Vie�c</font></h3>
<%
    if (xmlDoc == null) {

%>
        <font face="VNI-Times" size="+1">Nha�n vie�n na�y ch�a co� co�ng vie�c na�o.</font>
<%
    }
    else {

%>
        <xslt:apply xsl="/xslt/showProgress.xsl">
            <%= xmlDoc %>
        </xslt:apply>
<%
    }
%>
        <p>
            <a href="showStaffInfo.jsp">Tr�� ve� trang tho�ng tin nha�n vie�n</a>
        </p>
    </body>
</html>