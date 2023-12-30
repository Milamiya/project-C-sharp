<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Repeater runat="server" ID="rpt" OnItemCommand="rpt_ItemCommand">
        <ItemTemplate>
            <div class="new_giahang_new2">
                <div>
                    <div class="gianhang_left_new">
                        <img height="34" width="48" src="Images/Design/build_left1.gif"></div>
                    <div class="gianhang_right">
                        <img height="34" width="14" src="Images/Design/build_right1.gif"></div>
                    <div class="gianhang_center_new">
                        <asp:Label ID="lbTenSanPham" runat="server" Text="Label"></asp:Label></div>
                </div>
            </div>
            <div style="float: left; padding-right: 5px; width: 99%;">
                <div id="viewParts" style="width: 100%; float: left;">
                    <div style="width: 168px; float: left;">
                        <div class="adsimg_new">
                            <img height="100px" border="0" width="150px" onclick="objProducts.zoomProduct(5);"
                                id="img_1619" src="<%#Eval("Image")%>" />
                            <input type="hidden" value="Images/Products/bep-am-pc-3f1e-60acc-tc_1251691096.png"
                                id="img_preview_5" />
                        </div>
                    </div>
                    <div class="box_chitiet">
                        <div>
                            <table cellspacing="5" cellpadding="2" border="0" width="583px" class="detail_text">
                                <tbody>
                                    <tr>
                                        <td class="product_detail_name" colspan="2">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td nowrap="nowrap" width="25%">
                                            <b>Giá bán :</b>
                                        </td>
                                        <td>
                                            <div class="product_detail_price">
                                                &nbsp;<asp:Label ID="lbGiaTien" runat="server" Text='<%#Eval("Money")%>'></asp:Label>
                                                &nbsp; VNĐ &nbsp;&nbsp;
                                            </div>
                                        </td>
                                    </tr>
                                    <tr style="">
                                        <td bgcolor="#f9f9f9" style="border: 1px solid rgb(204, 204, 204); padding: 5px;"
                                            colspan="2">
                                            <div style="font-size: 13px;" class="normal" id="">
                                                <b>Gian hàng chưa đăng ký thuộc Hệ thống Gian hàng được Shopbuild đảm bảo</b>
                                            </div>
                                            <div style="float: left; width: 100%;">
                                                <b>(Toàn quốc)</b> <font class="width_price"></font>
                                                <asp:ImageButton ID="btnMuaHang" runat="server" ImageUrl="~/Images/Design/shopcart2.gif" />
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <br class="clear">
                    <br class="clear">
                    <!--Begin view attribute of product-->
                    <div style="float: left; width: 100%; border: 1px solid rgb(222, 222, 222); background: none repeat scroll 0% 0% rgb(249, 249, 249);
                        height: 22px;">
                        <img hspace="5" border="0" align="absmiddle" id="iconView" onclick="objProducts.viewAttPro(this)"
                            src="http://shopbuild.vn/templates/default//images/icon_min.gif" style="cursor: pointer;">
                        <b>Thông số kỹ thuật</b>
                    </div>
                    <div id="viewAttPro" style="display: block; margin: 8px;" class="detail_product_teaser_close">
                        <br />
                        Xuất xứ : <b>
                            <asp:Label ID="lbXuatXu" runat="server" Text='<%#Eval("Origin")%>'></asp:Label></b>
                        <br />
                        Hãng sản xuất : <b>
                            <asp:Label ID="lbHangSanXuat" runat="server" Text='<%#Eval("Maker")%>'></asp:Label></b>
                        <br />
                        Loại bếp : <b>
                            <asp:Label ID="lbLoai" runat="server" Text='<%#Eval("Goods")%>'></asp:Label></b>
                        <br />
                        Mầu sắc : <b>
                            <asp:Label ID="lbMau" runat="server" Text='<%#Eval("Color")%>'></asp:Label></b>
                        <br />
                        <br />
                        Tính năng : <b>
                            <asp:Label ID="lbTinhNang" runat="server" Text='<%#Eval("Features")%>'></asp:Label></b></b>
                        <br />
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
