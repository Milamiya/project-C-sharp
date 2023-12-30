<html>

<head>
<meta http-equiv="Content-Language" content="en-us">
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>BỔ SUNG LỚP</title>
</head>

<body background="HINH%20ANH/nen1.jpg">
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>
		<center>
			<!--#include file="ketnoi.inc"-->
<%
 nd=session("nd")
 mk=session("mk")
 sql2="select * from tbldangnhap"
 sql2=sql2 & " where nguoidung= '"& nd &"' and  matkhau='"& mk &"'"
 set rs2 = cn.execute(sql2)
 if   rs2.eof then
 response.redirect("login.htm")
 else 
 %>
<form method=post action=bslop1.asp>
<%
 sql1="select * from tblchuyennganh"
 set rs1 = cn.execute(sql1)
 if not rs1.eof then
 %>
 <p align="center"><b><font size="4">BỔ SUNG LỚP</font></b></p>
 <table border="0" width="60%" id="table1">
	<tr>
		<td>Mã lớp</td>
		<td><input type="text" name="ml" size="20"></td>
	</tr>
	<tr>
		<td>Mã ngành</td>
		<td><select name=mn size=1>
		<%do while not rs1.eof%>
		<option value="<%=rs1("ID_chuyennganh")%>"><%=rs1("tenchuyennganh")%></option>
			 <%rs1.movenext
    loop
    end if%> 
		</select></td>
	</tr>
	<tr>
		<td> </td>
		<td><input type="submit" value="BỔ SUNG" style="font-weight: bold"></td>
		<td></td>
	</tr>
</table>
</form>
</center>
<%end if%>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>
</html>