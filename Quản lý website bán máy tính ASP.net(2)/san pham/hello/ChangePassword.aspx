<%@ Page Language="C#" MasterPageFile="~/hello/Admin.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="hello_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .thongsosp
        {
        	width:794px;
        	height:300px;
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
        .style1
        {
            width: 243px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-bottom:20px;margin-top:5px;">
        <br />
        <asp:Label ID="Label1" runat="server" Text=">>Thay đổi password" 
        Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
    </div>
    <table class="thongsosp">
        <tr>
            <td class="style1">&nbsp;&nbsp;&nbsp; Mật khẩu cũ:</td>
            <td>
                <asp:TextBox ID="txtOldPass" runat="server" CssClass="textbox" 
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">&nbsp;&nbsp;&nbsp; Mật khẩu mới:</td>
            <td>
                <asp:TextBox ID="txtNewPass" runat="server" CssClass="textbox" 
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">&nbsp;&nbsp;&nbsp; Nhập lại mật khẩu mới:</td>
            <td>
                <asp:TextBox ID="txtNew2Pass" runat="server" CssClass="textbox" 
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="padding-left:300px;">
                <asp:Button ID="btThayDoi" runat="server" Text="Thay đổi" Height="28px" 
                    Width="84px" onclick="btThayDoi_Click" />
            </td>            
        </tr>
    </table>
</asp:Content>

