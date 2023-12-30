<%
if Session("DangNhap")<>true then
	'Quay lai dang nhap
	Response.Redirect("DangNhap.asp")
end if
%>