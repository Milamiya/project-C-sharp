<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Thông tin sinh viên cần sửa</title>

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
 sql="select * from tblsinhvien"
 sql=sql & " where ID_sinhvien= '"&request("msv")&"'" 
 set rs = cn.execute(sql)
 if not rs.eof then
 %>
 <center><b><font size="4">THÔNG TIN SINH VIÊN</font></b><font size="4"> </font>
<form  method=post action=suasv.asp>
 <table border="0" width="60%">
	<tr>
		<td>Mã sinh viên :</td>
		<td><input type=text name="msv" size="30" readonly value=<%=rs("ID_sinhvien")%>></td>
	</tr>
	<tr>
		<td>Họ tên sinh viên : </td>
		<td><input type="text" name="ht" size="30"   value="<%=rs("hoten")%>"""></td>
	</tr>
	<tr>
		<td>Địa chỉ : </td>
		<td><input type="text" name="dc" size="30" value="<%=rs("diachi")%> """></td>
	</tr>
<%
 sql1="select * from tbllop"
 set rs1 = cn.execute(sql1)
   if not rs1.eof then
 %><tr>
		<td>Tên lớp</td>
		<td><select name=tl size=1>
		<option value= "<%=rs("tenlop")%>" selected><%=rs("tenlop")%></option>
	<%do while not rs1.eof%>
		 <option value= "<%=rs1("tenlop")%>"><%=rs1("tenlop")%></option>
		 <%rs1.movenext
    loop
    end if%>   
		</select></td>
	</tr>
	<tr>
		<td> </td>
		<td><input type="submit" value="Thực hiện sửa" style="font-weight: bold"></td>
	</tr>
	<%else%> Sinh viên này không có trong CSDL
	<%end if%>	
	<%end if%>	
	<%end if%>	
	</table> 
</form>
</center>
		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>


</html>
