<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="khachhang_dangnhap.aspx.cs" Inherits="PKT.khachhang_dangnhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="same">
    <div id="re">
    <div id="tt-o">ĐĂNG NHẬP</div>
    </div>
    <div id="same-1">
        <div id="cus">
            <div id="cus-1">
                <p>Email:</p>
                <p>Password:</p>
            </div>
            <div id="cus-2">
                <p><asp:TextBox ID="username" runat="server" Width="190px" BorderColor="#FF9933" 
                        BorderStyle="Solid"></asp:TextBox></p>
                <p><asp:TextBox ID="pass" runat="server" ontextchanged="pass_TextChanged" 
                        Width="190px" BorderColor="#FF9933" BorderStyle="Solid" 
                        TextMode="Password"></asp:TextBox></p>
            </div>
            <div id="cus-3">
                &nbsp;<asp:Button ID="login" runat="server" onclick="login_Click" 
                    Text="Đăng nhập" />
                <br />
                <p7> <a href="dangky.aspx"> Đăng ký</a> | <a href="dangky.aspx"> Quên mật khẩu </a></p7>
                <br />
                <asp:Label ID="error" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
            </div>
        </div>
    </div>
</div>
</asp:Content>
