<%@ Page Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="DoAn4.WebForm7" Title="Giỏ hàng" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Con1" runat="server">
    <div class="daukhungmain">
    <asp:Label ID="Label6" runat="server" Text="GIỎ HÀNG" Font-Bold="True" 
        Font-Names="Arial"></asp:Label>
    </div>
        <asp:Panel ID="PanelCoHang" runat="server">
<center>
<div style="margin-top:10px ">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
        CellPadding="3" Font-Size="Medium" ForeColor="Black" GridLines="Vertical"  
         Width="620px">
        <Columns>
            <asp:TemplateField HeaderText="Tên sản phẩm">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="False" 
                        ForeColor="Red" 
                        NavigateUrl='<%# "Chitiet.aspx?Product_ID="+Eval("Product_ID") %>' 
                        Text='<%# Bind("Product_Name") %>'></asp:HyperLink>
                </ItemTemplate>
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
                <ItemStyle ForeColor="Red" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SL">
                <ItemTemplate>
                    <asp:TextBox ID="txtSL" runat="server" Height="25px" 
                        Text='<%# Bind("Amount") %>' Width="30px"></asp:TextBox>
                </ItemTemplate>
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:TemplateField>
            <asp:BoundField DataField="Price_Export" HeaderText="Giá">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="Size" HeaderText="Size">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="Color" HeaderText="Màu">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="Material" HeaderText="Chất liệu">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="Weight" HeaderText="Trọng lượng">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="Product_ID" HeaderText="Mã SP">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="Money" HeaderText="Tiền">
                <HeaderStyle BackColor="Silver" ForeColor="Black" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <asp:CheckBox ID="CheckXoa" runat="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <EmptyDataTemplate>
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" 
                Text='<%# Bind("SL") %>' Width="41px"></asp:TextBox>
        </EmptyDataTemplate>
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#CCCCCC" />
    </asp:GridView>
    </div>
    <div style="text-align:right; margin:10px">
        <asp:Label ID="lblTTL" runat="server" Text="Tổng trọng lượng: "></asp:Label>
        <asp:Label ID="lblTongTL" runat="server"></asp:Label><br />
        <asp:Label ID="Label5" runat="server" Text="Tổng tiền: "></asp:Label>
        <asp:Label ID="lblTongTien" runat="server"></asp:Label>
    </div>
    <div style="border:1px solid #C0C0C0; background-color: #EFEFEF; padding:5px; margin:10px">
        <asp:ImageButton ID="btnCapNhat" runat="server" Height="25px" 
            ImageUrl="~/Anh/capnhat.jpg" Width="90px" ImageAlign="Left" 
            onclick="btnCapNhat_Click" />
        <asp:ImageButton ID="btnMuaTiep" runat="server" Height="25px" 
            ImageUrl="~/Anh/tieptucmuahang.jpg" Width="177.5px" 
            onclick="ImageButton2_Click"/>
        <asp:ImageButton ID="btnThanhToan" runat="server" Height="25px" 
            ImageUrl="~/Anh/thanhtoan.jpg" Width="112.5px" ImageAlign="Right" 
            onclick="btnThanhToan_Click" />
    </div>
    </center>
    </asp:Panel>
<asp:Panel ID="PanelKhongHang" runat="server">
<div style="border:1px solid #C0C0C0; background-color: #EFEFEF; padding:10px; margin:10px">
    <asp:Label ID="Label7" runat="server" 
        Text="Giỏ hàng của bạn hiện không có mặt hàng nào!"></asp:Label>
</div>
<div style="border:1px solid #C0C0C0; background-color: #EFEFEF; padding:7px; margin:10px; text-align:right">
     <asp:ImageButton ID="ImageButton1" runat="server" Height="25px" 
        ImageAlign="Middle" ImageUrl="~/Anh/tieptuc.jpg" Width="81px" 
         onclick="ImageButton1_Click" />
    </div>
</asp:Panel>
</asp:Content>
