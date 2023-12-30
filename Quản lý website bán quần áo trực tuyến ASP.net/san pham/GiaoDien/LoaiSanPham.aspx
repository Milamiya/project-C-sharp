<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="LoaiSanPham.aspx.cs" Inherits="GiaoDien_LoaiSanPham" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <div >
    
        Danh sách loại sản phẩm<br /><br />
    </div>
    <div>
        <asp:GridView ID="grLoaiSP" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" 
            BackColor="#F3F3F3" DataKeyNames="ProductGroupID" DataSourceID="SqlDataSource2" 
            Height="295px" Width="403px" CellPadding="3" 
            onselectedindexchanged="grLoaiSP_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ProductGroupID" HeaderText="Mã loại sản phẩm"
                    InsertVisible="False" ReadOnly="True" SortExpression="ProductGroupID" 
                    ShowHeader="False" />
                <asp:BoundField DataField="ProductGroupName" HeaderText="Tên loại sản phẩm" 
                    SortExpression="ProductGroupName" />
                <asp:CommandField HeaderText="Sửa" ShowEditButton="True" />
                <asp:CommandField HeaderText="Xóa" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ShoponlineConnectionString %>" 
            SelectCommand="SELECT [ProductGroupID], [ProductGroupName] FROM [ProductGroups]">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ShoponlineConnectionString %>" 
            SelectCommand="SELECT [ProductCodeName], [ProductCodeID] FROM [ProductCodes]">
        </asp:SqlDataSource>
    </div>
</div>
</asp:Content>

