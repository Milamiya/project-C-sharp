<!--#include file="KiemTraPasswordDN.asp"-->
<%
'Khai bao bien 
Dim sqlString

'Ket noi CSDL
Set Con=Server.Createobject("ADODB.Connection")
Con.Open "DSN=StoreDSN"
sqlString="Select MaMH, TenMH, DonGia From MATHANG "
          
Set RS=Con.Execute(sqlString)
%>

<html>

<head>
<title>Hien thi Mat hang</title>
</head>

<body bgcolor="#E0EAB9">
<!--#include file="TieuDeQL.asp"-->
<center>
  <table border="0" width="674" cellspacing="0" cellpadding="0" height="41">
  	<tr>
  		<td width="674">
  		<br><b><font color="#000080">Click v�o</font><a href="frmBoSungMH.asp">
        <font color="#FF0000">B&#7893; sung</font></a> <font color="#000080">&#273;&#7875; th�m m&#7863;t h�ng m&#7899;i v�o c&#417; s&#7903; d&#7919; li&#7879;u.</font></b><font color="#000080">
        </font>
        <br><b><font color="#000080">&#272;&#7875; xo� m&#7863;t h�ng kh&#7887;i c&#417; s&#7903; d&#7919; li&#7879;u click 
        &quot;Delete&quot;.</font></b><br><font color="#000080"><b>&#272;&#7875; c&#7853;p nh&#7853;t ho&#7863;c xo� m&#7863;t h�ng kh&#7887;i c&#417; s&#7903; d&#7919; li&#7879;u, h�y click v�o m� m&#7863;t h�ng ho&#7863;c t�n m&#7863;t h�ng d&#432;&#7899;i &#273;�y :
        </b>
        </font>
        <br><br>
 		</td>
  	</tr>
  </table>
  <table border="1" width="677" cellspacing="0" cellpadding="4" height="56">
  <tr bgcolor="lightgreen" >
  	 <th width="136" height="17">M� m&#7863;t h�ng</th>
  	 <th width="284" height="17">T�n m&#7863;t h�ng</th>
  	 <th width="168" height="17">&#272;&#417;n gi�</font></th>
  </tr>
  <%Do While Not RS.EOF%>
  <tr bgcolor="lightyellow">
   	<td width="136" height="19">
   	<a href="frmCapNhatMH.asp?MaMH=<%=RS("MaMH")%>">
   		 <%=RS("MaMH")%></a>
   	</td>	
  	<td width="284" height="19">
  	<a href="frmCapNhatMH.asp?MaMH=<%=RS("MaMH")%>">
   		 <%=RS("TenMH")%></a>
    </td>
   	<td width="177" height="19" align="Center">
   	<%=formatcurrency(RS("DonGia")/100,2)%>
    </td>
    <td height="19">
    <a href="XoaMH.asp?MaMH=<%=RS("MaMH")%>">Delete</a>
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