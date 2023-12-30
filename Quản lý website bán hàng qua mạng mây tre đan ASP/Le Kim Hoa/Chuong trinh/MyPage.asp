<%
 'MaKH=TRIM(Request("MaKH"))
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
submitpage=Request.ServerVariables("Script_Name")
%>
<html>
<head>
<title>Kiem Tra thong tin khach hang</title>
</head>
<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/Brown.jpg">
<center>
<form method="post" action="<%=submitpage%>" name="frmkiemdinh">
    <table border="1" cellPadding="4" cellSpacing="2" width="584">
       <tr>
        <td colspan="2" bgColor="lightgreen" width="512">
        <p align="center"><strong>
        <span >
        <font  color="#800000" size="5">Thông tin khách hàng</font></span></strong></td>
        </tr>
        <tr>
        <td width="227"><font color="#000080">Username</font></td>
        <td width="329">
            <input type="text" name="Username" value="<%=Username%>" size="20"></td>
       </tr>
       <tr>
        <td width="227"><font  color="#000080">Password</font></td>
        <td width="329">
            <input  name="Password" value="<%=Password%>" size="20"></td>
       </tr>
        <tr>
        <td width="227"><font color="#000080">H&#7885; tên khách hàng</font></td></font>
        <td width="329">
            <input type="text" name="HoTenKH" value="<%=HoTenKH%>" size="30"></td></tr>
    	 <tr>
        <td width="227"><font color="#000080">&#272;&#432;&#7901;ng</font></td></font>
        <td width="329">
            <input type="text" name="Duong" value="<%=Duong%>" style="HEIGHT: 22px; WIDTH: 265px" size="20"></td></tr>
	    <tr>
        <td width="227"><font color="#000080">Qu&#7853;n (Huy&#7879;n)</font></td>
        <td width="329">
            <input type="text" name="Quan" value="<%=Quan%>" size="20"></td>
       </tr>
	    <tr>
        <td width="227"><font color="#000080">Thành ph&#7889; (T&#7881;nh)</font></td></font>
        <td width="329">
            <input type="text" name="ThanhPho" value="<%=ThanhPho%>" size="20"></td></tr>
   		<tr>
   		<td width="227"><font color="#000080">Qu&#7889;c gia</font></td>
        <td width="329">
            <input name="QuocGia" value="<%=QuocGia%>"style="HEIGHT: 22px; WIDTH: 135px" size="20"></td>
       </tr>
   		<td width="227"><font color="#000080">&#272;i&#7879;n tho&#7841;i</font></td></font>
        <td width="329">
            <input name="Phone" value="<%=Phone%>" size="10"></td></tr>
   		<tr>
   		<td width="227"><font  color="#000080">Email</font></td>
        <td width="329">
            <input name="Email" value="<%=Email%>"style="HEIGHT: 22px; WIDTH: 135px" size="20"></td>
       </tr>
    	<tr>
        	</font>
        </tr>
     	<tr>
        	</font>
        </tr>
    	<tr>
	        </font>
    	    </tr>
    	</table>
  	<input type="hidden" name="MaDC" value="<%=RS("MaDC")%>">
  	<input type="hidden" name="MaKH" value="<%=MaKH%>">
    <input type="hidden" name="CapNhatKH" value="1">
	<p><input name="btnsubmit" type="button" value="C&#7853;p nh&#7853;t">&nbsp;
	</form>
</center>
</td>
<!--#Include file="Footer.asp"-->
</body>
</html>
<Script language=vbscript>
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