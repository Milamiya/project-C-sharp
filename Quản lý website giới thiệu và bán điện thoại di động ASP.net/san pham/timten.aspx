<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="timten.aspx.cs" Inherits="Default3" Title="Timkiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 24pt; color: #0000ff"><span style="font-size: 12pt"></span>
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" Font-Size="24pt" Text="KẾT QUẢ TÌM KIẾM" ForeColor="Black" Font-Bold="true"></asp:Label><br />
            <asp:Label ID="Label8" runat="server" Font-Size="Medium" ForeColor="black"
                Text="Kết quả tìm kiếm với từ khoá: "></asp:Label><br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="99%" CellPadding="4" Font-Size="12pt" ForeColor="#333333" GridLines="None">
                <Columns>
                    <asp:TemplateField HeaderText="Sản phẩm">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl='<%# "dienthoai/"+Eval("Anh") %>'
                                Width="80px" />
                        </ItemTemplate>
                        <HeaderStyle BackColor="#4584AF" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Th&#244;ng tin">
                        <ItemTemplate>
                            <div>
                                <asp:HyperLink ID="hplThongTin" runat="server" Font-Bold="True" Font-Size="Smaller"
                                    ForeColor="black" Text='<%# Eval("TenSP") %>' Width="100%"></asp:HyperLink>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#4584AF" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gi&#225; b&#225;n">
                        <EditItemTemplate>
                            &nbsp;
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" ForeColor="black" Text='<%# Bind("Gia") %>' Font-Size="Smaller"></asp:Label>
                            <asp:Label ID="Label9" runat="server" ForeColor="black" Text="VNĐ" Font-Size="Smaller"></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#4584AF" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="soluong" HeaderText="Số lượng">
                        <HeaderStyle BackColor="#4584AF" ForeColor="White" />
                        <ItemStyle Font-Bold="True" Font-Size="Small" ForeColor="black" />
                    </asp:BoundField>
                    <asp:HyperLinkField DataNavigateUrlFields="chitiet" HeaderText="chi tiet" Text="xem chi tiet"/>
                </Columns>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            &nbsp;</div>
    </span>
</asp:Content>

