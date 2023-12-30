<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="ThongkeSP.aspx.cs" Inherits="DoAn4.Admin.WebForm13" Title="Thống kê sản phẩm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 270px;
            font-family: Arial, Helvetica, sans-serif;
            text-align: right;
        }
        .style3
        {
            width: 213px;
        }
        .style4
        {
            width: 99%;
            height: 39px;
            margin-bottom: 0px;
        }
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            text-align: right;
            width: 47%;
        }
    .style6
    {
        font-family: Arial, Helvetica, sans-serif;
        font-weight: bold;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: right; width: 790px;">
        <div>
            <center style="font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #000000">
                <b>THỐNG KÊ SẢN PHẨM</b></center>
            <hr width="50%" />
        </div>
        <div>
            <div style="text-align: center; height: 52px;">
                <table cellpadding="0" cellspacing="0" class="style4">
                    <tr>
                        <td class="style5">
                            Chọn loại sản phẩm:
                        </td>
                        <td style="text-align: left" width="10px">
                            &nbsp;
                        </td>
                        <td style="text-align: left">
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
                                DataTextField="Type_Name" DataValueField="Type_Name" OnPreRender="DropDownList1_PreRender"
                                Height="25px" Width="144px" 
                                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem Enabled="False" Selected="True">-------Chọn-------</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                                SelectCommand="SELECT [Type_ID], [Type_Name] FROM [tbl_Type]"></asp:SqlDataSource>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <center>
                    <asp:Button ID="btnThongke" runat="server" Text="Thống kê" 
                        onclick="btnThongke_Click" style="height: 26px" />
                </center>
            </div>
            <br />
            <div>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Width="100%" AutoGenerateColumns="False" 
                    style="text-align: center" onpageindexchanging="GridView1_PageIndexChanging1">
                        <RowStyle ForeColor="#000066" />
                        <Columns>
                            <asp:BoundField DataField="Product_ID" HeaderText="Mã SP" 
                                SortExpression="Product_ID" />
                            <asp:BoundField DataField="Product_Name" HeaderText="Tên SP" 
                                SortExpression="Product_Name" />
                            <asp:TemplateField HeaderText="Loại SP">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Type_Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Phong cách">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Style_Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="NCC">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Supplier_Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Hãng SX">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Producer_Name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Price_Import" HeaderText="Giá nhập" 
                                SortExpression="Price_Import" />
                            <asp:BoundField DataField="Price_Export" HeaderText="Giá xuất" 
                                SortExpression="Price_Export" />
                            <asp:BoundField DataField="Amount" HeaderText="Số lượng" 
                                SortExpression="Amount" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
            </div>
        </div>
    </div>
    <br />
    <div style="width: 775px; text-align: left; height: 79px;">
        <table align="right" style="width: 324px; height: 78px;">
            <tr>
                <td class="style2">
                    Tổng sản phẩm:
                </td>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" Style="color: #000000; font-weight: 700; font-family: Arial, Helvetica, sans-serif"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Tổng số lượng:
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Style="color: #000000; font-weight: 700; font-family: Arial, Helvetica, sans-serif"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Tổng tiền nhập:
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Style="color: #000000; font-weight: 700; font-family: Arial, Helvetica, sans-serif"></asp:Label>
                &nbsp;&nbsp; <span class="style6">VNĐ</span></td>
            </tr>
        </table>
        &nbsp;
        <br />
        &nbsp;
    </div>
    </div>
</asp:Content>
