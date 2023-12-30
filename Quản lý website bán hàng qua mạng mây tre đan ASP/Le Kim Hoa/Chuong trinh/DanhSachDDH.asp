<%
sqlString="select * From DONDATHANG Where MaKH=" & MaKH 
Set RS=Con.Execute (sqlString)
sqlString="select Username From KHachHang Where MaKH=" & MaKH 
Set RS1=Con.Execute (sqlString)
%>

<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 5.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252">
<title>KHACH HANG</title>
</head>
<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/BlowBlueSand.jpg">
<center>
<table width="592" height="377">
<tr>
<td width="595" height="176">
<%
If RS.EOF Then
%>
<p align="center">
<b><font size="5" color="LightRed"><%=RS1("Username")%></font><font size="5" color="#000080"> ch&#432;a có &#273;&#417;n &#273;&#7863;t hàng 
nào c&#7843;</font></b></p>
<%
Else
%> 
<p align="center"><font color="#000080" size="5"><b>Danh sách &#273;&#417;n &#273;&#7863;t hàng c&#7911;a</font><font size="5" color="LightRed"><%=RS1("Username")%></font></b></font>&nbsp;
</p>
<table cellpadding=4 cellspacing=0 bgcolor="lightyellow" border=1 width="587">
<tr	bgcolor="lightgreen">
	<th width="37">Mã </th>
	<th width="126">Ngày &#273;&#7863;t hàng </th>
	<th width="186">Tên m&#7863;t hàng </th>
	<th width="139">Tr&#7841;ng thái &#272;&#272;H</th>
</tr>
<%
While not RS.EOF 
%>
	<tr>
		<td width="37"><a href="frmChiTietDDH.asp?MaDDH=<%=RS("MaDDH")%>">
		<%=RS("MaDDH")%>&nbsp;</td>
		<td width="126">
		<%=RS("NgayDatHang")%> &nbsp;</td>
		<td width="186">
		<%
		sqlString="select MaMH From XUAT Where MaDDH=" & RS("MaDDH")
		Set RS1=Con.Execute (sqlString)
		dem=0
		While not RS1.EOF 
			dem=dem+1
			sqlString="select TenMH From MATHANG Where MaMH='" & RS1("MaMH") & "' "
			Set RS2=Con.Execute (sqlString)
			%>
			<BR><%=dem%>.<%=RS2("TenMH")%>
		<%
		RS1.MoveNext
		WEnd
		Rs1.close
		%>
		</td>
		<td width="139">
		<small>
		<%=showOrderStatus(RS("TrangThaiDDH"))%>
		</small>
		&nbsp;</td>
		<td width="47">
		<a href="frmChiTietDDH.asp?MaDDH=<%=RS("MaDDH")%>">Chi ti&#7871;t</a>
		</td>
	</tr>
<%
RS.MoveNext
WEnd
Rs.close
%>
</table>
<%
End If
%>
</center>
</td>
</tr>
<tr>
<td height="223">
</td>
</tr>
</table>
</td>
<!--#Include file="Footer.asp"-->
</body>

</html>