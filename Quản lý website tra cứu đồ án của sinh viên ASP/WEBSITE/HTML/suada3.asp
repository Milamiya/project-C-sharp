<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>SỬA THÔNG TIN ĐỒ ÁN</title>
</head>
<body background="HINH%20ANH/nen1.jpg">
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>
			<!--#include file="ketnoi.inc"-->
<%
 nd=session("nd")
 mk=session("mk")
 sql="select * from tbldangnhap"
 sql=sql & " where nguoidung= '"& nd &"' and  matkhau='"& mk &"'"
 set rs = cn.execute(sql)
 if   rs.eof then
    response.redirect("login.htm")
    else
         if trim(rs("nguoidung"))="admin" then%>
<center>
<form method=post action=suada1.asp>
<p align="center"><b><font size="4">SỬA ĐỒ ÁN THEO MÃ</font></b></p>
 <table border="0" width="50%">
	<tr>
		<td>Mã đồ án</td>
		<td><input type="text" name="mdt" size="20"></td>
	</tr>
	<tr><th></th><td><input type="submit" value="  sua " style="font-weight: bold"></td></tr>
	</table>
</form>
</center>
<%end if%>
<%end if%>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>
