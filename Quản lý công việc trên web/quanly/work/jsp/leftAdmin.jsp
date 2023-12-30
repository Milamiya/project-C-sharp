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

           tn_updateGroup_on     = new Image();
           tn_updateGroup_on.src = "../images/updateGroupEn.gif";
           tn_updatePer_on       = new Image();
           tn_updatePer_on.src   = "../images/updatePerEn.gif";
           tn_setPer_on          = new Image();
           tn_setPer_on.src      = "../images/setPerEn.gif";
           tn_updateStaff_on     = new Image();
           tn_updateStaff_on.src = "../images/updateStaffEn.gif";
           tn_refresh_on         = new Image();
           tn_refresh_on.src     = "../images/refreshEn.gif";
           tn_restore_on         = new Image();
           tn_restore_on.src     = "../images/restoreEn.gif";
           tn_changePwd_on       = new Image();
           tn_changePwd_on.src   = "../images/changePwdEn.gif";

           tn_updateGroup_off    = new Image();
           tn_updateGroup_off.src = "../images/updateGroupVN.gif";
           tn_updatePer_off       = new Image();
           tn_updatePer_off.src   = "../images/updatePerVN.gif";
           tn_setPer_off          = new Image();
           tn_setPer_off.src      = "../images/setPerVN.gif";
           tn_updateStaff_off     = new Image();
           tn_updateStaff_off.src = "../images/updateStaffVN.gif";
           tn_refresh_off         = new Image();
           tn_refresh_off.src     = "../images/refreshVN.gif";
           tn_restore_off         = new Image();
           tn_restore_off.src     = "../images/restoreVN.gif";
           tn_changePwd_off       = new Image();
           tn_changePwd_off.src   = "../images/changePwdVN.gif";
        }
    // End hiding from old browsers -->
        </script>
    </head>
    <body bgcolor="#FFFFFF" text="#000000">
        <table border="0" align="left">
            <caption align="left">
            <font face="VNI-Times" style="font-size: 10pt">Chöùc naêng cuûa <b><i>
            Heä&nbsp; Thoáng</i></b></font></caption>
<%! String privilege; %>
<%
	// Get a current user in the session.
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {
    	privilege = user.getGroupId();
    //}
%>
<%
        if (privilege.equals("1")) { // privilege.equals("Admin")
%>
	    <%-- Cap nhat nhom --%>
	    <tr>
		<td width="200">
		    <a href="../html/controlGroup.html" target="mainFrame" onmouseover="tnImgOn('tn_updateGroup')" onmouseout="tnImgOff('tn_updateGroup')">
			<img src="../images/updateGroupVN.gif" alt="Cap Nhat Nhom" border="0" name="tn_updateGroup" width="132" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Cap nhat quyen --%>
	    <tr>
		<td width="200">
		    <a href="../html/controlPermission.html" target="mainFrame" onmouseover="tnImgOn('tn_updatePer')" onmouseout="tnImgOff('tn_updatePer')">
			<img src="../images/updatePerVN.gif" alt="Cap Nhat Quyen" border="0" name="tn_updatePer" width="141" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Gan quyen --%>
	    <tr>
		<td width="200">
		    <a href="../jsp/setPermission.jsp" target="mainFrame" onmouseover="tnImgOn('tn_setPer')" onmouseout="tnImgOff('tn_setPer')">
			<img src="../images/setPerVN.gif" alt="Gan Quyen" border="0" name="tn_setPer" width="101" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Cap nhat nhan vien --%>
	    <tr>
		<td width="200">
		    <a href="../html/controlStaff.html" target="mainFrame" onmouseover="tnImgOn('tn_updateStaff')" onmouseout="tnImgOff('tn_updateStaff')">
			<img src="../images/updateStaffVN.gif" alt="Cap Nhat Nhan Vien" border="0" name="tn_updateStaff" width="123" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Refresh database --%>
	    <tr>
		<td width="200">
		    <a href="../html/refreshing.html" target="mainFrame" onmouseover="tnImgOn('tn_refresh')" onmouseout="tnImgOff('tn_refresh')">
			<img src="../images/refreshVN.gif" alt="Lam Tuoi Co So Du Lieu" border="0" name="tn_refresh" width="139" height="25" />
		    </a>
		</td>
	    </tr>
	    <%-- Restore database --%>
	    <tr>
		<td width="200">
		    <a href="../html/restoring.html" target="mainFrame" onmouseover="tnImgOn('tn_restore')" onmouseout="tnImgOff('tn_restore')">
			<img src="../images/restoreVN.gif" alt="Phuc Hoi Co So Du Lieu" border="0" name="tn_restore" width="130" height="25" />
		    </a>
		</td>
	    </tr>
<%
        }
    }
%>
	    <%-- Change password for all groups --%>
	    <tr>
		<td width="200">
		    <a href="../jsp/changePassword.jsp" target="mainFrame" onmouseover="tnImgOn('tn_changePwd')" onmouseout="tnImgOff('tn_changePwd')">
			<img src="../images/changePwdVN.gif" alt="Doi Mat Khau" border="0" name="tn_changePwd" width="109" height="26" />
		    </a>
		</td>
	    </tr>
        </table>
    </body>
</html>