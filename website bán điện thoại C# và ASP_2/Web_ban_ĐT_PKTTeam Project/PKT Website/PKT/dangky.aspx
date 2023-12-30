<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="PKT.dangky" MaintainScrollPositionOnPostBack = "true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="same">
    <div id="re">
    <div id="tt-o">ĐĂNG KÝ</div>
    </div>
        <div id="same-1"> <strong>ĐĂNG KÝ THÀNH VIÊN</strong>
            <div>
            <div id="re1">Họ và tên: <p4>*</p4> 
                <p>Ngày Sinh: <p4>*</p4></p>
                <p>Giới Tính: <p4>*</p4></p>
                <p>CMND: <p4>*</p4></p>
                <p>Địa Chỉ: <p4>*</p4></p>
                <p>Số Điện Thoại: <p4>*</p4></p>
                <p>Email: <p4>*</p4></p>
                <p>Password: <p4>*</p4></p> 
                <p>Cofirm Password: <p4>*</p4></p>
                <p>Điều khoản:</p>
            </div>
            <div id="re2">
                    <asp:TextBox ID="ten" runat="server" AutoPostBack="True" TabIndex="1" 
                        Width="200px" ontextchanged="ten_TextChanged"></asp:TextBox>
                    <asp:Label ID="e4" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
&nbsp;<p>&nbsp;<asp:DropDownList ID="ngay" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ngay_SelectedIndexChanged" Width="40px" 
                        TabIndex="2">
                    </asp:DropDownList>
&nbsp;<asp:DropDownList ID="thang" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="thang_SelectedIndexChanged" Width="40px" 
                        TabIndex="3">
                    </asp:DropDownList>
&nbsp;<asp:DropDownList ID="nam" runat="server" onselectedindexchanged="nam_SelectedIndexChanged" 
                        Width="60px" TabIndex="4">
                    </asp:DropDownList>
                </p>	
                <p>
                    <asp:RadioButton ID="Male" runat="server" Text="Nam" GroupName="gt" />
                    <asp:RadioButton ID="Female" runat="server" Text="Nữ" GroupName="gt" />
                </p>
                <p>
                    <asp:TextBox ID="cmnd" runat="server" AutoPostBack="True" TabIndex="5" 
                        Width="200px" ontextchanged="cmnd_TextChanged"></asp:TextBox>
                    <asp:Label ID="e5" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="diachi" runat="server" AutoPostBack="True" TabIndex="6" 
                        Width="200px" ontextchanged="diachi_TextChanged"></asp:TextBox>
                    <asp:Label ID="e6" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="dt" runat="server" AutoPostBack="True" TabIndex="7" 
                        Width="200px" ontextchanged="dt_TextChanged"></asp:TextBox>
                    <asp:Label ID="e7" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="email" runat="server" AutoPostBack="True" TabIndex="8" 
                        Width="200px" ontextchanged="email_TextChanged"></asp:TextBox>
                    <asp:Label ID="e8" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="pass" runat="server" AutoPostBack="True" TabIndex="9" 
                        Width="200px" ontextchanged="pass_TextChanged"></asp:TextBox>
                    <asp:Label ID="e2" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="cofirm" runat="server" AutoPostBack="True" 
                        ontextchanged="cofirm_TextChanged" TabIndex="10" Width="200px"></asp:TextBox>
                    <asp:Label ID="e3" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p><textarea style="height: 114px; width: 314px">1.1. Điều khoản thanh toán kiểm soát chủ yếu các rủi ro trong thanh toán

Các rủi ro tài chính (trong xuất khẩu) có thể được kiểm soát bằng cách:

Bảo đảm qua một nhà môi giới bảo hiểm

Chia các rủi ro về giao hàng giữa người mua và người bán bằng cách phân định rõ trách nhiệm (Phụ lục 4).

Chia các rủi ro thanh toán hoặc không thanh toán cũng theo cách trên.

Ba yếu tố kiểm soát rủi ro trên thường được kết hợp sử dụng trong giao dịch kinh doanh.
1.2. Tín dụng ngắn hạn và dài hạn

Yếu tố đầu tiên của kiểm soát rủi ro là xác định thời hạn của tín dụng được nhà cung cấp chấp nhận. Thanh toán tín dụng ở đây được kết hợp với rất nhiều hình thức thanh toán. Ví dụ: "L/C 60 ngày". Việc thanh toán sẽ được ngân hàng thực hiện và sau 60 ngày kể từ khi L/C được xuất trình. Có 2 loại tín dụng:

Tín dụng ngắn hạn: Thời hạn thanh toán nằm trong khoảng thời gian không quá 12 tháng, nghĩa là thời gian từ lúc giao hàng tới khi thanh toán được thực hiện không quá 12 tháng. Tín dụng ngắn hạn thường dùng cho việc thanh toán hàng tiêu dùng, nguyên liệu thô, hàng hoá bán thành phẩm.

Tín dụng dài hạn: việc thanh toán được thực hiện dài hơn 12 tháng sau khi giao nhận hàng hoá hay sau khi hết hạn hợp đồng.</textarea></p>
				<p>
                    <asp:CheckBox ID="check" runat="server" TabIndex="11" Text=" " />
                    Tôi đồng ý với điều khoản <p4>*</p4></input></p>
                <p>
                    <asp:Button ID="buttom_dangky" runat="server" onclick="buttom_dangky_Click" 
                        TabIndex="12" Text="Đăng Ký" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Xóa" />
                </p>
                <p>
                    <br />
                    <asp:Label ID="e10" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    &nbsp;</p>
            </div>
            <div id="r3">PKTPhone.com cam kết áp dụng mức bảo mật cao nhất thông tin Quý khách đặt hàng.</div>
        </div>
    </div>
</asp:Content>
