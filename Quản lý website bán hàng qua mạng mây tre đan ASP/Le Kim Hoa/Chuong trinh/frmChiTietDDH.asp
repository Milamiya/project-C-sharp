<!--#INCLUDE FILE="HamLuuTru.asp"-->
<%
MaDDH=Trim(Request("MaDDH"))
 
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

sqlString="Select * From DONDATHANG Where MaDDH=" & MaDDH
Set RS0=Con.Execute (sqlString)
sqlString="Select MaDC From KHACHHANG Where MaKH= " & RS0("MaKH")
Set RS1=Con.Execute (sqlString)
sqlString="Select * From DIACHI Where MaDC= " & RS1("MaDC")
Set RS2=Con.Execute (sqlString)
sqlString="Select * From DIACHI Where MaDC= " & RS0("MaDC")
Set RS3=Con.Execute (sqlString)
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
<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/Brown.jpg">
<center>
<table border=0 cellspadding=4 cellspacing=0 width="26" height="291">
<center>
<tr>
	<td width="725" height="34">
	<p align="center"><font size="6" color="#000080"><b>CHI TI&#7870;T </b></font><font color="#000080"><b>
    <font size="6">
    &#272;&#416;N &#272;&#7862;T HÀNG </font> </b>
	</font>
	</td>
</tr>
<tr>
	<td width="725" height="1">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="585" height="1">
	<tr >
		<td bgcolor="lightgreen" width="36" height="1">
			<p align="center">
			<b>Mã &#272;&#272;H</b></td>	
		<td  width="71" height="1" align="center">
			<%=MaDDH%> </td>
		<td bgcolor="lightgreen" width="81" height="1">
			 <p align="center"><b>Ngày &#273;&#7863;t hàng</b></td>	
		<td width="150" height="1">
			<%=RS0("NgayDatHang")%> &nbsp;</td>
		<td bgcolor="lightgreen" width="100" height="1">
			 <p align="center"><b>Ngày giao hàng</b></td>	
		<td width="226">
			<%if RS0("NgayGiaoHang")<>"" then%>
				<%=RS0("NgayGiaoHang")%> 
			<%Else%>Tu&#7923; ý
			<%End if%>
		</td>
		<td bgcolor="lightgreen" width="88" height="1">
			 <p align="center">
			 <b>Tr&#7841;ng thái &#272;&#272;H</b></td>	
		<td  height="1" width="146">
			<%=showOrderStatus(RS0("TrangThaiDDH"))%></td>
	</tr>
	</table>
	</td>
</tr>
<tr>
	<td height="191" width="725">
	<table bgcolor="lightyellow" border=1 cellspadding=4 cellspacing=0 width="585" height="95">
	<tr bgcolor="lightgreen">
		<th width="112">
		Thông tin</th>
		<th width="246" >
		&#272;&#7883;a ch&#7881; liên l&#7841;c
		</th>
		<th width="213">
		&#272;&#7883;a ch&#7881; giao hàng
		</th>
	</tr>
	<tr>
		<td height="1" width="112">
			<tr>
        		<td width="112" height="12"><font color="#000080">H&#7885; Tên </font></td>
        		<td width="246" height="12">
        			<%=Server.HTMLEncode(RS2("HoTenKH"))%></td>
        		<td width="213" height="12">
        			<%=Server.HTMLEncode(RS3("HoTenKH"))%></td>
		    </tr>
    		<tr>
        		<td width="112" height="13"><font face="Times New Roman" color="#000080">&#272;&#432;&#7901;ng</font></td>
        		<td width="246" height="13">
	        		<%=Server.HTMLEncode(RS2("Duong"))%></td>
        		<td width="213" height="13">
        			<%=Server.HTMLEncode(RS3("Duong"))%></td>
        	</tr>
    		<tr>
        		<td width="112" height="22"><font face="Times New Roman" color="#000080">Qu&#7853;n (Huy&#7879;n)</font></td>
        		<td width="246" height="22">
					<%=Server.HTMLEncode(RS2("Quan"))%></td>
        		<td width="213" height="22">
					<%=Server.HTMLEncode(RS3("Quan"))%></td>
		    </tr>
    		<tr>
        		<td width="112" height="19"><font face="Times New Roman" color="#000080">Thành ph&#7889; (T&#7881;nh)</font></td>
        		<td width="246" height="19">
					<%=Server.HTMLEncode(RS2("ThanhPho"))%></td>
        		<td width="213" height="19">
					<%=Server.HTMLEncode(RS3("ThanhPho"))%></td>
            </tr>
    		<tr>
   				<td width="112" height="15"><font face="Times New Roman" color="#000080">Qu&#7889;c gia</font></td>
   	            <td width="246" height="15">
					<%=Server.HTMLEncode(RS2("QuocGia"))%></td>
	            <td width="213" height="15">
					<%=Server.HTMLEncode(RS3("QuocGia"))%></td>
		    </tr>
    		<tr>
   				<td width="112" height="15">
                <font face="Times New Roman" color="#000080">&#272;i&#7879;n tho&#7841;i</font></td>
   	            <td width="246" height="15">
					<%=Server.HTMLEncode(RS2("Phone"))%></td>
   	            <td width="213" height="15">
   	            	<%=Server.HTMLEncode(RS3("Phone"))%></td>
	        </tr>
    		<tr>
   				<td width="112" height="15"><font color="#000080">Email</font></td>
   	            <td width="246" height="15">
					<%=Server.HTMLEncode(RS2("Email"))%></td>
   	            <td width="213" height="15">
					<%=Server.HTMLEncode(RS3("Email"))%></td>
	        </tr>
		</td>
	</tr>
    </table>
    </td>
</tr>
<tr>
	<td width="725" height="89">
	<table bgcolor="lightyellow" border=1 cellpadding=4 cellspacing=0 width="586" height="73">
<tr bgcolor="lightgreen">
	<th width="33" height="19">Mã </th>
	<th width="117" height="19">Tên M&#7863;t Hàng</th>
	<th width="73" height="19">&#272;&#417;n Giá </th>
	<th width="68" height="19">S&#7889; L&#432;&#7907;ng</th>
	<th width="97" height="19">Thành Ti&#7873;n</th>
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
		<%=server.HTMLEncode(RS4("MaMH"))%></td>
	<td width="117" height="19">
		<%=server.HTMLEncode(RS5("TenMH"))%></td>
	<td width="73" height="19">
		<%=formatCurrency(RS5("DonGia"))%></td>
	<td width="68" height="19">
		<p align="center">
		<%=RS4("SoLuong")%></td>
	<td width="94" height="19">
		<%=formatCurrency(TT)%></td>
</tr>
<%
	RS4.MoveNext
Wend
RS4.Close
%> 

<tr bgcolor="yellow">
	<td colspan=4 align=right width="321" height="5">
	<b>T&#7893;ng c&#7897;ng :</b> (VND)</td>
	<td width="97" height="5">
	<%=formatCurrency(TongCong)%></td>
</tr>
</table>
</td>
</tr>
</center>
</table>
</center>
</td>
<!--#Include file="Footer.asp"-->

</body>

</html>