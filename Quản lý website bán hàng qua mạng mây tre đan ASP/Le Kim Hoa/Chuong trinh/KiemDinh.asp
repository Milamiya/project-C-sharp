<%
Username=TRIM(Request("Username"))
Password=TRIM(Request("Password"))
MaKH=TRIM(Request("MaKH"))
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
sqlString="Select MaDC From KHACHHANG Where MaKH= " & MaKH & " "
Set RS=Con.Execute (sqlString)
If Not RS.EOF Then
	sqlString="Select * From DIACHI Where MaDC=" & RS("MaDC")
	Set RS1=Con.Execute (sqlString)
	If Not RS1.EOF Then
		HoTenKH=RS1("HoTenKH")
		Duong=RS1("Duong")
		Quan=RS1("Quan")
		ThanhPho=RS1("ThanhPho")
		QuocGia=RS1("QuocGia")
		Phone=RS1("Phone")
		Email=RS1("Email")
	End If
End If
%>
<html>
<head>
<title>Kiem Tra thong tin khach hang</title>
</head>
<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/BlowBlueSand.jpg">
<center>
<table border="0" cellPadding="4" cellSpacing="2" width="599" height="470">
<tr>
	<td colspan="2" bgColor="lightgreen" width="587" height="26">
        <p align="center"><b>
        <font color="#800000" size="5" face="Times New Roman">
        Nh&#7853;p vào thông tin &#273;&#7883;a ch&#7881; giao hàng</font></b></td>
</tr>
<tr>
<form method="post" action="DonDatHang.asp" name="frmKiemDinh">
<td width="175" height="304">
	<font face="Times New Roman">
	<input name="Chon" Type="Radio" value="" checked onclick="DiaChiCu()">
    </font><font face="Times New Roman" color="#800000">&#272;&#7883;a ch&#7881; giao hàng trùng 
    v&#7899;i &#273;&#7883;a ch&#7881; thông tin khách hàng &#273;ã &#273;&#259;ng ký, 
    thì ch&#7885;n &quot;&#272;&#7891;ng ý !&quot;
    <br><input name="Chon" Type="Radio" value="1" onclick="DiaChiKhac()"> &#272;&#7883;a ch&#7881; giao hàng khác v&#7899;i &#273;&#7883;a ch&#7881; thông tin khách hàng &#273;ã &#273;&#259;ng ký 
    thì&nbsp; nh&#7853;p thông tin &#273;&#7883;a ch&#7881; giao hàng r&#7891;i click &quot;&#272;&#7891;ng ý !&quot;
    <br>&nbsp;</font></td>
