<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="quenmatkhau.aspx.cs" Inherits="quenmatkhau" Title="Lay lai mat khau" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix = "ajaxToolkit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="black"
        Text="Bạn vui lòng nhập thông tin cần thiết sau để tìm lại mật khẩu của mình."></asp:Label>
    <br />
    &nbsp;<br />
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div style="width: 100%; height: 86px; text-align: left">
                <table align="center" cellpadding="0" cellspacing="0" style="width: 95%">
                    <tr>
                        <td width="40%">
                            <asp:Label ID="Label2" runat="server" ForeColor="black" Text="Họ và tên:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtten" runat="server" Width="75%" 
                        Height="22px"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <div style="width: 100%; height: 40px; text-align: left">
                    <table align="center" cellpadding="0" cellspacing="0" 
                        style="width: 95%; height: 32px;">
                        <tr>
                            <td width="40%">
                                <asp:Label ID="Label3" runat="server" ForeColor="black" 
                                    style="margin-top: 0px" Text="Email:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtemail" runat="server" Width="75%" Height="22px"></asp:TextBox>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </div>
                <div style="width: 100%; height: 40px; text-align: left">
                    <table align="center" cellpadding="0" cellspacing="0" 
                        style="width: 95%; height: 6px;">
                        <tr>
                            <td width="40%">
                                <asp:Label ID="Label4" runat="server" ForeColor="black" Text="Địa chỉ:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtdc" runat="server" Width="75%" Height="22px"></asp:TextBox>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                    <br />
                </div>
                <br />
            </div><br />
            <asp:Label ID="lbthongbao" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="black"
        Text="Label" Visible="False"></asp:Label><br />
    <br />
    &nbsp;<asp:Button ID="btntimmk" runat="server" ForeColor="black" OnClick="btntimmk_Click"
        Text="Tìm mật khẩu" Font-Bold="true"/>
        </ContentTemplate>
    </asp:UpdatePanel>
    
    
</asp:Content>

