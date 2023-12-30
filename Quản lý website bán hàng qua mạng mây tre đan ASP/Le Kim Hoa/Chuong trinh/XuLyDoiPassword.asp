<html>
<head>
<title>Thay &#273;&#7893;i Password</title>
</head>

<body background="FileAnhHoTroWeb\bg1.jpg" > 

<%
  user = request("txtUsername")
  pass = request("txtPassword")
  NewPassword = request("txtNewPassword")
 
  Set Con = Server.CreateObject("ADODB.Connection")
  Con.Open "storeDSN"
  sqlString="select * from QUANTRI where UsernameQT='" & user &"' and PasswordQT='" & pass & "'"
  set RS= Con.Execute(sqlString)
  
  if Not RS.EOF then
  	sqlString ="UPDATE QUANTRI SET PasswordQT='" & NewPassword & "'"	
	sqlString=sqlString & "where usernameQT ='" & user & "' and PasswordQT='" & pass & "'"
    Con.Execute(sqlString)
  %>
<p align="center"><b><font  size="7" color="#0000FF">Chúc m&#7915;ng !!!</font></b></p>
<p align="center"><font size="5">B&#7841;n &#273;ã &#273;&#7893;i Password thành công !
<%  	
  else
  %> </font></p>
<p align="center"><b><font size="7" color="#0000FF">Xin l&#7895;i !!!</font></b></p>
  <p align="center" style="margin-top: 0; margin-bottom: 0"><font  size="5">Không th&#7875; &#273;&#7893;i Password vì b&#7841;n nh&#7853;p</font></p>
  <p align="center" style="margin-top: 0; margin-bottom: 0"><font size="5">
  Username ho&#7863;c Password không &#273;úng!</font></p>
  <%  	
  end if
  RS.Close
  Con.Close  	
%> 
<p align="center"><font color="#FF0000">
<a target="_parent" href="TrangChu.ASP"><font color="#FF0000">V&#7873; trang ch&#7911;</font></a>
| <font color="#FF0000"><a target="_parent" href="DoiPassword.asp">
<font color="#FF0000">Ti&#7871;p t&#7909;c &#273;&#7893;i Password</font></a></font></font></p>
</body>
</html>