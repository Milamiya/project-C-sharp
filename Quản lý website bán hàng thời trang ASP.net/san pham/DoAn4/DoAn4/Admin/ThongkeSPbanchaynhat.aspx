<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ThongkeSPbanchaynhat.aspx.cs" Inherits="DoAn4.Admin.WebForm14" Title="Thống kê sản phẩm bán chạy nhất" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 66%;
            height: 104px;
        }
        .style4
        {
            height: 32px;
            text-align: left;
        }
        .style6
        {
            height: 31px;
        }
        .style7
        {
            height: 32px;
        }
        .style8
        {
            height: 32px;
            width: 152px;
        }
        .style9
        {
            height: 31px;
            width: 152px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
<center style="font-family: Arial, Helvetica, sans-serif; font-size: large; color: #000000; height: 24px;">THỐNG KÊ SẢN PHẨM BÁN CHẠY NHẤT</center>
    <hr width="50%" />
</div>
<div>

    <table cellpadding="0" cellspacing="0" class="style2" align="center">
        <tr>
            <td align="right" 
                
                style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #000000; text-align: left;" 
                class="style8">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="165px" 
                            AutoPostBack="True" Height="94px">
                            <asp:ListItem>Theo ngày</asp:ListItem>
                            <asp:ListItem>Theo khoảng thời gian</asp:ListItem>
                            <asp:ListItem>Theo năm</asp:ListItem>
                        </asp:RadioButtonList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td class="style4" 
                style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #000000">
                <asp:TextBox ID="txtTheongay" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtTheongay_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txtTheongay">
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
                <br />
                </td>
        </tr>
    </table>

</div><br />
<div>
<center>
    <asp:Button ID="btnThongke" runat="server" onclick="btnThongke_Click" 
        Text="Thống kê" />
    </center>
</div><br />
<div>
<center>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        style="text-align: center" Width="80%">
    <FooterStyle BackColor="White" ForeColor="#000066" />
    <RowStyle ForeColor="#000066" />
    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
</asp:GridView>
</center>
</div>
</asp:Content>

