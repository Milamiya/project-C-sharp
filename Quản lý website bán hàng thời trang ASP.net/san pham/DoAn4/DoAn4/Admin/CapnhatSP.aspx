<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true"
    CodeBehind="CapnhatSP.aspx.cs" Inherits="DoAn4.Admin.WebForm3" Title="Cập nhật sản phẩm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .khungSP
        {
            width: 794px;
            height: 748px;
            margin-right: 0px;
        }
        .daukhungSP
        {
            color: Black;
            font-weight: bold;
            text-align: center;
            margin-top: auto;
            height: 25px;
            width: 793px;
        }
        .style9
        {
            width: 97%;
            margin-left: 8px;
            height: 124px;
        }
        .style11
        {
            width: 254px;
            height: 26px;
        }
        .style12
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 91px;
            height: 26px;
        }
        .style13
        {
            color: Black;
            text-align: center;
            margin-top: auto;
            height: 40px;
            width: 797px;
            font-family: Arial;
            font-size: large;
        }
        .style15
        {
            width: 254px;
            height: 16px;
        }
        .style16
        {
            height: 16px;
        }
        .style17
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 91px;
            height: 16px;
        }
        .style18
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 20px;
        }
        .style19
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 16px;
        }
        .style24
        {
            width: 29px;
            height: 26px;
        }
        .style26
        {
            height: 16px;
            width: 29px;
        }
        .style32
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 36px;
        }
        .style42
        {
            height: 26px;
        }
        .style43
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 32px;
        }
        .style44
        {
            width: 254px;
            height: 32px;
        }
        .style45
        {
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .style46
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 26px;
        }
        .style51
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 44px;
        }
        .style52
        {
            width: 254px;
            height: 44px;
        }
        .style53
        {
            height: 44px;
            width: 29px;
        }
        .style54
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 91px;
            height: 44px;
        }
        .style55
        {
            height: 44px;
        }
        .style56
        {
            width: 254px;
            height: 36px;
        }
        .style57
        {
            width: 29px;
            height: 36px;
        }
        .style58
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 91px;
            height: 36px;
        }
        .style59
        {
            height: 36px;
        }
        .style60
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 23%;
            height: 35px;
        }
        .style61
        {
            width: 254px;
            height: 35px;
        }
        .style62
        {
            width: 29px;
            height: 35px;
        }
        .style63
        {
            font-family: Arial;
            font-size: small;
            text-align: right;
            width: 91px;
            height: 35px;
        }
        .style64
        {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="khungSP">
        <div class="style13">
            CẬP NHẬT SẢN PHẨM<br />
            <hr width="50%" />
        </div>
        <div>
            <table cellpadding="0" cellspacing="0" class="style9" align="center">
                <tr>
                    <td class="style43">
                        &nbsp; Mã sản phẩm:
                    </td>
                    <td class="style44">
                        &nbsp;&nbsp;<asp:TextBox ID="txtMa" runat="server" Width="125px" Enabled="False"></asp:TextBox>
                        &nbsp;<asp:Label ID="Label6" runat="server" Style="color: #FF0000; font-size: small; font-family: Arial, Helvetica, sans-serif;
                            font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style46">
                        &nbsp; Tên sản phẩm:
                    </td>
                    <td class="style11">
                        &nbsp;&nbsp;<asp:TextBox ID="txtTenSP" runat="server" Width="198px"></asp:TextBox>
                        &nbsp;<span class="style45">(*)</span><br />
                    </td>
                    <td class="style24">
                        &nbsp;
                    </td>
                    <td class="style12">
                        &nbsp;Màu sắc:
                    </td>
                    <td width="30%" align="left" class="style42">
                        &nbsp;<asp:TextBox ID="txtMau" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style51">
                        &nbsp;Loại sản phẩm:
                    </td>
                    <td class="style52" align="left">
                        &nbsp;&nbsp;<asp:DropDownList ID="drLoaiSP" runat="server" DataSourceID="SqlDataSource1"
                            DataTextField="Type_Name" DataValueField="Type_ID" Height="21px" Width="200px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                            SelectCommand="SELECT [Type_ID], [Type_Name] FROM [tbl_Type]"></asp:SqlDataSource>
                    </td>
                    <td class="style53">
                        &nbsp;
                    </td>
                    <td class="style54">
                        &nbsp;Chất liệu:
                    </td>
                    <td align="left" class="style55">
                        &nbsp;
                        <asp:TextBox ID="txtChatlieu" runat="server" Width="205px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style19">
                        &nbsp; Phong cách:
                    </td>
                    <td class="style15" align="left">
                        &nbsp;
                        <asp:DropDownList ID="drPhongcach" runat="server" DataSourceID="SqlDataSource2" DataTextField="Style_Name"
                            DataValueField="Style_ID" Width="200px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                            SelectCommand="SELECT [Style_ID], [Style_Name] FROM [tbl_Style]"></asp:SqlDataSource>
                    </td>
                    <td class="style26">
                        &nbsp;
                    </td>
                    <td class="style17">
                        Kích cỡ:
                    </td>
                    <td align="left" class="style16">
                        &nbsp;
                        <asp:TextBox ID="txtKichthuoc" runat="server" Width="205px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style32">
                        &nbsp; Nhà cung cấp:
                    </td>
                    <td class="style56" align="left">
                        &nbsp;
                        <asp:DropDownList ID="drNhacungcap" runat="server" DataSourceID="SqlDataSource3"
                            DataTextField="Supplier_Name" DataValueField="Supplier_ID" Width="200px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                            SelectCommand="SELECT [Supplier_ID], [Supplier_Name] FROM [tbl_Supplier]"></asp:SqlDataSource>
                    </td>
                    <td class="style57">
                        &nbsp;
                    </td>
                    <td class="style58">
                        Giá nhập:
                    </td>
                    <td align="left" class="style59">
                        &nbsp;
                        <asp:TextBox ID="txtGianhap" runat="server" Width="150px"></asp:TextBox>
                        &nbsp;<span class="style45">(*)</span></td>
                </tr>
                <tr>
                    <td class="style60">
                        &nbsp; Hãng sản xuất:
                    </td>
                    <td class="style61" align="left">
                        &nbsp;
                        <asp:DropDownList ID="drHangsanxuat" runat="server" DataSourceID="SqlDataSource4"
                            DataTextField="Producer_Name" DataValueField="Producer_ID" Width="200px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                            SelectCommand="SELECT [Producer_ID], [Producer_Name] FROM [tbl_Producer]"></asp:SqlDataSource>
                    </td>
                    <td class="style62">
                        &nbsp;
                    </td>
                    <td class="style63">
                        Giá xuất:
                    </td>
                    <td align="left" class="style64">
                        &nbsp;
                        <asp:TextBox ID="txtGiaxuat" runat="server" Width="150px"></asp:TextBox>
                        &nbsp;<span class="style45">(*)</span>&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style18">
                        &nbsp;Hình ảnh:
                    </td>
                    <td class="style11" align="left">
                        &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                    <td class="style24">
                        &nbsp;
                    </td>
                    <td class="style12">
                        Trọng lượng:
                    </td>
                    <td align="left" class="style42">
                        &nbsp;
                        <asp:TextBox ID="txtTrongluong" runat="server" Width="80px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <center>
            <div style="height: 42px">
                <asp:Button ID="btnNhap" runat="server" Text="Nhập" Width="60px" OnClick="btnNhap_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="btnSua" runat="server" Text="Sửa" Width="60px" OnClick="btnSua_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="60px" OnClick="btnXoa_Click" />
                <br />
                <asp:Label ID="Label2" runat="server" Style="color: #FF0000; font-family: Arial, Helvetica, sans-serif;
                    font-size: small; font-weight: 700;"></asp:Label>
                <br />
            </div>
        </center>
        <br />
        <div style="margin-left: 3px; height: 386px;">
            <center>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" OnPageIndexChanging="GridView1_PageIndexChanging" Style="text-align: center;
                    margin-top: 0px;" Width="100%" Height="317px" OnRowEditing="GridView1_RowEditing"
                    OnRowUpdating="GridView1_RowUpdating">
                    <RowStyle ForeColor="#000066" />
                    <Columns>
                        <asp:TemplateField HeaderText="Mã SP" SortExpression="Product_ID">
                            <ItemTemplate>
                                <asp:Label ID="lbMa" runat="server" Text='<%# Bind("Product_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên SP" SortExpression="Product_Name">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("Product_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Loại SP" SortExpression="Type_ID">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# Bind("Type_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Phong cách" SortExpression="Style_ID">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# Bind("Style_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NCC" SortExpression="Supplier_ID">
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# Bind("Supplier_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="HSX" SortExpression="Producer_ID">
                            <ItemTemplate>
                                <asp:Label ID="Label12" runat="server" Text='<%# Bind("Producer_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hình ảnh" SortExpression="Image">
                            <ItemTemplate>
                                <asp:Label ID="Label13" runat="server" Text='<%# Bind("Image") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Giá nhập" SortExpression="Price_Import">
                            <ItemTemplate>
                                <asp:Label ID="Label14" runat="server" Text='<%# Bind("Price_Import") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Giá xuất" SortExpression="Price_Export">
                            <ItemTemplate>
                                <asp:Label ID="Label15" runat="server" Text='<%# Bind("Price_Export") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField EditText="Chọn" HeaderText="Chọn" ShowCancelButton="False" ShowEditButton="True"
                            UpdateText="Huỷ" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </center>
        </div>
    </div>
</asp:Content>
