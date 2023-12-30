<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="ThongkeDoanhthu.aspx.cs" Inherits="DoAn4.Admin.WebForm17" Title="Thống kê doanh thu" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            font-size: medium;
        }
        .style3
        {
            width: 69%;
        }
        .style4
        {
            width: 191px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
            <span class="style2">THỐNG KÊ DOANH THU</span>
        </center>
        <hr width="60%" />
    </div>
    <br />
    <div>
        <table cellpadding="0" cellspacing="0" class="style3" align="center">
            <tr>
                <td class="style4">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                                Height="84px" Width="161px">
                                <asp:ListItem>Theo ngày</asp:ListItem>
                                <asp:ListItem>Theo khoảng thời gian</asp:ListItem>
                                <asp:ListItem>Theo năm</asp:ListItem>
                            </asp:RadioButtonList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td>
                    <asp:TextBox ID="txtNgay" runat="server"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtNgay_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtNgay">
                    </cc1:CalendarExtender>
                    <br />
                    <asp:TextBox ID="txtTungay" runat="server"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtTungay_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtTungay">
                    </cc1:CalendarExtender>
                    &nbsp;&gt;&gt;
                    <asp:TextBox ID="txtDenngay" runat="server"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtDenngay_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="txtDenngay">
                    </cc1:CalendarExtender>
                    <br />
                    <asp:TextBox ID="txtNam" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div>
    <center>
    <asp:Button ID="btnThongke" runat="server" Text="Thống kê" 
            onclick="btnThongke_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            style="text-align: center" Width="90%">
            <RowStyle ForeColor="#000066" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Doanh thu:"></asp:Label>
&nbsp;
        <asp:Label ID="Label1" runat="server" style="font-weight: 700"></asp:Label>
    </center>
    </div>
    
</asp:Content>
