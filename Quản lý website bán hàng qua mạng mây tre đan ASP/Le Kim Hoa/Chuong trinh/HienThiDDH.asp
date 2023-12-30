<%
MaDDH=Trim(Request("MaDDH"))
MaKH=Trim(Request("pid"))
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

sqlString="Select * From DONDATHANG Where MaDDH=" & MaDDH
Set RS=Con.Execute (sqlString)
sqlString="Select * From DIACHI Where MaDC=" & RS("MaDC")
Set RS1=Con.Execute (sqlString)
sqlString="Select * From XUAT Where MaDDH=" & MaDDH
Set RS2=Con.Execute (sqlString)
sqlString="Select MaDC From KHACHHANG Where MaKH=" & MaKH
Set khRS=Con.Execute (sqlString)
sqlString="Select * From DIACHI Where MaDC=" & khRS("MaDC")
Set dcRS=Con.Execute (sqlString)


%>
<html>

<head>
<meta name="GENERATOR" content="Microsoft FrontPage 5.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252">
<title>New Page 1</title>
</head>

<body>
<table border=0 cellspadding=4 cellspacing=0 width="600" height="347">
<tr>
	<td width="599" height="34">
	<p align="center"><font color="#000080"><b><font size="5">BIÊN NH&#7852;N &#272;&#416;N &#272;&#7862;T HÀNG</font> </b>
	</font>
	</td>
</tr>
<tr>
	<td width="599" height="25">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="599">
	<tr >
		<td bgcolor="lightgreen" width="124">
			<b>Mã &#273;&#417;n &#273;&#7863;t hàng&nbsp; </b>
		</td>	
		<td  width="91">
			<%=MaDDH%> &nbsp;</td>
		<td bgcolor="lightgreen" width="177">
			 <b>Ngày t&#7841;o &#273;&#417;n &#273;&#7863;t hàng</b>
		</td>	
		<td width="189">
			<%=RS("NgayDatHang")%> &nbsp;</td>
	</tr>
	</table>
	</td>
</tr>
<tr>
	<td height="191" width="599">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="599" height="95">
	<tr bgcolor="lightgreen">
		<th width="116">
		Thông tin</th>
		<th width="229" >
		&#272;&#7883;a ch&#7881; liên l&#7841;c
		</th>
		<th width="240">
		&#272;&#7883;a ch&#7881; thanh toán
		</th>
	</tr>
	<tr>
		<td height="1" width="116">
			<tr>
        		<td width="116" height="12"><font color="#000080">H&#7885; Tên </font></td>
        		<td width="229" height="12"><%=Server.HTMLEncode(dcRS("HoTenKH"))%></td>
        		<td width="240" height="12"><%=Server.HTMLEncode(RS1("HoTenKH"))%></td>
		    </tr>
    		<tr>
        		<td width="116" height="13"><font face="Times New Roman" color="#000080">&#272;&#432;&#7901;ng</font></td>
        		<td width="229" height="13"><%=Server.HTMLEncode(dcRS("Duong"))%></td>
        		<td width="240" height="13"><%=Server.HTMLEncode(RS1("Duong"))%></td>
        	</tr>
    		<tr>
        		<td width="116" height="22"><font face="Times New Roman" color="#000080">Qu&#7853;n (Huy&#7879;n)</font></td>
        		 <td width="229" height="22"><%=Server.HTMLEncode(dcRS("Quan"))%></td>
        		  <td width="240" height="22"><%=Server.HTMLEncode(RS1("Quan"))%></td>
		    </tr>
    		<tr>
        		<td width="116" height="19"><font face="Times New Roman" color="#000080">Thành ph&#7889; (T&#7881;nh)</font></td>
        		<td width="229" height="19"><%=Server.HTMLEncode(dcRS("ThanhPho"))%></td>
        		<td width="240" height="19"><%=Server.HTMLEncode(RS1("ThanhPho"))%></td>
            </tr>
    		<tr>
   				<td width="116" height="15"><font face="Times New Roman" color="#000080">Qu&#7889;c gia</font></td>
   	            <td width="229" height="15"><%=Server.HTMLEncode(dcRS("QuocGia"))%></td>
	            <td width="240" height="15"><%=Server.HTMLEncode(RS1("QuocGia"))%></td>
		    </tr>
    		<tr>
   				<td width="116" height="15">
                <font face="Times New Roman" color="#000080">&#272;i&#7879;n tho&#7841;i</font></td>
   	            <td width="229" height="15"><%=Server.HTMLEncode(dcRS("Phone"))%></td>
	        </tr>
    		<tr>
   				<td width="116" height="15">Email</td>
   	            <td width="229" height="15"><%=Server.HTMLEncode(dcRS("Email"))%></td>
	        </tr>
		</td>
	</tr>
    </table>
    </td>
</tr>
<tr>
	<td width="599" height="89">
	<table bgcolor="lightyellow" border=1 cellpadding=4 cellspacing=0 width="599">
<tr bgcolor="lightgreen">
	<th width="33">Mã </th>
	<th width="117">Tên M&#7863;t Hàng</th>
	<th width="107">&#272;&#417;n Giá (VND)</th>
	<th width="66">S&#7889; L&#432;&#7907;ng</th>
	<th width="78">Thành Ti&#7873;n</th>
</tr>
<% 
TongCong=0
WHILE NOT RS2.EOF
%>
<tr>
<%
	sqlString="Select TenMH, DonGia From MatHang Where MaMH='" & RS2("MaMH") & "'"
	Set RS3=Con.Execute (sqlString)
	TT=RS3("DonGia")*RS2("SoLuong")
	TongCong=TongCong+TT
%>
	<td width="33">
	<%=server.HTMLEncode(RS2("MaMH"))%> &nbsp;</td>
	<td width="117">
	<%=server.HTMLEncode(RS3("TenMH"))%>&nbsp;</td>
	<td width="107">
	<%=formatCurrency(RS3("DonGia"))%> &nbsp;</td>
	<td width="66">
	<%=RS2("SoLuong")%>&nbsp;</td>
	<td width="75">
	<%=formatCurrency(TT)%>&nbsp;</td>
</tr>
<%
	RS2.MoveNext
Wend
RS2.Close
%> 

<tr bgcolor="yellow">
	<td colspan=4 align=right width="353">
	<b>T&#7893;ng c&#7897;ng :</b>
	</td>
	<td width="78">
	<%=formatCurrency(TongCong)%> &nbsp;</td>
</tr>
</table>
	</td>
</tr>
</table>


</body>

</html>