<html>

<head>
<title>Truy cap</title>
</head>

<body background="FileAnhHoTroWeb\bg1.jpg" onload=Dangnhap.UsernameQT.focus()>
	<tr>
		<td>
	    <b><font color="#CC0066">
    	<a target="_parent" href="TrangChu.ASP"><font color="#FF0000">Tr&#7903; v&#7873; trang ch&#7911;
	    </td>
		<td colspan=2>
			</font></a></font></b>
			<hr width="100%">
		</td>
	</tr>

<table border="0" width="679" height="55">
    <tr>
       <td width="673" height="51">
       <p align="center"><font color="#0000FF"><b>
       <font size="7" >&#272;&#259;ng nh&#7853;p </font></b></font></p>
       </td>
    </tr>
  </table>
    <p align="center">
  <img border="0" src="FileAnhHoTroWeb/DuongPhanCach.gif" width="575" height="10">
    </p>
<form name="DangNhap" action="QuanLyCH.asp" method="post">
  <table border="0" width="505" height="1">
    <tr>
	   <td width="166" align="left">
	   <b><font color="#CC0066">Ch&#7881; cho phép nh&#7919;ng ng&#432;&#7901;i qu&#7843;n tr&#7883; c&#7917;a hàng &#273;&#259;ng nh&#7853;p vào trang này &#273;&#7875; qu&#7843;n lý h&#7879; th&#7889;ng c&#7917;a hàng.
	   <br> Mong các b&#7841;n thông c&#7843;m !!!</font></b></td>
       <td width="68">
       </td>	     
       <td width="103" height="1" >
      	<p align="left"><b>
      	<font color="#000080">Username</font></b></p>
        <p align="left">
      	<b>
      	<font color="#000080">
     		 Password </font></b></td>
      <td width="150" height="1">
      	<input type="text" name="UsernameQT" size="20" maxlength="20">
      	<p><input type="password" name="PasswordQT" size="20" maxlength="20">
      </td>
    </tr>
    <tr>
    	<td height="27" width="166" align="left" colspan=3>
    	</td>
    	<td width="103" height="27" >
	    <p align="center">
	    <input type="button" name="btnsubmit" value= "&#272;&#259;ng nh&#7853;p !" size="20" maxlength="20">
	    </td>
    </tr>
  </table>
</form>
<Script language="VBScript">
sub btnsubmit_onclick()
  	If (Len(DangNhap.UsernameQT.Value)=0)  Then
		alert("Ban phai nhap vao Ten truy cap")
		DangNhap.UsernameQT.focus
		exit Sub
	ElseIf (Len(DangNhap.PasswordQT.value)=0) Then
		alert("Ban phai nhap vao Password truy cap")
		DangNhap.PasswordQT.focus
		exit Sub
 	End If
	DangNhap.submit()
end sub
    </Script>
</body>

</html>