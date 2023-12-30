<%
 user=request("UsernameQT")
 pass=request("PasswordQT")

 Set Con = Server.CreateObject("ADODB.Connection")
 Con.Open "storeDSN"
 sqlString="select * from QUANTRI where UsernameQT='" & user & "' and PasswordQT='" & pass & "'"
 set RS=Con.Execute(sqlString)
 If RS.EOF Then
 	'Dang nhap lai
    response.redirect("DangNhap.asp")
 Else
	' Dang nhap thanh cong 
 	Session("DangnhapQT")=true
 End if 
 RS.Close
 Con.Close
%>

<html>

<head>
<title>Qu&#7843;n lý c&#7917;a hàng TÀI TRÍ</title>
</head>

<body bgcolor="#E0EAB9">
	 	<!--#include file="TieuDeQL.asp"-->
  <center>
  <table border="0" width="668" cellspacing="0" cellpadding="0" height="26">
  <tr>
      <td width="668">
      <p align="center"><font color="#0000FF"><b>
      <font size="6" face="Times New Roman" >Ch&#7913;c n&#259;ng h&#7893; tr&#7907; cho ng&#432;&#7901;i qu&#7843;n tr&#7883; </font>
  </tr>
  </table>
  <table border="0" width="439" cellspacing="0" cellpadding="0" height="26">
  <tr>
  	<td width="439">
  	<p style="margin-top: 0; margin-bottom: 0">&nbsp;</p>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font fcolor="#000080" color="#000080" face="Times New Roman">+ &#272;&#259;ng nh&#7853;p vào h&#7879; th&#7889;ng &#273;&#7875; qu&#7843;n lý c&#7917;a hàng.</font></b></p>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font  color="#000080" face="Times New Roman">+ &#272;&#7893;i Password &#273;&#259;ng nh&#7853;p.</font></b></p>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font color="#000080" face="Times New Roman">+ Li&#7879;t kê :</font></b></p>
    <ul>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font color="#000080" face="Times New Roman">M&#7863;t hàng.</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font  color="#000080" face="Times New Roman">Lo&#7841;i m&#7863;t hàng.</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font color="#000080" face="Times New Roman">&#272;&#417;n &#273;&#7863;t hàng.</font></li>
    </ul>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font  color="#000080" face="Times New Roman">+ B&#7893; sung :</font></b></p>
    <ul>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font color="#000080" face="Times New Roman">M&#7863;t hàng</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font color="#000080" face="Times New Roman">Lo&#7841;i m&#7863;t hàng</font></li>
    </ul>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font color="#000080" face="Times New Roman">+ C&#7853;p nh&#7853;t</font></b></p>
    <ul>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font  color="#000080" face="Times New Roman">M&#7863;t hàng.</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font  color="#000080" face="Times New Roman">Lo&#7841;i m&#7863;t hàng</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font  color="#000080" face="Times New Roman">&#272;&#417;n &#273;&#7863;t hàng.</font></li>
    </ul>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font color="#000080" face="Times New Roman">+ Xoá :</font></b></p>
    <ul>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font  color="#000080" face="Times New Roman">M&#7863;t hàng.</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font color="#000080" face="Times New Roman">Lo&#7841;i m&#7863;t hàng.</font></li>
      <li>
      <p style="margin-top: 0; margin-bottom: 0">
      <font  color="#000080" face="Times New Roman">&#272;&#417;n &#273;&#7863;t hàng.</font></li>
    </ul>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font  color="#000080" face="Times New Roman">+ L&#7885;c &#273;&#417;n &#273;&#7863;t hàng.</font></b></p>
    <p style="margin-top: 0; margin-bottom: 0"><b>
    <font color="#000080" face="Times New Roman">+ Thành l&#7853;p hoá &#273;&#417;n giao hàng.</font></b></td>
  </tr>
  </table>
  </center>
</body>
</html>