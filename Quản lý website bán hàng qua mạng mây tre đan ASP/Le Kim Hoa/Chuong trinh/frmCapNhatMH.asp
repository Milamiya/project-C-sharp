<!--#include file="KiemTraPasswordDN.asp"-->
<%
'Lay ma mat hang
MaMH=TRIM(Request("MaMH"))

'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'An dinh chuoi hien thi mat hang da lua chon de cap nhat
sqlString="Select * from MATHANG where MaMH='" & MaMH & "' "
SET RS=Con.Execute(sqlString)

IF NOT RS.EOF THEN
	TenMH=RS("TenMH")
	DonGia=RS("DonGia")
	FileAnhMH=RS("FileAnhMH")
	MaLH=RS("MaLH")
	MoTaN=RS("MoTaN")
	MoTaDD=RS("MoTaDD")
	TrangThaiMH=RS("TrangThaiMH")
END IF

FUNCTION SELECTED(tam1, tam2)
	IF cSTR(tam1)=cSTR(tam2) THEN
		SELECTED ="SELECTED"
	END IF	
END FUNCTION	
If TenMH="" Then
	TenMH="?????"
End if
If MaLH="" Then
	MaLH="?????"
End if
If MoTaN="" Then
	MoTaN="?????"
End if
If MoTaDD="" Then
	MoTaDD="?????"
End if
%>
<HTML>
<HEAD>
<TITLE>Cap Nhat mat hang</TITLE>
</HEAD>
<BODY bgcolor="#E0EAB9">
<!--#inClude file="TieuDeQL.asp"-->

<form method="post" action="XuLyMH.asp" name=xuLyCN>

<center>
<table border="0" width="648" cellspacing="0" cellpadding="4" height="8">
    <tr bgcolor="#99CC00">
      <td width="647" align="center" height="1" >
         <p>
	<font face=" Arial" size="5" color="#800080">
	<b>C&#7853;p Nh&#7853;t M&#7863;t Hàng Trong C&#417; S&#7903; D&#7919; Li&#7879;u</b>
	</font>
	  </td>
    </tr>
  </table>
<table width="647" bgcolor="lightyellow" border=1 cellpadding="4" cellspacing="0" height="171">
<tr>
	<td width="194" height="1">
	<font color="#000099">
	<b>Mã m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td width="431" height="1">
	<%=Server.HTMLEncode (MaMH)%>
	</td>
</tr>
<tr>
	<td width="194" height="1">
	<font color="#000099">
	<b>Tên m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td width="431" height="1">
	<input name="TenMH" size="20" maxlength="20"
			value="<%=TenMH%>">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#000080">
	<b>Giá m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<input name="DonGia" size="10" value="<%=DonGia%>">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#000080">
	<b>File &#7843;nh m&#7863;t hàng&nbsp;&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<input name="FileAnhMH" size="50" maxlength="50" value="<%=FileAnhMH%>">
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#000080">
	<b>Lo&#7841;i m&#7863;t hàng&nbsp; </b>
	</font>
	</td>
	<td height="23">
	<input name="MaLH" size="50" maxlength="4" value="<%=MaLH%>">
	</td>
</tr>
<tr>
	<td height="36">
	<font color="#000080">
	<b>Mô t&#7843; ng&#7855;n&nbsp; </b>
	</font>
	</td>
	<td height="36">
	<textarea  name="MoTaN" cols="51" rows="4" 
				wrap="virtual"><%=MoTaN%>
	</textarea>
	</td>
</tr>
<tr>
	<td height="43">
	<font color="#000080">
	<b>Mô t&#7843; &#273;&#7847;y &#273;&#7911;&nbsp; </b>
	</font>
	</td>
	<td height="43">
	<textarea  name="MoTaDD" cols="51" rows="4" 
				wrap="virtual"><%=MoTaDD%>
	</textarea>
	</td>
</tr>
<tr>
	<td height="23">
	<font color="#000080">
	<b>Tr&#7841;ng thái m&#7863;t hàng</b></font></td>
	<td height="23">
	<select name="TrangThaiMH">
	<option value="1" <%=SELECTED("1", TrangThaiKH)%>>Mat hang con san xuat
	<option value="0" <%=SELECTED("0", TrangThaiKH)%>>Mat hang khong con san xuat
	</select>
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
<input name="MaMH" type="hidden" value="<%=MaMH%>">
<input name="CapNhatMH" type="hidden" value="1">
</form>
<%
'Dong va khu tham chieu doi tuong database
RS.Close
Set RS=Nothing
%>
<Script language=vbscript>
Sub KiemTra_OnClick()
	If Len(xulyCN.TenMH.value)=0 Then
		Alert "Ban phai nhap vao ten mat hang"
		xulyCN.TenMH.focus
		Exit Sub
	ElseIf Len(xuLyCN.DonGia.value)=0 Then
		Alert "Ban phai nhap vao kich thuoc mat hang"
		xulyCN.DonGia.focus
		Exit Sub
	ElseIf Not isNumeric(xulyCN.DonGia.value) Then
		Alert "Ban phai nhap lai don gia mat hang"
		xulyCN.DonGia.value=""
		xulyCN.DonGia.focus
		Exit Sub
	Else  
		If Len(xulyCN.FileAnhMH.value)=0 Then
			FileAnhMH="?????"
		End if
		If Len(xulyCN.MoTaN.value)=0  Then
			MoTaN="?????"
		End If
		If Len(xulyCN.MoTaDD.value)=0 Then
			MoTaDD="?????"
		End If
	End If
	Call xulyCN.Submit()
End Sub
</Script>
</BODY>
</HTML>