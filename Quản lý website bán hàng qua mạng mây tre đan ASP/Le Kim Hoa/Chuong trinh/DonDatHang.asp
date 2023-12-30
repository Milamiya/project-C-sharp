<%
NgayGiaoHang=Request("Ngay") & "/" & Request("Thang") & "/" & Request("Nam")
NgayGiaoHang=cDate(NgayGiaoHang)
MaKH=Trim(Request("pid"))
MaDC1=Trim(Request("MaDC"))
HoTenKH=Trim(Request("HoTenKH"))
Duong=Trim(Request("Duong"))
Quan=Trim(Request("Quan"))
ThanhPho=Trim(Request("ThanhPho"))
QuocGia=Trim(Request("QuocGia"))
Phone=Trim(Request("Phone"))
Email=Trim(Request("Email"))
 
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"
'MaDC1=MaDC
sqlString="Select MaDC From DIACHI " &_
		 "Where HoTenKH='" & HoTenKH & "' and Duong='" & Duong & "' " &_
		" and Quan='" & Quan & "' and ThanhPho='" & ThanhPho & "' and QuocGia='" & QuocGia & "'" &_
		" and phone='" & phone & "' and Email='" & Email & "' "
Set RS=Con.Execute (sqlString)
If RS.EOF then
	sqlString1="Insert Into DIACHI(HoTenKH, Duong, Quan, ThanhPho, QuocGia, Phone, Email)" &_
			"Values ('" & HoTenKH & "', '" & Duong & "', '" & Quan & "'" &_
			", '" & ThanhPho & "', '" & QuocGia & "', '" & Phone & "', '" & Email & "')"
		Con.Execute (sqlString1)
		sqlString="Select MaDC From DIACHI " &_
				" Where HoTenKH = '" & HoTenKH & "' And Duong='" & Duong & "'" &_
				" And Quan='" & Quan & "' And ThanhPho='" & ThanhPho & "'" &_
				" And QuocGia='" & QuocGia & "' And Phone='" & Phone & "' And Email='" & Email & "'"
		Set RS1=Con.Execute (sqlString)
		MaDC=RS1("MaDC")
Else	
		MaDC=RS("MaDC")
End if
sqlString="Select * From GIOMUAHANG Where MaKH=" & MaKH
Set RS3=Con.Execute (sqlString)
If Not RS3.EOF then
MaDDH=RS3("MaGio") 
if NgayGiaoHang>= Now() then
	'sqlString="Insert Into DONDATHANG( MaDDH, MaKH, MaDC, NgayDatHang)" &_
	'			"Values (" & MaDDH & "," & MaKH & " ," & MaDC & ", Now())"
	'Con.Execute sqlString
'Else
	sqlString="Insert Into DONDATHANG( MaDDH, MaKH, MaDC, NgayDatHang, NgayGiaoHang )" &_
				"Values (" & MaDDH & "," & MaKH & " ," & MaDC & ", Now(),  '" & NgayGiaoHang & "')"
	Con.Execute sqlString
'End if
sqlString="select * From DONDATHANG Where MaDDH=" & MaDDH 
Set RS2=Con.Execute (sqlString)
		
WHILE NOT RS3.EOF
	sqlString="select MaXuat From Xuat Where MaDDH=" & RS2("MaDDH") & " And MaMH='" & RS3("MaMH") & "'"
	set ktRS=Con.Execute (sqlString)
	if ktRS.EOF then
		sqlString="Insert Into XUAT( MaDDH, MaMH, SoLuong)" &_
				"Values (" & RS2("MaDDH") & " ,'" & RS3("MaMH") & "', " & RS3("SoLuongMua") & " )"
	Con.Execute sqlString
	end if
	RS3.MoveNext
Wend
RS3.Close
sqlString="Delete From GIOMUAHANG where MaKH=" & MaKH
Con.Execute sqlString

