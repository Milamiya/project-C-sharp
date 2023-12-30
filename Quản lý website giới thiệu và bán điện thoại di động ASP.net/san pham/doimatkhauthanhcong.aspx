<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="doimatkhauthanhcong.aspx.cs" Inherits="doimatkhauthanhcong" Title="Doi mat khau thanh cong " %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
        ForeColor="black" Text="CHÚC MỪNG BẠN ĐÃ ĐỔI MẬT KHẨU THÀNH CÔNG"></asp:Label>
    <br />
    <br />
    <asp:HyperLink ID="hpldangnhap" runat="server" Font-Bold="True" 
        Font-Size="Small" Font-Underline="False" ForeColor="blue" 
            NavigateUrl="Default.aspx">NHẤN VÀO ĐÂY ĐỂ 
    ĐĂNG NHẬP TÀI KHOẢN</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/Default.aspx" ForeColor="Black">&gt;&gt;TRỞ 
    VỀ TRANG CHỦ</asp:HyperLink>
    </center>

    <br />
    <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderWidth="2px">
        
                <table border="0" cellpadding="1" cellspacing="0" 
                    style="margin-left: 3px;">
                    <tr>
                        <td>
                            <table border="0" cellpadding="0" style="width:455px;">
                                <tr>
                                    <td align="center" colspan="2">
                                    <asp:Panel ID="tieude" runat="server">
                                    <div style="background-color :white"><h1><b>ĐĂNG NHẬP</b></h1> </div>
                                    </asp:Panel> </td>
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
                                    <td align="center" colspan="2" style="color:Red;">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:Button ID="btndangnhap" runat="server" CommandName="Login" 
                                            Text="Đăng nhập" onclick="btndangnhap_Click" Font-Bold="true" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btncancel" runat="server" CommandName="Login" Text="Hủy bỏ" 
                                            Height="26px" Width="94px"  Font-Bold="true"/>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
             </asp:Panel>
    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" 
        CancelControlID="btncancel" DropShadow="True" 
        TargetControlID="hpldangnhap" PopupControlID="Panel1" PopupDragHandleControlID="tieude">
    </ajaxToolkit:ModalPopupExtender>
    
</asp:Content>

