<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="DonHangKhongXuLy.aspx.cs" Inherits="GiaoDien_DonHangKhongXuLy" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <div> Đơn hàng đã xử lý thành công</div>
    <div>
        <asp:Repeater ID="rptDonHang" runat="server" onitemcommand="rptDonHang_ItemCommand">
                        <HeaderTemplate>
                            <table border="1" cellpadding="0" cellspacing="0" class="tableRepeaterFirm">
                                <tr>
                                    <td class="header">
                                        Xử lý
                                        
                                    </td>
                                    <td class="header">
                                        Mã hóa đơn
                                    </td>
                                    <td class="header">
                                        Ngày đặt hàng
                                    </td>
                                    <td class="header">
                                        Ngày giao hàng
                                    </td>
                                    <td class="header">
                                        Tên khách hàng
                                    </td>
                                    <td class="header">
                                        Địa chỉ khách hàng
                                    </td>
                                    <%--<td class="header">
                                        Số lượng SP
                                    </td>
                                    <td class="header">
                                        Tổng tiền TT
                                    </td>--%>
                                    <td>
                                    </td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td style="text-align: center">
                                    <asp:CheckBox runat="server" ID="ckCheck" />
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lbmaHD" Text='<%#Eval("OrderID") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lbNgayDat" Text='<%#Eval("DateSet") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lbNgayGiao" Text='<%#Eval("DateDelivery") %>'></asp:Label>
                                </td>
                                
                                <td style="text-align: center">
                                    <asp:Label runat="server" ID="lbTenKH" Text='<%#Eval("UserName") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lbDCKH" Text='<%#Eval("Address") %>'></asp:Label>
                                </td>
                                <%--<td>
                                    <asp:Label runat="server" ID="lbSL" Text='1'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lbTongTien" Text='1'></asp:Label>
                                </td>--%>
                                <td>
                                    <%--<asp:LinkButton ID="lbtnDetail" Text="Chi tiết" runat="server" CommandName="ChiTiet"></asp:LinkButton>--%>
                                    <asp:Button  runat="server" ID="btnChiTiet" Text="ChiTiet..." CommandName="ChiTiet" CommandArgument='<%#Eval("OrderID") %>'/>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                    <div style="margin:10px auto auto 150px">
                        <table>
                            <tr>
                                <td><asp:Button runat="server" ID="btBack" Text="Trở về trang cũ" onclick="btBack_Click" 
                                         /></td>
                                <td><asp:Button runat="server" ID="btnXoa" Text="Xóa đơn hàng " onclick="btnXoa_Click" 
                                        
                                         /></td>
                            </tr>
                        </table>
                    </div>
    </div>
</div>
</asp:Content>

