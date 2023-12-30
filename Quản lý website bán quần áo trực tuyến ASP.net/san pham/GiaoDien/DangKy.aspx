<%@ Page Language="C#" MasterPageFile="~/UserControl/NguoiDung.master" AutoEventWireup="true" CodeFile="DangKy.aspx.cs" Inherits="GiaoDien_DangKy" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="khung-giua">
    <div class="title-giua-top">Đăng Ký Tài Khoản</div>
    <div><p style="padding:5px;">Nếu bạn đã có tài khoản vui lòng &nbsp<a href="#">Đăng nhập</a></p>
    <b style="margin-bottom: 2px; display: block;padding-left:7px;"> Thông tin cá nhân</b>
    <div style="background-color:#f7f7f7;border:1px solid #DDD;margin:10px;padding:10px">
    <table>
        <tr>
            <td style="width:150px">Họ tên:</td>
            <td><input type="text" id="txtTen" /></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td><asp:TextBox runat="server" ID="txtEmail"></asp:TextBox></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
        <tr>
            <td>Điện thoại:</td>
            <td><input type="text" id="txtDienThoai" /></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
    </table>
    </div>
    <b style="margin-bottom: 2px; display: block;padding-left:7px;">Địa chỉ</b>
    <div style="background-color:#f7f7f7;border:1px solid #DDD;margin:10px;padding:10px">
    <table>
        <tr>
            <td style="width:150px;">Địa chỉ 1:</td>
            <td><input type="text" id="txtDC1" /></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
        <tr>
            <td>Địa chỉ 2:</td>
            <td><input type="text" id="txtDC2" /></td>
            
        </tr>
        <tr>
            <td>Thành phố:</td>
            <td><input type="text" id="txtTP" /></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
    </table>
    </div>
    <b style="margin-bottom: 2px; display: block;padding-left:7px;">Mật khẩu</b>
    <div style="background-color:#f7f7f7;border:1px solid #DDD;margin:10px;padding:10px">
    <table>
        <tr>
            <td style="width:150px;">Mật khẩu:</td>
            <td><input type="text" id="txtMK" /></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
        <tr>
            <td>Nhập lại mật khẩu:</td>
            <td><input type="text" id="txtNhapLaiMK" /></td>
            <td style="color:#f6358a">(*)</td>
        </tr>
    </table>
    </div>
    <div style="margin:auto auto 10px 5px;">
        <p><asp:CheckBox runat="server" ID="ckDangKi" Text="" /> Tôi đã đọc và đồng ý với các &nbsp<a href="#">Quy định</a>&nbsp&nbsp&nbsp<asp:Button 
                runat="server" ID="btnDangKi" Text="Đăng ký" onclick="btnDangKi_Click" /></p>
    </div>
    <div>
        <asp:Label runat="server" ID="lbThongBao"></asp:Label>
    </div>
    </div>
    
</div>
</asp:Content>

