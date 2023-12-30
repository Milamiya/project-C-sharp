<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="PKT.sanpham" MaintainScrollPositionOnPostBack = "true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="d-page">
                <div id="d-o"><img src="Img/Images/icon/icon-first.gif" /></div>
                <div id="d-o"><asp:hyperlink id="lnkPre" runat="server"><img src="Img/Images/icon/icon-prev.gif" /></asp:hyperlink></div>
                <div id="d-o"><asp:Label ID="page" runat="server" BorderColor="Silver" 
                        BorderStyle="None" Font-Size="Small" Height="16px"></asp:Label></div>
                <div id="d-o"><asp:hyperlink id="lnkNext" runat="server"><img src="Img/Images/icon/icon-next.gif" /></asp:hyperlink></div>
                <div id="d-o"><img src="Img/Images/icon/icon-last.gif" /></div>
                <div id="count">Tìm thấy
                    <asp:Label ID="count" runat="server" Text="0"></asp:Label>
                    sản phẩm</div>
                <div id="order">Sắp xếp
                    <asp:DropDownList ID="order" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="order_SelectedIndexChanged">
                        <asp:ListItem Value="1">Giá tăng dần</asp:ListItem>
                        <asp:ListItem Value="2">Giá giảm dần</asp:ListItem>
                        <asp:ListItem Value="3">A-Z</asp:ListItem>
                        <asp:ListItem Value="4">Z-A</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div><img src="Img/Images/ghachcam.png" width="560px"/></div>
     </div>
    <div id="content-2">
        <asp:Repeater ID="data" runat="server">
            <ItemTemplate>
                <a href="chitiet_sp.aspx?id=<%#Eval("MaSP") %>" data-tooltip="<%#Eval("MaSP") %>">
                <div id="content-2-1">
                    <img src="<%# Eval("HinhAnh") %>"/>
                        <div id="content-2-1-1">
                            <br><%# Eval("TenSP") %>
                            <br><p1><%# Eval("GiaBan","{0:0,000 VNĐ}") %></p1></div>
                </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>      
    </div>

    <div id="mystickytooltip" class="stickytooltip">
        <asp:Repeater ID="detail" runat="server">
            <ItemTemplate>
	                <div id="<%#Eval("MaSP") %>" class="atip" style="width:200px">
                    <div id="tick1"><p5><%# Eval("TenSP") %> - <%# Eval("GiaBan","{0:0,000 VNĐ}") %></p5></div>
                    <div id="tick2"><p6><%#Eval("NoiBat") %></p6></div>  
                    </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>

    <div id="d-page">
                <div><img src="Img/Images/ghachcam.png" width="560px"/></div>
                <div id="d-o"><img src="Img/Images/icon/icon-first.gif" /></div>
                <div id="d-o"><asp:hyperlink id="lnkPre2" runat="server"><img src="Img/Images/icon/icon-prev.gif" /></asp:hyperlink></div>
                <div id="d-o"><asp:Label ID="page2" runat="server" BorderColor="Silver" 
                        BorderStyle="None" Font-Size="Small" Height="16px"></asp:Label></div>
                <div id="d-o"><asp:hyperlink id="lnkNext2" runat="server"><img src="Img/Images/icon/icon-next.gif" /></asp:hyperlink></div>
                <div id="d-o"><img src="Img/Images/icon/icon-last.gif" /></div>
                <div id="count">Tìm thấy
                    <asp:Label ID="count2" runat="server" Text="0"></asp:Label>
                    sản phẩm</div>
                <div id="order">Sắp xếp
                    <asp:DropDownList ID="order2" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="order2_SelectedIndexChanged">
                        <asp:ListItem Value="1">Giá tăng dần</asp:ListItem>
                        <asp:ListItem Value="2">Giá giảm dần</asp:ListItem>
                        <asp:ListItem Value="3">A-Z</asp:ListItem>
                        <asp:ListItem Value="4">Z-A</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </div>
     </div>
</asp:Content>