sqlString="Select * From DIACHI Where MaDC=" & RS2("MaDC")
Set RS4=Con.Execute (sqlString)
sqlString="Select * From XUAT Where MaDDH=" & RS2("MaDDH")
Set RS5=Con.Execute (sqlString)
sqlString="Select * From DIACHI Where MaDC=" & MaDC1
Set dcRS=Con.Execute (sqlString)

%>
<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 5.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252">
<title>Dat Hang</title>
</head>
<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/Brown.jpg">
<table border=0 cellspacing=0 cellpadding=0 width="600" height="65">
<tr>
	<td height="18" width="596">
	<p align="center" style="margin-top: 0; margin-bottom: 0">
	<font color="#800000" size="4"><b>C&#7917;a chúng tôi r&#7845;t c&#7843;m &#417;n quí khách hàng &#273;ã &#273;&#7863;t hàng 
    </b></font>
	<p align="center" style="margin-top: 0; margin-bottom: 0">
	<font color="#800000" size="4"><b>t&#7841;i c&#7917;a hàng chúng tôi.
	<br>Chúng tôi s&#7869; giao hàng &#273;úng lúc, &#273;úng n&#417;i mà khách hàng &#273;ã yêu c&#7847;u.
    </b></font>
	</td>
</tr>
</table>
<table border=0 cellspadding=4 cellspacing=0 width="587" height="347">
<tr>
	<td width="599" height="34">
	<p align="center"><font color="#000080"><b><font size="5">BIÊN NH&#7852;N &#272;&#416;N &#272;&#7862;T HÀNG</font> </b>
	</font>
	</td>
</tr>
<tr>
	<td width="599" height="25">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="590">
	<tr >
		<td bgcolor="lightgreen" width="131">
			<p align="center">
			<b>Mã &#273;&#417;n &#273;&#7863;t hàng&nbsp; </b>
		</td>	
		<td  width="120">
			<%=RS2("MaDDH")%> &nbsp;</td>
		<td bgcolor="lightgreen" width="90">
			 <p align="center">
			 <b>Ngày &#273;&#7863;t hàng</b>
		</td>	
		<td width="246">
			<%=RS2("NgayDatHang")%> &nbsp;</td>
		<td bgcolor="lightgreen" width="98">
			 <p align="center">
			 <b>Ngày giao hàng</b></td>	
		<td width="217">
		<%if RS2("NgayGiaoHang")<>"" then%>
			<%=RS2("NgayGiaoHang")%> 
		<%Else%>Tu&#7923; ý
		<%End if%></td>
	
	</tr>
	</table>
	</td>
