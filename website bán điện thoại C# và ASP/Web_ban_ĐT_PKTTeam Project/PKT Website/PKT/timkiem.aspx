<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="timkiem.aspx.cs" Inherits="PKT.timkiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="same">
    <div id="re">
    <div id="tt-o">TÌM KIẾM</div>
    </div>
    <div id="same-1">
        <div id="tk1"><p>TÌM KIẾM NÂNG CAO</p></div>
        <div id="tk2"> TÌM KIẾM THEO TÊN SẢN PHẨM </div>
        <div id="tk2-1"> <p>Nhập tên sản phẩm: </br><p3> Ví dụ: Nokia 1280</p3></div>
        <div id="tk2-2"> <p>
            <asp:TextBox ID="key" runat="server" AutoPostBack="True" 
                ontextchanged="key_TextChanged" Width="223px"></asp:TextBox>
            </p> 
                            <asp:HyperLink ID="search_click1" runat="server">
                             <img src="Img/Images/icon/buttom_timkiem.png" />
                            </asp:HyperLink>
                       </p></div>
        <div id="tk2"> TÌM KIẾM THEO GIÁ SẢN PHẨM </div>
        <div id="tk2-1"> <p>Chọn hãng sản xuất:</p>Giá:
        </div>
        <div id="tk2-2"> 
            <p>
                        	<asp:DropDownList ID="ManuID" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ManuID_SelectedIndexChanged" 
                    Height="16px" Width="218px">
                            </asp:DropDownList>
                       &nbsp;</p>
                        	<asp:DropDownList ID="PriceFrom" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="FriceFrom_SelectedIndexChanged">
                                <asp:ListItem Value="0">Giá Từ...</asp:ListItem>
                                <asp:ListItem>1000000</asp:ListItem>
                                <asp:ListItem>2000000</asp:ListItem>
                                <asp:ListItem>3000000</asp:ListItem>
                            </asp:DropDownList>
                       &nbsp;<asp:DropDownList ID="PriceTo" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="PriceTo_SelectedIndexChanged">
                                <asp:ListItem Value="0">Giá đến...</asp:ListItem>
                                <asp:ListItem>3000000</asp:ListItem>
                                <asp:ListItem>9000000</asp:ListItem>
                            </asp:DropDownList>
                       &nbsp;</div>
        <div id="tk3"><p> 
                            <asp:HyperLink ID="search_click2" runat="server">
                             <img src="Img/Images/icon/buttom_timkiem.png" />
                            </asp:HyperLink>
                       </p></div>
        <div id="tk2"> TÌM KIẾM THEO CHỨC NĂNG </div>
        <table style="color:#0033FF;">
            <tr>
                <td width="35px"><img src="Img/Images/icon/icon_cam.gif" /></td>
                <td width="150px">Chụp hình</td>
                <td width="30px">
                    <asp:CheckBox ID="ct1" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct1_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/videoCamera_icon.gif" /></td>
                <td width="150px">Quay phim</td>
                <td width="30px">
                    <asp:CheckBox ID="ct3" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct3_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/icon_bt.gif" /></td>
                <td width="150px">Bluetooth</td>
                <td width="30px">
                    <asp:CheckBox ID="ct21" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct21_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/FM_icon.gif" /></td>
                <td width="150px">Nghe FM</td>
                <td width="30px">
                    <asp:CheckBox ID="ct6" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct6_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/GPRS_icon.gif"/></td>
                <td width="150px">GPRS</td>
                <td width="30px">
                    <asp:CheckBox ID="ct19" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct19_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/3G_icon.gif" /></td>
                <td width="150px">3G</td>
                <td width="30px">
                    <asp:CheckBox ID="ct17" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct17_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/icon_wifi.gif" /></td>
                <td width="150px">WiFi</td>
                <td width="30px">
                    <asp:CheckBox ID="ct20" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct20_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/icon_nhac.gif" /></td>
                <td width="150px">Nghe nhạc</td>
                <td width="30px">
                    <asp:CheckBox ID="ct5" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct5_CheckedChanged" />
                <td>
            </tr>
            <tr>
                <td width="35px"><img src="Img/Images/icon/TwoSim_icon.gif" /></td>
                <td width="150px">Đa sim</td>
                <td width="30px">
                    <asp:CheckBox ID="ct18" runat="server" AutoPostBack="True" 
                        oncheckedchanged="ct18_CheckedChanged" />
                <td>
            </tr>
        </table>
        <div id="tk3"><p> 
                            <asp:HyperLink ID="search_click3" runat="server">
                             <img src="Img/Images/icon/buttom_timkiem.png" />
                            </asp:HyperLink>
                       </p></div>
    </div>
</div>
</asp:Content>
