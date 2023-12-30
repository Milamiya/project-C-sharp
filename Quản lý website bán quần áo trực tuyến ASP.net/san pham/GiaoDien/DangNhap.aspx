<%@ Page Language="C#" MasterPageFile="~/UserControl/NguoiDung.master" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="GiaoDien_DangNhap" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="khung-giua">
        <div class="title-giua-top">Đăng Nhập</div>
<div style="background-color:#f7f7f7;border:1px solid #DDD;margin:10px;padding:10px">        
<table>
    <tr>
        <td>Tên đăng nhập:</td>
        <td><asp:TextBox runat="server" ID="txtTenDN" Width="150px"></asp:TextBox></td>
        <td style="color:#f6358a">(*)</td>
    </tr>
    <tr>
        <td>Mật khẩu:</td>
        <td><asp:TextBox runat="server" ID="txtMK" Width="150px"></asp:TextBox></td>
        <td style="color:#f6358a">(*)</td>
    </tr>
    <tr>
        <td></td>
        <td><asp:CheckBox runat="server" ID="ckGhinhoMK" Text="Ghi nhớ mật khẩu" /></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button runat="server" ID="btnOK" Text="OK" BackColor="#00CC00" 
                ForeColor="Black" Width="61px" onclick="btnOK_Click" /></td>
    </tr>
</table>
</div>
    <div style="margin:10px auto auto 5px;">Nếu bạn chưa có tài khoản hãy sở hữu một tài 
        khoản cho mình bằng cách:
    <input type="button" value="Đăng ký" id="btDK" 
            style="background-color:#00cc00;padding-top:5px" />
    </div>
</div>
<script language="javascript" type="text/javascript">
// <!CDATA[

function btDK_onclick() {

}

// ]]>
</script>
</asp:Content>

