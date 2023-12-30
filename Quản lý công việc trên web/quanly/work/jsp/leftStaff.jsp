<?xml version="1.0" encoding="ISO-8859-1" ?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.beans.UserBean"
             errorPage="error.jsp" %>
    <%--
        
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

           tn_seeReport_on          = new Image();
           tn_seeReport_on.src      = "../images/seeReportEn.gif";
           tn_promoteIdea_on         = new Image();
           tn_promoteIdea_on.src     = "../images/promoteIdeaEn.gif";
           tn_reportProcess_on       = new Image();
           tn_reportProcess_on.src   = "../images/reportProcessEn.gif";
           tn_seeValueWork_on        = new Image();
           tn_seeValueWork_on.src    = "../images/seeValueWorkEn.gif";
           tn_seeAssignedWork_on     = new Image();
           tn_seeAssignedWork_on.src = "../images/seeAssignedWorkEn.gif";
           /*tn_passWork_on     = new Image();
           tn_passWork_on.src = "../images/passWorkEn.gif";*/

           tn_seeReport_off          = new Image();
           tn_seeReport_off.src      = "../images/seeReportVN.gif";
           tn_promoteIdea_off         = new Image();
           tn_promoteIdea_off.src     = "../images/promoteIdeaVN.gif";
           tn_reportProcess_off       = new Image();
           tn_reportProcess_off.src   = "../images/reportProcessVN.gif";
           tn_seeValueWork_off        = new Image();
           tn_seeValueWork_off.src    = "../images/seeValueWorkVN.gif";
           tn_seeAssignedWork_off     = new Image();
           tn_seeAssignedWork_off.src = "../images/seeAssignedWorkVN.gif";
           /*tn_passWork_off     = new Image();
           tn_passWork_off.src = "../images/passWorkVN.gif";*/

        }
    // End hiding from old browsers -->
        </script>
    </head>
    <body bgcolor="#FFFFFF" text="#000000">
        <table border="0" align="left">
            <caption align="left">
            <font face="VNI-Times" style="font-size: 10pt">Chöùc naêng cuûa <b><i>Nhaân Vieân</i></b></font></caption>
<%! String privilege; %>
<%
	// Get a current user in the session.
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
    	privilege = user.getGroupId();
    //}
%>
<%--
    else if (privilege.equals("3")) { // privilege.equals("Staff")
--%>
	    <%-- Xem bao cao;tnCopyOn('tn_doc');tnCopyOff('tn_doc') --%>
	    <tr>
		<td>
		    <a href="seeReport.jsp" target="mainFrame" onmouseover="tnImgOn('tn_seeReport')" onmouseout="tnImgOff('tn_seeReport')">
			<img src="../images/seeReportVN.gif" alt="Xem Bao Cao" border="0" name="tn_seeReport" width="114" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- De xuat y kien --%>
	    <tr>
		<td>
		    <a href="giveIdea.jsp" target="mainFrame" onmouseover="tnImgOn('tn_promoteIdea')" onmouseout="tnImgOff('tn_promoteIdea')">
			<img src="../images/promoteIdeaVN.gif" alt="De Xuat Y Kien" border="0" name="tn_promoteIdea" width="130" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Bao cao tien do --%>
	    <tr>
		<td>
		    <a href="reportProgress.jsp" target="mainFrame" onmouseover="tnImgOn('tn_reportProcess')" onmouseout="tnImgOff('tn_reportProcess')">
		        <img src="../images/reportProcessVN.gif" alt="Bao Cao Tien Do" border="0" name="tn_reportProcess" width="137" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Xem danh gia cong viec --%>
	    <tr>
		<td>
		    <a href="seeValueWork.jsp" target="mainFrame" onmouseover="tnImgOn('tn_seeValueWork')" onmouseout="tnImgOff('tn_seeValueWork')">
			<img src="../images/seeValueWorkVN.gif" alt="Xem Danh Gia Cong Viec" border="0" name="tn_seeValueWork" width="148" height="25" />
		    </a>
	        </td>
	    </tr>
	    <%-- Xem cong viec duoc giao --%>
	    <tr>
		<td>
		    <a href="seeWork.jsp" target="mainFrame" onmouseover="tnImgOn('tn_seeAssignedWork')" onmouseout="tnImgOff('tn_seeAssignedWork')">
			<img src="../images/seeAssignedWorkVN.gif" alt="Xem Cong Viec Duoc Giao" border="0" name="tn_seeAssignedWork" width="156" height="25" />
		    </a>
	        </td>
	    </tr>
	    <%-- Xem cong viec chuyen giao --%>
	    <!--tr>
		<td>
		    <a href="passWork.jsp" target="mainFrame" onmouseover="tnImgOn('tn_passWork')" onmouseout="tnImgOff('tn_passWork')">
			<img src="../images/passWorkVN.gif" alt="Xem Cong Viec Chuyen Giao Truc Tiep Cho Ban" border="0" name="tn_passWork" />
		    </a>
	        </td>
	    </tr-->
<%
        }
%>
        </table>
    </body>
</html>