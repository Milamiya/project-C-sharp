<%
submitpage=Request.ServerVariables("Script_Name")
%>

<html>
<head>
<title>Dang nhap</title>
</head>
<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/bg1.jpg">
<table border="0" width="552" height="27">
    <tr>
       <td width="611" height="23">
       <p align="center"><font color="#0000FF"><b>
       <font size="6" face="Times New Roman" >&#272;&#259;ng nh&#7853;p </font></b></font></p>
       </td>
    </tr>
    <tr>
    	<td width="611">
	    <img border="0" src="FileAnhHoTroWeb/DuongPhanCach.gif" width="591" height="4">
	    </td>
	<tr>
  <form name="DangNhap" action="<%=submitpage%>" method="post">
  <input type="hidden" name="DangNhap1" value="1">
  <table border="0" width="598" height="312">
    <tr>
	    <td width="150" height="65" >
      	<p align="left"><b>
      	<font  color="#000080">Username</font></b></p>
        <p align="left">
      	<b>
      	<font color="#000080">
     		 Password </font></b></td>
      <td width="438" height="65">
      	<input type="text" name="Username" size="20" maxlength="20">
      	<p><input type="password" name="Password" size="20" maxlength="20">
      </td>
    </tr>
    <tr>
    	<td height="45" width="150" align="left">
    	<input type="button" name="btnsubmit" value= "Dang nhap !" size="20" maxlength="20" style="float: left">
    	</td>
    </tr>
    <tr>
    <td height="191" width="150">
    </td>
    </tr>
  </table>
</form>
</table>
</td>
<!--#Include file="Footer.asp"-->

</body>

</html>
<Script language="VBScript">
sub btnsubmit_onclick()
  	If (Len(DangNhap.Username.Value)=0)  Then
		alert("Ban phai nhap vao Ten truy cap")
		DangNhap.Username.focus
		exit Sub
	ElseIf (Len(DangNhap.Password.value)=0) Then
		alert("Ban phai nhap vao Password truy cap")
		DangNhap.Password.focus
		exit Sub
 	End If
	DangNhap.submit()
end sub
</Script>