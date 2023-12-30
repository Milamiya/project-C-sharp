<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Thực hiện sửa</title>
</head>

<body background="HINH%20ANH/nen1.jpg">
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>
			<p align="center">

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
 sql="select * from tblsinhvien"
 sql=sql & " where ID_sinhvien= '"&request("msv")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then 
 msv=request("msv")
 ht=request("ht")
 dc=request("dc")
 tl=request("tl")
 set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="suatblsinhvien"
 cmd.Parameters.Append cmd.CreateParameter("@masv",202,1,10,msv)
 cmd.Parameters.Append cmd.CreateParameter("@hoten",202,1,50,ht)
 cmd.Parameters.Append cmd.CreateParameter("@dc",202,1,50,dc)
 cmd.Parameters.Append cmd.CreateParameter("@tenlop",202,1,10,tl)
 cmd.Execute ,,adExecuteNorecords
%><font size="4"><b>ĐÃ SỬA XONG THÔNG TIN SINH VIÊN</b></font></p>
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
