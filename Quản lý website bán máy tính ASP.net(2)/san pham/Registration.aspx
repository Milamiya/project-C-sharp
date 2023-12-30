<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Default2"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    .table
    {
    	-moz-border-radius-topleft:10px;
    	-moz-border-radius-topright:10px;
    	-moz-border-radius-bottomleft:10px;
    	-moz-border-radius-bottomright:10px;
    	border: 1px solid gray;   
    	width:750px;
    	height:500px;
    	background-color:#eef3ef;	
    	}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div><asp:Image ID="Image1" runat="server" 
                    ImageUrl="~/images/register_title.gif" Width="415px" 
            Height="48px" />
    </div>
    <table class="table">        
        
        <tr>
            <td bgcolor="#CCCCCC"><b>Thông tin dùng đăng nhập website</b></td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr>
        <tr>
            <td style="padding-left:10px;">Email:</td>
            <td style="padding-right:200px;"><asp:TextBox ID="txtEmail" runat="server" 
                    Width="173px"></asp:TextBox>(*)<br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Email chưa đúng" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="lbThongBao" runat="server" ForeColor="Red" 
                    Text="Email này đã có người sử dụng!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="padding-left:10px;">Mật khẩu:</td>
            <td><asp:TextBox ID="txtMK" runat="server" TextMode="Password" Width="200px"></asp:TextBox>(*)<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMK" 
                    ErrorMessage="Nhập vào mật khẩu"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr>   
        <tr>
            <td style="padding-left:10px;">Nhắc lại mật khẩu:</td>
            <td><asp:TextBox ID="txtMK2" runat="server" TextMode="Password" Width="200px"></asp:TextBox>(*)<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMK2" 
                    ErrorMessage="Nhập lại mật khẩu"></asp:RequiredFieldValidator>
            </td>
        </tr>        
        <tr>
            <td style="height:5px;"></td>
        </tr>
        <tr>
            <td bgcolor="#CCCCCC"><b>Thông tin cá nhân</b></td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr>
        <tr>
            <td style="padding-left:10px;">Họ tên:</td>
            <td><asp:TextBox ID="txtHoTen" runat="server" Width="200px"></asp:TextBox>(*)<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtHoTen" 
                    ErrorMessage="Nhập vào họ tên"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr> 
        <tr>
            <td style="padding-left:10px;">Giới tính:</td>
            <td><asp:RadioButton ID="rbNam" runat="server" Text="Nam" Checked="True" />
                <asp:RadioButton ID="rbNu" runat="server" Text="Nữ" /></td>            
        </tr>
        <tr>
            <td style="height:7px;"></td>
        </tr>
        <tr>
            <td style="padding-left:10px;">Ngày sinh:</td>
            <td>Ngày
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>-</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
&nbsp;Tháng
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>-</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
&nbsp;Năm<asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>-</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                </asp:DropDownList>
                                        </td>
        </tr> 
        <tr>
            <td style="height:7px;"></td>
        </tr>
        <tr>
            <td style="padding-left:10px;">Số điện thoại:</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr>
        <tr>
            <td style="padding-left:10px;">Địa chỉ:</td>
            <td><asp:TextBox ID="txtDiaChi" runat="server" Width="200px"></asp:TextBox>(*)<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDiaChi" 
                    ErrorMessage="Nhập vào địa chỉ"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height:5px;"></td>
        </tr> 
        <tr>
            <td colspan="2" style="padding-left:330px;"><asp:Button ID="btDangKy" 
                    runat="server" Text="Đăng ký" onclick="btDangKy_Click" /></td>
        </tr>
        <tr>
            <td style="height:10px;"></td>
        </tr> 
        </table>
</asp:Content>

