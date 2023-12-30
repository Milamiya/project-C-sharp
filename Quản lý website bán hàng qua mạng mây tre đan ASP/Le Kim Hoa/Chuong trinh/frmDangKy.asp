<%
MaMH=TRIM(Request("pid"))
SoLuong=TRIM(Request("SoLuong"))
NewUsername=TRIM(Request("NewUsername"))
NewPassword=TRIM(Request("NewPassword"))
HoTenKH=TRIM(Request("HoTenKH"))
Duong=TRIM(Request("Duong"))
Quan=TRIM(Request("Quan"))
ThanhPho=TRIM(Request("ThanhPho"))
QuocGia=TRIM(Request("QuocGia"))
Phone=TRIM(Request("Phone"))
Email=TRIM(Request("Email"))

submitpage=Request.ServerVariables("Script_Name")
%>
<HTML xmlns:v="urn:schemas-microsoft-com:vml" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns="http://www.w3.org/TR/REC-html40">
<HEAD>

<title>&#272;&#259;ng ký</title>
</HEAD>

<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/Brown.jpg">
<table border=0 style="HEIGHT: 430; WIDTH: 594">
<tr>
<td width="244" height="364">
<form name=frmDangNhap method=post action="<%=submitpage%>">
<font face="Times New Roman">
<input name="DangNhap" type="hidden" value="1" >
<input name="pid" type="hidden" value="<%=MaMH%>">
<input name="SoLuong" type="hidden" value="<%=SoLuong%>">
</font>
<table border=1 HEIGHT= 316>
    <tr>
		<td class=tablehead align=left colspan=2 bgcolor="#008000" width="229" height="14">
        <p><font face="Times New Roman" color="#FFFF00" size="5">
        &#272;&#259;ng nh&#7853;p&nbsp; </font></td>
	</tr>
	<tr>
		<td width="70" height="31"><font face="Times New Roman" color="#000080">Username</font></td>
		<td width="153" height="31"><font face="Times New Roman">
			<input name="Username" maxlength=20 size="20" >
		</font></td>
	</tr>
	<tr>
		<td width="70" height="23"><font face="Times New Roman" color="#000080">Password</font></td>
		<td width="153" height="23"><font face="Times New Roman">
			<input type="password" name="Password" maxlength=20 size="20" >
		</font></td>
	</tr>
	<tr>
		<td colspan=2 width="70" height="1">
			<font face="Times New Roman">
			<INPUT name="btnsubmit1" type="button" value="Dang Nhap" >
            </font>
		</td>
	</tr>
	<tr>
		<td colspan=2 height="249" width="229">
		<p align="justify">
		<font face="Times New Roman">
		<i><font color="#0000FF">+ N&#7871;u b&#7841;n &#273;ã &#273;&#259;ng ký là thành viên c&#7911;a c&#7917;a hàng 
        chúng tôi r&#7891;i thì nh&#7853;p thông tin &#273;&#259;ng nh&#7853;p &#7903; bên trên.</font></i>
        <br><i>
        <font color="#0000FF">+ N&#7871;u b&#7841;n ch&#432;a t&#7915;ng &#273;&#259;ng ký v&#7899;i c&#7917;a hàng chúng tôi 
        ho&#7863;c &#273;ã &#273;&#259;ng ký r&#7891;i nh&#432;ng quên Username và Password &#273;&#259;ng nh&#7853;p thì xin 
        &#273;&#259;ng ký l&#7841;i v&#7899;i nh&#7919;ng thông tin k&#7871; bên.</font></i></font></p>
        <p align="justify"></p>
        <p align="justify">
        <font face="Times New Roman"><b><font color="#800000">Xin chân thành c&#7843;m &#417;n !!!</font></b></font></td>
	</tr>	
</table>
</form>

