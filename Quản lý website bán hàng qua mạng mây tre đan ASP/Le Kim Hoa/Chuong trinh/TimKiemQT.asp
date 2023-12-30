<!-- #Include File="adovbs.inc"-->
<%

MHTimKiem=Trim(request("MHTimKiem"))

Set con=server.CreateObject("ADODB.Connection")
con.Open "storeDSN"
'Set RS=Server.CreateObject("ADODB.Recordset")

sqlString="Select MaMH, TenMH, DonGia From MATHANG " &_
		"Where  TenMH Like '% " & TimKiem & " %' Or MoTaN Like '% " & TimKiem & " %' " 
Set RS=con.Execute(sqlString)
%>

<html>
<head>
<title>Tim Kiem Mat Hang</title>
</head>

<body background="FileAnhHoTroWeb\Brown.jpg">
<%If not RS.EOF And TimKiem<>"" Then%>
<table width="540" border=0 cellpadding=5 cellspacing=0 height="160">
	<p align="left">
	<font color="darkblue" size="4">
	<b>K&#7871;t qu&#7843; tìm ki&#7871;m : </b>
	</font>
<Img SRC="FileAnhHoTroWeb\L2.gif" width="100%" height="6">

<%
while Not RS.EOF
%> </p>
<tr>
	<td width="79" height="107">
	<%If RS("FileAnhMH")<>"" Then%>
    <p style="margin-top: 0; margin-bottom: 0">
	<Img SRC="FileAnhMatHang\<%=RS("FileAnhMH")%>" hspace=4 vspace=4 Border=0 align="center">
	<%End If%>
	</td>
	<td width="540" align="top" height="107">
		<form method="post" action="KiemTraKH.asp">
		<p style="margin-top: 0; margin-bottom: 0">
		<b>Ten :
		<font color="blue"><%=RS("TenMH")%></font></b>
		<br><font color="blue"><%=RS("MoTaN")%></font>
		<a href="MatHang.asp?MaMH=<%=RS("MaMH")%>"><font color="#FF00FF">chi tiet >></font></a><font color="#FF00FF">
        </font>
		<br><b>Gia :</b><font color="blue">	<%=RS("DonGia")%></font> dong
		<br><b>So luong :
		<Input type="text" value="1" name="SoLuong" size="2"></b> </p>
		<Input type="hidden" value="<%=RS("MaMH")%>" name="MaMH">
			<p style="margin-top: 0; margin-bottom: 0">
			<input type="submit" value="Chon mua" name="chon"> </p>
		</form>
	</td>
</tr>
<tr>
	<td colspan=2 align="center" width="531" height="19">
	<p style="margin-top: 0; margin-bottom: 0">&nbsp;
	</td>
<tr>
<%
RS.MoveNext
WEnd
%>
<table>
<%Else%>
<table width="353" border=0 cellpadding=5 ceellspacing=0>
<tr>
	<td width="339">
	<p style="margin-top: 0; margin-bottom: 0">
	<font face="Arial" color="#FF0000" size="4">
	<b>M&#7863;t hàng quí khách c&#7847;n tìm c&#7917;a hàng chúng tôi hi&#7879;n th&#7901;i không có. </b>
	</font>
	</p>
	<p style="margin-top: 0; margin-bottom: 0">
	<font face="Arial" color="#FF0000" size="4">
	<b>Mong quí khách thông c&#7843;m !!!</b>
	</font>
	</td>
</table>
<%End If%>
<td>
</tr>
</table>
</body>

</html>