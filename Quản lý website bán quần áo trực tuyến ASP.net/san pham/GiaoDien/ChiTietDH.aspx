<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="ChiTietDH.aspx.cs" Inherits="GiaoDien_ChiTietDH" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="margin:0 auto 10px 0px;">
    <div style="padding-left:5px; height:35px; font-size:20px; color:Maroon">
        Thông tin chi tiết hóa đơn    
    </div>
    <div style="height:25px;margin-left:130px; width: 607px; color:Blue;font-size:18px;">Mã hóa đơn: &nbsp;&nbsp;&nbsp;<asp:Label runat="server" ID="lblMaHD"></asp:Label></div>
      <div class="title-giua-top">
        Thông tin sản phẩm    
    </div>
     <div >
        <table border="1px" style="margin-left:130px" width="340px">
        <tr style="background-color:#CED7FB ; color: Black;">
            
            <td class="title-GH">Mã SP</td>
            <td class="title-GH">Tên SP</td>
            <td class="title-GH">Giá(VNĐ)</td>
            <td class="title-GH">Số lượng</td>
            <td class="title-GH">Thành tiền(VNĐ)</td>
            
        </tr>
    <asp:Repeater ID="rpt_CTHD" runat="server" >
            <ItemTemplate>
                <tr>        
                            
                            <td>
                             <asp:Label runat="server" id="lbID" Text='<%#Eval("ProductID") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" id="lbTensp" Text='<%# Eval("ProductName") %>'></asp:Label>
                            </td>
                            
                            <td>
                                <asp:Label runat="server" id="lbGia" Text='<%# Eval("Price") %> '></asp:Label>
                            </td>
                            <td>
                               <asp:Label runat="server" id="lbSL" Text='<%# Eval("Number")%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lbTong"></asp:Label>
                            </td>
                    
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </table>
        </div>
        <div style="margin:10px auto 5px 130px">
            <table >
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
    <div style="margin-left:130px">
    <asp:DataList runat="server" ID="dlTTKH" RepeatColumns="1" 
            onselectedindexchanged="dlTTKH_SelectedIndexChanged">
        <ItemTemplate>
            <table style="background-color:#f7f7f7;border:1px solid #ddd;" width="340px">
                <tr>
                    <td>Tên khách hàng</td>
                    <td><asp:Label runat="server" ID="lblTenKH" Text='<%#Eval("Name") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td><asp:Label runat="server" ID="lblEmaiKH" Text='<%#Eval("Email") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Địa chỉ</td>
                    <td><asp:Label runat="server" ID="lblDiaChiKH" Text='<%#Eval("Address") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Điện thoại khách hàng</td>
                    <td><asp:Label runat="server" ID="lblDTKH" Text='<%#Eval("Phone") %>'></asp:Label></td>
                </tr>
                
            </table>
        </ItemTemplate>
    </asp:DataList>
    </div>
    <div class="title-giua-top">
        Thông tin người nhận
    </div>
    <div style="margin:0 auto 10px 130px">
    <asp:DataList runat="server" ID="dlTTNguoiNhan" RepeatColumns="1">
        <ItemTemplate>
            <table style="background-color:#f7f7f7;border:1px solid #ddd" width="340px">
                <tr>
                    <td>Tên người nhận</td>
                    <td><asp:Label runat="server" ID="lblTenNN" Text='<%#Eval("RecipientName") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Email người nhận</td>
                    <td><asp:Label runat="server" ID="lblEmaiNN" Text='<%#Eval("Email") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Địa chỉ người nhận</td>
                    <td><asp:Label runat="server" ID="lblDiaChiNN" Text='<%#Eval("Address") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Điện thoại người nhận</td>
                    <td><asp:Label runat="server" ID="lblDTNN" Text='<%#Eval("Phone") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>Phương thức thanh toán</td>
                    <td><asp:Label runat="server" ID="Label1" Text='<%#Eval("PaymentName") %>'></asp:Label></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
   </div>
   <div>
        <table style="margin:0 auto 10px 130px">
            <tr>
                <td><asp:RadioButton runat ="server" ID="rdXLTC" Visible="false" GroupName="gender"  
                        Text="Xử lý thành công" AutoPostBack="True" 
                        oncheckedchanged="rdXLTC_CheckedChanged" /></td>
                <td><asp:RadioButton runat ="server" ID="rdHuyDH" Visible="false" GroupName="gender"
                        Text="Hủy đơn hàng" AutoPostBack="True" 
                        oncheckedchanged="rdHuyDH_CheckedChanged" /></td>
            </tr>
            <tr>
                <td><asp:Button runat="server" ID="btBack" Text="Trở về trang cũ" 
                        onclick="btBack_Click"/></td>
                <td><asp:Button runat="server" ID="btXuLy" Visible="false" Text="Xử lý đơn hàng" 
                        onclick="btXuLy_Click"/></td>
                <td><asp:Button runat="server" ID="btIn" Visible="false" Text="In đơn hàng"/></td>
            </tr>
        </table>
   </div>
</div>
</asp:Content>