</td>
<td width="355" height="364">
<form name=frmDangKy method=post action="<%=submitpage%>">
<font face="Times New Roman">
<input name="DangKy" type="hidden" value="1" >
<input name="pid" type="hidden" value="<%=MaMH%>">
<input name="SoLuong" type="hidden" value="<%=SoLuong%>">
</font>
<table border=1 style="HEIGHT: 304; WIDTH: 340">
    <tr>
		<td class=tablehead align=left colspan=2 bgcolor="#008000" width="359" height="27">
        <p><font face="Times New Roman" color="#FFFF00" size="5">
        &#272;&#259;ng ký thành viên </font></td>
	</tr>
	<tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">H&#7885; và tên</font></td>
		<td width="220" height="23"><font face="Times New Roman">
			<input name="HoTenKH" size="30" maxlength="30" value="<%=Server.HTMLEncode(HoTenKH)%>">
		</font></td>
	</tr>
	<tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">Username</font></td>
		<td width="220" height="23"><font face="Times New Roman">
			<input name="NewUsername" maxlength=20 size="20" value="<%=Server.HTMLEncode(NewUsername)%>">
		</font></td>
	</tr>
	<tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">Password</font></td>
		<td width="220" height="23"><font face="Times New Roman">
			<input type="password" name="NewPassword" maxlength=20 size="20" value="<%=Server.HTMLEncode(NewPassword)%>">
		</font></td>
	</tr>
	<tr>
		<td width="136" height="38"><font face="Times New Roman" color="#000080">&#272;ánh l&#7841;i Password </font>
        </td>
		<td width="220" height="38"><font face="Times New Roman">
			<input type="password" name="DLPassword" maxlength=20 size="20">
		</font></td>
	</tr>
	<tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">&#272;i&#7879;n tho&#7841;i </font>
        </td>
		<td width="220" height="23"><font face="Times New Roman">
			<input name="Phone" maxlength=10 size="10" value="<%=Server.HTMLEncode(Phone)%>">
        </font></td>
	</tr>
    <tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">Email</font></td>
		<td width="220" height="23"><font face="Times New Roman">
			<input name="Email" maxlength=50 size="30" value="<%=Server.HTMLEncode(Email)%>">
        </font></td>
	</tr>
    <tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">&#272;&#432;&#7901;ng</font></td>
        <td width="220" height="23"><font face="Times New Roman">
        	<input name="Duong" maxlength=50 size="30" value="<%=Server.HTMLEncode(Duong)%>">
        </font></td>
	</tr>
    <tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">Qu&#7853;n (Huy&#7879;n) </font>
        </td>
		<td width="220" height="23"><font face="Times New Roman">
			<input name="Quan" maxlength=20 size="20" value="<%=Server.HTMLEncode(Quan)%>">
        </font></td>
	</tr>
    <tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">Thành Ph&#7889; (T&#7881;nh)</font></td>
        <td width="220" height="23"><font face="Times New Roman">
        	<input name="ThanhPho" maxlength=20 size="20" value="<%=Server.HTMLEncode(ThanhPho)%>">
        </font></td>
	</tr>
	<tr>
		<td width="136" height="23"><font face="Times New Roman" color="#000080">Qu&#7889;c gia</font></td>
        <td width="220" height="23"><font face="Times New Roman">
        	<input name="QuocGia" maxlength=20 size="20" value="<%=Server.HTMLEncode(QuocGia)%>">
        </font></td>
	</tr>
	<tr>
		<td width="136" height="1">
			<font face="Times New Roman">
			<INPUT name="btnsubmit" type="button" value="Dang ky !" ></font></td>
		<td width="220" height="1">
			<font face="Times New Roman">
			<INPUT name=reset type=reset value=" Reset" style="float: left"></font></td>
	</tr>	
</table>
</form>
</td>
</tr>
<tr>
<td =20 height="78">
</td>
</tr>
</table>
</td>
<!--#Include file="Footer.asp"-->
</BODY>
</HTML>
<Script language=vbscript>
Sub btnSubmit1_Onclick()
	If Len(frmDangNhap.username.value)=0 Then
		Alert "Ban phai nhap vao username cua ban"
		frmDangNhap.username.focus
		Exit Sub
	ElseIf Len(frmDangNhap.Password.value)=0 Then
		Alert "Ban phai nhap vao Password cua ban"
		frmDangNhap.Password.focus
		Exit Sub
	End if
	Call frmDangNhap.Submit()
End Sub
Sub btnSubmit_Onclick()
	IF Len(frmDangKy.HoTenKH.value)=0 Then
		Alert "Ban phai nhap vao ho va ten cua ban"
		frmDangKy.HoTenKH.focus
		Exit Sub
	ElseIf Len(frmDangKy.NewUsername.value)=0 Then
		Alert "Ban phai nhap vao username cua ban"
		frmDangKy.NewUsername.focus
		Exit Sub
	ElseIf Len(frmDangKy.NewPassword.value)=0 Then
		Alert "Ban phai nhap vao Password cua ban"
		frmDangKy.NewPassword.focus
		Exit Sub
	ElseIf frmDangKy.DLPassword.value<>frmDangKy.NewPassword.value Then
		Alert "Ban phai nhap vao 'Password danh lai' sao cho trung voi 'Password' cua ban"
		frmDangKy.DLPassword.value=""
		frmDangKy.DLPassword.focus
    	Exit Sub
	ElseIf Len(frmDangKy.Phone.value)=0 Then
		Alert "Ban phai nhap vao so Phone cua ban"
		frmDangKy.Phone.focus
		Exit Sub
	ElseIf Not isNumeric(frmDangKy.Phone.value) Then
		Alert "Ban phai nhap lai so Phone cua ban"
		frmDangKy.Phone.value=""
		frmDangKy.Phone.focus
		Exit Sub
	ElseIf Len(frmDangKy.Phone.value)<9 Then
		Alert "Ban phai nhap lai so Phone cua ban tren 9 so"
		frmDangKy.Phone.value=""
		frmDangKy.Phone.focus
		Exit Sub
	ElseIf Len(frmDangKy.Email.value)=0 Then
		Alert "Ban phai nhap vao Email cua ban"
		frmDangKy.Email.focus
		Exit Sub
	ElseIf Len(frmDangKy.Duong.value)=0 Then
		Alert "Ban phai nhap vao so nha va ten duong cua ban"
		frmDangKy.Duong.focus
		Exit Sub
	ElseIf Len(frmDangKy.Quan.value)=0 Then
		Alert "Ban phai nhap vao Quan(Huyen) cua ban"
		frmDangKy.Quan.focus
		Exit Sub
	ElseIf Len(frmDangKy.ThanhPho.value)=0 Then
		Alert "Ban phai nhap vao Thanh Pho(Tinh) cua ban"
		frmDangKy.ThanhPho.focus
		Exit Sub
	ElseIf Len(frmDangKy.QuocGia.value)=0 Then
		Alert "Ban phai nhap vao Quoc Gia cua ban"
		frmDangKy.QuocGia.focus
		Exit Sub
	End if
	Call frmDangKy.Submit()
End Sub
</script>