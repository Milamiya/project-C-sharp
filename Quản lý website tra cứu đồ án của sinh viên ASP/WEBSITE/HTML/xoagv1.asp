<html>

<head>
<meta http-equiv="Content-Language" content="en-us">
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>XÓA THÔNG TIN GIÁO VIÊN</title>
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
<CENTER>
<form method=post action=xoagv.asp>
<table border="0" width="60%">
<p align="center"><b><font size="4">XÓA THÔNG TIN GIÁO VIÊN</font></b></p>
	<tr>
		<td>Mã  giáo viên</td>
		<td><input type="text" name="mgv" size="20"></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td><input type="submit" value="Thực hiện xóa" style="font-weight: bold"></td>
	</tr>
</table>
</form>
</CENTER>
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
