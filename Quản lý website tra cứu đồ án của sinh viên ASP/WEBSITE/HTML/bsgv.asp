<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Ket qua bo sung</title>
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
 
<p align="center"><b><font size="4">BỔ SUNG GIÁO VIÊN HƯỚNG DẪN</font></b></p>
<form method=post action=bsgv1.asp>
<CENTER>
<table border="0" width="60%">
	<tr>
		<td>Mã giáo viên</td>
		<td><input type="text" name="mgv" size="30"></td>
	</tr>
	<tr>
		<td>Họ Tên</td>
		<td><input type="text" name="ht" size="30"></td>
	</tr>
	<tr>
		<td>Học hàm_học vị</td>
		<td><input type="text" name="hh" size="30"></td>
	</tr>
	<tr>
		<td>Đơn vị công tác</td>
		<td><input type="text" name="dv" size="30"></td>
	</tr>
	<tr>
		<td></td>
		<td><input type="submit" value="BỔ SUNG" style="font-weight: bold"></td>
	</tr>
</table>
</CENTER>
</form>
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




