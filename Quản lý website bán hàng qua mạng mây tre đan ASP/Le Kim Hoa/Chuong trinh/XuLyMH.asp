<%
CapNhatMH=TRIM(Request("CapNhatMH"))
BoSungMH=TRIM(Request("BoSungMH"))
	MaMH=TRIM(Request("MaMH"))
	TenMH=TRIM(Request("TenMH"))
	DonGia=TRIM(Request("DonGia"))
	FileAnhMH=TRIM(Request("FileAnhMH"))
	MaLH=TRIM(Request("MaLH"))
	MoTaN=TRIM(Request("MoTaN"))
	MoTaDD=TRIM(Request("MoTaDD"))
	TrangThaiMH=TRIM(Request("TrangThaiMH"))
'khoi tri
IF FileAnhMH="" THEN
	FileAnhMH="?????"
END IF
IF MoTaN="" THEN
	MoTaN="?????"
END IF
IF MoTaDD="" THEN
	MoTaDD="?????"
END IF

'Ket noi co so du lieu
set Con=Server.CreateObject("ADODB.connection")
Con.Open "storeDSN" 

sqlString="Select MaMH from MATHANG Where MaMH='" & MaMH & "'"
SET RS=Con.Execute(sqlString)

'Bo sung mat hang moi vao co so du lieu
IF BoSungMH<>"" and RS.EOF THEN
	sqlString="INSERT INTO MATHANG(MaMH, MaLH, TenMH, DonGia, FileAnhMH, MotaN, MoTaDD,TrangThaiMH)" &_
			"VALUES ('" & MaMH & "', '" & MaLH & "','" & TenMH & "', " & cCUR(DonGia) & "," &_
			" '" & FileAnhMH & "', '" & MoTaN & "','" & MoTaDD & "'," & TrangThaiMH & ") "
	Con.Execute sqlString
End If

' Cap nhat mat hang
IF CapNhatMH<>"" THEN
	sqlString=" UPDATE MATHANG SET "&_
		" TenMH='" & Cstr(TenMH)& "'"&_
	    ", DonGia= "& ccur(DonGia) &" "&_
	    ",FileAnhMH='" & Cstr(FileAnhMH) & "'"&_
	    ",MoTaN='" & Cstr(MoTaN) & "' "&_
		",MoTaDD='" & Cstr(MoTaDD) & "' "&_
		",TrangThaiMH= " & TrangThaiMH & " WHERE  MaMH='" & MaMH & "' "
	Con.Execute sqlString
END IF
Response.Redirect "frmHienThiMH.asp"
%>