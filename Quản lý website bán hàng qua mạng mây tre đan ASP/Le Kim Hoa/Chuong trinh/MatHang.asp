<%
Ma=Trim(Request("MaMH"))
' Mo ket noi
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
'Tao doi tuong
Set prodRS=Server.CreateObject("ADODB.Recordset")
prodRS.ActiveConnection=Con
prodRS.CursorType=adOpenStatic
sqlString="SELECT * FROM MATHANG " 
sqlString=sqlString & " WHERE MaMH='" & Ma & "' And TrangThaiMH=1"
'sqlString=sqlString & "ORDER BY TenMH DESC"
prodRS.Open sqlString
%>

<html>
<head>
<title>Chi tiec Mat Hang</title>
</head>

<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/BlowBlueSand.jpg">
<table width="588" border=0 cellpadding=5 cellspacing=0 height="305">
<% If NOT prodRS.EOF then%><font face="Times New Roman"> </font>
	<p align="left">
	<font face="Times New Roman">
	<b>M&#7863;t hàng :<font color="blue"><%=prodRS("TenMH")%>
    </font></b>&nbsp;<Img SRC="FileAnhHoTroWeb\N7.gif" width="582" height="2" >
    </font>

<tr>
	<td width="138" height="101">
	<table width="138" border=0 cellpadding=5 cellspacing=0 >
		<tr>
			<td width="1" height="49">
			<% IF prodRS("FileAnhMH")<>"" THEN %><font face="Times New Roman">
            </font>
            <p style="margin-top: 0; margin-bottom: 0">
				<font face="Times New Roman">
				<img src="FileAnhMatHang\<%=prodRS("FileAnhMH")%>" hspace=4 vspace=4 border=0 align="center">
			<% END IF %> </font>
			</td>
		</tr>
		<tr>
			<td >
			<p style="margin-top: 0; margin-bottom: 0">
			<font face="Times New Roman">
			<b>Gia : </b><font color="blue">&nbsp;<%=prodRS("DonGia")%></font>dong
            </font>
			</td>
		</tr>
	</table>
	</td>
	<td width="441" height="101">
	<table width="438" border=0 cellpadding=0 cellspacing=0  >
		<tr>
			<td width="365">
			<p style="margin-top: 0; margin-bottom: 0">
            <font face="Times New Roman">Mô t&#7843; ng&#7855;n :<font color="blue"><%=prodRS("MoTaN")%></font>
			<br>Mô t&#7843; &#273;&#7847;y &#273;&#7911; :<font color="blue"><%=prodRS("MoTaDD")%></font>
            </font>
			</td>
		</tr>
		<tr>
			<td colspan=2 width="438" height="63">
			<form method="post" action="KiemTraKH.asp" name="frmChon">
				<p align="left" style="margin-top: 0; margin-bottom: 0">
				<b><font face="Times New Roman">So luong :
				<Input type="text" value="1" name="SoLuong" size="2"></font></b><font face="Times New Roman">
                </font> </p>
				<font face="Times New Roman">
				<Input type="hidden" value="<%=prodRS("MaMH")%>" name="MaMH">
				</font>
				<p align="center" style="margin-top: 0; margin-bottom: 0">
				<font face="Times New Roman">
				<input type="button" value="Chon mua" name="btnsubmit" style="float: left" size="20"> </p>
			</form>
			</td>
		</tr>
	</table>
	</td>	
</tr>
<% End If%> </font>
<tr>
<td height="185" width="138">
</td>
</tr>
</table>
</td>
<!--#Include file="Footer.asp"-->
</body>
</html>
<Script language=vbscript>
Sub btnSubmit_Onclick()
	IF Len(frmChon.SoLuong.value)=0 Then
		Alert "Ban phai nhap lai so luong mat hang can mua"
		frmChon.soluong.focus
		Exit Sub
	ElseIF Not isNumeric(frmChon.SoLuong.value) THEN
		Alert "Ban phai nhap lai So Luong mat hang can mua la mot con so"
		frmChon.SoLuong.value=""
		frmAdd.SoLuong.focus
		Exit Sub
	END IF
	Call frmChon.Submit()
End Sub
</script>