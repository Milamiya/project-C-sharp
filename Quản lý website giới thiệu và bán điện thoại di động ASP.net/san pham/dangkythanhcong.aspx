<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangkythanhcong.aspx.cs" Inherits="dangkythanhcong" Title="Dang ky thanh cong" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<center><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
        ForeColor="black" Text="CHÚC MỪNG BẠN ĐÃ ĐĂNG KÝ THÀNH CÔNG"></asp:Label>
   
    <br /><br />
    <asp:HyperLink ID="hpldangnhap" runat="server" Font-Bold="True" 
        Font-Size="Small" Font-Underline="False" ForeColor="blue" 
            NavigateUrl="~/Default.aspx"><i>NHẤN VÀO ĐÂY ĐỂ 
    ĐĂNG NHẬP TÀI KHOẢN</i></asp:HyperLink></center>


    <br />
    <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderWidth="2px" 
        Width="448px">
        
                <table border="0" cellpadding="1" cellspacing="0" 
                    style="width: 100%">
                    <tr>
                        <td>
                            
                            
                            <table border="0" cellpadding="0" style="width:445px;">
                                <tr>
                                    <td align="center" colspan="2"><asp:Panel ID="tieude" runat="server">
                                    <div style="background-color :white"> <h1><b>ĐĂNG NHẬP</b></h1></div> </asp:Panel></td>
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
                                    <td align="right" style="height: 28px">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="txtpass">Mật 
                                        khẩu:</asp:Label>
                                    </td>
                                    <td style="height: 28px">
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
                                    <td align="center" colspan="2" style="color:blue">
                                        <asp:Label ID="Label2" runat="server"></asp:Label>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" 
                                            CancelControlID="btncancel"  DropShadow="true" PopupControlID="Panel1" 
                                            PopupDragHandleControlID="tieude" TargetControlID="hpldangnhap">
                                        </ajaxToolkit:ModalPopupExtender>
                                        <asp:Button ID="btndangnhap" runat="server" CommandName="Login" Font-Bold="true"
                                            Text="Đăng nhập" onclick="btndangnhap_Click" 
                                             />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btncancel" runat="server" CommandName="Login" Text="Hủy bỏ" Font-Bold="true"
                                            Height="26px" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            
    </asp:Panel>
    </asp:Content>

