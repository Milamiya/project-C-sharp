<!--#include file="KiemTraPasswordDN.asp"-->

<!--#include file="KiemTraPasswordDN.asp"-->

<%
'Khai bao bien 
Dim sqlString

'Ket noi CSDL
Set Con=Server.Createobject("ADODB.Connection")
Con.Open "DSN=StoreDSN"
sqlString="Select MaLH, TenLH From LOAIHANG "
          
Set RS=Con.Execute(sqlString)
%>

<html>

<head>
<title>Hien thi Mat hang</title>
</head>

<body bgcolor="#E0EAB9">
<!--#include file="TieuDeQL.asp"-->
<center>
  <table border="0" width="564" cellspacing="0" cellpadding="0" height="41">
  	<tr>
  		<td width="564">
  		<br><font color="#000080"><b>Click v�o</b></font><b><a href="frmBoSungLH.asp">
        <font color="#FF0000">B&#7893; sung</font></a> <font color="#000080">&#273;&#7875; th�m 
        lo&#7841;i m&#7863;t h�ng m&#7899;i v�o c&#417; s&#7903; d&#7919; li&#7879;u.</font></b><font color="#000080">
        </font>
        <br><b><font color="#000080">&#272;&#7875; xo� lo&#7841;i m&#7863;t h�ng kh&#7887;i c&#417; s&#7903; d&#7919; li&#7879;u 
        click &quot;Delete&quot;.</font></b><br><font color="#000080"><b>&#272;&#7875; c&#7853;p nh&#7853;t&nbsp; h�y click v�o m� m&#7863;t h�ng ho&#7863;c t�n m&#7863;t h�ng d&#432;&#7899;i &#273;�y :
        </b>
        </font>
        <br><br>
 		</td>
  	</tr>
  </table>
  <table border="1" width="565" cellspacing="0" cellpadding="4" height="1">
  <tr bgcolor="lightgreen" >
  	 <th width="136" height="1">M� lo&#7841;i h�ng</th>
  	 <th width="332" height="1">T�n lo&#7841;i h�ng</th>
  </tr>
  <%Do While Not RS.EOF%>
  <tr bgcolor="lightyellow">
   	<td width="136" height="1">
   	<a href="frmCapNhatLH.asp?MaLH=<%=RS("MaLH")%>">
   		 <%=RS("MaLH")%></a>
   	</td>	
  	<td width="332" height="1">
  	<a href="frmCapNhatLH.asp?MaLH=<%=RS("MaLH")%>">
   		 <%=RS("TenLH")%></a>
    </td>
    <td width="65">
    <a href="XoaLH.asp?MaLH=<%=RS("MaLH")%>">Delete</a>
    </td>
  </tr>
  <%
  	RS.MoveNext 
  	Loop
  	RS.Close
  %>
  
  </table>
</body>

</html>