<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>THÔNG TIN ĐỀ TÀI</title>
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
 sql2="select * from tbldangnhap"
 sql2=sql2 & " where nguoidung= '"& nd &"' and  matkhau='"& mk &"'"
 set rs2= cn.execute(sql2)
 if   rs2.eof then
 response.redirect("login.htm")
 else 
 %>
<CENTER>
<form method=post action=hd1.asp>
<table border=0 width=311>
<CENTER></CENTER><font size="4">THÔNG TIN ĐỀ TÀI </font></CENTER>
<!--#include file="ketnoi.inc"-->
	<%
 sql1="select * from tblhuongdan"
 set rs1 = cn.execute(sql1)
   if not rs1.eof then%>
	<tr>
		<td><b>Mã đề tài</b></td>
		<td><select name=mdt size=1>
		<%do while not rs1.eof%>
		 <option value= "<%=rs1("ID_detai")%>"><%=rs1("ID_detai")%></option>
		 <%rs1.movenext
    loop
    end if%>
		</select></td>
		</tr>
		<tr><td></td><td><input type="submit" value="Thực hiện sửa" style="font-weight: bold"></td></tr>
</table>
</form>
</CENTER>
<%end if%>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>

</html>