<%
	Sub addUser
		NewUsername=Trim(Request("NewUsername"))
		NewPassword=Trim(Request("NewPassword"))
		HoTenKH=Trim(Request("HoTenKH"))
		Email=Trim(Request("Email"))
		Phone=Trim(Request("Phone"))
		Duong=Trim(Request("Duong"))
		Quan=Trim(Request("Quan"))
		ThanhPho=Trim(Request("ThanhPho"))
		QuocGia=Trim(Request("QuocGia"))
		backpage=Request.ServerVariables("SCRIPT_NAME")
		If NewUsername="" Then
			errorForm "Ban phai nhap Username", backpage
		End If
		If NewPassword="" Then
			errorForm "Ban phai nhap Password", backpage
		End If
		If HoTenKH="" Then
			errorForm "Ban phai nhap ho va ten cua ban", backpage
		End If
		If Email="" Then
			errorForm "Ban phai nhap dia chi Email cua ban", backpage
		End If
		If Phone="" Then
			errorForm "Ban phai nhap so phone cua ban", backpage
		End If
		If Duong="" Then
			errorForm "Ban phai nhap dia chi duong", backpage
		End If
		If Quan="" Then
			errorForm "Ban phai nhap dia chi quan(huyen)", backpage
		End If
		If ThanhPho="" Then
			errorForm "Ban phai nhap dia chi thanh pho(Tinh)", backpage
		End If
		If QuocGia="" Then
			errorForm "Ban phai nhap ten Quoc Gia", backpage
		End If
		If KiemTraEmail(Email) Then
			errorForm "Ban khong nhap dung email", backpage
		End If
		If alreadyUser(NewUsername) Then
			errorForm "xin vui long chon mot username khac", backpage
		End If
		
		'Bo sung khach hang moi vao co so du lieu
		sqlString1="Insert Into DIACHI(HoTenKH, Duong, Quan, ThanhPho, QuocGia, Phone, Email)" &_
				"Values ('" & HoTenKH & "', '" & Duong & "', '" & Quan & "'" &_
				", '" & ThanhPho & "', '" & QuocGia & "','" & Phone & "', '" & Email & "')"
		Con.Execute sqlString1
		sqlString2="Select MaDC From DIACHI " &_
				" Where HoTenKH = '" & HoTenKH & "' And Duong='" & Duong & "'" &_
				" And Quan='" & Quan & "' And ThanhPho='" & ThanhPho & "'" &_
				" And QuocGia='" & QuocGia & "' And Phone='" & Phone & "' And Email='" & Email & "'"
		Set RS=Con.Execute (sqlString2)
		MaDC=RS("MaDC")
		sqlString3="Insert Into KHACHHANG( Username, Password, MaDC )" &_
				"Values ('" & NewUsername & "', '" & NewPassword & "', " & MaDC & ")"
		Con.Execute sqlString3
		
		Username=NewUsername
		PassWord=NewPassword
		
	End sub
	
	Function KiemTraEmail(email)
		If Instr(email,"@")=0 Or Instr(email,".")=0 or Instr(email," ")<>0 or Instr(email,"@")>Instr(email,".") or left(email,1)="." or left(email,1)="@" or isNumeric(left(email,1)) Then
			KiemTraEmail=TRUE
		else
			KiemTraEmail=FALSE
		End If
	End Function
	
	Function alreadyUser(theUsername)
		sqlString="Select Username From KHACHHANG Where Username='" & theUsername & "'"
		Set RS=Con.Execute (sqlString)
		If RS.EOF Then
			alreadyUser=False
		Else
			alreadyUser=True
		End If	
		RS.Close
	End Function
	
	Sub addCookie(theName, theValue)	
		Response.Cookies(theName)=theValue
	End Sub
	
	Sub errorForm(errorMSG, backpage)
	%>
	<html>
	<head><title>Loi</title></head>
	<!--#Include file="Header.asp"-->
	<td  background="FileAnhHoTroWeb/Brown.jpg">
	<center>
	<table width="582" boder=1 cellspacing=0 cellpadding=5 height="365">
		<tr>
			<td width="572" height="73">
			<font face="Arial" size="4" color="darkblue">
			<b>Có v&#7845;n &#273;&#7873; thông tin nh&#7853;p vào :</b>
			</font>
			<font size="3" color="red">
			<b><br><%=errorMSG%></b>
			</font>
			<br>
			<form method="post" action="<%=backpage%>">
				<input name="error" type="hidden" value="1">
				<%formFields%>
				<input type="submit" value="Quay l&#7841;i">
			</form>
			</td>
		</tr>
		<tr>
			<td height="273">
			</td>
		</tr>
	</table>
	</center>
	</td>
	<!--#Include file="Footer.asp"-->
	</body>
	</html>
	<%
	Response.End
	End Sub
	
	Sub formFields
		For each item in Request.Form
		%>
		<input name="<%=item%>" type="hidden" value="<%=Server.HTMLEncode(Request(item))%>">
		<%
		Next
	End Sub
	
	Function KiemTraPassword(theUsername, thePassword, theCon)
		sqlString="Select MaKH From KHACHHANG " &_
				" Where Username='" & theUsername & "' And Password='" & thePassword & "'"
		Set RS=theCon.Execute (sqlString)
		If RS.EOF then
			KiemTraPassword=-1
		Else
			KiemTraPassword=RS("MaKH")
			addCookie "Username", Username
			addCookie "Password", Password
		End If
	End Function
