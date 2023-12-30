<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Bo sung chuyen nganh</title>
</head>

<body background="HINH%20ANH/nen1.JPG" style="background-attachment: fixed">
<!--#include file="header.asp"-->
<table border="0" width="100%" id="table1">
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
 
<font size="4" color="#FFFFFF">BỔ SUNG CHUYÊN NGÀNH</font></b></p>
<CENTER>
<form method=post action=bschuyenn1.asp>
<table border="0" width="100%">
	<tr>
		<td><font color="#FFFFFF">Mã chuyên ngành </font> </td>
		<td><input type="text" name="mcn" size="20"></td>
	</tr>
	<tr>
		<td><font color="#FFFFFF">Tên chuyên ngành</font></td>
		<td><input type="text" name="tcn" size="20"></td>
	</tr>

	<tr>
		<td>&nbsp;</td>
		<td><input type="submit" value="BỔ SUNG" style="font-weight: bold"></td>
	</tr>
</table>
 
</form><td valign=top>
			<!--#include file="right.asp"-->
		</td>
</table>


 </CENTER>
     <%ELSE%>
      <%end if%>
  <%end if%>
</body>

</html>
