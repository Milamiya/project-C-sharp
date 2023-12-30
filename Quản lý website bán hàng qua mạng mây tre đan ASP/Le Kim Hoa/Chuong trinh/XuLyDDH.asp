<!--#INCLUDE FILE="adovbs.inc"-->
<%
'Lay bien form
HienThiDDH=TRIM(Request("HienThiDDH"))
HienThiTrang=TRIM(Request("HienThiTrang"))
TrangThai_DDH=TRIM(Request("TrangThaiDDH"))
Ma_DDH=TRIM(Request("Ma_DDH"))
allpages=TRIM(Request("allpages"))

'khoi tri
IF HienThiDDH="" THEN
	HienThiDDH=0
END IF	
IF HienThiTrang="" THEN
	HienThiTrang=1
END IF

'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'Cap nhat don dat hang
IF Ma_DDH<>"" THEN
	IF TrangThai_DDH=3 THEN
		sqlString="UPDATE DONDATHANG"&_
				SET TrangThaiDDH="& TrangThai_DDH &","&_
				"NgayDatHang=NOW() "&_
				"WHERE MaDDH="& Ma_DDH
	ELSE
		sqlString="UPDATE DONDATHANG"&_
				SET TrangThaiDDH="& TrangThai_DDH &","&_
				"NgayDatHang=NULL "&_
				"WHERE MaDDH="& Ma_DDH
	END IF
	Con.Execute sqlString
END IF

' retrieve don dat hang
sqlString="SELECT *"&_
		"FROM  DONDATHANG,KHACHHANG,MATHANG"&_
		"WHERE Ma_DDH_KH=MaKH"&_
		"AND Ma_DDH_MH=MaMH"&_
IF HienThiDDH<99 THEN
	sqlString=sqlString & "and TrangThaiDDH=" & HienThiDDH
END IF
sqlString=sqlString & "ORDER BY NgayLapDDH DESC"

SET RS=Server.CreateObject("ADODB.Recordset")
RS.CursorType=adopenStatic
IF allpage="" THEN
	RS.Pagesize=5
ELSE
	RS.Pagesize=99999
END IF
RS.Activeconnection=con
RS.Open sqlString
IF NOT RS.EOF THEN
	RS.AbsolutePage=cINT(HienThitrang)
END IF

FUNCTION SELECTED(val1,val2)
	IF cSTR(val1)=cSTR(val2) THEN
		SELECTED="selected"
	END IF
END FUNCTION
%>
<html>

<head>
<title>X&#7917; lý &#273;&#417;n &#273;&#7863;t hàng</title>
</head>

