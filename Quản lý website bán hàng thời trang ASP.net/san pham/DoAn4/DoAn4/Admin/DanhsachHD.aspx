<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="DanhsachHD.aspx.cs" Inherits="DoAn4.Admin.WebForm15" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
            <span class="style2">DANH SÁCH HOÁ ĐƠN</span>
        </center>
        <hr width="60%" />
    </div>
    <br />
    <div>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            style="text-align: center" AutoGenerateColumns="False" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onrowdeleting="GridView1_RowDeleting" Width="100%">
            <RowStyle ForeColor="#000066" />
            <Columns>
                <asp:TemplateField HeaderText="Mã HĐ" SortExpression="Order_ID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Order_ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày mua" SortExpression="Date">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Người nhận" SortExpression="Name_Receivde">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Name_Received") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Người thanh toán" SortExpression="Name_Pay">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Name_Pay") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tổng tiền" SortExpression="SumMoney">
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("SumMoney") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Trạng thái" SortExpression="State">
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("State") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="Order_ID" 
                    DataNavigateUrlFormatString="ChitietHD.aspx?Order_ID={0}" HeaderText="Chi tiết" 
                    Text="Chi tiết" />
                <asp:CommandField ButtonType="Button" DeleteText="Xem hoá đơn" 
                    HeaderText="Xem hoá đơn" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>
</asp:Content>
