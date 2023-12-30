<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewsDetails.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="NewsID" 
        DataSourceID="SqlDataSource1">
        <ItemTemplate>
        <div>
            <asp:Label ID="CreatedLabel" runat="server" ForeColor="#999999" 
                Text='<%# Eval("Created") %>' />
        </div>
        <div>
            <asp:Label ID="TitleLabel" runat="server" Font-Bold="True" Font-Size="14pt" 
                ForeColor="#0066FF" Text='<%# Eval("Title") %>' />
        </div>
        <div>
            <asp:Label ID="DescriptionLabel" runat="server" ForeColor="#666666" 
                Text='<%# Eval("Description") %>' Font-Bold="True" Font-Size="13pt" 
                Font-Italic="False" />
        </div>
        <div style="height:25px;"></div>
        <div style="text-align:center;">
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageURL") %>' 
                ImageAlign="Middle" />
        </div>
        <div style="height:25px;"></div>
        <div>
            <asp:Label ID="ContentsLabel" runat="server" Text='<%# Eval("Contents") %>' 
                Font-Size="12pt" />
        </div>
        <div style="height:20px;"></div>
        <div style="float:right;padding-right:40px;">
            <asp:Label ID="PosterLabel" runat="server" Text='<%# Eval("Poster") %>' 
                Font-Bold="True" ForeColor="Black" ></asp:Label>
        </div>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [tbNews] WHERE ([NewsID] = @NewsID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="NewsID" QueryStringField="NewsID" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

