<!--#include file="KiemTraPasswordDN.asp"-->
<%
MaDDH=Trim(Request("MaDDH"))
 
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

sqlString="Select * From DONDATHANG Where MaDDH=" & MaDDH
Set RS0=Con.Execute (sqlString)
If not RS0.Eof then
	sqlString="Select MaDC From KHACHHANG Where MaKH= " & RS0("MaKH")
	Set RS1=Con.Execute (sqlString)
	sqlString="Select * From DIACHI Where MaDC= " & RS0("MaDC")
	Set RS3=Con.Execute (sqlString)
	If not RS1.Eof then
		sqlString="Select * From DIACHI Where MaDC= " & RS1("MaDC")
		Set RS2=Con.Execute (sqlString)
	End if
End if
sqlString="Select * From XUAT Where MaDDH= " & MaDDH
Set RS4=Con.Execute (sqlString)

%>
<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 5.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252">
<title>Dat Hang</title>
</head>
<BODY bgcolor="#E0EAB9">
<center>
<!--#include file="TieuDeQL.asp"-->
<table border=0 cellspadding=4 cellspacing=0 width="728" height="291">
<center>
<form method="post" action="CapNhatDDH.asp" NAME="frmKiemDinh">
<tr>
	<td width="726" height="34">
	<p align="center"><font size="5" color="#000080"><b>CHI TI&#7870;T </b></font><font color="#000080"><b><font size="5">
    &#272;&#416;N &#272;&#7862;T HÀNG</font> </b>
	</font>
	</td>
</tr>
<tr>
	<td width="726" height="1">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="725" height="1">
	<tr >
		<td bgcolor="lightgreen" width="67" height="1">
			<p align="center">
			<b>Mã &#272;&#272;H</b></td>	
		<td  width="125" height="1">
			<%=MaDDH%> &nbsp;</td>
		<td bgcolor="lightgreen" width="143" height="1">
			 <p align="center">
			 <b>Ngày t&#7841;o &#272;&#272;H</b></td>	
		<td width="406" height="1">
			<%=RS0("NgayDatHang")%> &nbsp;</td>
		<td bgcolor="lightgreen" width="166" height="1">
			 <p align="center">
			 <b>Ngày giao hàng</b></td>	
		<td width="226">
			<%if RS0("NgayGiaoHang")<>"" then%>
				<%=RS0("NgayGiaoHang")%> 
			<%Else%>Tu&#7923; ý
			<%End if%>
		</td>
		<td bgcolor="lightgreen" width="147" height="1">
			 <p align="center">
			 <b>Tr&#7841;ng thái &#272;&#272;H</b></td>	
		<td width="180" height="1">
			<%
   			st0=""
   			st1=""
   			st2=""
   			select case RS0("TrangThaiDDH")
   				Case 0 
   					st0="selected"
   				Case 1
   					st1="selected"
   				Case 2
   					st2="selected"
   				Case 3
   					st3="selected"
   			End select%>
			<select name="TrangThaiDDH">
				<option value="0" <%=st0%>>Ch&#432;a giao hàng
				<option value="1" <%=st1%>>&#272;ang giao hàng
				<option value="2" <%=st2%>>&#272;ã giao hàng và thanh toán
				<option value="3" <%=st3%>>Không x&#7917; lý
			</Select>
 		</td>
	</tr>
	</table>
	</td>
