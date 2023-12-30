<html>

<head>
<meta http-equiv="Content-Language" content="en-us">
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>XÓA THÔNG TIN ĐỀ TÀI</title>
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
<%
 nd=session("nd")
 mk=session("mk")
 sql1="select * from tbldangnhap"
 sql1=sql1 & " where nguoidung= '"& nd &"' and  matkhau='"& mk &"'"
 set rs1 = cn.execute(sql1)
 if   rs1.eof then
 response.redirect("login.htm")
 else 
 %>

<center>
<form method=post action=xoadt.asp>
<table border="0" width="60%">
<p align="center"><b><font size="4">XÓA THÔNG TIN THEO MÃ</font></b></p>
	<tr>
		<td>Mã đề tài</td>
		<td><input type="text" name="mdt" size="30"></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td><input type="submit" value="  XÓA  " style="font-weight: bold"></td>
	</tr>
</table>
</form>
</center>
<%end if%>
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
