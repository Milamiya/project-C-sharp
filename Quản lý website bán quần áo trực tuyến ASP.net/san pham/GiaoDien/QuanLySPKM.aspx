<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="QuanLySPKM.aspx.cs" Inherits="GiaoDien_QuanLySPKM" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
    <div class="title-giua-top" style=" height:30px; font-size:20px;color:Maroon">Sản phẩm khuyến mại</div>
    <div style="margin:2px auto 10px 200px; width:400px">
        <table style="border:1 thin #0000ff; width:400px">
            <tr>
                <td class="dong">
                    Mã hàng khuyến mại:
                </td>
                <td class="dong">
                    <asp:TextBox runat="server" ID="txtMaKM" Width="200px" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="dong">
                    Sản phẩm khuyến mại:
                </td>
                <td class="dong">
                    <asp:DropDownList runat="server" ID="ddlSP" Width="200px" Height="25px"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="dong">
                    Ngày bắt đầu khuyến mại:
                </td>
                <td class="dong">
                    <asp:TextBox runat="server" ID="txtNgayBDKM" Width="200px" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="dong">
                   Ngày kết thúc khuyến mại :
                </td>
                <td class="dong">
                    <asp:TextBox runat="server" ID="txtNgayKTKM" Width="200px" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="dong">
                   Chiết khấu :
                </td>
                <td class="dong">
                    <asp:TextBox runat="server" ID="txtChietKhau" Width="200px" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="dong">
                    Số lượng khuyến mại:
                </td>
                <td class="dong">
                    <asp:TextBox runat="server" ID="txtSLKM" Width="200px" Height="25px"></asp:TextBox>
                </td>
            </tr>
        </table>
        </div>
        <div style="margin:auto 5px 10px 350px">
            <table>
                <tr>
                    <td><asp:Button runat="server" ID="btThem" Text="Thêm"/></td>
                    <td><asp:Button runat="server" ID="btSua" Text="Sửa"/></td>
                    <td><asp:Button runat="server" ID="btXoa" Text="Xóa"/></td>
                </tr>
            </table>
        </div>
</div>
</asp:Content>

