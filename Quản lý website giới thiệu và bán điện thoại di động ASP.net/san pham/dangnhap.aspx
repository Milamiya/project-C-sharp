<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangnhap.aspx.cs" Inherits="dangnhap" Title="Dang nhap" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix ="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        
                <table border="0" cellpadding="1" cellspacing="0" 
                    style="border-collapse:collapse;">
                    <tr>
                        <td style="height: 179px">
                            <table border="0" cellpadding="0" style="width:433px;">
                                <tr>
                                    <td align="center" colspan="2">
                                    <div style="background-color :Green"> ĐĂNG NHẬP</div> </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="txtemail">Email 
                                        của bạn:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtemail" runat="server" Height="22px" Width="150px"></asp:TextBox>&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="txtpass">Mật 
                                        khẩu:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Height="22px" 
                                            Width="150px"></asp:TextBox>&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:CheckBox ID="RememberMe" runat="server" 
                                            Text="Nhớ thông tin đăng nhập cho lần sau." />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red; height: 19px;">
                                        <asp:Label ID="Label1" runat="server"></asp:Label>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:Button ID="btndangnhap" runat="server" CommandName="Login" Text="Đăng nhập" OnClick="btndangnhap_Click" 
                                             />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btncancel" runat="server" CommandName="Login" Text="Hủy bỏ" 
                                            Height="26px" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            
    </asp:Panel>
</asp:Content>