</tr>
<tr>
	<td height="191" width="599">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="590" height="95">
	<tr bgcolor="lightgreen">
		<th width="116">
		Thông tin</th>
		<th width="229" >
		&#272;&#7883;a ch&#7881; liên l&#7841;c
		</th>
		<th width="231">
		&#272;&#7883;a ch&#7881; giao hàng</th>
	</tr>
	<tr>
		<td height="1" width="116">
			<tr>
        		<td width="116" height="12"><font color="#000080">H&#7885; Tên </font></td>
        		<td width="229" height="12"><%=Server.HTMLEncode(dcRS("HoTenKH"))%></td>
        		<td width="231" height="12"><%=Server.HTMLEncode(RS4("HoTenKH"))%></td>
		    </tr>
    		<tr>
        		<td width="116" height="13"><font face="Times New Roman" color="#000080">&#272;&#432;&#7901;ng</font></td>
        		<td width="229" height="13"><%=Server.HTMLEncode(dcRS("Duong"))%></td>
        		<td width="231" height="13"><%=Server.HTMLEncode(RS4("Duong"))%></td>
        	</tr>
    		<tr>
        		<td width="116" height="22"><font face="Times New Roman" color="#000080">Qu&#7853;n (Huy&#7879;n)</font></td>
        		 <td width="229" height="22"><%=Server.HTMLEncode(dcRS("Quan"))%></td>
        		  <td width="231" height="22"><%=Server.HTMLEncode(RS4("Quan"))%></td>
		    </tr>
    		<tr>
        		<td width="116" height="19"><font face="Times New Roman" color="#000080">Thành ph&#7889; (T&#7881;nh)</font></td>
        		<td width="229" height="19"><%=Server.HTMLEncode(dcRS("ThanhPho"))%></td>
        		<td width="231" height="19"><%=Server.HTMLEncode(RS4("ThanhPho"))%></td>
            </tr>
    		<tr>
   				<td width="116" height="15"><font face="Times New Roman" color="#000080">Qu&#7889;c gia</font></td>
   	            <td width="229" height="15"><%=Server.HTMLEncode(dcRS("QuocGia"))%></td>
	            <td width="231" height="15"><%=Server.HTMLEncode(RS4("QuocGia"))%></td>
		    </tr>
    		<tr>
   				<td width="116" height="15">
                <font face="Times New Roman" color="#000080">&#272;i&#7879;n tho&#7841;i</font></td>
   	            <td width="229" height="15"><%=Server.HTMLEncode(dcRS("Phone"))%></td>
   	            <td width="231" height="15"><%=Server.HTMLEncode(RS4("Phone"))%></td>

	        </tr>
    		<tr>
   				<td width="116" height="15">Email</td>
   	            <td width="229" height="15"><%=Server.HTMLEncode(dcRS("Email"))%></td>
   	            <td width="231" height="15"><%=Server.HTMLEncode(RS4("Email"))%></td>

	        </tr>
		</td>
	</tr>
    </table>
    </td>
</tr>
<tr>
<td width="599" height="89">
<table bgcolor="lightyellow" border=1 cellpadding=4 cellspacing=0 width="590" height="73">
<tr bgcolor="lightgreen">
	<th width="33" height="19">Mã </th>
	<th width="117" height="19">Tên M&#7863;t Hàng</th>
	<th width="107" height="19">&#272;&#417;n Giá (VND)</th>
	<th width="66" height="19">S&#7889; L&#432;&#7907;ng</th>
	<th width="69" height="19">Thành Ti&#7873;n</th>
</tr>
<% 
TongCong=0
WHILE NOT RS5.EOF
%>
<tr>
<%
	sqlString="Select TenMH, DonGia From MatHang Where MaMH='" & RS5("MaMH") & "'"
	Set RS6=Con.Execute (sqlString)
	TT=RS6("DonGia")*RS5("SoLuong")
	TongCong=TongCong+TT
%>
	<td width="33" height="19">
	<%=server.HTMLEncode(RS5("MaMH"))%> &nbsp;</td>
	<td width="117" height="19">
	<%=server.HTMLEncode(RS6("TenMH"))%>&nbsp;</td>
	<td width="107" height="19">
	<%=formatCurrency(RS6("DonGia"))%> &nbsp;</td>
	<td width="66" height="19">
	<%=RS5("SoLuong")%>&nbsp;</td>
	<td width="66" height="19">
	<%=formatCurrency(TT)%>&nbsp;</td>
</tr>
<%
	RS5.MoveNext
Wend
RS5.Close
%> 

<tr bgcolor="yellow">
	<td colspan=4 align=right width="353" height="5">
	<b>T&#7893;ng c&#7897;ng :</b>
	</td>
	<td width="69" height="5">
	<%=formatCurrency(TongCong)%> &nbsp;</td>
</tr>
</table>
	</td>
</tr>
<%Else%>
	<tr>
		<td>
			Ban da nhap sai 
		</td>
	</tr>
<%End if%>
</table>

<%Else%>
<tr>
	<td>
	Xin m&#7901;i các b&#7841;n tr&#7903; v&#7873; <a href="TrangChu.asp">trang ch&#7911;</a> &#273;&#7875; xem &#273;&#417;n &#273;&#7863;t hàng c&#7911;a mình.
	</td>
</tr>
<%End if%></td><!--#Include file="Footer.asp"--></body></html>