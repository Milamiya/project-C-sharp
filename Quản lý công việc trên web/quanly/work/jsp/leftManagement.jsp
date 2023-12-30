<?xml version="1.0" encoding="ISO-8859-1" ?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 21, 2003
        @description: Check all permissions for user is logging in
        the application.
    --%>

    <head>
        <title>The Web Work</title>
        <meta name="author" content="Dinh Le Giang" />
        <meta name="description" content="The Web Work, Job, JSP" />
        <script language="JavaScript">
    <!-- Start hiding from old browsers
        if (document.images) {

	    function tnImgOn(imgName) {
    	        if (document.images) {
	            document[imgName].src = eval(imgName + "_on.src");
	        }
            }

	    function tnImgOff(imgName) {
	        if (document.images) {
	            document[imgName].src = eval(imgName + "_off.src");
	        }
            }

           tn_valueWork_on          = new Image();
           tn_valueWork_on.src      = "../images/valueWorkEn.gif";
           tn_workStatistic_on      = new Image();
           tn_workStatistic_on.src  = "../images/workStatisticEn.gif";
           tn_updateWork_on         = new Image();
           tn_updateWork_on.src     = "../images/updateWorkEn.gif";
           tn_assignWork_on         = new Image();
           tn_assignWork_on.src     = "../images/assignWorkEn.gif";
           tn_testProcess_on        = new Image();
           tn_testProcess_on.src    = "../images/testProcessEn.gif";
           tn_seeStaffInfo_on       = new Image();
           tn_seeStaffInfo_on.src   = "../images/seeStaffInfoEn.gif";
           tn_combineReport_on      = new Image();
           tn_combineReport_on.src  = "../images/combineReportEn.gif";
           tn_seeIdea_on            = new Image();
           tn_seeIdea_on.src        = "../images/seeIdeaEn.gif";
           tn_setupWork_on          = new Image();
           tn_setupWork_on.src      = "../images/setupWorkEn.gif";

           tn_valueWork_off          = new Image();
           tn_valueWork_off.src      = "../images/valueWorkVN.gif";
           tn_workStatistic_off      = new Image();
           tn_workStatistic_off.src  = "../images/workStatisticVN.gif";
           tn_updateWork_off         = new Image();
           tn_updateWork_off.src     = "../images/updateWorkVN.gif";
           tn_assignWork_off         = new Image();
           tn_assignWork_off.src     = "../images/assignWorkVN.gif";
           tn_testProcess_off        = new Image();
           tn_testProcess_off.src    = "../images/testProcessVN.gif";
           tn_seeStaffInfo_off       = new Image();
           tn_seeStaffInfo_off.src   = "../images/seeStaffInfoVN.gif";
           tn_combineReport_off      = new Image();
           tn_combineReport_off.src  = "../images/combineReportVN.gif";
           tn_seeIdea_off            = new Image();
           tn_seeIdea_off.src        = "../images/seeIdeaVN.gif";
           tn_setupWork_off          = new Image();
           tn_setupWork_off.src      = "../images/setupWorkVN.gif";
        }
    // End hiding from old browsers -->
        </script>
    </head>
    <body bgcolor="#FFFFFF" text="#000000">
        <table border="0" align="left">
<%! String privilege; %>
<%
	// Get a current user in the session.
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
    	privilege = user.getGroupId();
    //}
%>
<%
    //else
        if (privilege.equals("2")) { // privilege.equals("Management")
%>
            <caption align="left">
            <font face="VNI-Times" style="font-size: 10pt">Chöùc naêng cuûa <b><i>Quaûn Lyù</i></b></font></caption>
	    <%-- Danh gia cong viec --%>
	    <tr>
	        <td>
		    <a href="valueWork.jsp" target="mainFrame" onmouseover="tnImgOn('tn_valueWork')" onmouseout="tnImgOff('tn_valueWork')">
			<img src="../images/valueWorkVN.gif" alt="Danh Gia CV" border="0" name="tn_valueWork" width="120" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Thong ke cong viec --%>
	    <tr>
		<td>
		    <a href="prepareStatistic.jsp" target="mainFrame" onmouseover="tnImgOn('tn_workStatistic')" onmouseout="tnImgOff('tn_workStatistic')">
			<img src="../images/workStatisticVN.gif" alt="Thong Ke Cong Viec" border="0" name="tn_workStatistic" width="123" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Cap nhat cong viec --%>
     	    <tr>
	        <td>
		    <a href="../html/controlJob.html" target="mainFrame" onmouseover="tnImgOn('tn_updateWork')" onmouseout="tnImgOff('tn_updateWork')">
			<img src="../images/updateWorkVN.gif" alt="CN Cong Viec" border="0" name="tn_updateWork" width="121" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Phan cong cong viec --%>
	    <tr>
		<td>
		    <a href="assignWork.jsp" target="mainFrame" onmouseover="tnImgOn('tn_assignWork')" onmouseout="tnImgOff('tn_assignWork')">
			<img src="../images/assignWorkVN.gif" alt="Phan Cong CV" border="0" name="tn_assignWork" width="130" height="25" />
		    </a>
	        </td>
	    </tr>
	    <%-- Kiem tra tien do thuc hien --%>
	    <tr>
		<td>
		    <a href="showStaffInfo.jsp" target="mainFrame" onmouseover="tnImgOn('tn_testProcess')" onmouseout="tnImgOff('tn_testProcess')">
			<img src="../images/testProcessVN.gif" alt="Kiem Tra Tien Do" border="0" name="tn_testProcess" width="140" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Xem thong tin NV --%>
	    <tr>
		<td>
		    <a href="seeStaffInfo.jsp" target="mainFrame" onmouseover="tnImgOn('tn_seeStaffInfo')" onmouseout="tnImgOff('tn_seeStaffInfo')">
			<img src="../images/seeStaffInfoVN.gif" alt="Xem thong tin nhan vien" border="0" name="tn_seeStaffInfo" width="151" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Tong hop bao cao --%>
	    <tr>
		<td>
		    <a href="prepareReport.jsp" target="mainFrame" onmouseover="tnImgOn('tn_combineReport')" onmouseout="tnImgOff('tn_combineReport')">
			<img src="../images/combineReportVN.gif" alt="Tong Hop Bao Cao" border="0" name="tn_combineReport" width="149" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Xem gop y thac mac --%>
	    <tr>
		<td>
		    <a href="seeIdea.jsp" target="mainFrame" onmouseover="tnImgOn('tn_seeIdea')" onmouseout="tnImgOff('tn_seeIdea')">
			<img src="../images/seeIdeaVN.gif" alt="Xem gop y thac mac" border="0" name="tn_seeIdea" width="190" height="25"/>
		    </a>
		</td>
	    </tr>
	    <%-- Thiet lap che do lam viec --%>
	    <tr>
		<td>
		    <a href="setupWork.jsp" target="mainFrame" onmouseover="tnImgOn('tn_setupWork')" onmouseout="tnImgOff('tn_setupWork')">
			<img src="../images/setupWorkVN.gif" alt="Thiet Lap Che Do Lam Viec" border="0" name="tn_setupWork" width="188" height="25" />
		    </a>
		</td>
	    </tr>
<%
        }
        else {
%>
            <tr>
                <font face="VNI-Times, VNI-Helve" size="+1" color="red">
                    Baïn khoâng coù quyeàn trong chöùc naêng naøy.
                </font>
            </tr>
<%
        }
    }
%>
        </table>
    </body>
</html>