<%@ Page Language="C#" MasterPageFile="~/UserControl/NguoiDung.master" AutoEventWireup="true" CodeFile="GioHang.aspx.cs" Inherits="GiaoDien_GioHang" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="khung-giua">
    <div class="title-giua-top"> Giỏ Hàng Của Bạn</div>
    <%--asp:Repeater runat ="server" ID="rptGH">
        
            <HeaderTemplate>
            <table border="1" cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="title1" style="width:20px"> STT</td>
                                          
                    
                        <td class="title1" > Mã sản phẩm</td>
                    
                        <td class="title1" >Tên sản phẩm </td>
                        <td class="title1" >Giá </td>
                    
                        <td class="title1">Số lượng</td>
                    
                        <td class="title1">Thành tiền </td>
                        <td></td>
                    </tr>
                    
                       
            </HeaderTemplate>
            <ItemTemplate>
                
                    <tr>
                        <td><asp:Label runat="server" ID="lblSTT" Text='<%#Eval("STT") %>'></asp:Label></td>
                       
                        <td><asp:Label runat="server" ID="lblMaSP" Text='<%#Eval("MaSP") %>'></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblTenSP" Text='<%#Eval("TenSP") %>'></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblGia" Text='<%#Eval("Gia") %>'></asp:Label></td>
                        <td><asp:TextBox runat="server" ID="txtSL" Text='1' ></asp:TextBox></td>
                        <td><asp:Label runat="server" ID="lblTongtien" Text='<%#Eval("Tong") %>'></asp:Label></td>
                    </tr>
            </ItemTemplate>
            <FooterTemplate>
           </table>
           </FooterTemplate>
        </asp:Repeater>
        <table>
            <tr>
                <td>Tổng tiền của các sản phẩm:</td>
                <td><asp:Label runat="server" ID="lblTongTien"></asp:Label>&nbsp VNĐ</td>
            </tr>
        </table>
        <div>--%>
<div>
        <table border="1px">
        <tr style="background-color:#CED7FB ; color: Black;">
            <td class="title-GH">Mã SP</td>
            <td class="title-GH">Tên SP</td>
            <td class="title-GH">Giá</td>
            <td class="title-GH">Số lượng</td>
            <td class="title-GH">Thành tiền</td>
            <td class="title-GH"></td>
        </tr>
        <asp:Repeater ID="rpt_giohang" runat="server" EnableViewState="true"  onitemcommand="rpt_giohang_ItemCommand">
            <ItemTemplate>
                <tr>
                            <td>
                             <asp:Label runat="server" id="lbID" Text='<%#Eval("ID") %>'></asp:Label>
                            </td>
                            <td>
                                <%# Eval("DisplayName") %>
                            </td>
                            
                            <td>
                                <%# Eval("Price") %>
                            </td>
                            <td>
                               <asp:TextBox runat="server" ID="txtSL" Text='<%# Eval("Quantity") %>'></asp:TextBox> 
                            </td>
                            <td>
                                <%# Eval("Total") %>
                            </td>
                    <td class="title-GH">
                        <asp:ImageButton runat="server" ID="imbDelete" CommandName="Xoa" CommandArgument='<%#Eval("ID") %>' ImageUrl="~/Image/Icon/1290571539_dialog-close.ico"/>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
    </div>
    <br />
    
    <div style="text-align:center;padding-right:10px;margin-bottom:5px; font-size:20px;">
        Tổng tiền của giỏ hàng:&nbsp;&nbsp;&nbsp;<asp:Label runat="server" ID="lbTongTien"></asp:Label>
    </div>
    
    <div style="margin:5px 0 0 0;text-align:center">
   <asp:Button runat="server" Text="Cập nhật" ID="btnCapNhat" CommandName="CapNhat" CommandArgument='<%#Eval("ID") %>'
            onclick="btnCapNhat_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button runat="server" Text="Tiếp tục mua hàng" ID="btnTiepTuc" 
            onclick="btnTiepTuc_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button runat="server" ID="btnThanhToan" Text="Thanh toán" 
            onclick="btnThanhToan_Click1" OnClientClick="javascript: return edit_confirm();" />
    </div>
</div>
</asp:Content>

