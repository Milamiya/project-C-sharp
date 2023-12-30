<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>sửa thông tin giáo viên</title>
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
 sql="select * from tblgvhd"
 sql=sql & " where ID_gvhd= '"&request("mgv")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then 
 mgv=request("mgv")
 ht=request("ht")
 hh=request("hh")
 dv=request("dv")
 set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="suatblgvhd"
 cmd.Parameters.Append cmd.CreateParameter("@magvhd",202,1,10,mgv)
 cmd.Parameters.Append cmd.CreateParameter("@hoten",202,1,50,ht)
 cmd.Parameters.Append cmd.CreateParameter("@hocham",202,1,50,hh)
 cmd.Parameters.Append cmd.CreateParameter("@dvct",202,1,50,dv)
 cmd.Execute ,,adExecuteNorecords
%><%=request("msv")%><b><font size="4">ĐÃ SỬA XONG THÔNG TIN GIÁO VIÊN </font>
</b> 
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
