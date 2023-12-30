<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <img src="Image/thongtingiohang.gif" style="width: 256px; height: 61px" />&nbsp;
    <div><asp:Label ID="lbThongbao" runat="server" Text="Hiện không có sản phẩm nào trong giỏ hàng của bạn" Enabled="false"></asp:Label></div>
    <asp:GridView 
        ID="gvCart" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ProductID"  Width="750px" CellPadding="4" 
        ForeColor="#333333" Height="201px" onrowcommand="gvCart_RowCommand" 
        onrowdeleting="gvCart_RowDeleting" onrowediting="gvCart_RowEditing"   
       >
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="ProductName" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="Price" HeaderText="Giá tiền" />
            <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtNumber" runat="server" Text='<%# Bind("Number") %>' 
                        Width="30px"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Total" HeaderText="Tổng tiền" />
            <asp:ButtonField CommandName="Sua" HeaderText="Sửa" Text="Sửa" />
            <asp:CommandField DeleteText="Xóa" HeaderText="Xóa" ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" BorderColor="Black" BorderWidth="1px" 
            ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>    
        <div style="padding-left:415px;padding-top:7px;margin-top:3px;border:1px solid black;height:30px; font-size:11pt;font-family:.VnTime">
            <b>Tổng tiền thanh toán là:&nbsp;&nbsp</b><asp:Label ID="lbTongTien" runat="server" 
                Font-Bold="True" Font-Italic="False" ForeColor="#CC0000" 
                onload="lbTongTien_Load"></asp:Label>   
            <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="VNĐ"></asp:Label>
        </div>   
        <div style="height:20px;"></div>
        <div style="width:350px; padding-left:480px;">
        <div style="float:left; margin-right:20px;">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Image/tieptucmuahang.bmp" PostBackUrl="~/HomePage.aspx" /></div>             
        <div>
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/Image/thanh toan.jpg" onclick="ImageButton2_Click" /></div>
        </div>                       
</asp:Content>

