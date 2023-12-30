<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="ChitietNhap.aspx.cs" Inherits="DoAn4.Admin.WebForm8" Title="Chi tiết hóa đơn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungNH
        {
            width: 792px;
            margin-left: 0px;
            margin-bottom: 8px;
        }
        .daukhungNH
        {
            color: Black;
            text-align: center;
            margin-top: auto;
            height: 25px;
            font-family: Arial;
            font-size: medium;
        }
        .style4
        {
            color: Black;
            text-align: center;
            margin-top: auto;
            height: 22px;
            font-family: Arial;
            font-size: larger;
            width: 796px;
        }
        .style5
        {
            width: 86%;
            height: 110px;
        }
        .style6
        {
            text-align: right;
            font-family: Arial;
            font-size: small;
            width: 46%;
        }
        .style8
        {
            height: 30px;
        }
        .style9
        {
            text-align: right;
            font-family: Arial;
            font-size: small;
            height: 26px;
            width: 46%;
        }
        .style10
        {
            height: 26px;
        }
        .style11
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            text-align: right;
        }
        .style14
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            text-align: right;
            height: 30px;
        }
        .style17
        {
            text-align: right;
            font-family: Arial;
            font-size: small;
            height: 28px;
            width: 46%;
        }
        .style19
        {
            text-align: right;
            font-family: Arial;
            font-size: small;
            height: 37px;
            width: 46%;
        }
        .style21
        {
            text-align: right;
            font-family: Arial;
            font-size: small;
            height: 34px;
            width: 46%;
        }
        .style22
        {
            height: 34px;
        }
        .style23
        {
            height: 28px;
        }
        .style24
        {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungNH">
        <div class="style4">
            CHI TIẾT NHẬP HÀNG
        </div>
        <hr style="width: 43%" />
        <div>
            <table cellpadding="0" cellspacing="0" class="style5" align="center">
                <tr>
                    <td class="style17">
                        Mã phiếu nhập:
                    </td>
                    <td class="style23">
                        &nbsp;
                        &nbsp;<asp:Label ID="Label7" runat="server" 
                            style="font-weight: 700; font-size: large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        Mã sản phẩm:
                    </td>
                    <td class="style22">
                        &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                            DataSourceID="SqlDataSource1" DataTextField="Product_ID" 
                            DataValueField="Product_ID" Height="22px" Width="100px" 
                            onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
&nbsp;
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                            SelectCommand="SELECT [Product_ID] FROM [tbl_Product]"></asp:SqlDataSource>
                        <br />
                        <asp:Label ID="Label4" runat="server" Style="color: #FF0000"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        Giá nhập:
                    </td>
                    <td class="style10">
                        &nbsp;<asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" 
                            DataTextField="Price_Import" DataValueField="Price_Import" 
                            ontextchanged="DropDownList3_TextChanged" Width="100px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                            SelectCommand="SELECT [Price_Import] FROM [tbl_Product] WHERE ([Product_ID] = @Product_ID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList2" Name="Product_ID" 
                                    PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="style19">
                        Số lượng:
                    </td>
                    <td class="style24">
                        &nbsp;<asp:TextBox ID="txtSL" runat="server" OnTextChanged="txtSL_TextChanged"></asp:TextBox>
                    &nbsp;<asp:Label ID="Label8" runat="server" style="color: #FF0000"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style6">
                        Thành tiền:
                    </td>
                    <td>
                        &nbsp;<asp:TextBox ID="txtThanhtien" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <center>
                    <asp:Button ID="btntiep" runat="server" onclick="btntiep_Click" 
                        Text="Nhập mới" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNhap" runat="server" Text="Nhập" Width="60px" 
                        OnClick="btnNhap_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="Sửa" Width="60px" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="60px" OnClick="btnXoa_Click" />
                    <br />
                    <asp:Label ID="Label6" runat="server" style="color: #0000FF"></asp:Label>
                    <br />
                    <br />
                </center>
            </div>
        </div>
        <div>
            <center>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Style="text-align: center"
                    Width="90%" onrowdeleting="GridView1_RowDeleting" 
                    onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating">
                    <RowStyle ForeColor="#000066" />
                    <Columns>
                        <asp:TemplateField HeaderText="Mã hoá đơn" SortExpression="Import_ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Import_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Import_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mã sản phẩm" SortExpression="Product_ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Product_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbMaSP" runat="server" Text='<%# Bind("Product_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Price_Import" HeaderText="Giá nhập" 
                            SortExpression="Price_Import" />
                        <asp:BoundField DataField="Amount" HeaderText="Số lượng" SortExpression="Amount" />
                        <asp:BoundField DataField="Money" HeaderText="Thành tiền" SortExpression="Money" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </center>
        </div>
        <br />
        <div>
            <table cellpadding="0" cellspacing="0" class="style5">
                <tr>
                    <td class="style11">
                        Tổng sản phẩm:
                    </td>
                    <td>
                        &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Style="font-weight: 700"></asp:Label>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style14">
                        Tổng số lượng:
                    </td>
                    <td class="style8">
                        &nbsp;
                        <asp:Label ID="Label2" runat="server" Style="font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style11" width="80%">
                        Tổng tiền:
                    </td>
                    <td>
                        &nbsp;
                        <asp:Label ID="Label3" runat="server" Style="font-weight: 700"></asp:Label>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
