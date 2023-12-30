<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ThongtinHD.aspx.cs" Inherits="DoAn4.Admin.WebForm21" Title="Thông tin hoá đơn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            text-align: center;
        }
        .style3
        {
            width: 97%;
            height: 474px;
        }
        .style4
        {
            text-align: right;
            font-size: small;
            font-weight: normal;
        }
        .style5
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style2">
        THÔNG TIN HOÁ ĐƠN<hr width="60%" />
        <table cellpadding="2" cellspacing="2" class="style3" 
            style="font-weight: bold; font-size: small;">
            <tr>
                <td class="style4" width="50%">
                    Mã hoá đơn:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label1" runat="server" 
                        style="font-weight: 700; font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4" width="45%">
                    Tài khoản:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4" width="45%">
                    Ngày đặt hàng:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4" width="45%">
                    Hình thức thanh toán:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4" width="45%">
                    Hình thức vận chuyển:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Tên người nhận:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Địa chỉ người nhận:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Số điện thoại người nhận:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Tên người thanh toán:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Địa chỉ người thanh toán:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Số điện thoại người thanh toán:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Lời nhắn:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Phí gói quà:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Tổng trọng lượng:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Phí vận chuyển:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Tổng tiền:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Trạng thái:</td>
                <td class="style5">
&nbsp;
                    <asp:Label ID="Label17" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Quay lại" />
    </div>
</asp:Content>
