<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Products.aspx.cs" Inherits="Products" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="Styles/Products.css" rel="stylesheet" type="text/css" />
    <div>
        <div style="background: url('Images/Design/nenTieude2.gif') repeat-x; height: 28px">
            <span style="float: left; width: 100%; height: 100%; background: url('Images/Design/nentieude1.gif' )no-repeat;
                color: White"><span style="float: left; font-weight: bold; padding-top: 5px; padding-left: 35px">
                    <%#Eval("Title")%>Các sản phẩm</span></span>
        </div>
        <div class="lw50h200New">
            <asp:DataList ID="dtlProducts" runat="server" RepeatColumns="4" Width="100%" OnItemDataBound="dtlProducts_ItemDataBound">
                <ItemTemplate>
                    <div class="sanpham">
                        <div class="imageSP">
                            <asp:Label runat="server" Visible="false" ID="lbMa" Text='<%#Eval("ProductID")%>'></asp:Label>
                            <a href="ProductDetail.aspx?idp=<%#Eval("ProductID")%>"><span>
                                <%#Eval("Title")%></span> 
                                    <img src="<%#Eval("Image")%>" />
                        </div>
                        <div class="giaban">
                            <p>
                                Sản xuất: <b><i>
                                    <%#Eval("Production")%></i></b></p>
                            <p>
                                Giá bán:<b><i><%#Eval("Money")%></i></b>
                            </p>
                        </div>
                        <asp:ImageButton ID="btnMuaHang" ImageUrl="~/Images/Design/Muahang.png" runat="server" />
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
