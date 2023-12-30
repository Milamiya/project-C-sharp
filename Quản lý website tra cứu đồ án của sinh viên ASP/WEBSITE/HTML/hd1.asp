<html>

<head>
<meta http-equiv="Content-Language" content="en-us">
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>THÔNG&nbsp; TIN THỰC HIỆN ĐỀ TÀI</title>
</head>
<body background="HINH%20ANH/nen1.jpg">
<!--#include file="header.asp"-->
<table border="0" width="100%">
	<tr>
		<td width=220>
			<!--#include file="left.asp"-->
		</td>
		<td valign=top width=600>
			<center>
<form method=post action=hd2.asp>
<p align="center"><font size="4">THÔNG TIN THỰC HIỆN ĐỀ TÀI</font></p>
<table border="0" width="416">
<!--#include file="ketnoi.inc"-->
 <% sql3="select * from tblhuongdan"
    sql3=sql3 & " where ID_detai= '"&request("mdt")&"'" 
    set rs3 = cn.execute(sql3)
    if not rs3.eof then%>
    <tr>
         <td>Mã đề tài</td>
         <td> <input type=text readonly name="mdt"  value="<%=rs3("ID_detai")%>""" size="20"></td>
    </tr>         	
 		<tr>
			<td>Mã giáo viên</td>
			<td><input type="text" name="mgv" readonly value="<%=rs3("ID_gvhd")%>" size="20"></td>
		</tr>
		<tr>
			<td>Mã sinh viên</td>
			<td><input type="text" name="msv" readonly value="<%=rs3("ID_sinhvien")%>" size="20"></td>
		</tr>
	<tr><td>Năm Thực Hiện</td><td><input type="text" name="nth" value="<%=rs3("namthuchien")%>" size="10"></td></tr>
	<%end if%>
	<tr><td></td><td><input type="submit" value="Thực hiện sửa"></td></tr>
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