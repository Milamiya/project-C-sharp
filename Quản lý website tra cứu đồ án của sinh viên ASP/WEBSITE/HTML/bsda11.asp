<html>
<%session.codepage=65001%>
<head>
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
 if trim(rs("nguoidung"))="admin" then%>
 
<p align="center"><b><font size="4" color="#FFFFFF">BỔ SUNG ĐỒ ÁN</font></b></p>
<center>
<form method=post action=bsda12.asp>
<table border="0" width="100%">
	<tr>
		<td><font color="#FFFFFF">Mã đồ án</font></td>
		<td><input type="text" name="mda" size="30"></td>
	</tr>
	<tr>
		<td><font color="#FFFFFF">Tên đồ án</font></td>
		<td><font color="#FFFFFF"><input type="text" name="tda" size="30"></font></td>
	</tr>
	<tr>
		<td height="27"><font color="#FFFFFF">Tóm tắt</font></td>
		<td height="27"><textarea rows="9" name="tt" cols="38"></textarea></td>
	</tr>
	<tr>
		<td><font color="#FFFFFF">Đường dẫn</font></td>
		<td><input type="file" name="dd" size="42"></td>
	</tr>

<%
 sql="select * from tblchuyennganh"
 set rs = cn.execute(sql)
    if  not rs.eof then %>
	<tr>
		<td><font color="#FFFFFF">Tên chuyên ngành</font></td>
		<td><select name=mcn size==1>
	<%do while not rs.eof%>
	    <option value="<%=rs("ID_chuyennganh")%>"><%=rs("tenchuyennganh")%></option>
	<%rs.movenext
    loop
    end if%> 
		</select></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td><input type="submit" value="BỔ SUNG" style="font-weight: bold"></td>
	</tr>
</table>
</form>
</center></td>
		
 <%else%> <li><a href="xoasv1.asp" title="XÓA THÔNG TIN SINH VIÊN">XÓA&nbsp;THÔNG&nbsp;TIN&nbsp;SINH&nbsp;VIÊN</a></li>
 <%end if%><%end if%>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>


