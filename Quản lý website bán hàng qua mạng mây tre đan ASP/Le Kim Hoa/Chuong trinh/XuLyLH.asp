<%
CapNhatLH=TRIM(Request("CapNhatLH"))
BoSungLH=TRIM(Request("BoSungLH"))
	MaLH=TRIM(Request("MaLH"))
	TenLH=TRIM(Request("TenLH"))
	MoTaLH=TRIM(Request("MoTaLH"))
	
'khoi tri
IF MoTaLH="" THEN
	MoTaLH="?????"
END IF

'Ket noi co so du lieu
set Con=Server.CreateObject("ADODB.connection")
Con.Open "storeDSN" 

sqlString="Select MaLH from LOAIHANG Where MaLH='" & MaLH & "'"
SET RS=Con.Execute(sqlString)

'Bo sung loai mat hang moi vao co so du lieu
IF BoSungLH<>"" and RS.EOF THEN
		sqlString="INSERT INTO LOAIHANG(MaLH, TenLH, MoTaLH)" &_
				"VALUES ('" & MaLH & "','" & TenLH & "','" & MoTaLH & "') "
		Con.Execute sqlString
End If

' Cap nhat Loai mat hang
IF CapNhatLH<>"" THEN
	sqlString=" UPDATE LOAIHANG SET "&_
		" TenLH='" & Cstr(TenLH)& "'"&_
	    ",MoTaLH='" & Cstr(MoTaLH) & "' "&_
	 " WHERE  MaLH='" & MaLH & "' "
	Con.Execute sqlString
END IF

Response.Redirect "frmHienThiLH.asp"
%>