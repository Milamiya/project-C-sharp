<%
 If Session("DangNhapQT")<>True Then
 	'Dang nhap lai
    response.redirect("DangNhap.asp")
 End if 
%>