<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Components.aspx.cs" Inherits="Default2"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="Css/Default.css" rel="stylesheet" type="text/css" />
    
    <script src="Css/jquery.min.js" type="text/javascript"></script>

    <script src="Css/System_Tooltip.js" type="text/javascript"></script>
    <style type="text/css">
    .a:hover
    {
    	color:Red;
    	}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ComponentDetailsID" 
        DataSourceID="SqlDataSource1" RepeatColumns="3" 
        onitemcommand="DataList1_ItemCommand">
        <ItemTemplate>
        <div class="border">
            <div style="padding:10px; width:90%;">
                <div style="width:100%; height:45px;">
                    
                    <asp:LinkButton ID="lblParameter" runat="server" Text='<%# Eval("Parameter") %>'
                     
                        PostBackUrl='<%#"~/ComponentDetails.aspx?ComponentDetailsID="+ Eval("ComponentDetailsID") %>' 
                        Font-Bold="True" Font-Size="Large" ForeColor="#0066FF" ></asp:LinkButton>
                    
                </div>
                <div style="width:100%;height:190px;">                    
                    <%--<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageURL") %>' Width="90%" />--%>
                    <img alt="hello" src='<%# Eval("ImageURL") %>' onmouseover="showtip('<div class=\'Title\'><%# Eval("Parameter") %></div><%# Eval("Parameter") %> Nhà sản xuất: <%# Eval("Manufacturer") %> Giá:<%# Eval ("Price") %>VNĐ Bảo hành: <%# Eval("Warranty") %> ');" onmouseout="hidetip();" width="90%"  />
                </div>                
                <div>
                <table>
                        <colgroup>
                            <col style="width: 130px; text-align: right;" />
                            <tr>
                                <td rowspan="2">
                                    <asp:Label ID="lblPrice" runat="server" ForeColor="Black" 
                                        Text='<%# Eval("Price") %>' />
                                    VNĐ</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="a"
                                        PostBackUrl='<%# "ComponentDetails.aspx?ComponentDetailsID=" + Eval("ComponentDetailsID") %>'>Chi tiết&gt;&gt;</asp:LinkButton>
                                    </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/Image/iconMuaHang.gif" CommandName="GioHang" />
                                </td>
                            </tr>
                        </colgroup>
                 </table>                
                 </div>                
            </div>
        </div>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [tbComponentDetails]"></asp:SqlDataSource>
</asp:Content>

