<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kiemtragiohang.aspx.cs" Inherits="kiemtragiohang" Title="Kiem tra gio hang " %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="color: black; font-weight: bold; font-size: 15pt"><h1 align="center"><b> Thông tin về giỏ hàng của bạn:</b></h1>
    </div>
    <div>
        <table cellpadding="0" cellspacing="0" style="color: black">
            <tr>
                <td>
                    &nbsp;&nbsp; Khách hàng:&nbsp;</td>
                <td>
                    <asp:Label ID="lbTenKhachHang" runat="server" Text="Label" Font-Bold="True" 
                        ForeColor="black"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp; Địa chỉ:&nbsp;</td>
                <td>
                    <asp:Label ID="lbdiachiKH" runat="server" Text="Label" Font-Bold="True" 
                        ForeColor="black"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp; Ngày đặt hàng:&nbsp;<br />
                                        </td>
                <td>
                    <asp:Label ID="lbNgayDat" runat="server" Text="Label" Font-Bold="True" 
                        ForeColor="black"></asp:Label>
                    <br />
                </td>
            </tr>
        </table>
    </div>
    <div style="color: black; font-size: 15pt; font-weight: bold; height: 67px;">&nbsp;&nbsp; <br />
                Các sản phẩm bạn đã chọn:<br />
                            </div>
    <div align="center">
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Outset">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" 
                BorderColor="blue" BorderStyle="Solid" BorderWidth="1px" Height="222px">
                <RowStyle BackColor="white" ForeColor="black" />
                <Columns>
                    <asp:TemplateField HeaderText="Sản phẩm" HeaderStyle-ForeColor="Black">
                        <ItemTemplate>
                            <asp:Label ID="Label19" runat="server" Text='<%# Eval("TenSP") %>' 
                                Width="99%" style="margin-bottom: 0px"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Số lượng" HeaderStyle-ForeColor="Black">
                        <ItemTemplate>
                            <asp:Label ID="Label20" runat="server" Text='<%# Eval("SoLuong") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Đơn giá" HeaderStyle-ForeColor="Black">
                        <ItemTemplate>
                            <asp:Label ID="Label21" runat="server" Text='<%# Eval("Gia") %>' 
                                Font-Bold="True" Font-Size="11pt" ForeColor="black"></asp:Label>
                            <br />
                            VNĐ
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tổng giá" HeaderStyle-ForeColor="Black">
                        <ItemTemplate>
                            <asp:Label ID="Label22" runat="server" Text='<%# Eval("TongGia") %>' 
                                Font-Bold="True" Font-Size="11pt" ForeColor="black"></asp:Label>
                            <br />
                            VNĐ
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle BackColor="#ECE9D8" BorderColor="Yellow" BorderStyle="Solid" 
                    BorderWidth="2px" Font-Bold="True" Font-Size="13pt" ForeColor="#CC3300" 
                    Height="30px" />
            </asp:GridView>
        </asp:Panel>
    </div>
    <div>
        <asp:Label ID="lbtien" runat="server" Text="Label" Font-Bold="True" 
            Font-Size="14pt" ForeColor="black"></asp:Label>
    </div>
    <div style="height: 34px; margin-bottom: 0px;" align="left">
        &nbsp;&nbsp;&nbsp;
        <br />
    </div>
    <div style="height: 29px; color: black; font-weight: bold; font-size: 15pt;">&nbsp;&nbsp; Thông báo:<asp:Label ID="lbthongbao" runat="server" Font-Bold="True" Font-Size="12pt" 
            ForeColor="blue"></asp:Label>
        <br />
    </div>
    <div align="center" 
    style="height: 55px; color: black; font-size: 15pt; font-weight: bold;">
        <br />
        <asp:Label ID="Label23" runat="server" 
            Text="Cảm ơn quý khách đã chọn mua hàng tại Website."></asp:Label>
        <br />
        &nbsp;<table cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:Button ID="btndatlaihang" runat="server" Text="Đặt lại Hàng" onclick="btndatlaihang_Click" Font-Bold="true" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:Button ID="btndathang" runat="server"  Text="Đặt Hàng" onclick="btndathang_Click" Font-Bold="true" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

