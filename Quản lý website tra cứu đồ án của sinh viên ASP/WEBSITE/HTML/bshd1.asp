<html>

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
<font color="#FF0000">
<%
 sql="select * from tblhuongdan"
 sql=sql & " where ID_detai= '"&request("mdt")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %></font></p>
<p align="center"> &nbsp;<p align="center"> &nbsp;<p align="center"> &nbsp;<p align="center"> 
			<font size="4" color="#FF0000">ĐỀ TÀI NÀY ĐÃ CÓ TRONG BẢNG HƯỚNG DẪN
 <%ELSE
     mgv=request("mgv")
     mdt=request("mdt")
     msv=request("msv")
     nth=request("nth")
     sql1="select * from tblhuongdan"
     sql1=sql1 & " where ID_sinhvien= '"&request("msv")&"' "
     set rs1 = cn.execute(sql1)
     if  not rs1.eof then %></font><p align="center"> 
<font size="4" color="#FF0000">HÃY KIỂM TRA LẠI MÃ SINH VIÊN
     <%ELSE
       set cmd=server.createobject("ADODB.command")
       cmd.ActiveConnection=cn
       cmd.CommandType=4
       cmd.CommandText="bosungtblhuongdan"
       cmd.Parameters.Append cmd.CreateParameter("@magv",202,1,10,mgv)
       cmd.Parameters.Append cmd.CreateParameter("@madt",202,1,50,mdt)
       cmd.Parameters.Append cmd.CreateParameter("@masv",202,1,500,msv)
       cmd.Parameters.Append cmd.CreateParameter("@namthuchien",202,1,50,nth)
       cmd.Execute ,,adExecuteNorecords%><br>ĐÃ BỔ SUNG XONG
       <%END IF%>
  <%end if%>
</font>
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