</tr>
<tr>
	<td height="191" width="726">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="725" height="95">
	<tr bgcolor="lightgreen">
		<th width="116">
		Thông tin</th>
		<th width="285" >
		&#272;&#7883;a ch&#7881; liên l&#7841;c
		</th>
		<th width="310">
		&#272;&#7883;a ch&#7881; thanh toán
		</th>
	</tr>
	<tr>
		<td height="1" width="116">
			<tr>
        		<td width="116" height="12"><font color="#000080">H&#7885; Tên </font></td>
        		<td width="285" height="12">
        			<input type="text" name="HoTenKHLL" value="<%=Server.HTMLEncode(RS2("HoTenKH"))%>" size="30"></td>
        		<td width="310" height="12">
        			<input type="text" name="HoTenKHGH" value="<%=Server.HTMLEncode(RS3("HoTenKH"))%>" size="30"></td>
		    </tr>
    		<tr>
        		<td width="116" height="13"><font face="Times New Roman" color="#000080">&#272;&#432;&#7901;ng</font></td>
        		<td width="285" height="13">
	        		<input type="text" name="DuongLL" value="<%=Server.HTMLEncode(RS2("Duong"))%>" size="30"></td>
        		<td width="310" height="13">
        			<input type="text" name="DuongGH" value="<%=Server.HTMLEncode(RS3("Duong"))%>" size="30"></td>
        	</tr>
    		<tr>
        		<td width="116" height="22"><font face="Times New Roman" color="#000080">Qu&#7853;n (Huy&#7879;n)</font></td>
        		<td width="285" height="22">
        			<input type="text" name="QuanLL" value="<%=Server.HTMLEncode(RS2("Quan"))%>" size="20"></td>
        		<td width="310" height="22">
        			<input type="text" name="QuanGH" value="<%=Server.HTMLEncode(RS3("Quan"))%>" size="20"></td>
		    </tr>
    		<tr>
        		<td width="116" height="19"><font face="Times New Roman" color="#000080">Thành ph&#7889; (T&#7881;nh)</font></td>
        		<td width="285" height="19">
        			<input type="text" name="ThanhPhoLL" value="<%=Server.HTMLEncode(RS2("ThanhPho"))%>" size="20"></td>
        		<td width="310" height="19">
        			<input type="text" name="ThanhPhoGH" value="<%=Server.HTMLEncode(RS3("ThanhPho"))%>" size="20"></td>
            </tr>
    		<tr>
   				<td width="116" height="15"><font face="Times New Roman" color="#000080">Qu&#7889;c gia</font></td>
   	            <td width="285" height="15">
   	            	<input type="text" name="QuocGiaLL" value="<%=Server.HTMLEncode(RS2("QuocGia"))%>" size="20"></td>
	            <td width="310" height="15">
	            	<input type="text" name="QuocGiaGH" value="<%=Server.HTMLEncode(RS3("QuocGia"))%>" size="20"></td>
		    </tr>
    		<tr>
   				<td width="116" height="15">
                <font face="Times New Roman" color="#000080">&#272;i&#7879;n tho&#7841;i</font></td>
   	            <td width="285" height="15">
   	            	<input type="text" name="PhoneLL" value="<%=Server.HTMLEncode(RS2("Phone"))%>" size="20"></td>
   	            <td width="310" height="15">
   	            	<input type="text" name="PhoneGH" value="<%=Server.HTMLEncode(RS3("Phone"))%>" size="20"></td>
	        </tr>
    		<tr>
   				<td width="116" height="15"><font color="#000080">Email</font></td>
   	            <td width="285" height="15">
   	            	<input type="text" name="EmailLL" value="<%=Server.HTMLEncode(RS2("Email"))%>" size="30"></td>
   	            <td width="310" height="15">
   	            	<input type="text" name="EmailLL" value="<%=Server.HTMLEncode(RS3("Email"))%>" size="30"></td>
	        </tr>
		</td>
	</tr>
    </table>
    </td>
</tr>
<tr>
	<td width="726" height="89">
	<table bgcolor="lightyellow" border=1 cellpadding=4 cellspacing=0 width="725" height="73">
<tr bgcolor="lightgreen">
	<th width="33" height="19">Mã </th>
	<th width="117" height="19">Tên M&#7863;t Hàng</th>
	<th width="107" height="19">&#272;&#417;n Giá (VND)</th>
	<th width="81" height="19">S&#7889; L&#432;&#7907;ng</th>
	<th width="189" height="19">Thành Ti&#7873;n</th>
</tr>
<% 
TongCong=0
WHILE NOT RS4.EOF
%>
<tr>
<%
	sqlString="Select TenMH, DonGia From MatHang Where MaMH='" & RS4("MaMH") & "'"
	Set RS5=Con.Execute (sqlString)
	TT=RS5("DonGia")*RS4("SoLuong")
	TongCong=TongCong+TT
%>
	<td width="33" height="19">
		<input type="text" name="MaMH" value="<%=server.HTMLEncode(RS4("MaMH"))%>" size="4"></td>
	<td width="117" height="19">
		<%=server.HTMLEncode(RS5("TenMH"))%></td>
	<td width="107" height="19">
		<%=formatCurrency(RS5("DonGia"))%></td>
	<td width="81" height="19">
		<p align="center">
		<input type="text" name="SoLuong" value="<%=RS4("SoLuong")%>" size="3"></td>
	<td width="186" height="19">
		<%=formatCurrency(TT)%>&nbsp;</td>
