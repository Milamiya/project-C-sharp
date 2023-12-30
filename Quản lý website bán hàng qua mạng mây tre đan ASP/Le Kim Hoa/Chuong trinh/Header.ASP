<%
Username=Trim(Request("Username"))
Password=Trim(Request("Password"))

%>

<body alink="red" vlink="blue" background="FileAnhHoTroWeb/b.jpg">
<table width="100%" hight="50" cellspacing="0" cellspadding="0" height="21">
<tr>
	<td width="20%" align="center" height="43" >
		<img border="0" src="FileAnhHoTroWeb/logoTT.gif" width="78" height="55">
	</td>
	<td width="80%" align="center" height="43" background="FileAnhHoTroWeb/globe.wmf">
		<img border="0" src="FileAnhHoTroWeb/TIEUDE3.GIF" width="590" height="59" align="right">
	</td>
</tr>
<tr>
	<td colspan=2 height="1">
		<Img SRC="FileAnhHoTroWeb\L5.gif" height="3" width="100%" height="4">
	</td>
</tr>
</table>
<table width="764" hight="50" cellspacing="0" cellspadding="0">
<tr>
	<td width="495" align="center" height="24">
		&nbsp;</td>
	<td width="109" align="center" height="24">
		<a target="_parent" href="TrangChu.asp">
		<img border="0" src="FileAnhHoTroWeb/TO.GIF" align="right" width="110" height="24"></a></td>
	<td width="110" align="center" height="24">
		<a target="_parent" href="HuongDanMuaHang.asp">
		<img border="0" src="FileAnhHoTroWeb/HELP.GIF" width="104" height="21" align="right"></a></td>
	<td width="42" align="center" height="24">
		<a title="Gio mua hang" target="_parent" href="KiemTraKH.asp">
		<img border="0" src="FileAnhHoTroWeb/BASKET.GIF" width="36" height="22" align="right"></a></td>
</tr>
</table>
<table border="0" width="679" cellspacing="0" cellpadding="0" height="97">
<tr>
<td valign=top width="160">
	<table cellspacing=0 cellpadding=0 border=1 width="160">
			<tr>
				<td valign=bottom bgcolor=pink width="160">
				<p align="left">
				<img border="0" src="FileAnhHoTroWeb/Timkiem.gif" width="160" height="25"></td>
			</tr>
			<tr>
				<td width="170" valign=bottom bgcolor=lightyellow>
					<form method="post" action="TimKiem.asp" name="frmTimKiem">
						<p align="center">
						<input type="text" name="TimKiem" size="20" >
						<input name="btnsubmit" type="button"  value="Tim kiem" target="_parent" style="float: right">
                        </p>
					</form>
				</td>
			</tr>
	</table>
	<table cellspacing=0 cellpadding=0 border=1 width="1">
			<tr>
				<td valign=bottom bgcolor=pink width="170">
				<p align="left">
				<img border="0" src="FileAnhHoTroWeb/NhomMH.gif" width="160" height="25"></td>
			</tr>
			<tr>
				<td width="160">
					<table width=160 cellpadding=4 cellspacing=0 bgcolor=lightyellow border=0>
						<tr>
							<td width="160">
								<!-- #Include File="DanhSachLH.asp" -->
							</td>
						</tr>
					</table>
				</td>
			</tr>
	</table>
	<table cellspacing=0 cellpadding=0 border=1 width="22">
			<tr>
				<td valign=bottom bgcolor=pink width="170">
				<p align="left">
				<img border="0" src="FileAnhHoTroWeb/khtd.gif" width="160" height="21"></td>
			</tr>
			<tr>
				<td width="160">
					<table width=160 cellpadding=4 cellspacing=0 bgcolor=lightyellow border=0>
						<tr>
							<td width="160">
							<a href="DDHKhachHang.asp">
							<img border="0" src="FileAnhHoTroWeb/DDH.gif" width="123" height="23">
							</a>
							</td>
						</tr>
						</table>
				</td>
			</tr>
	</table>
	<table cellspacing=0 cellpadding=0 border=1 width="120" >
			<tr>
				<td valign=bottom bgcolor=pink height="25" width="170">
				<img border="0" src="FileAnhHoTroWeb/GioiThieuCH.gif" width="160" height="23"></td>
			</tr>
			<tr>
				<td height="32" width="170">
					<table width=159 cellpadding=4 cellspacing=0 bgcolor=lightyellow border=0>
						<tr>
							<td width="147">
							<a target="_parent" href="GioiThieuCuaHang.asp">
							<img border="0" src="FileAnhHoTroWeb/CH.gif" ></a></td>
						</tr>
					</table>
				</td>
			</tr>
	</table>
	<table cellspacing=0 cellpadding=0 border=1 width="44">
			<tr>
				<td valign=bottom bgcolor=pink width="170">
				<p align="left">
				<img border="0" src="FileAnhHoTroWeb/QLCH.gif" width="160" height="25"></td>
			</tr>
			<tr>
				<td width="160">
					<table width=160 cellpadding=4 cellspacing=0 bgcolor=lightyellow border=0>
						<tr>
							<td width="160">
							<a href="DangNhap.asp">
							<img border="0" src="FileAnhHoTroWeb/login.gif"></a></td>
						</tr>
						<tr>
							<td width="160">
							<a href="DoiPassword.asp">
                            <img border="0" src="FileAnhHoTroWeb/DoiP.gif"></a></td>
						</tr>
					</table>
				</td>
			</tr>
	</table>
  </td>
  <td bgcolor="red">
 
  </td>
<Script language=vbscript>
Sub btnSubmit_Onclick()
	IF Len(frmTimKiem.TimKiem.value)=0 Then
		frmTimKiem.TimKiem.focus
	Else
		Call frmTimKiem.Submit()
	End If
End Sub
</script>