<%@ Page Language="C#" MasterPageFile="~/UserControl/NguoiDung.master" AutoEventWireup="true" CodeFile="ThongTinDatHang.aspx.cs" Inherits="GiaoDien_ThongTinDatHang" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="khung-giua">
 <div class="title-giua-top">Chi tiết đặt hàng  </div>
<div>
    <div>
        <table border="1px">
        <tr style="background-color:#CED7FB ; color: Black;">
            <td class="title-GH">Mã SP</td>
            <td class="title-GH">Tên SP</td>
            <td class="title-GH">Giá</td>
            <td class="title-GH">Số lượng</td>
            <td class="title-GH">Thành tiền</td>
            
        </tr>
    <asp:Repeater ID="rpt_TTGH" runat="server" >
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
                               <%# Eval("Quantity") %>
                            </td>
                            <td>
                                <%# Eval("Total") %>
                            </td>
                    
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
        </div>
        <br />
        <div>
            <table>
                <tr>
                    <td>Số lượng sản phẩm:</td>
                    <td><asp:Label runat="server" ID="lbTongSL"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        Tổng tiền phải trả:
                    </td>
                    <td><asp:Label runat="server" ID="lbTongTien"></asp:Label></td>
                </tr>
            </table>
        </div>
    <div class="title-giua-top">
        Thông tin khách hàng    
    </div>
    <asp:DataList runat="server" ID="dlTTKH" RepeatColumns="1">
        <ItemTemplate>
            <table style="background-color:#f7f7f7;border:1px solid #ddd">
                <tr>
                    <td>Tên khách hàng</td>
                    <td><asp:Label runat="server" ID="lblTenKH" Text='<%#Eval("Name") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td><asp:Label runat="server" ID="lblEmai" Text='<%#Eval("Email") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Địa chỉ</td>
                    <td><asp:Label runat="server" ID="lblDiaChi" Text='<%#Eval("Address") %>'></asp:Label></td>
                </tr>
                
            </table>
        </ItemTemplate>
    </asp:DataList>
    
     <div class="title-giua-top">
        Thông tin người nhận
    </div>
    <table>
        <tr>
            <td>Tên người nhận</td>
            <td><asp:TextBox runat="server" ID="txtTenNN"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Địa chỉ người nhận</td>
            <td><asp:TextBox runat="server" ID="txtDCNN"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Số điện thoại</td>
            <td><asp:TextBox runat="server" ID="txtSDTNN"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email người nhận</td>
            <td><asp:TextBox runat="server" ID="txtEmailNN"></asp:TextBox></td>
        </tr>
    </table>
    <div class="title-giua-top">
        Hình thức thanh toán
     </div>
    <table>
        <tr>
            <td><asp:RadioButton runat="server" ID="rdTTTT" GroupName="gender" Text="Thanh toán trực tiếp"/></td>
        </tr>
        <tr>
            <td><asp:RadioButton runat="server" ID="rdTTQuaThe" GroupName="gender" Text="Thanh toán qua tài khoản ngân lượng"/></td>
        </tr>
    </table>
    <br />
    <br />
    <div style="text-align:center">
        <asp:Button runat ="server" ID="btnTroVe" Text="Trở về trang cũ" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" ID="btnTiepTuc" Text="Tiếp tục thanh toán" 
            onclick="btnTiepTuc_Click" />
    </div>
</div>
</div>
</asp:Content>

