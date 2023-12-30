<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="sanpham" Title="Trang Chủ" %>
<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly= "CollectionPager" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
            <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                DataFile="~/App_Data/dienthoaididong.mdb" 
                
                SelectCommand="SELECT masp, mahang, tensp, gia, soluong, dacdiem, baohanh, khuyenmai, kieudang, phongcach, anh, ghichu,'chitiet.aspx?tensp='+tensp as chitiet FROM tblsanpham WHERE (mahang = ?)">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="nk" Name="mahang" 
                        QueryStringField="mahang" Type="String" />
                </SelectParameters>
            </asp:AccessDataSource>
            <asp:DataList ID="DataList2" runat="server" DataKeyField="masp" 
                RepeatColumns="4" 
    onselectedindexchanged="DataList2_SelectedIndexChanged">
                <ItemTemplate>
                    <table 
                        style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid;
                width: 125px; border-bottom: black 1px solid; height: 154px; background-color: #ffffff">
                        <tr>
                            <td align="left" style="width: 205px; height: 12px; text-align: center" 
                                valign="middle">
                                <asp:Label ID="Label11" runat="server" Text='<%# Eval("tenhang") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="width: 205px; height: 100px; text-align: center" 
                                valign="top">
                                <asp:Image ID="Image4" runat="server" Height="86px" 
                                    ImageUrl='<%# "dienthoai/"+Eval("anh") %>' Width="85px" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="width: 205px; height: 14px; text-align: center" 
                                valign="top">
                                <asp:HyperLink ID="HyperLink1" runat="server" Height="40px" 
                                    Text='<%# Eval("tensp") %>' NavigateUrl='<%# Eval("chitiet") %>'></asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="width: 205px; height: 14px; text-align: center" valign="top">
                                </td>
                        </tr>
                        <tr>
                            <td align="center" style="width: 205px" valign="top">
                                <div align="center" 
                                    style="font-size: 12px; color: #cc0000; font-family: Tahoma">
                                    <asp:Label ID="Label6" runat="server" Font-Size="Smaller" Text="Giá"></asp:Label>
                                    <asp:Label ID="Label7" runat="server" Font-Size="Smaller" 
                                        Text='<%# Eval("gia") %>' Width="37px"></asp:Label>
                                    <span style="font-size: 9pt">VNĐ</span></div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 205px; height: 18px; text-align: center" valign="top">
                                <asp:Label ID="Label8" runat="server" Font-Size="Smaller" 
                                    Text='<%# Eval("baohanh") %>'></asp:Label>
                                <asp:Label ID="Label9" runat="server" Font-Size="Smaller" 
                                    Text='<%# Eval("baohanh") %>' Width="56px"></asp:Label>
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
                                <asp:Label ID="Label10" runat="server" Font-Size="Smaller" 
                                    Text="Đã đưa vào giỏ hàng" Visible="False" Width="111px" Height="16px" 
                                    style="color: #FF3300; font-size: small"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <HeaderTemplate>
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="2" height="32" 
                                style="font-weight: bold; background-image: url(Images/thanhngang2.gif); background-repeat: repeat-x; width: 700px; color: White" align="center">
                                Để dễ dàng chọn hàng, bạn hãy kích vào nút Xem theo hàng hoặc cột
                            </td>
                        </tr>
                        <tr style="background-color: #d8d8d8">
                            <td style="width: 206px; ">
                                Xem:
                                <asp:ImageButton ID="imgcot1" runat="server" Height="22px" 
                                    ImageUrl="~/Images/sapxep1.jpg" ToolTip="Hiển thị theo cột" Width="26px" />
                                <asp:ImageButton ID="imghang1" runat="server" Height="22px" 
                                    ImageUrl="~/Images/sapxep2.jpg" ToolTip="Hiển thị theo hàng" Width="26px" />
                            </td>
                            <td style="text-align: right">
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                    ForeColor="#40698F">
                                    <asp:ListItem Value="theo">Sắp xếp theo</asp:ListItem>
                                    <asp:ListItem Value="tang">Giá tăng dần</asp:ListItem>
                                    <asp:ListItem Value="giam">Giá giảm dần</asp:ListItem>
                                    <asp:ListItem Value="moi">Sản phẩm mới</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                </asp:DataList><span style="color: #0000ff; text-decoration: underline"></span><cc1:CollectionPager ID="clp1" runat="server"></cc1:CollectionPager>
        </asp:Content>

