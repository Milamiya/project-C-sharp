<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuenMatKhau.aspx.cs" Inherits="admin_QuenMatKhau" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Quên mật khẩu</title>
    <style type="text/css">
        .style2
        {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .Button
        {
            font-size: 12px;
            background: #FFFFFF;
            border-bottom: 1px solid #104A7B;
            border-right: 1px solid #104A7B;
            border-left: 1px solid #AFC4D5;
            border-top: 1px solid #AFC4D5;
            color: #000000;
            font-weight: bold;
            text-decoration: none;
            cursor: hand;
            font-style: normal;
            font-variant: normal;
            line-height: normal;
            font-family: tahoma, verdana, geneva, lucida, "lucida grande" , arial, helvetica, sans-serif;
        }
        .style4
        {
            width: 371px;
        }
        .style5
        {
            width: 369px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table cellpadding="0" cellspacing="0" class="style2" 
            style="border-color: #C0C0C0" width="300px">
            <tr>
                <td colspan="2" colspan="2" align="center" bgcolor="#006699" style="color: #FFFFFF;
                    font-weight: bold;">
                    Quên Mật Khẩu
                </td>
            </tr>
            <tr>
                <td align="right" class="style5">
                    Tên đăng nhập:
                </td>
                <td align="left" class="style4">
                    <asp:TextBox ID="txtTenDN" runat="server" Width="150px" 
                        style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style5">
                    Email:
                </td>
                <td align="left" class="style4">
                    <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="butXacNhan" runat="server" Text="Xác Nhận" CssClass="Button" 
                        Width="150px" onclick="butXacNhan_Click" />
                    <br />
                    <asp:Label ID="lblThongBao" runat="server"></asp:Label>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