</tr>
<%
	RS4.MoveNext
Wend
RS4.Close
%> 

<tr bgcolor="yellow">
	<td colspan=4 align=right width="368" height="5">
	<b>T&#7893;ng c&#7897;ng :</b>
	</td>
	<td width="189" height="5">
	<%=formatCurrency(TongCong)%> &nbsp;</td>
</tr>
</table>
</td>
</tr>
<tr>
	<td>
		<p align="center">
		<br>
		&nbsp;</td>
	</td>
</tr>
</form>
</center>
</table>
</center>
</body>

</html>
<Script language=vbscript>

Sub btnSubmit_Onclick()
	IF Len(frmKiemDinh.HoTenKHLL.value)=0 Then
		Alert "Ban phai nhap vao ho va ten cua ban"
		frmKiemDinh.HoTenKHLL.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.DuongLL.value)=0 Then
		Alert "Ban phai nhap vao so nha va ten duong cua ban"
		frmKiemDinh.DuongLL.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.QuanLL.value)=0 Then
		Alert "Ban phai nhap vao Quan(Huyen) cua ban"
		frmKiemDinh.QuanLL.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.ThanhPhoLL.value)=0 Then
		Alert "Ban phai nhap vao Thanh Pho(Tinh) cua ban"
		frmKiemDinh.ThanhPhoLL.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.QuocGiaLL.value)=0 Then
		Alert "Ban phai nhap vao Quoc Gia cua ban"
		frmKiemDinh.QuocGiaLL.focus
		Exit Sub
	ElseIf Len(frmDangKy.PhoneLL.value)=0 Then
		Alert "Ban phai nhap vao so Phone cua ban"
		frmDangKy.PhoneLL.focus
		Exit Sub
	ElseIf Not isNumeric(frmDangKy.PhoneLL.value) Then
		Alert "Ban phai nhap lai so Phone cua ban"
		frmDangKy.PhoneLL.value=""
		frmDangKy.PhoneLL.focus
		Exit Sub
	ElseIf Len(frmDangKy.PhoneLL.value)<9 Then
		Alert "Ban phai nhap lai so Phone cua ban tren 9 so"
		frmDangKy.PhoneLL.value=""
		frmDangKy.PhoneLL.focus
		Exit Sub
	ElseIf Len(frmDangKy.EmailLL.value)=0 Then
		Alert "Ban phai nhap vao Email cua ban"
		frmDangKy.EmailLL.focus
		Exit Sub
	ELSEIF Len(frmKiemDinh.HoTenKHGH.value)=0 Then
		Alert "Ban phai nhap vao ho va ten cua ban"
		frmKiemDinh.HoTenKHGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.DuongGH.value)=0 Then
		Alert "Ban phai nhap vao so nha va ten duong cua ban"
		frmKiemDinh.DuongGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.QuanGH.value)=0 Then
		Alert "Ban phai nhap vao Quan(Huyen) cua ban"
		frmKiemDinh.QuanGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.ThanhPhoGH.value)=0 Then
		Alert "Ban phai nhap vao Thanh Pho(Tinh) cua ban"
		frmKiemDinh.ThanhPhoGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.QuocGiaGH.value)=0 Then
		Alert "Ban phai nhap vao Quoc Gia cua ban"
		frmKiemDinh.QuocGiaGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.PhoneGH.value)=0 Then
		Alert "Ban phai nhap vao so Phone cua ban"
		frmKiemDinh.PhoneGH.focus
		Exit Sub
	ElseIf Not isNumeric(frmKiemDinh.PhoneGH.value) Then
		Alert "Ban phai nhap lai so Phone cua ban"
		frmKiemDinh.PhoneGH.value=""
		frmKiemDinh.PhoneGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.PhoneGH.value)<9 Then
		Alert "Ban phai nhap lai so Phone cua ban tren 9 so"
		frmKiemDinh.PhoneGH.value=""
		frmKiemDinh.PhoneGH.focus
		Exit Sub
	ElseIf Len(frmKiemDinh.EmailGH.value)=0 Then
		Alert "Ban phai nhap vao Email cua ban"
		frmKiemDinh.EmailGH.focus
		Exit Sub
	End if
	Call frmKiemDinh.Submit()
End Sub
</script>