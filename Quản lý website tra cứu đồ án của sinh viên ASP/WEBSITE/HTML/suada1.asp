<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>SỬA THÔNG TIN ĐỒ ÁN</title>
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
 %>
 <center>
 <form method=post action=suada.asp>
 <b><font size="4">THÔNG TIN ĐỀ TÀI</font></b>
 <table border="0" width="80%">
	<tr>
		<td>Mã đồ án:</td>
		<td><input type="text" name="mdt" readonly value="<%=rs("ID_detai")%>" size="20"></td>
	</tr>
	<tr>
		<td>Tên đồ án</td>
		<td><input type="text" name="tdt" value="<%=rs("tendetai")%>" size="60"></td>
	</tr>
	<tr>
		<td>Tóm tắt</td>
		<td><textarea name="tt" cols="50" rows="8"><%=rs("tomtat")%></textarea></td>
	</tr>
	<tr>
		<td>URL</td>
		<td><input type="file" name="url" value="<%=rs("URL")%>" size="40"></td>
	</tr>
	
	<%
 sql1="select * from tblchuyennganh"
 set rs1 = cn.execute(sql1)
 if not rs1.eof then
 %>
 <tr>
		<td>Mã chuyên ngành</td>
		<td><select name=mcn size=1>
		<option value= "<%=rs("ID_chuyennganh")%>" selected><%=rs("ID_chuyennganh")%></option>
	<%do while not rs1.eof%>
		 <option value= "<%=rs1("ID_chuyennganh")%>"><%=rs1("ID_chuyennganh")%></option>
		 <%rs1.movenext
    loop
    end if%>   
		</select></td>
	</tr>
		<td></td>
		<td><input type="submit" value="Thực hiện sửa"></td>
	</tr>
	<%else%> Không có đề tài này
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