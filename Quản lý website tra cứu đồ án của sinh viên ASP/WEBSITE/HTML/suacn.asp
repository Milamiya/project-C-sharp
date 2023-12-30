<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>sửa chuyên ngành</title>
</head>
<body background="HINH%20ANH/nen1.jpg">
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>
			<form method=post action=suacn1.asp>
<!--#include file="ketnoi.inc"-->
<%
 sql1="select * from tblchuyennganh"
 set rs1 = cn.execute(sql1)
 if not rs1.eof then
 %>
 <p align="center"><b><font size="4">SỬA THÔNG TIN CHUYÊN NGÀNH</font></b></p>
 <table border="0" width="100%" id="table1">
	<tr>
		<td>Tên chuyên ngành</td>
		<td><select name=mcn size=1>
		<%do while not rs1.eof%>
		<option value="<%=rs1("ID_chuyennganh")%>"><%=rs1("tenchuyennganh")%></option>
			 <%rs1.movenext
    loop
    end if%> 
		</select></td>
	</tr>
	<tr>
		<td> </td>
		<td><input type="submit" value="SỬA" style="font-weight: bold"></td>
		<td></td>
	</tr>
</table>
</form>
</center>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>
</html>
