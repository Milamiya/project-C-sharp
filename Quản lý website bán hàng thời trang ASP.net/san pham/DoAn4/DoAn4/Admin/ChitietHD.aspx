<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ChitietHD.aspx.cs" Inherits="DoAn4.Admin.WebForm20" Title="Chi tiết hoá đơn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style2">
        CHI TIẾT HOÁ ĐƠN<hr width="60%" />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="False" 
            style="font-size: small" Text="Mã hoá đơn:"></asp:Label>
&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <div>
        <center>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                Font-Bold="False" 
                style="font-family: 'Times New Roman', Times, serif; text-align: center" 
                AutoGenerateColumns="False" onrowdeleting="GridView1_RowDeleting" Width="728px">
                <RowStyle ForeColor="#000066" />
                <Columns>
                    <asp:TemplateField HeaderText="Mã hoá đơn" SortExpression="Order_ID">
                        <ItemTemplate>
                            <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Order_ID") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Order_ID") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Mã sản phẩm" SortExpression="Product_ID">
                        <ItemTemplate>
                            <asp:Label ID="lbMaSP" runat="server" Text='<%# Bind("Product_ID") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Product_ID") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Price_Export" HeaderText="Giá bán" 
                        SortExpression="Price_Export" />
                    <asp:BoundField DataField="Amount" HeaderText="Số lượng" 
                        SortExpression="Amount" />
                    <asp:BoundField DataField="Money" HeaderText="Thành tiền " 
                        SortExpression="Money" />
                    <asp:BoundField DataField="State" HeaderText="Trạng thái" 
                        SortExpression="State" />
                    <asp:CommandField ButtonType="Button" DeleteText="Xử lý" HeaderText="Xử lý" 
                        ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            </center>
        </div>
        <br />
    </div>
</asp:Content>
