<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="InsertUser.aspx.cs" Inherits="hello_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .thongsosp
        {
        	width:794px;
        	height:450px;
        	border-top:1px solid #e99765;                    	
        	border-right:1px solid #e99765;  
        	border-left:1px solid #e99765;                     	
        	border-bottom:1px solid #e99765;                  	
        	float:left;        	
        	background-color:White;
        	}        
        .textbox
        {
        	width:200px;
        	height:25px;
        	}              
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-bottom:20px;margin-top:5px;">
        <br />
        <asp:Label ID="Label1" runat="server" Text=">>Thêm user" 
        Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
    </div>
    <table class="thongsosp">
        <tr>
            <td></td>
        </tr> 
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Tên đăng nhập:</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Tên đăng nhập trống" ControlToValidate="txtUserName">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Mật khẩu:</td>
            <td>
                <asp:TextBox ID="txtPass" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPass" ErrorMessage="Mật khẩu trống">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Họ và tên:</td>
            <td>
                <asp:TextBox ID="txtFullName" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Ngày sinh:</td>
            <td>
                <asp:TextBox ID="txtBirthday" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Email chưa đúng định dạng" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Phân quyền:</td>
            <td>
                <asp:RadioButton ID="rbAdmin" runat="server" Checked="True" Text="Admin" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbUser" runat="server" Text="User" />
            </td>
        </tr>
        <tr>
            <td></td>
        </tr> 
        <tr>
            <td colspan="2" style="padding-left:270px;">
                <asp:Button ID="btThem" runat="server" Text="Thêm mới" Height="26px"
                    Width="102px" onclick="btThem_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

