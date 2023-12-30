<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Dang nhap</title>
</head>
<body background="HINH%20ANH/nen1.jpg">
<!--#include file="ketnoi.inc"-->
<%
 sql="select * from tbldangnhap"
 sql=sql & " where nguoidung= '"&request("nd")&"' and  matkhau='"&request("mk")&"'"
 set rs = cn.execute(sql)
 if   rs.eof then
     response.redirect("login.htm")
     else
           nd=request("nd")
           mk=request("mk")
           session("nd")=nd
           session("mk")=mk
           if trim(rs("nguoidung"))="admin" then%>
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>

		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
         <%ELSE%><!--#include file="tracuu.asp"-->
         <%end if
 end if
  end if
  end if%>
</body>

</html>