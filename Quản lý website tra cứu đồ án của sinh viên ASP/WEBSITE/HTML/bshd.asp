<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Bo sung </title>
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
<b><font size="4">BỔ SUNG THÔNG TIN HƯỚNG DẪN ĐỀ TÀI</font></b></p>
<CENTER>
<form method=post action=bshd1.asp>
<table border="0" width="100%">
<%
 sql="select * from tblgvhd"
 set rs = cn.execute(sql)
    if  not rs.eof then %>
	<tr>
		<td>Mã giáo viên</td>
		<td><select name=mgv size==1>
	<%do while not rs.eof%>
	    <option value="<%=rs("ID_gvhd")%>"><%=rs("ID_gvhd")%></option>
	<%rs.movenext
    loop
    end if%> 
		</select></td>
<%
 sql1="select * from tbldetai"
 set rs1 = cn.execute(sql1)
    if  not rs1.eof then %>
	<tr>
		<td>Mã đề tài</td>
		<td><select name=mdt size==1>
	<%do while not rs1.eof%>
	    <option value="<%=rs1("ID_detai")%>"><%=rs1("ID_detai")%></option>
	<%rs1.movenext
    loop
    end if%> 
		</select></td>
<%
 sql2="select * from tblsinhvien"
 set rs2 = cn.execute(sql2)
    if  not rs2.eof then %>
	<tr>
		<td>Mã sinh viên</td>
		<td><select name=msv size==1>
	<%do while not rs2.eof%>
	    <option value="<%=rs2("ID_sinhvien")%>"><%=rs2("ID_sinhvien")%></option>
	<%rs2.movenext
    loop
    end if%> 
		</select></td>

	<tr>
		<td>Năm thực hiện</td>
		<td><input type="text" name="nth" size="20"></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td><input type="submit" value="BỔ SUNG" style="font-weight: bold"></td>
	</tr>
</table>
</form>
</CENTER>
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