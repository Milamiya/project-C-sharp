<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="phukien.aspx.cs" Inherits="Default2" Title="Phu kien
" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/dienthoaididong.mdb"
        SelectCommand="SELECT tblsanpham.masp,'chitiet.aspx?tensp='+tensp as chitiet, tblsanpham.mahang, tblsanpham.tensp, tblsanpham.gia, tblsanpham.soluong, tblsanpham.dacdiem, tblsanpham.baohanh, tblsanpham.khuyenmai, tblsanpham.kieudang, tblsanpham.phongcach, tblsanpham.anh, tblsanpham.ghichu, tblhang.tenhang FROM (tblsanpham INNER JOIN tblhang ON tblsanpham.mahang = tblhang.mahang) WHERE (tblsanpham.ghichu = 'phu kien')">
    </asp:AccessDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="AccessDataSource1" RepeatColumns="4">
        <ItemTemplate>
            <table style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid;
                width: 100%; border-bottom: black 1px solid; height: 154px; background-color: #ffffff">
                <tr>
                    <td align="left" style="width: 205px; height: 12px; text-align: center" valign="middle">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("tenhang") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" style="width: 205px; height: 100px; text-align: center" valign="top">
                        <asp:Image ID="Image4" runat="server" Height="86px" ImageUrl='<%# "dienthoai/"+Eval("anh") %>'
                            Width="85px" /></td>
                </tr>
                <tr>
                    <td align="center" style="width: 205px; height: 14px; text-align: center" valign="top">
                        <asp:HyperLink ID="HyperLink1" runat="server" Height="40px" Text='<%# Eval("tensp") %>' Width="102px" NavigateUrl='<%# Eval("chitiet") %>'></asp:HyperLink></td>
                </tr>
                <tr>
                    <td align="center" style="width: 205px" valign="top">
                        <div align="center" style="font-size: 12px; color: #cc0000; font-family: Tahoma">
                            <asp:Label ID="Label6" runat="server" Font-Size="Smaller" Text="Giá"></asp:Label>
                            <asp:Label ID="Label7" runat="server" Font-Size="Smaller" Text='<%# Eval("gia") %>'
                                Width="37px"></asp:Label>
                            <span style="font-size: 9pt">VNĐ</span></div>
                    </td>
                </tr>
                <tr>
                    <td style="width: 205px; height: 18px; text-align: center" valign="top">
                        <asp:Label ID="Label8" runat="server" Font-Size="Smaller" Text="Bảo hành"></asp:Label>
                        <asp:Label ID="Label9" runat="server" Font-Size="Smaller" Text='<%# Eval("baohanh") %>'
                            Width="56px"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 205px; height: 18px; text-align: center" valign="top">
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/Chonmua1.jpg" /></td>
                </tr>
                <tr>
                    <td style="width: 205px; height: 18px; text-align: center" valign="top">
                        <asp:Label ID="Label10" runat="server" Enabled="False" Font-Size="Smaller" Text="Đã đưa vào giỏ hàng"
                            Visible="False" Width="111px"></asp:Label></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

