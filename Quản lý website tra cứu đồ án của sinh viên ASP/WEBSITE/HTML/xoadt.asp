<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>xóa đề tài</title>
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
 sql=sql & " where ID_detai= '"&request("mdt")&"'" 
 set rs = cn.execute(sql)
 if not rs.eof then
 mdt=request("mdt")
 set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="xoadt"
 cmd.Parameters.Append cmd.CreateParameter("@madetai",202,1,10,mdt)
 cmd.Execute ,,adExecuteNorecords
 %><b><font size="4">ĐÃ XÓA XONG<br>
 <%ELSE%>KHÔNG CÓ ĐỀ TÀI NÀY</font></b>
 <%END IF%>
  <%END IF%>
   <%END IF%>
</p>
</center>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>
