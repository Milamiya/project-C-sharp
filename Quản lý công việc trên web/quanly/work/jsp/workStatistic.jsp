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
        <title>Work Statistic Table</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%
    Connection conPool = (Connection) session.getAttribute("conJobPool");

    if (conPool != null) {
        String[] statistics = request.getParameterValues("statistic");
        String sql = null;
        String xslFile = null;
        String header = null;
        for (int i = 0; i < statistics.length; i++) {
            if (statistics[i].equals("on0")) { // thoi gian, may be not finished
                String start = request.getParameter("start");
                String end = request.getParameter("end");
                header = "Theo Thôøi Gian <br />Töø " + start + " Ñeán " + end;
                xslFile = "/xslt/timeStatistic.xsl";
                sql = "select tencv, daxong, tennv, tenda "
                    + "from works, nhanvien, dean, phancong "
                    + "where nhanvien.manv=phancong.manv and phancong.macv=works.macv "
                    + "and works.mada=dean.mada and phancong.ngaykt>='"
                    + start.trim() + "' and phancong.ngaykt<='" + end.trim() + "'";
            }
            else if (statistics[i].equals("on1")) { // quanlity, finished
                String grade = request.getParameter("grade");
                header = "Theo Chaát Löôïng <br />Vôùi Loaïi " + grade;
                xslFile = "/xslt/valueStatistic.xsl";
                sql = "select tencv, daxong, tennv, tenda "
                    + "from works, nhanvien, dean, phancong, danhgia, xeploai "
                    + "where nhanvien.manv=phancong.manv and phancong.macv=works.macv "
                    + "and works.mada=dean.mada and works.madg=danhgia.madg "
                    + "and danhgia.maxl=xeploai.maxl and xeploai.xeploai='" + grade.trim() + "'";
            }
            else if (statistics[i].equals("on2")) { // project, may be not finished
                String project = request.getParameter("project");
                header = "Thuoäc Ñeà AÙn <br />" + project;
                xslFile = "/xslt/projectStatistic.xsl";
                sql = "select tencv, daxong, tennv, ngaybd, ngaykt "
                    + "from works, nhanvien, dean, phancong "
                    + "where nhanvien.manv=phancong.manv and phancong.macv=works.macv "
                    + "and works.mada=dean.mada and dean.tenda='" + project.trim() + "'";
            }
        }
        if (sql != null) {
            String xmlDoc = DBResults.transferXML(conPool, sql);
            if (xmlDoc == null) {
%>
        <h3 align="center">
            <font face="VNI-Times, VNI-Helve">Tieâu chuaån caàn thoáng keâ khoâng hôïp lyù.</font><br />
            <a href="prepareStatistic.jsp">Haõy choïn laïi</a>
        </h3>
<%
            }
            else {
%>
        <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Baûng Thoáng Keâ Coâng Vieäc <%= header %></font></h3>
        <xslt:apply xsl="<%= xslFile %>">
            <%= xmlDoc %>
        </xslt:apply>
        <p>
            <a href="prepareStatistic.jsp">Trôû laïi trang tröôùc</a>
        </p>
<%
            }
        }
    }
%>
    </body>
</html>