<%@ page import="com.dinhgiang.beans.UserBean, java.util.HashMap" errorPage="error.jsp" %>

<%
    if (session != null) {
    UserBean user = (UserBean)session.getValue("user");
        if (user != null) {
            HashMap hash =(HashMap)application.getAttribute("monitor");
            hash.remove(user);
            session.invalidate();
        }
    }

    //response.sendRedirect("../");
%>
<jsp:forward page="/html/showLogin.html" />
