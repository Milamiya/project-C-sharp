<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThemmoiSP.aspx.cs" Inherits="GiaoDien_ThemmoiSP" %>

<%@ Register src="~/UserControl/Menungang.ascx" tagname="Menungang" tagprefix="uc1" %>

<%@ Register src="~/UserControl/MenuQuanTri.ascx" tagname="MenuQuanTri" tagprefix="uc2" %>

<%@ Register src="~/UserControl/Footer.ascx" tagname="Footer" tagprefix="uc3" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="../CSS/QuanTri.css" rel="Stylesheet" type="text/css"/>
    <link href="../CSS/Menu.css" rel="Stylesheet" type="text/css" />
    <link href="../CSS/ShopOnline.css" rel="Stylesheet" type="text/css"/>
    <style type="text/css">
        .style5
        {
            width: 170px;
            font-size: 16px;
            padding-left: 10px;
        }
        .style6
        {
            width: 26px;
            font-size: 16px;
            padding-left: 10px;
        }
        .style7
        {
            width: 170px;
            padding-left: 10px;
        }
        .style8
        {
            width: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 980px;">
        <div style="float:left;width:980px;">
            <uc1:Menungang ID="Menungang1" runat="server" />
         </div>
         <div style="float:left; width:200px;">
             <uc2:MenuQuanTri ID="MenuQuanTri1" runat="server" />
       </div>
       <div class="noidung">
            <div class="tieude">
                Thêm mới sản phẩm
            </div>
            <div class="khung-insert">
        <table>
            <tr>
                <td class="text">Mã sản phẩm:</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtMaSP" Width="150px"></asp:TextBox></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="rqvMaSP" ControlToValidate="txtMaSP" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td class="text">Size:</td>
                <td class="input-data"><asp:DropDownList runat="server" ID="ddlSize" Width="150px"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text">Tên sản phẩm:</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtTenSP" Width="150px"></asp:TextBox></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="rqvTenSP" ControlToValidate="txtTenSP" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td class="text">Tên hãng SX:</td>
                <td class="input-data"><asp:DropDownList runat="server" ID="ddlTenHSX" Width="150px"></asp:DropDownList></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="ddlTenHSX" ErrorMessage="*"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="text">Loại sản phẩm:</td>
                <td class="input-data"><asp:DropDownList runat="server" ID="ddlLoaiSP" 
                        Width="150px" onselectedindexchanged="ddlLoaiSP_SelectedIndexChanged"></asp:DropDownList></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="ddlLoaiSP" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <%--<td class="text">Tên NCC:</td>
                 <td class="input-data"><asp:DropDownList runat="server" ID="ddlNCC" Width="150px" ></asp:DropDownList></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="ddlNCC" ErrorMessage="*"></asp:RequiredFieldValidator></td>--%>
                <td class="text"> Màu sắc</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtMau" Width="150"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text">Số lượng:</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtSoLuong" Width="150px"></asp:TextBox></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtSoLuong" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td class="text">Mô tả:</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtMoTa" Width="150px"></asp:TextBox></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator6" ControlToValidate="txtMoTa" ErrorMessage="*"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="text">Hình ảnh:</td>
                <td class="input-data"><asp:FileUpload runat="server" ID="fuSP" /></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator7" ControlToValidate="fuSP" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                
               
                <td class="text">Hiển thị SP:</td>
                <td class="input-data"><asp:CheckBox runat="server" ID="ckHienThi" Checked="true" Text="Có" /></td>
            </tr>
            
            <tr>
                
                <td class="text">Giá bán:</td>
                <td class="input-data"><asp:TextBox runat="server" ID="txtGiaBan" Width="150px"></asp:TextBox></td>
                <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator8" ControlToValidate="txtGiaBan" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td class="text">Ngày nhập</td>
                <td class="input-data">
                    <asp:DropDownList runat="server" ID="ddlNgay" Width="50"></asp:DropDownList>
                    <asp:DropDownList runat="server" ID="ddlThang" Width="50"></asp:DropDownList>
                    <asp:DropDownList runat="server" ID="ddlNam" Width="70"></asp:DropDownList>
                </td>
                 <td style="width:10px"><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="ddlNgay" ErrorMessage="*"></asp:RequiredFieldValidator></td>   
            </tr>
        <%--    <tr>
                <td class="text">Ngày nhập: </td>
                <td class="inpu
            </tr>--%>
        </table>
        <div style="text-align:center"><asp:Button  runat="server" ID="btThemSP" 
                Text="Thêm mới" onclick="btThemSP_Click"/></div>
    </div>
    <%--</div>
    <uc3:Footer ID="Footer2" runat="server" />
    </div>--%>
    </div>
    </div>
    </form>
</body>
</html>
