<%
TrangTiep=Request("TrangTiep")
Ten_KHMoi=Request("Ten_KHMoi")
Password_KHMoi=Request("Password_KHMoi")
%>
<html>

<head>
<title>&#272;&#259;ng ký</title>
</head>

<body>
<font face="Arial"><b>Hãy &#273;&#259;ng ký t&#7841;i trang Web này b&#7857;ng cách l&#7921;a ch&#7885;n Tên truy c&#7853;p và 
Password : </b>
<form method="post" action="<%=TrangTiep%>">
<input name="KHMoi" type="hidden" value="1">
<b>Tên khách hàng&nbsp;&nbsp;
</b><input name="Ten_KHMoi" size="20" maxlenggth="20" value="<%=Server.HTMLEncode(Ten_KHMoi)%>">
<p><b>Password
</b><input name="Password_KHMoi" size="15" maxlength="15" value="<%=Server.HTMLEncode(Password_KHMoi)%>"></p>
<p>&nbsp;<input type="submit" value="&#272;&#259;ng ký !"> </p>
</form>
</font>
</body>

</html>