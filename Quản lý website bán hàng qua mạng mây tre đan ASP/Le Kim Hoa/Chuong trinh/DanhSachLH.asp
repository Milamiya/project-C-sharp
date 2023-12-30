<%
' Mo ket noi
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

' Tao doi tuong recordset
Set catRS=Server.CreateObject("ADODB.Recordset")
catRS.ActiveConnection=Con
sqlString="SELECT MaLH, TenLH FROM LOAIHANG"
catRS.Open sqlString
%>
	<% WHILE NOT catRS.EOF %>
	<li><a href="DanhsachMH.asp?cat=<%=Server.URLEncode(catRS("MaLH"))%>" target="_parent">
	<font color="blue"><b>
	<%=catRS("TenLH")%></b></font></a>
	<%
	catRS.MoveNext
	WEND
	%></U><%catRS.close%>