<html>

<head>
<%session.codepage=65001%>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Ket qua bo sung</title>
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
 if trim(rs("nguoidung"))="admin" then
 
 sql="select * from tbldetai"
 sql=sql & " where ID_detai= '"&request("mda")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %></p>
<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">
			<font size="4" color="#FF0000">MÃ ĐỀ TÀI NÀY ĐÃ CÓ TRONG CSDL
 <%ELSE
  mda=request("mda")
  tda=request("tda")
  tt=request("tt")
  dd=request("dd")
  mcn=request("mcn")

	sql = "Insert Into tbldetai Values(N'"&mda&"', N'"&tda&"', N'"&tt&"', N'"&dd&"', N'"&mcn&"')"
	cn.Execute (sql)
	
%>
 %><br>ĐÃ BỔ SUNG XONG
 <%END IF
 end if
 end if%></font></td>

		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>


