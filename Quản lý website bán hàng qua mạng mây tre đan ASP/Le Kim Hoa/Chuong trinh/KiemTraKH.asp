<%@ Language=VBScript %>
<!--#INCLUDE FILE="adovbs.inc"-->
<!--#INCLUDE FILE="HamLuuTru.asp"-->
<%
'Lay thong tin dang nhap
Username=TRIM(Request("Username"))
Password=TRIM(Request("Password"))
DangKy=TRIM(Request("DangKy"))
Error=TRIM(Request("Error"))
DangNhap=Trim(Request("DangNhap"))
SoLuong=Trim(Request("SoLuong"))
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'Kiem tra dang ky
IF DangKy<>"" AND Error="" THEN
	'bo sung khack hang
	addUser
END IF

'lay ma khach hang
MaKH=KiemTraPassword(Username, Password, Con)

IF MaKH>0 THEN
	%>
	<!--#INCLUDE FILE="GioMH.asp" -->	
<%ELSE%>
	<!--#INCLUDE FILE="frmDangKy.asp" -->
<%END IF%>