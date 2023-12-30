<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="test.ascx.cs" Inherits="TestOnline.hy.vn.Control.Manager.test" %>
<style type="text/css">
    .ListPage_border
    {
        font: 500 14px Arial;
        width: 708px;
        border: solid 1px gray;
        border-top: none;
        border-bottom-left-radius: 8px;
        border-bottom-right-radius: 8px;
        height: 70px;
    }
</style>

<script type="text/javascript">

var mins
var secs;
function cd() {
var thoigian=document.getElementsByName("thoigian");
if(thoigian.length==1)
{
mins=1*m[thoigian[0].value];
}
else
{
mins=1*m("10");
}
 	secs = 0 + s(":01"); 
 	redo();
}
function m(obj) {
 	for(var i = 0; i < obj.length; i++) {
  		if(obj.substring(i, i + 1) == ":")
  		break;
 	}
 	return(obj.substring(0, i));
}
function s(obj) {
 	for(var i = 0; i < obj.length; i++) {
  		if(obj.substring(i, i + 1) == ":")
  		break;
 	}
 	return(obj.substring(i + 1, obj.length));
}
kt=true;

function dis(mins,secs) {
 	var disp;
 	if(mins <= 9) {
  		disp = " 0";
 	} else {
  		disp = " ";
 	}
 	disp += mins + ":";
 	if(secs <= 9) {
  		disp += "0" + secs;
 	} else {
  		disp += secs;
 	}
 	return(disp);
}

function redo() {
   if(kt==true)
   {
 	secs--;
 	if(secs == -1) {
  		secs = 59;
  		mins--;
 	}
 	document.getElementById("txt1").value = dis(mins,secs);
 	if((mins == 0) && (secs == 0)) {
  		window.alert("Hết giờ.Nhấn OK để nộp bài ."); 
  		ketqua();
  		document.getElementById("Button1").disabled="disabled";
 	} else {
 		cd = setTimeout("redo()",1000);
 	}
 	}
}
function an()
{
  		kt=false;
  		document.getElementById("Button1").disabled="disabled";
}
function init() {
  cd();
}
window.onload = init;
</script>

<script type="text/javascript">
function ketqua()
{
  		an();
var a=document.getElementsByTagName("input");var j=0;var sd=0;var ss=0;
for(var i=0;i<a.length;i++)
{
if(a[i].name=="dapan")
{
j++;
var b=document.getElementsByName(j.toString());
var c=document.getElementsByName("phuongan"+j.toString());
for(var l=0;l<b.length;l++)
{
if(b[l].value==a[i].value)
{
 c[l].style.color="Blue";
}
 if(b[l].checked==true)
 {
 if(b[l].value!=a[i].value)
 {
 c[l].style.color="Red";
 ss++;
 }
 else
 sd++;
}
}
}
}
document.getElementById("Text1").value=sd.toString();
document.getElementById("Text2").value=ss.toString();

}
</script>

<div id="di" style="position: fixed">
    <input id="txt1" readonly="true" type="text" value="15:00" border="0" name="disp">
</div>
<div style="width: 710px; border-top-left-radius: 8px; border-top-right-radius: 8px;
    text-align: left; height: 25px; background-repeat: repeat-x; background-image: url('../Images/menu_title1.gif')">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/70px-Logo_book2.png'">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-top: 5px;">
        Thông tin thí sinh dự thi
    </div>
</div>
<div class="ListPage_border">
    <br />
    <table style="width: 100%">
        <tr>
            <td>
                Họ và tên:<asp:Label runat="server" ID="lblFullName"></asp:Label>
            </td>
            <td>
                Thời gian thi: 90 phút
            </td>
            <td>
                Số câu đúng: 0
            </td>
        </tr>
        <tr>
            <td>
                Môn thi: <asp:Label ID="lblSubject" runat="server"></asp:Label>
            </td>
            <td>
                Đề số: <asp:Label ID="lblThread" runat="server"></asp:Label>
            </td>
            <td>
                Số câu sai: 0
            </td>
        </tr>
    </table>
</div>
<div style="width: 710px; border-top-left-radius: 8px; border-top-right-radius: 8px; margin-top:5px;
    text-align: left; height: 25px; background-repeat: repeat-x; background-image: url('../Images/menu_title1.gif')">
    <div style="float: left; height: 30px; width: 30px; background-image: url('../Images/70px-Logo_book2.png'">
    </div>
    <div style="float: left; color: White; font: 500 15px Arial; padding-top: 5px;">
        Danh sách câu hỏi
    </div>
</div>
<table style=" font: 500 14px Arial; margin-top:-5px;
        width: 709px;
        border: solid 1px gray;
        border-top: none;
        border-bottom-left-radius: 8px;
        border-bottom-right-radius: 8px;">
    <tr>
        <td style="padding-left:5px">
            <div>
                <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Label"></asp:Label>
            </div>
        </td>
    </tr>
</table>
<asp:Label ID="Label2" runat="server"></asp:Label>
<div style="float:right; padding-right:15px; margin-top:5px">   <input id="Button1" type="button" value="Nộp bài thi" onclick="ketqua()" /></div>
