<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ComponentDetails.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ComponentDetailsID" 
        DataSourceID="SqlDataSource1">
        <ItemTemplate>
        <div class="border" style="width:750px;">
            <div style="padding:10px; width:90%;">
                <table>
                <tr>
                    <td rowspan="6" width="300px">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageURL") %>' 
                            Height="100%" Width="100%" />                                                   
                    </td>
                    <td style="margin-left:30px;">
                        <asp:Label ID="ParameterLabel" runat="server" Font-Bold="True" 
                        Font-Size="Large" Font-Underline="false" ForeColor="#0033CC" 
                        Text='<%# Eval("Parameter") %>' />
                    </td>                
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbPrice" runat="server" Text="Giá:" Font-Bold="true"></asp:Label>
                        <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' 
                            ForeColor="Red" />VNĐ            
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Hãng sản xuất:" Font-Bold="true"></asp:Label>
                        <asp:Label ID="ManufacturerLabel" runat="server" 
                        Text='<%# Eval("Manufacturer") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Bảo hành:" Font-Bold="true"></asp:Label>
                        <asp:Label ID="WarrantyLabel" runat="server" Text='<%# Eval("Warranty") %>' />        
                    </td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Trong kho:"></asp:Label> 
                    <asp:Label ID="lblKhoHang" runat="server" Text='<%# (Eval("Number").ToString()=="0")? "Hết hàng" : "Còn hàng" %>'  ></asp:Label>
                    </td>                                     
            </tr>
                <tr>
                    <td>
                        
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            ImageUrl="~/Image/iconMuaHang.gif" PostBackUrl="~/Cart.aspx" />                                                                        
                    </td>
                </tr>
                </table>            
            </div>
        </div>
        </ItemTemplate>
    </asp:DataList>
    <div style="height:10px;"></div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlTuKhoa" EventName="SelectedIndexChanged" />
         </Triggers>
    <ContentTemplate>
    <table style="width:auto;">                    
            <tr>
                <td style="float:left;height:10px;text-align:center;padding-top:5px;">
                <b>SẢN PHẨM CÙNG LOẠI </b>                                 
                &nbsp;</td> 
                <td style="padding-left:5px;">
                Tìm theo:<asp:DropDownList ID="ddlTuKhoa" runat="server" Width="120px" 
                        AutoPostBack="True" onselectedindexchanged="DDL1_SelectedIndexChanged">
                        <asp:ListItem Value="Manufacturer">Hãng sản xuất</asp:ListItem>
                        <asp:ListItem Value="Price">Giá</asp:ListItem>
                        <asp:ListItem Value="Warranty">Bảo hành</asp:ListItem>                        
                </asp:DropDownList>                
                </td>                               
            </tr>
    </table>
    <div style="height:10px;"></div>
    <asp:DataList ID="dlSPLienQuan" runat="server" RepeatColumns="3" onitemcommand="dlSPLienQuan_ItemCommand"         
        >
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
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
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
        SelectCommand="SELECT [ComponentDetailsID], [Parameter], [ImageURL], [Price],[Number],[Manufacturer], [Warranty] FROM [tbComponentDetails] WHERE ([ComponentDetailsID] = @ComponentDetailsID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ComponentDetailsID" 
                QueryStringField="ComponentDetailsID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <div style="height:25px ; width:736px; padding-left:10px; margin-bottom:10px; padding-top:7px; border:solid 1px Gray;  background-image:none;">
        Đây là trang thứ: 
        <asp:Label ID="lbBanTin" runat="server" Text="1" ForeColor="#CC0000"></asp:Label>
        &nbsp;trên tổng số 
        <asp:Label ID="lbSobantintrongtrang" runat="server"
            ForeColor="#CC0000"></asp:Label>&nbsp;trang&nbsp;&nbsp;&nbsp;&nbsp; Tổng số bản tin 
        là: <asp:Label ID="lbTongsobantin" runat="server" Text="lbTongsobantin" 
            ForeColor="#CC0000"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lkbPreview" runat="server" Font-Underline="False" 
            onclick="lkbPreview_Click">&lt;&lt;Trước</asp:LinkButton>
        &nbsp;&nbsp;<asp:LinkButton ID="lkbNext" runat="server" Font-Underline="False" 
            onclick="lkbNext_Click">Sau&gt;&gt;</asp:LinkButton>
    </div>
    </ContentTemplate> 
    </asp:UpdatePanel>    
</asp:Content>

