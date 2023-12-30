<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="MuaHang.aspx.cs" Inherits="MuaHang" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="Js/jquery-1.7.js" type="text/javascript"></script>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="Styles/MuaHang.css" rel="stylesheet" type="text/css" />
    <div id="viewContent" class="box_new_1">
        <div class="viewCart">
            <div class="title_name_cart">
                Trung Tâm Thiết Bị Gia Dụng (Số 78 Cao Thắng, P4, Q3, Tp Hưng yên - Tel: 838341934)</div>
            <asp:Repeater ID="rptOrder" runat="server" OnItemCommand="rptOrder_ItemCommand" OnItemDataBound="rptOrder_ItemDataBound">
                <HeaderTemplate>
                    <table class="tableOrder" border="1" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td class="header1" style="width: 25px">
                                STT
                            </td>
                            <td class="header1">
                                Mã sản phẩm
                            </td>
                            <td class="header1">
                                Tên sản phẩm
                            </td>
                            <td class="header1">
                                Đơn giá
                            </td>
                            <td class="header1">
                                Số lượng
                            </td>
                            <td class="header1">
                                Thành tiền
                            </td>
                            <td class="header1" style="border-right: thin solid #ccc">
                            </td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbsoluong" runat="server" Text="Label"></asp:Label>
                    <tr>
                        <td class="header1" style="border-top: none">
                            <label id="lbSTT">
                                <%#Eval("STT")%>
                            </label>
                        </td>
                        <td class="header1" style="border-top: none">
                            <label id="lbMaSP">
                                <%#Eval("MaHang")%>
                            </label>
                        </td>
                        <td class="header1" style="border-top: none">
                            <label id="lbTenSP">
                                <%#Eval("TenMatHang")%>
                            </label>
                        </td>
                        <td class="header1" style="border-top: none">
                            <asp:Label ID="lbGiaTien" runat="server" Text='<%#Eval("DonGia")%>'></asp:Label>
                        </td>
                        <td class="header1" style="border-top: none">
                            <asp:TextBox ID="txtSoLuong" Width="40px" Text='<%#Eval("SoLuong")%>' runat="server"></asp:TextBox>
                        </td>
                        <td class="header1" style="border-top: none">
                            <asp:Label ID="lbThanhTien" runat="server" Text='<%#Eval("ThanhTien")%>'></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                    <div align="right" style="float: left; width: 96%; padding-top: 10px;">
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <div align="center">
            <asp:Button ID="btnThanhToan" runat="server" OnClick="btnThanhToan_Click" Text="Hoàn tất mua hàng" />
            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnTiepTucMuaHang" runat="server" Text="Tiếp tục mua hang" OnClick="btnTiepTucMuaHang_Click" />
        </div>
    </div>
</asp:Content>
