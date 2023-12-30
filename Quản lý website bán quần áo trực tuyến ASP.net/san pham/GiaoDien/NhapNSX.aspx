<%@ Page Language="C#" MasterPageFile="~/UserControl/Admin.master" AutoEventWireup="true" CodeFile="NhapNSX.aspx.cs" Inherits="GiaoDien_NhapNCC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script language="javascript" type="text/jscript">
function btnNhap_onclick()
{}
</script>
<div style="padding-left:150px;margin-top:10px;margin-bottom:10px;border:1px">
<h3>
NHẬP THÔNG TIN NHÀ SẢN XUẤT</h3>
</div>

    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td class="style3" style="text-align:right">
                Tên nhà sản xuất:&nbsp
                </td>
                <td class="style2">
                <asp:TextBox ID="txtTenNSX" runat="server" Height="22px" Width="200px"></asp:TextBox>
            </td>
            <td class="style10">
                <asp:RequiredFieldValidator ControlToValidate="txtTenNSX" ID="RequiredFieldValidator2" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align:right">
                Địa chỉ:&nbsp</td>
            <td class="style4">
                <asp:TextBox ID="txtDiachi" runat="server" Height="22px" Width="200px"></asp:TextBox>
                </td>
                <td class="style10">
                    <asp:RequiredFieldValidator ControlToValidate="txtDiachi" ID="RequiredFieldValidator1" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style5" style="text-align:right">
                Email:&nbsp</td>
            <td class="style6">
                <asp:TextBox ID="txtEmail" runat="server" Height="22px" Width="200px"></asp:TextBox> <br />
               <asp:Label ID="LB1" Text="Gợi ý: abc@gmail.com" runat="server"></asp:Label>
               
               
            </td>
            <td class="style10">
                <asp:RequiredFieldValidator ControlToValidate="txtEmail" ID="RequiredFieldValidator3" runat="server" ErrorMessage="(*)"></asp:RequiredFieldValidator><br />
                <asp:RegularExpressionValidator ControlToValidate="txtEmail" ID="refEmail" ErrorMessage="Bạn nhập không đúng định dạng Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server"></asp:RegularExpressionValidator>
            </td>
            
        </tr>
        <tr>
            <td class="style2" style="text-align:right">
                Logo:&nbsp</td>
            <td class="style9">
                <asp:FileUpload ID="FupLogo" runat="server" Height="21px" Width="212px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                </td>
            <td class="style8">
                <asp:Button ID="btnNhap" runat="server" Text="Nhập" Width="94px" 
                    Height="31px" onclick="btnNhap_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 79%;
            height: 165px;
        }
        .style2
        {
            width: 174px;
        }
        .style3
        {
            width: 174px;
            height: 31px;
        }
        .style4
        {
            height: 31px;
            width: 285px;
        }
        .style5
        {
            width: 174px;
            height: 32px;
        }
        .style6
        {
            height: 32px;
            width: 285px;
        }
        .style7
        {
            width: 174px;
            height: 27px;
        }
        .style8
        {
            height: 27px;
            width: 285px;
        }
        .style9
        {
            width: 285px;
        }
        .style10
        {
            width: 165px;
        }
    </style>

</asp:Content>

