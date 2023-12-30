<!--#include file="KiemTraPasswordDN.asp"-->
<%
'Lay ma mat hang
MaLH=TRIM(Request("MaLH"))

'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'An dinh chuoi hien thi loai mat hang da lua chon de cap nhat
sqlString="Select * from LOAIHANG where MaLH='" & MaLH & "' "
SET RS=Con.Execute(sqlString)

IF NOT RS.EOF THEN
	TenLH=RS("TenLH")
	MoTaLH=RS("MoTaLH")
END IF
	
If TenLH="?????" Then
	TenLH=""
End if
If MoTaLH="?????" Then
	MoTaLH=""
End if
%>
<HTML>
<HEAD>
<TITLE>Cap Nhat mat hang</TITLE>
</HEAD>
<BODY bgcolor="#E0EAB9"  onload=xuLyCN.TenLH.focus()>
<!--#inClude file="TieuDeQL.asp"-->
<form method="post" action="XuLyLH.asp" name=xuLyCN>

<center>
<table border="0" width="648" cellspacing="0" cellpadding="4" height="8">
    <tr bgcolor="#99CC00">
      <td width="647" align="center" height="1" >
         <p>
	<font face=" Arial" size="5" color="#800080">
	<b>C&#7853;p Nh&#7853;t Lo&#7841;i M&#7863;t Hàng Trong C&#417; S&#7903; D&#7919; Li&#7879;u</b>
	</font>
	  </td>
    </tr>
  </table>
<table width="647" bgcolor="lightyellow" border=1 cellpadding="4" cellspacing="0" height="196">
<tr>
	<td width="194" height="1">
	<font color="#000099">
	<b>Mã lo&#7841;i m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td width="431" height="1">
	<%=Server.HTMLEncode (MaLH)%>
	</td>
</tr>
<tr>
	<td width="194" height="1">
	<font color="#000099">
	<b>Tên lo&#7841;i m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td width="431" height="1">
	<input name="TenLH" size="20" maxlength="20"
			value="<%=Server.HTMLEncode (TenLH)%>">
	</td>
</tr>
<tr>
	<td width="194" height="81">
	<font color="#000099">
	<b>Mô t&#7843; lo&#7841;i m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td width="431" height="81">
	<textarea  name="MoTaLH" cols="51" rows="4" 
				wrap="virtual"><%=server.HTMLEncode (MoTaLH)%>
	</textarea>
	</td>
</tr>
<tr>
	<td colspan=2 align="right" width="609" height="10">
	<font face="Times New Roman"><b>
	<input type="button" name="KiemTra" value="C&#7853;p nh&#7853;t" style="float: left"> </b>
    </font>
	</td>
</tr>
</table>
</center>
<input name="MaLH" type="hidden" value="<%=MaLH%>">
<input name="CapNhatLH" type="hidden" value="1">
</form>
<%
'Dong va khu tham chieu doi tuong database
RS.Close
Set RS=Nothing
%>
<Script language=vbscript>
Sub KiemTra_OnClick()
	If Len(xulyCN.TenLH.value)=0 Then
		Alert "Ban phai nhap vao ten loai mat hang"
		xulyCN.TenLH.focus
		Exit Sub
	ElseIf Len(xulyCN.MoTaLH.value)=0  Then
		MoTaLH="?????"
	End If
	Call xulyCN.Submit()
End Sub
</Script>
</BODY>
</HTML>