%>
<%
Function showOrderStatus(theStatus)
	Select Case theStatus
	Case 0
		showOrderStatus="Chua giao hang"
	Case 1
		showOrderStatus="Dang giao hang"
	Case 2
		showOrderStatus="Da giao hang va thanh toan" 
	Case 3
		showOrderStatus="Khong xu ly" 
	End Select
End Function
%>
<%
Sub UpdateUser
	MaKH=Trim(Request("MaKH"))
	MaDC=Trim(Request("MaDC"))
	HoTenKH=Trim(Request("HoTenKH"))
	Duong=Trim(Request("Duong"))
	Quan=Trim(Request("Quan"))
	ThanhPho=Trim(Request("ThanhPho"))
	QuocGia=Trim(Request("QuocGia"))
	Phone=TRIM(Request("Phone"))
	Email=TRIM(Request("Email"))
	backpage=Request.ServerVariables("SCRIPT_NAME")
	If KiemTraEmail(Email) Then
			errorForm "Ban khong nhap dung email", backpage
	End If
	If MaKH>0 or MaKH<>"" then
	'Cap nhat thong tin
		sqlstring="Update DIACHI SET" &_
			"HoTenKH='" & HoTenKH & "', Duong='" & Duong & "', " &_
			"Quan='" & Quan & "', ThanhPho='" & ThanhPho & "',  " &_
			"QuocGia='" & QuocGia & "' Phone='" & Phone & "'" &_
			"Email='" & Email & "'" &_
			"Where MaDC=" & MaDC
		Con.Execute sqlString
	Else
		If alreadyUser(NewUsername) Then
			errorForm "xin vui long chon mot username khac", backpage
		End If
		'Bo sung khach hang moi vao co so du lieu
		sqlString1="Insert Into DIACHI(HoTenKH, Duong, Quan, ThanhPho, QuocGia, Phone, Email)" &_
				"Values ('" & HoTenKH & "', '" & Duong & "', '" & Quan & "'" &_
				", '" & ThanhPho & "', '" & QuocGia & "','" & Phone & "', '" & Email & "')"
		Con.Execute sqlString1
		sqlString2="Select MaDC From DIACHI " &_
				" Where HoTenKH = '" & HoTenKH & "' And Duong='" & Duong & "'" &_
				" And Quan='" & Quan & "' And ThanhPho='" & ThanhPho & "'" &_
				" And QuocGia='" & QuocGia & "' And Phone='" & Phone & "' And Email='" & Email & "'"
		Set RS=Con.Execute (sqlString2)
		MaDC=RS("MaDC")
		sqlString3="Insert Into KHACHHANG( Username, Password, MaDC )" &_
				"Values ('" & NewUsername & "', '" & NewPassword & "', " & MaDC & ")"
		Con.Execute sqlString3
	End if
	
End Sub
%>