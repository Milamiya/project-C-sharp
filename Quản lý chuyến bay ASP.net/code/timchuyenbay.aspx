<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="timchuyenbay.aspx.cs" Inherits="timchuyenbay" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White"
        Style="z-index: 100; left: 393px; position: absolute; top: 199px" Text="TÌM CHUYẾN BAY"></asp:Label>
    <table style="z-index: 100; left: 150px; position: absolute; top: 225px">
        <tr>
            <td style="width: 49px; height: 55px">
                <asp:Label ID="Label4" runat="server" Text="Loại vé" Font-Bold="True" Width="50px"></asp:Label></td>
            <td style="width: 105px; height: 55px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged"
                    RepeatDirection="Horizontal" Width="208px">
                    <asp:ListItem Value="khuhoi">Khứ hồi</asp:ListItem>
                    <asp:ListItem Value="motchieu">Một chiều</asp:ListItem>
                </asp:RadioButtonList></td>
            <td style="width: 44px; height: 55px">
                &nbsp;</td>
            <td style="width: 139px; height: 55px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1"
                    ErrorMessage="Vui lòng chọn loại vé"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 49px; height: 43px;">
                <asp:Label ID="Label2" runat="server" Text="Từ" Font-Bold="True"></asp:Label></td>
            <td style="width: 105px; height: 43px;">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>H&#224; Nội</asp:ListItem>
                    <asp:ListItem>Hồ Ch&#237; Minh</asp:ListItem>
                    <asp:ListItem>Nha Trang</asp:ListItem>
                    <asp:ListItem>Ph&#250; Y&#234;n</asp:ListItem>
                    <asp:ListItem>Hải Ph&#242;ng</asp:ListItem>
                    <asp:ListItem>Đ&#224; Nẵng</asp:ListItem>
                    <asp:ListItem>Gia Lai</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 44px; height: 43px;">
                <asp:Label ID="Label3" runat="server" Text="Đến" Font-Bold="True"></asp:Label></td>
            <td style="width: 139px; height: 43px;">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Hồ Ch&#237; Minh</asp:ListItem>
                    <asp:ListItem>H&#224; Nội</asp:ListItem>
                    <asp:ListItem>Đ&#224; Nẵng</asp:ListItem>
                    <asp:ListItem>Ph&#250; Y&#234;n</asp:ListItem>
                    <asp:ListItem>Gia Lai</asp:ListItem>
                    <asp:ListItem>Hải Ph&#242;ng</asp:ListItem>
                    <asp:ListItem>Nha Trang</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 49px; height: 22px;">
                <asp:Label ID="Label5" runat="server" Text="Ngày đi" Font-Bold="True" Width="52px"></asp:Label></td>
            <td style="width: 105px; height: 22px;">
                <asp:Calendar ID="Calendar1" runat="server" ForeColor="#004040">
                    <SelectedDayStyle BorderColor="#004040" BorderStyle="Dotted" />
                    <DayStyle BorderStyle="Dotted" />
                    <DayHeaderStyle BorderStyle="Solid" />
                    <TitleStyle BorderStyle="Dashed" />
                </asp:Calendar>
            </td>
            <td style="width: 44px; height: 22px;">
                <asp:Label ID="Label6" runat="server" Text="Ngày về" Width="58px" Font-Bold="True"></asp:Label></td>
            <td style="width: 139px; height: 22px;">
                <asp:Calendar ID="Calendar2" runat="server" ForeColor="#004040">
                    <SelectedDayStyle BorderColor="#004040" BorderStyle="Dotted" />
                    <TodayDayStyle BorderColor="#004040" />
                    <DayStyle BorderStyle="Dotted" />
                    <DayHeaderStyle BorderStyle="Solid" />
                    <TitleStyle BorderStyle="Dashed" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="width: 49px; height: 35px">
            </td>
            <td style="width: 105px; height: 35px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 100;
                    left: 260px; position: absolute; top: 361px" Text="Tìm chuyến bay" Width="109px" />
                <asp:DropDownList ID="DropDownList3" runat="server" Style="z-index: 101; left: 318px;
                    position: absolute; top: 330px">
                    <asp:ListItem>Phổ th&#244;ng</asp:ListItem>
                    <asp:ListItem>Thương gia</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label7" runat="server" Style="z-index: 103; left: 249px; position: absolute;
                    top: 331px" Text="Hạng vé" Width="63px" Font-Bold="True"></asp:Label>
                <asp:Image ID="Image5" runat="server" ImageUrl="~/hinh anh/67.jpg" Style="z-index: 100;
                    left: 3px; position: absolute; top: 393px" />
            </td>
            <td style="width: 44px; height: 35px">
            </td>
            <td style="width: 139px; height: 35px">
            </td>
        </tr>
        <tr>
            <td style="width: 49px; height: 14px">
            </td>
            <td style="width: 105px; height: 14px">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White"
                    Style="z-index: 100; left: 220px; position: absolute; top: 401px" Text="KẾT QUẢ TÌM KIẾM"
                    Width="178px"></asp:Label>
            </td>
            <td style="width: 44px; height: 14px">
            </td>
            <td style="width: 139px; height: 14px">
            </td>
        </tr>
        <tr>
            <td style="width: 49px; height: 21px">
            </td>
            <td colspan="3" style="height: 21px">
                &nbsp;
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                    Style="z-index: 100; left: 6px; position: absolute; top: 437px" Width="593px">
                    <RowStyle BackColor="#EFF3FB" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 102; left: 7px; position: absolute; top: 604px" Width="589px">
                    <RowStyle BackColor="#EFF3FB" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

