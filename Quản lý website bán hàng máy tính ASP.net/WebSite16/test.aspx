<%@ Page Language="C#" MasterPageFile="~/QuanTri.master" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" Title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="WedMayTinhDataContext" TableName="SanPhams" Where="MaSanPham<15">
</asp:LinqDataSource>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" PageSize="2" 
        AutoGenerateColumns="False" DataKeyNames="MaSanPham" 
        DataSourceID="LinqDataSource1" >
    <Columns>
        <asp:BoundField DataField="MaSanPham" HeaderText="MaSanPham" 
            InsertVisible="False" ReadOnly="True" SortExpression="MaSanPham" />
        <asp:BoundField DataField="TenSP" HeaderText="TenSP" SortExpression="TenSP" />
        <asp:BoundField DataField="LoaiSP" HeaderText="LoaiSP" 
            SortExpression="LoaiSP" />
        <asp:BoundField DataField="NhaSanXuat" HeaderText="NhaSanXuat" 
            SortExpression="NhaSanXuat" />
        <asp:BoundField DataField="MaNhaCungCap" HeaderText="MaNhaCungCap" 
            SortExpression="MaNhaCungCap" />
        <asp:BoundField DataField="BaoHanh" HeaderText="BaoHanh" 
            SortExpression="BaoHanh" />
        <asp:BoundField DataField="SoLuong" HeaderText="SoLuong" 
            SortExpression="SoLuong" />
        <asp:BoundField DataField="ThongSoKyThuat" HeaderText="ThongSoKyThuat" 
            SortExpression="ThongSoKyThuat" />
        <asp:BoundField DataField="GiaBan" HeaderText="GiaBan" 
            SortExpression="GiaBan" />
        <asp:BoundField DataField="HinhAnh" HeaderText="HinhAnh" 
            SortExpression="HinhAnh" />
        <asp:BoundField DataField="GhiChu" HeaderText="GhiChu" 
            SortExpression="GhiChu" />
    </Columns>
</asp:GridView>
</asp:Content>

