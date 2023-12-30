<?xml version="1.0" encoding="ISO-8859-1" ?>
<!DOCTYPE html
    PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
    "DTD/xhtml1-strict.dtd">
<%-- User not existing --%>
<html>
    <head>
        <%@ page isErrorPage="true"%>
	  <%--
            @author     : Dinh Le Giang
            @date       : August 15, 2003
            @description: showing a exception when user is not existing.
        --%>
        <title>User not existing</title>
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
        <h3> The user is not existing.</h3>
	  <h5><font face="VNI-Times">Ngöôøi duøng naøy khoâng toàn taïi.</font></h5>
        <%= "Exception " + exception %>

        <br/><br/>

        <%= "Message " + exception.getMessage() %>
        <% exception.printStackTrace(); %>
    </body>
</html>
