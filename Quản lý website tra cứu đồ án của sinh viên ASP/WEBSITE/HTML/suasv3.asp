<html>

<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>sưa thông tin sin viên theo mã</title>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
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
<form method=post action=suasv1.asp>
  <table border="0" width="60%">
  <p align="center"><b><font size="4">SƯA THÔNG TIN SINH 
VIÊN THEO MÃ</font></b></p>
	<tr>
		<td>Mã sinh viên</td>
		<td><input type="text" name="msv" size="20"></td>
	</tr>
	<tr> <td></td><td><input type=submit value="  sua  " ></td>
	</tr>
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