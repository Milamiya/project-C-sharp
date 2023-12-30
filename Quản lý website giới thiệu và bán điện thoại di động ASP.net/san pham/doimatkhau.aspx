<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="doimatkhau.aspx.cs" Inherits="doimatkhau" Title="Doi mat khau" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix ="ajaxToolkit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div align="center" >
                     <h1><b>THAY ĐỔI MẬT KHẨU</b></h1>
                <table border="0" cellpadding="0">
                    <tr>
                        <td align="center" colspan="2" 
                style="font-weight: bold; font-size: large; color: #008000;
                font-style: oblique; font-family: 'Times New Roman', Times, serif; height: 34px">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="text-align: left">
                            <asp:Label ID="CurrentPasswordLabel" runat="server" AssociatedControlID="txtcu">Mật khẩu cũ:</asp:Label>
                        </td>
                        <td style="width: 225px; text-align: left">
                            <asp:TextBox ID="txtcu" runat="server" TextMode="Password"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="text-align: left">
                            <asp:Label ID="NewPasswordLabel" runat="server" AssociatedControlID="txtmoi">Mật khẩu mới:</asp:Label>
                        </td>
                        <td style="width: 225px; text-align: left">
                            <asp:TextBox ID="txtmoi" runat="server" TextMode="Password"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="text-align: left">
                            <asp:Label ID="ConfirmNewPasswordLabel" runat="server" 
                    AssociatedControlID="txtxacnhan">Xác nhận mật khẩu mới:</asp:Label>
                        </td>
                        <td style="width: 225px; text-align: left">
                            <asp:TextBox ID="txtxacnhan" runat="server" TextMode="Password"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" style="color: blue; text-align: left">
                            <asp:Label ID="lbltb" runat="server"></asp:Label>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Button ID="ChangePasswordPushButton" runat="server" CommandName="ChangePassword"
                    OnClick="ChangePasswordPushButton_Click" Text="Đổi mật khẩu" Font-Bold="true"/>
                        </td>
                        <td align="center" style="width: 225px">
                            <asp:Button ID="CancelPushButton" runat="server" CausesValidation="False" CommandName="Cancel"
                    OnClick="CancelPushButton_Click" Text="Hủy bỏ" Font-Bold="true"/>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
     </asp:Content>


