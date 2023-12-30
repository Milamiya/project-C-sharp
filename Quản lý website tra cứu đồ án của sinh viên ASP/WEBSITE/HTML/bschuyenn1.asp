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
 <%
 sql="select * from tblchuyennganh"
 sql=sql & " where ID_chuyennganh= '"&request("mcn")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %><br>&nbsp;<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p align="center"><font color="#FF0000">CHUYÊN NGÀNH NÀY ĐÃ TỒN TẠI
  <%ELSE
  mcn=request("mcn")
  tcn=request("tcn")
  set cmd=server.createobject("ADODB.command")
 cmd.ActiveConnection=cn
 cmd.CommandType=4
 cmd.CommandText="bosungtblchuyennganh"
 cmd.Parameters.Append cmd.CreateParameter("@macn",202,1,10,mcn)
 cmd.Parameters.Append cmd.CreateParameter("@tcn",202,1,50,tcn)
 cmd.Execute ,,adExecuteNorecords
 %></font><br><font color="#FF0000">ĐÃ BỔ SUNG XONG
 <%end if%></font>
<%else%> <li><a href="xoasv1.asp" title="XÓA THÔNG TIN SINH VIÊN">XÓA&nbsp;THÔNG&nbsp;TIN&nbsp;SINH&nbsp;VIÊN</a></li>
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




