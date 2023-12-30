<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Default" Title="Trang chu" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    &nbsp;<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/dienthoaididong.mdb"
        SelectCommand="SELECT tblsanpham.masp, tblsanpham.tensp, tblsanpham.gia, tblsanpham.soluong, tblsanpham.dacdiem,'chitiet.aspx?tensp='+tensp as chitiet, tblsanpham.baohanh, tblsanpham.khuyenmai, tblsanpham.kieudang, tblsanpham.phongcach, tblsanpham.anh, tblsanpham.mahang, tblhang.tenhang FROM (tblsanpham INNER JOIN tblhang ON tblsanpham.mahang = tblhang.mahang) WHERE (tblsanpham.phongcach = 'độc đáo')">
    </asp:AccessDataSource>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
        <ItemTemplate>
            <table style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid;
                width: 142px; border-bottom: black 1px solid; height: 154px; background-color: #ffffff">
                <tr>
                    <td align="left" style="width: 205px; height: 12px; text-align: center" valign="middle">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("tenhang") %>'></asp:Label>
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
                        <asp:HyperLink ID="HyperLink1" runat="server" Height="40px" Text='<%# Eval("tensp") %>'
                            NavigateUrl='<%# Eval("chitiet") %>'></asp:HyperLink>
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
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/Chonmua1.jpg" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 205px; height: 18px; text-align: center" valign="top">
                        <asp:Label ID="Label10" runat="server" Enabled="False" Font-Size="Smaller" Text="Đã đưa vào giỏ hàng"
                            Visible="False" Width="111px"></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <HeaderTemplate>
            <table cellpadding="0" cellspacing="0">
                <tr>
                    <td colspan="2" height="32" style="font-weight: bold; background-image: url(Images/thanhngang2.gif);
                        background-repeat: repeat-x; color: White; width: 700px" align="center">
                        Để dễ dàng chọn hàng, bạn hãy kích vào nút Xem theo hàng hoặc cột
                    </td>
                </tr>
                <tr style="background-color: #d8d8d8">
                    <td>
                        Xem:
                        <asp:ImageButton ID="imgcot1" runat="server" Height="22px" ImageUrl="~/Images/sapxep1.jpg"
                            ToolTip="Hiển thị theo cột" Width="26px" />
                        <asp:ImageButton ID="imghang1" runat="server" Height="22px" ImageUrl="~/Images/sapxep2.jpg"
                            ToolTip="Hiển thị theo hàng" Width="26px" />
                    </td>
                    <td style="text-align: right">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" ForeColor="#40698F">
                            <asp:ListItem Value="theo">Sắp xếp theo</asp:ListItem>
                            <asp:ListItem Value="tang">Giá tăng dần</asp:ListItem>
                            <asp:ListItem Value="giam">Giá giảm dần</asp:ListItem>
                            <asp:ListItem Value="moi">Sản phẩm mới</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </HeaderTemplate>
    </asp:DataList>
    <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/dienthoaididong.mdb"
        SelectCommand="SELECT [soluong], [dacdiem], [phongcach], [tensp] FROM [tblsanpham] WHERE ([phongcach] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="phongcach" QueryStringField="độc đáo" Type="String"
                DefaultValue="độc đáo" />
        </SelectParameters>
    </asp:AccessDataSource>
    <asp:Panel ID="Panel1" runat="server" Height="142px" Width="247px">
        <asp:DataList ID="DataList2" runat="server" DataSourceID="AccessDataSource2" Height="16px"
            Width="155px" CellPadding="4" ForeColor="#333333" RepeatColumns="1" 
            UseAccessibleHeader="True" 
            onselectedindexchanged="DataList2_SelectedIndexChanged">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#FF3300"
                    Text='<%# Eval("tensp") %>'></asp:Label>
                <br />
                <asp:Label ID="Label11" runat="server" Text='<%# Eval("dacdiem") %>'></asp:Label>
                <br />
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <cc1:CollectionPager ID="clp1" runat="server" LabelText="Trang:" 
        ResultsFormat="Số trang {0}-{1} (trong  {2})">
    </cc1:CollectionPager>
    <ajaxToolkit:HoverMenuExtender ID="hme1" runat="server" TargetControlID="DataList1"
        PopupControlID="Panel1" PopupPosition="Right" PopDelay="25">
    </ajaxToolkit:HoverMenuExtender>
    <br />
</asp:Content>
