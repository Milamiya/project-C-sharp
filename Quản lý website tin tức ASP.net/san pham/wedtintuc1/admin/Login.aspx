<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        .style1
        {
            width: 120px;
            height: 20px;
        }
        .style2
        {
            width: 280px;
            height: 20px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br/><br/><br/><br/><br/>
    </div>
    <table align="center" cellpadding="0" cellspacing="0" class="TableCenter">
        <tr>
            <td colspan="2" class="divframe_head" align="center">
                Đăng nhập</td>
        </tr>
        <tr>
            <td colspan="2" style="height:30px">
                </td>
        </tr>
        <tr>
            <td align="left" class="style1" style="padding-left:10px">
                Tên đăng nhập</td>
            <td align="left" class="style2">
                <asp:TextBox ID="txtUserName" CssClass="textboxLogin" Width="150px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  align="left" class="style1" style="padding-left:10px">
                mật khẩu</td>
            <td align="left" class="style2">
                <asp:TextBox ID="txtPassWord" TextMode="Password" CssClass="textboxLogin" Width="150px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  align="center" style="height:38px" valign="bottom" colspan="2">
                <asp:Button ID="btlogin" CssClass="Login" runat="server" Text="Đăng nhập" 
                    onclick="btlogin_Click" />
            </td>
        </tr>
        <tr>
            <td  style="width:120px"align="left">
                &nbsp;</td>
            <td style="width:280px" align="left">
                &nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
