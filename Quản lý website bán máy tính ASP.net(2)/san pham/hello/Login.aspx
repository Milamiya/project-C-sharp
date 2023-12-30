<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="hello_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Website máy tính</title>
    <link rel="SHORTCUT ICON " href="~/images/businessman.ico" />
    <style>
    .table
    {
        -moz-border-radius-topleft:20px;
        -moz-border-radius-topright:20px;
        -moz-border-radius-bottomright: 20px;
	    -moz-border-radius-bottomleft: 20px;
        height:200px;
        width:339px;
        text-align:center; 
        border:1px solid black;
    	}
    .div
    {    	
        width:339px;
        text-align:center; 
    	}               
        .style1
        {
            width: 600px;
            height: 221px;
        }
              
    </style>
</head>
<body style="background-color:White;padding:100px 0px 0px 0px;">
    <center>
    <form id="form1" runat="server">    
    <table class="style1" align="center">
        <tr>
            <td rowspan="6">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/login_icon.gif" 
                    ImageAlign="Left" Width="288px" />
            </td>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" 
                    Text="ĐĂNG NHẬP" Font-Size="X-Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-family:Tahoma">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Tài khoản:" 
                    Font-Size="Small"></asp:Label>
            </td>
            <td style="padding-right:100px;">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-family:Tahoma">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Mật khẩu:" 
                    Font-Size="Small"></asp:Label>
            </td>
            <td style="padding-right:100px;">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Tự động đăng nhập" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btLogin" runat="server" Height="26px" Text="OK" 
                    Width="83px" OnClick="btLogin_Click" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Hủy" Width="56px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lbThongBao" runat="server" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
    </table>    
    </form>
    <%--<table class="table">        
        <tr>
            <td class="a" colspan="2" ><h3>ĐĂNG NHẬP</h3></td>            
        </tr>
        <tr>
            <td>Tên đăng nhập</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtPass" ErrorMessage="Chưa điền tên đăng nhập!">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Mật khẩu</td>
            <td><asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPass" ErrorMessage="Chưa điền mật khẩu!">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height:10px;"></td>
        </tr>
        <tr>        
            <td style="padding-left:50px;">
                <asp:Button ID="btLogin" runat="server" Text="Đăng nhập" 
                    onclick="btLogin_Click"/>
            </td>
            <td style="padding-right:50px;">
                <asp:Button ID="btHuy" runat="server" Text="Hủy" />
            </td>
        </tr>
    </table>
    <div class="div" style="height:auto;">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>--%>
    </center>
</body>
</html>
