<%@ Page Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true"
    CodeBehind="ChiTiet.aspx.cs" Inherits="DoAn4.WebForm3" Title="Chi tiết sản phẩm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 99%;
        }
        .style2
        {
            width: 127px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Con1" runat="server">
    <div class="daukhungmain">
        <asp:Label ID="lblTieuDe" runat="server" Font-Bold="False" Font-Names="Arial" 
            Font-Size="Large" ForeColor="#333333"></asp:Label>
    </div>
    <div style="width: 100%; height:314px">
        <div style="width: 225px; height: 300px; float: left; margin-left: 10px; border: thin solid green">
            <asp:Image ID="lblImage" runat="server" Height="300px" Width="225px" /></div>
        <div style="width: 356px; height: 300px; margin: 5px; float: right">
            <div style="font-family: Arial, Helvetica, sans-serif; width: 340px; margin-top: 10px;">
                <table class="style1">
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label1" runat="server" Text="Chủng loại:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblType_Name" runat="server" ForeColor="Black" Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label2" runat="server" Text="Phong cách:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td >
                            <asp:Label ID="lblStyle_Name" runat="server" ForeColor="Black" Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label3" runat="server" Text="Màu:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblColor" runat="server" ForeColor="Black" Font-Bold="False" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label5" runat="server" Text="Chất liệu:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td >
                            <asp:Label ID="lblMaterial" runat="server" ForeColor="Black" Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label6" runat="server" Text="Size:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblSize" runat="server" ForeColor="Black" Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label7" runat="server" Text="Giá:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td >
                            <asp:Label ID="lblPrice" runat="server" ForeColor="Red" Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" align="justify" valign="top">
                            <asp:Label ID="Label8" runat="server" Text="Số lượng:" Font-Bold="True" 
                                Font-Size="11pt"></asp:Label>
                        </td>
                        <td >
                            <asp:TextBox ID="txtTotal" runat="server" Height="19px" Width="35px"></asp:TextBox>
                            /&nbsp;
                            <asp:Label ID="lblSL" runat="server" ForeColor="Black" Font-Size="11pt"></asp:Label>&nbsp;
                            <asp:Label ID="Label9" runat="server" Text="Sản phẩm" Font-Size="11pt"></asp:Label>&nbsp;
                        
                        </td>
                        
                    </tr>
                    <tfoot>
                    <td colspan="2">
                    <asp:CustomValidator ID="CtvThongBao" runat="server" 
                                
                            ErrorMessage="Số lượng phải là số nguyên dương và nhỏ hơn số lượng sản phẩm hiện có!" ControlToValidate="txtTotal" 
                                ValidateEmptyText="True" Font-Size="10pt" 
                                onservervalidate="CtvThongBao_ServerValidate" Width="294px"></asp:CustomValidator>
                                </td>
                    </tfoot>
                </table>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Anh/muahang.jpg" Width="98"
                    Height="25" ImageAlign="Right" OnClick="ImageButton1_Click" />
                <asp:HiddenField ID="hdf" runat="server" />
            </div>
        </div>
    </div>
    <br /><br />
    &nbsp;
    <asp:Label ID="Label4" runat="server" Text="Các sản phẩm cùng loại" 
        Font-Bold="True" ForeColor="#FF6600"></asp:Label><br />
    <hr />
   <div style="margin:10px">
        <asp:DataList ID="sanpham" runat="server" HorizontalAlign="Center" 
        RepeatColumns="4" Width="100%" DataKeyField="Product_ID"  RepeatDirection="Horizontal">
        <ItemTemplate>
        <div style="width:121px; height:183px">
        <asp:ImageButton ID="ImageButton2" runat="server" Height="136px" Width="120px"
                        ImageUrl='<%# "~/AnhSanPham/"+Eval("Image") %>' 
                        
                PostBackUrl='<%# "Chitiet.aspx?Product_ID="+Eval("Product_ID") %>'/>
            <div class="dong">
                <asp:HyperLink ID="HyperLink3" runat="server" Font-Size="10pt" 
                    ForeColor="#333333" Text='<%# Eval("Product_Name") %>' 
                    NavigateUrl='<%# "Chitiet.aspx?Product_ID="+Eval("Product_ID") %>' Font-Underline="False"
                   ></asp:HyperLink>
             </div>
             <div class="dong">
                &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="#CC0000" 
                    Text='<%# Eval("Price_Export") %>' Font-Size="10pt"></asp:Label>
                <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" Text="VNĐ" 
                     Font-Size="10pt"></asp:Label>
            
                </div>
                </div>
                </ItemTemplate>
        </asp:DataList>
    </div>
    </asp:Content>
