<html>
<head>
<meta http-equiv="Content-Language" content="en-us">
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>BỔ SUNG SINH VIÊN</title>
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
 sql1="select * from tbldangnhap"
 sql1=sql1 & " where nguoidung= '"& nd &"' and  matkhau='"& mk &"'"
 set rs1 = cn.execute(sql1)
 if   rs1.eof then
 response.redirect("login.htm")
 else 
 %>
<p align="center"><b><font size="4">BỔ SUNG THÔNG TIN SINH VIÊN</font></b></p>
<CENTER>
<form method=post action=bssv1.asp>
<table border="0" width="60%">
	<tr>
		<td>Mã sinh viên</td>
		<td><input type="text" name="msv" size="30"></td>
	</tr>
	<tr>
		<td>Họ Tên</td>
		<td><input type="text" name="ht" size="30"></td>
	</tr>
	<tr>
		<td>Địa chỉ</td>
		<td><input type="text" name="dc" size="30"></td>
	</tr>
<!--#include file="ketnoi.inc"-->
<%
 sql="select * from tbllop"
 set rs = cn.execute(sql)
    if  not rs.eof then %>
	<tr>
	<tr>
		<td>Tên Lớp</td>
		<td><select name=tl size=1>
	<%do while not rs.eof%>
	    <option value="<%=rs("tenlop")%>"><%=rs("tenlop")%></option>
	<%rs.movenext
    loop
    end if%> 
		</select></td>
	</tr>

		<td></td>
		<td><input type="submit" value="BỔ SUNG" style="font-weight: bold"></td>
	</tr>
</table>
</form>
</CENTER>
<%end if%>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>
