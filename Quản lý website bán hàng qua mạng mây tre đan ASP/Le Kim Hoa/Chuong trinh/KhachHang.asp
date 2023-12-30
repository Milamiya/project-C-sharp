<%@ Language=VBScript %>
<!--#INCLUDE FILE="adovbs.inc"-->
<!--#INCLUDE FILE="HamLuuTru.asp"-->
<%
'Lay thong tin dang nhap
Username=TRIM(Request("Username"))
Password=TRIM(Request("Password"))
Error=TRIM(Request("Error"))
CapNhatKH=TRim(Request("CapNhatKH"))
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
IF CapnhatKH<>"" And Error="" THEN
	UpdateUser
END IF
'lay ma khach hang
MaKH=KiemTraPassword(Username, Password, Con)
IF MaKH>0 THEN
	sqlString="Select MaDC From KHACHHANG Where MaKH= " & MaKH & " "
	Set RS=Con.Execute (sqlString)
	If Not RS.EOF Then
		sqlString="Select * From DIACHI Where MaDC=" & RS("MaDC")
		Set RS1=Con.Execute (sqlString)
		If Not RS1.EOF Then
			HoTenKH=RS1("HoTenKH")
			Duong=RS1("Duong")
			Quan=RS1("Quan")
			ThanhPho=RS1("ThanhPho")
			QuocGia=RS1("QuocGia")
			Phone=RS1("Phone")
			Email=RS1("Email")
		End If
	End If
END IF
submitpage=Request.ServerVariables("Script_Name")

%><!--#INCLUDE FILE="Mypage.asp"-->