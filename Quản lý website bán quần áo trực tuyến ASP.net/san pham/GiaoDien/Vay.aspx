<%@ Page Language="C#" MasterPageFile="~/UserControl/NguoiDung.master" AutoEventWireup="true" CodeFile="Vay.aspx.cs" Inherits="GiaoDien_Vay" %>

<asp:Content ID="Conten1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="khung-giua">
<div class="slideshow">
        <img src="../Image/AnhQC/slide1.jpg" alt="anhQC" title="1" />
        <img src="../Image/AnhQC/slide2.jpg" alt="anhQC" title="2"/>
        <img src="../Image/AnhQC/slide3.jpg" alt="anhQC" title="3"/>
        <img src="../Image/AnhQC/slide4.jpg" alt="anhQC" title="4"/>
        <img src="../Image/AnhQC/slide5.jpg" alt="anhQC" title="5"/>
</div>
<div id="sp-moi">
<div class="title-giua">
Váy thời trang
</div>
<div style="float:left; margin-left:10px">
<asp:DataList ID="dlvay" runat="server" RepeatColumns="4" 
                RepeatDirection="Horizontal" Width="551px">
                <ItemTemplate>
                    <table>
                                <tr style="text-align: center; color: #1500FF; font-weight: bold; font-size: 15px">
                                    <td style="height: 35px">
                                        <asp:Label runat="server" ID="lbTenSP" Text='<%#Eval("ProductName") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr style="text-align: center">
                                    <td>
                                        <a href="#">
                                            <asp:HyperLink ID="hp1" runat="server" ImageUrl='<%#"~/Image/DoNu/"+Eval("Images") %>'
                                                Width="120px" Height="120px"
                                                NavigateUrl='<%# "ThongTinChiTietSP.aspx?ProductID="+Eval("ProductID") %>'>Hình ảnh</asp:HyperLink>
                    </td>
                                    </td>
                                </tr>
                                <tr style="text-align: center; color: black; font-weight: bold; font-size: 13px;
                                    height: 20px">
                                    <td>
                                        <asp:Label ID="lbGia" runat="server" Text='<%#Eval("Price")+" VNĐ" %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr style="text-align: center">
                                    <td>
                                        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Image/Icon/button_red_add_to_cart.jpeg"
                                            NavigateUrl="#"></asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                </ItemTemplate>
            </asp:DataList>
</div>
</div>
</div>
</asp:Content>
