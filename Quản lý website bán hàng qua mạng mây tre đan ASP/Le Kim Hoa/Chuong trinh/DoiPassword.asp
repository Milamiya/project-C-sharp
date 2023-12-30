<html>
<head>
<title>Thay &#273;&#7893;i Password</title>
</head>

<body background="FileAnhHoTroWeb\bg1.jpg" onload=frmDoiP.txtUsername.focus()> 
<tr>
		<td>
	    <b>
    	<font color="#FF0000"><a target="_parent" href="TrangChu.asp">Tr&#7903; v&#7873; 
trang ch&#7911;</a></font><a target="_parent" href="TrangChu.ASP"><font color="#FF0000"><hr width="700">
		</td>
	</tr>

<table border="0" width="679" height="55">
    <tr>
       <td width="673" height="51">
       <p align="center"><b><font size="7" color="#0000FF">
       &#272;&#7893;i Password &#273;&#259;ng nh&#7853;p</font></b></p>
       </td>
    </tr>
  </table>
    <p align="center">
  <img border="0" src="FileAnhHoTroWeb/DuongPhanCach.gif" width="575" height="10">
    </p>

  <form name="frmDoiP" action="XuLyDoiPassword.asp" method="post">
    <table border="0" width="505" height="212">
    <tr>
      <td width="106" height="149"></td>
      <td width="192" height="149">
    	  <font  size="4" color="#000080">Username </font><p>
     	 <font  size="4" color="#000080">Password c&#361;</font></p>
      	 <p><font  size="4" color="#000080">Password m&#7899;i</font></p>
     	 <p><font  size="4" color="#000080">Nh&#7853;p l&#7841;i Password m&#7899;i</font>
      </td>
      <td width="193" height="149"><input type="text" name="txtUsername" size="20"
      MaxLength="10"> <p><input type="password" name="txtPassword" size="20" MaxLength="10"></p>
      <p><input type="password" name="txtNewPassword" size="20" MaxLength="10"></p>
      <p><input type="password" name="txtReNewPassword" size="20" MaxLength="10"></td>
    </tr>
    <tr>
    	<td width="106" height="55">
    	</td>
    	<td width="192" height="55">
    	 <input type="button" name="btnsubmit" value= "&#272;&#7891;ng ý !" size="20" maxlength="20">
   	</td>
    </tr>
  </table>
</form>
</body>
<script language="VBScript">
sub btnsubmit_Onclick()
	if (frmDoiP.txtUsername.value="")then
		alert("Ban phai nhap Ten truy cap")
		frmDoiP.txtUsername.focus()
		exit Sub
	elseif (frmDoiP.txtPassword.value="") then
		alert("Ban phai nhap Password cu")
		frmDoiP.txtPassword.focus()
		exit Sub
    elseif (frmDoiP.txtNewPassword.value="") then
        alert("Ban phai nhap Password moi")
		frmDoiP.txtNewPassword.focus()
		exit Sub
	elseif (frmDoiP.txtReNewPassword.value="") then
		alert("Ban phai nhap lai Password sao cho trung voi Password moi")
		frmDoiP.txtReNewPassword.focus()
		exit Sub
    elseif (frmDoiP.txtNewPassword.value <> frmDoiP.txtReNewPassword.value) then
		alert ("Ban phai nhap lai Password moi")
		frmDoiP.txtNewPassword.value=""
        frmDoiP.txtReNewPassword.value=""
		frmDoiP.txtNewPassword.focus()
		exit Sub
	end if
	frmDoiP.submit()
end sub
  </script>

</html>