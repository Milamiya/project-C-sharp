<!--#include file="KiemTraPasswordDN.asp"-->
<%
'Khai bao bien 
Dim sqlString

'Ket noi CSDL
Set Con=Server.Createobject("ADODB.Connection")
Con.Open "DSN=StoreDSN"
sqlString="Select * From DONDATHANG"
Set RS=Con.Execute(sqlString)
%>

<html>

<head>
<title>Hien thi Mat hang</title>
</head>

<body bgcolor="#E0EAB9">
<!--#include file="TieuDeQL.asp"-->
<center>
<%if RS.EOF then%>
  <table border="0" width="674" cellspacing="0" cellpadding="0" height="41">
  	<tr>
  		<td width="674">
  		<p align="center"><font size="5" color="#000080"><b>C&#7917;a hàng chúng ta 
        hi&#7879;n th&#7901;i ch&#432;a có &#273;&#417;n &#273;&#7863;t hàng nào c&#7843;</b></font><br>
 		</td>
  	</tr>
  </table>
<%Else%>	
  <table border="0" width="674" cellspacing="0" cellpadding="0" height="41">
  	<tr>
  		<td width="674">
  		<p align="left"><b><font size="5" color="#000080">Danh Sách &#273;&#417;n &#273;&#7863;t 
        hàng</font></b><br>
 		</td>
  	</tr>
  </table>
  <table border="1" width="693" cellspacing="0" cellpadding="4" height="56">
  <tr bgcolor="lightgreen" >
  	 <th width="49" height="17">Mã </th>
  	 <th width="119" height="17">Ngày &#273;&#7863;t hàng</th>
   	 <th width="135" height="17">H&#7885; tên khách hàng</th>
  	 <th width="105" height="17">T&#7893;ng s&#7889; ti&#7873;n</th>
  	 <th width="167" height="17">Tr&#7841;ng thái &#272;&#272;H</th>
  </tr>
  <%Do While Not RS.EOF%>
  <tr bgcolor="lightyellow">
   	<td width="49" height="19">
   	<a href="ChiTietDDH.asp?MaDDH=<%=RS("MaDDH")%> ">
   		 <%=RS("MaDDH")%></a>
   	</td>	
  	<td width="119" height="19">
  	<%=RS("NgayDatHang")%>
  	</td>
  	<td width="135">
  	<%	sqlString="Select MaDC From KHACHHANG WHERE MaKH=" & RS("MaKH")
		Set RS3=Con.Execute(sqlString)
   		sqlString="Select HoTenKH From DIACHI WHERE MaDC=" & RS3("MaDC")
		Set RS4=Con.Execute(sqlString)
	%>
	<%=RS4("HoTenKH")%> &nbsp;</td>
   	<td width="105" height="19" align="Center">
   	<%
   		sqlString="Select MaMH, SoLuong From XUAT WHERE MaDDH=" & RS("MaDDH")
		Set RS1=Con.Execute(sqlString)
		TongTien=0
		Do While Not RS1.EOF
			sqlString="Select DonGia From MATHANG WHERE MaMH='" & RS1("MaMH") & "' "
			Set RS2=Con.Execute(sqlString)
			TongTien=TongTien + (RS1("SoLuong")*RS2("DonGia"))
		RS1.MoveNext 
	  	Loop
  		RS1.Close
   	%>
   	<%=formatcurrency(TongTien)%>
    </td>
   	<td width="167" height="19" align="Center">
   	<%
   	st0=""
   	st1=""
   	st2=""
   	select case RS("TrangThaiDDH")
   		Case 0 
   			st0="selected"
   		Case 1
   			st1="selected"
   		Case 2
   			st2="selected"
   		Case 3
   			st3="selected"
   	End select%>
	<form method ="post" action="CapNhatTTDDH.asp">
		<input type="hidden" name="MaDDH" value="<%=RS("MaDDH")%>">
		<select name="TTDDH">
			<option value="0" <%=st0%>>Ch&#432;a giao hàng
			<option value="1" <%=st1%>>&#272;ang giao hàng
			<option value="2" <%=st2%>>&#272;ã giao hàng và thanh toán
			<option value="3" <%=st3%>>Không x&#7917; lý
		</Select>
		<input type="submit" name="CapNhatDDH" value="C&#7853;p nh&#7853;t">
	</form>
   	 </td>
    <td height="19" width="40">
    <a href="XoaDDH.asp?MaDDH=<%=RS("MaDDH")%>">Delete</a>
    </td>
    <td height="19" width="56">
    <a href="ChiTietDDH.asp?MaDDH=<%=RS("MaDDH")%>">Chi ti&#7871;t </a>
    </td>
  </tr>
  <%
  	RS.MoveNext 
  	Loop
  	RS.Close
  %>
  
  </table>
<%End if%>
 </center> 
</body>

</html>