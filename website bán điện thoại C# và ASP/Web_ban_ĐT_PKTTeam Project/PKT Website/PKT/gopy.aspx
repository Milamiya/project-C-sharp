<%@ Page Title="PKT Phone | Liên Hệ" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="gopy.aspx.cs" Inherits="PKT.gopy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="same">
    <div id="re">
    <div id="tt-o">LIÊN HỆ</div>
    </div>
        <div id="same-1">
            <div> <p><strong>LIÊN HỆ - GÓP Ý</strong></p>
            Chúng tôi luôn trân trọng ý kiến phản hồi từ Quý khách mua hàng và Quý đối tác!
Nếu không hài lòng về chất lượng sản phẩm, dịch vụ cũng như nhân viên phục vụ tại các siêu thị, hệ thống tổng đài, website… mong Quý khách dành chút thời gian
góp ý cho chúng tôi. Bộ phận chăm sóc khách hàng của chúng tôi sẽ phản hồi trong thời gian sớm nhất 
			</div>
            <div id="feed1">
                Chủ đề <p4>*</p4>
                <p>Họ và tên <p4>*</p4></p>
                <p>Địa chỉ </p>
                <p>Số điện thoại </p>
                <p>Email <p4>*</p4></p>
                <p>Nội dung <p4>*</p4></p>                               
            </div>
            <div id="feed2">
                <asp:DropDownList ID="Chude" runat="server" Height="17px" Width="190px">
                    <asp:ListItem>Góp ý về Website</asp:ListItem>
                    <asp:ListItem>Góp ý về của hàng</asp:ListItem>
                    <asp:ListItem>Góp ý về nhân viên</asp:ListItem>
                    <asp:ListItem>Góp ý khác</asp:ListItem>
                    <asp:ListItem>Liên hệ hợp tác</asp:ListItem>
                </asp:DropDownList>
&nbsp;<p><asp:TextBox ID="ten" runat="server" Width="190px" ontextchanged="ten_TextChanged"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" 
                        style="color: #FF0000; font-style: italic"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="diachi" runat="server" Width="190px"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="dt" runat="server" Width="190px"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="email" runat="server" Width="190px" 
                        ontextchanged="email_TextChanged"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" 
                        style="color: #FF0000; font-style: italic"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="nd" runat="server" Height="109px" TextMode="MultiLine" 
                        Width="300px" ontextchanged="nd_TextChanged"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="gui" runat="server" Height="29px" Text="Gửi" 
                        Width="75px" onclick="gui_Click" />
                    <asp:Label ID="Label1" runat="server" 
                        style="color: #FF0000; font-style: italic"></asp:Label>
                </p>
            </div>
            <div id="feed3">Chúng tôi sẽ bảo mật hoàn toàn thông tin cá nhân của bạn (xem chính sách bảo mật). Một số trường hợp, chúng tôi không phản hồi thông tin nếu góp ý không phù hợp. Bạn cũng có thể liên lạc với PKTPhone.com qua Tổng Đài Tư Vấn Bán Hàng toàn quốc 1900.561.292 - 19001887 hoặc (08)38.102.102 (từ 7:30 - 22:00)</div>
        </div>
    </div>
</asp:Content>
