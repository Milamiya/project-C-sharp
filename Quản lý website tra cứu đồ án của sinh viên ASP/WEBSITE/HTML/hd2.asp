<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>SỬA THÔNG TIN ĐỒ ÁN</title>
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

 <%  sql="select * from tblhuongdan"
 sql=sql & " where ID_detai= '"&request("mdt")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then 
    mdt=request("mdt")
    mgv=request("mgv")
    msv=request("msv")
    nth=request("nth")
    set cmd=server.createobject("ADODB.command")
    cmd.ActiveConnection=cn
    cmd.CommandType=4
    cmd.CommandText="suatblhuongdan"
    cmd.Parameters.Append cmd.CreateParameter("@magv",202,1,10,mgv)
    cmd.Parameters.Append cmd.CreateParameter("@madt",202,1,10,mdt)
    cmd.Parameters.Append cmd.CreateParameter("@masinhvien",202,1,10,msv)
    cmd.Parameters.Append cmd.CreateParameter("@namthuchien",202,1,10,nth)
    cmd.Execute ,,adExecuteNorecords
    %><p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p align="center"><b>BÃ SỬA XONG THÔNG TIN ĐỀ TÀI</b><Br>
<%end if%>
</p>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>
