<?xml version="1.0" encoding="ISO-8859-1" ?>
<!DOCTYPE html
    PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
    "DTD/xhtml1-strict.dtd">
<%-- report error --%>
<html>
    <head>
        <%@ page isErrorPage="true"%>
        <title>Report Error</title>
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
        <h3>Something bad has happened. And it looks like:</h3>
        <h5><font face="VNI-Times">Coù loãi xuaát hieän, ñöôïc moâ taû nhö sau:</font></h5>

        <%= "Exception " + exception %>

        <br/><br/>

        <%= "Message " + exception.getMessage() %>
        <% exception.printStackTrace(); %>
        <br/>
    </body>
</html>

