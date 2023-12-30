<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 5.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252">
<title>Tên truy c&#7853;p</title>
<base target="trai">
</head>

<body>
<form name="DangNhap" action="KiemTra.asp" method="post">
  <input type=hidden name= FormAction value=Buoc2>	
  <table border="0" width="231" height="1">
    <tr>
       <td width="59" height="1" >
      	<font face="Arial" color="#000080" size="2">
      		Tên truy c&#7853;p
      	</font><p>
      	<font face="Arial" color="#000080" size="2">
     		 Password </font></td>
      <td width="162" height="1">
      	<input type="text" name="txtTenTC" size="20" maxlength="20">
      	<p><input type="password" name="txtPassword" size="20" maxlength="20">
      </td>
    </tr>
    <tr>
    	<td height="27" width="59">
    	</td>
    	<td width="162" height="27">
	    <input type="button" onclick="on_submit()" value="Truy C&#7853;p"> 
	    </td>
    </tr>
  </table>
</form>
<Script language="VBScript">
sub on_submit()
	If (Len(DangNhap.txtTenTC.Value)=0)  Then
		alert("Ban phai nhap vao Ten truy cap")
		DangNhap.txtTenTC.focus
		exit Sub
	ElseIf (Len(DangNhap.txtPassword.value)=0) Then
		alert("Ban phai nhap vao Password truy cap")
		DangNhap.txtPassword.focus
		exit Sub
 	End If
	DangNhap.submit()
end sub
</Script>
</body>

</html>