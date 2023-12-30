<%
MaDDH=Request("MaDDH")
Set Con = Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
TrangThai=Request("TTDDH")
sqlString="Update DONDATHANG Set TrangThaiDDH= " & TrangThai & " where MaDDH=" & MaDDH
Con.Execute (sqlString)
Response.Redirect "frmHienThiDDH.asp"
%>