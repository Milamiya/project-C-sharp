<%
'Lay ma mat hang
 MaMH=TRIM(Request("pid"))
 SoluongMua=TRIM(Request("SoLuong"))
'Mo ket noi co so du lieu
Set Con=Server.CreateObject("ADODB.Connection")
Con.Open "storeDSN"

'Bo sung mat hang vao gio
IF MaMH<>"" THEN
	sqlString="SELECT MaGio FROM GIOMUAHANG" &_
			" WHERE MaKH= " & MaKH & " AND MaMH= '" & MaMH & "' " 
	SET RS=Con.Execute(sqlString)
	IF RS.EOF THEN
		sqlString="INSERT INTO GIOMUAHANG(MaKH, MaMH, SoLuongMua)" &_ 
			" VALUES ( " & MaKH & " ,'" & MaMH & "', " & SoLuongMua & ") "
		Con.Execute sqlString
	ELSE
		sqlString="UPDATE GIOMUAHANG SET"&_
				"SoLuongMua=" & SoLuongMua &" "&_
				"WHERE MaGio= "& RS("MaGio") & "" 
	END IF
	RS.Close
	SET RS=Nothing
END IF

'Cap nhat so luong gio mua hang
IF Request("updateQ")<>"" THEN
	SET RS=Server.CreateObject("ADODB.Recordset")
	RS.ActiveConnection=Con
	RS.CursorType=adOpenDynamic
	RS.LockType=adLockOptimistic
	sqlString="SELECT MaGio, SoLuongMua FROM GIOMUAHANG "&_
			"WHERE MaKH="& MaKH
	RS.Open sqlString
	WHILE NOT RS.EOF 
		newQ=TRIM(Request ("pq" & RS("MaGio")))
		deleteMH=TRIM(Request("pd" & RS("MaGio")))
		IF newQ="" OR NewQ="0" OR deleteMH<>"" THEN
			RS.Delete
		ELSE
			IF isNumeric(newQ) THEN
				RS("SoLuongMua")=newQ
			END IF
		END IF
		RS.MoveNext
	WEND
	RS.Close
	SET RS=Nothing
END IF

'Xoa sach gio
IF Request("Empty")<>"" THEN
SET RS=Server.CreateObject("ADODB.Recordset")
	RS.ActiveConnection=Con
	RS.CursorType=adOpenDynamic
	RS.LockType=adLockOptimistic
	sqlString="SELECT MaGio FROM GIOMUAHANG "&_
			"WHERE MaKH="& MaKH
	RS.Open sqlString
	WHILE NOT RS.EOF 
		RS.Delete
	RS.MoveNext
	WEND
	RS.Close
	SET RS=Nothing
End If 
%>

<html>

<head>
<title>Gi&#7887; mua hàng</title>
</head>

<!--#Include file="Header.asp"-->
<td  background="FileAnhHoTroWeb/BlowBlueSand.jpg">
<table border=0 height="417" width="593">
<center>
<tr>
<td height="248" width="598">
<table width="589" height="62">
<tr>
<td width="583" height="20">
<p align="center">
<font face="Times New Roman" size=4 color="#000080" >
<b>Gi&#7887; mua hàng c&#7911;a <%=Username%> </b>
</font>
</td>
</tr>
<%
sqlString="SELECT * FROM  GIOMUAHANG " &_
		"WHERE MaKH= " & MaKH & " "
SET RS1=Con.Execute (sqlString)

IF RS1.EOF THEN
%><font face="Times New Roman"> </font>
<tr>
<td width="583" height="34">
<p align="left">
<b>
<font size="4" face="Times New Roman">không có m&#7863;t hàng nào c&#7843;, xin m&#7901;i quí khách ch&#7885;n hàng 
cho vào gi&#7887; r&#7891;i ti&#7871;n hành &#273;&#7863;t hàng. C&#7843;m &#417;n !!!</font></b><p align="left">
</td>
</tr>
<tr>
<td height="63" width="583">
</td>
</tr>
</table>
<%
ELSE
TongCong=0
%> 
<table bgcolor="lightyellow" border=1 cellpadding=4 cellspacing=0 width="586" height="162">
<form method="post" action="KiemTraKH.asp" name="frmGMH">
	<font face="Times New Roman">
	<input name="updateQ" type="hidden" value="1">
	<input name="Username" type="hidden" value="<%=Username%>">
	<input name="Password" type="hidden" value="<%=Password%>">
    </font>
