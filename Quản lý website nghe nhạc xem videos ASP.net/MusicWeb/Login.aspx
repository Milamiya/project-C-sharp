<%@ Page Language="C#" Title="Tam anh music" MasterPageFile="~/Master_Log.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<a href="">
    <img src="img_QuangCao/Arsenal.png" width="100%" /> </a>
</div>
<div class="login">
<div class="_tieude" >ĐĂNG NHẬP</div>
<div class="_noidung">
<div>
    <span style="color: #FFFFFF"><strong>UserName </strong></span> <br />
    <center><asp:TextBox ID="txt_user"  runat="server" CssClass="txt__txt" placeholder="UserName" autocomplete='off' Font-Size="13px" ForeColor="#666666" Width="250" Height="22"></asp:TextBox>
    </center>
    <p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txt_user" ErrorMessage="Bạn chưa nhập tài khoản .."></asp:RequiredFieldValidator>
    </p>
</div>
<div >
    <span style="color: #FFFFFF"><strong>PassWord </strong></span> <br />
    <center>
        <asp:TextBox ID="txt_pass"  runat="server" CssClass="txt__txt" 
            placeholder="PassWord" TextMode="Password" autocomplete='off' Font-Size="13px" ForeColor="#666666" 
            Width="250" Height="22"></asp:TextBox>
    </center>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Bạn chưa nhập mật khẩu" ControlToValidate="txt_pass"></asp:RequiredFieldValidator>
    </p>
</div>
<div class="buttom" > 
<center><asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/img_button/dangnhap.jpg" Width="50%" 
        onclick="ImageButton1_Click" /></center>
 <a href=""><img src="img_button/quenmatkhau.png" width="49%" height="35px" /></a>
 <a href="Regirter.aspx"><img src="img_button/dangky.jpg" width="49%" height="35px" /> </a>
</div>
</div> 

</div>
</asp:Content>

