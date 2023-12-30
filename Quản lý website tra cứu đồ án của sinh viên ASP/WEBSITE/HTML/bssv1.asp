<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>SINH VIÊN NÀY ĐÃ CÓ TRONG CSDL</title>
</head>

<body background="HINH%20ANH/nen1.jpg">
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>
			<p>
<!--#include file="ketnoi.inc"-->
<%
 sql="select * from tblsinhvien"
 sql=sql & " where ID_sinhvien= '"&request("msv")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %></p>
<p align="center"><font size="4">SINH VIÊN NÀY ĐÃ CÓ TRONG CSDL
 <%ELSE
  msv=request("msv")
  ht=request("ht")
  dc=request("dc")
  tl=request("tl")
  set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="bosungtblsinhvien"
 cmd.Parameters.Append cmd.CreateParameter("@masv",202,1,10,msv)
 cmd.Parameters.Append cmd.CreateParameter("@ten",202,1,50,ht)
 cmd.Parameters.Append cmd.CreateParameter("@dc",202,1,50,dc)
 cmd.Parameters.Append cmd.CreateParameter("@tlop",202,1,10,tl)
 cmd.Execute ,,adExecuteNorecords
 %><br>ĐÃ BỔ SUNG XONG
 <%END IF%>
</font>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>


</html>
