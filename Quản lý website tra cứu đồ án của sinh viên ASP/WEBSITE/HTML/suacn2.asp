<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>ĐÃ SỬA XONG THÔNG TIN</title>
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
 
 mdt=request("mdt")
 tdt=request("tdt")
 set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="suatblcn"
 cmd.Parameters.Append cmd.CreateParameter("@manganh",202,1,10,mdt)
 cmd.Parameters.Append cmd.CreateParameter("@tennganh",202,1,150,tdt)
 cmd.Execute ,,adExecuteNorecords
%><p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p align="center"><b><font size="4">ĐÃ SỬA XONG THÔNG TIN</font></b></p>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>
<!--#include file="ketnoi.inc"-->
<%
 
 mdt=request("mdt")
 tdt=request("tdt")
 set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="suatblcn"
 cmd.Parameters.Append cmd.CreateParameter("@manganh",202,1,10,mdt)
 cmd.Parameters.Append cmd.CreateParameter("@tennganh",202,1,150,tdt)
 cmd.Execute ,,adExecuteNorecords
%><p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p align="center"><b><font size="4">ĐÃ SỬA XONG THÔNG TIN</font></b></p>
</html>
