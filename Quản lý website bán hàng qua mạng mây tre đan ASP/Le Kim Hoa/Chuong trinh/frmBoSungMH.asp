<!--#include file="KiemTraPasswordDN.asp"-->
<%
'Mo doi tuong Recordset
Set RS=server.CreateObject ("ADODB.Recordset")
RS.Open "LOAIHANG", "DSN=storeDSN"
%>
<html>

<head>
</head>

<body bgcolor="#E0EAB9" onload="frmAdd.MaMH.focus()">
<!--#inClude file="TieuDeQL.asp"-->
<form method="post" action="XuLyMH.asp" name="frmAdd">
<center>
<table border="0" width="601" cellspacing="0" cellpadding="4" height="10">
    <tr bgcolor="#99CC00">
      <td width="600" align="center" height="1" >
         <p>
         <b><font size="5" color="#660033">B&#7893; Sung M&#7863;t Hàng Vào C&#417; S&#7903; D&#7919; 
         Li&#7879;u </font></b>
	  </td>
    </tr>
</table>
<table width="600" bgcolor ="lightyellow" border=1 cellpadding="4" cellspacing="0" height="357">
<tr>
	<td height="23">
	<font color="#0000CC">
	<b>Mã m&#7863;t hàng</b></font></td>
	<td height="23">
	<input name="MaMH" size="4" maxlength="50">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#0000CC">
	<b>Tên m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<input type="text" name="TenMH" value="" size="50" maxlength="50">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#0000CC">
	<b>Giá m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<input name="DonGia" size="10">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#0000CC">
	<b>File &#7843;nh m&#7863;t hàng&nbsp;&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<input name="FileAnhMH" size="50" maxlength="50">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#0000CC">
	<b>Lo&#7841;i m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<SELECT name="MaLH">
	<%
		Do While Not RS.EOF 
	%>
		<OPTION value="<%=RS("MaLH")%>">
		<%=RS("TenLH")%>
		</OPTION>
	<%
		RS.MoveNext 
		Loop
		RS.Close 
		set RS=Nothing
	%>
	</SELECT>
	</td>
</tr>
<tr>
	<td height="36">
	<font color="#0000CC">
	<b>Mô t&#7843; ng&#7855;n&nbsp; </b>
	</font>
	</td>
	<td height="36">
	<textarea name="MoTaN" cols="50" rows="2" wrap="virtual"></textarea>
	</td>
</tr>
<tr>
	<td height="43">
	<font color="#0000CC">
	<b>Mô t&#7843; &#273;&#7847;y &#273;&#7911;&nbsp; </b>
	</font>
	</td>
	<td height="43">
	<textarea name="MoTaDD" cols="50" rows="3" wrap="virtual"></textarea>
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#0000CC">
	<b>Tr&#7841;ng thái m&#7863;t hàng</b></font></td>
	<td height="23">
	<select name="TrangThaiMH">
	<option value="1">Mat hang con san xuat
	<option value="0">Mat hang khong con san xuat
	</select>
	</td>
</tr>
<tr>
	<td colspan=2 align="right" height="17">
	<input type="button" name="btnSubmit" value="B&#7893; sung" style="float: left">
	</td>
</tr>
</table>
</center>
<input name="BoSungMH" type="hidden" value="1" size="20">
</form>
<SCRIPT LANGUAGE=vbscript>
Sub btnSubmit_Onclick()
	IF LEN(frmAdd.MaMH.value)=0 THEN
		Alert "Ban phai nhap vao ma mat hang"
		frmAdd.MaMH.focus
		Exit Sub
	ElseIF LEN(frmAdd.MaMH.value)<>4 THEN
		Alert "Ban phai nhap vao ma mat hang dung 4 ky tu"
		frmAdd.MaMH.value=""
		frmAdd.MaMH.focus
		Exit Sub
	ElseIF LEN(frmAdd.TenMH.value)=0 THEN
		Alert "Ban phai nhap vao ten mat hang"
		frmAdd.TenMH.focus
		Exit Sub
	ElseIF LEN(frmAdd.DonGia.value)=0 THEN
		Alert "Ban phai nhap vao don gia mat hang"
		frmAdd.DonGia.focus
		Exit Sub
	ElseIF Not isNumeric(frmAdd.DonGia.value) THEN
		Alert "Ban phai nhap lai don gia mat hang"
		frmAdd.DonGia.value=""
		frmAdd.DonGia.focus
		Exit Sub
	END IF
	Call frmAdd.Submit()
End Sub
</SCRIPT>
</body>
</html>