<%@ Page Language="C#" MasterPageFile="~/admin/AdminMaster.master" AutoEventWireup="true" CodeFile="QuanTriNguoiDung.aspx.cs" Inherits="admin_QuanTriNguoiDung" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align="right">
        <table cellpadding="2" cellspacing="1" border="0" align="center" 
        style="background-color: #93DCFF" width="100%">
            <tr>
                <td colspan="2" align="center" 
                    style="font-weight: bold; color: #FFFFFF; background-color: #006699">
                    Quản trị người dùng</td>
            </tr>
            <tr>
                <td class="style9">
                    Tên đăng nhập:
                </td>
                <td class="style8" align="left">
                    <asp:TextBox ID="txtTenDN" runat="server" Width="200px"></asp:TextBox>
                    <asp:HiddenField ID="hidAction" runat="server" />
                    <asp:HiddenField ID="hidUser" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style9">
                    Mật khẩu
                </td>
                <td class="style8" align="left">
                    <asp:TextBox ID="txtMatKhau" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    Phân quyền
                </td>
                <td class="style8" align="left">
                    <asp:DropDownList ID="dropPhanQuyenEdit" runat="server" Width="200px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    Họ tên:
                </td>
                <td class="style8" align="left">
                    <asp:TextBox ID="txtHoTen" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    Email:
                </td>
                <td class="style8" align="left" width="200px">
                    <asp:TextBox ID="txtMail" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    Trạng thái
                </td>
                <td class="style8" align="left">
                    <asp:RadioButton ID="rdOn" runat="server" GroupName="Status" Text="Hoạt Động" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdOff" runat="server" GroupName="Status" Text="Khóa" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="background-color: #FFF;">
                    &nbsp;
                    <asp:LinkButton ID="lbtThem" runat="server" onclick="lbtThem_Click">
                <img src="Images/User.png" border="0"/><b>Thêm Mới</b>
                    </asp:LinkButton>
                    &nbsp;|
                   &nbsp;<asp:LinkButton ID="lbtLuu" runat="server" onclick="lbtLuu_Click"> <img src="Images/DiaMem.png" border="0" /><b>Lưu</b></asp:LinkButton>
                    &nbsp;
                    | 
                    <asp:LinkButton ID="lbtSua" runat="server" onclick="lbtSua_Click"> <img src="Images/DiaMem.png" border="0" /><b>Sửa</b></asp:LinkButton>
                    | 
                    <asp:LinkButton ID="lbtXoa" runat="server" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa không');" onclick="lbtXoa_Click"> <img src="Images/DiaMem.png" border="0" /><b>Xóa</b></asp:LinkButton></td>
            </tr>
            <tr>
                <td class="style7" colspan="2" style="background-color: #FFF;">
                    &nbsp; &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7" colspan="2" id="TableGrid"  style="background-color: #FFF;">
                    <asp:Panel ID="pnDanhSach" runat="server">
                        <asp:GridView ID="grvDanhSachUS" runat="server" AutoGenerateColumns="False" 
                            Width="100%" onselectedindexchanging="grvDanhSachUS_SelectedIndexChanging">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                        <asp:CheckBox ID="ckCheck" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Tên Đăng Nhập" SortExpression="Username">
                                    <ItemTemplate>
                                        <asp:Label ID="lblUserName" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="RoLeName" HeaderText="Quyền" 
                                    SortExpression="RoleName" />
                                <asp:BoundField DataField="Numlog" HeaderText="Lần Đăng Nhập" 
                                    SortExpression="Numlog" />
                                <asp:BoundField DataField="TrangThai" HeaderText="Trạng Thái" 
                                    SortExpression="TrangThai" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
            </table>
    </div>
</asp:Content>

