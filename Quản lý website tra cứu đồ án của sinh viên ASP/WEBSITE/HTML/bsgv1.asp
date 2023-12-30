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
 sql="select * from tblgvhd"
 sql=sql & " where ID_gvhd= '"&request("mgv")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %></p>
<p align="center"> &nbsp;<p align="center"> &nbsp;<p align="center"> 
			<font size="4" color="#FF0000">GIÁO VIÊN NÀY ĐÃ TỒN TẠI
 <%ELSE
     mgv=request("mgv")
     ht=request("ht")
     hh=request("hh")
     dv=request("dv")
    
       set cmd=server.createobject("ADODB.command")
       cmd.ActiveConnection=cn
       cmd.CommandType=4
       cmd.CommandText="bosungtblgvhd"
       cmd.Parameters.Append cmd.CreateParameter("@magv",202,1,10,mgv)
       cmd.Parameters.Append cmd.CreateParameter("@hoten",202,1,50,ht)
       cmd.Parameters.Append cmd.CreateParameter("@hh",202,1,50,hh)
       cmd.Parameters.Append cmd.CreateParameter("@dvct",202,1,50,dv)
       cmd.Execute ,,adExecuteNorecords%><br>ĐÃ BỔ SUNG XONG
     
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