<body>
<form action="XuLyDDH.asp">
	<table width="100%" border=0>
		<tr>
			<td>
				<font face="Arial" size="4">
				X&#7917; lý &#273;&#417;n &#273;&#7863;t hàng
				</font>
			</td>
			<td align="right">
				Hien th&#7883; &#273;&#417;n &#273;&#7863;t hàng :
				<select name="HienThiDDH">
					<option value="0" <%=SELECTED("0",HienThiDDH)%>>Pending(Ch&#432;a hoàn t&#7845;t)
					<option value="1" <%=SELECTED("1",HienThiDDH)%>>Credit C&#7843;d Declined(Không có th&#7867; tín d&#7909;ng)
					<option value="2" <%=SELECTED("2",HienThiDDH)%>>Not in stock(không có hàng)
					<option value="3" <%=SELECTED("3",HienThiDDH)%>>Shipped(hoàn t&#7845;t)
					<option value="99" <%=SELECTED("99",HienThiDDH)%>>T&#7845;t c&#7843; &#273;&#417;n &#273;&#7863;t hàng
				</select>
				<input type="submit" value="Hi&#7875;n Th&#7883;">
			</td>
		</tr>
	</table>
</form>

<%
WHILE NOT RS.EOF AND SoHang<RS.Pagesize
	SoHang=SoHang+1
%>
<p>
<table border=1 cellspadding=4 cellspacing=0>
	<tr>
		<td bgcolor="lightyellow">
			Mã &#273;&#417;n &#273;&#7863;t hàng :
		</td>	
		<td>
			<%=RS("MaDDH")%> &nbsp;</td>
		<td bgcolor="lightyellow">
			 Ngày t&#7841;o &#273;&#417;n &#273;&#7863;t hàng :
		</td>	
		<td>
			<%=RS("NgayLapDDH")%> &nbsp;</td>
	</tr>
	<tr>
		<td bgcolor="lightyellow">
			Mã m&#7863;t hàng :
		</td>	
		<td>
			<%=RS("MaMH")%> &nbsp;</td>
		<td bgcolor="lightyellow">
			 M&#7863;t hàng :
		</td>	
		<td>
			<%=RS("TenMH")%> &nbsp;</td>
	</tr>
	<tr>
		<td bgcolor="lightyellow">
			S&#7889; l&#432;&#7907;ng &#273;&#7863;t hàng :
		</td>	
		<td>
			<%=RS("SoLuongMH")%> &nbsp;</td>
		<td bgcolor="lightyellow">
			 Shipped(&#272;ã mua):
		</td>	
		<td>
			<%IF isDATE(RS("NgayDatHang")) THEN %>
				<%=RS("NgayDatHang")%>
			<%ELSE%>
			N/A
			END IF
		</td>
	</tr>
	<tr>
		<td bgcolor="lightyellow">
			&#272;&#417;n Giá :
		</td>	
		<td>
			<%=FormCurrency(RS("DonGia"))%> &nbsp;</td>
		<td bgcolor="lightyellow">
			 Order Total :
		</td>	
		<td>
			<%=FormCurrency(RS("SoLuongMH"))*RS("DonGia")%> &nbsp;</td>
	</tr>
	<tr>
		<td bgcolor="lightyellow">
			Credit Card :
		</td>	
		<td colspan=3>
			Tên :<%=RS("Ten_KH_CC")%>
			<br>S&#7889; : <%=RS("So_KH_CC")%> 
			<br>Loai :
			<%
			SELECT CASE RS("Loai_KH_CC")
				CASE "1" Response.Write "Visa"
				CASE "2" Response.Write "MasterCard"
			END SELECT
			%>
			<br>expires :<%=RS("KH_CCexpires")%>
		</td>
	</tr>
	<tr>
		<td bgcolor="lightyellow">
			&#272;&#7883;a ch&#7881; :
		</td>
		<td colspan=3>
			&#272;&#432;&#7901;ng :<%=RS("DuongKH")%>
			<br>Thanh ph&#7889; : <%=RS("TPKH")%> 
			<br>Mã QG(state):<%=RS("Ma_QG_KH")%>
		</td>
	</tr>
	<tr>
		<td colspan=4>
			<table border=1 width="100%" cellpadding=4 cellspacing=0>
				<tr bgcolor="lightgrey">
					<%IF RS("TrangThaiDDH")=0 THEN%>
						<td bgcolor="lightblue">Pending
						</td>
					<%ELSE%>	
					<td>
						<a href="XuLyDDH.asp?HienThiTarng=<%HienThiTrang%>& Ma_DDH=<%=RS("MaDDH")%>& os=0 & HienThiDDH=<%=HienThiDDH%>">Pending
						</a>
					</td>
					<%END IF%>
					<%IF RS("TrangThaiDDH")=1 THEN%>
						<td bgcolor="lightblue">Credit Card Declined
						</td>
					<%ELSE%>	
					<td>
						<a href="XuLyDDH.asp?HienThiTarng=<%HienThiTrang%>& Ma_DDH=<%=RS("MaDDH")%>& os=1 & HienThiDDH=<%=HienThiDDH%>">Credit Card Declined
						</a>
					</td>
					<%END IF%>
					<%IF RS("TrangThaiDDH")=2 THEN%>
						<td bgcolor="lightblue">Not in stock
						</td>
					<%ELSE%>	
					<td>
						<a href="XuLyDDH.asp?HienThiTarng=<%HienThiTrang%>& Ma_DDH=<%=RS("MaDDH")%>& os=2 & HienThiDDH=<%=HienThiDDH%>">Not in stock
						</a>
					</td>
					<%END IF%>
					<%IF RS("TrangThaiDDH")=3 THEN%>
						<td bgcolor="lightblue">Shipped
						</td>
					<%ELSE%>	
					<td>
						<a href="XuLyDDH.asp?HienThiTarng=<%HienThiTrang%>& Ma_DDH=<%=RS("MaDDH")%>& os=3 & HienThiDDH=<%=HienThiDDH%>">Shipped
						</a>
					</td>
					<%END IF%>
				</tr>
			</table>
	</tr>
</table>
<%
RS.MoveNext
WEND
%>
<hr>
<%IF RS.pageCount>1 THEN%>
Trang :
<%
FOR i=1 TO RS.PageCount
IF cINT(HienThiTrang)=i THEN
	%>
	<%=i%>|
	<%ELSE%>
	<a href="XuLyDDH.asp?HienThiTrang=<%=i%>& HienTHiDDH=<%=HienThiDDH%>">
	<%=i%>
	</a>|
	<%
END IF
NEXT
IF allpage<>"" THEN
%>
	T&#7845;t c&#7843;
<%ELSE%>
	<a href="XuLyDDH.asp?HienThiDDH=<%=HienThiDDH%>& allpage=1">
	T&#7845;t c&#7843;
	</a>
<%
END IF
END IF
%>
</body>
</html>