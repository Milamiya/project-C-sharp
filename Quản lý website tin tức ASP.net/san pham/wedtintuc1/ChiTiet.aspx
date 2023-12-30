<%@ Page Language="C#" MasterPageFile="~/TrangChu.master" AutoEventWireup="true" CodeFile="ChiTiet.aspx.cs" Inherits="ChiTiet" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <link href="Css/ChiTietTin.css" rel="stylesheet" type="text/css" />
    <div style="height: auto">
     <div class="header-article">
         <asp:Literal ID="ltrTieuDeChuyenMuc" runat="server"></asp:Literal>
        </div>
    <div class="DivCha">
        <asp:DataList ID="DataList1" runat="server" OnItemDataBound="DataList1_ItemDataBound">
            <ItemTemplate>
                <asp:HiddenField ID="hdf_IDNews" runat="server" Value='<%# Eval("idNews") %>' />
                <div class="Box_Button">
                    <img src="themes/note.gif" />&nbsp<asp:Label ID="Label1" runat="server" Text='<%# Eval("Title") %>'></asp:Label>&nbsp
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("CreateDate") %>'></asp:Label>
                </div>
                <div class="tdDescription">
                    <p>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                    </p>
                </div>
                <div class="divTextContent">
                    <p style="text-align: center">
                        <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl='<%# Eval("Picture") %>'
                            CssClass="Anh" />
                    </p>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Content") %>'></asp:Label>
                </div>
                <div class="divTacGia">
                    <asp:Label ID="Label6" runat="server" Text="Tác giả: "></asp:Label>  <asp:Label ID="Label4" runat="server" Text='<%# Eval("Author") %>'></asp:Label>
                </div>
                <div class="divCuoiBai">
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div class="Box">
        <div class="tdDescription">
            <b>Các bài đã đăng</b></div>
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <div class="tdDescription">
                    <img src="themes/note.gif" />
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "ChiTiet.aspx?idNews="+Eval("idNews") %>'
                        Text='<%# Eval("Title") %>'></asp:HyperLink>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </div>
</asp:Content>

