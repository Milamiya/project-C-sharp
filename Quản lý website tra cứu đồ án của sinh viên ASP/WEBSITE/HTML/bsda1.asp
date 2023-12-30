<%session.codepage=65001%>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Ket qua bo sung</title>


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
 sql="select * from tbldetai1"
 sql=sql & " where ID_detai= '"&request("mda")&"' "
 set rs = cn.execute(sql)
 if  not rs.eof then %></p>
<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">&nbsp;<p align="center">
			<font size="4" color="#FF0000">MÃ ĐỀ TÀI NÀY ĐÃ CÓ TRONG CSDL
 <%ELSE
  mda=request("mda")
  tda=request("tda")
  tt=request("tt")
  dd=request("dd")
  mcn=request("mcn")

	sql = "Insert Into tbldetai1 Values(N'"&mda&"', N'"&tda&"',N'"&tt&"',N'"&dd&"',N'"&mcn&"')"
	cn.Execute (sql)
	
%>
 %><br>ĐÃ BỔ SUNG XONG
 <%END IF

 %></font></td>

		</td>
		
		<td valign=top>
			<!--#include file="right.asp"-->
		</td>
	</tr>
</table>
</body>



