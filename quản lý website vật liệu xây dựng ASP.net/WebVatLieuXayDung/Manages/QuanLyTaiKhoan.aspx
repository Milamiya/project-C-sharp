<%@ Page Language="C#" MasterPageFile="~/Manages/Account.master" AutoEventWireup="true"
    CodeFile="QuanLyTaiKhoan.aspx.cs" Inherits="Manages_QuanLyTaiKhoan" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceBody" runat="Server">
    <link href="StyleAccount/pageManageNews.css" rel="stylesheet" type="text/css" />
    <div class="bannerManager">
        <div class="menutop">
            <div style="background-position: center center; height: 67%; background-image: url('Icon/Button-Help-icon.png');
                background-repeat: no-repeat;">
            </div>
            <a href="#">Trợ giúp</a>
        </div>
        <%--<div class="menutop">
            <%--<div style="background-position: center center; height: 67%; background-image: url('Icon/cancel-icon.png');
                background-repeat: no-repeat; margin-bottom: 0px;">
            </div>
            <a href="#">Xóa tài khoản chọn</a>
        </div>--%>
        <div class="menutop">
            <asp:Panel ID="Panel1" runat="server" Height="100%">
                <div style="background-position: center center; height: 67%; background-image: url('Icon/add-1-icon.png');
                    background-repeat: no-repeat;">
                </div>
                <%--<a href="ThemTaiKhoan.aspx">Thêm tài khoản</a>--%><asp:HyperLink ID="btnThemTaiKhoan"
                    NavigateUrl="ThemTaiKhoan.aspx" runat="server">Thêm tài khoản</asp:HyperLink>
            </asp:Panel>
        </div>
    </div>
    <div>
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%"
            OnRowCommand="grid_RowCommand">
            <RowStyle ForeColor="#000066" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="AccountID" HeaderText="Tài khoản" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="FullName" HeaderText="Họ tên" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Số điện thoại" />
                <asp:ButtonField Text="Sửa" CommandName="btnSua" />
                <asp:ButtonField Text="Xóa" CommandName="btnXoa" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>
</asp:Content>
