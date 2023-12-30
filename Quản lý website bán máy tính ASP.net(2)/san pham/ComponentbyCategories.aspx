<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ComponentbyCategories.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-bottom:20px;">
        <asp:DropDownList ID="ddlSapXep" runat="server" Width="150px" 
            AutoPostBack="True" 
            >
            <asp:ListItem>-------Sắp xếp-------</asp:ListItem>
            <asp:ListItem Value="Tang">-Giá tăng dần-</asp:ListItem>
            <asp:ListItem Value="Giam">-Giá giảm dần-</asp:ListItem>
            <asp:ListItem Value="Moi">-Mới nhất-</asp:ListItem>
        </asp:DropDownList>
    <asp:TextBox ID="txtTimKiem" runat="server" Width="250px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Tìm" 
        onclick="Timkiem_Click" />
    </div>
    <asp:Panel ID="Panel1" runat="server">
    <asp:DataList ID="DataList1" runat="server" 
        RepeatColumns="3">
        <ItemTemplate>
        <div class="border">
        <div style="padding:10px; width:90%;">
            <div style="width:100%; height:40px;">
                <asp:Label ID="ParameterLabel" runat="server" Font-Bold="True" 
                Font-Size="Large" Font-Underline="True" ForeColor="#0066FF" 
                Text='<%# Eval("Parameter") %>' />
            </div>
            <div style="width:100%;height:190px;">
                <asp:ImageButton ID="ImageButton3" runat="server" ImageAlign="Middle" 
                    ImageUrl='<%# Eval("ImageURL") %>'
                    Width="90%" PostBackUrl='<%#"~/ComponentDetails.aspx?ComponentDetailsID="+ Eval("ComponentDetailsID") %>' />                      
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
                                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%#"~/ComponentDetails.aspx?ComponentDetailsID="+ Eval("ComponentDetailsID") %>'>Chi tiết&gt;&gt;</asp:LinkButton>
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = @ComponentName">
        <SelectParameters>
            <asp:QueryStringParameter Name="ComponentName" 
                QueryStringField="ComponentName" />
        </SelectParameters>
    </asp:SqlDataSource>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
            <div class="border">
            <div style="padding:10px; width:90%;">
            <div style="width:100%; height:40px;">
                <asp:Label ID="ParameterLabel" runat="server" Font-Bold="True" 
                Font-Size="Large" Font-Underline="True" ForeColor="#0066FF" 
                Text='<%# Eval("Parameter") %>' />
            </div>
            <div style="width:100%;height:190px;">
                <asp:ImageButton ID="ImageButton3" runat="server" ImageAlign="Middle" 
                    ImageUrl='<%# Eval("ImageURL") %>'
                    Width="90%" PostBackUrl='<%#"~/ComponentDetails.aspx?ComponentDetailsID="+ Eval("ComponentDetailsID") %>' />                      
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
                                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%#"~/ComponentDetails.aspx?ComponentDetailsID="+ Eval("ComponentDetailsID") %>'>Chi tiết&gt;&gt;</asp:LinkButton>
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
            SelectCommand="SELECT * FROM [tbComponentDetails]"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>

