<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeFile="ThongTinCaNhan.aspx.cs" Inherits="admin_ThongTinCaNhan" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p class="accoditionHeader" style="text-align:left">
    <asp:Label ID="lblUser" runat="server"  />
</p>
<table cellpadding="0" cellspacing="0" class="style5">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" CssClass="accoditionHeader" Width="98%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td td style="width:50%; border:1px solid #DFDFDF; background-color:#f6f6f6" align="left" valign="top">
                    <table cellpadding="3" cellspacing="3" class="style6">
                        <tr>
                            <td style="width:30%">
                                Tên đăng nhập:</td>
                            <td style="width:70%">
                                <asp:TextBox ID="txtTenDN" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                Họ và Tên:</td>
                            <td style="width:70%">
                                <asp:TextBox ID="txtHoTen" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                Email:</td>
                            <td style="width:70%">
                                <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                Phân quyền:</td>
                            <td style="width:70%">
                                <asp:TextBox ID="txtQuyen" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                                <asp:Label ID="lblRoleName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                &nbsp;</td>
                            <td style="width:70%">
                                <asp:Button ID="butCapNhat" runat="server" CssClass="buttonLogin" 
                                    Text="Cập nhật" Width="100px" onclick="butCapNhat_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="style9">
                    </td>
                <td td style="width:50%; border:1px solid #DFDFDF; background-color:#f6f6f6" align="left" valign="top">
                    <table cellpadding="3" cellspacing="3" class="style6">
                        <tr>
                            <td style="width:30%">
                                Mật khẩu cũ:</td>
                            <td style="width:70%">
                                <asp:TextBox ID="txtOldPass" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                Mật khẩu mới:</td>
                            <td style="width:70%">
                                <asp:TextBox ID="txtNewPass" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                Nhập lại mật khẩu: </td>
                            <td style="width:70%; margin-left: 80px;">
                                <asp:TextBox ID="txtNewPassAgain" runat="server" Width="200px" 
                                    TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                &nbsp;</td>
                            <td style="width:70%">
                                <asp:Button ID="butDoiMk" runat="server" CssClass="buttonLogin" 
                                    Text="Đổi mật khẩu" Width="100px" onclick="butDoiMk_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width:30%">
                                &nbsp;</td>
                            <td style="width:70%">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>


</asp:Content>

