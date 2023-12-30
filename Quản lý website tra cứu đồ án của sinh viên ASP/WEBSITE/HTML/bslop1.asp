<html>

<head>
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
			<!--#include file="ketnoi.inc"-->
<%
 sql="select * from tbllop"
 sql=sql & " where tenlop= '"&request("ml")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %></p>
<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">
			<font size="4">LỚP NÀY ĐÃ TỒN TẠI
 <%ELSE
  ml=request("ml")
  mn=request("mn")
  set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="bosungtbllop"
 cmd.Parameters.Append cmd.CreateParameter("@tenlop",202,1,10,ml)
 cmd.Parameters.Append cmd.CreateParameter("@man",202,1,10,mn)
 cmd.Execute ,,adExecuteNorecords
 %><br>ĐÃ BỔ SUNG XONG
 <%END IF%></font>

		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>


</html>
