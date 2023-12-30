<%@ Page Language="C#" MasterPageFile="~/TrangChu.master" AutoEventWireup="true" CodeFile="ChuyenMucCha.aspx.cs" Inherits="ChuyenMucCha" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<link href="Css/ChuyenMuc.css" rel="stylesheet" type="text/css" />
    <div align="center">
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    <div>
                        <div class="header-article">
                            <asp:Literal ID="ltrTieuDeChuyenMuc" runat="server"></asp:Literal>
                        </div>
                        <div class="topic-left">
                            <div class="dot_Hotnews">
                                <asp:Literal ID="ltrLastNews" runat="server"></asp:Literal>
                            </div>
                        </div>
                        <div class="topic-right">
                            <div class="box-topic">
                                <div class="box-topic-header">
                                    Xem nhiều
                                </div>
                                <div class="box-topic-body">
                                    <ul>
                                        <asp:Literal ID="ltrHotNews" runat="server"></asp:Literal>
                                    </ul>
                                </div>
                                <br class="clear">
                            </div>
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="Box_Button">
                        <img src="Images/MenuItem1.gif">&nbsp;<asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:DataList ID="dtl1" runat="server" Width="683px">
                            <ItemTemplate>
                                <div class="cont09">
                                    <div class="cont09im">
                                        <a href="ChiTiet.aspx?idNews=<%#Eval("idNews") %>">
                                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Picture") %>' />
                                        </a>
                                    </div>
                                    <div>
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "ChiTiet.aspx?idNews="+Eval("idNews") %>'
                                            Text='<%# Eval("Title") %>' CssClass="Hyper"></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="Box_Button">
                        <img src="Images/MenuItem1.gif">&nbsp;<asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:DataList ID="dtl2" runat="server" Width="683px">
                            <ItemTemplate>
                                <div class="cont09">
                                    <div class="cont09im">
                                        <a href="ChiTiet.aspx?idNews=<%#Eval("idNews") %>">
                                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Picture") %>' />
                                        </a>
                                    </div>
                                    <div>
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "ChiTiet.aspx?idNews="+Eval("idNews") %>'
                                            Text='<%# Eval("Title") %>' CssClass="Hyper"></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="Box_Button">
                        <img src="Images/MenuItem1.gif">&nbsp;<asp:Label ID="lbl3" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:DataList ID="dtl3" runat="server" Width="683px">
                            <ItemTemplate>
                                <div class="cont09">
                                    <div class="cont09im">
                                        <a href="ChiTiet.aspx?idNews=<%#Eval("idNews") %>">
                                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Picture") %>' />
                                        </a>
                                    </div>
                                    <div>
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "ChiTiet.aspx?idNews="+Eval("idNews") %>'
                                            Text='<%# Eval("Title") %>' CssClass="Hyper"></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="Box_Button">
                        <img src="Images/MenuItem1.gif">&nbsp;<asp:Label ID="lbl4" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:DataList ID="dtl4" runat="server" Width="683px">
                            <ItemTemplate>
                                <div class="cont09">
                                    <div class="cont09im">
                                        <a href="ChiTiet.aspx?idNews=<%#Eval("idNews") %>">
                                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Picture") %>' />
                                        </a>
                                    </div>
                                    <div>
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "ChiTiet.aspx?idNews="+Eval("idNews") %>'
                                            Text='<%# Eval("Title") %>' CssClass="Hyper"></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="Box_Button">
                        <img src="Images/MenuItem1.gif">&nbsp;<asp:Label ID="lbl5" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:DataList ID="dtl5" runat="server" Width="683px">
                            <ItemTemplate>
                                <div class="cont09">
                                    <div class="cont09im">
                                        <a href="ChiTiet.aspx?idNews=<%#Eval("idNews") %>">
                                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Picture") %>' />
                                        </a>
                                    </div>
                                    <div>
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "ChiTiet.aspx?idNews="+Eval("idNews") %>'
                                            Text='<%# Eval("Title") %>' CssClass="Hyper"></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

