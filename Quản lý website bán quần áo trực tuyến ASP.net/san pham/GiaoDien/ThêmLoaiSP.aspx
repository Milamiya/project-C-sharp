<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="ThêmLoaiSP.aspx.cs" Inherits="GiaoDien_ThêmLoaiSP" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnThemLoaiSP_onclick() {

}

// ]]>
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<div class="noidung">
            <div class="tieude">
                Quản lý loại sản phẩm
            </div>
            <div class="khung-insert">
        <table style="width:450px; margin:10px auto auto auto">
        
            
            <tr>
                <td class="text">Tên loại sản phẩm:</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtTenLoaiSP" Width="150px"></asp:TextBox> </td>
                <td>             
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenLoaiSP" ErrorMessage="Bạn phải nhập tên loại sản phẩm!"></asp:RequiredFieldValidator></td>
            </tr>
        </table>
        <div style="padding-left:350px"><asp:Button Text="Thêm mới" ID="btnThemLoaiSP" 
                runat="server" onclick="btnThemLoaiSP_Click" /></div>
    </div>
</div>
</div>
</asp:Content>

