<%
MaDDH=Trim(Request("MaDDH"))
Set Con = Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
sqlString= "select MaKH, MaDC From DONDATHANG Where MaDDH=" & MaDDH & ""
set RS0=Con.Execute (sqlString)
sqlString= "select MaDC From DONDATHANG"
set RS01=Con.Execute (sqlString)
KiemTRa=0
Do While NOT RS01.EOF
	if RS0("MaDC")= RS01("MaDC") then
		KiemTra=1
		Exit do
	end if
	RS01.MoveNext
Loop
RS01.Close

if not RS0.EOF then
	sqlString= "select MaDC From KHACHHANG Where MaKH=" & RS0("MaKH") & ""
	set RS=Con.Execute (sqlString)
	if not RS.EOF then
		If RS0("MaDC")<>RS("MaDC") and KiemTra=0 then
			sqlString1= "Delete From XUAT Where MaDDH=" & MaDDH & ""
			sqlString2= "Delete From DONDATHANG Where MaDDH=" & MaDDH & ""
			set RS1=Con.Execute (sqlString1)
			set RS2=Con.Execute (sqlString2)
			sqlString= "Delete From DIACHI Where MaDC=" & RS0("MaDC") & ""
			set RS3=Con.Execute (sqlString)
		Else
			sqlString1= "Delete From XUAT Where MaDDH=" & MaDDH & ""
			sqlString2= "Delete From DONDATHANG Where MaDDH=" & MaDDH & ""
			set RS1=Con.Execute (sqlString1)
			set RS2=Con.Execute (sqlString2)
		End IF
	End IF
end if
Response.Redirect "frmHienThiDDH.asp"
%>