<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kieudang.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly= "CollectionPager" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center" > <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
    onselectedindexchanged="DataList1_SelectedIndexChanged" >
        <ItemTemplate>
            <table style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid;
                width: 100%; border-bottom: black 1px solid; height: 154px; background-color: #ffffff">
                <tr>
                    <td align="left" style="width: 100%; height: 12px; text-align: center" valign="middle">
                        <asp:Image ID="Image5" runat="server" Height="30px" 
                            ImageUrl='<%# "dienthoai/"+Eval("mahang")+".jpg" %>' Width="90px" />
                    </td>
                </tr>
                <tr>
                    <td align="center" style="width: 205px; height: 100px; text-align: center" valign="top">
                        <asp:Image ID="Image4" runat="server" Height="86px" ImageUrl='<%# "dienthoai/"+Eval("anh") %>'
                            Width="85px" />
                    </td>
                </tr>
                <tr>
                    <td align="center" style="width: 205px; height: 14px; text-align: center" valign="top">
                        <asp:HyperLink ID="HyperLink1" runat="server" Height="40px" 
                            Text='<%# Eval("tensp") %>' NavigateUrl='<%# Eval("chitiet") %>'></asp:HyperLink>
                        <br />
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("kieudang") %>'></asp:Label>
                    </td>
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
                            Width="56px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 205px; height: 18px; text-align: center" valign="top">
                        <asp:ImageButton ID="ImageButton2" runat="server" 
                            ImageUrl="~/Images/Chonmua1.jpg" CommandName="Select" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 205px; height: 18px; text-align: center" valign="top">
                        <asp:Label ID="Label10" runat="server" Font-Size="Smaller" Text="Đã đưa vào giỏ hàng"
                            Visible="False" Width="111px" 
                            style="color: #FF3300; font-size: small; background-color: #FFFFFF"></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList></div>
     <cc1:CollectionPager ID="clp1" runat="server"></cc1:CollectionPager>
</asp:Content>

