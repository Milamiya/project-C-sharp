<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sanpham.aspx.cs" Inherits="sanpham" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 100; left: 182px; position: absolute; top: 235px" Width="543px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table>
                        <tr>
                            <td colspan="2">
                                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="Larger"
                                    ForeColor="DodgerBlue" Text='<%# Eval("tencb") %>'></asp:HyperLink></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("hinh") %>' /></td>
                        </tr>
                        <tr>
                            <td style="width: 184px">
                                Giá vé phổ thông:
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("giavept") %>'></asp:Label></td>
                            <td style="width: 311px">
                                Giá vé thương gia:
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("giavetg") %>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 184px">
                                Lịch bay:
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("lichbay") %>'></asp:Label></td>
                            <td style="width: 311px">
                                Giờ bay:
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("giobay") %>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("thongtinchitiet") %>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                Ngày đăng:
                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("ngaydang") %>'></asp:Label></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White"
        Style="z-index: 101; left: 379px; position: absolute; top: 199px" Text="CHI TIẾT THÔNG TIN"></asp:Label>
</asp:Content>

