<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dangky.aspx.cs" Inherits="dangky" Title="Dang ky tai khoan" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Overline= "false" 
        Font-Size="X-Large" Font-Strikeout="False" Font-Underline="True"  
        ForeColor=" black" Text="ĐĂNG KÝ TÀI KHOẢN MỚI"></asp:Label></center>
<br />
    <asp:Label ID="Label1" runat="server" 
        Text="Quý khách vui lòng nhập đầy đủ thông tin dưới đây để đăng ký:" 
        Font-Size="Medium" ForeColor="blue" Font-Bold="True"></asp:Label>&nbsp;<br />
   
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table align="right" cellpadding="0" cellspacing="0" frame="void" style="width: 95%;
        color: #1a50b8; height: 20%" width="30%">
                <tr>
                    <td style="width: 167px; height: 21px">
                        <asp:Label ID="Label3" runat="server" ForeColor="black" Text="Email:"></asp:Label>
                    </td>
                    <td style="height: 21px">
                        <asp:TextBox ID="txtemail" runat="server" Style="margin-left: 0px" Width="80%"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 18px">
                        <asp:Label ID="Label2" runat="server" ForeColor="black" Text="Mật khẩu:"></asp:Label>
                    </td>
                    <td style="height: 18px">
                        <asp:TextBox ID="txtpass" runat="server" AutoCompleteType="BusinessZipCode" TabIndex="1"
                    TextMode="Password" Width="80%"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 28px">
                        <asp:Label ID="Label4" runat="server" ForeColor="black" 
                    Text="Nhập lại mật khẩu:"></asp:Label>
                    </td>
                    <td style="height: 28px">
                        <asp:TextBox ID="TextBox3" runat="server" TabIndex="2" TextMode="Password" 
                    Width="80%"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 20px">
                        <asp:Label ID="Label5" runat="server" ForeColor="black" Text="Họ tên:"></asp:Label>
                    </td>
                    <td style="height: 20px">
                        <asp:TextBox ID="txthoten" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                        &nbsp;
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px">
                        <asp:Label ID="Label6" runat="server" ForeColor="black" Text="Địa chỉ:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtdc" runat="server" TabIndex="4" Width="80%"></asp:TextBox>
                        &nbsp;
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 28px; color: Black">
                        Số CMND:</td>
                    <td style="height: 28px">
                        <asp:TextBox ID="txtcmt" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 28px; color:Black">
                        Mã bưu điện:</td>
                    <td style="height: 28px">
                        <asp:TextBox ID="txtmabuudien" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 30px; color: Black">
                        Số tài khoản ngân hàng:</td>
                    <td style="height: 30px">
                        <asp:TextBox ID="txtnganhang" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 28px">
                        <asp:Label ID="Label7" runat="server" ForeColor="black" Text="Điện thoại:"></asp:Label>
                    </td>
                    <td style="height: 28px">
                        <asp:TextBox ID="txtdt" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 24px">
                        &nbsp;<asp:Label ID="Lblthongbao" runat="server" ForeColor="black"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Đăng ký" Font-Bold="true"
                    Width="86px" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
                            
    </asp:Content>

