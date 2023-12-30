<%@ Language=VBScript %>
<!--#INCLUDE FILE="adovbs.inc"-->
<!--#INCLUDE FILE="HamLuuTru.asp"-->
<%
'Lay thong tin dang nhap
Username=TRIM(Request("Username"))
Password=TRIM(Request("Password"))

'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'lay ma khach hang
MaKH=KiemTraPassword(Username, Password, Con)

IF MaKH>0 THEN
%>
	<!--#INCLUDE FILE="DanhSachDDH.asp" -->
<%ELSE%>
	<!--#INCLUDE FILE="frmDangNhap.asp" -->
<%END IF%>