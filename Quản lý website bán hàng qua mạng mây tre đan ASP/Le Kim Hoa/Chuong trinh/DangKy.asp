<%
TrangTiep=Request("TrangTiep")
Ten_KHMoi=Request("Ten_KHMoi")
Password_KHMoi=Request("Password_KHMoi")
%>
<html>

<head>
<title>&#272;&#259;ng k�</title>
</head>

<body>
<font face="Arial"><b>H�y &#273;&#259;ng k� t&#7841;i trang Web n�y b&#7857;ng c�ch l&#7921;a ch&#7885;n T�n truy c&#7853;p v� 
Password : </b>
<form method="post" action="<%=TrangTiep%>">
<input name="KHMoi" type="hidden" value="1">
<b>T�n kh�ch h�ng&nbsp;&nbsp;
</b><input name="Ten_KHMoi" size="20" maxlenggth="20" value="<%=Server.HTMLEncode(Ten_KHMoi)%>">
<p><b>Password
</b><input name="Password_KHMoi" size="15" maxlength="15" value="<%=Server.HTMLEncode(Password_KHMoi)%>"></p>
<p>&nbsp;<input type="submit" value="&#272;&#259;ng k� !"> </p>
</form>
</font>
</body>

</html>