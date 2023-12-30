<html>
<%session.codepage=65001%>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Tra cuu theo chuyen nganh</title>
</head>

<body background="HINH%20ANH/nen1.jpg">
<img src="HINH%20ANH/banner3.jpg" width="100%" height=180>
			<!--#include file="ketnoi.inc"-->
 <%nd=session("nd")
 mk=session("mk")
 sql="select * from tbldangnhap"
 sql=sql & " where nguoidung= '"& nd &"' and  matkhau='"& mk &"'"
 set rs = cn.execute(sql)
 if   rs.eof then
    response.redirect("login.htm")
    else
         if trim(rs("nguoidung"))<>"admin" then%>
<table >
<td valign=top width=820>
<!-- Begin Vista-Buttons.com -->
<script type="text/javascript" src="tracuu1-files/scwyo7i.js"></script>
<table id="vista-buttons.com:idwyo7i" width=0 cellpadding=0 cellspacing=0 border=0><tr><td style="padding-right:0px" title ="Theo chuyên ngành">
<a href="tccn1.asp" onMouseOver='xpe("wyo7io");' onMouseOut='xpe("wyo7in");' onMouseDown='xpe("wyo7ic");'><img id="xpi_wyo7i" src="tracuu1-files/btwyo7i_0.gif" name=vbwyo7i width="155" height="28" border=0 alt="Theo chuyên ngành"></a></td><td style="padding-right:0px" title ="Theo lóp">
<a href="tracuulop.asp" onMouseOver='xpe("4yo7io");' onMouseOut='xpe("4yo7in");' onMouseDown='xpe("4yo7ic");'><img id="xpi_4yo7i" src="tracuu1-files/bt4yo7i_0.gif" name=vb4yo7i width="160" height="28" border=0 alt="Theo lóp"></a></td><td style="padding-right:0px" title ="Theo tu khóa ">
<a href="tcthu.asp" onMouseOver='xpe("zyo7io");' onMouseOut='xpe("zyo7in");' onMouseDown='xpe("zyo7ic");'><img id="xpi_zyo7i" src="tracuu1-files/btzyo7i_0.gif" name=vbzyo7i width="160" height="28" border=0 alt="Theo tu khóa "></a></td></tr></table>
<noscript><a href="http://vista-buttons.com">Hover Buttons by Vista-Buttons.com v2.27</a></noscript>
<!-- End Vista-Buttons.com -->
<table>
<td valign=top width=210> 	
<img src="HINH%20ANH/anh9.gif" width="70%" height=120>
<img src="HINH%20ANH/anh2.gif" width="70%" height=190>
<img src="HINH%20ANH/TIMKIEM.gif" width="70%" height=130>
<img src="HINH%20ANH/hocmai.jpg" width="70%" height=120>
</td>
<td valign=top>
        <!--#include file="ketnoi.inc"-->
     <%
    sql="select * from dsdtcn2"
    sql=sql & " where ID_chuyennganh= '"&request("tl")&"' "
    set rs = cn.execute(sql)

    do while not rs.eof

    %>
    <table border="0" width="100%">
	<tr>
		<td><img src="HINH%20ANH/sach.jpg" width="50" height=50></td>
		<td valign=top> <a href="<%=rs("URL")%>"> 
		<font size=1 ><b> <%=rs("tendetai")%></b></font></a>
        <br><font size=1 > <%=rs("tomtat")%></font>
       </td>
	</tr>
   </table>
	 <% rs.movenext
   loop
end if%>

</td>
<td valign=top>

</table>
</td>
<td valign=top> <!--#include file="right.asp"--></td>
</table>
<%    end if%>

</body>

</html>










