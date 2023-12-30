<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DoAn4.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <style type="text/css">
        .khung
        {
            border: solid black 1px;
            width: 254px;
            height: 180px;
            margin-top:200px;
        }
        .daukhung
        {
            background-color: Olive;
            height: 25px;
            color: White;
            text-align: center;
            padding-top: auto;
        }
        .style1
        {
            width: 100%;
        }
        .style2
        {
            background-color: Olive;
            height: 25px;
            color: White;
            text-align: center;
            padding-top: auto;
            font-family: Arial;
            font-size: medium;
            line-height:1.5em;
        }
        .style3
        {
            font-family: Arial;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <div class="khung">
            <div class="style2">
                ĐĂNG NHẬP</div>
                <br />
            <table cellpadding="2" class="style1">
                <tr>
                    <td align="right" width="30%" class="style3">
                        &nbsp;
                        Username:</td>
                    <td align="left">
                        <asp:TextBox ID="txtuser" runat="server" Width="132px"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="30%" class="style3">
                        Password:&nbsp;
                    </td>
                    <td align="left" width="50%">
                        <asp:TextBox ID="txtpass" runat="server" Width="132px"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center" class="style3">
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            <div align="center">
                <asp:Button ID="Button1" runat="server" Text="Đăng nhập" onclick="Button1_Click" 
                    />
            </div>
        </div>
    </center>
    </form>
</body>
</html>