<tr bgcolor="lightgreen">
	<th width="42" height="28"><font face="Times New Roman"><span style="font-weight: 400">Mã </span>
    </font></th>
	<th width="149" height="28"><font face="Times New Roman"><span style="font-weight: 400">Tên M&#7863;t Hàng</span></font></th>
	<th width="109" height="28"><font face="Times New Roman"><span style="font-weight: 400">&#272;&#417;n Giá (VND)</span></font></th>
	<th width="65" height="28"><font face="Times New Roman"><span style="font-weight: 400">S&#7889; L&#432;&#7907;ng</span></font></th>
	<th width="108" height="28"><font face="Times New Roman"><span style="font-weight: 400">Thành Ti&#7873;n</span></font></th>
	<th width="61" height="28"><font face="Times New Roman"><span style="font-weight: 400">Ch&#7885;n </span></th>
</tr>
<%
WHILE NOT RS1.EOF 
sqlString="SELECT TenMH, DonGia FROM  MATHANG " &_
		"WHERE MaMH= '" & RS1("MaMH") & "' "
SET RS2=Con.Execute (sqlString)

TT=RS2("DonGia")*RS1("SoLuongMua")
TongCong=TongCong+TT
%> </font>
<tr>
	<td width="42" height="22">
	<%=server.HTMLEncode(RS1("MaMH"))%><font face="Times New Roman"> </font>
    <p align="left">&nbsp;</td>
	<td width="149" height="22">
	<%=server.HTMLEncode(RS2("TenMH"))%><font face="Times New Roman"> </font>
    <p align="left">&nbsp;</td>
	<td width="109" height="22">
	<%=formatCurrency(RS2("DonGia"))%><font face="Times New Roman"> </font>
    <p align="center">&nbsp;</td>
	<td width="65" height="22">
	<p align="center">
	<font face="Times New Roman">
	<input name="pq<%=RS1("MaGio")%>" type="text" size=3 value="<%=RS1("SoLuongMua")%>"></font></td>
	<td width="108" height="22">
	<%=formatCurrency(TT)%><font face="Times New Roman"> </font>
    <p align="center">&nbsp;</td>
	<td width="61" height="22">
	<font face="Times New Roman">
	<input name="pd<%=RS1("MaGio")%>" type="checkbox" value="1">Delete
	</td>
</tr>
<%
RS1.MoveNext

WEND
%> </font>
<tr bgcolor="yellow">
	<td colspan=4 align=right width="395" height="19">
	<font face="Times New Roman">
	<b>T&#7893;ng c&#7897;ng :</b> </font>
	</td>
	<td colspan=2 width="158" height="19">
	<%=formatCurrency(TongCong)%><font face="Times New Roman"> </font>&nbsp;</td>
</tr>
<tr>
 	<td colspan=6 width="102" height="26">
		<font face="Times New Roman">
		<input type="submit" name="btnsubmit" value="Cap Nhat !" style="float: left" target="_parent">
        </font>
	</td>
</tr>
</form>
<tr>
	<td colspan=6 width="376" width="240" height="17">
	<table border=0>
	<tr>
		<form method="post" action="KiemTraKH.asp">
			<font face="Times New Roman">
			<input name="Username" type="hidden" value="<%=Username%>">
			<input name="Password" type="hidden" value="<%=Password%>">
			<input name="Empty" type="hidden" value="1">
			</font>
			<td>
				<font face="Times New Roman">
				<input type="submit" value="Xoa Sach gio !" target="_parent">
                </font>
			</td>
		</form>
		<form method="post" action="KiemDinh.asp">	
			<font face="Times New Roman">	
			<input name="Username" type="hidden" value="<%=Username%>">
			<input name="Password" type="hidden" value="<%=Password%>">
			<input name="MaKH" type="hidden" value="<%=MaKH%>">
			</font>
			<td >
				<font face="Times New Roman">
				<input type="submit" value="Kiem Dinh !" target="_parent">
			</td>
		</form>
	</tr>
	</table>
	</td>
</tr>
</table>
</td>
</tr>
<tr>
<td  height="211" width="598">
</td>
</tr>
<% END IF %>
</center>
</table>
</td>
<!--#Include file="Footer.asp"-->

</body>
</html>
</font>
<Script language=vbscript>