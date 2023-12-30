<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>SỬA THÔNG TIN ĐỀ TÀI</title>
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
 sql="select * from tbldetai"
 sql=sql & " where ID_detai= '"&request("mdt")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then 
 mdt=request("mdt")
 tdt=request("tdt")
 tt=request("tt")
 url=request("url")
 mcn=request("mcn")
 set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="suatbldetai"
 cmd.Parameters.Append cmd.CreateParameter("@id_detai",202,1,10,mdt)
 cmd.Parameters.Append cmd.CreateParameter("@tendetai",202,1,250,tdt)
 cmd.Parameters.Append cmd.CreateParameter("@tomtat",202,1,500,tt)
 cmd.Parameters.Append cmd.CreateParameter("@URL",202,1,50,url)
 cmd.Parameters.Append cmd.CreateParameter("@id_chuyennganh",202,1,10,mcn)
 cmd.Execute ,,adExecuteNorecords
%><p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p align="center"><b><font size="4">ĐÃ SỬA XONG THÔNG TIN</font></b></p>
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
