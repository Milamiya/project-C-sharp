<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="trangchu.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:GridView ID="GridView1" runat="server" OnPageIndexChanging="Gridview1_PageIndexChanging"  AllowPaging="True" AutoGenerateColumns="False" style="z-index: 100; left: 185px; position: absolute; top: 227px" Width="531px" PageSize="3">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table>
                        <tr>
                            <td colspan="2">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("macb","sanpham.aspx?macb={0}") %>' Text='<%# Eval("tencb") %>' Font-Bold="True" Font-Overline="False" Font-Size="Larger" Font-Strikeout="False" Font-Underline="False" ForeColor="DodgerBlue" Width="291px"></asp:HyperLink></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("hinh") %>' /></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("thongtintomtat") %>'></asp:Label>
                                <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="DodgerBlue" NavigateUrl='<%# Eval("macb","sanpham.aspx?macb={0}") %>'
                                    Width="153px">Chi tiết</asp:HyperLink></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                Ngày đăng:
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("ngaydang") %>'></asp:Label></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerStyle Wrap="False" />
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Larger"
        ForeColor="White" Style="z-index: 102; left: 394px; position: absolute; top: 199px"
        Text="CHUYẾN BAY MỚI"></asp:Label>
</asp:Content>

