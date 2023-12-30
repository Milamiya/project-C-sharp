<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="Style/StyleSheet.css" rel="stylesheet" type="text/css" />
   
</head>
<body>
<form id="form1" runat="server">
<div id ="Laptop" >
<asp:DataList ID="DataList1"  runat="server" RepeatDirection="Horizontal" 
        Width="1000px"  Height="240px" 
        DataSourceID="LinqDataSource1" 
          CellPadding=0 CellSpacing=0 
        onselectedindexchanged="DataList1_SelectedIndexChanged" >
        <ItemTemplate>
       <div style="width:200px; height:50px " >
            <asp:Label ID="TenSPLabel"  runat="server" Text='<%# Eval("TenSP") %>' ToolTip='<%# Eval("ThongSoKyThuat") %>' />
            
            </div>
            <div style="width:200px; height:100px">
            <asp:ImageButton ID="HinhAnhLabel"  runat="server"  ImageUrl ='<%# Eval("HinhAnh") %>' ToolTip='<%# Eval("ThongSoKyThuat") %>' />
            <br />
            </div>
            <div style="width:200px; height:25px ">
            <asp:Label ID="GiaBanLabel"  runat="server" Text='<%# Eval("GiaBan") %>' ToolTip='<%# Eval("ThongSoKyThuat") %>' />
            <br />
            </div>
            <div style="width:200px; height:25px" >
            <asp:Label ID="ThongSoKyThuatLabel"  runat="server" 
                Text='<%# Eval("ThongSoKyThuat") %>' ToolTip='<%# Eval("ThongSoKyThuat") %>' />
                <asp:ImageButton ImageUrl='image/but_buy.jpg' />
            <br /> 
            <br />
            </div>
        </ItemTemplate>
</asp:DataList>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="WedMayTinhDataContext" TableName="SanPhams" 
        Select="new (TenSP, HinhAnh, GiaBan, ThongSoKyThuat)">
    </asp:LinqDataSource>
</div>
    </form>
</body>
</html>
