<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="ThemQuanTri.aspx.cs" Inherits="GiaoDien_ThemQuanTri" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="content">
    <div>Thêm người quản trị</div>
    <div class="khung-insert">
       <table>
          <tr>
             <td class="text">Tên đăng nhập:</td>
             <td class="input-data"><asp:TextBox runat="server" ID="txtTenDN"></asp:TextBox></td>
          </tr>
           <tr>
             <td class="text">Mật khẩu:</td>
             <td class="input-data"><asp:TextBox runat="server" ID="txtMatKhau"></asp:TextBox></td>
          </tr>
           <tr>
             <td class="text">Quyền:</td>
             <td class="input-data"><asp:DropDownList runat="server" ID="drlQuyen"></asp:DropDownList></td>
          </tr>
          <tr style="text-align:center">
             <td colspan="2"><asp:Button runat="server" ID="btnThem" Text="Thêm" 
                     onclick="btnThem_Click" /></td>
          </tr>
       </table>
    </div>
</div>
</asp:Content>

