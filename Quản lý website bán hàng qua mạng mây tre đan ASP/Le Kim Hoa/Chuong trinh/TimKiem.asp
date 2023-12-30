<%

TimKiem=Trim(request("TimKiem"))

Set con=server.CreateObject("ADODB.Connection")
con.Open "storeDSN"

sqlString="Select MaMH, FileAnhMH, TenMH, MoTaN, DonGia From MATHANG " &_
		"Where TrangThaiMH=1 And ( TenMH Like '% " & TimKiem & " %' Or MoTaN Like '% " & TimKiem & " %' )" &_ 
		"Order By TenMH"

Set RS=con.Execute(sqlString)
%>

<html>
<head>
<title>Tim Kiem Mat Hang</title>
</head>

<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/Brown.jpg">
<%If not RS.EOF And TimKiem<>"" Then%>
<table width="595" border=0 cellpadding=5 cellspacing=0 height="163">
	<p align="left">
	<font face="Times New Roman">
	<font color="darkblue" size="4">
	<b>K&#7871;t qu&#7843; tìm ki&#7871;m : </b>
	</font>
<Img SRC="FileAnhHoTroWeb\L2.gif" width="100%" height="3">

<%
while Not RS.EOF
%> </font> </p>
<tr>
	<td width="79" height="107">
	<%If RS("FileAnhMH")<>"" Then%><font face="Times New Roman"> </font>
    <p style="margin-top: 0; margin-bottom: 0">
	<font face="Times New Roman">
	<Img SRC="FileAnhMatHang\<%=RS("FileAnhMH")%>" hspace=4 vspace=4 Border=0 align="center">
	<%End If%> </font>
	</td>
	<td width="595" align="top" height="107">
		<form method="post" action="KiemTraKH.asp" name="frmChon">
		<p style="margin-top: 0; margin-bottom: 0">
		<font face="Times New Roman">
		<b>Ten :
		<font color="blue"><%=RS("TenMH")%></font></b>
		<br><font color="blue"><%=RS("MoTaN")%></font>
		<a href="MatHang.asp?MaMH=<%=RS("MaMH")%>" target="_parent"><font color="#FF00FF">chi tiet >></font></a><font color="#FF00FF">
        </font>
		<br><b>Gia :</b><font color="blue">	<%=RS("DonGia")%></font> dong
		<br></font><b><font face="Times New Roman">So luong :
		<Input type="text" value="1" name="SoLuong" size="2"></font></b><font face="Times New Roman">
        </font> </p>
		<font face="Times New Roman">
		<Input type="hidden" value="<%=RS("MaMH")%>" name="MaMH">
			</font>
			<p style="margin-top: 0; margin-bottom: 0">
			<font face="Times New Roman">
			<input type="submit" value="Chon mua" name="chon" target="_parent">
            </font> </p>
		</form>
	</td>
</tr>
<tr>
	<td colspan=2 align="center" width="586" height="38">
	<p style="margin-top: 0; margin-bottom: 0"><font face="Times New Roman">&nbsp;
    </font>
	</td>
<tr>
<%
RS.MoveNext
WEnd
%><font face="Times New Roman"> </font>
</table>
<%Else%><font face="Times New Roman"> </font>
<table width="597" border=0 cellpadding=5 ceellspacing=0 height="165">
<tr>
	<td width="583" height="37">
	<p style="margin-top: 0; margin-bottom: 0">
	<font face="Times New Roman" color="#FF0000" size="4">
	<b>M&#7863;t hàng quí khách c&#7847;n tìm c&#7917;a hàng chúng tôi hi&#7879;n th&#7901;i không có. </b>
	</font>
	</p>
	<p style="margin-top: 0; margin-bottom: 0">
	<font face="Times New Roman" color="#FF0000" size="4">
	<b>Mong quí khách thông c&#7843;m !!!</b>
	</font>
	</td>
</tr>
<tr>
<td height="105">
</td>
</tr>
</table>
<%End If%>
<td>
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