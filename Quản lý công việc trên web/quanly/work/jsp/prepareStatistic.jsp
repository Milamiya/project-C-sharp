<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults,
                     java.util.GregorianCalendar,
                     java.sql.ResultSet,
                     java.sql.Connection"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 30, 2003
        @description: Preperation for Work Statistic.
     --%>
    <head>
        <title>Preperation for Work Statistic</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
        <script language="JavaScript">
    <!--
	function testCheck(form, index) {
            if (form.PrepareStatistic.disabled == true) {
                form.PrepareStatistic.disabled = false;
            }
	    if (index == 0) { //time
                //Hide work value
		form.grade.disabled = true;
                //Hide project
                form.project.disabled = true;
		//Show time
		form.start.disabled = false;
		form.end.disabled = false;
                //Set value for radio button
                form.statistic[1].value = "off";
                form.statistic[2].value = "off";
                form.statistic[index].value = "on0";
	    }
	    if (index == 1) { //grade
                //Hide time
		form.start.disabled = true;
		form.end.disabled = true;
                //Hide project
                form.project.disabled = true;

                //Show work value
		form.grade.disabled = false;

                //Set value for radio button
                form.statistic[0].value = "off";
                form.statistic[2].value = "off";
                form.statistic[index].value = "on1";
	    }
	    if (index == 2) { // project
                //Hide time
		form.start.disabled = true;
		form.end.disabled = true;
                //Hide work value
		form.grade.disabled = true;
                //Show project
                form.project.disabled = false;
                //Set value for radio button
                form.statistic[0].value = "off";
                form.statistic[1].value = "off";
                form.statistic[index].value = "on2";
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

            GregorianCalendar calendar = new GregorianCalendar();
            int date = calendar.get(GregorianCalendar.DATE);
            int month = calendar.get(GregorianCalendar.MONTH) + 1;
            int year = calendar.get(GregorianCalendar.YEAR);
            String fullday = "" + year + "/" + month + "/" + date;
%>
        <form name="frmPrepareStatistic" action="workStatistic.jsp" method="POST">
            <h3 align="center"><font face="VNI-Times, VNI-Helve" color="#AA0000">Thoáng Keâ Coâng Vieäc</font></h3>
            <dl>
                <dt>
                    <input type="radio" name="statistic" value="off" onclick="testCheck(this.form, 0)" />
                    <b><font face="VNI-Times, VNI-Helve">Thôøi Gian</font></b>
                </dt>
                <dd>
                    <b><font face="VNI-Times, VNI-Helve" size="-1">Baét Ñaàu:&nbsp;&nbsp;</b><input type="text" name="start" value="<%= fullday %>" size="8" disabled /></font>
                    <b><font face="VNI-Times, VNI-Helve" size="-1">&nbsp;&nbsp;&nbsp;&nbsp;Keát Thuùc:&nbsp;&nbsp;</b><input type="text" name="end" value="<%= fullday %>" size="8" disabled /></font>
                </dd>
                <br />
                <dt>
                    <input type="radio" name="statistic" value="off" onclick="testCheck(this.form, 1)" />
                    <b><font face="VNI-Times, VNI-Helve">Chaát Löôïng</font></b>
                </dt>
                <dd>
                    <b><font face="VNI-Times, VNI-Helve" size="-1">Loaïi:&nbsp;&nbsp;</font></b>
                    <select name="grade" disabled>
<%
            String sql = "select xeploai from xeploai";
            ResultSet rs = DBResults.executeQuery(conPool, sql);
            while(rs.next()) {
                String gradeName = rs.getString(1);
%>
                        <option value="<%= gradeName %>"><%= gradeName %></option>
<%
            }
%>
                    </select>
                </dd>
                <br />
                <dt>
                    <input type="radio" name="statistic" value="off" onclick="testCheck(this.form, 2)" />
                    <b><font face="VNI-Times, VNI-Helve">Ñeà AÙn</font></b>
                </dt>
                <dd>
                    <b><font face="VNI-Times, VNI-Helve" size="-1">Teân Ñeà AÙn:&nbsp;&nbsp;</font></b>
                    <select name="project" disabled>
<%
            sql = "select tenda from dean";
            rs = DBResults.executeQuery(conPool, sql);
            while(rs.next()) {
                String projectName = rs.getString(1);
%>
                        <option value="<%= projectName %>"><%= projectName %></option>
<%
            }
            rs.close();
%>
                    </select>
                </dd>
            </dl>
            <p align="center">
                <input type="submit" name="PrepareStatistic" value="  OK   " disabled />
            </p>
        </form>
<%
        }
    }
%>
    </body>
</html>