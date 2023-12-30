<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="themqtri.aspx.cs" Inherits="Default3" Title="themquantri" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <center><asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Overline="False"
        Font-Size="X-Large" Font-Strikeout="False" Font-Underline="True" ForeColor="black" Text="THÊM QUẢN TRỊ VIÊN"></asp:Label><br />
    &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="black"
             Text="Vui lòng nhập đầy đủ thông tin dưới đây để đăng ký:"></asp:Label></center>&nbsp;<br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" BorderColor="#C1D2EE" BorderStyle="Groove"
        BorderWidth="2px" Height="292px">
                <table align="right" cellpadding="0" cellspacing="0" frame="void" style="width: 95%;
            color: #1a50b8; height: 99%" width="30%">
                    <tr>
                        <td style="width: 167px">
                            <asp:Label ID="Label3" runat="server" ForeColor="black" Text="Email:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtemail" runat="server" Style="margin-left: 0px" Width="80%"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px">
                            <asp:Label ID="Label2" runat="server" ForeColor="black" Text="Mật khẩu:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpass" runat="server" AutoCompleteType="BusinessZipCode" TabIndex="1"
                        TextMode="Password" Width="80%"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px">
                            <asp:Label ID="Label4" runat="server" ForeColor="black" Text="Nhập lại mật khẩu:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" TabIndex="2" TextMode="Password" Width="80%"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px">
                            <asp:Label ID="Label5" runat="server" ForeColor="black" Text="Họ tên:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txthoteb" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                            &nbsp;
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px; height: 20px">
                            <asp:Label ID="Label6" runat="server" ForeColor="black" Text="Địa chỉ:"></asp:Label>
                        </td>
                        <td style="height: 20px">
                            <asp:TextBox ID="txtdc" runat="server" TabIndex="4" Width="80%"></asp:TextBox>
                            &nbsp;
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px; height: 28px; color: Black">
                            Số CMT:</td>
                        <td style="height: 28px">
                            <asp:TextBox ID="txtcmt" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px; color: Black">
                            Mã bưu điện:</td>
                        <td>
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
                        <td style="width: 167px">
                            <asp:Label ID="Label7" runat="server" ForeColor="black" Text="Điện thoại:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtdt" runat="server" TabIndex="6" Width="80%"></asp:TextBox>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;<asp:Label ID="Lblthongbao" runat="server" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 167px; height: 23px">
                            &nbsp;</td>
                        <td style="height: 23px">
                            <asp:Button ID="btndangky" runat="server" OnClick="btndangky_Click" Text="Thêm mới" Font-Bold="true"
                        Width="86px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
        
</asp:Content>

