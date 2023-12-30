<%
MaLH=Trim(Request("MaLH"))
Set Con = Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

sqlString= "Delete From LOAIHANG Where MaLH='" & MaLH & "'"
set RS=Con.Execute (sqlString)
Response.Redirect "frmHienThiLH.asp"
%>