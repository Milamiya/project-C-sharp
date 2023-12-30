<!--#INCLUDE FILE="HamLuuTru.asp"-->
<%
MaMH=TRIM(Request("MaKH"))
MaDC=TRIM(Request("MaDC"))
Username=TRIM(Request("Username"))
Password=TRIM(Request("Password"))
HoTenKH=TRIM(Request("HoTenKH"))
Duong=TRIM(Request("Duong"))
Quan=TRIM(Request("Quan"))
ThanhPho=TRIM(Request("ThanhPho"))
QuocGia=TRIM(Request("QuocGia"))
Phone=TRIM(Request("Phone"))
Email=TRIM(Request("Email"))
backpage="MyPage.asp"
'Request.ServerVariables("SCRIPT_NAME")
If KiemTraEmail(Email) Then
	errorForm "Ban khong nhap dung email", backpage
End If

	'Cap nhat thong tin
	sqlstring="Update DIACHI SET" &_
			"HoTenKH='" & HoTenKH & "', Duong='" & Duong & "', " &_
			"Quan='" & Quan & "', ThanhPho='" & ThanhPho & "',  " &_
			"QuocGia='" & QuocGia & "' Phone='" & Phone & "'" &_
			"Email='" & Email & "'" &_
			"Where MaDC=" & MaDC
	Con.Execute sqlString

%>