<%
Ma=Trim(Request("cat"))

' Mo ket noi
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'Tao doi tuong mat hang
Set prodRS=Server.CreateObject("ADODB.Recordset")
prodRS.ActiveConnection=Con
prodRS.CursorType=adOpenStatic
sqlString="SELECT MaMH, TenMH, DonGia, FileAnhMH, MoTaN FROM MATHANG " &_ 
		" WHERE MaLH='" & Ma & "' And TrangThaiMH=1"
prodRS.Open sqlString

sqlString="SELECT * FROM LOAIHANG  WHERE MaLH='" & Ma & "' " 
SET cRS=Con.Execute(sqlString)

%>
<html>
<head>
<title>Danh sach Mat Hang</title>
</head>

<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/MAUNEN.GIF">
<table height="290" width="595">
<CENTER>
<tr>
<td width="596" height="39" >
	<font face="Times New Roman">
	<b><font color="blue">
	Lo&#7841;i hàng&nbsp; </font> <font color="dackblue"><%=cRS("TenLH")%></font></b>
	<font color="blue">
là <%=cRS("MoTaLH")%> bao g&#7891;m các m&#7863;t hàng : </font>
    </font>
<p style="margin-top: 0; margin-bottom: 0">
<font face="Times New Roman">
<Img SRC="FileAnhHoTroWeb\L2.gif" width="593" height="3"> </font> </p>
</td>
</tr>
<tr>
<td height="238" width="596">
<table width="546" border=0 cellpadding=5 cellspacing=0 height="302">
<% WHILE NOT prodRS.EOF %>
<tr>
	<td width="73" height="107">
	<% IF prodRS("FileAnhMH")<>"" THEN %>
    <p style="margin-top: 0; margin-bottom: 0">
	<img src="FileAnhMatHang\<%=prodRS("FileAnhMH")%>" hspace=4 vspace=4 border=0 align="center">
	<% END IF %>
	</td>
	<td width="540" align="top" height="107">
		<p style="margin-top: 0; margin-bottom: 0">
		<font face="Times New Roman">
		<b>Ten :
		<font color="blue"><%=prodRS("TenMH")%></font></b>
		<br><font color="blue"><%=prodRS("MoTaN")%></font>
		<a href="MatHang.asp?MaMH=<%=prodRS("MaMH")%>" target="_parent">chi tiet >></a>
		<form method="post" action="KiemTraKH.asp" name="frmChon">
		<br><b>Gia :</b><font color="blue">	<%=prodRS("DonGia")%></font> dong
		<br></font><b><font face="Times New Roman">So luong :
				<Input type="text" value="1" name="SoLuong" size="2"></font></b><font face="Times New Roman">
        </font> </p>
			<font face="Times New Roman">
			<Input type="hidden" value="<%=prodRS("MaMH")%>" name="pid">
			</font>
			<p style="margin-top: 0; margin-bottom: 0">
			<font face="Times New Roman">
			<input type="submit" value="Chon mua" name="btnsubmit" target="_parent">
            </font> </p>
		</form>
	</td>
</tr>
<%
prodRS.MoveNext
WEND
prodRS.Close

%>
<tr>
<td height="177">
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td height="1" width="596"></td>
</tr>
</CENTER>
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
	ElseIF Len(frmChon.SoLuong.value)>10 Then
		Alert "Ban phai nhap lai so luong mat hang can mua <= 10  so"
		frmChon.soluong.focus
		Exit Sub
	ElseIF Not isNumeric(frmChon.SoLuong.value) THEN
		Alert "Ban phai nhap lai So Luong mat hang can mua la mot con so"
		frmChon.SoLuong.value=""
		frmAdd.SoLuong.focus
		Exit Sub
	ElseIF frmChon.SoLuong.value<=0 THEN
		Alert "Ban phai nhap lai So Luong mat hang can mua la mot con so >0"
		frmChon.SoLuong.value=""
		frmAdd.SoLuong.focus
		Exit Sub
	END IF
	Call frmChon.Submit()
End Sub
</script>