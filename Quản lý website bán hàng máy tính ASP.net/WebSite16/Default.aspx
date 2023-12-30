<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<script language="javascript">
var i=1;
var t;
function Timer()
{
    var name = " Vu thanh binh - C1008L - Admin C1008L.com - Chuc moi nguoi hoc tap tot.";
    document.getElementById('lbl').innerHTML += name.charAt(i++);
    
    t = setTimeout("Timer()",60);
    if (i>name.length)
    {
        clearTimeout(t);
        document.getElementById('lbl').innerHTML += 'Done!';
    }
}
</script>
</head>

<body onload="Timer()">
<label id="lbl"></label>
</body>
</html>