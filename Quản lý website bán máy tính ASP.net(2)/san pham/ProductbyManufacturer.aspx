<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductbyManufacturer.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" 
        DataSourceID="SqlDataSource1"
        RepeatColumns="3">
        <ItemTemplate>
        <div class="border">
            <div style="padding:10px;width:90%;">
                <div style="width:100%;height:40px;">
                <asp:Label ID="ProductNameLabel" runat="server" 
                    Text='<%# Eval("ProductName") %>' Font-Bold="True" Font-Size="Large" 
                        ForeColor="#0066FF" />
                </div>        
                <div style="width:100%;height:190px;">
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageURL") %>' 
                        Width="200px" />
                </div>
                <div>
                    <table style="table-layout:fixed">
                        <colgroup>
                            <col style="width: 130px; text-align: right;" />
                            <tr>
                                <td rowspan="2">
                                    <asp:Label ID="PriceLabel" runat="server" ForeColor="Black" 
                                        Text='<%# Eval("Price") %>' />
                                    VNĐ</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                        PostBackUrl='<%# "ProductDetails.aspx?ProductID=" + Eval("ProductID") %>'>Chi tiết&gt;&gt;</asp:LinkButton>
                                    </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/Image/iconMuaHang.gif" />
                                </td>
                            </tr>
                        </colgroup>
                    </table>
                </div> 
             </div>
        </div>                   
        </ItemTemplate>
    </asp:DataList>
    <asp:DataList ID="DataList2" runat="server" DataKeyField="ComponentDetailsID" 
        DataSourceID="SqlDataSource2" RepeatColumns="3">
        <ItemTemplate>
            <div class="border">
            <div style="padding:10px; width:90%;">
                <div style="width:100%; height:45px;">
                    
                    <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("Parameter") %>'
                     
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
                                    <asp:Label ID="Label1" runat="server" ForeColor="Black" 
                                        Text='<%# Eval("Price") %>' />
                                    VNĐ</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                        PostBackUrl='<%# "ComponentDetails.aspx?ComponentDetailsID=" + Eval("ComponentDetailsID") %>'>Chi tiết&gt;&gt;</asp:LinkButton>
                                    </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/Image/iconMuaHang.gif" PostBackUrl="~/Cart.aspx" />
                                </td>
                            </tr>
                        </colgroup>
                 </table>                
                 </div>                
            </div>
        </div>
        </ItemTemplate>
    </asp:DataList>
     <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [tbComponentDetails] WHERE ([Manufacturer] = @Manufacturer)">
         <SelectParameters>
             <asp:QueryStringParameter Name="Manufacturer" QueryStringField="Manufacturer" 
                 Type="String" />
         </SelectParameters>
    </asp:SqlDataSource>
     <%--<div style="width:750px;"> 
        So mau tin:<asp:Label ID="lbcount" runat="server" Text="Lable"></asp:Label>                 
         Dang xem san pham tu so<asp:Label ID="lbCurrentPage" runat="server" Text="0"></asp:Label>
         den so<asp:Label ID="lbPageSize" runat="server" Text="1"></asp:Label>
         <asp:LinkButton ID="lbPreview" runat="server">Preview</asp:LinkButton>
            <asp:LinkButton ID="lbNext" runat="server" Font-Underline="True" 
                onclick="lbNext_Click">Next</asp:LinkButton>             
    </div>--%>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"         
        SelectCommand="SELECT * FROM [tbProduct] WHERE ([Manufacturer] = @Manufacturer)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Manufacturer" QueryStringField="Manufacturer" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

