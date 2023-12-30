<%
MaMH=Trim(Request("MaMH"))
Set Con = Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
sqlString= "Delete From MATHANG Where MaMH='" & MaMH & "'"
set RS=Con.Execute (sqlString)
Response.Redirect "frmHienThiMH.asp"
%>