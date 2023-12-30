<%@ Page Language="C#" MasterPageFile="~/TrangChu.master" AutoEventWireup="true" CodeFile="ChuyenMuc.aspx.cs" Inherits="ChuyenMuc" Title="Untitled Page" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link href="Css/ChuyenMuc.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    $(document).ready(function(){
    $("#sm_frm1").hide();
    });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
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
        <asp:DataList ID="DataList4" runat="server" Width="683px">
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
        <br />
        <div align="right">
            <cc1:CollectionPager ID="CollectionPager1" runat="server" BackText="« Trang Trước"
                LabelText="Trang:" NextText="Trang Tiếp »" ResultsFormat="Hiện tại: {0}-{1} (of {2})">
            </cc1:CollectionPager>
        </div>
</asp:Content>

