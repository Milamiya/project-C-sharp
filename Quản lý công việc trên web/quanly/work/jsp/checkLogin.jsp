<%@ page language="java"
         import="com.dinhgiang.beans.UserBean,
                 com.dinhgiang.utils.JobPool,
                 java.util.HashMap,
                 java.sql.Connection"
         errorPage="error.jsp" %>

<jsp:useBean id="loginBean" scope="page" class="com.dinhgiang.beans.LoginBean">
    <%-- jsp:setProperty name="loginBean" property="*"/ --%>
    <jsp:setProperty name="loginBean" property="username" value="<%= request.getParameter(\"username\") %>" />
    <jsp:setProperty name="loginBean" property="password" value="<%= request.getParameter(\"password\") %>" />
</jsp:useBean>

<jsp:useBean id="monitor" scope="application" class="java.util.HashMap"/>
<%! String display = "."; %>
<%
    // boolean recoverOrder = false;
    // Check  existing connection.
    Connection conJobPool = (Connection) session.getAttribute("conJobPool");
    if (conJobPool == null) {
        /* Creating a connection to use in session */
        conJobPool = JobPool.getInstance().getConnection();
        session.setAttribute("conJobPool", conJobPool);
        display = "errorpage.jsp";
    }

    UserBean user = loginBean.authenticate(conJobPool);
    if (user != null) {
        user.setIpAddr(request.getRemoteHost());

        // Got user. Now do they already have a session?
        if (monitor.containsKey(user)) {
            HttpSession oldSession = (HttpSession)monitor.get(user);
            /*- If we want to complete an old order, uncomment these lines, recoverOrder
                and push the page to processOrder.jsp?action=1
                Order oldOrder = (Order)oldSession.getAttribute("anOrder");
                if (oldOrder != null && oldOrder.isProcessed() == false) {
                    session.setAttribute("anOrder", oldOrder);
                    recoverOrder = true;
                }
                oldSession.invalidate();
             */
        }
        session.setAttribute("user", user);
        monitor.put(user, session);
        System.out.println("Assigned new session for: " + user);

        session.setMaxInactiveInterval(900);
        // display = recoverOrder ? "processOrder.jsp?action=1" : "browse.jsp";
        display = "/html/index.html";
    }
    else {
        display = "/html/failLogin.html";
    }
%>
<jsp:forward page="<%= display %>" />