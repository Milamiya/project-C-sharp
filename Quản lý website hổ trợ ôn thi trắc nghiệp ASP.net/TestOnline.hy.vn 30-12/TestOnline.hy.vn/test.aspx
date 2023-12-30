<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="TestOnline.hy.vn._Default" %>

<%@ Register src="Control/menuleft/ucMenuLeft1.ascx" tagname="ucMenuLeft1" tagprefix="uc1" %>

<%@ Register src="Control/menuleft/ucMenuSubject.ascx" tagname="ucMenuSubject" tagprefix="uc2" %>

<%@ Register src="Control/ucListThread.ascx" tagname="ucListThread" tagprefix="uc3" %>
<%@ Register src="Control/ucRegistry.ascx" tagname="ucRegistry" tagprefix="uc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <uc4:ucRegistry ID="ucRegistry1" runat="server" />
    </form>
</body>
</html>
