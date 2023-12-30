<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dathang.aspx.cs" Inherits="PKT.dathang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style1
        {
            font-size: small;
        }

    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="same">
    <div id="tt">
    <div id="tt-o">CHỌN HÀNG</div>
    <div id="tt-o">ĐẶT HÀNG</div>
    <div id="tt-o">XÁC NHẬN</div>
    </div>
    <div id="same-1"> <p><strong>THÔNG TIN ĐẶT HÀNG</strong><br />Nếu bạn có tài khoản thì vui lòng đăng nhập <a href="khachhang_dangnhap.aspx">tại đây.</a> </p>
        <div id="re1">Họ và tên: <p4>*</p4> 
                <p>CMND: <p4>*</p4></p>
                <p>Địa Chỉ: <p4>*</p4></p>
                <p>Số Điện Thoại: <p4>*</p4></p>
                <p>Email:</p>
                <p>Ghi Chú:</p>
            </div>
            <div id="re2">
                    <asp:TextBox ID="ten" runat="server" AutoPostBack="True" TabIndex="4" 
                        Width="200px" ontextchanged="ten_TextChanged"></asp:TextBox>
                <asp:Label ID="e1" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
&nbsp;<p>
                    <asp:TextBox ID="cmnd" runat="server" AutoPostBack="True" TabIndex="7" 
                        Width="200px" ontextchanged="cmnd_TextChanged"></asp:TextBox>
                    <asp:Label ID="e2" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="diachi" runat="server" AutoPostBack="True" TabIndex="9" 
                        Width="200px" ontextchanged="diachi_TextChanged"></asp:TextBox>
                    <asp:Label ID="e3" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="dt" runat="server" AutoPostBack="True" TabIndex="10" 
                        Width="200px" ontextchanged="dt_TextChanged"></asp:TextBox>
                    <asp:Label ID="e4" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="email" runat="server" AutoPostBack="True" TabIndex="11" 
                        Width="200px" ontextchanged="email_TextChanged"></asp:TextBox>
                    <asp:Label ID="e5" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="TextBox1" runat="server" Height="112px" TextMode="MultiLine" 
                        Width="326px"></asp:TextBox>
                </p>
				<p style="height: 24px">
                    <asp:CheckBox ID="check" runat="server" TabIndex="12" Text=" " />
                    <span class="style1">Tạo tài khoản trên PKTPhone. (Pass sẽ được gửi vào email của bạn).</span></p>
                <p>
                    <asp:Button ID="buttom_next" runat="server" 
                        TabIndex="13" Text="Tiếp tục" onclick="buttom_next_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Xóa" />
                </p>
                <p>
                    <br />
                    <asp:Label ID="e6" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    &nbsp;</p>
            </div>
            <div id="r3">PKTPhone.com cam kết áp dụng mức bảo mật cao nhất thông tin Quý khách đặt hàng.</div> 
    </div>
</div>
</asp:Content>
