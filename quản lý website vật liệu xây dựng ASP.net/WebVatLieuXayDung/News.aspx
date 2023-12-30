<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="News.aspx.cs" Inherits="News" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="Styles/News.css" rel="stylesheet" type="text/css" />
    <div>
        <div style="background: url('Images/Design/nenTieude2.gif') repeat-x; height: 28px">
            <span style="float: left; width: 100%; height: 100%; background: url('Images/Design/nentieude1.gif' )no-repeat;
                color: White"><span style="float: left; font-weight: bold; padding-top: 5px; padding-left: 35px">
                    <%#Eval("Title")%></span></span>
        </div>
        <div class="lw50h200New">
            <asp:Repeater ID="rptNews" runat="server">
                <ItemTemplate>
                    <div class="newOne">
                        <a href="NewDetail.aspx?idNew=<%#Eval("NewID")%>">
                            <h4 style="margin: 3px;">
                                <%#Eval("Title")%></h4>
                        </a>
                        <div style="width: 100%; border-bottom: solid thin #F0F0F0">
                            <div style="float: left; margin: 10px; margin-bottom: 0px; margin-right: 0; width: 150px;
                                height: 150px; text-align: center">
                                <img height="130px" width="150px" src="<%#Eval("Image")%>" />
                                <h5 style="margin: 0">
                                    (ảnh minh họa)</h5>
                            </div>
                            <div style="float: right; width: 570px; margin: 5px; margin-left: 0px; margin-top: 10px;
                                height: 150px">
                                <p style="height: 130px; text-align: justify; margin: 0">
                                    <%#Eval("SubTitle")%></p>
                                <p style="text-align: right; padding-right: 10px; color: #0299D2; margin: 0">
                                    <a href="NewDetail.aspx?idNew=<%#Eval("NewID")%>">Chi tiết</a></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
