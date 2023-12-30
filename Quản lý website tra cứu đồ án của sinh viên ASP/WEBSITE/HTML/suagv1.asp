<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>sửa thông tin giáo viên theo mã</title>
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
 sql=sql & " where ID_gvhd= '"&request("mgv")&"'" 
 set rs = cn.execute(sql)
 if not rs.eof then
 %>
 <center>
 <form method=post action=suagv.asp>

 <table border="0" width="70%">
 <p align="center"><b><font size="4"> THÔNG TIN GIÁO VIÊN HƯỚNG DẪN</font></b></p>
	<tr>
		<td>Mã giáo viên</td>
		<td><input type="text" name="mgv" readonly value="<%=rs("ID_gvhd")%>" size="20"></td>
	</tr>
	<tr>
		<td>Họ tên</td>
		<td><input type="text" name="ht" value="<%=rs("hoten")%>"  size="30"></td>
	</tr>
	<tr>
		<td>Học hàm_học vị</td>
		<td><input type="text" name="hh" value="<%=rs("hocham_hocvi")%>"  size="30"></td>
	</tr>
	<tr>
		<td>Đơn vị công tác</td>
		<td><input type="text" name="dv" value="<%=rs("donvicongtac")%>""" size="50"></td>
	</tr>
	</table>
	<input type="submit" value="Thực hiện sửa">
 </form>
 <%else%> Không có giáo viên này
 <%end if%>
  <%end if%>
   <%end if%>
 </center>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>
