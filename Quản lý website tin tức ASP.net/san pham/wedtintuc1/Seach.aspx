<%@ Page Language="C#" MasterPageFile="~/TrangChu.master" AutoEventWireup="true" CodeFile="Seach.aspx.cs" Inherits="Seach" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <link href="Css/ChuyenMuc.css" rel="stylesheet" type="text/css" />
 <div>
        <asp:Panel ID="pnSearch" runat="server">
            <asp:DataList ID="dtlSearch" runat="server" Width="683px">
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
        </asp:Panel>
    </div>
</asp:Content>

