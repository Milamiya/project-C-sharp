<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="ThongkeNhaphang.aspx.cs" Inherits="DoAn4.Admin.WebForm16" Title="Thống kê nhập hàng" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            font-weight: bold;
        }
        .style3
        {
            width: 81%;
            margin-left: 140px;
            height: 100px;
        }
        .style4
        {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: right;
            width: 152px;
        }
        .style6
        {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
            <span class="style2">THỐNG KÊ HÓA ĐƠN NHẬP</span>
        </center>
    </div>
    <hr width="60%" />
    <div>
    </div>
    <br />
    <div>
        <center>
        <table cellpadding="0" cellspacing="0" class="style3" align="center">
            <tr>
                <td class="style4">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="99px" 
                                style="text-align: left" Width="169px">
                                <asp:ListItem>Theo ngày</asp:ListItem>
                                <asp:ListItem>Theo khoảng thời gian</asp:ListItem>
                                <asp:ListItem>Theo năm</asp:ListItem>
                            </asp:RadioButtonList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtNgay" runat="server" style="text-align: left"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtNgay_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtNgay">
                    </cc1:CalendarExtender>
                    <br />
                    <asp:TextBox ID="txtTungay" runat="server"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtTungay_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtTungay">
                    </cc1:CalendarExtender>
&nbsp;&gt;&gt;&nbsp;
                    <asp:TextBox ID="txtDenngay" runat="server"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtDenngay_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtDenngay">
                    </cc1:CalendarExtender>
                    <br />
                    <asp:TextBox ID="txtTheonam" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
            <asp:Button ID="btnThongke" runat="server" Text="Thống kê" OnClick="btnThongke_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="White"
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnPageIndexChanging="GridView1_PageIndexChanging1"
                Style="text-align: center" Width="641px">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <RowStyle ForeColor="#000066" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <br />
            <table cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td style="font-family: Arial, Helvetica, sans-serif; font-size: small; text-align: right"
                        width="70%">
                        Tổng tiền nhập:
                    </td>
                    <td style="text-align: left; font-weight: 700">
                        &nbsp;
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </center>
    </div>
</asp:Content>
