<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>THÔNG TIN CHUYÊN NGÀNH</title>
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
 sql="select * from tblchuyennganh"
 sql=sql & " where ID_chuyennganh= '"&request("mcn")&"'" 
 set rs = cn.execute(sql)
  if not rs.eof then
 %>
 <center>
 <form method=post action=suacn2.asp>
 <b><font size="4">THÔNG TIN CHUYÊN NGÀNH</font></b>
 <table border="0" width="100%">
	<tr>
		<td>Mã chuyên ngành</td>
		<td><input type="text" name="mdt" readonly value="<%=rs("ID_chuyennganh")%>" size="20"></td>
	</tr>
	<tr>
		<td>Tên chuyên ngành</td>
		<td><input type="text" name="tdt" value="<%=rs("tenchuyennganh")%>" size="30"></td>
	</tr>


		<td></td>
		<td><input type="submit" value="Thực hiện sửa"></td>
	</tr>

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
