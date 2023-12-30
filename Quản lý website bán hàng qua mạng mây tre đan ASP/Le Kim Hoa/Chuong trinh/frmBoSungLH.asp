<!--#include file="KiemTraPasswordDN.asp"-->
<html>

<head>
</head>

<body bgcolor="#E0EAB9" onload=frmAdd.MaLH.focus()>
<!--#inClude file="TieuDeQL.asp"-->
<form method="post" action="XuLyLH.asp" name="frmAdd">
<center>
<table border="0" width="601" cellspacing="0" cellpadding="4" height="10">
    <tr bgcolor="#99CC00">
      <td width="600" align="center" height="1" >
         <p>
         <b><font size="5" color="#660033">B&#7893; Sung Lo&#7841;i M&#7863;t Hàng Vào C&#417; S&#7903; D&#7919; 
         Li&#7879;u </font></b>
	  </td>
    </tr>
</table>
<table width="600" bgcolor="lightyellow" border=1 cellpadding="4" cellspacing="0" height="57">
<tr>
	<td height="1">
	<font color="#0000CC">
	<b>Mã lo&#7841;i hàng</b></font></td>
	<td height="1">
	<input name="MaLH" size="10" maxlength="50">
	</td>
</tr>
<tr>
	<td height="1">
	<font color="#0000CC">
	<b>Tên lo&#7841;i m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td height="1">
	<input name="TenLH" size="50" maxlength="50">
	</td>
</tr>
<tr>
	<td height="25">
	<font color="#0000CC">
	<b>Mô t&#7843; lo&#7841;i hàng&nbsp; </b>
	</font>
	</td>
	<td height="25">
	<textarea name="MoTaLH" cols="50" rows="3" wrap="virtual"></textarea>
	</td>
</tr>
<tr>
	<td colspan=2 align="right" height="1">
	<input type="button" name="btnSubmit" value="B&#7893; sung" style="float: left">
	</td>
</tr>
</table>
</center>
<input name="BoSungLH" type="hidden" value="1" size="20">
</form>
<SCRIPT LANGUAGE=vbscript>
Sub btnSubmit_Onclick()
	IF LEN(frmAdd.MaLH.value)=0 THEN
		Alert "Ban phai nhap vao ten mat hang"
		frmAdd.MaLH.focus
		Exit Sub
	ElseIF LEN(frmAdd.TenLH.value)=0 THEN
		Alert "Ban phai nhap vao ten mat hang"
		frmAdd.TenLH.focus
		Exit Sub
	END IF
	Call frmAdd.Submit()
End Sub
</SCRIPT>
</body>
</html>