<td width="402" height="304">
	<font face="Times New Roman">
	<input type="hidden" name="Username" value="<%=Username%>">
    <input type="hidden" name="Password" value="<%=Password%>">
    </font>
    <table border="1" cellPadding="4" cellSpacing="2" width="375">
        <tr>
        <td width="130"><font color="#000080" face="Times New Roman">H&#7885; Tên khách hàng</font></td></font>
        <td width="220">
            <font face="Times New Roman">
            <input type="text" name="HoTenKH" value="<%=Server.HTMLEncode(HoTenKH)%>" size="30"></font></td></tr>
     	 <tr>
        <td width="130"><font face="Times New Roman" color="#000080">&#272;&#432;&#7901;ng</font></td></font>
        <td width="220">
            <font face="Times New Roman">
            <input type="text" name="Duong" value="<%=Server.HTMLEncode(Duong)%>" size="20"></font></td></tr>
	    <tr>
        <td width="130"><font face="Times New Roman" color="#000080">Qu&#7853;n (Huy&#7879;n)</font></td>
        <td width="220">
            <font face="Times New Roman">
            <input type="text" name="Quan" value="<%=Server.HTMLEncode(Quan)%>" size="20"></font></td> </tr>
	    <tr>
        <td width="130"><font face="Times New Roman" color="#000080">Thành ph&#7889; (T&#7881;nh)</font></td></font>
        <td width="220">
            <font face="Times New Roman">
            <input type="text" name="ThanhPho" value="<%=Server.HTMLEncode(ThanhPho)%>" size="20"></font></td></tr>
        <tr>
   		<td width="130"><font face="Times New Roman" color="#000080">Qu&#7889;c gia</font></td>
        <td width="220">
            <font face="Times New Roman">
            <input name="QuocGia" value="<%=Server.HTMLEncode(QuocGia)%>" size="20"></font></td>
        </tr>
        <tr>
   		<td width="130"><font face="Times New Roman" color="#000080">&#272;i&#7879;n tho&#7841;i</font></td>
        <td width="220">
            <font face="Times New Roman">
            <input name="Phone" value="<%=Server.HTMLEncode(Phone)%>" size="10"></font></td>
        </tr>
        <tr>
   		<td width="130"><font color="#000080" face="Times New Roman">Email</font></td>
        <td width="220">
            <font face="Times New Roman">
            <input name="Email" value="<%=Server.HTMLEncode(Email)%>" size="30"></font></td>
    	</tr>
        <tr>
   		<td width="130"><font color="#000080" face="Times New Roman">Ngày giao hàng</font></td></font>
        <td width="220">
        	<font face="Times New Roman">
        	<select name="Ngay">
        	<%for i=1 to 31%>
        	<%
        		if i<10 then
	        		
    	 		%>	
        			
        			
        			<option value="<%="0" & i%>" ><%= "0" & i%>
					<%
				else%>
					<option value="<%= i%>" ><%=i%>
				<%
				end if
			next%>
			</Select>
			<select name="Thang">
        	<%for j=1 to 12%>
        	<%  
        		if j<10 then
        		%>	
        			<option value="<%= "0" & j%>" selected><%="0" & j%>
        		<%	
				else%>
					<option value="<%=j%>" ><%= j%>
				<%End if
			next%>
			</Select>
			<select name="Nam">
        	<%for k=2003 to 2010%>
        	<%
        		if k=2003 then
        		%>	
        			<option value="<%=k%>" selected><%=k%>
        		<%else%>
        			<option value="<%=k%>" ><%=k%>
				<%End if
			next%>
			</Select> </font>
        </td>
    	</tr>
    </table>
  	<font face="Times New Roman">
  	<input type="hidden" name="MaDC" value="<%=RS("MaDC")%>">
  	<input type="hidden" name="pid" value="<%=MaKH%>">
    <input type="hidden" name="DongY" value="1">
	</font><font face="Times New Roman">
	<input name="btnsubmit" type="button" value="Dong y !"> </font>
	</td>
</form>
</tr>
<tr>
<td border=0 height="105" width="175">
</td>
</tr>
</table>
</center>
</td>
<!--#Include file="Footer.asp"-->
</body>
</html>
<Script language=vbscript>
Sub DiaChiKhac()
	frmKiemDinh.HoTenKH.value="" 
	frmKiemDinh.HoTenKH.focus
	frmKiemDinh.Duong.value="" 
	frmKiemDinh.Quan.value="" 
	frmKiemDinh.ThanhPho.value="" 
	frmKiemDinh.QuocGia.value="" 
	frmKiemDinh.Phone.value="" 
	frmKiemDinh.Email.value="" 
end sub

Sub btnSubmit_Onclick()
	IF Len(frmKiemDinh.HoTenKH.value)=0 Then
		Alert "Ban phai nhap vao ho va ten cua ban"
		frmKiemDinh.HoTenKH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.Duong.value)=0 Then
		Alert "Ban phai nhap vao so nha va ten duong cua ban"
		frmKiemDinh.Duong.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.Quan.value)=0 Then
		Alert "Ban phai nhap vao Quan(Huyen) cua ban"
		frmKiemDinh.Quan.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.ThanhPho.value)=0 Then
		Alert "Ban phai nhap vao Thanh Pho(Tinh) cua ban"
		frmKiemDinh.ThanhPho.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.QuocGia.value)=0 Then
		Alert "Ban phai nhap vao Quoc Gia cua ban"
		frmKiemDinh.QuocGia.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.Phone.value)=0 Then
		Alert "Ban phai nhap vao so Phone cua ban"
		frmKiemDinh.Phone.focus
		Exit Sub
	ElseIf Not isNumeric(frmKiemDinh.Phone.value) Then
		Alert "Ban phai nhap lai so Phone cua ban"
		frmKiemDinh.Phone.value=""
		frmKiemDinh.Phone.focus
		Exit Sub
	ElseIf Len(frmkiemdinh.Phone.value)<9 Then
		Alert "Ban phai nhap lai so Phone cua ban tren 9 so"
		frmKiemDinh.Phone.value=""
		frmKiemDinh.Phone.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.Email.value)=0 Then
		Alert "Ban phai nhap vao Email cua ban"
		frmKiemDinh.Email.focus
		Exit Sub
	End if
	Call frmKiemDinh.Submit()
End Sub
</script>