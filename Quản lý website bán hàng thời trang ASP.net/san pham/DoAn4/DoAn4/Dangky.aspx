<%@ Page Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true"
    CodeBehind="Dangky.aspx.cs" Inherits="DoAn4.WebForm6" Title="Đăng ký" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            width: 22%;
        }
    .style4
    {
        color: #FF0000;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Con1" runat="server">
<div class="daukhungmain">
<asp:Label ID="Label2" runat="server" Text="ĐĂNG KÍ TÀI KHOẢN" Font-Names="Arial" 
        Font-Size="Large" ForeColor="Black"></asp:Label>
</div>
<div class="khungthanhtoan">
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label4" runat="server" Text="Thông tin cá nhân" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        Tên đầy đủ:
                    </td>
                    <td>
                        <asp:TextBox ID="txtTendaydu" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="style3">
                        Địa chỉ:
                    </td>
                    <td>
                        <asp:TextBox ID="txtDiachi" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Quận/Huyện:</td>
                    <td>
                        <asp:TextBox ID="txtQuanHuyen" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Tỉnh/Thành phố:</td>
                    <td>
                        <asp:TextBox ID="txtTinhThanh" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Quốc gia:</td>
                    <td>
                        <asp:TextBox ID="txtQuocGia" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Số điện thoại:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSDT" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Email:
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="220px" 
                            ontextchanged="TextBox4_TextChanged"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtEmail" ErrorMessage="Email không đúng định dạng" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
        <div class="khungthanhtoan">
        <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td class="style3">
                        <asp:Label ID="Label3" runat="server" Text="Thông tin cá nhân" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        <span class="style4">*</span>
                        Tên đăng nhập:
                    </td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        <span class="style4">* </span>Mật khẩu:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" Width="220px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="style3">
                        <span class="style4">* </span>Xác nhận mật khẩu:
                    </td>
                    <td>
                        <asp:TextBox ID="RePass" runat="server" Width="220px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        
        <center>
            <asp:Label ID="Label1" runat="server" Text="" style="color: #FF0000"></asp:Label><br />
            <asp:Button ID="btnDangky" runat="server" Text="Đăng ký" 
                onclick="btnDangky_Click" />
        </center>
        
    
</asp:Content>
