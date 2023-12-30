<%@ Page Language="C#" MasterPageFile="~/Manages/MasterPageM.master" AutoEventWireup="true"
    CodeFile="QuanLyBaiViet.aspx.cs" Inherits="Manages_QuanLyBaiViet" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMasterPageManages" runat="Server">
    <div>
        <div class="bannerManager">
            <div class="menutop">
                <div style="background-position: center center; height: 67%; background-image: url('Picture/Icon/Button-Help-icon.png');
                    background-repeat: no-repeat;">
                </div>
                <a href="#">Trợ giúp</a>
            </div>
            <div class="menutop">
                <div style="background-position: center center; height: 67%; background-image: url('Picture/Icon/cancel-icon.png');
                    background-repeat: no-repeat; margin-bottom: 0px;">
                </div>
                <a href="#">Xóa bài chọn</a>
            </div>
            <div class="menutop">
                <div style="background-position: center center; height: 67%; background-image: url('Picture/Icon/add-1-icon.png');
                    background-repeat: no-repeat;">
                </div>
                <a href="ThemBaiViet.aspx">Thêm bài viết</a>
            </div>
        </div>
        <div class="danhmuc">
            <div style="height: 33px; border-bottom: thin solid #e1e1e1">
                <div style="width: 45%; float: left; height: 121%" align="left">
                    Tìm bài viết&nbsp;<asp:TextBox ID="txtTimKiem" runat="server" Width="190px" Height="25px"></asp:TextBox>
                    <asp:Button ID="btnTimKiem" runat="server" Text="TimKiem" OnClick="btnTimKiem_Click" />
                </div>
                <div style="width: 53%; float: right; height: 100%; text-align: right">
                    &nbsp&nbsp
                </div>
                <div style="clear: both;">
                </div>
            </div>
            <div style="width: 100%; padding-left: 0px; clear: left;">
                <asp:GridView ID="grvTin" runat="server" Width="100%" PageSize="15" AutoGenerateColumns="False"
                    OnRowCommand="grvTin_RowCommand" AllowPaging="True" AllowSorting="True" 
                    onpageindexchanging="grvTin_PageIndexChanging">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <input type="checkbox" id="chkAll" name="chkAll" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkSelect" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowSelectButton="True" SelectText="Thông tin" />
                        <asp:BoundField DataField="NewID" HeaderText="Mã tin" />
                        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" />
                        <asp:BoundField DataField="CreateDate" HeaderText="Ngày đăng" />
                        <asp:BoundField HeaderText="Tổng xem" DataField="TotalView" />
                        <asp:BoundField HeaderText="Trạng Thái" DataField="IsPost" />
                        <asp:ButtonField Text="Sửa" CommandName="btnSua" ButtonType="Button">
                            <ControlStyle BackColor="#0099FF" />
                        </asp:ButtonField>
                        <asp:ButtonField Text="Xóa" CommandName="btnXoa" ButtonType="Button">
                            <ControlStyle BackColor="#0099FF" />
                        </asp:ButtonField>
                    </Columns>
                </asp:GridView>
            </div>
            <div style="text-align: center; height: 20px; width: 900px;" align="center">
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            </div>
        </div>
    </div>
</asp:Content>
